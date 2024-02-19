using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Employee;

namespace DirRX.EssPlatformSolution
{
  partial class EmployeeDepartmentPropertyFilteringServerHandler<T>
  {

    public override IQueryable<T> DepartmentFiltering(IQueryable<T> query, Sungero.Domain.PropertyFilteringEventArgs e)
    {
      if (_obj.BusinessUnitDirRX != null)
        query = query.Where(d => Equals(d.BusinessUnit, _obj.BusinessUnitDirRX));
      return query;
    }
  }

  partial class EmployeeServerHandlers
  {

    public override IDigestModel GetDigest(Sungero.Domain.GetDigestEventArgs e)
    {
      var digest = UserDigest.Create(_obj);
      if (_obj.BusinessUnitDirRX != null)
        digest.AddEntity(_obj.BusinessUnitDirRX);
      
      if (_obj.Department != null)
        digest.AddEntity(_obj.Department);
      
      if (_obj.JobTitle != null)
        digest.AddLabel(_obj.JobTitle.Name);
      
      if (!string.IsNullOrWhiteSpace(_obj.Phone))
        digest.AddLabel(string.Format("{0} {1}", Sungero.Company.Employees.Resources.PopupPhoneDescription, _obj.Phone));
      
      if (_obj.Department != null)
      {
        var manager = _obj.Department.Manager;
        if (manager == null && _obj.Department.HeadOffice != null)
          manager = _obj.Department.HeadOffice.Manager;
        
        if (manager != null && !Equals(manager, _obj))
          digest.AddEntity(manager, Sungero.Company.Employees.Resources.PopupManagerDescription);
      }
      return digest;
    }

    public override void Created(Sungero.Domain.CreatedEventArgs e)
    {
      base.Created(e);
      
      if (!_obj.State.IsCopied)
      {
        _obj.PersonalAccountStatusDirRX = EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent;
        _obj.ConfirmationTypeDirRX = DirRX.EssPlatformSolution.Employee.ConfirmationTypeDirRX.DefaultValue;
        _obj.InheritFromBusinessUnitDirRX = true;
      }
    }

    public override void AfterSave(Sungero.Domain.AfterSaveEventArgs e)
    {
      base.AfterSave(e);
      
      //Если включена настройка "Подключить сервисы личного кабинета", то работать с Личным кабинетом.
      if (EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected())
      {
        e.Params.AddOrUpdate(EssPlatform.Resources.ParameterOldPhoneEmpForUpdateFormat(_obj.Id), _obj.PersonalPhoneDirRX);
      }
      
      // Если сохранение выполняется сотрудником и одно из свойств (Приглашение в ЛК, телефоны, email, каналы доставки, способ подтверждения) изменилось,
      // то обновить данные в других сотрудниках этой персоны.
      var isNeedUpdateEmployees = false;
      e.Params.TryGetValue(DirRX.EssPlatformSolution.Employees.Resources.IsNeedUpdateEmployeesFormat(_obj.Id), out isNeedUpdateEmployees);
      
      if (isNeedUpdateEmployees)
      {
        var employeesToChangeIdsList = Employees.GetAll(w => w.Status == Sungero.Company.Employee.Status.Active && w.Person.Id == _obj.Person.Id && w.Id != _obj.Id).Select(w => w.Id).ToList();
        if (employeesToChangeIdsList.Count > 0)
        {
          var synchronizeEmployee = EssPlatform.AsyncHandlers.SynchronizeEmployee.Create();
          synchronizeEmployee.personalAccountStatus = _obj.PersonalAccountStatusDirRX.Value.Value;
          synchronizeEmployee.personalPhone = _obj.PersonalPhoneDirRX;
          synchronizeEmployee.needNotifyNewHRAssignmentDirRX = _obj.NeedNotifyNewHRAssignmentDirRX.HasValue ? _obj.NeedNotifyNewHRAssignmentDirRX.Value.ToString() : string.Empty;
          synchronizeEmployee.needNotifyExpiredHRAssignmentDirRX = _obj.NeedNotifyExpiredHRAssignmentDirRX.HasValue ? _obj.NeedNotifyExpiredHRAssignmentDirRX.Value.ToString() : string.Empty;
          synchronizeEmployee.needNotifyHRRepeatDirRX = _obj.NeedNotifyHRRepeatDirRX.HasValue ? _obj.NeedNotifyHRRepeatDirRX.Value.ToString() : string.Empty;
          synchronizeEmployee.confirmationTypeDirRX = _obj.ConfirmationTypeDirRX.HasValue ? _obj.ConfirmationTypeDirRX.Value.ToString() : string.Empty;
          synchronizeEmployee.messagesEmail = _obj.MessagesEmailDirRX;
          synchronizeEmployee.employeeIds = string.Join(";", employeesToChangeIdsList);
          synchronizeEmployee.changedEmployeeId = _obj.Id;
          synchronizeEmployee.inheritFromBusinessUnitDirRX = _obj.InheritFromBusinessUnitDirRX.Value;
          synchronizeEmployee.ExecuteAsync();
        }
      }
      
      if(_obj.Status == Sungero.Company.Employee.Status.Closed)
      {
        SignPlatform.PublicFunctions.Module.AbortCertificateIssueTask(_obj);
      }
    }

    public override void BeforeSave(Sungero.Domain.BeforeSaveEventArgs e)
    {
      base.BeforeSave(e);
      
      // Если телефон изменился, то он должен быть корректен и уникален для каждого сотрудника одной персоны
      if (_obj.State.Properties.PersonalPhoneDirRX.IsChanged && !string.IsNullOrEmpty(_obj.PersonalPhoneDirRX))
      {
        var error = string.Empty;
        e.Params.TryGetValue(EssPlatform.Resources.ParameterPersonPhoneCheckErrorFormat(_obj.Id), out error);
        if (!string.IsNullOrEmpty(error))
          e.AddError(error);
      }
      
      // Если НОР не заполнена, запретить использовать настройки организации.
      if (_obj.BusinessUnitDirRX == null && _obj.InheritFromBusinessUnitDirRX.HasValue && _obj.InheritFromBusinessUnitDirRX.Value)
        e.AddError(DirRX.EssPlatformSolution.Employees.Resources.InheritFormEmptyBusinessUnitError);
      
      // Если включена настройка "Подключить сервисы личного кабинета", то работать с Личным кабинетом.
      if (EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected())
      {
        // Выяснить, является ли сотрудник последним действующим совмещением персоны.
        var isSingleActivePersonEmployee = EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.State.Properties.Status.OriginalValue);
        // Узнать, выбран ли вариант отключения от ЛК. Наличие параметра означает, что вариант отключения выбран и выводить сообщение повторно не нужно.
        // Тут же получить вариант отключения. В параметр записано значение True, если удаление временное, иначе False.
        bool? isTemporaryDisconnect;
        var isDisconnectOptionSelected = e.Params.TryGetValue(EssPlatform.Resources.ParameterIsTempDisconnectFormat(_obj.Id), out isTemporaryDisconnect);
        
        // Если переводим состояние карточки единственного действующего сотрудника персоны в состояние"Закрытая", при этом у него есть ЛК,
        // то при первой попытке сохранить запись необходимо вывести сообщение с выбором варианта отключения.
        if (_obj.State.Properties.Status.IsChanged && _obj.Status == EssPlatformSolution.Employee.Status.Closed && isSingleActivePersonEmployee &&
            !isDisconnectOptionSelected && _obj.PersonalAccountStatusDirRX.Value != EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent)
        {
          // Если сотрудник уже работает в ЛК, запросить вариант отключения.
          if (_obj.PersonalAccountStatusDirRX.Value == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted)
            e.AddError(EssPlatform.Resources.ConfirmDeleteEssUser, _obj.Info.Actions.DisconnectDirRX, _obj.Info.Actions.TempDisconnectDirRX);
          // Если приглашение отправили, но сотрудник его еще не принял, запросить подтверждение с единственным вариантом.
          else if (_obj.PersonalAccountStatusDirRX.Value == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteSent)
            e.AddError(EssPlatform.Resources.ConfirmDeleteEssUser, _obj.Info.Actions.DisconnectDirRX);
          return;
        }
        
        //Проверка заполнения email у совместителей
        if ((_obj.NeedNotifyNewHRAssignmentDirRX.HasValue && _obj.NeedNotifyNewHRAssignmentDirRX.Value == Employee.NeedNotifyNewHRAssignmentDirRX.Email) ||
            (_obj.NeedNotifyHRRepeatDirRX.HasValue && _obj.NeedNotifyHRRepeatDirRX.Value == Employee.NeedNotifyHRRepeatDirRX.Email) ||
            (_obj.NeedNotifyExpiredHRAssignmentDirRX.HasValue && _obj.NeedNotifyExpiredHRAssignmentDirRX.Value == Employee.NeedNotifyExpiredHRAssignmentDirRX.Email))
        {
          var partTimeWorkers = Employees.GetAll(x => Equals(x.Person, _obj.Person) && x.Status == Employee.Status.Active && x.Id != _obj.Id).ToList();
          foreach(var partTimeWorker in partTimeWorkers)
          {
            if(string.IsNullOrEmpty(partTimeWorker.Email))
            {
              e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmptyEmailPartTimeWorkerError);   
            }
          }
        }
        
        // Если проставлена рассылка сообщений в ЛК по личному e-mail, то проверить, что указана личная почта.
        if (((_obj.NeedNotifyNewHRAssignmentDirRX.HasValue && _obj.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.EmailPersonal) ||
             (_obj.NeedNotifyExpiredHRAssignmentDirRX.HasValue && _obj.NeedNotifyExpiredHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.EmailPersonal) ||
             (_obj.NeedNotifyHRRepeatDirRX.HasValue && _obj.NeedNotifyHRRepeatDirRX.Value == EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.EmailPersonal)) &&
            string.IsNullOrEmpty(_obj.MessagesEmailDirRX))
          e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmptyPersonalEMailError);
        
        // Если проставлена рассылка сообщений в ЛК по e-mail, то проверить, что указана почта.
        if (((_obj.NeedNotifyNewHRAssignmentDirRX.HasValue && _obj.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Email) ||
             (_obj.NeedNotifyExpiredHRAssignmentDirRX.HasValue && _obj.NeedNotifyExpiredHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.Email) ||
             (_obj.NeedNotifyHRRepeatDirRX.HasValue && _obj.NeedNotifyHRRepeatDirRX.Value == EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.Email)) &&
            string.IsNullOrEmpty(_obj.Email))
          e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmptyEMailError);
        
        //Если второй фактор или "email" или "по умолчанию" и в общих настройках email.
        var settings = EssPlatform.PublicFunctions.EssSetting.GetSettings();
        if(((_obj.ConfirmationTypeDirRX == Employee.ConfirmationTypeDirRX.DefaultValue && 
           settings.ConfirmationType == EssPlatform.EssSetting.ConfirmationType.Email) ||
           _obj.ConfirmationTypeDirRX == Employee.ConfirmationTypeDirRX.Email) &&
           (string.IsNullOrEmpty(_obj.Email) && string.IsNullOrEmpty(_obj.MessagesEmailDirRX)))
          e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmptyPersonalEMailOrWorkEmailError);
        
        // Если проставлена рассылка сообщений по СМС, то проверить, что сотрудник подключен к ЛК.
        if (((_obj.NeedNotifyNewHRAssignmentDirRX.HasValue && _obj.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.SMS) ||
             (_obj.NeedNotifyExpiredHRAssignmentDirRX.HasValue && _obj.NeedNotifyExpiredHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.SMS) ||
             (_obj.NeedNotifyHRRepeatDirRX.HasValue && _obj.NeedNotifyHRRepeatDirRX.Value == EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.SMS)) &&
            _obj.PersonalAccountStatusDirRX.Value != EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted)
          e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmptySMSError);
        
        // Если проставлена рассылка сообщений по Viber, то проверить, что сотрудник подключен к ЛК.
        if (((_obj.NeedNotifyNewHRAssignmentDirRX.HasValue && _obj.NeedNotifyNewHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyNewHRAssignmentDirRX.Viber) ||
             (_obj.NeedNotifyExpiredHRAssignmentDirRX.HasValue && _obj.NeedNotifyExpiredHRAssignmentDirRX.Value == EssPlatformSolution.Employee.NeedNotifyExpiredHRAssignmentDirRX.Viber) ||
             (_obj.NeedNotifyHRRepeatDirRX.HasValue && _obj.NeedNotifyHRRepeatDirRX.Value == EssPlatformSolution.Employee.NeedNotifyHRRepeatDirRX.Viber)) &&
            _obj.PersonalAccountStatusDirRX.Value != EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted)
          e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmptySMSError);
        
        // Если пользователь уже приглашен в ЛК, то выполнить ряд дополнительных действий
        if (_obj.PersonalAccountStatusDirRX.Value != DirRX.EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent)
        {
          var oldPhoneNumber = string.Empty;
          e.Params.TryGetValue(EssPlatform.Resources.ParameterOldPhoneEmpForUpdateFormat(_obj.Id), out oldPhoneNumber);
          // Если изменился номер телефоноа
          if (_obj.State.Properties.PersonalPhoneDirRX.IsChanged)
          {
            // Телефон для ЛК должен быть обязательно заполнен
            if (string.IsNullOrEmpty(_obj.PersonalPhoneDirRX))
            {
              e.AddError(DirRX.EssPlatformSolution.Employees.Resources.PersonalPhoneRequired);
              return;
            }
          }
          
          // Если изменились ФИО сотрудника, то  нужно обновить данные пользователя в ЛК,
          if (_obj.State.Properties.Name.IsChanged || _obj.State.Properties.PersonalPhoneDirRX.IsChanged)
          {
            EssPlatform.PublicFunctions.Module.UpdateEssUser(_obj, oldPhoneNumber);
          }
        }
        
        // Если единственный действующий сотрудник персоны закрыт, отключить пользователя от личного кабинета.
        if (isSingleActivePersonEmployee && _obj.Status.Value == Sungero.CoreEntities.DatabookEntry.Status.Closed
            && _obj.PersonalAccountStatusDirRX.Value != DirRX.EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent)
        {
          // Вариант отключения пользователя от личного кабинета получить из параметра.
          if (isTemporaryDisconnect.Value)
            EssPlatform.PublicFunctions.Module.Remote.TemporaryDisconnectEssUser(_obj);
          else
            EssPlatform.PublicFunctions.Module.Remote.DisconnectEssUser(_obj);
        }
      }
      
      // Если карточка не заблокирована АО,
      // и одно из свойств (Приглашение в ЛК, телефоны, email, каналы доставки) изменилось, то заполнить параметр для обновления данных в других сотрудниках этой персоны.
      // Исключить тот случай, когда изменение поля Приглашение в ЛК идет в рамках закрытия записи.
      var propertiesState = _obj.State.Properties;
      var isNeedUpdateEmployees = !(_obj.LockedByAsync.HasValue && _obj.LockedByAsync.Value) &&
                                  ((propertiesState.PersonalAccountStatusDirRX.IsChanged && !propertiesState.Status.IsChanged && _obj.Status == Sungero.Company.Employee.Status.Closed) ||
                                  propertiesState.PersonalPhoneDirRX.IsChanged ||
                                  propertiesState.NeedNotifyNewHRAssignmentDirRX.IsChanged || propertiesState.NeedNotifyExpiredHRAssignmentDirRX.IsChanged ||
                                  propertiesState.NeedNotifyHRRepeatDirRX.IsChanged || propertiesState.MessagesEmailDirRX.IsChanged || propertiesState.ConfirmationTypeDirRX.IsChanged ||
                                  propertiesState.InheritFromBusinessUnitDirRX.IsChanged);
      e.Params.AddOrUpdate(DirRX.EssPlatformSolution.Employees.Resources.IsNeedUpdateEmployeesFormat(_obj.Id), isNeedUpdateEmployees);
      
      // Поменять Статус подключения к ЛК на "Не подключен" при закрытии записи.
      if (_obj.State.Properties.Status.IsChanged && _obj.Status == EssPlatformSolution.Employee.Status.Closed &&
          _obj.PersonalAccountStatusDirRX != DirRX.EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent)
        _obj.PersonalAccountStatusDirRX = DirRX.EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent;
      
      var personEmployees = Employees.GetAll(w => w.Status == Sungero.Company.Employee.Status.Active && w.Person.Id == _obj.Person.Id && w.Id != _obj.Id);
      var mainPlaceEmploymentType = EmploymentType.MainPlace;
      var employeesWithMainPlace = personEmployees.Where(w => w.EmploymentType == mainPlaceEmploymentType);
      
      if (_obj.EmploymentType == mainPlaceEmploymentType && employeesWithMainPlace.Any())
      {
        e.AddError(DirRX.EssPlatformSolution.Employees.Resources.EmployeeWithMainPlaceEmploymentTypeDouble);
      }
      if (isNeedUpdateEmployees && personEmployees.Count() > 0)
      {
        _obj.LockedByAsync = true;
      }
      
      // Выводим предупреждение что нужно перевыпустить сертификат если изменилась почта\номер телефона.
      var hasCertificate = SignPlatform.PublicFunctions.Module.Remote.HasEmployeeCertificateOrIssueTask(_obj);
      var fieldChanged = false;
      e.Params.TryGetValue(EssPlatform.PublicConstants.Module.PhoneEmailChangedParamName, out fieldChanged);
      if(hasCertificate == true && fieldChanged == true)
        e.AddWarning(DirRX.EssPlatformSolution.Employees.Resources.NeedReissueCertificateAfterChange);

      // Не давать сохранить карточку если вид занятости Внутреннее совместительство и есть логин.
      if (_obj.EmploymentType.HasValue && _obj.EmploymentType == DirRX.EssPlatformSolution.Employee.EmploymentType.InternalConcurr && _obj.Login != null)
        e.AddError(DirRX.EssPlatformSolution.Employees.Resources.OnlyPrimaryEmploymentTypeCanHaveLogin);
    }
  }

}