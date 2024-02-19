using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.SignPlatform.CertificateIssueTask;

namespace DirRX.SignPlatform
{
  partial class CertificateIssueTaskServerHandlers
  {

    public override void BeforeStart(Sungero.Workflow.Server.BeforeStartEventArgs e)
    {
      _obj.Subject = Resources.CertificateIssueTaskSubjectFormat(_obj.Employee.Name);
    }

    public override void Created(Sungero.Domain.CreatedEventArgs e)
    {
      _obj.Subject = Sungero.Docflow.Resources.AutoformatTaskSubject;
    }
  }

}