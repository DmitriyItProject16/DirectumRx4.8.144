using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.SignPlatform.CertificateRequest;

namespace DirRX.SignPlatform.Client
{
  partial class CertificateRequestActions
  {
    public virtual void OpenDocument(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      try
      {
        var document = CertificateIssueStatementDocuments.Get(_obj.DocumentID.Value);
        document.Show();
      }
      catch
      {
        Dialogs.ShowMessage(DirRX.SignPlatform.CertificateRequests.Resources.CertificateIssueDocumentNotFound);
      }
    }

    public virtual bool CanOpenDocument(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

    public virtual void OpenTask(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      if (_obj.TaskId != null)
      {
        var task = DirRX.SignPlatform.CertificateIssueTasks.Get(_obj.TaskId.Value);
        task.Show();
      }
    }

    public virtual bool CanOpenTask(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return _obj.TaskId != null;
    }

  }

}