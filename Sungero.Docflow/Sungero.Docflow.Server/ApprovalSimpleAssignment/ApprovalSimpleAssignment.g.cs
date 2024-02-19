
// ==================================================================
// ApprovalSimpleAssignment.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class ApprovalSimpleAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.Docflow.IApprovalSimpleAssignment
    {
      protected new global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ApprovalSimpleAssignmentFilter(global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ApprovalSimpleAssignmentFilter()
      {
      }
    }
    public class ApprovalSimpleAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Subject { get; protected set; }
                  public override global::System.Boolean? HasSubtasksInProcess { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Performer { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Importance { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Deadline { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Result { get; protected set; }




        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ApprovalSimpleAssignmentFilter<global::Sungero.Docflow.IApprovalSimpleAssignment>))]

  public class ApprovalSimpleAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.Docflow.IApprovalSimpleAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("b0931934-7981-4139-a398-f0e39abbb981");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalSimpleAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalSimpleAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.IApprovalSimpleAssignmentState State
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalSimpleAssignmentState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalSimpleAssignmentInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IApprovalSimpleAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ApprovalSimpleAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ApprovalSimpleAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalSimpleAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalSimpleAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalSimpleAssignmentSharedHandlers(this);
    }

    private global::System.String _StageSubject;
    public virtual global::System.String StageSubject
    {
      get
      {
        return this._StageSubject;
      }

      set
      {
        this.SetPropertyValue("StageSubject", this._StageSubject, value, (propertyValue) => { this._StageSubject = propertyValue; }, this.StageSubjectChangedHandler);
      }
    }
    private global::System.Int32? _StageNumber;
    public virtual global::System.Int32? StageNumber
    {
      get
      {
        return this._StageNumber;
      }

      set
      {
        this.SetPropertyValue("StageNumber", this._StageNumber, value, (propertyValue) => { this._StageNumber = propertyValue; }, this.StageNumberChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.Docflow.ApprovalSimpleAssignment.Result),
      typeof(global::Sungero.Docflow.Server.ApprovalSimpleAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalSimpleAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalSimpleAssignment.ResultItems; }
    }






    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ApprovalSimpleAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IApprovalSimpleAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ApprovalSimpleAssignmentCreatingFromServerHandler((global::Sungero.Docflow.IApprovalSimpleAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void StageSubjectChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.StageSubject, this.StageSubject, this);
     ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).StageSubjectChanged(args);
    }

    protected void StageNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.StageNumber, this.StageNumber, this);
     ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).StageNumberChanged(args);
    }



    #endregion


    public ApprovalSimpleAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IApprovalSimpleAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalSimpleAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalSimpleAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalSimpleAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalSimpleAssignmentDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalSimpleAssignmentDocumentGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalSimpleAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ApprovalSimpleAssignmentHandlers.g.cs
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

  public partial class ApprovalSimpleAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IApprovalSimpleAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalSimpleAssignmentFilteringServerHandler(global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalSimpleAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ApprovalSimpleAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ApprovalSimpleAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ApprovalSimpleAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalSimpleAssignmentSearchDialogServerHandler(global::Sungero.Docflow.Server.ApprovalSimpleAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalSimpleAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.Docflow.IApprovalSimpleAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignment)this.Entity; }
    }

    public ApprovalSimpleAssignmentServerHandlers(global::Sungero.Docflow.IApprovalSimpleAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalSimpleAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IApprovalSimpleAssignment _source
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignment)this.Source; }
    }

    private global::Sungero.Docflow.IApprovalSimpleAssignmentInfo _info
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignmentInfo)this._Info; }
    }

    public ApprovalSimpleAssignmentCreatingFromServerHandler(global::Sungero.Docflow.IApprovalSimpleAssignment source, global::Sungero.Docflow.IApprovalSimpleAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalSimpleAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// ApprovalSimpleAssignmentAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ApprovalSimpleAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.Docflow.IApprovalSimpleAssignmentAccessRights
  {

    public ApprovalSimpleAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalSimpleAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.Docflow.IApprovalSimpleAssignmentAccessRights
  {

    public ApprovalSimpleAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalSimpleAssignmentRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class ApprovalSimpleAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalSimpleAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalSimpleAssignment 
    {
       public new global::Sungero.Docflow.IApprovalSimpleAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalSimpleAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalSimpleAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalSimpleAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ApprovalSimpleAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalSimpleAssignmentPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// ApprovalSimpleAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ApprovalSimpleAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalSimpleAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignment)this.Entity; }
    }

    public ApprovalSimpleAssignmentFunctions(global::Sungero.Docflow.IApprovalSimpleAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalSimpleAssignmentFunctions.g.cs
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
  internal static class ApprovalSimpleAssignment
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalSimpleAssignmentFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::Sungero.Core.StateView GetStagesStateView(global::Sungero.Docflow.IApprovalSimpleAssignment approvalSimpleAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalSimpleAssignment).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStagesStateView", new System.Type[] {  });
      return (global::Sungero.Core.StateView)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ApprovalSimpleAssignmentServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ApprovalSimpleAssignmentServerPublicFunctions : global::Sungero.Docflow.Server.IApprovalSimpleAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalSimpleAssignmentQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class ApprovalSimpleAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.ApprovalSimpleAssignment.ApprovalSimpleAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ApprovalSimpleAssignmentBlock.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ApprovalSimpleAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<ApprovalSimpleAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public ApprovalSimpleAssignmentArguments(ApprovalSimpleAssignmentBlock block) : base(block) { }
  }

  public class ApprovalSimpleAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<ApprovalSimpleAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.Docflow.IApprovalSimpleAssignment> 
  {
    public ApprovalSimpleAssignmentEndBlockEventArguments(ApprovalSimpleAssignmentBlock block) : base(block) { }
  }

  public partial class ApprovalSimpleAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {
    public virtual global::System.String StageSubject
    {
      get { return this.GetCustomProperty<global::System.String>("StageSubject"); }
      set { this.SetCustomProperty("StageSubject", value); }
    }
    public virtual global::System.Int32? StageNumber
    {
      get { return this.GetCustomProperty<global::System.Int32?>("StageNumber"); }
      set { this.SetCustomProperty("StageNumber", value); }
    }




    public ApprovalSimpleAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// ApprovalSimpleAssignmentChildWrappers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}
