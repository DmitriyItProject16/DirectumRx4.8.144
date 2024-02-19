using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DirRX.SignPlatform.Server
{
  public class ModuleJobs
  {

    /// <summary>
    /// 
    /// </summary>
    public virtual void CertificateIssueTaskMonitoring()
    {
      Logger.Debug("CertificateIssue. Jobs CertificateIssueTaskMonitoring. Started.");
      var requestEntries = CertificateRequests.GetAll(x => x.Executor == SignPlatform.CertificateRequest.Executor.BckgrndProcess)
        .Where(x => x.IssueStatus != SignPlatform.CertificateRequest.IssueStatus.Error)
        .Where(x => x.IssueStatus != SignPlatform.CertificateRequest.IssueStatus.NeedConfirm)
        .Where(x => x.IssueStatus != SignPlatform.CertificateRequest.IssueStatus.CertCreated);
      
      foreach (var requestEntry in requestEntries)
      {
        Logger.DebugFormat("CertificateIssue. Jobs CertificateIssueTaskMonitoring. requestEntry.RequestId={0} IssueStatus={1} start", requestEntry.RequestId, requestEntry.IssueStatus);

        // Сначала проверим на NeedConfirmEsia
        // Вдруг повезет, и если в ESIA уже подписали, то может уже и сертификат успеет выпуститься и следующеее условие это проверит
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirmEsia)
          if (Functions.Module.CheckCertificateConfirmByESIA(requestEntry))
            if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification ||
                requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.DocVerification ||
                requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error) {
          // Потрогать задачу за активные блоки мониторинга, пусть проверит - не пора ли двигаться дальше
          CertificateIssueTasks.Get(requestEntry.TaskId.Value).Blocks.ExecuteAllMonitoringBlocks();
          continue;
        }

        // проверки для этапов проверки документов и выпуска сертификата
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.DocVerification ||
            requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification ||
            requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress)
          if (Functions.Module.CheckCertificateStatus(requestEntry))
            if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt ||
                requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated ||
                requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error) {
          // Потрогать задачу за активные блоки мониторинга, пусть проверит - не пора ли двигаться дальше
          CertificateIssueTasks.Get(requestEntry.TaskId.Value).Blocks.ExecuteAllMonitoringBlocks();
          continue;
        }
        
        // этап скачивания задания
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt)
        {
          var task = CertificateIssueTasks.Get(requestEntry.TaskId.Value);
          if (Functions.Module.DownloadStatement(requestEntry, task))
            if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirm ||
                requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error) {
            // Потрогать задачу за активные блоки мониторинга, пусть проверит - не пора ли двигаться дальше
            CertificateIssueTasks.Get(requestEntry.TaskId.Value).Blocks.ExecuteAllMonitoringBlocks();
            continue;
          }
        }
        
        // этап сохранения сертификата в справочник "Цифровые сертификаты"
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated)
        {
          if (Functions.Module.SaveCertificate(requestEntry))
            if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered ||
                requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error) {
            // Потрогать задачу за активные блоки мониторинга, пусть проверит - не пора ли двигаться дальше
            CertificateIssueTasks.Get(requestEntry.TaskId.Value).Blocks.ExecuteAllMonitoringBlocks();
            continue;
          }
        }
      }
      Logger.Debug("CertificateIssue. Jobs CertificateIssueTaskMonitoring. Finished.");
    }
    
    /// <summary>
    /// Рассылка задач на перевыпуск облачных сертификатов.
    /// </summary>
    public virtual void CloudCertificatesReissueTasks()
    {
      SignPlatform.Functions.Module.CloudCertificatesReissueTasks();
    }
    
  }
}
