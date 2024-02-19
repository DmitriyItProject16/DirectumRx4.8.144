using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.BusinessUnit;

namespace DirRX.EssPlatformSolution.Shared
{
  partial class BusinessUnitFunctions
  {

    /// <summary>
    /// Проверить возможность оповещения сотрудников.
    /// </summary>
    /// <param name="notifyType">Способ оповещения.</param>
    /// <returns>Текст предупреждения, если у одного из сотрудников возможности оповещения выбранным способом нет, иначе - пустая строка.</returns>
    public string CheckEmployeeNotifyPossibility(Enumeration notifyType)
    {
      if (notifyType == DirRX.EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.SMS || notifyType == DirRX.EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Viber)
      {
        if (DirRX.EssPlatformSolution.Employees.GetAll(p => p.Status == Sungero.Company.Employee.Status.Active &&
                                                       p.InheritFromBusinessUnitDirRX.HasValue && p.InheritFromBusinessUnitDirRX.Value &&
                                                       p.BusinessUnitDirRX != null && Equals(_obj, p.BusinessUnitDirRX)).ToList()
            .Where(p => p.PersonalAccountStatusDirRX.HasValue && p.PersonalAccountStatusDirRX.Value != EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted).Any())
          return DirRX.EssPlatformSolution.BusinessUnits.Resources.ConnectEmployeeESSWarning;
      }
      
      if (notifyType == DirRX.EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Email)
      {
        if (DirRX.EssPlatformSolution.Employees.GetAll(p => p.Status == Sungero.Company.Employee.Status.Active &&
                                                       p.InheritFromBusinessUnitDirRX.HasValue && p.InheritFromBusinessUnitDirRX.Value &&
                                                       p.BusinessUnitDirRX != null && Equals(_obj, p.BusinessUnitDirRX)).ToList().Where(p => string.IsNullOrEmpty(p.Email)).Any())
          return DirRX.EssPlatformSolution.BusinessUnits.Resources.EmptyEmailExistsWarning;
      }
      
      if (notifyType == DirRX.EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.EmailPersonal)
      {
        if (DirRX.EssPlatformSolution.Employees.GetAll(p => p.Status == Sungero.Company.Employee.Status.Active &&
                                                       p.InheritFromBusinessUnitDirRX.HasValue && p.InheritFromBusinessUnitDirRX.Value &&
                                                       p.BusinessUnitDirRX != null && Equals(_obj, p.BusinessUnitDirRX)).ToList().Where(p => string.IsNullOrEmpty(p.MessagesEmailDirRX)).Any())
          return DirRX.EssPlatformSolution.BusinessUnits.Resources.EmptyEmailPersonalExistsWarning;
      }
      
      return string.Empty;
    }

  }
}