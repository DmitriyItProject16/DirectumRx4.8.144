using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.OfficialDocument;
using Sungero.Workflow;

namespace Sungero.RecordManagement.Server.RecordManagementBlocks
{

  partial class DocumentReviewBlockHandlers
  {

    public virtual void DocumentReviewBlockStart()
    {
      Logger.DebugFormat("DocumentReviewTask({0}) DocumentReviewBlockStart", _obj.Id);
      Functions.Module.SynchronizeAttachments(_obj, true);
      // Отправить запрос на подготовку предпросмотра для документов.
      Docflow.PublicFunctions.Module.PrepareAllAttachmentsPreviews(_obj);
    }
    
    public virtual void DocumentReviewBlockStartAssignment(Sungero.RecordManagement.IDocumentReviewAssignment assignment)
    {
      // Обновить статус исполнения - на рассмотрении.
      var reviewTask = DocumentReviewTasks.As(_obj);
      if (reviewTask != null)
      {
        Logger.DebugFormat("DocumentReviewTask({0}) DocumentReviewBlockStartAssignment", reviewTask.Id);
        var document = reviewTask.DocumentForReviewGroup.OfficialDocuments.First();
        Functions.Module.SetDocumentExecutionState(_obj, document, ExecutionState.OnReview);
        Functions.Module.SetDocumentControlExecutionState(document);
      }

      // Выдать исполнителю права на вложения.
      if (_block.GrantRightsByDefault == true)
        Functions.DocumentReviewTask.GrantRightsForMainDocumentAndAddendaToAssignees(reviewTask, _block.Performers.ToList(), true, assignment.AddendaGroup.OfficialDocuments.ToList());
    }

    public virtual void DocumentReviewBlockCompleteAssignment(Sungero.RecordManagement.IDocumentReviewAssignment assignment)
    {
      var reviewTask = DocumentReviewTasks.As(_obj);
      if (reviewTask != null)
      {
        Logger.DebugFormat("DocumentReviewTask({0}) DocumentReviewBlockCompleteAssignment", reviewTask.Id);
        var document = reviewTask.DocumentForReviewGroup.OfficialDocuments.First();
        
        // Заполнить текст резолюции из задания руководителя в задачу.
        if (assignment.Result == Sungero.RecordManagement.DocumentReviewAssignment.Result.ResPassed)
          reviewTask.ResolutionText = assignment.ActiveText;

        // Обновить статус исполнения - на исполнении.
        if (assignment.Result == Sungero.RecordManagement.DocumentReviewAssignment.Result.DraftResApprove)
        {
          Functions.Module.SetDocumentExecutionState(_obj, document, ExecutionState.OnExecution);
          Functions.Module.SetDocumentControlExecutionState(document);
        }
        
        // Обновить статус исполнения - не требует исполнения.
        if (assignment.Result == Sungero.RecordManagement.DocumentReviewAssignment.Result.Informed)
        {
          Functions.Module.SetDocumentExecutionState(_obj, document, ExecutionState.WithoutExecut);
          Functions.Module.SetDocumentControlExecutionState(document);
        }
      }
      
      Functions.Module.SynchronizeAttachments(assignment.Task, true);
    }

    public virtual void DocumentReviewBlockEnd(System.Collections.Generic.IEnumerable<Sungero.RecordManagement.IDocumentReviewAssignment> createdAssignments)
    {
      Docflow.PublicFunctions.Module.ExecuteWaitAssignmentMonitoring(createdAssignments.Select(a => a.Id).ToList());
      Logger.DebugFormat("DocumentReviewTask({0}) DocumentReviewBlockEnd", _obj.Id);
    }

  }

}