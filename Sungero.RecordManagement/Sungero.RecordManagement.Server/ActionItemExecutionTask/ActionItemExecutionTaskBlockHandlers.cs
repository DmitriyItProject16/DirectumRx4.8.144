using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Content;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Shared;
using Sungero.RecordManagement.ActionItemExecutionTask;
using Sungero.Workflow;

namespace Sungero.RecordManagement.Server.ActionItemExecutionTaskBlocks
{
  partial class SendActionItemsToCoAssigneesBlockHandlers
  {

    public virtual void SendActionItemsToCoAssigneesBlockStartTask(Sungero.RecordManagement.IActionItemExecutionTask task, Sungero.RecordManagement.IActionItemExecutionTaskCoAssignees item)
    {
      Functions.ActionItemExecutionTask.SynchronizeAddendaAndAttachmentsGroup(_obj);
      
      var parentAssignment = Functions.ActionItemExecutionTask.GetActionItemExecutionAssignment(_obj);
      // Dmitriev_IA: MainTask задачи должен соответствовать MainTask ведущего задания.
      // Иначе присвоение будет падать с ошибкой "Parent assignment doesn't belong to the current task family".
      ((Sungero.Workflow.IInternalTask)task).MainTask = parentAssignment.MainTask;
      task.ParentAssignment = parentAssignment;
      
      task.Importance = _obj.Importance;
      task.ActionItemType = ActionItemType.Additional;
      
      // Синхронизировать вложения.
      Functions.Module.SynchronizeAttachmentsToActionItem(_obj, task);
      
      // Задать текст.
      task.Texts.Last().IsAutoGenerated = true;
      
      // Задать поручение.
      task.ActionItem = _obj.ActionItem;
      
      // Задать исполнителя, ответственного, контролера и инициатора.
      task.Assignee = item.Assignee;
      task.IsUnderControl = true;
      task.Supervisor = _obj.Assignee;
      task.AssignedBy = _obj.Assignee;
      
      // Задать срок.
      task.Deadline = _obj.CoAssigneesDeadline ?? _obj.Deadline;
      task.MaxDeadline = _obj.CoAssigneesDeadline ?? _obj.Deadline;
      task.HasIndefiniteDeadline = _obj.HasIndefiniteDeadline == true && task.Deadline == null;
      
      item.AssignmentCreated = true;
      _obj.Save();
    }
  }

  partial class SendTasksByActionItemPartsBlockHandlers
  {

    public virtual void SendTasksByActionItemPartsBlockStart()
    {
      var document = _obj.DocumentsGroup.OfficialDocuments.FirstOrDefault();
      if (document != null)
      {
        if (document.Assignee == null)
        {
          var firstActionItemPart = _obj.ActionItemParts.FirstOrDefault();
          if (firstActionItemPart != null)
            Sungero.Docflow.PublicFunctions.OfficialDocument.SetDocumentAssignee(document, firstActionItemPart.Assignee);
        }

        Functions.ActionItemExecutionTask.RelateAddedAddendaToPrimaryDocument(_obj);
        Functions.Module.SetDocumentExecutionState(_obj, document, null);
        Functions.Module.SetDocumentControlExecutionState(document);
      }
    }

    public virtual void SendTasksByActionItemPartsBlockStartTask(Sungero.RecordManagement.IActionItemExecutionTask task, Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts item)
    {
      task.Importance = _obj.Importance;
      task.ActionItemType = ActionItemType.Component;
      
      // Синхронизировать вложения.
      Functions.Module.SynchronizeAttachmentsToActionItem(_obj, task);
      
      // Задать поручение и текст.
      task.ActiveText = string.IsNullOrWhiteSpace(item.ActionItemPart) ? _obj.ActiveText : item.ActionItemPart;
      
      // Задать соисполнителей.
      foreach (var coAssignee in Functions.ActionItemExecutionTask.GetPartCoAssignees(_obj, item.PartGuid))
        task.CoAssignees.AddNew().Assignee = coAssignee;
      
      // Задать исполнителя, ответственного, контролера и инициатора.
      task.Assignee = item.Assignee;
      task.HasIndefiniteDeadline = _obj.HasIndefiniteDeadline == true;
      task.IsUnderControl = _obj.IsUnderControl;
      task.Supervisor = item.Supervisor ?? _obj.Supervisor;
      task.AssignedBy = _obj.AssignedBy;

      // Задать срок.
      var actionItemDeadline = item.Deadline.HasValue ? item.Deadline : _obj.FinalDeadline;
      task.Deadline = actionItemDeadline;
      task.MaxDeadline = actionItemDeadline;
      
      // Задать срок соисполнителям.
      if (item.CoAssigneesDeadline.HasValue)
        task.CoAssigneesDeadline = item.CoAssigneesDeadline;
      
      // Добавить составные подзадачи в исходящее.
      if (task.Status == Sungero.Workflow.Task.Status.InProcess)
        Sungero.Workflow.SpecialFolders.GetOutbox(_obj.StartedBy).Items.Add(task);
      
      // Записать ссылку на поручение в составное поручение.
      item.ActionItemPartExecutionTask = task;
      
      item.AssignmentCreated = true;
      _obj.Save();
    }
  }

  partial class WaitArioProcessingBlockHandlers
  {

    public virtual bool WaitArioProcessingBlockResult()
    {
      return Functions.ActionItemExecutionTask.CheckArioTasksStatus(_obj);
    }

    public virtual void WaitArioProcessingBlockStart()
    {
      var predictionInfo = ActionItemPredictionInfos.GetAll()
        .FirstOrDefault(x => x.TaskId == _obj.Id &&
                        x.TaskType == RecordManagement.ActionItemPredictionInfo.TaskType.ActionItem);
      if (predictionInfo == null)
      {
        predictionInfo = ActionItemPredictionInfos.Create();
        predictionInfo.TaskId = _obj.Id;
        predictionInfo.TaskType = RecordManagement.ActionItemPredictionInfo.TaskType.ActionItem;
      }
      else
      {
        // Если Результаты предсказания поручений найдены, то используем их, а информацию о задаче Ario в них чистим.
        predictionInfo.ArioTaskId = null;
        predictionInfo.ArioTaskStatus = null;
        predictionInfo.ArioResultJson = null;
        RecordManagement.PublicFunctions.ActionItemPredictionInfo.RemoveActionItemDraftFromParentAssignment(predictionInfo);
        predictionInfo.ActionItemId = null;
      }
      
      var errorMessage = string.Empty;
      var assistant = Functions.ActionItemExecutionTask.GetAIAssistantPreparingActionItemDrafts(_obj);
      var document = _obj.DocumentsGroup.OfficialDocuments.FirstOrDefault();
      if (document != null && assistant != null && assistant.Classifiers.Any())
      {
        predictionInfo.AIManagerAssistant = assistant;
        try
        {
          var classifierIds = assistant.Classifiers
            .Where(x => x.ClassifierId.HasValue)
            .Select(x => x.ClassifierId.Value)
            .ToList();
          var arioTask = SmartProcessing.PublicFunctions.Module.ClassifyDocumentAsync(document, classifierIds);
          
          // Задать состояние поручения.
          if (_obj.ExecutionState != ExecutionState.OnRework)
            _obj.ExecutionState = ExecutionState.OnExecution;
          
          if (arioTask.Id.HasValue && arioTask.Id.Value > 0)
            predictionInfo.ArioTaskId = arioTask.Id.Value;
          else
          {
            errorMessage = string.Format("{0} classifierIds={1}, documentId={2}",
                                         arioTask.ErrorMessage, string.Join(",", classifierIds), document.Id);
          }
        }
        catch (Exception ex)
        {
          errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
        }
      }
      else
      {
        errorMessage = "No data found for classification in Ario";
      }
      
      if (!string.IsNullOrEmpty(errorMessage))
      {
        predictionInfo.ArioTaskStatus = RecordManagement.ActionItemPredictionInfo.ArioTaskStatus.ErrorOccured;
        Logger.DebugFormat("ActionItemExecutionTask (ID={0}). WaitArioProcessingBlockStart. Error while sending document to Ario: {1}",
                           _obj.Id, errorMessage);
      }
      
      Functions.ActionItemPredictionInfo.TrySave(predictionInfo);
      
      _block.Period = TimeSpan.FromSeconds(Constants.ActionItemExecutionTask.WaitArioProcessingBlockDefaultParams.PeriodInSeconds);
      if (_block.RelativeDeadline.Equals(TimeSpan.Zero))
        _block.RelativeDeadline = TimeSpan.FromMinutes(Constants.ActionItemExecutionTask.WaitArioProcessingBlockDefaultParams.RelativeDeadlineInMinutes);
    }
  }

  partial class PrepareDraftActionItemBlockHandlers
  {

    public virtual void PrepareDraftActionItemBlockExecute()
    {
      var predictionInfo = ActionItemPredictionInfos.GetAll()
        .FirstOrDefault(x => x.TaskId == _obj.Id && x.TaskType == RecordManagement.ActionItemPredictionInfo.TaskType.ActionItem);
      
      if (predictionInfo == null)
        return;
      
      if (predictionInfo.ArioTaskStatus == RecordManagement.ActionItemPredictionInfo.ArioTaskStatus.ErrorOccured)
        return;
      
      if (predictionInfo.ArioTaskStatus == RecordManagement.ActionItemPredictionInfo.ArioTaskStatus.InProcess)
      {
        Logger.DebugFormat("ActionItemExecutionTask (ID={0}). PrepareDraftActionItemBlockExecute. Ario processing time expired, no response received",
                           _obj.Id);
        predictionInfo.ArioTaskStatus = RecordManagement.ActionItemPredictionInfo.ArioTaskStatus.ErrorOccured;
        if (!Functions.ActionItemPredictionInfo.TrySave(predictionInfo))
          return;
      }
      
      // Определить исполнителя по результатам Ario.
      var classifier = predictionInfo.AIManagerAssistant.Classifiers
        .Where(x => x.ClassifierId.HasValue && x.ClassifierType == Intelligence.AIManagersAssistantClassifiers.ClassifierType.Assignee)
        .FirstOrDefault();
      if (classifier == null)
        return;
      var limit = (double)classifier.LowerClassificationLimit / 100;
      var performer = SmartProcessing.PublicFunctions.Module.GetPerformerByPredictionResult(predictionInfo.ArioResultJson, classifier.ClassifierId.Value, limit);
      if (performer == null)
        return;
      
      var draft = Functions.ActionItemExecutionTask.CreateDraftActionItemExecutionTask(_obj, performer);
      draft.Save();
      
      predictionInfo.ActionItemId = draft.Id;
      predictionInfo.Assignee = performer; 
      Functions.ActionItemPredictionInfo.TrySave(predictionInfo);
    }
  }

  partial class DeleteDraftActionItemsBlockHandlers
  {

    public virtual void DeleteDraftActionItemsBlockExecute()
    {
      Logger.DebugFormat("ActionItemExecutionTask (ID={0}). DeleteDraftActionItemsBlockExecute", _obj.Id);
      var draftTasks = ActionItemExecutionTasks.GetAll()
        .Where(x => x.ParentAssignment != null && Equals(x.ParentAssignment.Task, _obj)
               && x.Status == RecordManagement.ActionItemExecutionTask.Status.Draft)
        .ToList();
      Functions.Module.DeleteActionItemExecutionTasks(draftTasks);
    }
  }

  /// <summary>
  /// Назначение участникам прав на документы и задачу.
  /// </summary>
  partial class GrantAccessRightsToDocumentsAndTaskBlockHandlers
  {

    public virtual void GrantAccessRightsToDocumentsAndTaskBlockExecute()
    {
      // Выдать права на изменение для возможности прекращения задачи.
      Logger.DebugFormat("ActionItemExecutionTask (ID={0}). Grant access right to task.", _obj.Id);
      Functions.ActionItemExecutionTask.GrantAccessRightToTask(_obj, _obj);
      
      var documents = new List<Sungero.Domain.Shared.IEntity>();
      documents.AddRange(_obj.ResultGroup.All.ToList());
      documents.AddRange(_obj.DocumentsGroup.All.ToList());
      documents.AddRange(_obj.AddendaGroup.All.ToList());
      
      if (_obj.IsCompoundActionItem == true)
      {
        Functions.ActionItemExecutionTask.GrantAccessRightsToActionItemPartPerformers(_obj, documents);
      }
      else
      {
        Functions.ActionItemExecutionTask.GrantAccessRightsToAssignee(_obj, documents);
        Functions.ActionItemExecutionTask.GrantAccessRightsToCoAssignee(_obj, documents);
      }
      
      Functions.ActionItemExecutionTask.GrantAccessRightsToAttachments(_obj, documents, false);
      
      if (_obj.IsDraftResolution == true)
        _obj.IsDraftResolution = null;
    }
  }

  /// <summary>
  /// Ожидание исполнения всех пунктов составного поручения.
  /// </summary>
  partial class WaitForCompletionActionItemPartsBlockHandlers
  {
    [Obsolete("Ожидание завершения настроено в блоке SendTasksByActionItemParts")]
    public virtual bool WaitForCompletionActionItemPartsBlockResult()
    {
      return Functions.ActionItemExecutionTask.AllActionItemPartsAreCompleted(_obj);
    }
  }

  /// <summary>
  /// Отправка задачи по следующему пункту поручения.
  /// </summary>
  partial class SendTaskByNextActionItemPartBlockHandlers
  {
    [Obsolete("Используйте блок SendTasksByActionItemParts")]
    public virtual void SendTaskByNextActionItemPartBlockExecute()
    {
      var document = _obj.DocumentsGroup.OfficialDocuments.FirstOrDefault();
      if (document != null)
      {
        if (document.Assignee == null)
        {
          var firstActionItemPart = _obj.ActionItemParts.FirstOrDefault();
          if (firstActionItemPart != null)
            Sungero.Docflow.PublicFunctions.OfficialDocument.SetDocumentAssignee(document, firstActionItemPart.Assignee);
        }
        
        Functions.ActionItemExecutionTask.RelateAddedAddendaToPrimaryDocument(_obj);
        Functions.Module.SetDocumentExecutionState(_obj, document, null);
        Functions.Module.SetDocumentControlExecutionState(document);
      }
      
      if (_obj.ActionItemParts != null && _obj.ActionItemParts.Any(x => x.AssignmentCreated != true))
      {
        var job = _obj.ActionItemParts.FirstOrDefault(aip => aip.AssignmentCreated != true);
        
        var actionItemExecution = ActionItemExecutionTasks.CreateAsSubtask(_obj);
        actionItemExecution.Importance = _obj.Importance;
        actionItemExecution.ActionItemType = ActionItemType.Component;
        
        // Синхронизировать вложения.
        Functions.Module.SynchronizeAttachmentsToActionItem(_obj, actionItemExecution);
        
        // Задать поручение и текст.
        actionItemExecution.ActiveText = string.IsNullOrWhiteSpace(job.ActionItemPart) ? _obj.ActiveText : job.ActionItemPart;
        
        // Задать тему.
        actionItemExecution.Subject = Functions.ActionItemExecutionTask.GetActionItemExecutionSubject(actionItemExecution, ActionItemExecutionTasks.Resources.TaskSubject);
        actionItemExecution.ThreadSubject = Sungero.RecordManagement.ActionItemExecutionTasks.Resources.ActionItemWithNumberThreadSubject;
        
        // Задать соисполнителей.
        foreach (var coAssignee in Functions.ActionItemExecutionTask.GetPartCoAssignees(_obj, job.PartGuid))
          actionItemExecution.CoAssignees.AddNew().Assignee = coAssignee;
        
        // Задать исполнителя, ответственного, контролера и инициатора.
        actionItemExecution.Assignee = job.Assignee;
        actionItemExecution.HasIndefiniteDeadline = _obj.HasIndefiniteDeadline == true;
        actionItemExecution.IsUnderControl = _obj.IsUnderControl;
        actionItemExecution.Supervisor = job.Supervisor ?? _obj.Supervisor;
        actionItemExecution.Author = _obj.Author;
        actionItemExecution.AssignedBy = _obj.AssignedBy;

        // Задать срок.
        var actionItemDeadline = job.Deadline.HasValue ? job.Deadline : _obj.FinalDeadline;
        actionItemExecution.Deadline = actionItemDeadline;
        actionItemExecution.MaxDeadline = actionItemDeadline;
        
        // Задать срок соисполнителям.
        if (job.CoAssigneesDeadline.HasValue)
          actionItemExecution.CoAssigneesDeadline = job.CoAssigneesDeadline;
        
        actionItemExecution.Start();
        
        // Добавить составные подзадачи в исходящее.
        if (actionItemExecution.Status == Sungero.Workflow.Task.Status.InProcess)
          Sungero.Workflow.SpecialFolders.GetOutbox(_obj.StartedBy).Items.Add(actionItemExecution);
        
        // Записать ссылку на поручение в составное поручение.
        job.ActionItemPartExecutionTask = actionItemExecution;
        
        job.AssignmentCreated = true;
        _obj.Save();
      }
    }
  }

  /// <summary>
  /// Обработка результата исполнения поручения.
  /// </summary>
  partial class ProcessResultOfExecutionActionItemBlockHandlers
  {
    public virtual void ProcessResultOfExecutionActionItemBlockExecute()
    {
      // Задать состояние поручения.
      _obj.ExecutionState = ExecutionState.Executed;
      
      // Обновить статус исполнения документа - исполнен, статус контроля исполнения - снято с контроля.
      var document = _obj.DocumentsGroup.OfficialDocuments.FirstOrDefault();
      Functions.Module.SetDocumentExecutionState(_obj, document, null);
      Functions.Module.SetDocumentControlExecutionState(document);
      
      // Добавить документы из группы "Результаты исполнения" в ведущее задание на исполнение.
      Functions.ActionItemExecutionTask.SynchronizeResultGroup(_obj);
      
      // Автоматически выполнить ведущее поручение.
      if (Functions.ActionItemExecutionTask.CanAutoExecParentAssignment(_obj))
      {
        Functions.ActionItemExecutionTask.SynchronizeResultActiveText(_obj);
        Functions.ActionItemExecutionTask.CompleteParentAssignment(_obj);
        Functions.ActionItemExecutionTask.SetCompletedByInParentAssignment(_obj);
      }
    }
  }

  /// <summary>
  /// Ожидание разблокировки ведущего задания.
  /// </summary>
  partial class WaitForUnblockingLeadingAssignmentBlockHandlers
  {
    public virtual bool WaitForUnblockingLeadingAssignmentBlockResult()
    {
      return _obj.WaitForParentAssignment != true || _obj.ParentAssignment == null || _obj.ParentAssignment.Status == Workflow.Assignment.Status.Completed;
    }
  }

  /// <summary>
  /// Приемка работ контролером.
  /// </summary>
  partial class AcceptWorkBySupervisorBlockHandlers
  {

    public virtual void AcceptWorkBySupervisorBlockStart()
    {
      // Задать состояние поручения.
      _obj.ExecutionState = ExecutionState.OnControl;
      
      Functions.ActionItemExecutionTask.SynchronizeAddendaAndAttachmentsGroup(_obj);
    }

    public virtual void AcceptWorkBySupervisorBlockStartAssignment(Sungero.RecordManagement.IActionItemSupervisorAssignment assignment)
    {
      // Заполнить плановый срок поручения.
      assignment.ScheduledDate = _obj.Deadline;
      
      // Для подзадач соисполнителям заполнять данными из основной задачи.
      if (_obj.ActionItemType != ActionItemType.Main)
      {
        var mainActionItemExecution = ActionItemExecutionTasks.As(_obj.MainTask);
        if (mainActionItemExecution != null && !(mainActionItemExecution.IsCompoundActionItem ?? false))
        {
          // Задать автора.
          assignment.AssignedBy = mainActionItemExecution.AssignedBy;
        }
      }
      
      assignment.Author = _obj.Assignee;
      assignment.ActionItem = _obj.ActionItem;
      assignment.Importance = _obj.Importance;
      if (_obj.HasIndefiniteDeadline != true)
        assignment.NewDeadline = _obj.Deadline;
      assignment.AssignedBy = _obj.AssignedBy;
      
      // Выдать права на изменение для возможности прекращения задачи.
      Functions.ActionItemExecutionTask.GrantAccessRightToTask(_obj, _obj);
      
      if (_block.GrantRightsByDefault == true)
      {
        var attachments = _obj.ResultGroup.All.ToList();
        attachments.AddRange(_obj.DocumentsGroup.All.ToList());
        attachments.AddRange(_obj.AddendaGroup.All.ToList());
        Functions.ActionItemExecutionTask.GrantAccessRightsToAttachments(_obj, attachments, false);
      }
    }

    public virtual void AcceptWorkBySupervisorBlockCompleteAssignment(Sungero.RecordManagement.IActionItemSupervisorAssignment assignment)
    {
      // Переписка.
      _obj.ReportNote = assignment.ActiveText;
    }

    public virtual void AcceptWorkBySupervisorBlockEnd(System.Collections.Generic.IEnumerable<Sungero.RecordManagement.IActionItemSupervisorAssignment> createdAssignments)
    {
      var assignment = createdAssignments.OrderByDescending(a => a.Created).FirstOrDefault();
      if (assignment != null && assignment.Result == Sungero.RecordManagement.ActionItemSupervisorAssignment.Result.ForRework)
      {
        _obj.ExecutionState = ExecutionState.OnRework;
        var newDeadline = ActionItemSupervisorAssignments.As(assignment).NewDeadline;
        if (_obj.Deadline != newDeadline)
          Functions.ActionItemExecutionTask.SetActionItemChangeDeadlinesParams(_obj, true, true);
        _obj.Deadline = newDeadline;
        
        if (_obj.ActionItemType == ActionItemType.Component && ActionItemExecutionTasks.Is(_obj.ParentTask))
        {
          var rootTask = ActionItemExecutionTasks.As(_obj.ParentTask);
          var actionItem = rootTask.ActionItemParts.Where(i => Equals(i.ActionItemPartExecutionTask, _obj)).FirstOrDefault();
          if (actionItem != null && (actionItem.Deadline != null || rootTask.FinalDeadline != newDeadline))
          {
            if (actionItem.Deadline != newDeadline)
              Functions.ActionItemExecutionTask.SetActionItemChangeDeadlinesParams(rootTask, true, true);
            actionItem.Deadline = newDeadline;
          }
        }
      }
    }
  }

  /// <summary>
  /// Ожидание создания задания основному исполнителю.
  /// </summary>
  partial class WaitForCreateActionItemToAssigneeBlockHandlers
  {

    /// <summary>
    /// Проверка, создано ли задание исполнителю задачи.
    /// </summary>
    /// <returns>true - если задание создано.</returns>
    public virtual bool WaitForCreateActionItemToAssigneeBlockResult()
    {
      return Functions.ActionItemExecutionTask.AssignmentsCreated(_obj);
    }
  }

  /// <summary>
  /// Отправка поручения следующему соисполнителю.
  /// </summary>
  partial class SendActionItemToNextCoAssigneeBlockHandlers
  {
    [Obsolete("Используйте блок SendActionItemsToCoAssigneesBlock")]
    public virtual void SendActionItemToNextCoAssigneeBlockExecute()
    {
      var subject = Functions.ActionItemExecutionTask.GetActionItemExecutionSubject(_obj, ActionItemExecutionTasks.Resources.TaskSubject);
      
      Functions.ActionItemExecutionTask.SynchronizeAddendaAndAttachmentsGroup(_obj);
      
      // Задания соисполнителям.
      if (_obj.CoAssignees != null && _obj.CoAssignees.Any(ca => ca.AssignmentCreated != true))
      {
        var performer = _obj.CoAssignees.FirstOrDefault(ca => ca.AssignmentCreated != true);
        
        var parentAssignment = Functions.ActionItemExecutionTask.GetActionItemExecutionAssignment(_obj);
        
        var actionItemExecution = ActionItemExecutionTasks.CreateAsSubtask(parentAssignment);
        actionItemExecution.Importance = _obj.Importance;
        actionItemExecution.ActionItemType = ActionItemType.Additional;
        
        // Синхронизировать вложения.
        Functions.Module.SynchronizeAttachmentsToActionItem(_obj, actionItemExecution);
        
        // Задать текст.
        actionItemExecution.Texts.Last().IsAutoGenerated = true;
        
        // Задать поручение.
        actionItemExecution.ActionItem = _obj.ActionItem;
        
        // Задать тему.
        actionItemExecution.Subject = subject;
        
        // Задать исполнителя, ответственного, контролера и инициатора.
        actionItemExecution.Assignee = performer.Assignee;
        actionItemExecution.IsUnderControl = true;
        actionItemExecution.Supervisor = _obj.Assignee;
        actionItemExecution.AssignedBy = _obj.Assignee;
        
        // Задать срок.
        actionItemExecution.Deadline = _obj.CoAssigneesDeadline ?? _obj.Deadline;
        actionItemExecution.MaxDeadline = _obj.CoAssigneesDeadline ?? _obj.Deadline;
        actionItemExecution.HasIndefiniteDeadline = _obj.HasIndefiniteDeadline == true && actionItemExecution.Deadline == null;
        
        actionItemExecution.Start();
        
        performer.AssignmentCreated = true;
        _obj.Save();
      }
    }
  }

  /// <summary>
  /// Исполнение поручения.
  /// </summary>
  partial class ExecuteActionItemBlockHandlers
  {
    public virtual void ExecuteActionItemBlockStart()
    {
      Functions.ActionItemExecutionTask.SynchronizeAddendaAndAttachmentsGroup(_obj);
      Functions.ActionItemExecutionTask.RelateAddedAddendaToPrimaryDocument(_obj);
      
      // Задать состояние поручения.
      if (_obj.ExecutionState != ExecutionState.OnRework && _obj.Assignee != null)
        _obj.ExecutionState = ExecutionState.OnExecution;
      
      var document = _obj.DocumentsGroup.OfficialDocuments.FirstOrDefault();
      
      // Заполнить исполнителя, если это первое поручение по документу.
      if (document != null)
        Sungero.Docflow.PublicFunctions.OfficialDocument.SetDocumentAssignee(document, _obj.Assignee);

      // Обновить статус исполнения документа.
      Functions.Module.SetDocumentExecutionState(_obj, document, null);
      Functions.Module.SetDocumentControlExecutionState(document);
    }

    public virtual void ExecuteActionItemBlockStartAssignment(Sungero.RecordManagement.IActionItemExecutionAssignment assignment)
    {
      // Заполнить плановый срок. Не используется. Заполнение оставлено для обратной совместимости.
      if (_obj.Deadline.HasValue)
        assignment.ScheduledDate = _obj.Deadline.Value;
      
      Functions.ActionItemExecutionTask.AddDraftActionItemToParentAssignment(_obj, assignment);
      
      // Для подзадач соисполнителям заполнять "Выдал" из основной задачи.
      IActionItemExecutionTask actionItemTask = null;
      if (_obj.ActionItemType != ActionItemType.Main)
      {
        var mainActionItemExecution = ActionItemExecutionTasks.As(_obj.MainTask);
        if (mainActionItemExecution != null && !(mainActionItemExecution.IsCompoundActionItem ?? false))
          actionItemTask = mainActionItemExecution;
      }
      
      if (actionItemTask == null)
        actionItemTask = _obj;
      
      assignment.AssignedBy = actionItemTask.AssignedBy;
      
      assignment.ActionItem = _obj.ActionItem;
      assignment.Importance = _obj.Importance;
      if (_obj.ActionItemType == ActionItemType.Additional)
        assignment.Author = Sungero.RecordManagement.ActionItemExecutionTasks.As(_obj.ParentAssignment.Task).AssignedBy;
      
      if (_block.GrantRightsByDefault == true)
      {
        var attachments = _obj.ResultGroup.All.ToList();
        attachments.AddRange(_obj.DocumentsGroup.All.ToList());
        attachments.AddRange(_obj.AddendaGroup.All.ToList());
        Functions.ActionItemExecutionTask.GrantAccessRightsToAssignee(_obj, attachments);
      }
    }

    public virtual void ExecuteActionItemBlockCompleteAssignment(Sungero.RecordManagement.IActionItemExecutionAssignment assignment)
    {
      // Переписка.
      _obj.Report = assignment.ActiveText;
      
      // Прекратить задание на продление срока, если оно есть.
      // Устаревший тип задания, оставлен для совместимости.
      var extendDeadlineTasks = DeadlineExtensionTasks.GetAll(j => Equals(j.ParentAssignment, assignment) &&
                                                              j.Status == Workflow.Task.Status.InProcess);
      foreach (var extendDeadlineTask in extendDeadlineTasks)
        extendDeadlineTask.Abort();
      
      // Прекратить задание на продление срока, если оно есть.
      var newExtendDeadlineTasks = Docflow.DeadlineExtensionTasks.GetAll(j => Equals(j.ParentAssignment, assignment) &&
                                                                         j.Status == Workflow.Task.Status.InProcess);
      foreach (var newExtendDeadlineTask in newExtendDeadlineTasks)
        newExtendDeadlineTask.Abort();
      
      // Прекратить задачи на запрос отчета, созданные из текущей задачи.
      Functions.ActionItemExecutionTask.AbortReportRequestTasksCreatedFromTask(_obj);
      
      // Прекратить задачи на запрос отчета, созданные из родительского задания.
      Functions.ActionItemExecutionTask.AbortReportRequestTasksCreatedFromAssignmentToAssignee(_obj,
                                                                                               ActionItemExecutionAssignments.As(_obj.ParentAssignment),
                                                                                               _obj.Assignee);
      
      // Прекратить задачи на запрос отчета, созданные из составного поручения исполнителю пункта.
      if (ActionItemExecutionTasks.As(_obj.ParentTask)?.IsCompoundActionItem == true)
      {
        Functions.ActionItemExecutionTask.AbortReportRequestTasksCreatedFromTaskToAssignee(_obj,
                                                                                           ActionItemExecutionTasks.As(_obj.ParentTask),
                                                                                           _obj.Assignee);
      }

      // Рекурсивно прекратить подзадачи.
      if (assignment.NeedAbortChildActionItems ?? false)
      {
        var notCompletedExecutionSubTasks = Functions.ActionItemExecutionAssignment.GetNotCompletedSubActionItems(assignment);
        foreach (var subTask in notCompletedExecutionSubTasks)
        {
          Functions.Module.AbortSubtasksAndSendNotices(subTask, assignment.Performer, ActionItemExecutionTasks.Resources.AutoAbortingReason);
          subTask.Abort();
        }
        
        var otherTasksToAbort = new List<ITask>();
        otherTasksToAbort.AddRange(Functions.ActionItemExecutionAssignment.GetNotCompletedSubDeadlineExtensionTasks(assignment));
        otherTasksToAbort.AddRange(Functions.ActionItemExecutionAssignment.GetNotCompletedSubReportRequestTasks(assignment));
        foreach (var task in otherTasksToAbort)
          task.Abort();
      }
      
      if (_block.GrantRightsByDefault == true)
      {
        // Выдать права на вложенные документы.
        Functions.ActionItemExecutionTask.GrantAccessRightsToAttachments(_obj, _obj.ResultGroup.All.ToList(), false);
      }
      
      // Связать документы из группы "Результаты исполнения" с основным документом.
      var mainDocument = _obj.DocumentsGroup.OfficialDocuments.FirstOrDefault();
      if (mainDocument != null)
      {
        foreach (var document in _obj.ResultGroup.OfficialDocuments.Where(d => !Equals(d, mainDocument)))
        {
          try
          {
            if (!document.Relations.GetRelatedFrom(Constants.Module.SimpleRelationRelationName).Contains(mainDocument))
            {
              // Используется Lock, а не TryLock так как в случае невозможности блокировки необходимо генерировать Repeated lock exception и отправлять блок на переповтор. 
              // Это нужно для предотвращения ошибки при простановке связей и остановки задачи при параллельном завершении двух заданий с общим набором документов (см. Bug 269671).
              Locks.Lock(mainDocument);
              document.Relations.AddFrom(Constants.Module.SimpleRelationRelationName, mainDocument);
              document.Save();
            }
          }
          catch (Exception ex)
          {
            Logger.ErrorFormat("ExecuteActionItemBlockCompleteAssignment. Relation adding error: {3}. Task ID = {0}, Document ID = {1}, Main document ID = {2}", _obj.Id, document.Id, mainDocument.Id, ex.Message);
            throw;
          }
          finally
          {
            if (Locks.GetLockInfo(mainDocument).IsLockedByMe)
              Locks.Unlock(mainDocument);
          }
        }
      }
    }

    public virtual void ExecuteActionItemBlockEnd(System.Collections.Generic.IEnumerable<Sungero.RecordManagement.IActionItemExecutionAssignment> createdAssignments)
    {
      // Заполнить фактическую дату завершения исполнения поручения.
      var assignment = createdAssignments
        .OrderByDescending(a => a.Created)
        .FirstOrDefault();
      
      if (assignment == null)
        return;
      
      var completed = assignment.Completed;
      if (completed != null)
      {
        _obj.ActualDate = _block.AbsoluteDeadline.HasTime()
          ? completed
          : completed.ToUserTime(assignment.Performer).Value.Date;
      }
    }
  }
}