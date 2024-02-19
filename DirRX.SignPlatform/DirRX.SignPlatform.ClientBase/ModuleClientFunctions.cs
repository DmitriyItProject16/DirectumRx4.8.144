using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace DirRX.SignPlatform.Client
{
  public class ModuleFunctions
  {
    /// <summary>
    /// Стартовать задачу на выпуск сертификата электронной подписи.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="fromTask">Задачa, из которой запускается запрос.</param>
    /// <returns>Структура с результатами старта задачи.</returns>
    [Public]
    public virtual DirRX.SignPlatform.Structures.Module.IStartCertificateIssueTaskResult StartCertificateIssueTask(EssPlatformSolution.IEmployee employee, DirRX.SignPlatform.ICertificateIssueTask fromTask)
    {
      var startTaskResult = DirRX.SignPlatform.Structures.Module.StartCertificateIssueTaskResult.Create();
      startTaskResult.IsStarted = false;
      startTaskResult.StartTaskError = string.Empty;
      startTaskResult.DataErrorList = new List<DirRX.SignPlatform.Structures.Module.IStartCertificateIssueTaskError>();
      
      if (DirRX.SignPlatform.CertificateIssueTasks.GetAll(c => !Equals(fromTask, c) && c.Employee.Id == employee.Id && c.Status.HasValue &&
                                                          c.Status.Value == Sungero.Workflow.Task.Status.InProcess).Any())
      {
        var dialog = Dialogs.CreateTaskDialog(DirRX.EssPlatformSolution.Employees.Resources.CertificateIssueTaskAlreadyExist, MessageType.Question);
        dialog.Buttons.AddOkCancel();
        dialog.Buttons.Default = DialogButtons.Ok;
        
        if (dialog.Show() != DialogButtons.Ok)
        {
          return startTaskResult;
        }
      }
      
      if (Sungero.CoreEntities.Certificates.GetAll(c => c.Owner.Id == employee.Id && c.Enabled == true &&
                                                   c.PluginId == SignPlatform.PublicConstants.Module.PluginIdOfCloudCertificates).Any())
      {
        var dialog = Dialogs.CreateTaskDialog(DirRX.EssPlatformSolution.Employees.Resources.CloudCertificateAlreadyExist, MessageType.Question);
        dialog.Buttons.AddOkCancel();
        dialog.Buttons.Default = DialogButtons.Ok;
        
        if (dialog.Show() != DialogButtons.Ok)
        {
          return startTaskResult;
        }
      }
      
      // Если второй фактор или "email" или "по умолчанию" и в общих настройках email.
      var settings = EssPlatform.PublicFunctions.EssSetting.GetSettings();
      if (((employee.ConfirmationTypeDirRX == DirRX.EssPlatformSolution.Employee.ConfirmationTypeDirRX.DefaultValue && 
            settings.ConfirmationType == EssPlatform.EssSetting.ConfirmationType.Email) ||
            employee.ConfirmationTypeDirRX == DirRX.EssPlatformSolution.Employee.ConfirmationTypeDirRX.Email) &&
          (string.IsNullOrEmpty(employee.Email) && string.IsNullOrEmpty(employee.MessagesEmailDirRX)))
      {
        var error = DirRX.SignPlatform.Structures.Module.StartCertificateIssueTaskError.Create();
        error.Error = DirRX.EssPlatformSolution.Employees.Resources.EmptyPersonalEMailOrWorkEmailError;
        error.ShowPersonAction = false;
        startTaskResult.DataErrorList.Add(error);
        return startTaskResult;
      }
      
      var employeeErrors = SignPlatform.PublicFunctions.Module.Remote.ValidateEmployeeRequiredFields(employee);
      foreach (var employeeError in employeeErrors)
      {
        var error = DirRX.SignPlatform.Structures.Module.StartCertificateIssueTaskError.Create();
        error.Error = employeeError;
        error.ShowPersonAction = false;
        startTaskResult.DataErrorList.Add(error);
      }
      var personErrors = SignPlatform.PublicFunctions.Module.Remote.ValidatePersonRequiredFields(employee.Person);
      foreach (var personError in personErrors)
      {
        var error = DirRX.SignPlatform.Structures.Module.StartCertificateIssueTaskError.Create();
        error.Error = personError;
        error.ShowPersonAction = true;
        startTaskResult.DataErrorList.Add(error);
      }
      if (startTaskResult.DataErrorList.Any())
        return startTaskResult;
      
      var userConnectionParams = SignPlatform.PublicFunctions.Module.SetActivatingEssUserParameters(employee);
      if (userConnectionParams.IsSet == false)
        return startTaskResult;
      
      var errorText = SignPlatform.PublicFunctions.Module.Remote.IssueCertificate(employee, Users.Current, userConnectionParams.CloudSignProviderInfo.ProviderId, fromTask);
      if (!string.IsNullOrEmpty(errorText))
        startTaskResult.StartTaskError = errorText;
      else
        startTaskResult.IsStarted = true;
      
      return startTaskResult;
    }

    /// <summary>
    /// Установить параметры подключения пользователя к ЛК.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <returns>Структура с параметрами подключения пользователя к ЛК.</returns>
    [Public]
    public virtual SignPlatform.Structures.Module.IUserConnectionParams SetActivatingEssUserParameters(EssPlatformSolution.IEmployee employee)
    {
      try
      {
        if(string.IsNullOrEmpty(DirRX.EssPlatform.PublicFunctions.EssSetting.GetSettings().SignServiceAddress))
        {
          throw AppliedCodeException.Create(DirRX.SignPlatform.Resources.AddressOfSignServiceIsNullOrEmpty);
        }
        
        var cloudSignProviderInfos = SignPlatform.PublicFunctions.Module.GetCloudSignProviderInfo();
        var userConnectionParams = new SignPlatform.Structures.Module.UserConnectionParams();
        userConnectionParams.CloudSignProviderInfo = cloudSignProviderInfos.FirstOrDefault();
        
        if (userConnectionParams.CloudSignProviderInfo == null)
        {
          Dialogs.ShowMessage(DirRX.SignPlatform.Resources.InvalidIdentificationTypeFormat(employee.Name), MessageType.Error);
          userConnectionParams.IsSet = false;
          return userConnectionParams;
        }
        
        var dialog = Dialogs.CreateInputDialog(SignPlatform.Resources.SetIdentificationTypeDialogTitle);
        dialog.Buttons.AddOkCancel();
        dialog.Buttons.Default = DialogButtons.Ok;
        
        var cloudSignProviderType = dialog
          .AddSelect(SignPlatform.Resources.SetIdentificationTypeDialogCloudProvider, true, userConnectionParams.CloudSignProviderInfo.Name)
          .From(cloudSignProviderInfos.Select(info => info.Name).ToArray());
        
        var identificationTypeName = dialog
          .AddSelect(SignPlatform.Resources.SetIdentificationTypeDialogIdentificationType, true, userConnectionParams.CloudSignProviderInfo.IdentificationTypes.Select(type => type.Value).First())
          .From(userConnectionParams.CloudSignProviderInfo.IdentificationTypes.Select(type => type.Value).ToArray());
        
        cloudSignProviderType.SetOnValueChanged((x) =>
                                                {
                                                  if (x.NewValue != x.OldValue)
                                                  {
                                                    userConnectionParams.CloudSignProviderInfo = cloudSignProviderInfos.Single(info => Equals(x.NewValue, info.Name));
                                                    
                                                    identificationTypeName.From(userConnectionParams.CloudSignProviderInfo.IdentificationTypes.Select(type => type.Value).ToArray());
                                                  }
                                                });

        if (dialog.Show() == DialogButtons.Ok)
        {
          var identificationType = cloudSignProviderInfos.Single(info => Equals(info.Name, cloudSignProviderType.Value))
            .IdentificationTypes
            .First(type => Equals(type.Value, identificationTypeName.Value))
            .Key;
          var person = DirRX.EssPlatformSolution.People.Get(employee.Person.Id);
          
          switch (identificationType)
          {
            case "Personal":
              person.IdentificationTypeDirRx = EssPlatformSolution.Person.IdentificationTypeDirRx.Personal;
              person.Save();
              userConnectionParams.IsSet = true;
              return userConnectionParams;
            case "Esia":
              person.IdentificationTypeDirRx = EssPlatformSolution.Person.IdentificationTypeDirRx.Esia;
              person.Save();
              userConnectionParams.IsSet = true;
              return userConnectionParams;
            default:
              Dialogs.ShowMessage(DirRX.SignPlatform.Resources.InvalidIdentificationTypeFormat(employee.Name), MessageType.Error);
              userConnectionParams.IsSet = false;
              return userConnectionParams;
          }
        }
        else
        {
          userConnectionParams.IsSet = false;
          return userConnectionParams;
        }
      }
      // Перехватить ошибку "хост не найдет", которая будет признаком того, что пропал канал связи с сервисом.
      catch (System.Net.Http.HttpRequestException ex)
      {
        Logger.DebugFormat("===>>> {0} {1} {2} {3} {4}", ex.GetType(), ex.InnerException, ex.Message, ex.Source, ex.Data);
        if(ex.InnerException.GetType() == typeof(System.Net.Sockets.SocketException))
        {
          Logger.DebugFormat("CertificateIssue. SetActivatingEssUserParameters() SignService not answered.");
          Dialogs.ShowMessage(DirRX.SignPlatform.Resources.CloudSignProviderUnavailable, MessageType.Error);
          var userConnectionParams = new SignPlatform.Structures.Module.UserConnectionParams();
          userConnectionParams.IsSet = false;
          return userConnectionParams;
        }
        else
        {
          throw ex;
        }
      }
    }
  }
}