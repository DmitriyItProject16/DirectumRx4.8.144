using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace DirRX.SignPlatform.Server
{
  public class ModuleFunctions
  {
    #region Истечение срока сертификатов пользователей
    /// <summary>
    /// Рассылка задач на перевыпуск облачных сертификатов.
    /// </summary>
    public void CloudCertificatesReissueTasks()
    {
      bool sendResult = false;
      var previousRun = GetLastCloudCertificatesReissueTasksDate();
      var currentRun = Calendar.Now;
      
      try
      {
        var expiringCloudCertificates = this.GetExpiringCloudCertificates(previousRun, currentRun);
        sendResult = this.TrySendCertificateIssueTask(expiringCloudCertificates);
      }
      finally
      {
        if (sendResult)
          UpdateLastCloudCertificatesReissueTasksDate(currentRun);
        else
          Logger.Debug("Jobs CloudCertificatesReissueTasks: Last check date of cloud certificates reissue hasn't been changed");
      }
      
    }

    /// <summary>
    /// Получить дату последней отправки задач на перевыпуск облачных сертификатов.
    /// </summary>
    /// <returns>Дата последней отправки задач.</returns>
    public static DateTime GetLastCloudCertificatesReissueTasksDate()
    {
      try
      {
        var settings = EssPlatform.PublicFunctions.EssSetting.GetSettings();
        var daysToWarningCertificate = settings.DaysToWarnCert ?? DirRX.EssPlatform.PublicConstants.Module.DefaultDaysToWarningCertificate;
        var result = Sungero.Docflow.PublicFunctions.Module.Remote.GetDocflowParamsStringValue(Constants.Module.LastTaskOfCloudCertificatesExpiration);
        Logger.DebugFormat("Jobs CloudCertificatesReissueTasks: Last notification date of cloud certificates reissue in DB is {0} (UTC)", result);
        if (result == null)
          return Calendar.Today.AddDays(Convert.ToDouble(-daysToWarningCertificate));
        return Calendar.FromUtcTime(DateTime.Parse(result, null, System.Globalization.DateTimeStyles.AdjustToUniversal));
      }
      catch (Exception ex)
      {
        Logger.Error(DirRX.SignPlatform.Resources.ErrorTryGetLastCloudCertificatesExpirationTaskDate, ex);
        throw new Exception(DirRX.SignPlatform.Resources.ErrorTryGetLastCloudCertificatesExpirationTaskDate, ex);
      }
    }
    
    /// <summary>
    /// Получить сертификаты, срок действия которых истекает.
    /// </summary>
    /// <param name="previousRun">Предыдущий запуск.</param>
    /// <param name="notificationDate">Текущий запуск.</param>
    /// <returns>Сертификаты, по которым будет выполнена рассылка.</returns>
    public virtual List<Sungero.CoreEntities.ICertificate> GetExpiringCloudCertificates(DateTime previousRun, DateTime currentRun)
    {
      var settings = EssPlatform.PublicFunctions.EssSetting.GetSettings();
      var daysToWarningCertificate = settings.DaysToWarnCert ?? DirRX.EssPlatform.PublicConstants.Module.DefaultDaysToWarningCertificate;
      return Sungero.CoreEntities.Certificates.GetAll(c => c.NotAfter != null &&
                                                      c.Enabled != null && c.Enabled.Value == true &&
                                                      previousRun <= c.NotAfter.Value.AddDays(Convert.ToDouble(-daysToWarningCertificate)) &&
                                                      currentRun > c.NotAfter.Value.AddDays(Convert.ToDouble(-daysToWarningCertificate)) &&
                                                      c.PluginId == Constants.Module.PluginIdOfCloudCertificates).ToList();
    }
    
    /// <summary>
    /// Запустить новый выпуск, если истекает срока действия облачных сертификатов.
    /// </summary>
    /// <param name="certificates">Сертификаты, по которым будет выполнен выпуск.</param>
    /// <returns>True, если нет ошибок или хотя бы один выпуск сертификата был стартован, иначе - false.</returns>
    public bool TrySendCertificateIssueTask(List<Sungero.CoreEntities.ICertificate> certificates)
    {
      Logger.Debug("Jobs CloudCertificatesReissueTasks: Checking cloud certificates");
      var hasErrors = false;
      var anyIssueCreate = false;
      
      foreach (var certificate in certificates)
      {
        try
        {
          var employee = EssPlatformSolution.Employees.As(certificate.Owner);
          if (employee == null)
            continue;

          if(employee.Status != Sungero.CoreEntities.DatabookEntry.Status.Closed)
          {
            var author = EssPlatformSolution.Employees.GetAll(e => Equals(e.BusinessUnitDirRX, employee.BusinessUnitDirRX) && e.Status == Sungero.Company.Employee.Status.Active)
              .Select(s => Sungero.CoreEntities.Users.As(s)).ToList()
              .Where(u => u.IncludedIn(DirRX.EssPlatform.PublicConstants.Module.AdminElEmployeeInteractionSystem))
              .FirstOrDefault();
            var providerId = CertificateRequests.GetAll(cr => cr.CertificateID == certificate.Id).Select(pid => pid.ProviderId).FirstOrDefault();
            var errors = IssueCertificate(employee, author, providerId);
            if(!string.IsNullOrEmpty(errors))
            {
              hasErrors = true;
              Logger.Error(String.Format("Jobs CloudCertificatesReissueTasks: Error while issue certificate about cloud certificates expiration {0}", errors));
            }
            else
              anyIssueCreate = true;
          }
        }
        catch (Exception ex)
        {
          hasErrors = true;
          Logger.Error("Jobs CloudCertificatesReissueTasks: Error while issue certificate date about cloud certificates expiration", ex);
        }
      }
      
      if (!certificates.Any())
        Logger.Debug("Jobs CloudCertificatesReissueTasks: No expiring cloud certificates for issue certificate");
      else if (!anyIssueCreate && !hasErrors)
        Logger.Debug("Jobs CloudCertificatesReissueTasks: No employees for expiring cloud certificates for issue certificate");
      
      return anyIssueCreate || !hasErrors;
    }

    /// <summary>
    /// Обновить дату последней рассылки уведомлений об истечении срока действия облачных сертификатов.
    /// </summary>
    /// <param name="notificationDate">Дата рассылки уведомлений.</param>
    public static void UpdateLastCloudCertificatesReissueTasksDate(DateTime notificationDate)
    {
      var newDate = notificationDate.Add(-Calendar.UtcOffset).ToString("yyyy-MM-ddTHH:mm:ss.ffff+0");
      Sungero.Docflow.PublicFunctions.Module.InsertOrUpdateDocflowParam(Constants.Module.LastTaskOfCloudCertificatesExpiration, newDate);
      Logger.DebugFormat("Jobs CloudCertificatesReissueTasks: Last notification date of cloud certificates expiration is set to {0} (UTC)", newDate);
    }
    #endregion
    
    #region Функции для использования в перекрытых справочников
    /// <summary>
    /// Выпустить сертификат сотруднику.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="author">Автор.</param>
    /// <param name="providerId">Id провайдера.</param>
    /// <returns>Ошибки, если есть.</returns>
    [Public, Remote]
    public virtual string IssueCertificate(EssPlatformSolution.IEmployee employee, IUser author, string providerId)
    {
      // Получаем ИД запроса на выпуск сертификата.
      var response = SendCertificateIssueRequest(employee, providerId);
      if (!string.IsNullOrEmpty(response.Error))
        return response.Error;
      var person = DirRX.EssPlatformSolution.People.Get(employee.Person.Id);
      // Стартуем задачу на выпуск сертификата.
      var task = SignPlatform.CertificateIssueTasks.Create();
      task.Author = author;
      task.Employee = employee;
      task.RequestId = response.RequestId;
      task.IdentificationType = person.IdentificationTypeDirRx;
      task.ProviderId = providerId;
      task.Start();
      return string.Empty;
    }
    
    /// <summary>
    /// Выпустить сертификат сотруднику.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="author">Автор.</param>
    /// <param name="providerId">Id провайдера.</param>
    /// <returns>Ошибки, если есть.</returns>
    [Public, Remote]
    public virtual string IssueCertificate(EssPlatformSolution.IEmployee employee, IUser author, string providerId, DirRX.SignPlatform.ICertificateIssueTask fromTask)
    {
      // Получаем ИД запроса на выпуск сертификата.
      var response = SendCertificateIssueRequest(employee, providerId);
      if (!string.IsNullOrEmpty(response.Error))
        return response.Error;
      var person = DirRX.EssPlatformSolution.People.Get(employee.Person.Id);
      // Стартуем задачу на выпуск сертификата.
      var task = SignPlatform.CertificateIssueTasks.Create();
      task.Author = author;
      task.Employee = employee;
      task.RequestId = response.RequestId;
      task.IdentificationType = person.IdentificationTypeDirRx;
      task.ProviderId = providerId;
      if (fromTask != null && fromTask.MonitoringTask != null)
        task.MonitoringTask = fromTask.MonitoringTask;
      task.Start();
      return string.Empty;
    }
    
    /// <summary>
    /// Валидировать обязательные поля карточки Персоны.
    /// </summary>
    /// <param name="basePerson">Персона.</param>
    /// <returns>Список ошибок валидации.</returns>
    [Public, Remote]
    public virtual List<string> ValidatePersonRequiredFields(Sungero.Parties.IPerson basePerson)
    {
      var errors = new List<string>();
      
      var person = EssPlatformSolution.People.GetAll(currentPerson => Equals(currentPerson.Id, basePerson.Id)).First();
      
      // Проверить, что в карточке Персоны заполнен "Документ, удостоверяющий личность"
      if (person.IdentityDocumentKind == null)
      {
        errors.Add(SignPlatform.Resources.IdentityDocumentKindRequired);
      }
      
      // Проверить, что в карточке Персоны заполнен "ИНН"
      if (string.IsNullOrWhiteSpace(person.TIN))
      {
        errors.Add(SignPlatform.Resources.TinRequired);
      }
      
      // Проверить, что в карточке Персоны заполнен "СНИЛС"
      if (string.IsNullOrWhiteSpace(person.INILA))
      {
        errors.Add(SignPlatform.Resources.InilaRequired);
      }
      
      // Проверить, что в карточке Персоны заполнена "Дата рождения"
      if (person.DateOfBirth == null)
      {
        errors.Add(SignPlatform.Resources.DateOfBirthRequired);
      }
      
      // Проверить, что в карточке Персоны заполнен "Пол"
      if (person.Sex == null)
      {
        errors.Add(SignPlatform.Resources.GenderError);
      }
      
      return errors;
    }
    
    /// <summary>
    /// Валидировать обязательные поля на карточке Сотрудника.
    /// </summary>
    [Public, Remote]
    public virtual List<string> ValidateEmployeeRequiredFields(EssPlatformSolution.IEmployee employee)
    {
      var errors = new List<string>();
      
      // Проверить, что в карточке Сотрудника заполнен "Личный телефон"
      if (string.IsNullOrEmpty(employee.PersonalPhoneDirRX))
      {
        errors.Add(EssPlatformSolution.Employees.Resources.PersonalPhoneRequired);
      }
      
      return errors;
    }
    
    /// <summary>
    /// Завершить задания на выпуск сертификата у сотрудника, если сотрудник и все замещающие закрыты
    /// </summary>
    /// <param name="employee">Сотрудник</param>
    [Public]
    public virtual void AbortCertificateIssueTask(EssPlatformSolution.IEmployee employee)
    {
      var activeEmployees = EssPlatformSolution.Employees.GetAll(em => em.Person.Equals(employee.Person) && em.Status == Sungero.Company.Employee.Status.Active);
      if(!activeEmployees.Any())
      {
        var employees = EssPlatformSolution.Employees.GetAll(em => em.Person.Equals(employee.Person));
        var certTasksIds = Enumerable.Empty<long>().AsQueryable();
        AccessRights.AllowRead(
          () =>
          {
            certTasksIds = SignPlatform.CertificateIssueTasks.GetAll(c => employees.Contains(c.Employee) &&
                                                                     (c.Status.Equals(DirRX.SignPlatform.CertificateIssueTask.Status.InProcess) ||
                                                                      c.Status.Equals(DirRX.SignPlatform.CertificateIssueTask.Status.UnderReview))).Select(a => a.Id);
          });
        if (certTasksIds.Any())
        {
          var abortIssueTask = DirRX.SignPlatform.AsyncHandlers.AbortIssueTask.Create();
          abortIssueTask.TaskIds = string.Join(",", certTasksIds);
          abortIssueTask.ExecuteAsync();
        }
      }
    }
    
    /// <summary>
    /// Проверить есть ли у сотрудника доступные сертификаты или задачи на выпуск сертификата в процессе
    /// </summary>
    /// <param name="employee">Сотрудник</param>
    /// <returns>Наличие доступного сертификата либо задачи на выпуск сертификата в процессе</returns>
    [Public, Remote]
    public virtual bool HasEmployeeCertificateOrIssueTask(EssPlatformSolution.IEmployee employee)
    {
      var hasCertificate = Sungero.CoreEntities.Certificates.GetAll(c => c.Owner.Equals(Users.As(employee))
                                                                    && c.PluginId.ToLower().Equals(SignPlatform.PublicConstants.Module.PluginIdOfCloudCertificates)
                                                                    && c.Enabled == true).Any();
      var hasCertificateIssueTask = CertificateIssueTasks.GetAll(t => t.Employee.Equals(employee) && t.Status == Sungero.Workflow.Task.Status.InProcess).Any();
      if(hasCertificate == true || hasCertificateIssueTask == true)
        return true;
      return false;
    }
    #endregion
    
    #region Функции отправки запросов к SignService

    /// <summary>
    /// Отправить подтверждение на выпуск сертификата - /CertificateIssues/{requestId}/confirmation-request
    /// </summary>
    /// <param name="requestId">Id (на сервисе подписания) заявки на выпуск сертификата.</param>
    /// <param name="identificationType">Тип идентификации.</param>
    /// <param name="phone">Телефон.</param>
    /// <param name="providerId">Id провайдера.</param>
    /// <returns>Ответ на запрос. Коды ответов соответствуют константам SignServiceResponseCodes</returns>
    [Public, Remote]
    public static string SendCertificateIssueConfirmation(long requestId, string identificationType, string phone, string providerId)
    {
      Logger.DebugFormat("CertificateIssue. SendCertificateIssueConfirmation(). requestId={0} identificationType={1} phone={2}", requestId, identificationType, phone);
      // подготовить запрос
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var requestApi = string.Format(Constants.Module.RequestApiSignService.ConfirmationRequest, providerId, requestId);
      var result = SignPlatform.Structures.Module.HttpRequestErrorResult.Create();
      try
      {
        // собрать структуру для json-тела запроса
        var confirmationStruncture = Structures.Module.CertificateConfirmationRequest.Create();
        confirmationStruncture.identificationType = identificationType;
        confirmationStruncture.phoneNumber = phone;
        var json = EssPlatform.PublicFunctions.Module.SerializedToJson(confirmationStruncture);
        // получить токен
        var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
        // выполнить запрос
        var response = EssPlatform.PublicFunctions.Module.Remote.RunPostRequest(baseUri, requestApi, json, token);
        Logger.DebugFormat("CertificateIssue. SendCertificateIssueConfirmation(). requestId={0} apiurl='{1}' response.StatusCode={2}", requestId, requestApi, response.StatusCode);
        
        if (response.StatusCode == (int)HttpStatusCode.OK)
        {
          #region корректное выполнение запроса
          result.Code = SignPlatform.Constants.Module.SignServiceResponseCodes.Success;
          return EssPlatform.PublicFunctions.Module.SerializedToJson(result);
          #endregion
        }
        else if (response.StatusCode == Constants.Module.HttpStatusCodeTooManyRequests)
        {
          result = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
          result.Code = SignPlatform.Constants.Module.SignServiceResponseCodes.ConfirmationRetryTooFastException;
          return EssPlatform.PublicFunctions.Module.SerializedToJson(result);
        }
        else
        {
          #region Запрос /confirmation-request выдал какую-то ошибку - обработать её
          var responseError = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
          Logger.DebugFormat("CertificateIssue. SendCertificateIssueConfirmation(). requestId={0} apiurl='{1}' response.StatusCode={2} responseError.Code={3} responseError.Message={4}",
                             requestId, requestApi, response.StatusCode, responseError.Code, responseError.Message);
          result.Code = responseError.Code;
          return EssPlatform.PublicFunctions.Module.SerializedToJson(result);
          #endregion
        }
      }
      // перехватить ошибку "хост не найдет", которая будет признаком того, что пропал канал связи с сервисом
      catch (System.AggregateException ex)
      {
        #region catch
        if(ex.InnerException.GetType() == typeof(System.Net.Http.HttpRequestException))
        {
          Logger.DebugFormat("CertificateIssue. SendCertificateIssueConfirmation(). requestId={0} host {1} not found", requestId, baseUri);
          result.Code = Constants.Module.SignServiceResponseCodes.HostNotFound;
          return EssPlatform.PublicFunctions.Module.SerializedToJson(result);
        }
        else
        {
          throw ex;
        }
        #endregion
      }
    }

    /// <summary>
    /// Получить информацию о причинах отзыва сертификата
    /// </summary>
    /// <returns>Причины отзыва</returns>
    [Public]
    public virtual System.Collections.Generic.Dictionary<string, string> GetRevocationReasons()
    {
      var revocationReasons = new Dictionary<string, string>();

      revocationReasons.Add("CRL_REASON_UNSPECIFIED", DirRX.SignPlatform.Resources.CRL_REASON_UNSPECIFIED);
      revocationReasons.Add("CRL_REASON_KEY_COMPROMISE", DirRX.SignPlatform.Resources.CRL_REASON_KEY_COMPROMISE);
      revocationReasons.Add("CRL_REASON_CA_COMPROMISE", DirRX.SignPlatform.Resources.CRL_REASON_CA_COMPROMISE);
      revocationReasons.Add("CRL_REASON_AFFILIATION_CHANGED", DirRX.SignPlatform.Resources.CRL_REASON_AFFILIATION_CHANGED);
      revocationReasons.Add("CRL_REASON_SUPERSEDED", DirRX.SignPlatform.Resources.CRL_REASON_SUPERSEDED);
      revocationReasons.Add("CRL_REASON_CESSATION_OF_OPERATION", DirRX.SignPlatform.Resources.CRL_REASON_CESSATION_OF_OPERATION);
      
      return revocationReasons;
    }
    
    /// <summary>
    /// Деактивация всех сертификатов сотрудника по отпечатку сертификата
    /// </summary>
    /// <param name="thumbprint">Отпечаток сертификата</param>
    /// <returns>Список ошибок</returns>
    [Public, Remote]
    public virtual List<string> SetDisableEmployeeCertificates(string thumbprint)
    {
      var errors = new List<string>();
      Logger.DebugFormat("Certificate. SetDesableEmployeeCertificates(). thumbprint={0}", thumbprint);
      
      // все активные сертификаты сотрудника по отпечатку
      var emplCertsList = Sungero.CoreEntities.Certificates.GetAll(w => w.Thumbprint.ToLower() == thumbprint.ToLower() && w.Enabled == true);
      
      foreach(var item in emplCertsList)
      {
        
        try
        {
          item.Enabled = false;
          item.Save();
        }
        catch
        {
          var errStr = string.Format("Error certificate disable. Employee Id = {1}. Employee = {0}, Thumbprint = {2}", item.DisplayValue, item.Id, item.Thumbprint);
          Logger.DebugFormat(errStr);
          errors.Add(errStr);
        }
      }
      return errors;
    }
    
    /// <summary>
    /// Отправить подтверждение на отзыв сертификата - /Certificate/revocation
    /// </summary>
    /// <param name="thumbprint">Отпечаток сертификата</param>
    /// <param name="revocationReason">Причина</param>
    /// <returns></returns>
    [Public, Remote]
    public static string SendRevokeCertificate(string thumbprint, string revocationReason, string providerId)
    {
      Logger.DebugFormat("Certificate. SendRevokeCertificate(). thumbprint={0}, revocationReason={1}", thumbprint, revocationReason);
      // подготовить запрос
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var requestApi = string.Format(Constants.Module.RequestApiSignService.RevocationRequest, providerId);
      try
      {
        // собрать структуру для json-тела запроса
        var revokeStruncture = Structures.Module.RevokeCertificateRequest.Create();
        revokeStruncture.Thumbprint = thumbprint;
        revokeStruncture.RevocationReason = revocationReason;
        var json = EssPlatform.PublicFunctions.Module.SerializedToJson(revokeStruncture);
        // получить токен
        var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
        // выполнить запрос
        var response = EssPlatform.PublicFunctions.Module.Remote.RunPostRequest(baseUri, requestApi, json, token);
        Logger.DebugFormat("Certificate. SendRevokeCertificate(). ApiURL='{0}' response.StatusCode={1}", requestApi, response.StatusCode);
        
        if (response.StatusCode == (int)HttpStatusCode.OK)
        {
          return string.Empty;
        }
        else
        {
          var responseError = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
          Logger.DebugFormat("Certificate. SendRevokeCertificate(). ApiURL='{0}' response.StatusCode={1} responseError.Code={2} responseError.Message={3}", requestApi, response.StatusCode, responseError.Code, responseError.Message);
          return responseError.Code;
        }
      }
      // перехватить ошибку "хост не найдет", которая будет признаком того, что пропал канал связи с сервисом
      catch (System.AggregateException ex)
      {
        #region catch
        if(ex.InnerException.GetType() == typeof(System.Net.Http.HttpRequestException))
        {
          Logger.DebugFormat("Certificate. SendRevokeCertificate(). Host {0} not found", baseUri);
          return Constants.Module.SignServiceResponseCodes.HostNotFound;
        }
        else
        {
          throw ex;
        }
        #endregion
      }
    }
    
    /// <summary>
    /// Проверить второй фактора - /CertificateIssues/{requestId}/confirm
    /// </summary>
    /// <param name="requestId">Id (на сервисе подписания) заявки на выпуск сертификата.</param>
    /// <param name="code">Код второго фактора.</param>
    /// <param name="providerId">Id провайдера.</param>
    /// <returns>Ответ на запрос. Коды ответов соответствуют константам SignServiceResponseCodes</returns>
    [Public, Remote]
    public static string SendCertificateIssueConfirmPersonal(long requestId, string code, string providerId)
    {
      Logger.DebugFormat("CertificateIssue. SendCertificateIssueConfirmPersonal(). requestId={0}", requestId);
      var confirmCodeStructure = Structures.Module.ConfirmationCode.Create();
      confirmCodeStructure.code = code;
      var json = EssPlatform.PublicFunctions.Module.SerializedToJson(confirmCodeStructure);
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      
      try
      {
        var requestApi = string.Format(Constants.Module.RequestApiSignService.SendConfirmCode, providerId, requestId);
        var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
        var response = EssPlatform.PublicFunctions.Module.Remote.RunPostRequest(baseUri, requestApi, json, token);
        Logger.DebugFormat("CertificateIssue. SendCertificateIssueConfirmPersonal(). requestId={0} apiurl='{1}' response.StatusCode={2}", requestId, requestApi, response.StatusCode);
        
        if (response.StatusCode == (int)HttpStatusCode.OK)
        {
          #region корректное выполнение запроса
          return SignPlatform.Constants.Module.SignServiceResponseCodes.Success;
          #endregion
        }
        else
        {
          #region Запрос /confirmation-request выдал какую-то ошибку - обработать её
          var responseError = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
          Logger.DebugFormat("CertificateIssue. SendCertificateIssueConfirmPersonal(). requestId={0} apiurl='{1}' response.StatusCode={2} responseError.Code={3}", requestId, requestApi, response.StatusCode, responseError.Code);
          return responseError.Code;
          #endregion
        }
      }
      // перехватить ошибку "хост не найдет", которая будет признаком того, что пропал канал связи с сервисом
      catch (System.AggregateException ex)
      {
        #region catch
        if(ex.InnerException.GetType() == typeof(System.Net.Http.HttpRequestException))
        {
          Logger.DebugFormat("CertificateIssue. SendCertificateIssueConfirmPersonal(). requestId={0} host {1} not found", requestId, baseUri);
          return Constants.Module.SignServiceResponseCodes.HostNotFound;
        }
        else
        {
          throw ex;
        }
        #endregion
      }
    }
    
    /// <summary>
    /// Получить информацию об облачных провайдерах - /CloudSignProviders
    /// </summary>
    /// <returns>Информация об облачных провайдерах.</returns>
    [Public]
    public virtual List<SignPlatform.Structures.Module.ICloudSignProviderInfo> GetCloudSignProviderInfo()
    {
      var token = DirRX.EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(Constants.Module.SignServiceAudience);
      var signServiceUrl = DirRX.EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      
      var response = DirRX.EssPlatform.PublicFunctions.Module.RunGetRequest(signServiceUrl, Constants.Module.RequestApiSignService.GetCloudSignProviderInfos, token);
      var statusCode = response.StatusCode;
      if (statusCode == (int)HttpStatusCode.OK)
      {
        var result = JsonConvert.DeserializeObject<JArray>(response.RequestMessage);
        
        var cloudSignProviderInfos = new List<SignPlatform.Structures.Module.ICloudSignProviderInfo>();
        
        foreach (var info in result)
        {
          var identificationTypes = new System.Collections.Generic.Dictionary<string, string>();
          identificationTypes = info["identificationTypes"]
            .Select(type => (JProperty)type)
            .ToDictionary(type => type.Name.ToString(), type => type.Value.ToString());
          
          var cloudSignProviderInfo = SignPlatform.Structures.Module.CloudSignProviderInfo.Create(
            (string)info["name"],
            identificationTypes,
            (string)info["providerId"]);
          
          cloudSignProviderInfos.Add(cloudSignProviderInfo);
        }
        
        return cloudSignProviderInfos;
      }
      
      throw AppliedCodeException.Create(DirRX.SignPlatform.Resources.GetCloudSignProviderInfosExceptionFormat(statusCode, response.RequestMessage));
    }
    
    /// <summary>
    /// Отправить запрос на выпуск сертификата - /CertificateIssues
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="providerId">Id провайдера.</param>
    /// <returns>Структура с ID запроса на выпуск сертификата или ошибкой.</returns>
    [Public]
    public virtual Structures.Module.ICertificateIssueRequestResponse SendCertificateIssueRequest(EssPlatformSolution.IEmployee employee, string providerId)
    {
      Logger.DebugFormat("CertificateIssue. SendCertificateIssueRequest(). EmployeeId={0}, {1}", employee.Id, "start");
      var certificateIssueRequest = CreateCertificateIssueRequest(employee);
      
      var result = Structures.Module.CertificateIssueRequestResponse.Create();
      var json = EssPlatform.PublicFunctions.Module.SerializedToJson(certificateIssueRequest);
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
      var requestApi = string.Format(Constants.Module.RequestApiSignService.CreateCertificate, providerId);
      var response = EssPlatform.PublicFunctions.Module.Remote.RunPostRequest(baseUri, requestApi, json, token);
      
      Logger.DebugFormat("CertificateIssue. SendCertificateIssueRequest(). EmployeeId={0}, urlapi='/{1}' response.StatusCode={2}",
                         employee.Id, requestApi, response.StatusCode);
      // 200
      if (response.StatusCode == (int)HttpStatusCode.OK)
      {
        var responseResult = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.CertificateIssueResponse>(response.RequestMessage);
        Logger.DebugFormat("CertificateIssue. SendCertificateIssueRequest(). EmployeeId={0}, responseResult.Status={1} ", employee.Id, responseResult.Status);
        if (responseResult.Status == SignPlatform.CertificateRequest.IssueStatus.Error.Value)
        {
          result.Error = responseResult.Error;
          Logger.DebugFormat("CertificateIssue. SendCertificateIssueRequest(). EmployeeId={0}, responseResult.Status={1} responseResult.Error='{2}'", employee.Id, responseResult.Status, responseResult.Error);
        }
        result.RequestId = responseResult.RequestId;
        Logger.DebugFormat("CertificateIssue. SendCertificateIssueRequest(). EmployeeId={0}, responseResult.Status={1} responseResult.RequestId={2}", employee.Id, responseResult.Status, responseResult.RequestId);
        return result;
      }
      // 400
      if (response.StatusCode == (int)HttpStatusCode.BadRequest)
      {
        var responseResult = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
        result.Error = GetErrorMessage(Resources.Error400SignServiceRequest, responseResult);
        Logger.DebugFormat("CertificateIssue. SendCertificateIssueRequest(). EmployeeId={0}, responseResult.Status={1} responseResult.Error='{2}'", employee.Id, response.StatusCode, result.Error);
        return result;
      }
      // 500
      if (response.StatusCode == (int)HttpStatusCode.InternalServerError)
      {
        var responseResult = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
        result.Error = GetErrorMessage(Resources.Error500SignServiceRequest, responseResult);
        Logger.DebugFormat("CertificateIssue. SendCertificateIssueRequest(). EmployeeId = {0}, responseResult.Status={1} responseResult.Error={2}", employee.Id, response.StatusCode, result.Error);
        return result;
      }

      Logger.DebugFormat("CertificateIssue. SendCertificateIssueRequest(). EmployeeId = {0}, unexpected response.StatusCode)={1}", employee.Id, response.StatusCode);
      throw AppliedCodeException.Create(DirRX.SignPlatform.Resources.SendCertificateIssueRequestExceptionFormat(response.StatusCode, response.RequestMessage));
    }
    
    /// <summary>
    /// Получить способы подтверждения
    /// </summary>
    /// <returns>Лист строк способов подтверждения</returns>
    [Public, Remote]
    public virtual List<string> GetConfirmationTypes()
    {
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
      var response = DirRX.EssPlatform.PublicFunctions.Module.RunGetRequest(baseUri, Constants.Module.RequestApiSignService.GetConfirmationType, token);
      var statusCode = response.StatusCode;
      if (statusCode == (int)HttpStatusCode.OK)
      {
        var result = JsonConvert.DeserializeObject<JArray>(response.RequestMessage);
        var confirmationTypes = new List<string>();
        
        foreach (var info in result)
        {
          //HACK: Т.к. в RX нельзя добавить в перечисление значение Default, а сервисе значение Default, приходится подменять
          if ((string)info == "Default")
            confirmationTypes.Add("DefaultValue");
          else
            confirmationTypes.Add((string)info);
        }
        
        return confirmationTypes;
      }
      
      throw AppliedCodeException.Create(DirRX.SignPlatform.Resources.ErrorGetConfirmationTypesFormat(statusCode, response.RequestMessage));
    }
    
    /// <summary>
    /// Получить способы подтверждения в формате локализованной строки
    /// </summary>
    /// <returns>Лист строк способов подтверждения в формате локализованной строки</returns>
    [Public, Remote]
    public virtual List<string> GetConfirmationTypesLocalized()
    {
      var confirmationTypesEnum = new List<string>();
      var confirmationTypes = GetConfirmationTypes();
      foreach(var confirmationType in confirmationTypes)
      {
        confirmationTypesEnum.Add(GetConfirmationTypeLocalized(confirmationType));
      }
      return confirmationTypesEnum;
    }
    /// <summary>
    /// Получить локализованный способ подтверждения
    /// </summary>
    /// <param name="confirmationType">Системное имя способа подтверждения</param>
    /// <returns>Локализованный способ подтвержденияи</returns>
    [Public, Remote]
    public virtual string GetConfirmationTypeLocalized(string confirmationType)
    {
      if (EssPlatform.EssSetting.ConfirmationType.DefaultValue.Value == confirmationType)
        return DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_DefaultValue;
      
      else if (EssPlatform.EssSetting.ConfirmationType.Email.Value == confirmationType)
        return DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_Email;

      else if (EssPlatform.EssSetting.ConfirmationType.FlashCall.Value == confirmationType)
        return DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_FlashCall;

      else if (EssPlatform.EssSetting.ConfirmationType.None.Value == confirmationType)
        return DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_None;

      else if (EssPlatform.EssSetting.ConfirmationType.Sms.Value == confirmationType)
        return DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_Sms;

      else if (EssPlatform.EssSetting.ConfirmationType.Viber.Value == confirmationType)
        return DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_Viber;
      
      throw AppliedCodeException.Create( DirRX.SignPlatform.Resources.ConfirmationTypeNotFoundFormat(confirmationType));
    }
    /// <summary>
    /// Получить способ подтверждения по локализованной строке
    /// </summary>
    /// <param name="confirmationTypeLocalized">Локализованная строка способа подтверждения</param>
    /// <returns>Системное имя способа подтверждения</returns>
    [Public, Remote]
    public virtual string GetConfirmationType(string confirmationTypeLocalized)
    {
      var confirmationTypeName = this.GetConfirmationTypeEnumeration(confirmationTypeLocalized).Value;
      return confirmationTypeName;
    }
    
    /// <summary>
    /// Получить способ подтверждения по локализованной строке
    /// </summary>
    /// <param name="confirmationTypeLocalized">Локализованная строка способа подтверждения</param>
    /// <returns>Способ подтверждения</returns>
    [Public, Remote]
    public virtual Enumeration GetConfirmationTypeEnumeration(string confirmationTypeLocalized)
    {
      if (DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_DefaultValue.ToString() == confirmationTypeLocalized)
        return EssPlatform.EssSetting.ConfirmationType.DefaultValue;
      
      else if (DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_Email.ToString() == confirmationTypeLocalized)
        return EssPlatform.EssSetting.ConfirmationType.Email;

      else if (DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_FlashCall.ToString() == confirmationTypeLocalized)
        return EssPlatform.EssSetting.ConfirmationType.FlashCall;

      else if (DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_None.ToString() == confirmationTypeLocalized)
        return EssPlatform.EssSetting.ConfirmationType.None;

      else if (DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_Sms.ToString() == confirmationTypeLocalized)
        return EssPlatform.EssSetting.ConfirmationType.Sms;

      else if (DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_Viber.ToString() == confirmationTypeLocalized)
        return EssPlatform.EssSetting.ConfirmationType.Viber;
      
      throw AppliedCodeException.Create( DirRX.SignPlatform.Resources.ConfirmationTypeNotFoundFormat(confirmationTypeLocalized));
    }
    /// <summary>
    /// Изменить способ подтверждения по умолчанию на сервисе подписания
    /// </summary>
    /// <param name="confirmationType">Способ подтверждения.</param>
    /// <returns>Возвращает результат изменения способа подтверждения на сервисе подписания</returns>
    [Public, Remote]
    public virtual bool ChangeConfirmationType(string confirmationType)
    {
      var confirmationTypeRequest = new Structures.Module.ConfirmationTypeRequest();
      //HACK: Т.к. в RX нельзя добавить в перечисление значение Default, а сервисе значение Default, приходится подменять
      if(confirmationType == "DefaultValue")
        confirmationType = "Default";
      confirmationTypeRequest.ConfirmationType = confirmationType;
      var json = EssPlatform.PublicFunctions.Module.SerializedToJson(confirmationTypeRequest);
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
      var requestApi = Constants.Module.RequestApiSignService.ChangeConfirmationType;
      var response = EssPlatform.PublicFunctions.Module.Remote.RunPostRequest(baseUri, requestApi, json, token);
      
      Logger.DebugFormat("ChangeConfirmationType(). ConfirmationType={0}, urlapi='{1}' response.StatusCode={2}",
                         confirmationType, requestApi, response.StatusCode);
      // 200
      if (response.StatusCode == (int)HttpStatusCode.OK)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    
    /// <summary>
    /// Изменить способ подтверждения для владельца сертификата на сервисе подписания
    /// </summary>
    /// <param name="confirmationType">Способ подтверждения.</param>
    /// <param name="certificateOwnerId">Id владельца сертификата.</param>
    /// <returns>Возвращает результат изменения способа подтверждения на сервисе подписания</returns>
    [Public, Remote]
    public virtual Structures.Module.IChangeConfirmationTypeForCertificateOwnerResult ChangeConfirmationTypeForCertificateOwner(string confirmationType, string certificateOwnerId)
    {
      var confirmationTypeRequest = new Structures.Module.ConfirmationTypeRequest();
      //HACK: Т.к. в RX нельзя добавить в перечисление значение Default, а сервисе значение Default, приходится подменять
      if(confirmationType == "DefaultValue")
        confirmationType = "Default";
      confirmationTypeRequest.ConfirmationType = confirmationType;
      var json = EssPlatform.PublicFunctions.Module.SerializedToJson(confirmationTypeRequest);
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
      var requestApi = string.Format(Constants.Module.RequestApiSignService.ChangeConfirmationTypeForCertificateOwner, certificateOwnerId);
      var response = EssPlatform.PublicFunctions.Module.Remote.RunPostRequest(baseUri, requestApi, json, token);
      
      Logger.DebugFormat("ChangeConfirmationTypeForCertificateOwner(). ConfirmationType={0}, certificateOwnerId={1}, urlapi='{2}' response.StatusCode={3}",
                         confirmationType, certificateOwnerId, requestApi, response.StatusCode);
      
      var result = new Structures.Module.ChangeConfirmationTypeForCertificateOwnerResult();
      // 200
      if (response.StatusCode == (int)HttpStatusCode.OK)
      {
        result.IsCompleted = true;
        result.ErrorMessage = string.Empty;
      }
      // 404. При первом подключении нельзя поменять способ подтверждения без наличия выпущенного сертификата пользователя на сервисе подписания.
      else if (response.StatusCode == (int)HttpStatusCode.NotFound)
      {
        result.IsCompleted = false;
        result.ErrorMessage = DirRX.SignPlatform.Resources.UserNotFound;
      }
      else
      {
        result.IsCompleted = false;
        result.ErrorMessage = DirRX.EssPlatform.EssSettings.Resources.CanNotChangeConfirmationType;
      }
      return result;
    }
    
    #endregion
    
    #region Функции заполнения структур для запросов
    /// <summary>
    /// Создать структуру для запроса на инициирование процесса выпуска сертификата - /CertificateIssues
    /// </summary>
    /// <param name="employee">Сотрудник, которому необходимо выпустить сертификат.</param>
    /// <returns>Структура запроса на выпуск сертификата.</returns>
    public virtual SignPlatform.Structures.Module.CertificateIssueRequest CreateCertificateIssueRequest(EssPlatformSolution.IEmployee employee)
    {
      var person = DirRX.EssPlatformSolution.People.Get(employee.Person.Id);
      
      // Структура запроса на выпуск сертификата
      var certificateIssueRequest = DirRX.SignPlatform.Structures.Module.CertificateIssueRequest.Create();
      certificateIssueRequest.Login =  EssPlatform.PublicFunctions.Module.Remote.GetUidPerson(employee.Person);
      certificateIssueRequest.PhoneNumber = employee.PersonalPhoneDirRX;
      certificateIssueRequest.GivenName = person.FirstName;
      certificateIssueRequest.Patronym = person.MiddleName;
      certificateIssueRequest.Surname = person.LastName;
      certificateIssueRequest.Inn = person.TIN;
      certificateIssueRequest.Email = this.GetCertificateEmail(employee);
      certificateIssueRequest.IdentificationType = person.IdentificationTypeDirRx.Value.Value;
      certificateIssueRequest.IdentityDocuments = GetIdentityDocuments(person);
      
      return certificateIssueRequest;
    }
    
    /// <summary>
    /// Создать структуру для запроса на искачивание текста заявления - /CertificateIssues/{requestId}/statement
    /// </summary>
    /// <param name="employee">Сотрудник, которому необходимо выпустить сертификат.</param>
    /// <returns>Структура запроса на создание заявления на выпуск сертификата.</returns>
    public virtual SignPlatform.Structures.Module.CertificateIssueStatementRequest CreateCertificateIssueStatementRequest(EssPlatformSolution.IEmployee employee)
    {
      var person = DirRX.EssPlatformSolution.People.Get(employee.Person.Id);
      
      // Структура запроса на создание заявления на выпуск сертификата
      var certificateIssueRequest = DirRX.SignPlatform.Structures.Module.CertificateIssueStatementRequest.Create();
      certificateIssueRequest.Surname = person.LastName;
      certificateIssueRequest.GivenName = person.FirstName;
      certificateIssueRequest.Patronym = person.MiddleName;
      certificateIssueRequest.BirthDate = person.DateOfBirth.Value;
      certificateIssueRequest.Inn = person.TIN;
      certificateIssueRequest.IdentificationType = person.IdentificationTypeDirRx.Value.Value;
      certificateIssueRequest.IdentityDocuments = GetIdentityDocuments(person);
      certificateIssueRequest.PhoneNumber = employee.PersonalPhoneDirRX;
      certificateIssueRequest.Email = this.GetCertificateEmail(employee);
      
      return certificateIssueRequest;
    }
    
    /// <summary>
    /// Получить документы удостоверяющие личность.
    /// </summary>
    /// <param name="person">Персона.</param>
    /// <returns>Список документов удостоверяющих личность.</returns>
    public virtual List<DirRX.SignPlatform.Structures.Module.IdentityDocument> GetIdentityDocuments(EssPlatformSolution.IPerson person)
    {
      var identityDocumentKind = person.IdentityDocumentKind.Value.Value;
      
      var identityDocuments = new List<DirRX.SignPlatform.Structures.Module.IdentityDocument>();
      
      if (identityDocumentKind != null)
      {
        var identityDocument = DirRX.SignPlatform.Structures.Module.IdentityDocument.Create();
        identityDocument.Series = person.IdentityDocumentSeries;
        identityDocument.Number = person.IdentityDocumentNumber;
        identityDocument.Gender = GetGender(person.Sex.Value.Value);
        identityDocument.BirthDate = person.DateOfBirth.Value;
        identityDocument.IssueDate = person.IdentityDocumentIssueDate.Value;
        identityDocument.IssuedOrganization = person.IdentityDocumentIssuedBy;

        if (Equals(identityDocumentKind, EssPlatformSolution.Person.IdentityDocumentKind.PassportRF.Value))
        {
          // паспорт РФ
          identityDocument.IdentityDocumentType = SignPlatform.Constants.Module.IdentityDocumentType.Passport;
          identityDocument.IssuedOrganizationId = person.IdentityDocumentIssuerID;
        }
        
        else if (Equals(identityDocumentKind, EssPlatformSolution.Person.IdentityDocumentKind.OtherDocument.Value)
                 || Equals(identityDocumentKind, EssPlatformSolution.Person.IdentityDocumentKind.ForeignPassport.Value))
        {
          // иной документ удостоверяющий личность
          identityDocument.IdentityDocumentType = SignPlatform.Constants.Module.IdentityDocumentType.OtherIdentity;
          if(person.IdentityDocumentExpirationDate.HasValue)
            identityDocument.ValidityPeriod = person.IdentityDocumentExpirationDate.Value;
        }
        identityDocuments.Add(identityDocument);
      }
      
      // СНИЛС
      var INILA = DirRX.SignPlatform.Structures.Module.IdentityDocument.Create();
      INILA.IdentityDocumentType = SignPlatform.Constants.Module.IdentityDocumentType.INILA;
      INILA.Number = person.INILA;
      INILA.BirthDate = person.DateOfBirth.Value;
      identityDocuments.Add(INILA);
      
      return identityDocuments;
    }
    
    /// <summary>
    /// Получить пол в терминах сервиса подписания.
    /// </summary>
    /// <param name="sex">Пол.</param>
    /// <returns>Пол в терминах сервиса подписания.</returns>
    public virtual string GetGender(string sex)
    {
      if (Equals(sex, EssPlatformSolution.Person.Sex.Male.Value))
      {
        return Constants.Module.Gender.Male;
      }
      
      else if (Equals(sex, EssPlatformSolution.Person.Sex.Female.Value))
      {
        return Constants.Module.Gender.Female;
      }
      
      throw new Exception(DirRX.SignPlatform.Resources.GenderError);
    }
    
    /// <summary>
    /// Получить значение эл. почты при запросе сертфиката.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <returns>Эл. почта.</returns>
    [Public]
    public string GetCertificateEmail(EssPlatformSolution.IEmployee employee)
    {
      if (!string.IsNullOrEmpty(employee.MessagesEmailDirRX))
        return employee.MessagesEmailDirRX;
      if (!string.IsNullOrEmpty(employee.Email))
        return employee.Email;
      return EssPlatform.PublicFunctions.EssSetting.GetSettings().CertificateMail;
    }
    
    #endregion
    
    #region Функции обработки заявлений на сертификаты для использования в задаче и ФП
    
    /// <summary>
    /// Извлечь тексты ошибок из ответа запроса
    /// </summary>
    /// <param name="errorMain">Основной текст ошибки.</param>
    /// <param name="errorDetail">Распарсенный json с описанием ответа с ошибками.</param>
    public StateView GetAssignmentStateView(string text)
    {
      var stateView = Sungero.Core.StateView.Create();
      var block = stateView.AddBlock();
      var content = block.AddContent();
      content.AddLabel(text);
      block.ShowBorder = false;
      return stateView;
    }
    /// <returns>Извлеченные сообщения об ошибках в виде строки с переводами строк.</returns>
    /// <summary>
    /// Извлечь тексты ошибок из ответа запроса
    /// </summary>
    /// <param name="errorMain">Основной текст ошибки.</param>
    /// <param name="errorDetail">Распарсенный json с описанием ответа с ошибками.</param>
    /// <returns>Извлеченные сообщения об ошибках в виде строки с переводами строк.</returns>
    public virtual string GetErrorMessage(string errorMain, SignPlatform.Structures.Module.HttpRequestErrorResult errorDetail)
    {
      var errorMessage = errorDetail.Message;
      
      if (!string.IsNullOrEmpty(errorMain))
        errorMessage = string.Format("{0}{1}{2}", errorMain, Environment.NewLine, errorDetail.Message);
      
      if (errorDetail.Details != null)
        foreach (var detail in errorDetail.Details)
      {
        errorMessage += string.Format("{0}{1}Field: {2}, message: {3}\r\n", errorMessage, Environment.NewLine, detail.Field, detail.Message);
      }
      
      return errorMessage;
    }

    /// <summary>
    /// Скачать заявление
    /// </summary>
    /// <param name="requestEntry">Запись из справочника заявок на выпуск УНЭП.</param>
    /// <returns>Признак, изменен ли статус в записи.</returns>
    public virtual bool DownloadStatement(ICertificateRequest requestEntry, ICertificateIssueTask task)
    {
      Logger.DebugFormat("CertificateIssue. DownloadStatement(). requestEntry.RequestId={0} IssueStatus={1} start", requestEntry.RequestId, requestEntry.IssueStatus);
      var certificateIssueRequest = SignPlatform.Functions.Module.CreateCertificateIssueStatementRequest(requestEntry.Employee);
      Enumeration? newIssueStatus = null;
      string errorMessage = string.Empty;
      var json = EssPlatform.PublicFunctions.Module.SerializedToJson(certificateIssueRequest);
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var requestApi = string.Format(Constants.Module.RequestApiSignService.CreateStatement, task.ProviderId, requestEntry.RequestId);
      var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
      Logger.DebugFormat("CertificateIssue. DownloadStatement(). requestEntry.RequestId={0} IssueStatus={1} token received", requestEntry.RequestId, requestEntry.IssueStatus);
      try
      {
        var response = EssPlatform.PublicFunctions.Module.Remote.RunPostRequest(baseUri, requestApi, json, token);
        Logger.DebugFormat("CertificateIssue. DownloadStatement(). requestEntry.RequestId={0} IssueStatus={1}, urlapi='/{2}' response.StatusCode={3}",
                           requestEntry.RequestId, requestEntry.IssueStatus, requestApi, response.StatusCode);
        
        if (response.StatusCode == (int)HttpStatusCode.OK)
        {
          var result = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.CertificateIssueStatementResponse>(response.RequestMessage);
          var content = System.Convert.FromBase64String(result.Base64Content);
          
          var document = SignPlatform.CertificateIssueStatementDocuments.Create();
          document.Name = Resources.CertificateIssueStatementDocumentNameFormat(task.Employee.DisplayValue);
          
          document.DocumentKind = Sungero.Docflow.PublicFunctions.DocumentKind.GetNativeDocumentKind(Constants.Module.DocumentKind.CertificateIssueKind);
          
          using (var memory = new System.IO.MemoryStream(content))
          {
            document.CreateVersionFrom(memory, "pdf");
            document.AccessRights.Grant(task.Employee, DefaultAccessRightsTypes.FullAccess);
            document.AccessRights.Grant(task.Author, DefaultAccessRightsTypes.FullAccess);
            document.Save();
            
            requestEntry.DocumentID = document.Id;
          }
          newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.NeedConfirm;
        }
        if (response.StatusCode == (int)HttpStatusCode.InternalServerError || response.StatusCode == (int)HttpStatusCode.NotFound)
        {
          var result = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
          Logger.DebugFormat("CertificateIssue. DownloadStatement(). requestEntry.RequestId={0} IssueStatus={1} resultError.Code={2}", requestEntry.RequestId, requestEntry.IssueStatus, result.Code);
          if (result.Code != Constants.Module.SignServiceResponseCodes.TemporaryUnavailableError)
          {
            var mainErrorText = Resources.Error500SignServiceRequest;
            if (response.StatusCode == (int)HttpStatusCode.NotFound)
              mainErrorText = Resources.Error404SignServiceRequest;
            errorMessage = GetErrorMessage(mainErrorText, result);
            newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
          }
        }
        // обновить запись в CertificateRequest если что-то поменялось
        if (newIssueStatus != null)
        {
          Logger.DebugFormat("CertificateIssue. DownloadStatement(). requestEntry.RequestId={0} change IssueStatus={1}->{2}", requestEntry.RequestId, requestEntry.IssueStatus, newIssueStatus);
          requestEntry.IssueStatus = newIssueStatus;
          requestEntry.LastStatusChange = Calendar.Now;
          if (!string.IsNullOrEmpty(errorMessage))
          {
            requestEntry.Errors = errorMessage;
          }
          requestEntry.Save();
          return true;
        }
        // ничего не изменилось
        Logger.DebugFormat("CertificateIssue. DownloadStatement(). requestEntry.RequestId={0} no change IssueStatus={1}", requestEntry.RequestId, requestEntry.IssueStatus);
        return false;
      }
      // перехватить ошибку "хост не найдет", которая будет признаком того, что пропал канал связи с сервисом
      catch (System.AggregateException ex)
      {
        if(ex.InnerException.GetType() == typeof(System.Net.Http.HttpRequestException))
        {
          Logger.DebugFormat("CertificateIssue. DownloadStatement(). requestEntry.RequestId={0} IssueStatus={1} host {2} not found", requestEntry.RequestId, requestEntry.IssueStatus, baseUri);
          return false;
        }
        else
        {
          throw ex;
        }
      }
      
    }

    /// <summary>
    /// Проверить подписано ли заявление в ЕСИА
    /// </summary>
    /// <param name="requestEntry">Запись из справочника заявок на выпуск УНЭП.</param>
    /// <returns>Признак, изменен ли статус в записи.</returns>
    public virtual bool CheckCertificateConfirmByESIA(ICertificateRequest requestEntry)
    {
      Logger.DebugFormat("CertificateIssue. CheckCertificateConfirmByESIA(). requestEntry.RequestId={0} IssueStatus={1} start", requestEntry.RequestId, requestEntry.IssueStatus);
      
      var confirmCodeStructure = Structures.Module.ConfirmationCode.Create();
      confirmCodeStructure.code = string.Empty;
      var json = EssPlatform.PublicFunctions.Module.SerializedToJson(confirmCodeStructure);
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var requestApi = string.Format(Constants.Module.RequestApiSignService.SendConfirmCode, requestEntry.ProviderId, requestEntry.RequestId);
      var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
      var confirm2FAResponse = EssPlatform.PublicFunctions.Module.Remote.RunPostRequest(baseUri, requestApi, json, token);
      
      Logger.DebugFormat("CertificateIssue. CheckCertificateConfirmByESIA(). requestEntry.RequestId={0} apiurl='{1}' confirm2FAResponse.StatusCode={2}", requestEntry.RequestId, requestApi, confirm2FAResponse.StatusCode);
      try
      {
        Enumeration? newIssueStatus = null;
        string errorMessage = string.Empty;
        
        #region отправка запроса и обработка результатов
        if (confirm2FAResponse.StatusCode == (int)HttpStatusCode.OK)
        {
          #region Код принят сервисом
          Logger.DebugFormat("CertificateIssue. CheckCertificateConfirmByESIA(). requestEntry.RequestId={0} Successfully confirmated in ESIA ", requestEntry.RequestId);
          // Надо изменить статус заявки
          newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.IssVerification;
          #endregion
        }
        else
        {
          # region запрос /confirm дал какую-то ошибку - обработать её
          var response2FA_erros = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(confirm2FAResponse.RequestMessage);
          Logger.DebugFormat("CertificateIssue. CheckCertificateConfirmByESIA(). requestEntry.RequestId={0} response2FA_erros.Code={1}", requestEntry.RequestId, response2FA_erros.Code);
          if (confirm2FAResponse.StatusCode == (int)HttpStatusCode.BadRequest)
          {
            #region 400-я ошибка
            if (response2FA_erros.Code == Constants.Module.SignServiceResponseCodes.ConfirmationInProgress)
            {
              #region ConfirmationInProgress всё еще не подписали в ЕСИА
              return false;
              #endregion
            }
            else if (response2FA_erros.Code == Constants.Module.SignServiceResponseCodes.ConfirmationFailed)
            {
              var detailError = response2FA_erros.Details.FirstOrDefault();
              if (detailError != null)
              {
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
                if (detailError.Code == Constants.Module.SignServiceResponseCodes.ConfirmationRejected)
                {
                  // ConfirmationRejected
                  errorMessage = GetErrorMessage(SignPlatform.CertificateIssueTasks.Resources.ErrorConfirmationRejected, response2FA_erros);
                }
                else if (detailError.Code == Constants.Module.SignServiceResponseCodes.UserNotFoundInEsia)
                {
                  //UserNotFoundInEsia
                  errorMessage = GetErrorMessage(SignPlatform.CertificateIssueTasks.Resources.ErrorUserNotFoundInESIA, response2FA_erros);
                }
                else if (detailError.Code == Constants.Module.SignServiceResponseCodes.ConfirmationExpired)
                {
                  // ConfirmationExpired
                  errorMessage = GetErrorMessage(SignPlatform.CertificateIssueTasks.Resources.ErrorConfirmationExpired, response2FA_erros);
                }
                else
                {
                  // Unexpected Error
                  errorMessage = Resources.UnexpectedErrorTextFormat(detailError.Code);
                }
              }
            }
            else
            {
              #region Unexpected Error
              requestEntry.IssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
              errorMessage = Resources.UnexpectedErrorTextFormat(response2FA_erros.Code);
              #endregion
            }
            #endregion
          }

          if (confirm2FAResponse.StatusCode == (int)HttpStatusCode.InternalServerError || confirm2FAResponse.StatusCode == (int)HttpStatusCode.NotFound)
          {
            #region Запросы отработали с ошибкой
            var result = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(confirm2FAResponse.RequestMessage);
            Logger.DebugFormat("CertificateIssue. CheckCertificateConfirm(). requestEntry.RequestId={0} IssueStatus={1} resultError.Code={2}", requestEntry.RequestId, requestEntry.IssueStatus, result.Code);
            if (result.Code != Constants.Module.SignServiceResponseCodes.TemporaryUnavailableError)
            {
              var mainErrorText = Resources.Error500SignServiceRequest;
              if (confirm2FAResponse.StatusCode == (int)HttpStatusCode.NotFound)
                mainErrorText = Resources.Error404SignServiceRequest;
              errorMessage = GetErrorMessage(mainErrorText, result);
              newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
            }
            #endregion
          }
          #endregion
        }
        // обновить запись в CertificateRequest если что-то поменялось
        Logger.DebugFormat("CertificateIssue. CheckCertificateConfirm(). requestEntry.RequestId={0} newIssueStatus={1}", requestEntry.RequestId, newIssueStatus);
        if (newIssueStatus != null)
        {
          Logger.DebugFormat("CertificateIssue. CheckCertificateConfirm(). requestEntry.RequestId={0} change IssueStatus={1}->{2}", requestEntry.RequestId, requestEntry.IssueStatus, newIssueStatus);
          requestEntry.IssueStatus = newIssueStatus;
          requestEntry.LastStatusChange = Calendar.Now;
          if (!string.IsNullOrEmpty(errorMessage))
          {
            requestEntry.Errors = errorMessage;
          }
          requestEntry.Save();
          return true;
        }
        // ничего не изменилось
        Logger.DebugFormat("CertificateIssue. CheckCertificateConfirm(). requestEntry.RequestId={0} no change IssueStatus={1}", requestEntry.RequestId, requestEntry.IssueStatus);
        return false;
        #endregion
      }
      catch (System.AggregateException ex)
      {
        #region перехват ошибки "хост не найдет", которая будет признаком того, что пропал канал связи с сервисом
        if(ex.InnerException.GetType() == typeof(System.Net.Http.HttpRequestException))
        {
          Logger.DebugFormat("CertificateIssue. CheckCertificateConfirm(). requestEntry.RequestId={0} IssueStatus={1} host {2} not found", requestEntry.RequestId, requestEntry.IssueStatus, baseUri);
          return false;
        }
        else
        {
          throw ex;
        }
        #endregion
      }
      
    }
    
    /// <summary>
    /// Проверить статус заявки на выпуск УНЭП.
    /// </summary>
    /// <param name="requestEntry">Запись из справочника заявок на выпуск УНЭП.</param>
    /// <returns>Признак, изменен ли статус в записи.</returns>
    public virtual bool CheckCertificateStatus(ICertificateRequest requestEntry)
    {
      Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1} start", requestEntry.RequestId, requestEntry.IssueStatus);
      var oldIssueStatus = requestEntry.IssueStatus;
      var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
      var token = EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(SignPlatform.Constants.Module.SignServiceAudience);
      Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1} token received", requestEntry.RequestId, requestEntry.IssueStatus);
      try
      {
        var requestApi = string.Format(Constants.Module.RequestApiSignService.GetStatementStatus, requestEntry.ProviderId, requestEntry.RequestId.Value);
        var response = EssPlatform.PublicFunctions.Module.RunGetRequest(baseUri, requestApi, token);
        Enumeration? newIssueStatus = null;
        string errorMessage = string.Empty;
        Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1}, urlapi='/{2}' response.StatusCode={3}",
                           requestEntry.RequestId, requestEntry.IssueStatus, requestApi, response.StatusCode);
        if (response.StatusCode == 200)
        {
          var result = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestResult>(response.RequestMessage);
          Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1}, result.Status={2}",
                             requestEntry.RequestId, requestEntry.IssueStatus, result.Status);
          
          if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.DocVerification)
          {
            switch (result.Status)
            {
              case SignPlatform.Constants.Module.Response.DocumentsVerification:
                // остаться на этом же шаге
                break;
              case SignPlatform.Constants.Module.Response.NeedConfirm:
                // перейти на этап скачивания тела заявления
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt;
                break;
              case SignPlatform.Constants.Module.Response.Error:
                // ошибка обработки заявки
                errorMessage = result.Error;
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
                break;
              default:
                // ошибка "неожижанное значение статуса"
                Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1}, unexpected result.Status={2}",
                                   requestEntry.RequestId, requestEntry.IssueStatus, result.Status);
                errorMessage = Resources.UnexpectedStatusErrorFormat(result.Status);
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
                break;
            }
          }
          else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification)
          {
            switch (result.Status)
            {
              case SignPlatform.Constants.Module.Response.IssueVerification:
                // остаться на этом же шаге
                break;
              case SignPlatform.Constants.Module.Response.InProgress:
                // остаться на этом же шаге, но сменить статус заявки
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.InProgress;
                break;
              case SignPlatform.Constants.Module.Response.Success:
                // сменить статус заявки - сертификат готов
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.CertCreated;
                break;
              case SignPlatform.Constants.Module.Response.Error:
                // ошибка обработки заявки
                errorMessage = result.Error;
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
                break;
              default:
                Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1}, unexpected result.Status={2}",
                                   requestEntry.RequestId, requestEntry.IssueStatus, result.Status);
                // ошибка "неожижанное значение статуса"
                errorMessage = Resources.UnexpectedStatusErrorFormat(result.Status);
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
                break;
            }
          }
          else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress)
          {
            switch (result.Status) {
              case SignPlatform.Constants.Module.Response.InProgress:
                // остаться на этом же шаге
                break;
              case SignPlatform.Constants.Module.Response.Success:
                // перейти на этап скачивания сертификата
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.CertCreated;
                break;
              case SignPlatform.Constants.Module.Response.Error:
                // ошибка обработки заявки
                errorMessage = result.Error;
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
                break;
              default:
                Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1}, unexpected result.Status={2}",
                                   requestEntry.RequestId, requestEntry.IssueStatus, result.Status);
                // ошибка "неожижанное значение статуса"
                errorMessage = Resources.UnexpectedStatusErrorFormat(result.Status);
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
                break;
            }
          }
          else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated)
          {
            switch (result.Status) {
              case SignPlatform.Constants.Module.Response.Success:
                // остаться на этом же шаге
                break;
              default:
                Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1}, unexpected result.Status={2}",
                                   requestEntry.RequestId, requestEntry.IssueStatus, result.Status);
                // ошибка "неожижанное значение статуса"
                errorMessage = Resources.UnexpectedStatusErrorFormat(result.Status);
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
                break;
            }
          }
          else
          {
            // ошибка
            Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} unecpected IssueStatus={1}", requestEntry.RequestId, requestEntry.IssueStatus);
            errorMessage = Resources.UnexpectedRequestStatusErrorFormat(requestEntry.IssueStatus.Value);
            newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
          }
        }
        else if (response.StatusCode == (int)HttpStatusCode.InternalServerError || response.StatusCode == (int)HttpStatusCode.NotFound)
        {
          var result = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
          Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1} resultError.Code={2}", requestEntry.RequestId, requestEntry.IssueStatus, result.Code);
          if (result.Code != Constants.Module.SignServiceResponseCodes.TemporaryUnavailableError)
          {
            var mainErrorText = Resources.Error500SignServiceRequest;
            if (response.StatusCode == (int)HttpStatusCode.NotFound)
              mainErrorText = Resources.Error404SignServiceRequest;
            errorMessage = GetErrorMessage(mainErrorText, result);
            newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
          }
        }
        else
        {
          errorMessage = DirRX.SignPlatform.Resources.UnknownResponseCodeFormat(response.StatusCode);
          newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
        }
        // обновить запись в CertificateRequest если что-то поменялось
        if (newIssueStatus != null)
        {
          Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} change IssueStatus={1}->{2}", requestEntry.RequestId, requestEntry.IssueStatus, newIssueStatus);
          if(newIssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated && response.StatusCode == (int)HttpStatusCode.OK)
            requestEntry.CloudCertificateID = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestResult>(response.RequestMessage).CertificateId;
          requestEntry.IssueStatus = newIssueStatus;
          requestEntry.LastStatusChange = Calendar.Now;
          if (!string.IsNullOrEmpty(errorMessage))
          {
            requestEntry.Errors = errorMessage;
          }
          requestEntry.Save();
          return true;
        }
        // ничего не изменилось
        Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} no change IssueStatus={1}", requestEntry.RequestId, requestEntry.IssueStatus);
        return false;
      }
      // перехватить ошибку "хост не найдет", которая будет признаком того, что пропал канал связи с сервисом
      catch (System.AggregateException ex)
      {
        if(ex.InnerException.GetType() == typeof(System.Net.Http.HttpRequestException))
        {
          Logger.DebugFormat("CertificateIssue. CheckCertificateStatus(). requestEntry.RequestId={0} IssueStatus={1} host {2} not found", requestEntry.RequestId, requestEntry.IssueStatus, baseUri);
          return false;
        }
        else
        {
          throw ex;
        }
      }
    }

    /// <summary>
    /// Завершающие действия после выпуска сертификата. Функция-точка расширения, чтобы используя перекрытия  навешивать свои действия
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    [Public]
    public virtual void AfterIssueCertificate(EssPlatformSolution.IEmployee employee, Sungero.CoreEntities.IUser author)
    {
      
    }
    
    /// <summary>
    /// Сохранить облачный сертификат в справочник "Цифровые сертификаты".
    /// </summary>
    /// <param name="requestEntry">Запись из справочника заявок на выпуск УНЭП.</param>
    /// <returns>Признак, изменен ли статус в записи.</returns>
    public virtual bool SaveCertificate(ICertificateRequest requestEntry)
    {
      Logger.DebugFormat("CertificateIssue. SaveCertificate(). requestEntry.RequestId={0} IssueStatus={1} start", requestEntry.RequestId, requestEntry.IssueStatus);
      
      Enumeration? newIssueStatus = null;
      string errorMessage = string.Empty;
      long? certificateID = null;
      
      if(requestEntry.CloudCertificateID.HasValue)
      {
        var oldIssueStatus = requestEntry.IssueStatus;
        var baseUri = EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress;
        var requestApi = string.Format(Constants.Module.RequestApiSignService.GetCertificate, requestEntry.ProviderId, requestEntry.CloudCertificateID.Value);
        var token = DirRX.EssPlatform.PublicFunctions.Module.Remote.GetAnAuthenticationToken(Constants.Module.SignServiceAudience);
        Logger.DebugFormat("CertificateIssue. SaveCertificate(). requestEntry.RequestId={0} IssueStatus={1} token received", requestEntry.RequestId, requestEntry.IssueStatus);
        try
        {
          var response = DirRX.EssPlatform.PublicFunctions.Module.RunGetRequest(baseUri, requestApi, token);
          Logger.DebugFormat("CertificateIssue. SaveCertificate(). requestEntry.RequestId={0} IssueStatus={1}, urlapi='/{2}' response.StatusCode={3}",
                             requestEntry.RequestId, requestEntry.IssueStatus, requestApi, response.StatusCode);
          if (response.StatusCode == (int)HttpStatusCode.OK)
          {
            var certificate = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.Certificate>(response.RequestMessage);
            var employees = DirRX.EssPlatformSolution.Employees.GetAll(e => e.Person.Id == requestEntry.Employee.Person.Id && e.Status == Sungero.Company.Employee.Status.Active);
            
            foreach(var employee in employees)
            {
              string additionalDiscription = (employee.BusinessUnitDirRX != null ? employee.BusinessUnitDirRX.Name : "") +
                (employee.Department != null ? ", " + employee.Department.Name : "") +
                (employee.JobTitle != null ? ", " + employee.JobTitle.Name : "");
              
              var digitalCertificate = Sungero.CoreEntities.Certificates.Create();
              digitalCertificate.Owner = employee;
              digitalCertificate.Description = DirRX.SignPlatform.CertificateIssueTasks.Resources.CertificateDescriptionFormat(additionalDiscription);
              digitalCertificate.Subject = certificate.OwnerCommonName;
              digitalCertificate.Issuer = certificate.IssuerCommonName;
              digitalCertificate.NotBefore = certificate.ValidFrom;
              digitalCertificate.NotAfter = certificate.ValidTo;
              digitalCertificate.Thumbprint = certificate.Thumbprint;
              digitalCertificate.X509Certificate = System.Convert.FromBase64String(certificate.Content);
              digitalCertificate.PluginId = SignPlatform.Constants.Module.PluginIdOfCloudCertificates;
              // Заполнение providerId
              var providerIdParameter = digitalCertificate.Parameters.AddNew();
              providerIdParameter.Key = Constants.Module.ProviderIdCertificateKeyParameter;
              providerIdParameter.Value = certificate.ProviderId;
              // Заполнение ownerId
              var ownerIdParameter = digitalCertificate.Parameters.AddNew();
              ownerIdParameter.Key = Constants.Module.OwnerIdCertificateKeyParameter;
              ownerIdParameter.Value = certificate.OwnerId;
              digitalCertificate.Save();
              Logger.DebugFormat("CertificateIssue. SaveCertificate(). requestEntry.RequestId={0} IssueStatus={1}, saved certificate for employeeId={2}",
                                 requestEntry.RequestId, requestEntry.IssueStatus, employee.Id);
              if(employee.Id == requestEntry.Employee.Id)
              {
                certificateID = digitalCertificate.Id;
                newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.CertRegistered;
              }
            }
            
            this.DisablePrevCloudCertificates(requestEntry.Employee.Person.Id, certificate.ProviderId);
          }
          else if (response.StatusCode == (int)HttpStatusCode.InternalServerError || response.StatusCode == (int)HttpStatusCode.NotFound)
          {
            var result = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(response.RequestMessage);
            Logger.DebugFormat("CertificateIssue. SaveCertificate(). requestEntry.RequestId={0} IssueStatus={1} resultError.Code={2}", requestEntry.RequestId, requestEntry.IssueStatus, result.Code);
            if (result.Code != Constants.Module.SignServiceResponseCodes.TemporaryUnavailableError)
            {
              var mainErrorText = Resources.Error500SignServiceRequest;
              if (response.StatusCode == (int)HttpStatusCode.NotFound)
                mainErrorText = Resources.Error404SignServiceRequest;
              errorMessage = GetErrorMessage(mainErrorText, result);
              newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
            }
          }
          else
          {
            errorMessage = DirRX.SignPlatform.Resources.UnknownResponseCodeFormat(response.StatusCode);
            newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
          }
        }
        // перехватить ошибку "хост не найдет", которая будет признаком того, что пропал канал связи с сервисом
        catch (System.AggregateException ex)
        {
          if(ex.InnerException.GetType() == typeof(System.Net.Http.HttpRequestException))
          {
            Logger.DebugFormat("CertificateIssue. SaveCertificate(). requestEntry.RequestId={0} IssueStatus={1} host {2} not found", requestEntry.RequestId, requestEntry.IssueStatus, baseUri);
            return false;
          }
          else
          {
            throw ex;
          }
        }
      }
      else
      {
        // ошибка обработки заявки - не найден ИД облачного сертификата
        errorMessage = DirRX.SignPlatform.Resources.CloudCertificateIDNotFoundFormat(requestEntry.RequestId);
        newIssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
      }
      
      // обновить запись в CertificateRequest если что-то поменялось
      if (newIssueStatus != null)
      {
        Logger.DebugFormat("CertificateIssue. SaveCertificate(). requestEntry.RequestId={0} change IssueStatus={1}->{2}", requestEntry.RequestId, requestEntry.IssueStatus, newIssueStatus);
        if(certificateID.HasValue)
          requestEntry.CertificateID = certificateID.Value;
        requestEntry.IssueStatus = newIssueStatus;
        requestEntry.LastStatusChange = Calendar.Now;
        if (!string.IsNullOrEmpty(errorMessage))
        {
          requestEntry.Errors = errorMessage;
        }
        requestEntry.Save();
        return true;
      }
      // ничего не изменилось
      Logger.DebugFormat("CertificateIssue. SaveCertificate(). requestEntry.RequestId={0} no change IssueStatus={1}", requestEntry.RequestId, requestEntry.IssueStatus);
      return false;
    }
    
    /// <summary>
    /// Деактивировать ранее выпущенные "облачные" сертификаты персоны. Оставить только для основного сотрудника.
    /// </summary>
    /// <param name="personId">ИД персоны.</param>
    /// <param name="providerId">ИД провайдера.</param>
    public virtual void DisablePrevCloudCertificates(long personId, string providerId)
    {
      var employees = DirRX.EssPlatformSolution.Employees.GetAll(e => e.Person.Id == personId && e.Status == Sungero.Company.Employee.Status.Active);
      
      var mainEmployee = EssPlatform.PublicFunctions.Module.Remote.GetPersonMainEmployee(personId, null);
      
      var certificates = Certificates
        .GetAll()
        .Where(c => employees.Contains(c.Owner)
               && c.Enabled == true
               && c.Parameters.Any(p => Equals(p.Value, providerId))               
               && c.PluginId.ToLower().Equals(DirRX.SignPlatform.PublicConstants.Module.PluginIdOfCloudCertificates))
        .OrderByDescending(o => o.Id).ToList();
      
      var mainCert = certificates.Where(c => c.Owner.Equals(mainEmployee)).FirstOrDefault();
      if (mainCert != null)
        certificates.Remove(mainCert);
      
      foreach(var cert in certificates)
      {
        try
        {
          Logger.DebugFormat("CertificateIssue. DisablePrevCloudCertificates(). Try disable certificate with id {0} and thumbprint {1} by {2}", cert.Id, cert.Thumbprint, cert.Owner.Name);
          cert.Enabled = false;
          cert.Save();
        }
        catch(Exception ex)
        {
          Logger.DebugFormat("CertificateIssue. DisablePrevCloudCertificates(). Error when disable cert id {0}. {1}", cert.Id, ex.StackTrace);
        }
      }
    }
    
    /// <summary>
    /// Проверить наличие записи с указанным RequestId в справочнике Запросы на выдачу сертификата электронной подписи.
    /// </summary>
    /// <param name="requestId">ИД запроса на выдачу сертификата электронной подписи.</param>
    /// <returns>True, если запрос существует, иначе false.</returns>
    /// <remarks>Наличе записи проверять с правами на просмотр, так как важно именно наличие записи без учета прав у текущего пользователя.</remarks>
    [Remote]
    public virtual bool ExistsCertificateRequest(long requestId)
    {
      var existsRequest = false;
      AccessRights.AllowRead(
        () =>
        {
          existsRequest = CertificateRequests.GetAll(x => x.RequestId == requestId).Any();
        });
      return existsRequest;
    }
    #endregion
    
    #region Функции для сервиса интеграции
    
    /// <summary>
    /// Получить тип идентификации персоны.
    /// </summary>
    /// <param name="employeeId">ИД сотрудника.</param>
    /// <returns></returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetIdentificationType (long employeeId)
    {
      var emp = DirRX.EssPlatformSolution.Employees.Get(employeeId);
      var person = DirRX.EssPlatformSolution.People.Get(emp.Person.Id);
      return person.IdentificationTypeDirRx.Value.Value;
    }
    
    /// <summary>
    /// Запросить код второго фактора.
    /// </summary>
    /// <param name="assignmentId">ИД задания.</param>
    /// <returns>Ответ на запрос.</returns>
    [Public(WebApiRequestType = RequestType.Post)]
    public string SendCertificateIssueConfirmation (long assignmentId)
    {
      var task = CertificateIssueTasks.As(CertificateIssueStatementAcceptAssignments.Get(assignmentId).Task);
      return SendCertificateIssueConfirmation(task.RequestId.Value, task.IdentificationType.Value.Value, task.Employee.PersonalPhoneDirRX, task.ProviderId);
    }
    
    /// <summary>
    /// Отправить подтверждение вторым фактором.
    /// </summary>
    /// <param name="assignmentId">ИД задания.</param>
    /// <param name="code">Код второго фактора.</param>
    /// <returns>Ответ на запрос</returns>
    [Public(WebApiRequestType = RequestType.Post)]
    public string SendConfirmCodePersonal(long assignmentId, string code)
    {
      var task = CertificateIssueTasks.As(CertificateIssueStatementAcceptAssignments.Get(assignmentId).Task);
      return SendCertificateIssueConfirmPersonal(task.RequestId.Value, code, task.ProviderId);
    }
    #endregion

    /// <summary>
    /// Найти записть в CertificateRequests для указанного цифрового сертификата.
    /// </summary>
    /// <param name="certificate">Сертификат</param>
    /// <returns>Сущность из CertificateRrequests
    /// </returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetCertificateProvider(long certificateId) {
      var requestEntry = CertificateRequests.GetAll().Where(cr => cr.CertificateID == certificateId).FirstOrDefault();
      if (requestEntry == null || requestEntry.ProviderId == null)
        return "directum-css";
      return requestEntry.ProviderId;
    }
    
    /// <summary>
    /// Заполнить параметры цифровых сертификатов.
    /// </summary>
    /// <returns>Ответ на запрос.</returns>
    [Public(WebApiRequestType = RequestType.Post)]
    public virtual string FillCertificateParams(int numberRecordsProcess)
    {
      int unlimitedQuantity = 0;
      Logger.DebugFormat("SignPlatform.FillCertificateParams(). Start filling parameters of certificates.");
      var errorCertificates = new List<long>();
      IQueryable<ICertificate> certificates = Enumerable.Empty<ICertificate>().AsQueryable();
      if (numberRecordsProcess == unlimitedQuantity)
        certificates = this.GetCertificatesToFillParameters();
      else if (numberRecordsProcess > 0)
        certificates = this.GetCertificatesToFillParameters().OrderBy(l => l.Id).Take(numberRecordsProcess);
      
      if (certificates.Any())
      {
        foreach (var certificate in certificates)
        {
          try
          {
            Logger.DebugFormat("SignPlatform.FillCertificateParams(). Filling in the parameters of the certificate '{0}' with Id {1}", certificate, certificate.Id);
            var certificateRequest = CertificateRequests.GetAll().Where(l => l.CertificateID == certificate.Id &&
                                                                        l.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered).FirstOrDefault();
            
            if (certificateRequest != null && !certificate.Parameters.Where(a => a.Key.Equals(Constants.Module.ProviderIdCertificateKeyParameter)).Any())
            {
              if (!string.IsNullOrEmpty(certificateRequest.ProviderId))
              {
                var providerIdParameter = certificate.Parameters.AddNew();
                providerIdParameter.Key = Constants.Module.ProviderIdCertificateKeyParameter;
                providerIdParameter.Value = certificateRequest.ProviderId;
              }
            }
            if (!certificate.Parameters.Where(a => a.Key.Equals(Constants.Module.OwnerIdCertificateKeyParameter)).Any())
            {
              var ownerIdParameter = certificate.Parameters.AddNew();
              ownerIdParameter.Key = Constants.Module.OwnerIdCertificateKeyParameter;
              ownerIdParameter.Value = EssPlatform.PublicFunctions.Module.Remote.GetUidPerson(EssPlatformSolution.Employees.As(certificate.Owner).Person);
            }
            certificate.Save();
          }
          catch (Sungero.Domain.Shared.Exceptions.RepeatedLockException ex)
          {
            Logger.DebugFormat("SignPlatform.FillCertificateParams(). A blocking error occurred while processing the certificate '{0}': {1}", certificate, ex.Message);
            errorCertificates.Add(certificate.Id);
          }
        }
      }
      else
      {
        Logger.DebugFormat("SignPlatform.FillCertificateParams() End filling parameters for certificates.");
        return Resources.NoCertificatesWithEmptyParameters;
      }
      
      Logger.DebugFormat("SignPlatform.FillCertificateParams(). End filling parameters for certificates.");
      return errorCertificates.Any() ? Resources.ErrorAddingParametersToCertificateFormat(string.Join(", ", errorCertificates)) : Resources.SuccessfullyAddingCertificateParameters;
    }
    
    /// <summary>
    /// Получить список сертификатов для заполнения параметров.
    /// </summary>
    /// <returns>Список сертификатов.</returns>
    public virtual System.Linq.IQueryable<Sungero.CoreEntities.ICertificate> GetCertificatesToFillParameters()
    {
      var certificates = Sungero.CoreEntities.Certificates.GetAll().Where(l => l.Enabled == true && l.PluginId.ToLower().Equals(Constants.Module.PluginIdOfCloudCertificates))
        .Where(l => !l.Parameters.Where(a => a.Key.Equals(Constants.Module.ProviderIdCertificateKeyParameter)).Any() ||
               !l.Parameters.Where(a => a.Key.Equals(Constants.Module.OwnerIdCertificateKeyParameter)).Any());
      
      return certificates;
    }
    
    /// <summary>
    /// Получить количество сертификатов с незаполненными параметрами.
    /// </summary>
    /// <returns>Ответ на запрос.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public virtual int GetNumberCertificatesWithBlankParameters()
    {
      var certificates = this.GetCertificatesToFillParameters();
      
      return certificates.Count();
    }
    
    /// <summary>
    /// Получить скрытый номер телефона
    /// </summary>
    /// <param name="phone">Номер телефона</param>
    /// <returns>Скрытый номер телефона</returns>
    [Public, Remote]
    public virtual string GetHiddenPhone(string phone)
    {
      phone = System.Text.RegularExpressions.Regex.Replace(phone, "[^0-9]", "");
      var hiddenLength = phone.Length - Constants.Module.HiddenPhone.FirstPartLength - Constants.Module.HiddenPhone.LastPartLength;
      var firstPart = phone.Substring(0, Constants.Module.HiddenPhone.FirstPartLength);
      var hiddenPart = phone.Substring(Constants.Module.HiddenPhone.FirstPartLength, hiddenLength);
      var lastPart = phone.Substring(Constants.Module.HiddenPhone.FirstPartLength + hiddenLength, Constants.Module.HiddenPhone.LastPartLength);
      var hiddenPhone = firstPart + System.Text.RegularExpressions.Regex.Replace(hiddenPart ,@"\d", "X")+ lastPart;
      return hiddenPhone;
    }
  }
}