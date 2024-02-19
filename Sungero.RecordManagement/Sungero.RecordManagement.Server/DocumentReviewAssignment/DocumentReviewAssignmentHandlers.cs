using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.RecordManagement.DocumentReviewAssignment;

namespace Sungero.RecordManagement
{
  partial class DocumentReviewAssignmentServerHandlers
  {

    public override void BeforeComplete(Sungero.Workflow.Server.BeforeCompleteEventArgs e)
    {
      // Добавить автотекст.
      if (_obj.Result.Value == Result.Informed)
        e.Result = ReviewManagerAssignments.Resources.Explored;
      if (_obj.Result.Value == Result.ActionItemsSent || _obj.Result.Value == Result.DraftResApprove)
        e.Result = ReviewManagerAssignments.Resources.AssignmentCreated;
      if (_obj.Result.Value == Result.ResPassed)
        e.Result = ReviewManagerAssignments.Resources.ResolutionAdded;
      if (_obj.Result.Value == Result.Forward)
        e.Result = DocumentReviewTasks.Resources.ForwardFormat(Company.PublicFunctions.Employee.GetShortName(_obj.Addressee, DeclensionCase.Dative, true));
      if (_obj.Result.Value == Result.DocsRework || _obj.Result.Value == Result.DraftResRework)
        e.Result = ReviewDraftResolutionAssignments.Resources.ReworkResolution;
    }
  }

}