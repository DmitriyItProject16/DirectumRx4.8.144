using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatform.EssSetting;

namespace DirRX.EssPlatform
{
  partial class EssSettingServerHandlers
  {

    public override void BeforeSave(Sungero.Domain.BeforeSaveEventArgs e)
    {
      // Если не подключена настройка "Подключить сервисы личного кабинета", то последующие проверки выполняться не будут.
      if (_obj.IsUsedIdentityService != true)
        return;
      
      // Сначала проверить соответствие адреса ЛК формату URL, затем - корректность подключения,
      // проверять только для непустой строки.
      if (!string.IsNullOrEmpty(_obj.ESSAddress))
      {
        if (System.Uri.IsWellFormedUriString(_obj.ESSAddress, UriKind.Absolute))
        {
          var essConnectionErrors = DirRX.EssPlatform.PublicFunctions.Module.Remote.CheckESSConnection(_obj.ESSAddress);
          if (!string.IsNullOrEmpty(essConnectionErrors))
          {
            e.AddError(Resources.ESSCheckConnectionErrorFormat(essConnectionErrors));
          }
        }
        else
        {
          e.AddError(DirRX.EssPlatform.EssSettings.Resources.ESSUrlIsInvalid);
        }
      }
      
      // Сначала проверить соответствие адреса Idintity Service формату URL, затем - корректность подключения,
      // проверять только для непустой строки.
      if (!string.IsNullOrEmpty(_obj.IdentityServiceAddress))
      {
        if (System.Uri.IsWellFormedUriString(_obj.IdentityServiceAddress, UriKind.Absolute))
        {
          var loginResult = Functions.EssSetting.LoginIds(_obj, _obj.IdentityServicePassword, true);
          
          if (!string.IsNullOrEmpty(loginResult.Error))
          {
            e.AddError(loginResult.Error);
          }
        }
        else
        {
          e.AddError(DirRX.EssPlatform.EssSettings.Resources.IdsUrlInvalid);
        }
      }
      
      // Сначала проверить соответствие адреса MessageBroker формату URL, затем - корректность подключения,
      // проверять только для непустой строки.
      if (!string.IsNullOrEmpty(_obj.MessageBrokerAddress))
      {
        if (System.Uri.IsWellFormedUriString(_obj.MessageBrokerAddress, UriKind.Absolute))
        {
          var connectionErrors = DirRX.EssPlatform.PublicFunctions.Module.Remote.CheckMessageBrokerConnection(_obj.MessageBrokerAddress);
          if (!string.IsNullOrEmpty(connectionErrors))
          {
            e.AddError(Resources.MessageBrokerCheckConnectionErrorFormat(connectionErrors));
          }
        }
        else
        {
          e.AddError(DirRX.EssPlatform.EssSettings.Resources.MBUrlIsInvalid);
        }
      }
      
      // Сначала проверить соответствие адреса SignService формату URL, затем - корректность подключения,
      // проверять только для непустой строки.
      if (!string.IsNullOrEmpty(_obj.SignServiceAddress))
      {
        if (System.Uri.IsWellFormedUriString(_obj.SignServiceAddress, UriKind.Absolute))
        {
          var connectionErrors = DirRX.EssPlatform.PublicFunctions.Module.Remote.CheckSignServiceConnection(_obj.SignServiceAddress);
          if (!string.IsNullOrEmpty(connectionErrors))
          {
            e.AddError(Resources.SignServiceCheckConnectionErrorFormat(connectionErrors));
          }
        }
        else
        {
          e.AddError(DirRX.EssPlatform.EssSettings.Resources.SignServiceUrlIsInvalid);
        }
      }
      
      // Проверить соответствие адреса Соглашения об ЭДО формату URL.
      if (!string.IsNullOrEmpty(_obj.AgreementUrl))
      {
        if (!System.Uri.IsWellFormedUriString(_obj.AgreementUrl, UriKind.Absolute))
        {
          e.AddError(DirRX.EssPlatform.EssSettings.Resources.AgreementUrlIsInvalid);
        }
      }
      
      // Проверить заполненность электронной почты для сертификатов.
      if (string.IsNullOrEmpty(_obj.CertificateMail))
        e.AddError(DirRX.EssPlatform.EssSettings.Resources.EmptyCertificateMail);
      
      // Проверить, есть ли пользователи с облачным сертификатом и незаполненым Email.
      if (_obj.ConfirmationType == EssSetting.ConfirmationType.Email &&
          EssPlatformSolution.Employees.GetAll(em => em.ConfirmationTypeDirRX.HasValue &&
                                               em.ConfirmationTypeDirRX == EssPlatformSolution.Employee.ConfirmationTypeDirRX.DefaultValue &&
                                               (em.Email == null && em.MessagesEmailDirRX == null) &&
                                               Certificates.GetAll().Where(c => c.Owner.Equals(Users.As(em))
                                                                           && c.PluginId.ToLower().Equals(SignPlatform.PublicConstants.Module.PluginIdOfCloudCertificates)
                                                                           && c.Enabled == true).Any()).Any())
      {
        e.Params.AddOrUpdate(Constants.Module.ConfirmationTypeChangedParamName, false);
        e.AddError(DirRX.EssPlatform.EssSettings.Resources.HasEmployeeWithoutEmail, _obj.Info.Actions.ShowEmplWithoutEmail);
      }
      
      // Изменить способ подтверждения на сервисе подписания.
      bool isConfirmationTypeChanged;
      var isConfirmationTypeChangedHasValue = e.Params.TryGetValue(Constants.Module.ConfirmationTypeChangedParamName, out isConfirmationTypeChanged);
      if (isConfirmationTypeChangedHasValue == true && isConfirmationTypeChanged == true)
      {
        var isChangeOnSignService = SignPlatform.PublicFunctions.Module.Remote.ChangeConfirmationType(_obj.ConfirmationType.Value.Value);
        if (isChangeOnSignService == false)
        {
          e.AddError(DirRX.EssPlatform.EssSettings.Resources.CanNotChangeConfirmationType);
        }
      }
    }

    public override void BeforeDelete(Sungero.Domain.BeforeDeleteEventArgs e)
    {
      throw AppliedCodeException.Create(DirRX.EssPlatform.EssSettings.Resources.EssSettingsCannotBeDeleted);
    }
  }

}