using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.RecordManagement.PreparingDraftResolutionAssignment;

namespace Sungero.RecordManagement
{
  partial class PreparingDraftResolutionAssignmentSharedHandlers
  {

    public virtual void ResolutionGroupCreated(Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      _obj.Save();
      Functions.DocumentReviewTask.FillDraftResolutionProperties(DocumentReviewTasks.As(_obj.Task),
                                                                 _obj.DocumentForReviewGroup.OfficialDocuments.FirstOrDefault(),
                                                                 _obj.AddendaGroup.OfficialDocuments.Select(x => Sungero.Content.ElectronicDocuments.As(x)).ToList(),
                                                                 _obj.OtherGroup.All.ToList(),
                                                                 ActionItemExecutionTasks.As(e.Attachment));
    }
  }
}