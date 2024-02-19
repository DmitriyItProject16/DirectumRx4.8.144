using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.RecordManagement.DocumentReviewAssignment;

namespace Sungero.RecordManagement
{
  partial class DocumentReviewAssignmentClientHandlers
  {

    public override void Showing(Sungero.Presentation.FormShowingEventArgs e)
    {
      var withDraftResolution = _obj.ResolutionGroup.ActionItemExecutionTasks.Any();
      if (withDraftResolution)
      {
        e.HideAction(_obj.Info.Actions.DocsRework);
        e.HideAction(_obj.Info.Actions.ActionItemsSent);
        e.HideAction(_obj.Info.Actions.ResPassed);
        e.HideAction(_obj.Info.Actions.CreateActionItem);
      }
      else
      {
        e.HideAction(_obj.Info.Actions.DraftResApprove);
        e.HideAction(_obj.Info.Actions.DraftResRework);
        _obj.State.Controls.StateView.IsVisible = false;
      }
      // Скрывать результат выполнения "Вернуть инициатору" для задач, стартованных в рамках согласования по регламенту.
      if (Functions.DocumentReviewTask.ReviewStartedFromApproval(_obj.Task))
        e.HideAction(_obj.Info.Actions.DocsRework);
    }

    public override void Refresh(Sungero.Presentation.FormRefreshEventArgs e)
    {
      var canReadDocument = Functions.DocumentReviewAssignment.HasDocumentAndCanRead(_obj);
      _obj.State.Properties.Addressee.IsVisible = canReadDocument;
      if (!canReadDocument)
        e.AddError(Docflow.Resources.NoRightsToDocument);
    }

  }
}