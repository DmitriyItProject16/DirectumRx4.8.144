using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Employee;

namespace DirRX.EssPlatformSolution.Client
{
  partial class EmployeeActions
  {
    public virtual void ChangeConfirmationTypeDirRX(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      var dialog = Dialogs.CreateInputDialog(DirRX.EssPlatformSolution.Employees.Resources.ChangingConfirmationTypeWhenSigning);
      
      var defaultConfirmationType = _obj.ConfirmationTypeDirRX.HasValue
        ? SignPlatform.PublicFunctions.Module.Remote.GetConfirmationTypeLocalized(_obj.ConfirmationTypeDirRX.Value.Value)
        : DirRX.SignPlatform.Resources.EssSetting_Enum_ConfirmationType_DefaultValue;
      
      var confirmationTypesLocalized = DirRX.SignPlatform.PublicFunctions.Module.Remote.GetConfirmationTypesLocalized();
      var selectedConfirmationTypeLocalized = dialog
        .AddSelect(DirRX.EssPlatform.Resources.ConfirmationType, true, defaultConfirmationType)
        .From(confirmationTypesLocalized.ToArray());
      
      if (dialog.Show() == DialogButtons.Ok)
      {
        var confirmationTypeEnumeration = DirRX.SignPlatform.PublicFunctions.Module.Remote.GetConfirmationTypeEnumeration(selectedConfirmationTypeLocalized.Value);
        if (confirmationTypeEnumeration == DirRX.EssPlatformSolution.Employee.ConfirmationTypeDirRX.Email && string.IsNullOrEmpty(_obj.Email) && string.IsNullOrEmpty(_obj.MessagesEmailDirRX))
        {
          e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmptyPersonalEMailOrWorkEmailError);
          return;
        }
        
        var partTimeWorkers = Employees.GetAll(x => Equals(x.Person, _obj.Person) && x.Status == Employee.Status.Active && x.Id != _obj.Id).ToList();
        if (confirmationTypeEnumeration == DirRX.EssPlatformSolution.Employee.ConfirmationTypeDirRX.Email)
        {
          foreach(var partTimeWorker in partTimeWorkers)
          {
            if(string.IsNullOrEmpty(partTimeWorker.Email) && string.IsNullOrEmpty(partTimeWorker.MessagesEmailDirRX))
            {
              e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmptyPersonalEMailOrWorkEmailPartTimeWorkerError);
              return;
            }
          }
        }
        
        if (!_obj.ConfirmationTypeDirRX.Value.Equals(confirmationTypeEnumeration))
        {
          var result = SignPlatform.PublicFunctions.Module.Remote.ChangeConfirmationTypeForCertificateOwner(confirmationTypeEnumeration.Value,
                                                                                                            EssPlatform.PublicFunctions.Module.Remote.GetUidPerson(_obj.Person));
          if (result.IsCompleted)
          {
            e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.PropertyChangedFormat(_obj.Info.Properties.ConfirmationTypeDirRX.LocalizedName, _obj.Person.Name));
            _obj.ConfirmationTypeDirRX = confirmationTypeEnumeration;
            _obj.Save();
          }
          else
            Dialogs.ShowMessage(result.ErrorMessage, string.Empty, MessageType.Error, string.Empty);
        }
      }
    }

    public virtual bool CanChangeConfirmationTypeDirRX(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      var businessUnit = Sungero.Company.PublicFunctions.BusinessUnit.Remote.GetBusinessUnit(_obj);
      var useESSDirRX = businessUnit == null || (businessUnit != null
                                                 && EssPlatformSolution.BusinessUnits.As(businessUnit).UseESSDirRX.HasValue
                                                 && EssPlatformSolution.BusinessUnits.As(businessUnit).UseESSDirRX.Value);
      
      return !_obj.State.IsChanged
        && _obj.Status.Value == Sungero.Company.Employee.Status.Active
        && useESSDirRX;
    }
    
    public virtual bool CanTempDisconnectDirRX(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }
    
    public virtual void TempDisconnectDirRX(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      // Действие используется в сообщении, которое выводится на событии До сохранения записи, если изменили состояние на "Закрытая".
      // При выборе варианта "Временно отключить" записать в параметр значение True.
      // Наличие параметра означает, что выводить сообщение повторно не нужно (вариант отключения выбран). Значение True - что отключение временное.
      e.Params.AddOrUpdate(EssPlatform.Resources.ParameterIsTempDisconnectFormat(_obj.Id), true);
      _obj.Save();
    }
    
    public virtual void RevokeCertificateIssueTaskDirRx(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      var dialog = Dialogs.CreateInputDialog(DirRX.EssPlatformSolution.Employees.Resources.RevokeCertificateDialogTitle);
      
      // Выбор сертификата
      var certList = Sungero.CoreEntities.Certificates.GetAll(w => w.Owner.Id == _obj.Id && w.Enabled == true && w.PluginId != null && w.PluginId.ToLower() == DirRX.SignPlatform.PublicConstants.Module.PluginIdOfCloudCertificates);
      var certificates = dialog
        .AddSelect(DirRX.EssPlatformSolution.Employees.Resources.Certificate, true, (certList?.Count() == 1 ? certList.FirstOrDefault() : Sungero.CoreEntities.Certificates.Null))
        .From(certList);
      
      var revocationReasons = SignPlatform.PublicFunctions.Module.GetRevocationReasons();
      
      // Причина
      var reasonRevoke = dialog
        .AddSelect(DirRX.EssPlatformSolution.Employees.Resources.RevocationReason, true, revocationReasons.Select(type => type.Value).FirstOrDefault())
        .From(revocationReasons.Select(type => type.Value).ToArray());
      
      if (dialog.Show() == DialogButtons.Ok)
      {
        var revocationReason = revocationReasons.Single(w => Equals(reasonRevoke.Value, w.Value));
        var providerId = SignPlatform.PublicFunctions.Module.GetCertificateProvider(certificates.Value.Id);
        var error = SignPlatform.PublicFunctions.Module.Remote.SendRevokeCertificate(certificates.Value.Thumbprint, revocationReason.Key, providerId);
        if (string.IsNullOrEmpty(error) || error.Equals(DirRX.SignPlatform.PublicConstants.Module.RevokeException))
        {
          var errors = SignPlatform.PublicFunctions.Module.Remote.SetDisableEmployeeCertificates(certificates.Value.Thumbprint);
          if (errors.Any())
            Dialogs.ShowMessage(DirRX.EssPlatformSolution.Employees.Resources.CertificateRevocationError, errors.FirstOrDefault(), MessageType.Error, string.Empty);
          else
            Dialogs.ShowMessage(DirRX.EssPlatformSolution.Employees.Resources.RevocationDone, string.Empty, MessageType.Information, string.Empty);
        }
        else
        {
          Dialogs.ShowMessage(DirRX.EssPlatformSolution.Employees.Resources.CertificateRevocationError, string.Empty, MessageType.Error, string.Empty);
        }
      }
    }
    
    public virtual bool CanRevokeCertificateIssueTaskDirRx(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      var businessUnit = Sungero.Company.PublicFunctions.BusinessUnit.Remote.GetBusinessUnit(_obj);
      var useESSDirRX = businessUnit == null || (businessUnit != null
                                                 && EssPlatformSolution.BusinessUnits.As(businessUnit).UseESSDirRX.HasValue
                                                 && EssPlatformSolution.BusinessUnits.As(businessUnit).UseESSDirRX.Value);
      
      return !_obj.State.IsInserted
        && _obj.AccessRights.CanRevokeCertificateIssueTaskDirRx()
        && useESSDirRX;
    }
    
    public virtual void CreateCertificateIssueTaskDirRx(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      var personEmployees = DirRX.EssPlatformSolution.Employees.GetAll(emp => emp.Person == _obj.Person && emp.Status == Sungero.Company.Employee.Status.Active);
      
      var mainEmployee = EssPlatform.PublicFunctions.Module.Remote.GetPersonMainEmployee(_obj.Person.Id, null);
      
      var startCertificateIssueTaskResult = SignPlatform.PublicFunctions.Module.StartCertificateIssueTask(mainEmployee, null);
      if (startCertificateIssueTaskResult.IsStarted)
        Dialogs.NotifyMessage(DirRX.EssPlatformSolution.Employees.Resources.IssueCertificateTaskSent);
      else if (string.IsNullOrEmpty(startCertificateIssueTaskResult.StartTaskError) && !startCertificateIssueTaskResult.DataErrorList.Any())
        return;
      else
      {
        if (startCertificateIssueTaskResult.DataErrorList.Any())
        {
          foreach (var error in startCertificateIssueTaskResult.DataErrorList)
          {
            if (error.ShowPersonAction)
              e.AddError(error.Error, _obj.Info.Actions.ShowPerson);
            else
              e.AddError(error.Error);
          }
          return;
        }
        if (!string.IsNullOrEmpty(startCertificateIssueTaskResult.StartTaskError))
          Dialogs.CreateTaskDialog(DirRX.EssPlatformSolution.Employees.Resources.BeforeCertificateIssueTaskErrorFormat(startCertificateIssueTaskResult.StartTaskError), MessageType.Error).Show();
      }
    }

    public virtual bool CanCreateCertificateIssueTaskDirRx(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      var businessUnit = Sungero.Company.PublicFunctions.BusinessUnit.Remote.GetBusinessUnit(_obj);
      var useESSDirRX = businessUnit == null || (businessUnit != null
                                                 && EssPlatformSolution.BusinessUnits.As(businessUnit).UseESSDirRX.HasValue
                                                 && EssPlatformSolution.BusinessUnits.As(businessUnit).UseESSDirRX.Value);
      
      return !_obj.State.IsInserted
        && _obj.Status.Value == Sungero.Company.Employee.Status.Active
        && _obj.AccessRights.CanCreateCertificateIssueTaskDirRx()
        && useESSDirRX;
    }

    public virtual void ShowPerson(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      _obj.Person.ShowModal();
    }

    public virtual bool CanShowPerson(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

    public virtual void DeleteEssUserDirRX(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      if (Functions.Employee.CheckLockCardEmployeeOrPartTime(_obj))
      {
        e.AddError(EssPlatform.Resources.EmployeeCardIsLockedFormat(_obj.Name));
        return;
      }
      
      if(_obj.State.IsChanged)
      {
        e.AddError(DirRX.EssPlatformSolution.Employees.Resources.SaveBeforeDeleteESSUser);
        return;
      }
      
      // Предупредить о том, что при отключении ЛК будут отключены все сотрудники указанной персоны.
      if (!EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.Status))
      {
        var warningDialog = Dialogs.CreateTaskDialog(DirRX.EssPlatformSolution.Employees.Resources.PersonHasSeveralActiveEmployeesFormat(_obj.Person.Name), MessageType.Warning);
        var ok = warningDialog.Buttons.AddOk();
        warningDialog.Buttons.AddCancel();
        warningDialog.Buttons.Default = ok;
        if (warningDialog.Show() == DialogButtons.Cancel)
          return;
      }
      
      var certificateIssueTaskIds = DirRX.SignPlatform.CertificateIssueTasks.GetAll(c => c.Employee.Id == _obj.Id && c.Status.HasValue && c.Status.Value == Sungero.Workflow.Task.Status.InProcess).Select(i => i.Id);
      if(certificateIssueTaskIds.Any())
      {
        var abortIssueTask = DirRX.SignPlatform.AsyncHandlers.AbortIssueTask.Create();
        abortIssueTask.TaskIds = string.Join(",", certificateIssueTaskIds);
        abortIssueTask.ExecuteAsync();
      }
      // Если сотрудник уже работает в ЛК, запросить вариант отключения.
      if (_obj.PersonalAccountStatusDirRX.Value == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted)
      {
        var selectActionDialog = Dialogs.CreateInputDialog(DirRX.EssPlatformSolution.Employees.Resources.DeleteEssUserDialogHeader, DirRX.EssPlatformSolution.Employees.Resources.DeleteEssUserDialogString);
        var deleteButton = selectActionDialog.Buttons.AddCustom(DirRX.EssPlatformSolution.Employees.Resources.DeleteEssUserDialogButton);
        var temporaryDisconnectButton = selectActionDialog.Buttons.AddCustom(DirRX.EssPlatformSolution.Employees.Resources.TemporaryDisconnectEssUserDialogButton);
        selectActionDialog.Buttons.AddCancel();
        var result = selectActionDialog.Show();
        if (result == deleteButton || result == temporaryDisconnectButton)
        {
          if (result == deleteButton)
          {
            EssPlatform.PublicFunctions.Module.Remote.DisconnectEssUser(_obj);
            Dialogs.NotifyMessage(DirRX.EssPlatformSolution.Employees.Resources.EssUserDisconnectNotify);
          }
          else if (result == temporaryDisconnectButton)
          {
            EssPlatform.PublicFunctions.Module.Remote.TemporaryDisconnectEssUser(_obj);
            Dialogs.NotifyMessage(DirRX.EssPlatformSolution.Employees.Resources.EssUserTemporaryDisconnectNotify);
          }
          
          if (EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.Status))
            e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.ErrorChangeStatusWhenEmployeeCardLock);
          else
            e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.ErrorChangeStatusWhenPartTimeEmployeeCardLock);
        }
      }
      // Если приглашение отправили, но сотрудник его еще не принял, отключить без запроса варианта.
      else if (_obj.PersonalAccountStatusDirRX.Value == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteSent)
      {
        EssPlatform.PublicFunctions.Module.Remote.DisconnectEssUser(_obj);
        Dialogs.NotifyMessage(DirRX.EssPlatformSolution.Employees.Resources.EssUserDisconnectNotify);
        
        if (EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.Status))
          e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.ErrorChangeStatusWhenEmployeeCardLock);
        else
          e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.ErrorChangeStatusWhenPartTimeEmployeeCardLock);
      }
      
      // При отключении ставим поля с СМС или Вайбером в емаил если поля с емаил заполнены.
      var hasEmailPersonal = !string.IsNullOrEmpty(_obj.MessagesEmailDirRX);
      var hasEmail = !string.IsNullOrEmpty(_obj.Email);
      if(_obj.NeedNotifyNewHRAssignmentDirRX == Employee.NeedNotifyNewHRAssignmentDirRX.SMS || _obj.NeedNotifyNewHRAssignmentDirRX == Employee.NeedNotifyNewHRAssignmentDirRX.Viber)
      {
        _obj.NeedNotifyNewHRAssignmentDirRX = Employee.NeedNotifyNewHRAssignmentDirRX.No;
        if(hasEmail)
          _obj.NeedNotifyNewHRAssignmentDirRX = Employee.NeedNotifyNewHRAssignmentDirRX.Email;
        if(hasEmailPersonal)
          _obj.NeedNotifyNewHRAssignmentDirRX = Employee.NeedNotifyNewHRAssignmentDirRX.EmailPersonal;
      }
      if(_obj.NeedNotifyExpiredHRAssignmentDirRX == Employee.NeedNotifyExpiredHRAssignmentDirRX.SMS || _obj.NeedNotifyExpiredHRAssignmentDirRX == Employee.NeedNotifyExpiredHRAssignmentDirRX.Viber)
      {
        _obj.NeedNotifyExpiredHRAssignmentDirRX = Employee.NeedNotifyExpiredHRAssignmentDirRX.No;
        if(hasEmail)
          _obj.NeedNotifyExpiredHRAssignmentDirRX = Employee.NeedNotifyExpiredHRAssignmentDirRX.Email;
        if(hasEmailPersonal)
          _obj.NeedNotifyExpiredHRAssignmentDirRX = Employee.NeedNotifyExpiredHRAssignmentDirRX.EmailPersonal;
      }
      if(_obj.NeedNotifyHRRepeatDirRX == Employee.NeedNotifyHRRepeatDirRX.SMS || _obj.NeedNotifyHRRepeatDirRX == Employee.NeedNotifyHRRepeatDirRX.Viber)
      {
        _obj.NeedNotifyHRRepeatDirRX = Employee.NeedNotifyHRRepeatDirRX.No;
        if(hasEmail)
          _obj.NeedNotifyHRRepeatDirRX = Employee.NeedNotifyHRRepeatDirRX.Email;
        if(hasEmailPersonal)
          _obj.NeedNotifyHRRepeatDirRX = Employee.NeedNotifyHRRepeatDirRX.EmailPersonal;
      }
      
      _obj.Save();
    }

    public virtual bool CanDeleteEssUserDirRX(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      // Действие доступно если:
      //   - у пользователя есть права
      //   - приглашение ему отправлялось
      //   - выбрано Подключить сервисы личного кабинета
      return _obj.AccessRights.CanCreateEssUsersDirRX() &&
        _obj.PersonalAccountStatusDirRX.HasValue &&
        _obj.PersonalAccountStatusDirRX.Value != DirRX.EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent &&
        EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected();
    }
    
    public virtual void DisconnectDirRX(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      // Действие используется в сообщении, которое выводится на событии До сохранения записи, если изменили состояние на "Закрытая".
      // При выборе варианта "Отключить" записать в параметр значение False.
      // Наличие параметра означает, что выводить сообщение повторно не нужно (вариант отключения выбран). Значение False - что отключение постоянное.
      e.Params.AddOrUpdate(EssPlatform.Resources.ParameterIsTempDisconnectFormat(_obj.Id), false);
      _obj.Save();
    }

    public virtual bool CanDisconnectDirRX(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

    public virtual void CreateESSUserDirRX(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      if (Functions.Employee.CheckLockCardEmployeeOrPartTime(_obj))
      {
        e.AddError(EssPlatform.Resources.EmployeeCardIsLockedFormat(_obj.Name));
        return;
      }
      
      if(_obj.State.IsChanged)
      {
        e.AddError(DirRX.EssPlatformSolution.Employees.Resources.SaveBeforeCreateESSUser);
        return;
      }
      
      // Отправить приглашение сотруднику можно только при закрытой карточке настроек личного кабинета.
      
      var canCreateEssUser = false;
      var businessUnit = _obj.Department.BusinessUnit;
      if (businessUnit != null && businessUnit.Status.Value == Sungero.Company.BusinessUnit.Status.Active)
      {
        var businessUnitO = EssPlatformSolution.BusinessUnits.As(businessUnit);
        canCreateEssUser = businessUnitO.UseESSDirRX.HasValue && businessUnitO.UseESSDirRX.Value;
      }
      if (!canCreateEssUser)
      {
        e.AddError(DirRX.EssPlatformSolution.Employees.Resources.BusinessUnitOfEmployeeIsNotUseEssError);
        return;
      }
      // Проверить, что указан Личный телефон.
      if (string.IsNullOrEmpty(_obj.PersonalPhoneDirRX))
      {
        e.AddError(DirRX.EssPlatformSolution.Employees.Resources.PersonalPhoneRequired);
        return;
      }
      
      var employeeErrors = SignPlatform.PublicFunctions.Module.Remote.ValidateEmployeeRequiredFields(_obj);
      var personErrors = SignPlatform.PublicFunctions.Module.Remote.ValidatePersonRequiredFields(_obj.Person);
      
      if (employeeErrors.Any() || personErrors.Any())
      {
        employeeErrors.ForEach(e.AddError);
        personErrors.ForEach(error => e.AddError(error, _obj.Info.Actions.ShowPerson));
        
        return;
      }
      
      try
      {
        var personUid = EssPlatform.PublicFunctions.Module.Remote.GetUidPerson(_obj.Person);
        var activateExistsUser = EssPlatform.PublicFunctions.Module.Remote.ExistsIdsUser(personUid);
        
        EssPlatform.PublicFunctions.Module.Remote.ActivateESSUser(_obj);
        
        e.Params.AddOrUpdate(EssPlatform.Resources.ParameterOldPhoneEmpForUpdateFormat(_obj.Id), _obj.PersonalPhoneDirRX);
        Dialogs.NotifyMessage(activateExistsUser ? DirRX.EssPlatformSolution.Employees.Resources.ESSUserActivated : EssPlatform.Resources.ESSInviteSent);
        
        if (_obj.PersonalAccountStatusDirRX != EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted)
        {
          if (activateExistsUser)
            EssPlatform.PublicFunctions.Module.ChangePersonalAccountStatus(_obj, EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted);
          else
            EssPlatform.PublicFunctions.Module.ChangePersonalAccountStatus(_obj, EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteSent);
          
          if (EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.Status))
            e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.ErrorChangeStatusWhenEmployeeCardLock);
          else
            e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.ErrorChangeStatusWhenPartTimeEmployeeCardLock);
        }
        else
          Dialogs.NotifyMessage(EssPlatform.Resources.ErrorESSInvite);
        
        if (SignPlatform.CertificateIssueTasks.GetAll(c => c.Employee.Id == _obj.Id && c.Status.HasValue &&
                                                      c.Status.Value == Sungero.Workflow.Task.Status.InProcess).Any())
        {
          var dialog = Dialogs.CreateTaskDialog(DirRX.EssPlatformSolution.Employees.Resources.CertificateIssueTaskAlreadyExist, MessageType.Question);
          dialog.Buttons.AddOkCancel();
          dialog.Buttons.Default = DialogButtons.Ok;
          
          if (dialog.Show() != DialogButtons.Ok)
            return;
        }
        
        var userConnectionParams = SignPlatform.PublicFunctions.Module.SetActivatingEssUserParameters(_obj);
        if (userConnectionParams.IsSet == true)
        {
          var error = SignPlatform.PublicFunctions.Module.Remote.IssueCertificate(_obj, Users.Current, userConnectionParams.CloudSignProviderInfo.ProviderId);
          
          if(!string.IsNullOrEmpty(error))
            Dialogs.CreateTaskDialog(DirRX.EssPlatformSolution.Employees.Resources.BeforeCertificateIssueTaskErrorFormat(error), MessageType.Error).Show();
          
          else
            Dialogs.NotifyMessage(DirRX.EssPlatformSolution.Employees.Resources.IssueCertificateTaskSent);
        }
      }
      catch (Exception ex)
      {
        throw AppliedCodeException.Create(EssPlatform.Resources.ActivateEssUserErrorFormat(ex.Message));
      }
    }
    
    public virtual bool CanCreateESSUserDirRX(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      // Действие доступно если:
      //   - у пользователя есть права
      //   - сотрудник действующий и приглашение ему еще не отправлено
      //   - выбрано Подключить сервисы личного кабинета

      return _obj.AccessRights.CanCreateEssUsersDirRX() &&
        _obj.Status.Value == Sungero.Company.Employee.Status.Active &&
        _obj.Person.Status.Value == DirRX.EssPlatformSolution.Person.Status.Active &&
        _obj.PersonalAccountStatusDirRX.HasValue &&
        _obj.PersonalAccountStatusDirRX.Value == DirRX.EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent &&
        !_obj.State.IsInserted && EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected();
    }

  }

}