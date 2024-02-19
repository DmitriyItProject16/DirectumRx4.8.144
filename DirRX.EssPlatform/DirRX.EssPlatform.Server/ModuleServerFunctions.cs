using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Sungero.Commons;
using Sungero.Company;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow;
using Sungero.Parties;
using RequestApiIdentity = DirRX.EssPlatform.Constants.Module.RequestApiIdentity;
using Sungero.Domain;
using Sungero.Domain.Shared;
using System.Reflection;

namespace DirRX.EssPlatform.Server
{
  public class ModuleFunctions
  {

    /// <summary>
    /// Сформировать ссылку на объект в личном кабинете пользователя.
    /// </summary>
    /// <param name="targetSystem">Имя целевой системы.</param>
    /// <param name="selfOfficeObjectType">Рабочий элменет/Услуга/Группа услуг.</param>
    /// <param name="objectType">Имя типа карточки.</param>
    /// <param name="id">Идентификатор.</param>
    /// <returns>Ссылка на сущность в личном кабинете.</returns>
    [Public]
    public string CreateHyperLinkToSelfOffice(string targetSystemName, string selfOfficeObjectType, string objectTypeName, string id)
    {
      var resultUrl = string.Empty;
      var selfOfficeUrl = Functions.EssSetting.GetSettings().ESSAddress.TrimEnd('/');
      switch (selfOfficeObjectType)
      {
        case Constants.Module.SelfOfficeObjectTypes.WorkItems:
          resultUrl = Resources.SelfOfficeObjectHyperlinkFormat(selfOfficeUrl, Constants.Module.SelfOfficeObjectTypes.WorkItems, targetSystemName, objectTypeName, id);
          break;
        case Constants.Module.SelfOfficeObjectTypes.Facilities:
          resultUrl = Resources.SelfOfficeFacilitiesHyperlinkFormat(selfOfficeUrl, Constants.Module.SelfOfficeObjectTypes.Facilities, id);
          break;
        case Constants.Module.SelfOfficeObjectTypes.FacilityGroups:
          resultUrl = Resources.SelfOfficeFacilitiesHyperlinkFormat(selfOfficeUrl, Constants.Module.SelfOfficeObjectTypes.FacilityGroups, id);
          break;
      }
      return resultUrl;
    }

    /// <summary>
    /// Проверить если ли сотрудники заблокирвоанные в рамках синхронизации данных.
    /// </summary>
    /// <param name="personId">ИД персоны.</param>
    [Public, Remote(IsPure = true)]
    public bool CheckLockedByAsyncEmployees(EssPlatformSolution.IEmployee employee)
    {
      return EssPlatformSolution.Employees.GetAll(p => p.Status == Sungero.Company.Employee.Status.Active && p.Person.Equals(employee.Person) && p.LockedByAsync == true).Any();
    }
    
    /// <summary>
    /// Проверить, является ли сотрудник персоны единственным действующим.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="oldStatus">Состояние.</param>
    /// <returns>True - если у персоны нет других действующих сотрудников, иначе - false.</returns>
    [Public, Remote]
    public bool IsSingleActivePersonEmployee(IEmployee employee, Enumeration? oldStatus)
    {
      if (oldStatus == Sungero.Company.Employee.Status.Closed)
        return false;
      
      var otherEmployees = Employees.GetAll(w => Equals(w.Person, employee.Person) && w.Status == Sungero.Company.Employee.Status.Active && w.Id != employee.Id);
      
      return !otherEmployees.Any();
    }
    
    /// <summary>
    /// Получить основного сотрудника персоны.
    /// </summary>
    /// <param name="personId">ИД персоны.</param>
    /// <param name="filterBusinessUnit">Фильтр по НОР.</param>
    /// <returns>Основной сотрудник персоны.</returns>
    [Public, Remote]
    public EssPlatformSolution.IEmployee GetPersonMainEmployee(long personId, IBusinessUnit filterBusinessUnit)
    {
      var employees = this.EmployeesByPersonId(personId);
      
      if (filterBusinessUnit != null)
      {
        var employeesByBusinessUnit = employees.Where(w => Equals(w.BusinessUnitDirRX, filterBusinessUnit));
        return employeesByBusinessUnit.FirstOrDefault();
      }

      return employees.FirstOrDefault();
    }

    /// <summary>
    /// Проверить номер телефона ЛК.
    /// </summary>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <param name="employee">Сотрудник.</param>
    [Public, Remote]
    public virtual List<string> CheckPersonalPhoneNumber(string phoneNumber, DirRX.EssPlatformSolution.IEmployee employee)
    {
      var errorsList = new List<string>();
      if (!string.IsNullOrEmpty(phoneNumber))
      {
        if (!Functions.Module.PhoneNumberLengthIsValid(phoneNumber, false))
        {
          errorsList.Add(DirRX.EssPlatformSolution.Employees.Resources.PersonalPhoneNumbersCountError);
        }
        else
        {
          var phone = EssPlatform.PublicFunctions.Module.PhoneNumberToUniversalFormat(phoneNumber);
          
          if (PublicFunctions.EssSetting.Remote.SettingsConnected())
          {
            // Проверить уникальность номера в базе личного кабинета.
            DirRX.EssPlatform.Structures.Module.IdSUserInfo resultSearch = null;
            try
            {
              resultSearch = EssPlatform.PublicFunctions.Module.FindIdsUser(phone);
            }
            catch (AppliedCodeException ex)
            {
              errorsList.Add(ex.Message);
            }
            
            if (!string.IsNullOrEmpty(resultSearch.Name) && resultSearch.Name != EssPlatform.PublicFunctions.Module.Remote.GetUidPerson(employee.Person))
              errorsList.Add(DirRX.EssPlatformSolution.Employees.Resources.PersonalPhoneNotUniqInESS);
          }
          
          // Проверить уникальность номера в персонах.
          var result = DirRX.EssPlatformSolution.Employees.GetAll(e => e.PersonalPhoneDirRX == phone && e.Person.Id != employee.Person.Id);
          if (result.Any())
            errorsList.Add(DirRX.EssPlatformSolution.Employees.Resources.PersonalPhoneNotUniq);
        }
      }
      return errorsList;
    }
    
    /// <summary>
    /// Найти роли модуля.
    /// </summary>
    /// <returns>Список ролей модуля.</returns>
    [Remote]
    public virtual List<IRole> GetEssRoles()
    {
      return Sungero.CoreEntities.Roles.GetAll(r => r.Sid == Constants.Module.UsersWithAccessToIdentityDocument ||
                                               r.Sid == Constants.Module.AdminElEmployeeInteractionSystem).ToList();
    }

    #region Старт асинхронных обработчиков
    
    /// <summary>
    /// Создать асинхронное событие для изменения статуса личного кабинета для сотрудника.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="status">Статус ЛК.</param>
    [Public]
    public void ChangePersonalAccountStatus(EssPlatformSolution.IEmployee employee, Sungero.Core.Enumeration status)
    {
      var asyncChangeEssStatus = EssPlatform.AsyncHandlers.ChangeEmployeeEssStatus.Create();
      asyncChangeEssStatus.EmployeeId = employee.Id;
      asyncChangeEssStatus.EssStatus = status.ToString();
      asyncChangeEssStatus.changeTime = Calendar.Now;
      asyncChangeEssStatus.initiatorName = Users.Current.Login.ToString();
      asyncChangeEssStatus.ExecuteAsync();
    }
    #endregion
    
    #region Активация, изменение, удаление и поиск пользователя ЛК
    
    /// <summary>
    /// Получить уникальный идентификатор персоны в рамках тенанта.
    /// </summary>
    /// <param name="person">Персона</param>
    /// <returns>Идентификатор.</returns>
    [Public, Remote]
    public virtual string GetUidPerson(Sungero.Parties.IPerson person)
    {
      return Sungero.Core.TenantInfo.TenantId + "@" + person.Id;
    }
    
    /// <summary>
    /// Заполнить данные пользователя в json-строку.
    /// </summary>
    /// <param name="person">Персона.</param>
    /// <param name="user">Пользователь.</param>
    /// <param name="phone">Номер телефона.</param>
    /// <returns>Сериализованная строка.</returns>
    [Remote, Public]
    public virtual string CreateUserStructure(Sungero.Parties.IPerson person, IUser user, string phone)
    {
      var personUid = GetUidPerson(person);
      
      var personData = DirRX.EssPlatform.Structures.Module.PersonData.Create();
      personData.givenName = person.FirstName;
      personData.patronym = person.MiddleName;
      personData.phone = phone;
      personData.surname = person.LastName;
      
      var identites = DirRX.EssPlatform.Structures.Module.Claim.Create();
      identites.DirectumRX_PersonId = person.Id;
      
      var authentication = DirRX.EssPlatform.Structures.Module.Authentication.Create();
      // Убираем передачу типа аутентификации, так как пользователь теперь всегда будет создаваться без аутентификации.
      authentication.provider = string.Empty;
      
      var userEssJson = DirRX.EssPlatform.Structures.Module.EssUserActivateJson.Create();
      userEssJson.userName = personUid;
      userEssJson.person = personData;
      userEssJson.identities = identites;
      userEssJson.authentication = authentication;
      userEssJson.inviteToResource = DirRX.EssPlatform.Constants.Module.Audiences.EssSite;
      
      return SerializedToJson(userEssJson).Replace("DirectumRX_PersonId", "DirectumRX/PersonId");
    }
    
    /// <summary>
    /// Отправить запрос на активацию пользователя.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    [Public, Remote]
    public virtual void ActivateESSUser(EssPlatformSolution.IEmployee employee)
    {
      ActivateESSUser(employee, employee.Person, employee.PersonalPhoneDirRX, employee.BusinessUnitDirRX);
    }
    
    /// <summary>
    /// Отправить запрос на активацию пользователя.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    /// <param name="person">Персона.</param>
    /// <param name="phone">Номер телефона.</param>
    /// <param name="businessUnit">Организация.</param>
    [Public, Remote]
    public virtual void ActivateESSUser(IUser user, Sungero.Parties.IPerson person, string phone, Sungero.Company.IBusinessUnit businessUnit)
    {
      try
      {
        var personUid = GetUidPerson(person);
        
        Logger.DebugFormat("EssPlatform.ModuleServerFunctions.ActivateESSUser(). Activate Ess user {0}.", personUid);
        
        var baseUri = PublicFunctions.EssSetting.GetSettings().EssServiceAddress;
        var token = GetAnAuthenticationToken(EssPlatform.Constants.Module.Audiences.EssService);
        // Если пользователя с таким логином не нашли (не было или безвозвратно отключили) - создать его с передачей данных, иначе активировать существующего.
        var jsonString = string.Empty;
        var requestUri = string.Empty;
        if (ExistsIdsUser(personUid))
          requestUri = string.Format(EssPlatform.Constants.Module.RequestApiIdentity.ActivateDisabledEssUser, personUid);
        else
        {
          requestUri = EssPlatform.Constants.Module.RequestApiIdentity.ActivateUser;
          
          jsonString = CreateUserStructure(person, user, phone).Replace("DirectumRX_PersonId", "DirectumRX/PersonId");
        }
        
        // Отправить запрос на активацию пользователя.
        var result = RunPostRequest(baseUri, requestUri, jsonString, token);
        // При первичном создании возвращается код 200.
        if (result.StatusCode == 200)
        {
          Logger.Debug("EssPlatform.ModuleServerFunctions.ActivateESSUser(). User created.");
          return;
        }
        // При активации ранее отключенного - код 204.
        else if (result.StatusCode == 204)
        {
          Logger.Debug("EssPlatform.ModuleServerFunctions.ActivateESSUser(). User activated.");
          var businessUnitForSms = EssPlatformSolution.BusinessUnits.As(businessUnit);
          Functions.Module.SendSMS(phone, businessUnitForSms.SmsAfterActivateDirRX.Replace("#URL_SITE_ESS", Functions.EssSetting.GetSettings().ESSAddress));
          return;
        }
        else
          throw new Exception(DirRX.EssPlatform.Resources.ActivateESSUserExceptionFormat(result.StatusCode, result.RequestMessage));
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.ActivateESSUser(). An error occurred while sending the request: {0}.", ex.Message);
        throw new Exception(ex.Message);
      }
    }

    /// <summary>
    /// Добавить пользователей в личный кабинет.
    /// </summary>
    /// <param name="businessUnitIds">ИД наших организаций.</param>
    /// <param name="departmentIds">ИД подразделений.</param>
    /// <param name="employeeIds">ИД сотрудников.</param>
    /// <param name="identificationType">Тип идентификации (personal, esia).</param>
    /// <param name="author">Автор.</param>
    /// <param name="providerId">Id провайдера.</param>
    /// <param name="includeSubDepartments">true, если включены подчиненные подразделения.</param>
    /// <returns>Структура, содержащая всю информацию по созданию личных кабинетов сотрудников.
    /// Error содержит информацию об ошибках, произошедших в результате создания личного кабинета.
    /// WithoutPhoneUsersCount содержит кол-во сотрудников без личного телефона.
    /// AlreadyInvitedUsersCount содержит кол-во сотрудников, у которых уже есть личный кабинет.
    /// InvitedUsersCount содержит кол-во сотркудников, которым высланы приглашения.</returns>
    [Public]
    public virtual DirRX.EssPlatform.Structures.Module.ICreateEssUsersResults ActivateESSUsers(List<string> businessUnitIds, List<string> departmentIds, List<string> employeeIds, string identificationType, IUser author, string providerId, bool includeSubDepartments)
    {
      Logger.Debug("Process CreateEssUsers started");
      
      var result = DirRX.EssPlatform.Structures.Module.CreateEssUsersResults.Create();

      var employees = EssPlatformSolution.Employees.GetAll().Where(emp => emp.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                                                   && emp.Department != null
                                                                   && emp.Department.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                                                   && emp.Department.BusinessUnit != null
                                                                   && emp.Department.BusinessUnit.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                                                   && EssPlatformSolution.BusinessUnits.As(emp.Department.BusinessUnit).UseESSDirRX.HasValue
                                                                   && EssPlatformSolution.BusinessUnits.As(emp.Department.BusinessUnit).UseESSDirRX.Value);
      if (employeeIds.Any())
        employees = employees.Where(emp => employeeIds.Contains(emp.Id.ToString()));
      else if (includeSubDepartments && departmentIds.Any())
      {
        IQueryable<EssPlatformSolution.IEmployee> employeesList = Enumerable.Empty<EssPlatformSolution.IEmployee>().AsQueryable();
        foreach(var departmentId in departmentIds)
        {
          var department = Departments.Get(long.Parse(departmentId));
          var subEmployees = EssPlatformSolution.Employees.GetAll().AsEnumerable().Where(emp => emp.Status == Sungero.CoreEntities.DatabookEntry.Status.Active &&
                                                                                         emp.Department != null && emp.Department.Status == Sungero.CoreEntities.DatabookEntry.Status.Active &&
                                                                                         emp.Department.BusinessUnit != null && emp.Department.BusinessUnit.Status == Sungero.CoreEntities.DatabookEntry.Status.Active &&
                                                                                         EssPlatformSolution.BusinessUnits.As(emp.Department.BusinessUnit).UseESSDirRX.HasValue &&
                                                                                         EssPlatformSolution.BusinessUnits.As(emp.Department.BusinessUnit).UseESSDirRX.Value && emp.IncludedIn(department));
          employeesList = employeesList.Concat(subEmployees);
        }
        employees = employeesList;
      }
      else if (departmentIds.Any())
        employees = employees.Where(emp => departmentIds.Contains(emp.Department.Id.ToString()));
      else if (businessUnitIds.Any())
        employees = employees.Where(emp => businessUnitIds.Contains(emp.Department.BusinessUnit.Id.ToString()));

      var mainEmployeesIDs = new List<long>();
      foreach (var employee in employees)
      {
        if(employee.Equals(EssPlatform.PublicFunctions.Module.Remote.GetPersonMainEmployee(employee.Person.Id, null)))
          mainEmployeesIDs.Add(employee.Id);
      }
      employees = employees.Where(emp => mainEmployeesIDs.Contains(emp.Id));
      
      var usersWithoutPhone = employees.ToList().Where(emp => string.IsNullOrEmpty(emp.PersonalPhoneDirRX)).ToList();
      if (usersWithoutPhone.Any())
      {
        foreach (var user in usersWithoutPhone)
        {
          Logger.DebugFormat("{0} hasn't personal phone.", user.Name);
        }
      }
      
      var settings = EssPlatform.PublicFunctions.EssSetting.GetSettings();
      var usersWithoutEmail = employees.Where(e => (((e.ConfirmationTypeDirRX.HasValue && e.ConfirmationTypeDirRX.Value == DirRX.EssPlatformSolution.Employee.ConfirmationTypeDirRX.DefaultValue) &&
                                                     settings.ConfirmationType == EssPlatform.EssSetting.ConfirmationType.Email) ||
                                                    (e.ConfirmationTypeDirRX.HasValue && e.ConfirmationTypeDirRX.Value == DirRX.EssPlatformSolution.Employee.ConfirmationTypeDirRX.Email)) &&
                                              (e.Email == null && e.MessagesEmailDirRX == null)).ToList();
      if (usersWithoutEmail.Any())
      {
        foreach (var user in usersWithoutEmail)
        {
          Logger.DebugFormat("{0} hasn't work email or personal email.", user.Name);
        }
      }
      
      var usersWithInviteAccepted = employees.ToList().Where(emp => emp.PersonalAccountStatusDirRX == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted).ToList();
      if (usersWithInviteAccepted.Any())
      {
        foreach (var user in usersWithInviteAccepted)
        {
          Logger.DebugFormat("{0} already has personal office.", user.Name);
        }
      }
      
      var usersWithInviteSent = employees.ToList().Where(emp => emp.PersonalAccountStatusDirRX == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteSent).ToList();
      if (usersWithInviteSent.Any())
      {
        foreach (var user in usersWithInviteSent)
        {
          Logger.DebugFormat("{0} already sent invite to personal office.", user.Name);
        }
      }
      
      var usersToInvite = employees.ToList().Where(emp => !string.IsNullOrEmpty(emp.PersonalPhoneDirRX)
                                                   && emp.PersonalAccountStatusDirRX == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent
                                                   && !usersWithoutEmail.Contains(emp)).ToList();
      foreach(var empl in usersToInvite)
      {
        Logger.DebugFormat("{0} inviting...", empl.Name);
        
        try
        {
          var person = DirRX.EssPlatformSolution.People.Get(empl.Person.Id);
          if (identificationType == DirRX.EssPlatformSolution.Person.IdentificationTypeDirRx.Personal.Value)
          {
            if (person.IdentificationTypeDirRx != EssPlatformSolution.Person.IdentificationTypeDirRx.Personal)
            {
              person.IdentificationTypeDirRx = EssPlatformSolution.Person.IdentificationTypeDirRx.Personal;
            }
          }
          else if (identificationType == DirRX.EssPlatformSolution.Person.IdentificationTypeDirRx.Esia.Value)
          {
            if (person.IdentificationTypeDirRx != EssPlatformSolution.Person.IdentificationTypeDirRx.Esia)
            {
              person.IdentificationTypeDirRx = EssPlatformSolution.Person.IdentificationTypeDirRx.Esia;
            }
          }
          else
          {
            Logger.Error(DirRX.SignPlatform.Resources.InvalidIdentificationTypeFormat(empl.Name));
            result.Error = DirRX.SignPlatform.Resources.InvalidIdentificationTypeFormat(empl.Name);
            result.CatchErrorUsersCount ++;
            continue;
          }
          person.Save();
          
          if (empl.Person.TIN != null && empl.Person.INILA != null && empl.Person.DateOfBirth != null
              && DirRX.EssPlatformSolution.People.As(empl.Person).IdentityDocumentKind != null)
          {
            if(Locks.GetLockInfo(empl).IsLocked == false)
            {
              // Отправить запрос на подключение к ЛК
              ActivateESSUser(empl);
              // Сменить статус подключения сотрудника.
              Logger.Debug("Start ChangeEmployeeEssStatus from ActivateESSUsers");
              EssPlatform.PublicFunctions.Module.ChangePersonalAccountStatus(empl, EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteSent);
            }
            else
            {
              Logger.Error(DirRX.EssPlatform.Resources.EmployeeCardIsLockedFormat(empl.Name));
              result.Error = DirRX.EssPlatform.Resources.EmployeeCardIsLockedFormat(empl.Name);
              result.CatchErrorUsersCount ++;
              continue;
            }
          }
          else
          {
            Logger.Error(DirRX.EssPlatform.Resources.PersonRequiredInfoEmptyFormat(empl.Name));
            result.Error = DirRX.EssPlatform.Resources.PersonRequiredInfoEmptyFormat(empl.Name);
            result.CatchErrorUsersCount ++;
            continue;
          }
        }
        catch (Exception ex)
        {
          Logger.Error("Error: " + ex.Message);
          result.Error = ex.Message;
          result.CatchErrorUsersCount ++;
          continue;
        }
        // Выпустить сертификат.
        try
        {
          if (empl.Person.TIN != null && empl.Person.INILA != null && empl.Person.DateOfBirth != null
              && DirRX.EssPlatformSolution.People.As(empl.Person).IdentityDocumentKind != null)
          {
            // Стартовать задачу на выпуск сертификата.
            DirRX.SignPlatform.PublicFunctions.Module.Remote.IssueCertificate(empl, author, providerId);
          }
        }
        catch (Exception ex)
        {
          Logger.Error("Error: " + ex.Message);
          continue;
        }
      }
      
      result.InvitedUsersCount = usersToInvite.Count() - result.CatchErrorUsersCount;
      result.AlreadyInvitedUsersCount = usersWithInviteSent.Count();
      result.AlreadyAcceptedUsersCount = usersWithInviteAccepted.Count();
      result.WithoutPhoneUsersCount = usersWithoutPhone.Count();
      result.WithoutEmailUsersCount = usersWithoutEmail.Count();
      Logger.Debug("CreateEssUsers ended = = = = =");
      return result;
    }
    
    /// <summary>
    /// Изменить информацию о пользователе личного кабинета
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    [Public, Remote]
    public virtual void PatchEssUser(EssPlatformSolution.IEmployee employee)
    {
      try
      {
        var personUid = GetUidPerson(employee.Person);
        var idSUrl = PublicFunctions.EssSetting.GetSettings().EssServiceAddress;
        var token = GetAnAuthenticationToken(EssPlatform.Constants.Module.Audiences.EssService);
        // Cоздать структуру для формирования json-контента.
        var userEssJson = new Structures.Module.UserPatchJson();
        userEssJson.givenName = employee.Person.FirstName;
        userEssJson.surname = employee.Person.LastName;
        userEssJson.patronym = employee.Person.MiddleName;
        userEssJson.phoneNumber = employee.PersonalPhoneDirRX;
        // userEssJson.email = string.Empty;
        
        var requestResult = RunPatchRequest(idSUrl, String.Format(EssPlatform.Constants.Module.RequestApiIdentity.PatchEssUser, personUid), SerializedToJson(userEssJson), token);
        var statusCode = requestResult.StatusCode;
        if (statusCode == (int)HttpStatusCode.NoContent)
          return;
        // Ответы, отличные от 204 считать ошибками и пробрасывать дальше.
        throw new Exception(Resources.FindEssUserExceptionFormat(statusCode, requestResult.RequestMessage));
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.PatchEssUser(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Удалить пользователя из личного кабинета.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    public virtual void DeleteESSUser(EssPlatformSolution.IEmployee employee)
    {
      try
      {
        var personUid = GetUidPerson(employee.Person);
        var token = GetAnAuthenticationToken(EssPlatform.Constants.Module.Audiences.EssService);
        var baseUri = PublicFunctions.EssSetting.GetSettings().EssServiceAddress;
        var requestApi = string.Format(Constants.Module.RequestApiIdentity.DeleteEssUser, personUid);
        
        RunDeleteRequest(baseUri, requestApi, token);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.DeleteESSUser(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Временно отключить пользователя от личного кабинета.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    public virtual void DisableESSUser(EssPlatformSolution.IEmployee employee)
    {
      try
      {
        var personUid = GetUidPerson(employee.Person);
        var token = GetAnAuthenticationToken(EssPlatform.Constants.Module.Audiences.EssService);
        var baseUri = PublicFunctions.EssSetting.GetSettings().EssServiceAddress;
        var requestApi = string.Format(Constants.Module.RequestApiIdentity.DisableEssUser, personUid);
        
        RunPostRequest(baseUri, requestApi, string.Empty, token);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.ShutdownESSUser(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }

    /// <summary>
    /// Найти пользователя по имени (name) или номеру телефона сотрудника.
    /// </summary>
    /// <param name="searchParam">Номер телефона или Uid пользователя.</param>
    /// <returns>Струкутура со информацией о пользователе. Если пользователь не найден, то поля структуры будут пустые.</returns>
    [Public]
    public virtual Structures.Module.IdSUserInfo FindIdsUser(string searchParam)
    {
      try
      {
        var token = GetAnAuthenticationTokenCurrentSystem();
        var idSUrl = PublicFunctions.EssSetting.GetSettings().IdentityServiceAddress;
        // IdS обрабатывает номер без "+", удалить.
        var getRequestResult = RunGetRequest(idSUrl, string.Format(Constants.Module.RequestApiIdentity.FindEssUser, searchParam.Replace("+", "")), token);
        var statusCode = getRequestResult.StatusCode;
        if (statusCode == (int)HttpStatusCode.OK)
        {
          return JsonConvert.DeserializeObject<Structures.Module.IdSUserInfo>(getRequestResult.RequestMessage);
        }
        if (statusCode == (int)HttpStatusCode.NotFound)
        {
          return (Structures.Module.IdSUserInfo)Structures.Module.IdSUserInfo.Create(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }
        // Ответы, отличные от 200 и 404 считать ошибками и пробрасывать дальше.
        throw new Exception(Resources.FindEssUserExceptionFormat(statusCode, getRequestResult.RequestMessage));
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.FindIdsUser(). An error occurred while sending the find request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Узнать, существует ли пользователь с указанным именем (name) или номером телефона сотрудника.
    /// </summary>
    /// <param name="searchParam">Номер телефона или Uid пользователя.</param>
    /// <returns>Струкутура со информацией о пользователе. Если пользователь не найден, то поля структуры будут пустые.</returns>
    [Public, Remote]
    public virtual bool ExistsIdsUser(string searchParam)
    {
      try
      {
        var userData = FindIdsUser(searchParam);
        return !string.IsNullOrWhiteSpace(userData.Id);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.ExistsIdsUser(). An error occurred while sending the find request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Временно отключить пользователя личного кабинета.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    [Public, Remote]
    public virtual void TemporaryDisconnectEssUser(EssPlatformSolution.IEmployee employee)
    {
      var personUid = GetUidPerson(employee.Person);
      var businessUnit = EssPlatformSolution.BusinessUnits.As(employee.Department.BusinessUnit);
      try
      {
        DisableESSUser(employee);
      }
      catch (Exception ex)
      {
        throw AppliedCodeException.Create(DirRX.EssPlatform.Resources.DisconnectEssUserError, ex);
      }
      
      try
      {
        Functions.Module.SendSMS(employee.PersonalPhoneDirRX, businessUnit.SmsAfterTemporaryCloseDirRX);
      }
      catch (Exception ex)
      {
        throw AppliedCodeException.Create(DirRX.EssPlatform.Resources.DisconnectEssUserError, ex);
      }
      
      EssPlatform.PublicFunctions.Module.ChangePersonalAccountStatus(employee, EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent);
    }
    
    /// <summary>
    /// Отключить пользователя личного кабинета.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    [Public, Remote]
    public virtual void DisconnectEssUser(EssPlatformSolution.IEmployee employee)
    {
      var personUid = GetUidPerson(employee.Person);
      var businessUnit = EssPlatformSolution.BusinessUnits.As(employee.Department.BusinessUnit);
      Logger.DebugFormat("EssPlatform.ModuleServerFunctions.DisconnectESSUser(): user {0} disconnected started.", personUid);
      
      try
      {
        DeleteESSUser(employee);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.DisconnectESSUser(). An error occurred while diconnecting: {0}.", ex.Message);
        throw AppliedCodeException.Create(DirRX.EssPlatform.Resources.DisconnectEssUserError, ex);
      }
      
      Logger.DebugFormat("EssPlatform.ModuleServerFunctions.DisconnectESSUser(): user {0} disconnected.", personUid);
      
      Logger.DebugFormat("EssPlatform.ModuleServerFunctions.DisconnectESSUser(): send sms to user {0}.", personUid);
      
      try
      {
        Functions.Module.SendSMS(employee.PersonalPhoneDirRX, businessUnit.SmsAfterCloseDirRX);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.DisconnectESSUser(): could not send SMS to user {0}. Error: {1}.", personUid, ex.Message);
        throw AppliedCodeException.Create(DirRX.EssPlatform.Resources.DisconnectEssUserError, ex);
      }
      
      EssPlatform.PublicFunctions.Module.ChangePersonalAccountStatus(employee, EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent);
    }
    
    /// <summary>
    /// Обновить пользователя личного кабинета.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <remarks>- Если необходимо поменять номер, но сотрудник не включен в НОР или НОР не подключена к ЛК, СМС отправлены не будут, информация о пользователе не обновится.
    /// - Если было необходимо поменять номер, но процедура отправки СМС прошла неуспешно, информация о пользователе не обновится.</remarks>
    [Public]
    public virtual void UpdateEssUser(EssPlatformSolution.IEmployee employee, string oldPhoneNumber)
    {
      var uid = Functions.Module.GetUidPerson(employee.Person);
      Logger.DebugFormat("EssPlatform.ModuleServerFunctions.UpdateEssUser: user {0} update started.", uid);
      
      // Если передан старый номер телефона, значит номер сотрудника изменился - запустить процедуру по смене номера.
      if (!string.IsNullOrEmpty(oldPhoneNumber))
      {
        if (employee.Department.BusinessUnit != null)
        {
          var businessUnit = EssPlatformSolution.BusinessUnits.As(employee.Department.BusinessUnit);
          if (businessUnit.UseESSDirRX.HasValue && businessUnit.UseESSDirRX.Value)
          {
            if (oldPhoneNumber != employee.PersonalPhoneDirRX)
            {
              Logger.DebugFormat("EssPlatform.ModuleServerFunctions.UpdateEssUser: user {0} phone change started.", uid);
              try
              {
                SendSMS(oldPhoneNumber, businessUnit.SmsToOldPhoneDirRX);
                SendSMS(employee.PersonalPhoneDirRX, businessUnit.SmsToNewPhoneDirRX);
              }
              catch (Exception ex)
              {
                
                Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.UpdateEssUser: could not send SMS to user {0}. Error: {1}.", uid, ex.Message);
                throw AppliedCodeException.Create(DirRX.EssPlatform.Resources.UpdateEssuserError);
              }
            }
          }
          else
          {
            Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.UpdateEssUser: could not send SMS to user {0}. Business unit of user in not connected to Self Service Office.", uid);
            return;
          }
        }
        else
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.UpdateEssUser: could not send SMS to user {0}. Business unit of user is not defined.", uid);
          return;
        }
      }
      
      try
      {
        EssPlatform.PublicFunctions.Module.Remote.PatchEssUser(employee);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.UpdateEssUser: could not update EssUser. Employee id: {0}. Error: {1}.", employee.Id, ex.Message);
        throw AppliedCodeException.Create(DirRX.EssPlatform.Resources.UpdateEssuserError);
      }
    }
    
    /// <summary>
    /// Отправить уведомление - результат об отправке приглашений.
    /// </summary>
    /// <param name="userId">ИД пользователя.</param>
    /// <param name="text">Текст уведомления.</param>
    [Public]
    public virtual void SendNoticeAboutInvite(long userId, string text)
    {
      var recipients = new[] {Recipients.As(Users.Get(userId))};
      var task = Sungero.Workflow.SimpleTasks.CreateWithNotices(Resources.ESSNoticeSubject, recipients);
      task.ActiveText = text;
      task.Start();
    }
    /// <summary>
    /// Получить кол-во минут для следущего запуска асинхронного обработчика карточки сотрудника
    /// </summary>
    /// <param name="retryIteration">Номер итерации</param>
    /// <param name="maxRetry">Максимальное кол-во итераций</param>
    /// <returns>Кол-во минут до следущего запуска обработчика</returns>
    [Public]
    public virtual int GetMinutesToNextAsyncExecute(int retryIteration, int maxRetry)
    {
      var iterationWaitMinutes = new [] {2, 3, 4, 5, 15, 20, 300};
      var lastIndex = iterationWaitMinutes.Count() - 1;
      var addedMinutes = iterationWaitMinutes.FirstOrDefault();
      if (retryIteration <= lastIndex - 1)
      {
        addedMinutes = iterationWaitMinutes[retryIteration];
      }
      else if((retryIteration > lastIndex - 1) && (retryIteration < maxRetry))
      {
        addedMinutes = iterationWaitMinutes[lastIndex - 1];
      }
      else if (retryIteration >= maxRetry)
      {
        addedMinutes = iterationWaitMinutes[lastIndex];
      }
      return addedMinutes;
    }
    
    #endregion

    #region Запросы к MessageBroker Service

    /// <summary>
    /// Отправить SMS пользователю
    /// </summary>
    /// <param name="phoneNumber">Номер телефона</param>
    /// <param name="sms">Текст</param>
    [Public]
    public void SendSMS(string phoneNumber, string sms)
    {
      // Если отключена настройка "Подключить сервис идентификации", то отправка СМС выполняться не будет.
      if (!EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected())
        return;
      
      try
      {
        var token = GetAnAuthenticationTokenMessageBroker();
        var messageBrokerUrl = PublicFunctions.EssSetting.GetSettings().MessageBrokerAddress;
        var requestApi = String.Format(EssPlatform.Constants.Module.RequestApiMessageBroker.Sms, phoneNumber);
        var requestResult = RunPostRequest(messageBrokerUrl, requestApi, SerializedToJson(sms), token);
        var statusCode = requestResult.StatusCode;
        if (statusCode == (int)HttpStatusCode.OK)
          return;
        // Ответы, отличные от 200 считать ошибками и пробрасывать дальше.
        throw new Exception(DirRX.EssPlatform.Resources.SendSMSErrorFormat(statusCode, requestResult.RequestMessage));
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.SendSMS(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Отправить e-mail пользователю
    /// </summary>
    /// <param name="email">E-mail</param>
    /// <param name="subject">Тема</param>
    /// <param name="text">Текст</param>
    [Public]
    public void SendEMail(string email, string subject, string text)
    {
      // Если отключена настройка "Подключить сервис идентификации", то отправка E-mail выполняться не будет.
      if (!EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected())
        return;
      
      try
      {
        var token = GetAnAuthenticationTokenMessageBroker();
        var messageBrokerUrl = PublicFunctions.EssSetting.GetSettings().MessageBrokerAddress;
        var requestApi = String.Format(EssPlatform.Constants.Module.RequestApiMessageBroker.Email, email, subject);
        var requestResult = RunPostRequest(messageBrokerUrl, requestApi, SerializedToJson(text), token);
        var statusCode = requestResult.StatusCode;
        if (statusCode == (int)HttpStatusCode.OK)
          return;
        // Ответы, отличные от 200 считать ошибками и пробрасывать дальше.
        throw new Exception(DirRX.EssPlatform.Resources.SendEMailErrorFormat(statusCode, requestResult.RequestMessage));
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.SendEMail(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Отправить сообщение в Viber пользователю
    /// </summary>
    /// <param name="phoneNumber">Номер телефона</param>
    /// <param name="message">Текст</param>
    [Public]
    public void SendMessageToViber(string phoneNumber, string message)
    {
      // Если отключена настройка "Подключить сервис идентификации", то отправка сообщения в Viber выполняться не будет.
      if (!EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected())
        return;
      
      try
      {
        var token = GetAnAuthenticationTokenMessageBroker();
        var messageBrokerUrl = PublicFunctions.EssSetting.GetSettings().MessageBrokerAddress;
        var requestApi = String.Format(EssPlatform.Constants.Module.RequestApiMessageBroker.Viber, phoneNumber);
        var requestResult = RunPostRequest(messageBrokerUrl, requestApi, SerializedToJson(message), token);
        var statusCode = requestResult.StatusCode;
        if (statusCode == (int)HttpStatusCode.OK)
          return;
        // Ответы, отличные от 200 считать ошибками и пробрасывать дальше.
        throw new Exception(DirRX.EssPlatform.Resources.SendViberErrorFormat(statusCode, requestResult.RequestMessage));
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.SendMessageToViber(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Проверить подключение до ЛК.
    /// </summary>
    /// <param name="MBUrl">Адрес ЛК.</param>
    /// <returns>Если соединение установлено - пустая строка, иначе текст ошибки.</returns>
    [Public, Remote]
    public virtual string CheckESSConnection(string EssUrl)
    {
      try
      {
        var result = RunGetRequest(EssUrl, string.Empty, string.Empty);
        if (result.StatusCode == (int)HttpStatusCode.OK)
          return string.Empty;
        else
          return DirRX.EssPlatform.Resources.CheckConnectionErrorFormat(result.StatusCode);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("CheckEssConnection(). An error occurred while sending the request: {0}.", ex.Message);
        return ex.Message;
      }
    }
    
    /// <summary>
    /// Проверить подключение до MB.
    /// </summary>
    /// <param name="MBUrl">Адрес сервиса MessageBroker.</param>
    /// <returns>Если соединение установлено - пустая строка, иначе текст ошибки.</returns>
    [Public, Remote]
    public virtual string CheckMessageBrokerConnection(string MBUrl)
    {
      try
      {
        var result = RunGetRequest(MBUrl, Constants.Module.RequestApiMessageBroker.MessageBrokerHealth, string.Empty);
        if (result.StatusCode == (int)HttpStatusCode.OK)
          return string.Empty;
        else
          return DirRX.EssPlatform.Resources.CheckConnectionErrorFormat(result.StatusCode);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("CheckMBConnection(). An error occurred while sending the request: {0}.", ex.Message);
        return ex.Message;
      }
    }
    
    /// <summary>
    /// Проверить подключение до EssService.
    /// </summary>
    /// <param name="MBUrl">Адрес сервиса личного кабинета.</param>
    /// <returns>Если соединение установлено - пустая строка, иначе текст ошибки.</returns>
    [Public, Remote]
    public virtual string CheckEssServiceConnection(string MBUrl)
    {
      try
      {
        var result = RunGetRequest(MBUrl, Constants.Module.RequestApiIdentity.EssServiceHealth, string.Empty);
        if (result.StatusCode == (int)HttpStatusCode.OK)
          return string.Empty;
        else
          return DirRX.EssPlatform.Resources.CheckConnectionErrorFormat(result.StatusCode);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("CheckEssServiceConnection(). An error occurred while sending the request: {0}.", ex.Message);
        return ex.Message;
      }
    }

    /// <summary>
    /// Проверить подключение до SignService.
    /// </summary>
    /// <param name="signServiceUrl">Адрес сервиса SignService.</param>
    /// <returns>Если соединение установлено - пустая строка, иначе текст ошибки.</returns>
    [Public, Remote]
    public virtual string CheckSignServiceConnection(string signServiceUrl)
    {
      try
      {
        var result = RunGetRequest(signServiceUrl, SignPlatform.PublicConstants.Module.RequestApiSignService.SignServiceHealth, string.Empty);
        if (result.StatusCode == (int)HttpStatusCode.OK)
          return string.Empty;
        else
          return DirRX.EssPlatform.Resources.CheckConnectionErrorFormat(result.StatusCode);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("CheckSignServiceConnection(). An error occurred while sending the request: {0}.", ex.Message);
        return ex.Message;
      }
    }
    
    [Public]
    /// <summary>
    /// Подготовка структуры с описанием сообщения-колокольчика в ЛК
    /// </summary>
    /// <param name="employee">Сотрудник, которому надо отправить сообщение.</param>
    /// <returns>Структура с описанием сообщения</returns>
    public virtual EssPlatform.Structures.Module.IMessageBrokerNotification CreateEmptyEssNotification(EssPlatformSolution.IEmployee employee)
    {
      try
      {
        // Структура для уведомления
        var result = DirRX.EssPlatform.Structures.Module.MessageBrokerNotification.Create();
        result.Properties = new Dictionary<string, string>();
        result.Attachments = new List<DirRX.EssPlatform.Structures.Module.IMessageBrokerNotificationAttachment>();
        
        // сотрудник, которому отправляется сообщение
        var identity = DirRX.EssPlatform.Structures.Module.MessageBrokerNotificationIdentity.Create();
        identity.CredentialType = Constants.Module.RequestApiMessageBroker.CredentialType;
        identity.CredentialValue = GetUidPerson(employee.Person);
        result.Identity = identity;
        
        // дефолтные параметры доставки
        result.DeliveryMethod = 1;
        result.Priority = 1;

        return result;
      }
      catch (Exception ex)
      {
        Logger.Error(ex.Message);
        throw ex;

      }
    }

    /// <summary>
    /// Подготовка структуры с описанием вложения в сообщение-колокольчик в ЛК
    /// </summary>
    /// <param name="title">Название вложения.</param>
    /// <param name="id">Id документа с вложением.</param>
    /// <returns>Структура с описанием вложения. В качестве вложений поддерживаются только документы</returns>
    [Public]
    public virtual EssPlatform.Structures.Module.IMessageBrokerNotificationAttachment CreateAttachmentNotification(string title, long id)
    {
      var attachment = EssPlatform.Structures.Module.MessageBrokerNotificationAttachment.Create();
      attachment.Title = title;
      attachment.Url = $"EssBase://ElectronicDocument/{id}";
      return attachment;
    }

    /// <summary>
    /// Отправка сообщения в ЛК через MessageBroker.
    /// </summary>
    /// <param name="employee">Сотрудник, которому отправляется колокольчик.</param>
    /// <param name="title">Заголовок сообщения.</param>
    /// <param name="content">Содержимое сообщение.</param>
    /// <param name="workProcess">Имя типа задачи</param>
    /// <param name="workItem">Имя типа задания</param>
    /// <param name="document">Документ, который надо вложить в сообщение</param>
    [Public]
    public virtual void SendEssNotification(EssPlatformSolution.IEmployee employee, string title, string content,
                                            string workProcess, string workItem,
                                            Sungero.Content.IElectronicDocument document)
    {
      try
      {
        SendEssNotification(employee, title, content, workProcess, workItem, document, 1);
      }
      catch (Exception ex)
      {
        Logger.Error(ex.Message);
        throw ex;
      }
    }

    /// <summary>
    /// Отправка сообщения в ЛК через MessageBroker.
    /// </summary>
    /// <param name="employee">Сотрудник, которому отправляется колокольчик.</param>
    /// <param name="title">Заголовок сообщения.</param>
    /// <param name="content">Содержимое сообщение.</param>
    /// <param name="workProcess">Имя типа задачи</param>
    /// <param name="workItem">Имя типа задания</param>
    /// <param name="document">Документ, который надо вложить в сообщение</param>
    /// <param name="priority">Важность/срочность сообщения. 0 - высокая, 1 - обычная, 2 - низкая</param>
    [Public]
    public virtual void SendEssNotification(EssPlatformSolution.IEmployee employee, string title, string content,
                                            string workProcess, string workItem,
                                            Sungero.Content.IElectronicDocument document, int priority)
    {
      try
      {
        List<Sungero.Content.IElectronicDocument> docList = new List<Sungero.Content.IElectronicDocument>();
        docList.Add(document);
        SendEssNotification(employee, title, content, workProcess, workItem, docList, priority);
      }
      catch (Exception ex)
      {
        Logger.Error(ex.Message);
        throw ex;
      }
    }

    /// <summary>
    /// Отправка сообщения в ЛК через MessageBroker.
    /// </summary>
    /// <param name="employee">Сотрудник, которому отправляется колокольчик.</param>
    /// <param name="title">Заголовок сообщения.</param>
    /// <param name="content">Содержимое сообщение.</param>
    /// <param name="workProcess">Имя типа задачи</param>
    /// <param name="workItem">Имя типа задания</param>
    /// <param name="documents">Список документов (приведенных к ElectronicDocument), которые надо вложить в сообщение</param>
    [Public]
    public virtual void SendEssNotification(EssPlatformSolution.IEmployee employee, string title, string content,
                                            string workProcess, string workItem,
                                            List<Sungero.Content.IElectronicDocument> documents)
    {
      try
      {
        SendEssNotification(employee, title, content, workProcess, workItem, documents, 1);
      }
      catch (Exception ex)
      {
        Logger.Error(ex.Message);
        throw ex;
      }
    }

    /// <summary>
    /// Отправка сообщения в ЛК через MessageBroker.
    /// </summary>
    /// <param name="employee">Сотрудник, которому отправляется колокольчик.</param>
    /// <param name="title">Заголовок сообщения.</param>
    /// <param name="content">Содержимое сообщение.</param>
    /// <param name="workProcess">Имя типа задачи</param>
    /// <param name="workItem">Имя типа задания</param>
    /// <param name="documents">Список документов (приведенных к ElectronicDocument), которые надо вложить в сообщение</param>
    /// <param name="priority">Важность/срочность сообщения. 0 - высокая, 1 - обычная, 2 - низкая</param>
    [Public]
    public virtual void SendEssNotification(EssPlatformSolution.IEmployee employee, string title, string content, string workProcess, string workItem,
                                            List<Sungero.Content.IElectronicDocument> documents, int priority)
    {
      try
      {
        var properties = new System.Collections.Generic.Dictionary<string, string>();
        properties.Add("WorkProcess", workProcess);
        properties.Add("WorkItem", workItem);

        System.Collections.Generic.Dictionary<string, long> attachments = null;
        if (documents != null)
        {
          attachments = new System.Collections.Generic.Dictionary<string, long>();
          foreach(var d in documents)
            attachments.Add(d.Name, d.Id);
        }
        
        EssPlatform.PublicFunctions.Module.SendEssNotification(employee, title, content, priority, properties, attachments);
      }
      catch (Exception ex)
      {
        Logger.Error(ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Отправка сообщения в ЛК через MessageBroker.
    /// </summary>
    /// <param name="employee">Сотрудник, которому отправляется колокольчик.</param>
    /// <param name="title">Заголовок сообщения.</param>
    /// <param name="content">Содержимое сообщение.</param>
    /// <param name="priority">Срочность.</param>
    /// <param name="properties">Словарь (имя_параметра, значение) с дополнительными параметрами сообщения.</param>
    /// <param name="attachments">Словарь (имя_вложения, ИД-документа) с описанием вложений. Поддерживаются только документы</param>
    /// <returns>Значение.</returns>
    [Public]
    public virtual void SendEssNotification(EssPlatformSolution.IEmployee employee, string title, string content, int priority,
                                            System.Collections.Generic.Dictionary<string, string> properties,
                                            System.Collections.Generic.Dictionary<string, long> attachments)
    {
      try
      {
        var messageStruct = EssPlatform.PublicFunctions.Module.CreateEmptyEssNotification(employee);
        messageStruct.Title = title;
        messageStruct.Content = content;
        messageStruct.Priority = priority;
        
        if (properties != null)
          foreach(var p in properties)
            messageStruct.Properties.Add(p.Key, p.Value);

        if (attachments != null)
          foreach(var a in attachments)
            messageStruct.Attachments.Add(EssPlatform.PublicFunctions.Module.CreateAttachmentNotification(a.Key, a.Value));
        
        EssPlatform.PublicFunctions.Module.SendEssNotification(messageStruct);
      }
      catch (Exception ex)
      {
        Logger.Error(ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Отправка сообщения в ЛК через MessageBroker
    /// </summary>
    /// <param name="message">Структура с описанием сообщения.</param>
    [Public]
    public virtual void SendEssNotification(EssPlatform.Structures.Module.IMessageBrokerNotification message)
    {
      //Если отключена настройка "Подключить сервис идентификации", то последующие проверки выполняться не будут.
      if (!EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected())
        return;
      
      try
      {
        string jsonstring = SerializedToJson(message);
        var baseUri = PublicFunctions.EssSetting.GetSettings().MessageBrokerAddress;
        var requestApi = Constants.Module.RequestApiMessageBroker.MessageBrokerMessages;
        var token = GetAnAuthenticationTokenMessageBroker();
        RunPostRequest(baseUri, requestApi, jsonstring, token);
      }
      catch (Exception ex)
      {
        Logger.Error(ex.Message);
        throw ex;
      }
    }

    #endregion

    #region Работа с токенами

    /// <summary>
    /// Получить токен аутентификации от Ids.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <param name="password">Пароль.</param>.</param>
    /// <param name="serviceName">Имя сервиса для которого выдаётся токен.</param>
    /// <param name="idsUrl">Адрес сервиса Ids.</param>
    /// <returns>Токен, если аутентифкация пройдена. Исключение, если ошибка.</returns>
    [Public, Remote]
    public static string GetAnAuthenticationToken(string login, string password, string serviceName, string idsUrl)
    {
      try
      {
        var userSignIn = EssPlatform.Structures.Module.UserSignIn.Create();
        
        userSignIn.Login = login;
        userSignIn.Password = password;
        userSignIn.Audience = serviceName;
        userSignIn.TokenType = EssPlatform.Constants.Module.TokenType;

        string content = EssPlatform.PublicFunctions.Module.SerializedToJson(userSignIn);
        string requestApi = EssPlatform.Constants.Module.RequestApiIdentity.Authentication;
        var result = RunPostRequest(idsUrl, requestApi, content, string.Empty);
        if (result.StatusCode != (int)HttpStatusCode.OK)
          throw new Exception(DirRX.EssPlatform.Resources.GetAnAuthenticationTokenError);
        else
          return result.RequestMessage;
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetAnAuthenticationToken(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Получить токен аутентификации от Ids для текущей системы.
    /// </summary>
    /// <returns>Токен, если аутентифкация пройдена. Исключение, если ошибка.</returns>
    [Public, Remote]
    public static string GetAnAuthenticationTokenCurrentSystem()
    {
      try
      {
        return GetAnAuthenticationToken(PublicFunctions.EssSetting.GetSettings().IdentityServiceLogin);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetAnAuthenticationTokenCurrentSystem(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }

    /// <summary>
    /// Получить токен аутентификации от Ids для указанного сервиса.
    /// Параметры подключения к Identity Service будут получены из настроек.
    /// </summary>
    /// <param name="serviceName">Имя сервиса для которого выдаётся токен.</param>
    /// <returns>Токен, если аутентифкация пройдена. Исключение, если ошибка.</returns>
    [Public, Remote]
    public static string GetAnAuthenticationToken(string serviceName)
    {
      var settings = PublicFunctions.EssSetting.GetSettings();
      var password = string.Empty;
      var idSUrl = string.Empty;
      var login = string.Empty;
      if (!string.IsNullOrEmpty(settings.IdentityServiceLogin))
        login = settings.IdentityServiceLogin;
      else
        throw AppliedCodeException.Create(string.Format(DirRX.EssPlatform.Resources.EmptyIdentityServiceField, settings.Info.Properties.IdentityServiceLogin.LocalizedName));
      
      if (!string.IsNullOrEmpty(settings.IdentityServicePassword))
        password = Encryption.Decrypt(settings.IdentityServicePassword);
      else
        throw AppliedCodeException.Create(string.Format(DirRX.EssPlatform.Resources.EmptyIdentityServiceField, settings.Info.Properties.IdentityServicePassword.LocalizedName));
      
      if (!string.IsNullOrEmpty(settings.IdentityServiceAddress))
        idSUrl = settings.IdentityServiceAddress;
      else
        throw AppliedCodeException.Create(string.Format(DirRX.EssPlatform.Resources.EmptyIdentityServiceField, settings.Info.Properties.IdentityServiceAddress.LocalizedName));
      
      try
      {
        return GetAnAuthenticationToken(login, password, serviceName, idSUrl);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetAnAuthenticationToken(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }


    /// <summary>
    /// Получить токен аутентификации от Ids для MessageBroker
    /// </summary>
    /// <returns>Токен, если аутентифкация пройдена. Исключение, если ошибка.</returns>
    [Public, Remote]
    public static string GetAnAuthenticationTokenMessageBroker()
    {
      try
      {
        return GetAnAuthenticationToken(EssPlatform.Constants.Module.Audiences.MessageBroker);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetAnAuthenticationTokenCurrentSystem(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    #endregion
    
    #region Низкоуровневые http-запросы

    /// <summary>
    /// Сериализовать объект в Json.
    /// </summary>
    /// <param name="obj">Объект.</param>
    /// <returns>Строка в формате JSON.</returns>
    [Public]
    public string SerializedToJson(object obj)
    {
      return JsonConvert.SerializeObject(obj);
    }
    
    /// <summary>
    /// Отправить POST-запрос.
    /// </summary>
    /// <param name="baseUri">url сервиса</param>
    /// <param name="requestApi">добавочный url</param>
    /// <param name="jsonContent">Контент.</param>
    /// <param name="token">Токен</param>
    /// <returns>Структура с кодом результата запроса и сообщением либо исключение.
    /// Успешное выполнение запроса - статус 200 и сообщение ответа.
    /// Указан некорректный api-метод - статус 404 и пустое сообщение.
    /// Неавторизованный доступ (неправильный токен) - выброс исключения: UnauthorizedAccessException.
    /// У пользователя нет доступа (в токене нет нужной роли) - выброс исключения: UnauthorizedAccessException.
    /// Другие исключения пробрасываются выше по вызову с текстом сообщения исключения.</returns>
    [Public, Remote]
    public static Structures.Module.IHttpRequestResult RunPostRequest(string baseUri, string requestApi, string jsonContent, string token)
    {
      try
      {
        var result = Structures.Module.HttpRequestResult.Create();
        
        var httpClient = new HttpClient { BaseAddress = new Uri(baseUri) };
        if (!string.IsNullOrEmpty(token))
        {
          httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
          httpClient.DefaultRequestHeaders.Accept.Clear();
        }
        
        // Добавление контента.
        var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
        
        var response = httpClient.PostAsync(requestApi, httpContent).Result;
        var statusCode = response.StatusCode;
        var requestMessage = response.Content.ReadAsStringAsync().Result;
        
        // Ошибки авторизации пробрасывать дальше как ошибку, остальные результаты будем трактовать в зависимости от контекста вызова.
        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunPostRequest(). Authentication error {0} {1}.", (int)statusCode, requestMessage);
          throw new UnauthorizedAccessException(DirRX.EssPlatform.Resources.AuthenticationErrorText);
        }
        if (statusCode == HttpStatusCode.Forbidden)
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunPostRequest(). Authentication error {0} {1}.", (int)statusCode, requestMessage);
          throw new UnauthorizedAccessException(DirRX.EssPlatform.Resources.AuthenticationRightsErrorText);
        }

        result.StatusCode = (int)response.StatusCode;
        result.RequestMessage = response.Content.ReadAsStringAsync().Result;
        return result;
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunPostRequest(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Отправить PATCH-запрос.
    /// </summary>
    /// <param name="baseUri">Адрес сервиса.</param>
    /// <param name="requestUri">Текст запроса.</param>
    /// <param name="jsonContent">Контент.</param>
    /// <param name="token">Токен</param>
    /// <returns>Структура с кодом результата запроса и сообщением либо исключение.
    /// Успешное выполнение запроса - статус 200 и сообщение ответа.
    /// Указан несуществующий идентификатор пользователя IdS или указан некорректный api-метод - статус 404 и пустое сообщение.
    /// Неавторизованный доступ (неправильный токен) - выброс исключения: UnauthorizedAccessException.
    /// У пользователя нет доступа (в токене нет нужной роли) - выброс исключения: UnauthorizedAccessException.
    /// Другие исключения пробрасываются выше по вызову с текстом сообщения исключения.</returns>
    [Public, Remote]
    public static Structures.Module.IHttpRequestResult RunPatchRequest(string baseUri, string requestUri, string jsonContent, string token)
    {
      try
      {
        var method = new HttpMethod("PATCH");
        var httpClient = new HttpClient { BaseAddress = new Uri(baseUri) };
        if (!string.IsNullOrEmpty(token))
        {
          httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
          httpClient.DefaultRequestHeaders.Accept.Clear();
        }
        
        // Добавление контента.
        var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
        var request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri) {Content = httpContent};
        var response = httpClient.SendAsync(request).Result;
        var statusCode = response.StatusCode;
        var requestMessage = response.Content.ReadAsStringAsync().Result;
        // Ошибки авторизации пробрасывать дальше как ошибку, остальные результаты будем трактовать в зависимости от контекста вызова.
        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunPatchRequest(). Authentication error {0} {1}.", (int)statusCode, requestMessage);
          throw new UnauthorizedAccessException(DirRX.EssPlatform.Resources.AuthenticationErrorText);
        }
        if (statusCode == HttpStatusCode.Forbidden)
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunPatchRequest(). Authentication error {0} {1}.", (int)statusCode, requestMessage);
          throw new UnauthorizedAccessException(DirRX.EssPlatform.Resources.AuthenticationRightsErrorText);
        }
        var httpRequestResult = new Structures.Module.HttpRequestResult();
        httpRequestResult.StatusCode = (int)statusCode;
        httpRequestResult.RequestMessage = requestMessage;
        return httpRequestResult;
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunPatchRequest(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Отправить DELETE-запрос.
    /// </summary>
    /// <param name="baseUri">url сервиса</param>
    /// <param name="requestApi">добавочный url</param>
    /// <param name="token">Токен</param>
    /// <returns>Структура с кодом результата запроса и сообщением либо исключение.
    /// Успешное выполнение запроса - статус 200 и сообщение ответа.
    /// Указан несуществующий идентификатор пользователя IdS или указан некорректный api-метод - статус 404 и пустое сообщение.
    /// Неавторизованный доступ (неправильный токен) - выброс исключения: UnauthorizedAccessException.
    /// У пользователя нет доступа (в токене нет нужной роли) - выброс исключения: UnauthorizedAccessException.
    /// Другие исключения пробрасываются выше по вызову с текстом сообщения исключения.</returns>
    [Public, Remote]
    public static Structures.Module.IHttpRequestResult RunDeleteRequest(string baseUri, string requestApi, string token)
    {
      try
      {
        var result = Structures.Module.HttpRequestResult.Create();
        var httpClient = new HttpClient { BaseAddress = new Uri(baseUri) };
        if(!string.IsNullOrEmpty(token)) {
          httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
          httpClient.DefaultRequestHeaders.Accept.Clear();
        }
        var response = httpClient.DeleteAsync(requestApi).Result;
        var statusCode = response.StatusCode;
        var requestMessage = response.Content.ReadAsStringAsync().Result;
        result.StatusCode = (int)statusCode;
        
        // Ошибки авторизации пробрасывать дальше как ошибку, остальные результаты будем трактовать в зависимости от контекста вызова.
        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunDeleteRequest(). Authentication error {0} {1}.", (int)statusCode, requestMessage);
          throw new UnauthorizedAccessException(DirRX.EssPlatform.Resources.AuthenticationErrorText);
        }
        if (statusCode == HttpStatusCode.Forbidden)
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunDeleteRequest(). Authentication error {0} {1}.", (int)statusCode, requestMessage);
          throw new UnauthorizedAccessException(DirRX.EssPlatform.Resources.AuthenticationRightsErrorText);
        }
        
        result.RequestMessage = response.Content.ReadAsStringAsync().Result;
        return result;
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunDeleteRequest(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    
    /// <summary>
    /// Отправить GET-запрос.
    /// </summary>
    /// <param name="baseUri">Адрес сервиса.</param>
    /// <param name="requestUri">Текст запроса.</param>
    /// <param name="token">Токен.</param>
    /// <returns>Структура с кодом результата запроса и сообщением либо исключение.
    /// Успешное выполнение запроса - статус 200 и сообщение ответа.
    /// Указан несуществующий идентификатор пользователя IdS или указан некорректный api-метод - статус 404 и пустое сообщение.
    /// Неавторизованный доступ (неправильный токен) - выброс исключения: UnauthorizedAccessException.
    /// У пользователя нет доступа (в токене нет нужной роли) - выброс исключения: UnauthorizedAccessException.
    /// Другие исключения пробрасываются выше по вызову с текстом сообщения исключения.</returns>
    [Public]
    public static Structures.Module.HttpRequestResult RunGetRequest(string baseUri, string requestUri, string token)
    {
      try
      {
        var httpClient = new HttpClient { BaseAddress = new Uri(baseUri) };
        if (!string.IsNullOrEmpty(token))
        {
          httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
          httpClient.DefaultRequestHeaders.Accept.Clear();
        }
        var response = httpClient.GetAsync(requestUri).Result;
        var statusCode = response.StatusCode;
        var requestMessage = response.Content.ReadAsStringAsync().Result;
        // Ошибки авторизации пробрасывать дальше как ошибку, остальные результаты будем трактовать в зависимости от контекста вызова.
        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunGetRequest(). Authentication error {0} {1}.", (int)statusCode, requestMessage);
          throw new UnauthorizedAccessException(DirRX.EssPlatform.Resources.AuthenticationErrorText);
        }
        if (statusCode == HttpStatusCode.Forbidden)
        {
          Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunGetRequest(). Authentication error {0} {1}.", (int)statusCode, requestMessage);
          throw new UnauthorizedAccessException(DirRX.EssPlatform.Resources.AuthenticationRightsErrorText);
        }
        var httpRequestResult = new Structures.Module.HttpRequestResult();
        httpRequestResult.StatusCode = (int)statusCode;
        httpRequestResult.RequestMessage = requestMessage;
        return httpRequestResult;
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("EssPlatform.ModuleServerFunctions.RunGetRequest(). An error occurred while sending the request: {0}.", ex.Message);
        throw ex;
      }
    }
    #endregion
    
    #region test_functions
    /// <summary>
    /// Mock-функция для тестирования виджета "Заявления"
    /// </summary>
    /// <returns>строка с json для виджета "Заявления".</returns>
    [Public, Remote]
    public static string GetJSON4WidgetStatementMock()
    {
      string jsonString = "";
      var jsonValue = Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue("JSON4WidgetStatement");
      if (jsonValue != null)
        jsonString = jsonValue.ToString();
      return jsonString;
    }
    #endregion
    
    #region Функции для вызова в задачах HRLite

    /// <summary>
    /// Проверить, есть ли сотрудники, не подключенные к личному кабинету.
    /// </summary>
    /// <param name="employees">Список сотрудников.</param>
    /// <returns>True - если такие сотрудники есть, иначе false.</returns>
    [Public, Remote]
    public bool HasEmployeeNotInESS(List<IEmployee> employees)
    {
      return employees.Where(t => !HasEmployeePersonalAccountRegistred(t)).Any();
    }
    
    /// <summary>
    /// Определить зарегистрирован ли личный кабинет у сотрудника.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <returns>True - если ЛК зарегистрирован, False - если нет.</returns>
    [Public]
    public bool HasEmployeePersonalAccountRegistred(Sungero.Company.IEmployee employee)
    {
      var essPlatformEmployee = DirRX.EssPlatformSolution.Employees.As(employee);
      return essPlatformEmployee.PersonalAccountStatusDirRX == DirRX.EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted;
    }
    
    /// <summary>
    /// Получить список сотрудников с зарегистрированным ЛК.
    /// </summary>
    /// <param name="employees">Список сотрудников.</param>
    /// <returns>Список сотрудников с ЛК.</returns>
    [Public]
    public virtual List<Sungero.Company.IEmployee> GetEmployeesWithPersonalAccountRegistred(List<Sungero.Company.IEmployee> employees)
    {
      return employees.Where(t => HasEmployeePersonalAccountRegistred(t)).ToList();
    }
    
    /// <summary>
    /// Получить список сотрудников без ЛК.
    /// </summary>
    /// <param name="employees">Список сотрудников.</param>
    /// <returns>Список сотрудников без ЛК.</returns>
    [Public]
    public List<Sungero.Company.IEmployee> GetEmployeesWithoutPersonalAccountRegistred(List<Sungero.Company.IEmployee> employees)
    {
      return employees.Where(t => !HasEmployeePersonalAccountRegistred(t)).ToList();
    }
    
    /// <summary>
    /// Отправить сообщение сотруднику о новом задании/уведомлении.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="isNotice">True - уведомление, false - задание.</param>
    /// <param name="targetSystemName">Имя целевой системы.</param>
    /// <param name="selfOfficeObjectType">Тип объекта Личного кабинета.</param>
    /// <param name="objectTypeName">Объект личного кабинета сотрудника.</param>
    /// <param name="id">ИД объекта.</param>
    /// <param name="isSendToMobile">Может отправляться по СМС или Viber.</param>
    [Public]
    public virtual void SendNewNotification(Sungero.CoreEntities.IUser employee, bool isNotice, string targetSystemName, string selfOfficeObjectType, string objectTypeName, string id, bool isSendToMobile)
    {
      if (employee == null)
      {
        Logger.DebugFormat("SendNewNotification() was skipped - employee is null. objectTypeName={0} id={1}", objectTypeName, id);
        return;
      }
      #if DEBUG
      Logger.DebugFormat("SendNewNotification(). Start. objectTypeName={0} id={1} employee.id={2} employee.GetType()={3}", objectTypeName, id, employee.Id, employee.GetType().ToString());
      #endif
      if (Sungero.Company.Employees.Is(employee))
      {
        var essSiteUrl = PublicFunctions.EssSetting.GetSettings().ESSAddress;
        var link = Functions.Module.CreateHyperLinkToSelfOffice(targetSystemName, selfOfficeObjectType, objectTypeName, id);
        var messageText = isNotice ? DirRX.EssPlatform.Resources.NewNoticeNotificationTextFormat(link) :
          DirRX.EssPlatform.Resources.NewAssignmentNotificationTextFormat(link);
        var assignmentId = long.Parse(id);
        var employeeO = EssPlatformSolution.Employees.As(employee);
        // Определить способы оповещения. Если необходимо наследовать от НОР - взять настройки из НОР, иначе из Сотрудника.
        var sendSms = false;
        var sendEmail = false;
        var sendMessageToViber = false;
        var connectingESS = employeeO.PersonalAccountStatusDirRX.HasValue && employeeO.PersonalAccountStatusDirRX.Value == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted;
        if (employeeO.InheritFromBusinessUnitDirRX.HasValue && employeeO.InheritFromBusinessUnitDirRX.Value)
        {
          if (employeeO.BusinessUnitDirRX != null)
          {
            var businessUnitO = EssPlatformSolution.BusinessUnits.As(employeeO.BusinessUnitDirRX);
            sendSms = businessUnitO.NeedNotifyNewHRAssignmentDirRXSungero.HasValue &&
              businessUnitO.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.SMS && connectingESS;
            sendEmail = businessUnitO.NeedNotifyNewHRAssignmentDirRXSungero.HasValue &&
              (businessUnitO.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Email ||
               businessUnitO.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.EmailPersonal);
            sendMessageToViber = businessUnitO.NeedNotifyNewHRAssignmentDirRXSungero.HasValue &&
              businessUnitO.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Viber && connectingESS;
          }
        }
        else
        {
          sendSms = employeeO.NeedNotifyNewHRAssignmentDirRX.HasValue &&
            employeeO.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.SMS && connectingESS;
          sendEmail = employeeO.NeedNotifyNewHRAssignmentDirRX.HasValue &&
            (employeeO.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Email ||
             employeeO.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.EmailPersonal);
          sendMessageToViber = employeeO.NeedNotifyNewHRAssignmentDirRX.HasValue &&
            employeeO.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Viber && connectingESS;
        }
        // Запустить АС для оповещения.
        if (sendSms && !string.IsNullOrEmpty(objectTypeName))
        {
          if(isSendToMobile)
          { 
            var asyncHandler = AsyncHandlers.SendSms.Create();
            asyncHandler.userid = employee.Id;
            asyncHandler.messageText = messageText;
            asyncHandler.ExecuteAsync();
          }
        }
        if (sendEmail)
        {
          var asyncHandler = AsyncHandlers.SendEmail.Create();
          asyncHandler.assignmentId = assignmentId;
          asyncHandler.userid = employee.Id;
          asyncHandler.targetSystemName = targetSystemName;
          asyncHandler.ExecuteAsync();
        }
        if (sendMessageToViber && !string.IsNullOrEmpty(objectTypeName))
        {
          if(isSendToMobile)
          { 
            var asyncHandler = AsyncHandlers.SendMessageToViber.Create();
            asyncHandler.userid = employee.Id;
            asyncHandler.messageText = messageText;
            asyncHandler.ExecuteAsync();
           }
        }
      }
      else
      {
        Logger.DebugFormat("SendNewNotification() was skipped - not implemeted for 'not-employee'. objectTypeName={0} id={1} employee.id={2} employee.GetType()={3}", objectTypeName, id, employee.Id, employee.GetType().ToString());
      }
      #if DEBUG
        Logger.DebugFormat("SendNewNotification(). Finish. objectTypeName={0} id={1} employee.id={2}", objectTypeName, id, employee.Id);
      #endif
    }
    
    /// <summary>
    /// Получить перечисление NeedNotifyNewHRAssignmentDirRX по наименованию-строке.
    /// </summary>
    /// <param name="needNotifyNewHRAssignmentDirRX">Строка-наименование значения перечисления NeedNotifyNewHRAssignmentDirRX.</param>
    /// <returns>Значение перечисления NeedNotifyNewHRAssignmentDirRX.</returns>
    [Public]
    public Sungero.Core.Enumeration? GetNeedNotifyNewHRAssignmentDirRXEnum(string needNotifyNewHRAssignmentDirRX)
    {
      if (EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Email.Value == needNotifyNewHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Email;
      
      else if (EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.EmailPersonal.Value == needNotifyNewHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.EmailPersonal;
      
      else if (EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.No.Value == needNotifyNewHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.No;
      
      else if (EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.SMS.Value == needNotifyNewHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.SMS;
      
      else if (EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Viber.Value == needNotifyNewHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Viber;
      
      else
        return null;
    }
    
    /// <summary>
    /// Получить перечисление NeedNotifyExpiredHRAssignmentDirRX по наименованию-строке.
    /// </summary>
    /// <param name="needNotifyExpiredHRAssignmentDirRX">Строка-наименование значения перечисления NeedNotifyExpiredHRAssignmentDirRX.</param>
    /// <returns>Значение перечисления NeedNotifyExpiredHRAssignmentDirRX.</returns>
    [Public]
    public Sungero.Core.Enumeration? GetNeedNotifyExpiredHRAssignmentDirRXEnum(string needNotifyExpiredHRAssignmentDirRX)
    {
      if (EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.Email.Value == needNotifyExpiredHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.Email;
      
      else if (EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.EmailPersonal.Value == needNotifyExpiredHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.EmailPersonal;
      
      else if (EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.No.Value == needNotifyExpiredHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.No;
      
      else if (EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.SMS.Value == needNotifyExpiredHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.SMS;
      
      else if (EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.Viber.Value == needNotifyExpiredHRAssignmentDirRX)
        return EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.Viber;
      
      else
        return null;
    }
    
    /// <summary>
    /// Получить перечисление NeedNotifyHRRepeatDirRX по наименованию-строке.
    /// </summary>
    /// <param name="needNotifyHRRepeatDirRX">Строка-наименование значения перечисления NeedNotifyHRRepeatDirRX.</param>
    /// <returns>Значение перечисления NeedNotifyHRRepeatDirRX.</returns>
    [Public]
    public Sungero.Core.Enumeration? GetNeedNotifyHRRepeatDirRXEnum(string needNotifyHRRepeatDirRX)
    {
      if (EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.Email.Value == needNotifyHRRepeatDirRX)
        return EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.Email;
      
      else if (EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.EmailPersonal.Value == needNotifyHRRepeatDirRX)
        return EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.EmailPersonal;
      
      else if (EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.No.Value == needNotifyHRRepeatDirRX)
        return EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.No;
      
      else if (EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.SMS.Value == needNotifyHRRepeatDirRX)
        return EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.SMS;
      
      else if (EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.Viber.Value == needNotifyHRRepeatDirRX)
        return EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.Viber;
      
      else
        return null;
    }
    
    /// <summary>
    /// Получить перечисление ConfirmationTypeDirRX по наименованию-строке.
    /// </summary>
    /// <param name="confirmationTypeDirRX">Строка-наименование значения перечисления ConfirmationTypeDirRX.</param>
    /// <returns>Значение перечисления ConfirmationTypeDirRX.</returns>
    [Public]
    public Sungero.Core.Enumeration? GetConfirmationTypeDirRXEnum(string confirmationTypeDirRX)
    {
      if (EssPlatformSolution.Employee.ConfirmationTypeDirRX.Sms.Value == confirmationTypeDirRX)
        return EssPlatformSolution.Employee.ConfirmationTypeDirRX.Sms;
      else if (EssPlatformSolution.Employee.ConfirmationTypeDirRX.Email.Value == confirmationTypeDirRX)
        return EssPlatformSolution.Employee.ConfirmationTypeDirRX.Email;
      else if (EssPlatformSolution.Employee.ConfirmationTypeDirRX.Viber.Value == confirmationTypeDirRX)
        return EssPlatformSolution.Employee.ConfirmationTypeDirRX.Viber;
      else if (EssPlatformSolution.Employee.ConfirmationTypeDirRX.FlashCall.Value == confirmationTypeDirRX)
        return EssPlatformSolution.Employee.ConfirmationTypeDirRX.FlashCall;
      else if (EssPlatformSolution.Employee.ConfirmationTypeDirRX.None.Value == confirmationTypeDirRX)
        return EssPlatformSolution.Employee.ConfirmationTypeDirRX.None;
      else if (EssPlatformSolution.Employee.ConfirmationTypeDirRX.DefaultValue.Value == confirmationTypeDirRX)
        return EssPlatformSolution.Employee.ConfirmationTypeDirRX.DefaultValue;
      else
        return null;
    }
    #endregion
    
    /// <summary>
    /// Определяет, доступна ли текущему пользователю работа с персональными данными.
    /// </summary>
    /// <returns>Истина, если работа с ПДн доступна.</returns>
    [Public, Remote]
    public virtual bool PersonalDataAvailableForCurrentUser()
    {
      var role = Roles.GetAll(r => r.Sid == Constants.Module.UsersWithAccessToIdentityDocument).FirstOrDefault();
      return role == null ? false : Users.Current.IncludedIn(role);
    }

    #region Сервис интеграции

    // TODO После изменений в сервисе ЛК удалить эту ф-ию и обработчик openingEvetHandler из прикладной конфигурации услуги SendStatement.xml.
    // Task 89951: Некорректная работа с типами свойств шага при передаче макросов (таска команды Core).
    /// <summary>
    /// Костыль для совместителей.
    /// </summary>
    /// <param name="userId">ИД пользователя.</param>
    /// <returns>ИД инициатора.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public long GetInitiatorId(long userId)
    {
      return userId;
    }
    
    /// Получить ссылку на Соглашение между участниками ЭДО.
    /// </summary>
    /// <returns>Гиперссылка документа Соглашения между участниками ЭДО.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetAgreementUrl()
    {
      var setting = EssSettings.GetAll().FirstOrDefault();
      
      if (setting.IsUsedIdentityService != true)
        return string.Empty;
      
      return setting.AgreementUrl;
    }
    
    /// <summary>
    /// Добавить в задание ActiveText.
    /// </summary>
    /// <param name="assignmentId">ИД задания.</param>
    /// <param name="аctiveText">Текст задания.</param>
    [Public(WebApiRequestType = RequestType.Post)]
    public void AddAssignmentActiveText(long assignmentId, string аctiveText)
    {
      var assignment = Sungero.Workflow.Assignments.Get(assignmentId);
      if (assignment != null)
      {
        assignment.ActiveText = аctiveText;
        assignment.Save();
      }
    }
    
    /// <summary>
    /// Вложить в задание/задачу документы.
    /// </summary>
    /// <param name="entityType">Тип сущности (задача/задание).</param>
    /// <param name="entityId">ИД сущности.</param>
    /// <param name="documents">Список приложений в формате json, в которой есть ИД и имя группы, в которую надо вкладывать.</param>
    /// <remarks>Пример структуры вложений: "documents": "[{\"EntityId\":\"260\",\"Group\":\"AddendaGroup\"}]".
    /// Сейчас функция добавляет вложение в группу не смотря на то, какой тип указан в этой группе.</remarks>
    [Remote,Public(WebApiRequestType = RequestType.Post)]
    public static void AttachDocuments(string entityType, long entityId, string documents)
    {
      if (!string.IsNullOrEmpty(entityType))
      {
        IEntity entity = null;
        if (entityType.ToLower().Contains("task"))
          entity = Sungero.Workflow.Tasks.GetAll(t => t.Id == entityId).FirstOrDefault();
        else if (entityType.ToLower().Contains("assignment"))
        {
          entity = Sungero.Workflow.Assignments.GetAll(a => a.Id == entityId).FirstOrDefault();
        }
        
        if (entity != null)
        {
          var documentsList = JsonConvert.DeserializeObject<List<Structures.Module.AttachDocumentsInfo>>(documents);
          
          foreach (var document in documentsList)
          {
            var attachment = Sungero.Content.ElectronicDocuments.GetAll(x => x.Id == long.Parse(document.EntityId)).FirstOrDefault();
            // HACK: обходное решение для добавления документов в SimpleTask.
            if (!string.IsNullOrEmpty(document.Group))
            {
              var attachmentGroupePropertyInfo = entity.GetType().GetProperty(document.Group);
              var attachmentGroupeValue = attachmentGroupePropertyInfo?.GetValue(entity);
              var attachmentsTypePropertyInfo = attachmentGroupeValue?.GetType().GetProperty("All");
              var attachmentsTypeValue = attachmentsTypePropertyInfo?.GetValue(attachmentGroupeValue);
              var addAttachmentMethod = attachmentsTypePropertyInfo?.PropertyType.GetMethod("Add", new[] { attachment.GetType() });
              addAttachmentMethod?.Invoke(attachmentsTypeValue, new object[] { attachment });
            }
            else
            {
              if (Sungero.Workflow.Tasks.Is(entity))
                Sungero.Workflow.Tasks.As(entity).Attachments.Add(attachment);
              else if (Sungero.Workflow.Assignments.Is(entity))
                Sungero.Workflow.Assignments.As(entity).Attachments.Add(attachment);
            }
          }
          entity.Save();
        }
      }
    }
    
    /// <summary>
    /// Добавить подпись к документу
    /// </summary>
    /// <param name="documentId">ИД документа.</param>
    /// <param name="versionNumber">Версия документа.</param>
    /// <param name="signatureType">Тип подписи.</param>
    /// <param name="signedByEmployeeId">ИД подписанта.</param>
    /// <param name="base64Signature">Подпись в base64.</param>
    [Public(WebApiRequestType = RequestType.Post)]
    public void AddSignature(long documentId, int versionNumber, string signatureType, long signedByEmployeeId, string base64Signature)
    {
      Logger.DebugFormat("ESSPlatform.Server.AddSignature(). Start function. Doc id = {0}, signatureType = {1}, emp id = {2}", documentId, signatureType, signedByEmployeeId);
      
      var document = Sungero.Content.ElectronicDocuments.GetAll(x => x.Id == documentId).FirstOrDefault();
      var signatureContent = Convert.FromBase64String(base64Signature);
      var user = Users.GetAll(x => x.Id == signedByEmployeeId).FirstOrDefault();
      
      if (user != null)
      {
        Logger.DebugFormat("AddSignature(). User id = {0}", user.Id);
        Sungero.Content.IElectronicDocumentVersions version = null;

        if (versionNumber > 0)
        {
          version = document.Versions.SingleOrDefault(v => v.Number == versionNumber);
        }
        else
        {
          version = document.LastVersion;
        }
        
        if (version == null)
          Logger.Debug("AddSignature(). Version is null");
        else
          Logger.DebugFormat("AddSignature(). Version number = {0}", version.Number.Value);

        SignatureType type;
        if (signatureType.Equals(Constants.Module.EmployerSignatureType, StringComparison.OrdinalIgnoreCase))
        {
          ((Sungero.Domain.Shared.IExtendedEntity)document).Params[Resources.SignatureTypeParamsNameFormat(document.Id, user.Id)] = true;
          type = SignatureType.Approval;
        }
        else
          type = (SignatureType) Enum.Parse(typeof(SignatureType), signatureType);
        
        string unsignedAdditionalInfo = null;
        var signatureSetting = Sungero.Docflow.SignatureSettings.GetAll().Where(s => s.Status == Sungero.Docflow.SignatureSetting.Status.Active && s.Reason.Value == Sungero.Docflow.SignatureSetting.Reason.FormalizedPoA  && s.Recipient.Equals(user)).FirstOrDefault();
        
        if (signatureSetting != null && Sungero.Docflow.FormalizedPowerOfAttorneys.Is(signatureSetting.Document))
        {
          var formalizedPoA = Sungero.Docflow.FormalizedPowerOfAttorneys.As(signatureSetting.Document);
          unsignedAdditionalInfo = Sungero.Docflow.PublicFunctions.Module.FormatUnsignedAttribute(Sungero.Docflow.PublicConstants.Module.UnsignedAdditionalInfoKeyFPoA, formalizedPoA.UnifiedRegistrationNumber);
        }
        
        if (!string.IsNullOrEmpty(unsignedAdditionalInfo) && type == Sungero.Core.SignatureType.Approval)
        {
          Signatures.Import(document, type, user, signatureContent, unsignedAdditionalInfo, version);
        }
        else
        {
          Signatures.Import(document, type, user, signatureContent, version);
        }
        Logger.Debug("AddSignature(). Added signature");
      }
      else
        Logger.Debug("AddSignature(). User is null");
    }
    
    /// <summary>
    /// Стартовать задачу.
    /// </summary>
    /// <param name="taskId">ИД задачи.</param>
    [Public(WebApiRequestType = RequestType.Post)]
    public void StartTask(long taskId)
    {
      var task = Sungero.Workflow.Tasks.GetAll(x => x.Id == taskId).FirstOrDefault();
      if (task != null)
        task.Start();
    }
    
    /// <summary>
    /// Прекратить выполнение задачи.
    /// </summary>
    /// <param name="taskId">ИД задачи.</param>
    [Public(WebApiRequestType = RequestType.Post)]
    public void AbortTask(long taskId)
    {
      var task = Sungero.Workflow.Tasks.GetAll(x => x.Id == taskId).FirstOrDefault();
      if (task != null)
        task.Abort();
    }
    
    /// <summary>
    /// Получить информацию об исполнителе задачи/задания.
    /// </summary>
    /// <param name="employeeId">ИД задачи/задания.</param>
    /// <param name="type">Тип (Задание/задача).</param>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetPerformerInfo(long entityId, string entityType)
    {
      try
      {
        var performerInfo = Structures.Module.PerformerInfo.Create();
        if (!string.IsNullOrEmpty(entityType))
        {
          if (entityType.ToLower().Contains("task"))
          {
            var task = Sungero.Workflow.Tasks.GetAll(t => t.Id == entityId).FirstOrDefault();
            if (task != null)
            {
              var employee = Employees.As(task.Author);
              performerInfo.FullName = employee.Person.Name;
              performerInfo.Organization = employee.Department.BusinessUnit.Name;
              performerInfo.Department = employee.Department.Name;
              performerInfo.Position = employee.JobTitle.Name;
            }
          }
          else if (entityType.ToLower().Contains("assignment"))
          {
            var assignment = Sungero.Workflow.Assignments.GetAll(a => a.Id == entityId).FirstOrDefault();
            if (assignment != null)
            {
              var employee = Employees.As(assignment.Performer);
              performerInfo.FullName = employee.Person.Name;
              performerInfo.Organization = employee.Department.BusinessUnit.Name;
              performerInfo.Department = employee.Department.Name;
              performerInfo.Position = employee.JobTitle.Name;
            }
          }
        }
        return SerializedToJson(performerInfo);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetPerformerInfo(). {0}", ex.Message);
        return "[]";
      }
    }
    
    /// <summary>
    /// Возвращает список сотрудников персоны, отсортированный по виду занятости.
    /// Сотрудники сортируются в порядке:
    /// 1. Логин - сначала сотрудники с созданными учетными записями
    /// 2. Вид занятости (по убыв.) - сначала Основное место работы
    /// 3. Ид (по возр.) - сначала сотрудники, созданные раньше.
    /// После сортировки Основным местом работы считается сотрудник, указанный первым в списке.
    /// </summary>
    /// <param name="personId">Идентификатор персоны.</param>
    /// <returns>Список сотрудников.</returns>
    private IOrderedQueryable<EssPlatformSolution.IEmployee> EmployeesByPersonId(long personId)
    {
      var employees = EssPlatformSolution.Employees.GetAll()
        .Where(w => w.Status == Sungero.Company.Employee.Status.Active)
        .Where(w => w.Person != null)
        .Where(w => w.Person.Id == personId)
        // помещает сотрудников с логинами перед теми, кто без логинов
        .OrderByDescending(e => e.Login != null)
        // помещает сотрудников с видом занятости перед теми, кто без вида занятости
        .ThenByDescending(e => e.EmploymentType != null)
        // cортирует по виду занятости в следующем порядке: Основное место -> Внешнее совместительство -> Внутреннее совместительство;
        // делает это таким образом, потому что естественный порядок сортировки EmploymentType другой, а компаратор использовать нельзя
        .ThenBy(e => e.EmploymentType != DirRX.EssPlatformSolution.Employee.EmploymentType.MainPlace)
        .ThenBy(e => e.EmploymentType != DirRX.EssPlatformSolution.Employee.EmploymentType.ExternalConcurr)
        .ThenBy(e => e.EmploymentType != DirRX.EssPlatformSolution.Employee.EmploymentType.InternalConcurr)
        .ThenBy(e => e.Id);
      
      return employees;
    }
    
    /// <summary>
    /// Получить список должностей персоны.
    /// </summary>
    /// <param name="personId">Идентификатор персоны.</param>
    /// <returns>Список должностей персоны.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetPostListByPerson(long personId)
    {
      try
      {
        var postList = new List<Structures.Module.IPersonPostInfo>();
        var employees = EmployeesByPersonId(personId);

        foreach (var employee in employees)
        {
          var post = Structures.Module.PersonPostInfo.Create();
          post.id = employee.Id;
          post.organization = employee.Department?.BusinessUnit?.Name;
          post.department = employee.Department?.Name;
          post.HiddenPersonalPhone = SignPlatform.PublicFunctions.Module.Remote.GetHiddenPhone(employee.PersonalPhoneDirRX);
          post.title = employee.JobTitle?.Name;
          post.isPrimary = (employee.EmploymentType == EssPlatformSolution.Employee.EmploymentType.MainPlace);          
          postList.Add(post);
        }
        
        if (!postList.Any(p => p.isPrimary))
        {
          postList.First().isPrimary = true;
        }
        
        var personPostList = Structures.Module.PersonPostListInfo.Create();
        personPostList.positions = postList;
        
        return SerializedToJson(personPostList);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetPostListByPerson(). {0}", ex.Message);
        return "[]";
      }
    }
    
    /// <summary>
    /// Получить идентификаторы сотрудников указанной персоны.
    /// </summary>
    /// <param name="personId">Ид персоны.</param>
    /// <returns>Список идентификаторов сотрудников.
    /// Если у персоны нет совместителей, возвращется список из одного идентификатора.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public virtual List<long> GetPersonEmployeeIds(long personId)
    {
      try
      {
        var employees = EmployeesByPersonId(personId);
        return employees.Select(p => p.Id).ToList();
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetPersonEmployeeIds(). {0}", ex.Message);
        return new List<long>();
      }
    }
    
    /// <summary>
    /// Возвращает список идентификаторов пользователей персоны.
    /// </summary>
    /// <param name="personId">Ид персоны.</param>
    /// <returns>Список идентификаторов пользователей.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public virtual List<long> GetPersonUserIds(long personId)
    {
      return GetPersonEmployeeIds(personId);
    }

    /// <summary>
    /// Список id текущих/активных сотрудников для персоны
    /// </summary>
    /// <param name="personId">id персоны</param>
    /// <returns>В базовой реализаци - список ИД действующих сотрудников организаций, подключенных к ЛК.
    /// </returns>
    [Public]
    public virtual List<long> GetActiveEmployeeActors(long personId)
    {
      var activeEmployee = new List<long>();
      var employees = EssPlatformSolution.Employees.GetAll(e => e.Status == Sungero.Company.Employee.Status.Active && e.Person.Id == personId);
      foreach(var employee in employees)
        activeEmployee.Add(employee.Id);
      return activeEmployee;
    }
    
    /// <summary>
    /// Возвращает отношение персоны к роли личного кабинета "Действующий сотрудник"
    /// </summary>
    /// <param name="personId"></param>
    /// <returns>Структура Structures.Module.RoleActors с указанием идентификатора роли и списка идентификаторов акторов персоны, имеющих отношение к роли.
    /// </returns>
    [Public]
    public Structures.Module.IRoleActors GetEssRoleActiveEmployeeActors(long personId)
    {
      var acrtoIds = GetActiveEmployeeActors(personId);
      return Structures.Module.RoleActors.Create(DirRX.EssPlatform.PublicConstants.Module.RoleEssEmployeeActive, acrtoIds);
    }

    /// <summary>
    /// Определить отношение указанной персоны к зарегистрированным ролям личного кабинета.
    /// </summary>
    /// <param name="personId"> ИД персонs</param>
    /// <returns>Список зарегистрированных ролей, у которых будут указаны списки акторов, имеющих отношение к персоне</returns>
    /// <remarks>В самом базовом варианте возвращает список из одного элемента, результат работы функции GetEssRoleEmployeeActiveActors().
    /// Если прикладное решение добавляет свою роль для личного кабинета, то необходимо перекрыть функцию и к результатам,
    /// которые вернет base.GetEssRolesActors() добавить элемент с описанием отношения персоны к новой роли.
    /// </remarks>
    [Public]
    public virtual List<DirRX.EssPlatform.Structures.Module.IRoleActors> GetEssRolesActors(long personId)
    {
      var roles = new List<DirRX.EssPlatform.Structures.Module.IRoleActors>();
      var essRoleEmployeeActiveActors = GetEssRoleActiveEmployeeActors(personId);
      roles.Add(essRoleEmployeeActiveActors);
      return roles;
    }
    
    /// <summary>
    /// Возвращает список утверждений пользователя из системы RX по идентификатору персоны
    /// </summary>
    /// <param name="personId"> ИД персоны</param>
    /// <returns>actorId - идентификатор действующего лица (сотрудника или кандидата), roleId - идентификатор ролей.
    /// Пример: { "actorId": 234234, "roles": [ "Руководитель", "Стажер" ] }
    /// </returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetPersonIdentity(long personId)
    {
      try
      {
        // для всех зарегистрированных ролей получить список акторов, соответствующих персоне
        var roles = GetEssRolesActors(personId);

        // сформировать уникальный список id акторов из всех ролей
        List<long> uniqueActorIds = new List<long>();
        foreach(var role in roles)
          foreach(var actorId in role.actorIds)
            if (!uniqueActorIds.Contains(actorId))
              uniqueActorIds.Add(actorId);
        
        // для каждого актора вычислить список ролей, к которым принадлежит актор
        var actors = new List<Structures.Module.IActorRole>();
        foreach(var actorId in uniqueActorIds)
        {
          var actor = Structures.Module.ActorRole.Create();
          actor.actorId = actorId;
          actor.roles = new List<string>();
          foreach(var role in roles) {
            // Добавить роль в список, если текущий актор принадлежит роли и роли еще нет в списке
            if (role.actorIds.Contains(actorId) && !actor.roles.Contains(role.role)) {
              actor.roles.Add(role.role);
            }
          }
          actors.Add(actor);
        }
        return this.SerializedToJson(actors);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetPersonIdentity(). {0}", ex.Message);
        return "[]";
      }
    }
    
    /// <summary>
    /// Выполнить задание.
    /// </summary>
    /// <param name="assignmentId">ИД задания.</param>
    /// <param name="performResult">Результат выполнения.</param>
    [Public(WebApiRequestType = RequestType.Post)]
    public void CompleteAssignment(long assignmentId, string performResult)
    {
      var assignment = Sungero.Workflow.Assignments.GetAll(assingment => assingment.Id == assignmentId).FirstOrDefault();
      if (!string.IsNullOrEmpty(performResult))
      {
        var result = new Enumeration(performResult);
        if (assignment != null)
          assignment.Complete(result);
      }
      else assignment.Complete(null);
    }

    /// <summary>
    /// Получить тела утверждающих подписей
    /// </summary>
    /// <param name="documentId">ИД документа.</param>
    /// <returns>Список подписей в виде base64-строк.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetBodyOfApprovalSignatures(long documentId)
    {
      var document = Sungero.Content.ElectronicDocuments.GetAll(doc => doc.Id == documentId).FirstOrDefault();
      if (document != null)
      {
        var signatures = Signatures.Get(document.LastVersion, q => q.Where(s => s.SignatureType == SignatureType.Approval)).Where(s => s.IsValid == true);
        List<string> bodies = new List<string>();
        foreach (var signature in signatures)
        {
          var signData = signature.GetDataSignature();
          var bodyBase64 = Convert.ToBase64String(signData);
          bodies.Add(bodyBase64);
        }
        return this.SerializedToJson(bodies);
      }
      return "[]";
    }
    
    /// <summary>
    /// Получить информацию о подписях документа.
    /// </summary>
    /// <param name="documentId">ИД документа.</param>
    /// <param name="personId">ИД персоны.</param>
    /// <returns>Список подписей.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetSignatures(long documentId, long personId)
    {
      var document = Sungero.Content.ElectronicDocuments.GetAll(doc => doc.Id == documentId).FirstOrDefault();
      if (document != null)
      {
        var employeesIds = EssPlatformSolution.Employees.GetAll(e => e.Status == Sungero.Company.Employee.Status.Active &&
                                                                e.Person != null &&
                                                                e.Person.Id == personId).Select(e => e.Id).ToList();
        var signatures = Signatures.Get(document.LastVersion, q => q.Where(s => s.SignatureType == SignatureType.Approval ||
                                                                           (s.Signatory != null && employeesIds.Contains(s.Signatory.Id)) ||
                                                                           (s.SubstitutedUser != null && employeesIds.Contains(s.SubstitutedUser.Id))));
        
        var signaturesInfo = new List<Structures.Module.SignatureInfo>();
        foreach (var signature in signatures)
        {
          signaturesInfo.Add(Structures.Module.SignatureInfo.Create(signature.Signatory?.Id,
                                                                    signature.SignatoryFullName,
                                                                    signature.SigningDate,
                                                                    signature.SignatureType.ToString(),
                                                                    signature.Comment,
                                                                    signature.Certificate?.Thumbprint));
        }
        return this.SerializedToJson(signaturesInfo);
      }
      return "[]";
    }
    
    /// <summary>
    /// Сформировать список с инфо о сертификатах сотрудника.
    /// </summary>
    /// <param name="employeeId">ИД сотрудника.</param>
    /// <returns>Список с инфо о сертификатах сотрудника.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetEmployeeCertificates(long employeeId)
    {
      var employee = Sungero.Company.Employees.GetAll(e => e.Id == employeeId).FirstOrDefault();
      if (employee != null)
      {
        var certs = GetEmployeeCertificateEnities(employee);
        
        if (certs.Any())
        {
          var certList = new List<DirRX.EssPlatform.Structures.Module.ICertificateInfo>();
          
          foreach(var cert in certs)
          {
            var valid = DirRX.EssPlatform.Structures.Module.ValidPeriod.Create();
            valid.from = cert.NotBefore;
            valid.to = cert.NotAfter;
            
            var certInfo = DirRX.EssPlatform.Structures.Module.CertificateInfo.Create();
            certInfo.issuerInfo = cert.Issuer;
            certInfo.subjectInfo = cert.Description;
            certInfo.thumbprint = cert.Thumbprint;
            certInfo.validPeriod = valid;
            certInfo.pluginId = cert.PluginId ?? "standard";
            
            var providerIds = cert.Parameters.Where(l => l.Key.Equals(SignPlatform.PublicConstants.Module.ProviderIdCertificateKeyParameter));
            if (providerIds.Any())
              certInfo.providerId = providerIds.First().Value;
            else
              certInfo.providerId = null;
            var ownerIds = cert.Parameters.Where(l => l.Key.Equals(SignPlatform.PublicConstants.Module.OwnerIdCertificateKeyParameter));
            if (ownerIds.Any())
              certInfo.certificateOwnerId = ownerIds.First().Value;
            else
              certInfo.certificateOwnerId = null;
            
            if (!certList.Any(t => t.thumbprint == cert.Thumbprint))
              certList.Add(certInfo);
          }
          return JsonConvert.SerializeObject(certList);
        }
      }
      return "[]";
    }
    
    /// <summary>
    /// Получить список сертификатов сотрудника.
    /// </summary>
    /// <param name="employeeId">Cотрудник.</param>
    /// <returns>Список сертификатов сотрудника.</returns>
    [Public]
    public virtual IQueryable<ICertificate> GetEmployeeCertificateEnities(IEmployee employee)
    {
      return Certificates.GetAll().Where(x => Equals(x.Owner, employee) &&
                                         x.Enabled == true &&
                                         (!x.NotAfter.HasValue || x.NotAfter.Value > Calendar.Now));
    }
    
    /// <summary>
    /// Получить вложения задачи/задания.
    /// </summary>
    /// <param name="entityType">Тип сущности.</param>
    /// <param name="entityId">ИД сущности.</param>
    /// <returns>Список вложений.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetAttachments(string entityType, long entityId)
    {
      if (!string.IsNullOrEmpty(entityType))
      {
        Sungero.Workflow.ITask entity = null;
        if (entityType.ToLower().Contains("task"))
          entity = Sungero.Workflow.Tasks.GetAll(task => task.Id == entityId).FirstOrDefault();
        else if (entityType.ToLower().Contains("assignment"))
        {
          var assignment = Sungero.Workflow.Assignments.GetAll(assingment => assingment.Id == entityId).FirstOrDefault();
          if (assignment != null)
          {
            entity = assignment.Task;
          }
          else
          {
            var notice = Sungero.Workflow.Notices.GetAll(n => n.Id == entityId).FirstOrDefault();
            if (notice != null)
            {
              entity = notice.Task;
            }
          }
        }
        
        if (entity != null)
        {
          var attachments = entity.AllAttachments.Where(a => Sungero.Content.ElectronicDocuments.Is(a)).Select(a => EssPlatform.Structures.Module.AttachmentInfo.Create(
            a.Id.ToString(),
            a.DisplayValue,
            "Document",
            "IElectronicDocuments",
            entity.AttachmentsInfo.FirstOrDefault(i => i.IsLinkedTo(a))?.GroupName,
            Sungero.Content.ElectronicDocuments.As(a)?.Modified,
            Sungero.Content.ElectronicDocuments.As(a)?.AssociatedApplication?.Extension,
            Sungero.Content.ElectronicDocuments.As(a)?.LastVersion?.Body.Size)).ToList();
          
          return SerializedToJson(attachments);
        }
        
        return "[]";
      }
      
      return "[]";
    }
    
    /// <summary>
    /// Получить идентификатор сотрудника по идентификатору пользователя.
    /// </summary>
    /// <param name="uniqueId">Глобальный уникальный идентификатор пользователя.</param>
    /// <returns>Идентификатор сотрудника по идентификатору пользователя.</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public virtual long GetEmployeeByUniqueId(string uniqueId)
    {
      try
      {
        var guid = new Guid(uniqueId.Split('@').Last());
        var employees = Sungero.Company.Employees.GetAll(e => e.Sid.Value.Equals(guid));
        return employees.FirstOrDefault()?.Id ?? -1;
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("GetEmployeeByUniqueId(). {0}", ex.Message);
        return 0;
      }
    }

    /// <summary>
    /// Создать асинхронное событие для изменения статуса личного кабинета для сотрудника на "Принято"
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <description>Вызывается в Личном кабинете.</description>
    [Public(WebApiRequestType = RequestType.Post)]
    public virtual void ChangePersonalAccountStatusToInviteAccepted(long employeeId)
    {
      var employee = EssPlatformSolution.Employees.GetAll(i => i.Id == employeeId).FirstOrDefault();
      Logger.Debug("Start ChangeEmployeeEssStatus from ChangePersonalAccountStatusToInviteAccepted");
      ChangePersonalAccountStatus(employee, EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted);
    }
    
    /// <summary>
    /// Добавить штамп с ЭП в последнюю версию документа.
    /// </summary>
    /// <param name="documentId">Идентификатор документа.</param>
    /// <return>Возвращает признак успешности добавления штампа.</return>
    [Public(WebApiRequestType = RequestType.Post)]
    public bool AddStamp(long documentId)
    {
      try
      {
        var document = Sungero.Content.ElectronicDocuments.Get(documentId);
        var lastVersion = document.LastVersion;
        var versionSignature = Signatures.Get(lastVersion, q => q.Where(s => s.SignatureType == SignatureType.Approval && s.IsExternal == true)).FirstOrDefault();
        if (versionSignature != null)
        {
          using (var lastVersionBodyStream = new System.IO.MemoryStream())
          {
            lastVersion.Body.Read().CopyTo(lastVersionBodyStream);
            var extension = lastVersion.BodyAssociatedApplication.Extension;
            var signatureMark = Sungero.Docflow.PublicFunctions.Module.GetSignatureMarkForCertificateAsHtml(versionSignature, Sungero.Docflow.PublicFunctions.Module.GetDefaultSignatureStampParams(true));
            var pdfStream = Sungero.Docflow.IsolatedFunctions.PdfConverter.GeneratePdf(lastVersionBodyStream, extension);
            var pdfDocumentStream = Sungero.Docflow.IsolatedFunctions.PdfConverter.AddSignatureStamp(pdfStream, extension, signatureMark, Sungero.Docflow.Resources.SignatureMarkAnchorSymbol, 5);
            lastVersion.PublicBody.Write(pdfDocumentStream);
            lastVersion.AssociatedApplication = Sungero.Content.AssociatedApplications.GetByExtension("pdf");
            pdfStream.Close();
            pdfDocumentStream.Close();
          }
          document.Save();
        }
        return true;
      }
      catch (Exception ex)
      {
        Logger.DebugFormat("AddStamp() error: {0}", ex.StackTrace);
        return false;
      }
    }
    
    /// <summary>
    /// Получить должность сотрудника.
    /// </summary>
    /// <param name="employeeId">Идентификатор сотрудника.</param>
    /// <param name="declensionCase">Падеж.</param>
    /// <returns>Должность сотрудника</returns>
    [Public(WebApiRequestType = RequestType.Get)]
    public string GetEmployeePosition(long employeeId, string declensionCase)
    {
      var employee = Sungero.Company.Employees.GetAll(x => x.Id == employeeId).FirstOrDefault();
      if (employee != null)
      {
        try
        {
          DeclensionCase resultCase = (DeclensionCase)Enum.Parse(typeof(DeclensionCase), declensionCase);
          return Sungero.Company.PublicFunctions.Employee.GetJobTitle(employee, resultCase);
        }
        catch(Exception ex)
        {
          Logger.DebugFormat("GetEmployeePosition() error: {0}", ex.StackTrace);
          return employee.JobTitle.Name;
        }
      }
      else
      {
        Logger.Debug("GetEmployeePosition() error: employee not found.");
        return string.Empty;
      }
    }
    
    /// <summary>
    /// Проверить, заблокирована ли карточка задания.
    /// </summary>
    /// <param name="assignmentId">ИД задания.</param>
    /// <returns>Сообщение о блокировке, если карточка заблокирована, либо пустая строка в ином случае.</returns>
    [Public(WebApiRequestType = RequestType.Post)]
    public string IsAssignmentCardBlocked(long assignmentId)
    {
      var getAllAssignment = Sungero.Workflow.Assignments.GetAll(a => a.Id.Equals(assignmentId));
      if (getAllAssignment.Any())
      {
        var assignment = getAllAssignment.FirstOrDefault();
        return Locks.GetLockInfo(assignment).LockedMessage;
      }
      else
        return string.Empty;
    }
    #endregion
    
    #region Рассылка писем о новых заданиях
    /// <summary>
    /// Запустить рассылку по новым заданиям.
    /// </summary>
    /// <param name="previousRun">Дата прошлого запуска рассылки.</param>
    /// <param name="notificationDate">Дата текущей рассылки.</param>
    /// <param name="assignments">Задания, по которым будет выполнена рассылка.</param>
    /// <returns>True, если хотя бы одно письмо было отправлено, иначе - false.</returns>
    public bool? TrySendNewAssignmentsMailing(Sungero.Workflow.IAssignmentBase assignment, string targetSystemName)
    {
      Logger.Debug("DirRX.EssPlatform.Server Checking new HR assignments for mailing");
      var hasErrors = false;

      var anyMailSent = false;

      var employee = EssPlatformSolution.Employees.GetAll().Where(l => l.Id == assignment.Performer.Id).FirstOrDefault();

      var substitutions = Sungero.CoreEntities.Substitutions.GetAll(s => Equals(s.User, employee) && s.IsSystem != true &&
                                                                    (s.StartDate == null || (s.StartDate != null && s.StartDate.Value <= assignment.Created)) &&
                                                                    (s.EndDate == null || (s.EndDate != null && s.EndDate.Value.EndOfDay() >= assignment.Created)));

      var substitutes = EssPlatformSolution.Employees.GetAll(e => e.Status == Sungero.CoreEntities.DatabookEntry.Status.Active &&
                                                             substitutions.Any(s => Equals(s.Substitute, e)) &&
                                                             ((e.InheritFromBusinessUnitDirRX.HasValue && !e.InheritFromBusinessUnitDirRX.Value &&
                                                               e.NeedNotifyNewHRAssignmentDirRX.HasValue && e.NeedNotifyNewHRAssignmentDirRX.Value != EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.No) ||
                                                              (e.InheritFromBusinessUnitDirRX.HasValue && e.InheritFromBusinessUnitDirRX.Value && e.BusinessUnitDirRX != null &&
                                                               EssPlatformSolution.BusinessUnits.As(e.BusinessUnitDirRX).NeedNotifyNewHRAssignmentDirRXSungero.HasValue &&
                                                               EssPlatformSolution.BusinessUnits.As(e.BusinessUnitDirRX).NeedNotifyNewHRAssignmentDirRXSungero.Value != EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.No))).ToList();
      
      var subject = this.GetNewAssignmentSubject(assignment);
      var mailSent = this.TrySendMailByAssignment(assignment, subject, employee, substitutes, targetSystemName);
      if (!mailSent.IsSuccess)
        hasErrors = true;
      if (mailSent.IsSuccess && mailSent.AnyMailSended)
        anyMailSent = true;
      
      if (!anyMailSent)
        Logger.Debug("DirRX.EssPlatform.Server No subscribers for new HR assignments mailing");
      if (!anyMailSent && !hasErrors)
        return null;
      return anyMailSent || !hasErrors;
    }
    
    /// <summary>
    /// Сформировать тему письма по новому заданию.
    /// </summary>
    /// <param name="assignment">Задание, для которого формируется письмо.</param>
    /// <returns>Тема письма.</returns>
    public virtual string GetNewAssignmentSubject(Sungero.Workflow.IAssignmentBase assignment)
    {
      return Sungero.Docflow.Resources.NewAssignmentMailSubjectFormat(this.GetAssignmentTypeName(assignment), GetAuthorSubjectPart(assignment), assignment.Subject);
    }
    
    /// <summary>
    /// Получить локализованное имя типа задания.
    /// </summary>
    /// <param name="assignment">Базовое задание.</param>
    /// <returns>Имя типа задания.</returns>
    /// <remarks>Виртуальные функции доступны в шаблоне письма только с паблик атрибутом.</remarks>
    [Public]
    public virtual string GetAssignmentTypeName(Sungero.Workflow.IAssignmentBase assignment)
    {
      if (Sungero.Workflow.Notices.Is(assignment))
        return Sungero.Workflow.Notices.Info.LocalizedName;
      else
        return Sungero.Workflow.Assignments.Info.LocalizedName;
    }
    
    /// <summary>
    /// Получить часть темы письма, которая содержит автора задания.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <returns>Часть темы письма с автором задания.</returns>
    public static string GetAuthorSubjectPart(Sungero.Workflow.IAssignmentBase assignment)
    {
      if (Equals(assignment.Author, assignment.Performer))
        return string.Empty;

      return string.Format(" {0} {1}", Sungero.Docflow.Resources.From, GetFormattedUserNameInGenitive(assignment.Author.DisplayValue));
    }
    
    /// <summary>
    /// Получить форматированное имя пользователя в родительном падеже.
    /// </summary>
    /// <param name="userName">Имя пользователя.</param>
    /// <returns>Форматированное имя пользователя.</returns>
    public static string GetFormattedUserNameInGenitive(string userName)
    {
      CommonLibrary.PersonFullName personalData;
      var result = userName;
      if (CommonLibrary.PersonFullName.TryParse(result, out personalData) && !string.IsNullOrEmpty(personalData.MiddleName))
      {
        personalData.DisplayFormat = CommonLibrary.PersonFullNameDisplayFormat.LastNameAndInitials;
        result = CaseConverter.ConvertPersonFullNameToTargetDeclension(personalData, Sungero.Core.DeclensionCase.Genitive);
      }
      return result;
    }
    
    /// <summary>
    /// Попытаться отправить письмо по заданию.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="subject">Тема.</param>
    /// <param name="addressee">Получатель письма.</param>
    /// <param name="copies">Получатели копий письма.</param>
    /// <param name="targetSystemName">Имя целевой системы.</param>
    /// <returns>True, если ошибок при отправке не было, иначе - False.</returns>
    public Structures.Module.MailSendingResult TrySendMailByAssignment(Sungero.Workflow.IAssignmentBase assignment,
                                                                       string subject,
                                                                       EssPlatformSolution.IEmployee addressee,
                                                                       System.Collections.Generic.IEnumerable<EssPlatformSolution.IEmployee> copies,
                                                                       string targetSystemName)
    {
      var sendEmail = false;
      var sendEmailPersonal = false;
      var needNotify = false;
      string to = null;
      var inheritFromBusinessUnit = addressee.InheritFromBusinessUnitDirRX.HasValue && addressee.InheritFromBusinessUnitDirRX.Value;
      
      if (inheritFromBusinessUnit)
      {
        if (addressee.BusinessUnitDirRX != null)
        {
          var businessUnit = EssPlatformSolution.BusinessUnits.As(addressee.BusinessUnitDirRX);
          needNotify = businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.HasValue && businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Value != EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.No &&
            addressee.Status != Sungero.CoreEntities.DatabookEntry.Status.Closed;
        }
      }
      else
        needNotify = addressee.NeedNotifyNewHRAssignmentDirRX.HasValue && addressee.NeedNotifyNewHRAssignmentDirRX.Value != EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.No &&
          addressee.Status != Sungero.CoreEntities.DatabookEntry.Status.Closed;
      
      if (needNotify)
      {
        if (inheritFromBusinessUnit)
        {
          if (addressee.BusinessUnitDirRX != null)
          {
            var businessUnit = EssPlatformSolution.BusinessUnits.As(addressee.BusinessUnitDirRX);
            sendEmail = businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.HasValue && businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Email;
            sendEmailPersonal = businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.HasValue && businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.EmailPersonal;
          }
        }
        else
        {
          sendEmail = addressee.NeedNotifyNewHRAssignmentDirRX.HasValue && addressee.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Email;
          sendEmailPersonal = addressee.NeedNotifyNewHRAssignmentDirRX.HasValue && addressee.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.EmailPersonal;
        }
        if (sendEmail)
          to = !string.IsNullOrEmpty(addressee.Email) ? addressee.Email : null;
        else if (sendEmailPersonal)
          to = !string.IsNullOrEmpty(addressee.MessagesEmailDirRX) ? addressee.MessagesEmailDirRX : null;
      }
      
      var cc = new List<string>();
      foreach (var copy in copies)
      {
        if (copy.InheritFromBusinessUnitDirRX.HasValue && copy.InheritFromBusinessUnitDirRX.Value)
        {
          var businessUnit = EssPlatformSolution.BusinessUnits.As(copy.BusinessUnitDirRX);
          sendEmail = businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.HasValue && businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Email;
          sendEmailPersonal = businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.HasValue && businessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.EmailPersonal;
        }
        else
        {
          sendEmail = copy.NeedNotifyNewHRAssignmentDirRX.HasValue && copy.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Email;
          sendEmailPersonal = copy.NeedNotifyNewHRAssignmentDirRX.HasValue && copy.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.EmailPersonal;
        }
        if (sendEmail && !string.IsNullOrEmpty(copy.Email))
          cc.Add(copy.Email);
        else if (sendEmailPersonal && !string.IsNullOrEmpty(copy.MessagesEmailDirRX))
          cc.Add(copy.MessagesEmailDirRX);
      }
      
      if (string.IsNullOrEmpty(to) && !cc.Any())
        return Structures.Module.MailSendingResult.Create(true, false);
      
      bool isSendMailSuccess = false;
      try
      {
        Logger.DebugFormat("DirRX.EssPlatform.Server Sending mail by assignment with Id = {0}", assignment.Id);
        
        this.InternalSendMailByAssignment(assignment, subject, to, cc, targetSystemName);
        
        if (!string.IsNullOrEmpty(to))
          Logger.DebugFormat("DirRX.EssPlatform.Server Mail to performer with Id = {0} has been sent", addressee.Id);
        else if (needNotify)
          Logger.DebugFormat("DirRX.EssPlatform.Server Performer with Id = {0} has no email", addressee.Id);
        
        foreach (var employee in copies)
        {
          if (!string.IsNullOrEmpty(employee.Email) || !string.IsNullOrEmpty(employee.MessagesEmailDirRX))
            Logger.DebugFormat("DirRX.EssPlatform.Server Mail to substitute with Id = {0} has been sent", employee.Id);
          else
            Logger.DebugFormat("DirRX.EssPlatform.Server Substitute with Id = {0} has no email", employee.Id);
        }
        
        isSendMailSuccess = true;
      }
      catch (FormatException ex)
      {
        Logger.ErrorFormat("DirRX.EssPlatform.Server Performer with Id = {0} or his substitute has incorrect email", ex, addressee.Id);
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("DirRX.EssPlatform.Server Error while sending mail to performer with Id = {0} or his substitute", ex, addressee.Id);
      }
      return Structures.Module.MailSendingResult.Create(isSendMailSuccess, isSendMailSuccess && (!string.IsNullOrEmpty(to) || cc.Any()));
    }
    
    /// <summary>
    /// Отправить письмо по заданию.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="subject">Тема.</param>
    /// <param name="to">Получатель письма.</param>
    /// <param name="cc">Получатели копий письма.</param>
    [Public]
    public void InternalSendMailByAssignment(Sungero.Workflow.IAssignmentBase assignment, string subject, string to, System.Collections.Generic.IEnumerable<string> cc, string targetSystemName)
    {
      var message = Mail.CreateMailMessage();
      message.Body = this.GenerateBody(assignment, cc.Any(), targetSystemName);
      message.IsBodyHtml = true;
      message.Subject = subject.Replace('\r', ' ').Replace('\n', ' ');
      if (!string.IsNullOrEmpty(to))
        message.To.Add(to);
      foreach (var email in cc.Where(e => !string.IsNullOrEmpty(e)))
        message.CC.Add(email);
      if (assignment.Importance == Sungero.Workflow.AssignmentBase.Importance.High)
        message.Priority = Sungero.Core.MailPriority.High;
      else if (assignment.Importance == Sungero.Workflow.AssignmentBase.Importance.Low)
        message.Priority = Sungero.Core.MailPriority.Low;
      
      this.AddLogo(message);
      
      Mail.Send(message);
    }
    
    /// <summary>
    /// Получить ссылку на задание в ЛК.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="targetSystemName">Имя целевой системы.</param>
    /// <returns>Ссылка на задание в ЛК.</returns>
    [Public]
    public virtual string GetHyperlinkToSelfServiceOffice(Sungero.Workflow.IAssignmentBase assignment, string targetSystemName)
    {
      var employee = EssPlatformSolution.Employees.As(assignment.Performer);
      var selfOfficeObjectType = EssPlatform.PublicConstants.Module.SelfOfficeObjectTypes.WorkItems;
      var objectTypeName = string.Format("I{0}s", assignment.GetEntityMetadata().IntegrationServiceName);
      var link = EssPlatform.PublicFunctions.Module.CreateHyperLinkToSelfOffice(targetSystemName, selfOfficeObjectType, objectTypeName, assignment.Id.ToString());
      
      return link;
    }
    
    /// <summary>
    /// Получить ссылку на задание для почтовой рассылки.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="targetSystemName">Имя целевой системы.</param>
    /// <returns>Ссылка на задание в ЛК/RX.</returns>
    [Public]
    public virtual string GetHyperlinkForAssignment(Sungero.Workflow.IAssignmentBase assignment, string targetSystemName)
    {
      var employee = EssPlatformSolution.Employees.As(assignment.Performer);
      var link = string.Empty;
      
      var assignmentInESS = this.CheckAssignmentShowInSelfServiceOffice(assignment);
      
      if (assignmentInESS && employee.PersonalAccountStatusDirRX.Value == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted)
        link = this.GetHyperlinkToSelfServiceOffice(assignment, targetSystemName);
      else
        link = Hyperlinks.Get(assignment);
      
      return link;
    }
    
    /// <summary>
    /// Проверить есть ли задание в ЛК.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <returns>True - если есть, False - если нет.</returns>
    [Public]
    public virtual bool CheckAssignmentShowInSelfServiceOffice(Sungero.Workflow.IAssignmentBase assignment)
    {
      bool assignmentInESS;
      try
      {
        assignmentInESS = (bool)assignment.GetPropertyValue("ShowInSelfServiceOffice");
      }
      catch
      {
        assignmentInESS = false;
        Logger.DebugFormat("DirRX.EssPlatform.Server Assignment {0} has no property ShowInSelfServiceOffice", assignment);
      }
      
      return assignmentInESS;
    }
    
    /// <summary>
    /// Сгенерировать тело письма.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="hasSubstitutions">Признак просрочки.</param>
    /// <returns>Тело письма.</returns>
    public virtual string GenerateBody(Sungero.Workflow.IAssignmentBase assignment, bool hasSubstitutions, string targetSystemName)
    {
      if (!Nustache.Core.Helpers.Contains("process_text"))
        Nustache.Core.Helpers.Register("process_text", ProcessText);
      
      var model = this.GenerateBodyModel(assignment, hasSubstitutions, targetSystemName);
      
      return this.GetMailBodyAsHtml(EssPlatform.Resources.EmailTemplate, model);
    }
    
    /// <summary>
    /// Обработать текст, выделив в нём отдельные абзацы и гиперссылки.
    /// </summary>
    /// <param name="context">Контекст письма.</param>
    /// <param name="args">Аргументы.</param>
    /// <param name="options">Опции.</param>
    /// <param name="function">Функция.</param>
    /// <param name="inverse">Инверс.</param>
    public static void ProcessText(Nustache.Core.RenderContext context, System.Collections.Generic.IList<object> args,
                                   System.Collections.Generic.IDictionary<string, object> options,
                                   Nustache.Core.RenderBlock function, Nustache.Core.RenderBlock inverse)
    {
      var text = (args[0] ?? string.Empty).ToString().Replace(Environment.NewLine, "\n");
      var entityHyperlinksParser = new EntityHyperlinkParser(Sungero.Domain.Shared.HyperlinkParsers.HttpHyperlinkParser);
      var textChunks = entityHyperlinksParser.Parse(text);
      foreach (var chunk in textChunks)
        function(chunk);
    }
    
    /// <summary>
    /// Сгенерировать модель письма.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="hasSubstitutions">Признак просрочки.</param>
    /// <returns>Модель письма.</returns>
    public virtual System.Collections.Generic.Dictionary<string, object> GenerateBodyModel(Sungero.Workflow.IAssignmentBase assignment, bool hasSubstitutions, string targetSystemName)
    {
      var assignmentInESS = this.CheckAssignmentShowInSelfServiceOffice(assignment);
      var model = new Dictionary<string, object>();
      model["Assignment"] = assignment;
      if (!assignmentInESS || EssPlatformSolution.Employees.As(assignment.Performer).PersonalAccountStatusDirRX.Value !=
          EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted)
      {
        model["Attachments"] = assignment.AllAttachments.Where(ent => ent.AccessRights.CanRead(assignment.Performer)).ToList();
      }
      model["HasSubstitutions"] = hasSubstitutions;
      model["Hyperlink"] = this.GetHyperlinkForAssignment(assignment, targetSystemName);
      model["AdministratorEmail"] = AdministrationSettings.AdministratorEmail;
      model["MailingName"] = Sungero.Docflow.Resources.NewAssignmentsMailingName.ToString().Replace(" ", "%20");
      if (!string.Equals(assignment.Subject, assignment.MainTask.Subject))
        model["Subject"] = assignment.MainTask.Subject;
      if (!Equals(assignment.Author, assignment.Performer))
        model["Author"] = assignment.Author;
      return model;
    }

    /// <summary>
    /// Получить тело письма на основе шаблона и модели
    /// </summary>
    /// <param name="template">Шаблон.</param>
    /// <param name="model">Модель.</param>
    /// <returns>Тело письма.</returns>
    public virtual string GetMailBodyAsHtml(string template, System.Collections.Generic.Dictionary<string, object> model)
    {
      if (string.IsNullOrEmpty(template) || model == null)
        return string.Empty;
      
      return Nustache.Core.Render.StringToString(template, model,
                                                 new Nustache.Core.RenderContextBehaviour() { OnException = ex => Logger.Error(ex.Message, ex) });
    }
    
    /// <summary>
    /// Добавить логотип во вложения письма.
    /// </summary>
    /// <param name="message">Письмо.</param>
    public virtual void AddLogo(Sungero.Core.IEmailMessage message)
    {
      var logo = new System.IO.MemoryStream(Sungero.Core.SystemInfo.GetLogo());
      var attachment = message.AddAttachment(logo, "logo.png@01D004A6.A303C580");
      attachment.ContentId = "logo.png@01D004A6.A303C580";
      attachment.IsInline = true;
      attachment.MediaType = "image/png";
    }
    #endregion
  }
}