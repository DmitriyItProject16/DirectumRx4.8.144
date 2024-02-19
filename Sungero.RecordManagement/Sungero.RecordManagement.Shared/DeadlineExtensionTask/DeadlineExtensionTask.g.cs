
// ==================================================================
// DeadlineExtensionTaskState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class DeadlineExtensionTaskState : 
    global::Sungero.Workflow.Shared.TaskState, global::Sungero.RecordManagement.IDeadlineExtensionTaskState
  {
    public DeadlineExtensionTaskState(global::Sungero.RecordManagement.IDeadlineExtensionTask entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IDeadlineExtensionTaskAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new DeadlineExtensionTaskAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class DeadlineExtensionTaskAttachmentStates :
      global::Sungero.Workflow.Shared.TaskAttachmentStates, global::Sungero.RecordManagement.IDeadlineExtensionTaskAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentsGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("431d8004-a022-415b-b622-917af0d570bb"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("40dc1024-52c0-4a37-bd51-eb03d9b963e3"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("016ebd36-1503-4a7a-ab6e-4b4bbd2a94a7"));
        }
      }


      protected internal DeadlineExtensionTaskAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class DeadlineExtensionTaskControlStates : 
    global::Sungero.Workflow.Shared.TaskControlStates, global::Sungero.RecordManagement.IDeadlineExtensionTaskControlStates
  {
        public global::Sungero.Domain.Shared.IControlState Control
        {
        get { return this.GetControlState(global::System.Guid.Parse("e11dfa66-70b9-4716-8394-0aeba09ff5b2")); }
        }


    protected internal DeadlineExtensionTaskControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class DeadlineExtensionTaskPageStates : 
    global::Sungero.Workflow.Shared.TaskPageStates, global::Sungero.RecordManagement.IDeadlineExtensionTaskPageStates
  {
        public global::Sungero.Domain.Shared.IInplacePageState State
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IInplacePageState>("State"); }
        }


    protected internal DeadlineExtensionTaskPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DeadlineExtensionTaskPropertyStates : 
    global::Sungero.Workflow.Shared.TaskPropertyStates, global::Sungero.RecordManagement.IDeadlineExtensionTaskPropertyStates
  {
            public new global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversCollectionPropertyState<global::Sungero.RecordManagement.IDeadlineExtensionTaskObservers> Observers
            {
              get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversCollectionPropertyState<global::Sungero.RecordManagement.IDeadlineExtensionTaskObservers>)base.Observers; }
            }

            protected override global::Sungero.Workflow.ITaskObserversCollectionPropertyState<global::Sungero.Workflow.ITaskObservers> CreateObserversState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskObserversCollectionPropertyState<global::Sungero.RecordManagement.IDeadlineExtensionTaskObservers>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IUser> Assignee 
            {
              get { return this.InternalAssignee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IUser> InternalAssignee
            {
              get { return this.GetPropertyState<global::Sungero.CoreEntities.IUser>("Assignee"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> NewDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("NewDeadline"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> CurrentDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("CurrentDeadline"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState RejectionReason 
            {
              get { return this.GetDataPropertyState("RejectionReason"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState ActionItem 
            {
              get { return this.GetDataPropertyState("ActionItem"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState PrimaryReason 
            {
              get { return this.GetDataPropertyState("PrimaryReason"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState Reason 
            {
              get { return this.GetDataPropertyState("Reason"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IActionItemExecutionAssignment> ActionItemExecutionAssignment 
            {
              get { return this.InternalActionItemExecutionAssignment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IActionItemExecutionAssignment> InternalActionItemExecutionAssignment
            {
              get { return this.GetPropertyState<global::Sungero.RecordManagement.IActionItemExecutionAssignment>("ActionItemExecutionAssignment"); }
            }


    protected internal DeadlineExtensionTaskPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// DeadlineExtensionTaskInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class DeadlineExtensionTaskInfo : 
    global::Sungero.Workflow.Shared.TaskInfo, global::Sungero.RecordManagement.IDeadlineExtensionTaskInfo
  {
    public DeadlineExtensionTaskInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskPropertiesInfo(entityType);
    }

  }

  public class DeadlineExtensionTaskPropertiesInfo : 
    global::Sungero.Workflow.Shared.TaskPropertiesInfo, global::Sungero.RecordManagement.IDeadlineExtensionTaskPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversPropertiesInfo> Observers
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Observers");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.CoreEntities.IUserInfo, global::Sungero.CoreEntities.IUser> Assignee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Assignee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.CoreEntities.IUserInfo, global::Sungero.CoreEntities.IUser>(propertyMetadata);
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
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo CurrentDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("CurrentDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo RejectionReason 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("RejectionReason");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo ActionItem 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("ActionItem");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo PrimaryReason 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("PrimaryReason");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo Reason 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("Reason");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.RecordManagement.IActionItemExecutionAssignmentInfo, global::Sungero.RecordManagement.IActionItemExecutionAssignment> ActionItemExecutionAssignment 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ActionItemExecutionAssignment");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.RecordManagement.IActionItemExecutionAssignmentInfo, global::Sungero.RecordManagement.IActionItemExecutionAssignment>(propertyMetadata);
          }
        }


    protected internal DeadlineExtensionTaskPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// DeadlineExtensionTaskHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{
  public partial class DeadlineExtensionTaskSharedHandlers : global::Sungero.Workflow.TaskSharedHandlers, IDeadlineExtensionTaskSharedHandlers
  {
    private global::Sungero.RecordManagement.IDeadlineExtensionTask _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTask)this.Entity; }
    }
    public virtual void AssigneeChanged(global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskAssigneeChangedEventArgs e) { }


    public virtual void NewDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void CurrentDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void RejectionReasonChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }


    public virtual void ActionItemChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }


    public virtual void PrimaryReasonChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }


    public virtual void ReasonChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }


    public virtual void ActionItemExecutionAssignmentChanged(global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskActionItemExecutionAssignmentChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void DocumentsGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public DeadlineExtensionTaskSharedHandlers(global::Sungero.RecordManagement.IDeadlineExtensionTask entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DeadlineExtensionTaskResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.DeadlineExtensionTask
{
  /// <summary>
  /// Represents DeadlineExtensionTask resources.
  /// </summary>
  public class DeadlineExtensionTaskResources : global::Sungero.Workflow.Shared.Task.TaskResources, global::Sungero.RecordManagement.DeadlineExtensionTask.IDeadlineExtensionTaskResources
  {
    public virtual global::CommonLibrary.LocalizedString RequestExtensionDeadline
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask) , "RequestExtensionDeadline");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RequestExtensionDeadlineFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask), "RequestExtensionDeadline", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ExtensionDeadlineDenied
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask) , "ExtensionDeadlineDenied");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ExtensionDeadlineDeniedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask), "ExtensionDeadlineDenied", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ExtensionDeadline
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask) , "ExtensionDeadline");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ExtensionDeadlineFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask), "ExtensionDeadline", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString SpecifyReason
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask) , "SpecifyReason");
      }
    }

    public virtual global::CommonLibrary.LocalizedString SpecifyReasonFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask), "SpecifyReason", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DesiredDeadlineIsNotCorrect
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask) , "DesiredDeadlineIsNotCorrect");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DesiredDeadlineIsNotCorrectFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask), "DesiredDeadlineIsNotCorrect", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ImpossibleSpecifyDeadlineToNotWorkingDay
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask) , "ImpossibleSpecifyDeadlineToNotWorkingDay");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ImpossibleSpecifyDeadlineToNotWorkingDayFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask), "ImpossibleSpecifyDeadlineToNotWorkingDay", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ExtendDeadlineTaskSubject
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask) , "ExtendDeadlineTaskSubject");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ExtendDeadlineTaskSubjectFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineExtensionTask), "ExtendDeadlineTaskSubject", false, args);
    }

  }
}

// ==================================================================
// DeadlineExtensionTaskSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class DeadlineExtensionTaskFunctions : global::Sungero.Workflow.Shared.TaskFunctions
  {
    private global::Sungero.RecordManagement.IDeadlineExtensionTask _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTask)this.Entity; }
    }

    public DeadlineExtensionTaskFunctions(global::Sungero.RecordManagement.IDeadlineExtensionTask entity) : base(entity) { }
  }
}

// ==================================================================
// DeadlineExtensionTaskFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Functions
{
  internal static class DeadlineExtensionTask
  {
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DeadlineExtensionTaskFunctions" />
    internal static  global::System.String GetDeadlineExtensionSubject(global::Sungero.RecordManagement.IDeadlineExtensionTask task, CommonLibrary.LocalizedString beginningSubject)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.Shared.DeadlineExtensionTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDeadlineExtensionSubject",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.RecordManagement.IDeadlineExtensionTask), typeof(CommonLibrary.LocalizedString) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { task, beginningSubject });
      }
      else
      {
        return global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskFunctions.GetDeadlineExtensionSubject(task, beginningSubject);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DeadlineExtensionTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IDeadlineExtensionTask deadlineExtensionTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("67b46acc-07a9-43ed-86dc-8f9dc3ccf12f"),
          "GetStateView(global::Sungero.RecordManagement.IDeadlineExtensionTask)"
          , deadlineExtensionTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DeadlineExtensionTaskFunctions" />
      internal static  global::Sungero.RecordManagement.IDeadlineExtensionTask GetDeadlineExtension(global::Sungero.RecordManagement.IActionItemExecutionAssignment executionAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.RecordManagement.IDeadlineExtensionTask>(
          global::System.Guid.Parse("67b46acc-07a9-43ed-86dc-8f9dc3ccf12f"),
          "GetDeadlineExtension(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
      , executionAssignment);
      }

    }
  }
}

// ==================================================================
// DeadlineExtensionTaskFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.DeadlineExtensionTask
{

  public class DeadlineExtensionTaskFilterInfo : global::Sungero.Workflow.Shared.Task.TaskFilterInfo,
    global::Sungero.RecordManagement.IDeadlineExtensionTaskFilterInfo
  {
  }

  public class DeadlineExtensionTaskFilterState : global::Sungero.Workflow.Shared.Task.TaskFilterState,
    global::Sungero.RecordManagement.IDeadlineExtensionTaskFilterState
  {



    public new Sungero.RecordManagement.IDeadlineExtensionTaskFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IDeadlineExtensionTaskFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.DeadlineExtensionTask.DeadlineExtensionTaskFilterInfo();
    }

  }
}

// ==================================================================
// DeadlineExtensionTaskSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class DeadlineExtensionTaskSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IDeadlineExtensionTaskSharedPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineExtensionTaskAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{

  public class DeadlineExtensionTaskDocumentsGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineExtensionTaskDocumentsGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public DeadlineExtensionTaskDocumentsGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "431d8004-a022-415b-b622-917af0d570bb") { }
  }

  public class DeadlineExtensionTaskAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineExtensionTaskAddendaGroupAttachments
  {

    public DeadlineExtensionTaskAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "40dc1024-52c0-4a37-bd51-eb03d9b963e3") { }
  }

  public class DeadlineExtensionTaskOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineExtensionTaskOtherGroupAttachments
  {

    public DeadlineExtensionTaskOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "016ebd36-1503-4a7a-ab6e-4b4bbd2a94a7") { }
  }

}

// ==================================================================
// DeadlineExtensionTaskExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.DeadlineExtensionTask
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
          global::System.Guid.Parse("67b46acc-07a9-43ed-86dc-8f9dc3ccf12f"));
      }
    }

}