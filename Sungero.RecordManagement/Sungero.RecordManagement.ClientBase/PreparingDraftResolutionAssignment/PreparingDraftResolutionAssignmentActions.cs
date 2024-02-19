using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Company;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow;
using Sungero.RecordManagement;
using Sungero.RecordManagement.PreparingDraftResolutionAssignment;

namespace Sungero.RecordManagement.Client
{
  partial class PreparingDraftResolutionAssignmentActions
  {
    public virtual void Abort(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      if (!e.Validate())
        return;
      
      var dialogId = Constants.DocumentReviewTask.PreparingDraftResolutionAssignmentConfirmDialogID.Abort;
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
      return Equals(_obj.Performer, _obj.Task.Author) &&
        _obj.IsRework == true &&
        _obj.Addressee == null &&
        Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
    }

    public virtual void ForRework(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      // Проверить заполненность текста комментария.
      if (string.IsNullOrWhiteSpace(_obj.ActiveText))
      {
        e.AddError(ReviewDraftResolutionAssignments.Resources.NeedTextToRework);
        return;
      }
      
      var documentReviewTask = DocumentReviewTasks.As(_obj.Task);
      
      // Проверить, что все поручения выданы от имени адресата.
      var wrongActionItems = _obj.ResolutionGroup.ActionItemExecutionTasks.Where(x => documentReviewTask.Addressees.All(a => !Equals(a.Addressee, x.AssignedBy)));
      if (wrongActionItems.Any())
      {
        e.AddError(RecordManagement.Resources.ActionItemsMustBeAssignedByAddressee);
        return;
      }
      
      // Вывести предупреждение.
      var dialogID = Constants.DocumentReviewTask.PreparingDraftResolutionAssignmentConfirmDialogID.ForRework;
      if (!Docflow.PublicFunctions.Module.ShowDialogGrantAccessRightsWithConfirmationDialog(_obj, _obj.OtherGroup.All.ToList(),
                                                                                            null, e.Action, dialogID))
      {
        e.Cancel();
      }
    }

    public virtual bool CanForRework(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return _obj.Addressee == null && !Equals(_obj.Performer, _obj.Task.Author);
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

    public virtual void AddAssignment(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      if (!_obj.ResolutionGroup.ActionItemExecutionTasks.Any(t => t.Status == ActionItemExecutionTask.Status.Draft))
      {
        var confirmationAccepted = Functions.Module.ShowConfirmationDialogCreationActionItem(_obj, _obj.DocumentForReviewGroup.OfficialDocuments.FirstOrDefault(), e);
        var dialogID = Constants.DocumentReviewTask.PreparingDraftResolutionAssignmentConfirmDialogID.AddAssignment;
        if (Docflow.PublicFunctions.Module.ShowDialogGrantAccessRightsWithConfirmationDialog(_obj,
                                                                                             _obj.OtherGroup.All.ToList(),
                                                                                             confirmationAccepted ? null : e.Action,
                                                                                             dialogID) == false)
          e.Cancel();
      }
      else
      {
        Functions.DocumentReviewTask.CheckOverdueActionItemExecutionTasks(DocumentReviewTasks.As(_obj.Task), e);
        
        var giveRights = Docflow.PublicFunctions.Module.ShowDialogGrantAccessRights(_obj,
                                                                                    _obj.OtherGroup.All.ToList(),
                                                                                    null);
        if (giveRights == false)
          e.Cancel();
        
        if (giveRights == null && Functions.PreparingDraftResolutionAssignment.ShowConfirmationDialogStartDraftResolution(_obj, e) == false)
          e.Cancel();
        
        var actionItems = Functions.DocumentReviewTask.Remote.GetChildActionItemsForDraftResolution(DocumentReviewTasks.As(_obj.Task), _obj);
        foreach (var actionItem in actionItems)
          actionItem.Start();
      }
    }

    public virtual bool CanAddAssignment(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return _obj.Addressee == null && Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
    }

    public virtual void Explored(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      // В качестве проектов резолюции нельзя отправить поручения-непроекты.
      if (_obj.ResolutionGroup.ActionItemExecutionTasks.Any(a => a.IsDraftResolution != true))
      {
        e.AddError(DocumentReviewTasks.Resources.FindNotDraftResolution);
        e.Cancel();
      }
      
      var hasActionItems = _obj.ResolutionGroup.ActionItemExecutionTasks.Any();
      if (hasActionItems)
      {
        var dropDialogId = Constants.DocumentReviewTask.PreparingDraftResolutionAssignmentConfirmDialogID.ExploredWithDeletingDraftResolutions;
        var dropIsConfirmed = Docflow.PublicFunctions.Module.ShowConfirmationDialog(e.Action.ConfirmationMessage,
                                                                                    Resources.ConfirmDeleteDraftResolutionAssignment,
                                                                                    null, dropDialogId);
        if (!dropIsConfirmed)
          e.Cancel();
      }
      
      var confirmDialogId = Constants.DocumentReviewTask.PreparingDraftResolutionAssignmentConfirmDialogID.Explored;
      if (!Docflow.PublicFunctions.Module.ShowDialogGrantAccessRightsWithConfirmationDialog(_obj,
                                                                                            _obj.OtherGroup.All.ToList(),
                                                                                            hasActionItems ? null : e.Action,
                                                                                            confirmDialogId))
      {
        e.Cancel();
      }
      
      _obj.NeedDeleteActionItems = hasActionItems;
    }

    public virtual bool CanExplored(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return _obj.Addressee == null && Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
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
      
      // В качестве проектов резолюции нельзя отправить поручения-непроекты.
      if (_obj.ResolutionGroup.ActionItemExecutionTasks.Any(a => a.IsDraftResolution != true))
      {
        e.AddError(DocumentReviewTasks.Resources.FindNotDraftResolution);
        e.Cancel();
      }
      
      // Вывести подтверждение удаления проекта резолюции.
      var hasActionItems = _obj.ResolutionGroup.ActionItemExecutionTasks.Where(x => !Equals(x.AssignedBy, _obj.Addressee)).Any();
      if (hasActionItems)
      {
        var dropDialogId = Constants.DocumentReviewTask.PreparingDraftResolutionAssignmentConfirmDialogID.ForwardWithDeletingDraftResolutions;
        var dropIsConfirmed = Docflow.PublicFunctions.Module.ShowConfirmationDialog(e.Action.ConfirmationMessage,
                                                                                    Resources.ConfirmDeleteDraftResolutionAssignment,
                                                                                    null, dropDialogId);

        if (!dropIsConfirmed)
          e.Cancel();
      }
      
      var confirmDialogId = Constants.DocumentReviewTask.PreparingDraftResolutionAssignmentConfirmDialogID.Forward;
      var assignees = new List<IRecipient>() { _obj.Addressee };
      var assistant = Docflow.PublicFunctions.Module.GetSecretary(_obj.Addressee);
      if (assistant != null)
        assignees.Add(assistant);
      if (!Docflow.PublicFunctions.Module.ShowDialogGrantAccessRightsWithConfirmationDialog(_obj,
                                                                                            _obj.OtherGroup.All.ToList(),
                                                                                            assignees,
                                                                                            hasActionItems ? null : e.Action,
                                                                                            confirmDialogId))
      {
        e.Cancel();
      }
      
      _obj.NeedDeleteActionItems = hasActionItems;
    }

    public virtual bool CanForward(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
    }

    public virtual void SendForReview(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var documentReviewTask = DocumentReviewTasks.As(_obj.Task);
      
      // В качестве проектов резолюции нельзя отправить поручения-непроекты.
      if (_obj.ResolutionGroup.ActionItemExecutionTasks.Any(a => a.IsDraftResolution != true))
        e.AddError(DocumentReviewTasks.Resources.FindNotDraftResolution);
      
      // Проверить, что все поручения выданы от имени адресата.
      var wrongActionItems = _obj.ResolutionGroup.ActionItemExecutionTasks.Where(x => documentReviewTask.Addressees.All(a => !Equals(a.Addressee, x.AssignedBy)));
      if (wrongActionItems.Any())
      {
        e.AddError(RecordManagement.Resources.ActionItemsMustBeAssignedByAddressee);
        return;
      }
      
      var giveRights = Docflow.PublicFunctions.Module.ShowDialogGrantAccessRights(_obj,
                                                                                  _obj.OtherGroup.All.ToList(),
                                                                                  null);
      if (giveRights == false)
        e.Cancel();
      
      if (giveRights == null && _obj.NeedDeleteActionItems != true && !Functions.PreparingDraftResolutionAssignment.ShowConfirmationDialogSendForReview(_obj, e))
        e.Cancel();
    }

    public virtual bool CanSendForReview(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return _obj.Addressee == null && Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
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
      return _obj.Status.Value == PreparingDraftResolutionAssignment.Status.InProcess &&
        _obj.Addressee == null &&
        _obj.AccessRights.CanUpdate() &&
        Functions.DocumentReviewTask.HasDocumentAndCanRead(DocumentReviewTasks.As(_obj.Task));
    }

  }

}