using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.SignPlatform.CertificateRequest;

namespace DirRX.SignPlatform
{
  partial class CertificateRequestFilteringServerHandler<T>
  {

    public override IQueryable<T> Filtering(IQueryable<T> query, Sungero.Domain.FilteringEventArgs e)
    {
      if (_filter == null)
        return query;
      
      if (_filter.Employee != null)
        query = query.Where(s => s.Employee == _filter.Employee);
  
      if (_filter.Work || _filter.Error || _filter.Done)
        query = query.Where(s => (_filter.Error && s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error) ||
                                 (_filter.Work && (s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress || 
                                                   s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirm || 
                                                   s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.DocVerification ||
                                                   s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification ||
                                                   s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt ||
                                                   s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirmEsia)) ||
                                 (_filter.Done && (s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated ||
                                                   s.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered)));

      if (_filter.DateCreateFrom != null)
        query = query.Where(q => q.CreateDate >= _filter.DateCreateFrom);

      if (_filter.DateCreateTo != null)
        query = query.Where(q => q.CreateDate <= _filter.DateCreateTo);

      if (_filter.LastDateFrom != null)
        query = query.Where(q => q.LastStatusChange >= _filter.LastDateFrom);

      if (_filter.LastDateTo != null)
        query = query.Where(q => q.LastStatusChange <= _filter.LastDateTo);

      return query;
    }
  }

  partial class CertificateRequestServerHandlers
  {

    public override void BeforeSaveHistory(Sungero.Domain.HistoryEventArgs e)
    {
      if ((e.Action == Sungero.CoreEntities.History.Action.Create || e.Action == Sungero.CoreEntities.History.Action.Update) &&
         _obj.State.Properties.IssueStatus.IsChanged)
      {
        var comment = DirRX.SignPlatform.CertificateRequests.Resources.IssueStatusCommentToHistoryFormat(_obj.Info.Properties.IssueStatus.GetLocalizedValue(_obj.IssueStatus));
        e.Write(null, null, comment);
      }
    }
  }

}