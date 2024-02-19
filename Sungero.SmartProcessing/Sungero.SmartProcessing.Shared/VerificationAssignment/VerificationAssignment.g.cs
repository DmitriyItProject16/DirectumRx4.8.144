
// ==================================================================
// VerificationAssignmentState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class VerificationAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.SmartProcessing.IVerificationAssignmentState
  {
    public VerificationAssignmentState(global::Sungero.SmartProcessing.IVerificationAssignment entity) : base(entity) { }

    public new global::Sungero.SmartProcessing.IVerificationAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentPropertyStates(entity);
    }


    public new global::Sungero.SmartProcessing.IVerificationAssignmentControlStates Controls
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentControlStates(entity);
    }

    public new global::Sungero.SmartProcessing.IVerificationAssignmentPageStates Pages
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.SmartProcessing.IVerificationAssignmentAttachmentStates Attachments { get { return (global::Sungero.SmartProcessing.IVerificationAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new VerificationAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class VerificationAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.SmartProcessing.IVerificationAssignmentAttachmentStates
    {

      protected internal VerificationAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class VerificationAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.SmartProcessing.IVerificationAssignmentControlStates
  {

    protected internal VerificationAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class VerificationAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.SmartProcessing.IVerificationAssignmentPageStates
  {

    protected internal VerificationAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class VerificationAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.SmartProcessing.IVerificationAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Addressee 
            {
              get { return this.InternalAddressee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAddressee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Addressee"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> NewDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("NewDeadline"); }
            }


    protected internal VerificationAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// VerificationAssignmentInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class VerificationAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.SmartProcessing.IVerificationAssignmentInfo
  {
    public VerificationAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.SmartProcessing.IVerificationAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.SmartProcessing.IVerificationAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentActionsInfo(entityType);
    }
  }

  public class VerificationAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.SmartProcessing.IVerificationAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Addressee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Addressee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo NewDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("NewDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }


    protected internal VerificationAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class VerificationAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.SmartProcessing.IVerificationAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Complete 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Complete")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Forward 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Forward")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo SendForApproval 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("SendForApproval")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo SendForFreeApproval 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("SendForFreeApproval")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo SendForReview 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("SendForReview")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo SendForExecution 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("SendForExecution")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo DeleteDocuments 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("DeleteDocuments")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ShowInvalidDocuments 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ShowInvalidDocuments")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Repacking 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Repacking")); }
        }


    protected internal VerificationAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// VerificationAssignmentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{
  public partial class VerificationAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, IVerificationAssignmentSharedHandlers
  {
    private global::Sungero.SmartProcessing.IVerificationAssignment _obj
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignment)this.Entity; }
    }
    public virtual void AddresseeChanged(global::Sungero.SmartProcessing.Shared.VerificationAssignmentAddresseeChangedEventArgs e) { }


    public virtual void NewDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }



    #region Workflow attachments extention


    #endregion

    public VerificationAssignmentSharedHandlers(global::Sungero.SmartProcessing.IVerificationAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// VerificationAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared.VerificationAssignment
{
  /// <summary>
  /// Represents VerificationAssignment resources.
  /// </summary>
  public class VerificationAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.SmartProcessing.VerificationAssignment.IVerificationAssignmentResources
  {
    public virtual global::CommonLibrary.LocalizedString ImpossibleSpecifyDeadlineLessThenToday
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "ImpossibleSpecifyDeadlineLessThenToday");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ImpossibleSpecifyDeadlineLessThenTodayFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "ImpossibleSpecifyDeadlineLessThenToday", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogTitle
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "DeleteDocumentsDialogTitle");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogTitleFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "DeleteDocumentsDialogTitle", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogText
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "DeleteDocumentsDialogText");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogTextFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "DeleteDocumentsDialogText", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogAttachments
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "DeleteDocumentsDialogAttachments");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogAttachmentsFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "DeleteDocumentsDialogAttachments", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogNoticeAfterDelete
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "DeleteDocumentsDialogNoticeAfterDelete");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogNoticeAfterDeleteFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "DeleteDocumentsDialogNoticeAfterDelete", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InstructionStep1
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InstructionStep1");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InstructionStep1Format(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InstructionStep1", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InstructionStep2
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InstructionStep2");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InstructionStep2Format(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InstructionStep2", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InstructionStep3
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InstructionStep3");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InstructionStep3Format(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InstructionStep3", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InstructionStep4
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InstructionStep4");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InstructionStep4Format(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InstructionStep4", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InstructionStep5
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InstructionStep5");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InstructionStep5Format(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InstructionStep5", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InstructionStep6
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InstructionStep6");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InstructionStep6Format(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InstructionStep6", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InstructionStep7
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InstructionStep7");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InstructionStep7Format(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InstructionStep7", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InvalidDocumentWhenSendInWork
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InvalidDocumentWhenSendInWork");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InvalidDocumentWhenSendInWorkFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InvalidDocumentWhenSendInWork", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString InvalidDocumentWhenCompleted
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "InvalidDocumentWhenCompleted");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InvalidDocumentWhenCompletedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "InvalidDocumentWhenCompleted", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString AttachedDocumentsLocked
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "AttachedDocumentsLocked");
      }
    }

    public virtual global::CommonLibrary.LocalizedString AttachedDocumentsLockedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "AttachedDocumentsLocked", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString NoDocumentsSuitableForRepacking
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "NoDocumentsSuitableForRepacking");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NoDocumentsSuitableForRepackingFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "NoDocumentsSuitableForRepacking", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString RepackingIsInProgress
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "RepackingIsInProgress");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RepackingIsInProgressFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "RepackingIsInProgress", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString SaveAssignmentBeforeRepacking
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "SaveAssignmentBeforeRepacking");
      }
    }

    public virtual global::CommonLibrary.LocalizedString SaveAssignmentBeforeRepackingFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "SaveAssignmentBeforeRepacking", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString NoLicenseToRepacking
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "NoLicenseToRepacking");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NoLicenseToRepackingFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "NoLicenseToRepacking", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ShowRepackingResultsNotification
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "ShowRepackingResultsNotification");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ShowRepackingResultsNotificationFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "ShowRepackingResultsNotification", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString CompleteWithActiveRepackingSession
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "CompleteWithActiveRepackingSession");
      }
    }

    public virtual global::CommonLibrary.LocalizedString CompleteWithActiveRepackingSessionFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "CompleteWithActiveRepackingSession", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogImpossible
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment) , "DeleteDocumentsDialogImpossible");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeleteDocumentsDialogImpossibleFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IVerificationAssignment), "DeleteDocumentsDialogImpossible", false, args);
    }

  }
}

// ==================================================================
// VerificationAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Shared
{
  public partial class VerificationAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.SmartProcessing.IVerificationAssignment _obj
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignment)this.Entity; }
    }

    public VerificationAssignmentFunctions(global::Sungero.SmartProcessing.IVerificationAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// VerificationAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Functions
{
  internal static class VerificationAssignment
  {
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  global::System.String GetInstruction(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetInstruction", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> GetDocumentsSuitableForRepacking(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentsSuitableForRepacking", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> GetOrderedDocuments(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetOrderedDocuments", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetEncryptedDocuments(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEncryptedDocuments", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetInaccesssibleDocuments(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetInaccesssibleDocuments", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetNotSuitableExtensionDocuments(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetNotSuitableExtensionDocuments", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetDocumentsWithoutVersion(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentsWithoutVersion", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetDocumentsWithoutBody(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentsWithoutBody", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  void LogDocumentsSuitableForRepackingFilter(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, global::System.String name, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("LogDocumentsSuitableForRepackingFilter", new System.Type[] { typeof(global::System.String), typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { name, documents });
    }

  }
}

// ==================================================================
// VerificationAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Shared.VerificationAssignment
{

  public class VerificationAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.SmartProcessing.IVerificationAssignmentFilterInfo
  {
  }

  public class VerificationAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.SmartProcessing.IVerificationAssignmentFilterState
  {



    public new Sungero.SmartProcessing.IVerificationAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.SmartProcessing.IVerificationAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.SmartProcessing.Shared.VerificationAssignment.VerificationAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// VerificationAssignmentSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class VerificationAssignmentSharedPublicFunctions : global::Sungero.SmartProcessing.Shared.IVerificationAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// VerificationAssignmentAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
}

// ==================================================================
// VerificationAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.VerificationAssignment
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
}

    public static class TaskExtensions
    {
      /// <summary>
      /// Получить версию схемы запущенной задачи.
      /// </summary>
      /// <param name="task">Задача.</param>
      /// <returns>Версия схемы запущенной задачи.</returns>
      public static global::Sungero.Workflow.Shared.ExtendedSchemeVersion GetStartedSchemeVersion(this global::Sungero.Workflow.ITask task)
      {
        return global::Sungero.Workflow.Shared.OverriddenTaskHelper.FindLayerSchemeVersionForTask(task,
          global::System.Guid.Parse("999a5ae0-17ec-4735-bc90-d85c7fe08dd3"));
      }
    }

}
