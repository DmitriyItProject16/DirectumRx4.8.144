using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace DirRX.SignPlatform.Server
{
  public class ModuleAsyncHandlers
  {

    public virtual void AbortIssueTask(DirRX.SignPlatform.Server.AsyncHandlerInvokeArgs.AbortIssueTaskInvokeArgs args)
    {
      Logger.DebugFormat("SignPlatform.AsyncHandlers.AbortIssueTask started, iteration: {0}", args.RetryIteration);
      if (!string.IsNullOrEmpty(args.TaskIds))
      {
        var ids = args.TaskIds.Split(',');
        try
        {
          foreach (var id in ids)
          {
            Logger.DebugFormat("SignPlatform.AsyncHandlers.AbortIssueTask start of processing certificateIssueTask: {0}, iteration: {1}", id, args.RetryIteration);
            var certificateIssueTask = CertificateIssueTasks.GetAll(i => i.Id == long.Parse(id)).FirstOrDefault();
            if (certificateIssueTask != null && certificateIssueTask.Status == Sungero.Workflow.Task.Status.InProcess)
              certificateIssueTask.Abort();
            var certRequests = CertificateRequests.GetAll(cr => cr.TaskId == int.Parse(id) && cr.IssueStatus != SignPlatform.CertificateRequest.IssueStatus.Error);
            foreach (var certRequest in certRequests)
            {
              certRequest.IssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
              certRequest.Errors = DirRX.SignPlatform.Resources.ByDisconnectingFromESS;
              certRequest.Save();
            }
          }
          Logger.DebugFormat("SignPlatform.AsyncHandlers.AbortIssueTask ended, iteration: {0}", args.RetryIteration);
        }
        catch (Exception ex)
        {
          args.Retry = true;
          Logger.DebugFormat("SignPlatform.AsyncHandlers.AbortIssueTask error: \"{0}\". Iteration: {1}", ex.Message, args.RetryIteration);
        }
      }
    }
  }
}