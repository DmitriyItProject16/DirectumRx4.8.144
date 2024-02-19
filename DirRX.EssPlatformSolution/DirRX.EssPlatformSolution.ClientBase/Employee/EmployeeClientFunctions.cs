using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Employee;

namespace DirRX.EssPlatformSolution.Client
{
  partial class EmployeeFunctions
  {

    /// <summary>
    /// Проверить, заблокирована ли карточка сотрудника либо его совместителей.
    /// </summary>
    /// <returns>True, если заблокирована карточка хотя бы одного из сотрудников персоны.</returns>
    public bool CheckLockCardEmployeeOrPartTime()
    {
      var employeesByPerson = Functions.Employee.Remote.GetEmployeesByPerson(_obj);
      foreach (var employee in employeesByPerson)
      {
        if ((employee.LockedByAsync.HasValue && employee.LockedByAsync.Value) || Locks.GetLockInfo(employee).IsLockedByOther)
          return true;
      }
      return false;
    }

  }
}