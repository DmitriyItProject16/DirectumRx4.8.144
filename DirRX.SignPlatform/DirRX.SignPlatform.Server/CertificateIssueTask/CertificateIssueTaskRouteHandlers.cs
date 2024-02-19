using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Workflow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DirRX.SignPlatform.CertificateIssueTask;

namespace DirRX.SignPlatform.Server
{
  partial class CertificateIssueTaskRouteHandlers
  {

    public virtual void Script40Execute()
    {
      if (_obj.MonitoringTask != null)
      {
        _obj.IsCompleting = true;
        _obj.MonitoringTask.Blocks.ExecuteAllMonitoringBlocks();
      }
    }

    public virtual void Script34Execute()
    {
      // Создаем запись в справочнике заявок на выпуск сертификата.
      var certificateRequestEntry = CertificateRequests.Create();
      certificateRequestEntry.RequestId = _obj.RequestId;
      certificateRequestEntry.TaskId = _obj.Id;
      certificateRequestEntry.CreateDate = Calendar.Now;
      certificateRequestEntry.Employee = _obj.Employee;
      certificateRequestEntry.IssueStatus = SignPlatform.CertificateRequest.IssueStatus.DocVerification;
      certificateRequestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
      certificateRequestEntry.IdentificationType = _obj.IdentificationType;
      certificateRequestEntry.Name = DirRX.SignPlatform.Resources.CertificateRequestEntryNameFormat(certificateRequestEntry.Id, certificateRequestEntry.Employee.DisplayValue);
      certificateRequestEntry.ProviderId = _obj.ProviderId;
      certificateRequestEntry.Save();

      // Вкладываем заявку во вложения задачи.
      if (_obj.RequestId != null)
      {
        var requestEntry = SignPlatform.CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
        if (requestEntry != null)
        {
          requestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
          requestEntry.Save();
          _obj.CertificateRequestAttachmentGroup.CertificateRequests.Add(requestEntry);
          _obj.Save();
        }
      }
    }
    
    #region Этап проверки документов
    #region start
    public virtual void StartBlock13(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutKey).ToString()));
    }

    public virtual void StartBlock14(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringBackgroundProcessKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutBackgroundProcessKey).ToString()));
      
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.BckgrndProcess;
        requestEntry.Save();
      }
    }
    #endregion

    #region monitoring
    /// <summary>
    /// Быстрый мониторинг проверки документов
    /// Предполагается, что до блока заявка дойдет в состоянии DocVerification
    /// А в ходе выполнения блока:
    ///   - либо останется в состоянии DocVerification и тогда задача останется на текущем блоке
    ///   - либо перейдет в NeedDownloadSt или Error и тогда задачу надо двинуть дальше
    /// </summary>
    public virtual bool Monitoring13Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.DocVerification) {
          Functions.Module.CheckCertificateStatus(requestEntry);
          if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt ||
              requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
            return true;
          return false;
        }
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring13", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }

    /// <summary>
    /// Медленный мониторинг проверки документов
    /// Предполагается, что до блока заявка дойдет в состояниях
    ///   - DocVerification - тогда задача остается на этом же блоке
    ///   - NeedDownloadSt или Error - тогда задача двигается дальше
    /// </summary>
    public virtual bool Monitoring14Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.DocVerification)
          return false;
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
        {
          requestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
          requestEntry.Save();
          return true;
        }
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring14", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }
    #endregion

    #region decision
    public virtual bool Decision18Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        // Ожидается, что до блока заявка дойдет либо в состоянии NeedDownloadSt, либо Error
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt)
          return true;
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return false;
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Decision18", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return false;
    }
    #endregion
    #endregion
    
    #region Этап скачивания заявления
    #region start
    public virtual void StartBlock21(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      // TODO: Добавить свои параметры мониторингов для этого этапа задчи
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutKey).ToString()));

      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
        requestEntry.Save();
      }
    }

    public virtual void StartBlock22(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      // TODO: Добавить свои параметры мониторингов для этого этапа задчи
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringBackgroundProcessKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutBackgroundProcessKey).ToString()));
      
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.BckgrndProcess;
        requestEntry.Save();
      }
      
    }
    #endregion
    
    #region monitoring
    /// <summary>
    /// Быстрый мониторинг скачивания заявлений
    /// Предполагается, что до блока заявка дойдет в состоянии NeedDownloadSt.
    /// А в ходе выполнения блока:
    ///   - либо останется в состоянии NeedDownloadSt. и тогда задача останется на текущем блоке
    ///   - либо перейдет в NeedConfirm или Error и тогда задачу надо двинуть дальше
    /// </summary>
    public virtual bool Monitoring21Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt) {
          Functions.Module.DownloadStatement(requestEntry, _obj);
          if (requestEntry.DocumentID != null)
          {
            var document = CertificateIssueStatementDocuments.Get(requestEntry.DocumentID.Value);
            if (!_obj.CertificateIssueStatementAttachmentGroup.CertificateIssueStatementDocuments.Contains(document))
              _obj.CertificateIssueStatementAttachmentGroup.CertificateIssueStatementDocuments.Add(document);
          }
          if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirm ||
              requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
            return true;
          return false;
        }
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirm) {
          // из-за оптимизации в ФП к этому блоку может доходить уже в состоянии NeedConfirm - просто двинуть задачу дальше на задание
          return true;
        }
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring21", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }

    /// <summary>
    /// Медленный мониторинг скачивания заявлений
    /// Предполагается, что до блока заявка дойдет в состояниях.
    ///   - NeedDownloadSt - тогда задача остается на этом же блоке
    ///   - NeedConfirm или Error - тогда задача двигается дальше
    /// </summary>
    public virtual bool Monitoring22Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedDownloadSt)
          return false;
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirm ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return true;
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring22", requestEntry.IssueStatus, requestEntry.RequestId));
        
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }
    #endregion
    
    #region decision
    public virtual bool Decision23Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        // Ожидается, что до блока заявка дойдет либо в состоянии NeedConfirm, либо Error
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirm)
          return true;
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return false;
        else
          // неожиданное для блока текущее значение статуса заявки
          // TODO: сделать корректную обработку этой ошибки (во вторую очередь)
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Decision23", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return false;
    }
    #endregion
    #endregion

    #region этап подписания заявления сотрудником
    public virtual void StartBlock5(DirRX.SignPlatform.Server.CertificateIssueStatementAcceptAssignmentArguments e)
    {
      e.Block.ShowInSelfServiceOffice = true;
      e.Block.Performers.Add(_obj.Employee);
      e.Block.RelativeDeadlineDays = 1;

      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
        requestEntry.Save();
        if (requestEntry.DocumentID != null)
        {
          var document = CertificateIssueStatementDocuments.Get(requestEntry.DocumentID.Value);
          e.Block.Subject = Resources.CertificateIssueAssignmentSubjectFormat(document.Name);
        }
      }
    }

    /// <summary>
    /// Уведомление о задании: Согласие с заявлением на выпуск сертификата
    /// </summary>
    public virtual void StartAssignment5(DirRX.SignPlatform.ICertificateIssueStatementAcceptAssignment assignment, DirRX.SignPlatform.Server.CertificateIssueStatementAcceptAssignmentArguments e)
    {
      // Отправить сообщение о новом задании.
      EssPlatform.PublicFunctions.Module.SendNewNotification(Sungero.Company.Employees.As(assignment.Performer), false, DirRX.EssPlatform.PublicConstants.Module.TargetNameSpaces.EssNameSpace,
                                                             EssPlatform.PublicConstants.Module.SelfOfficeObjectTypes.WorkItems,
                                                             EssPlatform.PublicConstants.Module.ObjectCardTypeNames.CertificateIssueStatementAcceptAssignment, assignment.Id.ToString(), true);
    }
    
    public virtual bool Decision17Result()
    {
      return _obj.IdentificationType == SignPlatform.CertificateIssueTask.IdentificationType.Personal ? true : false;
    }


    public virtual void EndBlock5(DirRX.SignPlatform.Server.CertificateIssueStatementAcceptAssignmentEndBlockEventArguments e)
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry == null)
        throw AppliedCodeException.Create(string.Format("CertificateIssue. AcceptAssignment.EndBlock5(). TaskID={0}. RequestId={1} not found in CertificateRequest", _obj.Id, requestEntry.RequestId));
      var assignment = e.CreatedAssignments.OrderByDescending(a => a.Created).FirstOrDefault();
      if (assignment != null && assignment.Result == DirRX.SignPlatform.CertificateIssueStatementAcceptAssignment.Result.Accept)
      {
        if (_obj.IdentificationType == SignPlatform.CertificateIssueTask.IdentificationType.Personal)
        {
          // При личной идентификации после успешного подписания заявку на сервисе переходит в статус IssueVerification
          // и у нас надо перевести в это же состояние
          requestEntry.IssueStatus = SignPlatform.CertificateRequest.IssueStatus.IssVerification;
          requestEntry.Save();
        } else if (_obj.IdentificationType == SignPlatform.CertificateIssueTask.IdentificationType.Esia)
        {
          // При идентификации через ЕСИА заявка на сервисе остается в статусе NeedConfirm
          // а у нас надо перевести в состояние NeedConfirmEsia
          requestEntry.IssueStatus = SignPlatform.CertificateRequest.IssueStatus.NeedConfirmEsia;
          requestEntry.Save();
        }
        else
          throw AppliedCodeException.Create(string.Format("CertificateIssue. AcceptAssignment.Complete() TaskID={0} RequestId={1}. Identification type '{1}' not supported for certificates issue", _obj.Id, requestEntry.RequestId, _obj.IdentificationType ));
      }
      if (assignment != null && assignment.Result == DirRX.SignPlatform.CertificateIssueStatementAcceptAssignment.Result.Refuse)
      {
        requestEntry.IssueStatus = DirRX.SignPlatform.CertificateRequest.IssueStatus.Error;
        requestEntry.Errors = DirRX.SignPlatform.CertificateIssueTasks.Resources.ErrorEmployeeRefuseIssueCertificate;
        requestEntry.Save();
        // Особый текст темы задания ответственному
        _obj.ErrorAssignmentSubject = DirRX.SignPlatform.CertificateIssueTasks.Resources.EmployeeRefuseIssueCertificateFormat(_obj.Employee.Name);
      }
    }
    #endregion
    
    #region Этап ожидания подписания в ЕСИА и выпуска сертификата
    #region start
    public virtual void StartBlock16(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutKey).ToString()));

      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
        requestEntry.Save();
      }
    }

    public virtual void StartBlock8(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringBackgroundProcessKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutBackgroundProcessKey).ToString()));
      
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.BckgrndProcess;
        requestEntry.Save();
      }
    }
    
    public virtual void StartBlock32(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringBackgroundProcessKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutBackgroundProcessKey).ToString()));
      
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.BckgrndProcess;
        requestEntry.Save();
      }
      
    }
    #endregion

    #region monitoring
    /// <summary>
    /// Быстрый мониторинг ожидания подписания в ЕСИА и выпуска сертификата
    /// Предполагается, что до блока заявка дойдет в состоянии:
    /// 1. (IssVerification, InProgress). Тогда в ходе выполнения блока
    ///   - задача останется на текущем блоке
    ///   - либо перейдет в Error или CertCreated и тогда задачу надо двинуть дальше
    /// 2. (CertCreated, CertRegistered, Error). Тогда в ходе выполнения блока
    ///   - и тогда задачу надо двинуть дальше
    /// </summary>
    public virtual bool Monitoring16Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification ||
            requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress)
        {
          Functions.Module.CheckCertificateStatus(requestEntry);
          if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification ||
              requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress)
            return false; // остаться на блоке
          else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated ||
                   requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
            return true; // двинуть задачу дальше
          else
            // неожиданное для блока текущее значение статуса заявки
            throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring16-1", requestEntry.IssueStatus, requestEntry.RequestId));
        }
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return true; // двинуть задачу дальше
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring16-2", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }
    
    /// <summary>
    /// Медленный мониторинг проверки документов
    /// Предполагается, что до блока заявка дойдет в состояниях
    ///   - IssVerification или DocVerification - тогда задача остается на этом же блоке
    ///   - (CertCreated, CertRegistered, Error) - тогда задача двигается дальше
    /// </summary>
    public virtual bool Monitoring8Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification ||
            requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress)
          return false;  // остаться на месте
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return true; // двинуть задачу дальше
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Monitoring8Result. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring8", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }
    
    /// <summary>
    /// Медленный мониторинг ожидания подписания в ЕСИА
    /// Предполагается, что до блока заявка дойдет в состоянии
    /// 1. NeedConfirmEsia. Задача останется на текущем блоке
    /// 2. (IssVerification, InProgress, CertCreated, CertRegistered, Error). Тогда в ходе выполнения блока
    ///   - и тогда задача останется на текущем блоке
    ///   - либо перейдет в Error или CertCreated и тогда задачу надо двинуть дальше
    /// </summary>
    public virtual bool Monitoring32Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirmEsia)
          return false;
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return true;
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring32", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }
    #endregion

    #region decision
    public virtual bool Decision24Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        // Ожидается, что до блока заявка дойдет либо в состоянии CertCreated, либо Error
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated)
          return true;
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return false;
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Decision24", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return false;
    }
    
    public virtual bool Decision33Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.IssVerification ||
            requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress ||
            requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated ||
            requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered)
          return true;
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return false;
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Decision33", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return false;
    }
    
    #endregion
    
    #endregion

    #region Этап завершения выпуска сертификата
    public virtual void Script7Execute()
    {
      
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
        requestEntry.Save();
      }
      
      DirRX.SignPlatform.PublicFunctions.Module.AfterIssueCertificate(_obj.Employee, _obj.Author);
    }
    
    public virtual void StartBlock9(DirRX.SignPlatform.Server.CertificateIssueNoticeArguments e)
    {
      e.Block.Performers.Add(_obj.Employee);
      e.Block.Subject = DirRX.SignPlatform.Resources.CertificateIssuedSuccessfullyTitleFormat(_obj.Employee.Name);
      e.Block.ShowInSelfServiceOffice = true;
    }

    public virtual void EndBlock9(DirRX.SignPlatform.Server.CertificateIssueNoticeEndBlockEventArguments e)
    {
      // Отправить сообщение об уведомлении
      DirRX.EssPlatform.PublicFunctions.Module.SendNewNotification(_obj.Employee, true, DirRX.EssPlatform.PublicConstants.Module.TargetNameSpaces.EssNameSpace,
                                                                   EssPlatform.PublicConstants.Module.SelfOfficeObjectTypes.WorkItems,
                                                                   DirRX.EssPlatform.PublicConstants.Module.ObjectCardTypeNames.CertificateIssueNotice,
                                                                   e.CreatedNotices.FirstOrDefault().Id.ToString(), true);
    }
    
    #endregion

    #region Этап сохранения облачного сертификата в справочник "Цифровые сертификаты"
    #region start
    public virtual void StartBlock36(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringBackgroundProcessKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutBackgroundProcessKey).ToString()));
      
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.BckgrndProcess;
        requestEntry.Save();
      }
    }
    
    public virtual void StartBlock35(Sungero.Workflow.Server.Route.MonitoringStartBlockEventArguments e)
    {
      e.Block.Period = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskMonitoringKey).ToString()));
      e.Block.RelativeDeadline = TimeSpan.FromMinutes(double.Parse(Sungero.Docflow.PublicFunctions.Module.GetDocflowParamsValue(Constants.Module.ParamKey.CertificateIssueTaskTimeoutKey).ToString()));
      
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
        requestEntry.Save();
      }
    }
    #endregion
    
    #region monitoring
    /// <summary>
    /// Быстрый мониторинг сохранения облачного сертификата в справочник "Цифровые сертификаты"
    /// Предполагается, что до блока заявка дойдет в состоянии:
    /// 1. (CertCreated). Тогда в ходе выполнения блока
    ///   - задача останется на текущем блоке
    ///   - либо перейдет в Error или CertRegistered и тогда задачу надо двинуть дальше
    /// 2. (CertRegistered, Error). Тогда в ходе выполнения блока
    ///   - и тогда задачу надо двинуть дальше
    /// </summary>
    public virtual bool Monitoring35Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated)
        {
          Functions.Module.SaveCertificate(requestEntry);
          if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated)
            return false; // остаться на блоке
          else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered ||
                   requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
            return true; // двинуть задачу дальше
          else
            // неожиданное для блока текущее значение статуса заявки
            throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring35-1", requestEntry.IssueStatus, requestEntry.RequestId));
        }
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return true; // двинуть задачу дальше
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring35-2", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }
    
    /// <summary>
    /// Медленный мониторинг сохранения облачного сертификата в справочник "Цифровые сертификаты"
    /// Предполагается, что до блока заявка дойдет в состояниях
    ///   - (CertCreated) - тогда задача остается на этом же блоке
    ///   - (CertRegistered, Error) - тогда задача двигается дальше
    /// </summary>
    public virtual bool Monitoring36Result()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertCreated)
          return false;  // остаться на месте
        else if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.CertRegistered ||
                 requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.Error)
          return true; // двинуть задачу дальше
        else
          // неожиданное для блока текущее значение статуса заявки
          throw AppliedCodeException.Create(string.Format("CertificateIssue. Monitoring36Result. Unexpected requestEntry.IssueStatus={0} for block RequestId={1} in Monitoring36", requestEntry.IssueStatus, requestEntry.RequestId));
      }
      // Особый случай выхода - не найдена запись справочника CertificateRequest
      // Будет обработано в задании CertificateIssueErrorAssignment
      return true;
    }
    #endregion
    
    #region decision
    public virtual bool Decision39Result()
    {
      if(_obj.RequestId.HasValue)
      {
        var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
        if (requestEntry != null)
        {
          if(requestEntry.CertificateID.HasValue && Sungero.CoreEntities.Certificates.GetAll(x => x.Id == requestEntry.CertificateID.Value).FirstOrDefault() != null)
            return true;
          else
            _obj.ErrorAssignmentSubject = DirRX.SignPlatform.CertificateIssueTasks.Resources.SaveCertificateErrorFormat(_obj.RequestId.Value, _obj.Employee);
        }
        else
          _obj.ErrorAssignmentSubject = DirRX.SignPlatform.CertificateIssueTasks.Resources.GetRequestByIdErrorFormat(_obj.RequestId.Value, _obj.Employee);
      }
      else
        _obj.ErrorAssignmentSubject = DirRX.SignPlatform.CertificateIssueTasks.Resources.GetRequestErrorFormat(_obj.Employee);
      
      return false;
    }
    #endregion
    
    #endregion
    
    #region Этап "Сообщить ответственному об ошибке
    /// <summary>
    /// Обработать ситуации, когда из медленных мониторингов вышли по таймауту
    /// Нужно изменить статус заявки на Error и указать текст ошибки
    /// </summary>
    public virtual void Script30Execute()
    {
      var requestEntry = CertificateRequests.GetAll(x => x.RequestId == _obj.RequestId).FirstOrDefault();
      if (requestEntry != null)
      {
        requestEntry.Errors = Resources.SignServiceNotAnswer;
        
        if (requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.DocVerification)
        {
          requestEntry.Errors = SignPlatform.CertificateIssueTasks.Resources.ErrorTimeoutDocVerification;
        }
        else if(requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.InProgress)
        {
          requestEntry.Errors = SignPlatform.CertificateIssueTasks.Resources.ErrorTimeoutCertificateIssued;
        }
        else if(requestEntry.IssueStatus == SignPlatform.CertificateRequest.IssueStatus.NeedConfirmEsia)
        {
          requestEntry.Errors = SignPlatform.CertificateIssueTasks.Resources.ErrorTimeoutSignStatementESIA;
        }
        requestEntry.IssueStatus = SignPlatform.CertificateRequest.IssueStatus.Error;
        requestEntry.Executor = SignPlatform.CertificateRequest.Executor.TaskScheme;
        requestEntry.Save();
      }
    }

    public virtual void StartBlock20(DirRX.SignPlatform.Server.CertificateIssueErrorAssignmentArguments e)
    {
      if (string.IsNullOrEmpty(_obj.ErrorAssignmentSubject))
        e.Block.Subject = Resources.CertificateIssueErrorAssignmentSubjectFormat(_obj.RequestId, _obj.Employee);
      else
        e.Block.Subject = _obj.ErrorAssignmentSubject;
      e.Block.Performers.Add(_obj.Author);
    }
    
    /// <summary>
    /// Уведомление о задании: Ошибка при выпуске сертификата
    /// </summary>
    public virtual void StartAssignment20(DirRX.SignPlatform.ICertificateIssueErrorAssignment assignment, DirRX.SignPlatform.Server.CertificateIssueErrorAssignmentArguments e)
    {
      // Отправить сообщение о новом задании.
      EssPlatform.PublicFunctions.Module.SendNewNotification(Sungero.Company.Employees.As(assignment.Performer), false, DirRX.EssPlatform.PublicConstants.Module.TargetNameSpaces.EssNameSpace,
                                                             EssPlatform.PublicConstants.Module.SelfOfficeObjectTypes.WorkItems,
                                                             EssPlatform.PublicConstants.Module.ObjectCardTypeNames.CertificateIssueErrorAssignment, assignment.Id.ToString(), true);
    }
    
    #endregion
    
  }
}