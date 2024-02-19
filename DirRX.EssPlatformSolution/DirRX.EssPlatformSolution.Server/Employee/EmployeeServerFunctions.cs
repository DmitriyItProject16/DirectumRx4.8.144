using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Employee;

namespace DirRX.EssPlatformSolution.Server
{
  partial class EmployeeFunctions
  {

    /// <summary>
    /// Заполнить свойства ЛК.
    /// </summary>
    [Remote]
    public virtual void FillPersonalOfficeProperties()
    {
      if (_obj.Person != null)
      {
        var mainEmployee = EssPlatform.PublicFunctions.Module.Remote.GetPersonMainEmployee(_obj.Person.Id, null);
        
        if (mainEmployee != null)
        {
          if (_obj.PersonalAccountStatusDirRX != mainEmployee.PersonalAccountStatusDirRX)
            _obj.PersonalAccountStatusDirRX = mainEmployee.PersonalAccountStatusDirRX;
          if (_obj.PersonalPhoneDirRX != mainEmployee.PersonalPhoneDirRX)
            _obj.PersonalPhoneDirRX = mainEmployee.PersonalPhoneDirRX;
          if (_obj.MessagesEmailDirRX != mainEmployee.MessagesEmailDirRX)
            _obj.MessagesEmailDirRX = mainEmployee.MessagesEmailDirRX;
          if (_obj.NeedNotifyNewHRAssignmentDirRX != mainEmployee.NeedNotifyNewHRAssignmentDirRX)
            _obj.NeedNotifyNewHRAssignmentDirRX = mainEmployee.NeedNotifyNewHRAssignmentDirRX;
          if (_obj.NeedNotifyExpiredHRAssignmentDirRX != mainEmployee.NeedNotifyExpiredHRAssignmentDirRX)
            _obj.NeedNotifyExpiredHRAssignmentDirRX = mainEmployee.NeedNotifyExpiredHRAssignmentDirRX;
          if (_obj.NeedNotifyHRRepeatDirRX != mainEmployee.NeedNotifyHRRepeatDirRX)
            _obj.NeedNotifyHRRepeatDirRX = mainEmployee.NeedNotifyHRRepeatDirRX;
          if (_obj.ConfirmationTypeDirRX != mainEmployee.ConfirmationTypeDirRX)
            _obj.ConfirmationTypeDirRX = mainEmployee.ConfirmationTypeDirRX;
        }
      }
    }
    
    /// <summary>
    /// Очистить номер и статус подключения, если запись создана копированием и используется новая персона.
    /// </summary>
    [Remote]
    public virtual void ClearPersonalPhoneAndStatus()
    {
      if (_obj.Person != null)
      {
        var mainEmployee = EssPlatform.PublicFunctions.Module.Remote.GetPersonMainEmployee(_obj.Person.Id, null);
        
        if (mainEmployee == null && !Employees.GetAll().Where(e => e.Person == _obj.Person).Any() && _obj.State.IsCopied == true)
        {
          _obj.PersonalAccountStatusDirRX = PersonalAccountStatusDirRX.InviteIsNotSent;
          _obj.PersonalPhoneDirRX = null;
        }
      }
    }
    
    /// <summary>
    /// Получить всех сотрудников персоны.
    /// </summary>
    /// <returns>Сотрудники.</returns>
    [Remote]
    public virtual IQueryable<IEmployee> GetEmployeesByPerson()
    {
      return Employees.GetAll(e => e.Person.Equals(_obj.Person) && e.Status == Sungero.Company.Employee.Status.Active);
    }

  }
}