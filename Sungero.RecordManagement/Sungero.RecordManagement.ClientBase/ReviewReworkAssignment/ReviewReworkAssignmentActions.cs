using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.RecordManagement.ReviewReworkAssignment;

namespace Sungero.RecordManagement.Client
{
  partial class ReviewReworkAssignmentActions
  {
    public virtual void Informed(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      
    }

    public virtual bool CanInformed(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return true;
    }

    public virtual void PrintResolution(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      _obj.Save();
      var actionItems = _obj.ResolutionGroup.ActionItemExecutionTasks.ToList();
      Functions.DocumentReviewTask.OpenDraftResolutionReport(DocumentReviewTasks.As(_obj.Task), _obj.ActiveText, actionItems);
    }

    public virtual bool CanPrintResolution(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return _obj.Status == Workflow.Assignment.Status.InProcess &&
        _obj.ResolutionGroup.ActionItemExecutionTasks.Any() &&
        Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
    }

    public virtual void AddResolution(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      _obj.Save();
      
      var actionItem = Functions.DocumentReviewTask.CreateDraftResolution(DocumentReviewTasks.As(_obj.Task));
      if (!actionItem.State.IsInserted)
      {
        var draftActionItem = Functions.Module.Remote.GetActionitemById(actionItem.Id);
        _obj.ResolutionGroup.ActionItemExecutionTasks.Add(draftActionItem);
      }
    }

    public virtual bool CanAddResolution(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return _obj.Status == Workflow.Assignment.Status.InProcess && Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
    }

    public virtual void Abort(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      if (!e.Validate())
        return;
      
      var dialogId = Constants.DocumentReviewTask.ReviewReworkAssignmentConfirmDialogID.Abort;
      if (!Docflow.PublicFunctions.Module.ShowDialogGrantAccessRightsWithConfirmationDialog(_obj,
                                                                                            _obj.OtherGroup.All.ToList(),
                                                                                            e.Action,
                                                                                            dialogId))
      {
        return;
      }
      
      _obj.Task.Abort();
      e.CloseFormAfterAction = true;
    }

    public virtual bool CanAbort(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return _obj.Status.Value == ReviewReworkAssignment.Status.InProcess && _obj.Addressee == null;
    }

    public virtual void Forward(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var documentReviewTask = DocumentReviewTasks.As(_obj.Task);
      
      if (_obj.Addressee == null)
      {
        e.AddError(DocumentReviewTasks.Resources.CantRedirectWithoutAddressee);
        e.Cancel();
      }
      
      if (Equals(_obj.Addressee, documentReviewTask.Addressee))
      {
        e.AddError(DocumentReviewTasks.Resources.AddresseeAlreadyExistsFormat(_obj.Addressee.Person.ShortName));
        e.Cancel();
      }
      
      // Вывести подтверждение удаления проекта резолюции.
      var hasActionItems = _obj.ResolutionGroup.ActionItemExecutionTasks.Where(x => !Equals(x.AssignedBy, _obj.Addressee)).Any() &&
        _obj.State.Attachments.ResolutionGroup.IsVisible;
      if (hasActionItems)
      {
        var dropDialogId = Constants.DocumentReviewTask.ReviewReworkAssignmentConfirmDialogID.ForwardWithDrop;
        var dropIsConfirmed = Docflow.PublicFunctions.Module.ShowConfirmationDialog(e.Action.ConfirmationMessage,
                                                                                    ReviewReworkAssignments.Resources.ConfirmDeleteDraftResolutionAssignment,
                                                                                    null, dropDialogId);
        if (!dropIsConfirmed)
          e.Cancel();
      }
      
      // Вывести запрос прав на группу "Дополнительно".
      var assignees = new List<IRecipient>() { _obj.Addressee };
      var assistant = Docflow.PublicFunctions.Module.GetSecretary(_obj.Addressee);
      if (assistant != null)
        assignees.Add(assistant);
      var grantRightDialogResult = Docflow.PublicFunctions.Module.ShowDialogGrantAccessRights(_obj, _obj.OtherGroup.All.ToList(), assignees);
      if (grantRightDialogResult == false)
        e.Cancel();
      
      // Вывести подтверждение выполнения действия.
      var dialogId = Constants.DocumentReviewTask.ReviewReworkAssignmentConfirmDialogID.Forward;
      if (!hasActionItems && grantRightDialogResult == null &&
          !Docflow.PublicFunctions.Module.ShowConfirmationDialog(e.Action.ConfirmationMessage, null, null, dialogId))
      {
        e.Cancel();
      }
    }

    public virtual bool CanForward(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
    }

    public virtual void SendForReview(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var documentReviewTask = DocumentReviewTasks.As(_obj.Task);
      
      // Проверить, что исполнитель может готовить проект резолюции
      // и все поручения выданы адресатами рассмотрения.
      var actionItemAssigners = _obj.ResolutionGroup.ActionItemExecutionTasks.Select(a => a.AssignedBy).ToList();
      if (Functions.ReviewReworkAssignment.CanPrepareDraftResolution(_obj) &&
         actionItemAssigners.Any(x => documentReviewTask.Addressees.All(a => !Equals(a.Addressee, x))))
      {
        e.AddError(RecordManagement.Resources.ActionItemsMustBeAssignedByAddressee);
        return;
      }
      
      var giveRights = Docflow.PublicFunctions.Module.ShowDialogGrantAccessRights(_obj, _obj.OtherGroup.All.ToList(), null);
      if (giveRights == false)
        e.Cancel();
      
      var dialogId = Constants.DocumentReviewTask.ReviewReworkAssignmentConfirmDialogID.SendForReview;
      if (giveRights == null && !Docflow.PublicFunctions.Module.ShowConfirmationDialog(e.Action.ConfirmationMessage, null, null, dialogId))
        e.Cancel();
    }

    public virtual bool CanSendForReview(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return _obj.Addressee == null && Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
    }

  }

}