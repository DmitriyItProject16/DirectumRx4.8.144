
// ==================================================================
// CheckReturnAssignmentState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class CheckReturnAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.Docflow.ICheckReturnAssignmentState
  {
    public CheckReturnAssignmentState(global::Sungero.Docflow.ICheckReturnAssignment entity) : base(entity) { }

    public new global::Sungero.Docflow.ICheckReturnAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.ICheckReturnAssignmentControlStates Controls
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentControlStates(entity);
    }

    public new global::Sungero.Docflow.ICheckReturnAssignmentPageStates Pages
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.Docflow.ICheckReturnAssignmentAttachmentStates Attachments { get { return (global::Sungero.Docflow.ICheckReturnAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new CheckReturnAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class CheckReturnAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.Docflow.ICheckReturnAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("48ec17c0-ec12-4c25-aa67-543d5ae5d12e"));
        }
      }


      protected internal CheckReturnAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class CheckReturnAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.Docflow.ICheckReturnAssignmentControlStates
  {

    protected internal CheckReturnAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class CheckReturnAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.Docflow.ICheckReturnAssignmentPageStates
  {

    protected internal CheckReturnAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CheckReturnAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.Docflow.ICheckReturnAssignmentPropertyStates
  {

    protected internal CheckReturnAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// CheckReturnAssignmentInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class CheckReturnAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.Docflow.ICheckReturnAssignmentInfo
  {
    public CheckReturnAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.ICheckReturnAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.ICheckReturnAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentActionsInfo(entityType);
    }
  }

  public class CheckReturnAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.Docflow.ICheckReturnAssignmentPropertiesInfo
  {

    protected internal CheckReturnAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class CheckReturnAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.Docflow.ICheckReturnAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Complete 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Complete")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ExtendDeadline 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ExtendDeadline")); }
        }


    protected internal CheckReturnAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// CheckReturnAssignmentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{
  public partial class CheckReturnAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers, ICheckReturnAssignmentSharedHandlers
  {
    private global::Sungero.Docflow.ICheckReturnAssignment _obj
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignment)this.Entity; }
    }

    #region Workflow attachments extention

        public virtual void DocumentGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public CheckReturnAssignmentSharedHandlers(global::Sungero.Docflow.ICheckReturnAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CheckReturnAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.CheckReturnAssignment
{
  /// <summary>
  /// Represents CheckReturnAssignment resources.
  /// </summary>
  public class CheckReturnAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.Docflow.CheckReturnAssignment.ICheckReturnAssignmentResources
  {
  }
}

// ==================================================================
// CheckReturnAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class CheckReturnAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.Docflow.ICheckReturnAssignment _obj
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignment)this.Entity; }
    }

    public CheckReturnAssignmentFunctions(global::Sungero.Docflow.ICheckReturnAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// CheckReturnAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class CheckReturnAssignment
  {
  }
}

// ==================================================================
// CheckReturnAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.CheckReturnAssignment
{

  public class CheckReturnAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.Docflow.ICheckReturnAssignmentFilterInfo
  {
  }

  public class CheckReturnAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.Docflow.ICheckReturnAssignmentFilterState
  {



    public new Sungero.Docflow.ICheckReturnAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.ICheckReturnAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.CheckReturnAssignment.CheckReturnAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// CheckReturnAssignmentSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class CheckReturnAssignmentSharedPublicFunctions : global::Sungero.Docflow.Shared.ICheckReturnAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// CheckReturnAssignmentAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{

  public class CheckReturnAssignmentDocumentGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.ICheckReturnAssignmentDocumentGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public CheckReturnAssignmentDocumentGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "48ec17c0-ec12-4c25-aa67-543d5ae5d12e") { }
  }

}

// ==================================================================
// CheckReturnAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.CheckReturnAssignment
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
          global::System.Guid.Parse("af000bfc-7c6a-4308-883a-df6fe4ab7265"));
      }
    }

}