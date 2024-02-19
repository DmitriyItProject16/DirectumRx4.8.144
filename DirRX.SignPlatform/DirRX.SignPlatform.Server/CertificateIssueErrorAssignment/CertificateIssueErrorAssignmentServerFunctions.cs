using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.SignPlatform.CertificateIssueErrorAssignment;

namespace DirRX.SignPlatform.Server
{
  partial class CertificateIssueErrorAssignmentFunctions
  {

    /// <summary>
    /// Построить модель состояния инструкции.
    /// </summary>
    /// <returns>Модель состояния.</returns>
    [Remote(IsPure = true)]
    public StateView GetCertificateIssueErrorAssignmentState()
    {
      var instruction = string.Empty;
      switch (_obj.BlockUid)
      {
        case Constants.CertificateIssueTask.CertificateIssueErrorBlockId:
          instruction = CertificateIssueTasks.Resources.CertificateIssueErrorInstruction;
          break;
      }
      
      return Functions.Module.GetAssignmentStateView(instruction);
    }

  }
}