
// ==================================================================
// DeadlineRejectionAssignment.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
    public class DeadlineRejectionAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.RecordManagement.IDeadlineRejectionAssignment
    {
      protected new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState Filter { get; private set; }

      private global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState filter
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

      public DeadlineRejectionAssignmentFilter(global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected DeadlineRejectionAssignmentFilter()
      {
      }
    }
    public class DeadlineRejectionAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Subject { get; protected set; }
                  public override global::System.Boolean? HasSubtasksInProcess { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Performer { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Importance { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Deadline { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Result { get; protected set; }



                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> NewDeadline { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> CurrentDeadline { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.RecordManagement.Server.DeadlineRejectionAssignmentFilter<global::Sungero.RecordManagement.IDeadlineRejectionAssignment>))]

  public class DeadlineRejectionAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.RecordManagement.IDeadlineRejectionAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("dea721dd-12f9-498a-93e9-451a1fbfad67");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.DeadlineRejectionAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IDeadlineRejectionAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.RecordManagement.IDeadlineRejectionAssignmentState State
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentState(this);
    }

    public new virtual global::Sungero.RecordManagement.IDeadlineRejectionAssignmentInfo Info
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Server.DeadlineRejectionAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.RecordManagement.Server.DeadlineRejectionAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.DeadlineRejectionAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.DeadlineRejectionAssignmentSharedHandlers(this);
    }

    private global::System.DateTime? _NewDeadline;
    public virtual global::System.DateTime? NewDeadline
    {
      get
      {
        return this._NewDeadline;
      }

      set
      {
        this.SetPropertyValue("NewDeadline", this._NewDeadline, value, (propertyValue) => { this._NewDeadline = propertyValue; }, this.NewDeadlineChangedHandler);
      }
    }
    private global::System.DateTime? _CurrentDeadline;
    public virtual global::System.DateTime? CurrentDeadline
    {
      get
      {
        return this._CurrentDeadline;
      }

      set
      {
        this.SetPropertyValue("CurrentDeadline", this._CurrentDeadline, value, (propertyValue) => { this._CurrentDeadline = propertyValue; }, this.CurrentDeadlineChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.RecordManagement.DeadlineRejectionAssignment.Result),
      typeof(global::Sungero.RecordManagement.Server.DeadlineRejectionAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.RecordManagement.Server.DeadlineRejectionAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.RecordManagement.Server.DeadlineRejectionAssignment.ResultItems; }
    }






    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.RecordManagement.DeadlineRejectionAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.RecordManagement.IDeadlineRejectionAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.RecordManagement.DeadlineRejectionAssignmentCreatingFromServerHandler((global::Sungero.RecordManagement.IDeadlineRejectionAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }

    protected void CurrentDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.CurrentDeadline, this.CurrentDeadline, this);
     ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).CurrentDeadlineChanged(args);
    }



    #endregion


    public DeadlineRejectionAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDeadlineRejectionAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDeadlineRejectionAssignmentDocumentsGroupAttachments DocumentsGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentDocumentsGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IDeadlineRejectionAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// DeadlineRejectionAssignmentHandlers.g.cs
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

  public partial class DeadlineRejectionAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.RecordManagement.IDeadlineRejectionAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DeadlineRejectionAssignmentFilteringServerHandler(global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DeadlineRejectionAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class DeadlineRejectionAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.RecordManagement.Server.DeadlineRejectionAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.RecordManagement.Server.DeadlineRejectionAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public DeadlineRejectionAssignmentSearchDialogServerHandler(global::Sungero.RecordManagement.Server.DeadlineRejectionAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class DeadlineRejectionAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.RecordManagement.IDeadlineRejectionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignment)this.Entity; }
    }

    public DeadlineRejectionAssignmentServerHandlers(global::Sungero.RecordManagement.IDeadlineRejectionAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class DeadlineRejectionAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.RecordManagement.IDeadlineRejectionAssignment _source
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignment)this.Source; }
    }

    private global::Sungero.RecordManagement.IDeadlineRejectionAssignmentInfo _info
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentInfo)this._Info; }
    }

    public DeadlineRejectionAssignmentCreatingFromServerHandler(global::Sungero.RecordManagement.IDeadlineRejectionAssignment source, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// DeadlineRejectionAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}

// ==================================================================
// DeadlineRejectionAssignmentAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class DeadlineRejectionAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.RecordManagement.IDeadlineRejectionAssignmentAccessRights
  {

    public DeadlineRejectionAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DeadlineRejectionAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.RecordManagement.IDeadlineRejectionAssignmentAccessRights
  {

    public DeadlineRejectionAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// DeadlineRejectionAssignmentRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
    public class DeadlineRejectionAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IDeadlineRejectionAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IDeadlineRejectionAssignment 
    {
       public new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Server.DeadlineRejectionAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DeadlineRejectionAssignmentPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}

// ==================================================================
// DeadlineRejectionAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Server
{
  public partial class DeadlineRejectionAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IDeadlineRejectionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignment)this.Entity; }
    }

    public DeadlineRejectionAssignmentFunctions(global::Sungero.RecordManagement.IDeadlineRejectionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// DeadlineRejectionAssignmentFunctions.g.cs
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
  internal static class DeadlineRejectionAssignment
  {
    /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DeadlineRejectionAssignmentFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::Sungero.Core.StateView GetStateView(global::Sungero.RecordManagement.IDeadlineRejectionAssignment deadlineRejectionAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)deadlineRejectionAssignment).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStateView", new System.Type[] {  });
      return (global::Sungero.Core.StateView)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// DeadlineRejectionAssignmentServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class DeadlineRejectionAssignmentServerPublicFunctions : global::Sungero.RecordManagement.Server.IDeadlineRejectionAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineRejectionAssignmentQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Queries
{
  public class DeadlineRejectionAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.DeadlineRejectionAssignment.DeadlineRejectionAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// DeadlineRejectionAssignmentBlock.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class DeadlineRejectionAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<DeadlineRejectionAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public DeadlineRejectionAssignmentArguments(DeadlineRejectionAssignmentBlock block) : base(block) { }
  }

  public class DeadlineRejectionAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<DeadlineRejectionAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.RecordManagement.IDeadlineRejectionAssignment> 
  {
    public DeadlineRejectionAssignmentEndBlockEventArguments(DeadlineRejectionAssignmentBlock block) : base(block) { }
  }

  public partial class DeadlineRejectionAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {
    public virtual global::System.DateTime? NewDeadline
    {
      get { return this.GetCustomProperty<global::System.DateTime?>("NewDeadline"); }
      set { this.SetCustomProperty("NewDeadline", value); }
    }
    public virtual global::System.DateTime? CurrentDeadline
    {
      get { return this.GetCustomProperty<global::System.DateTime?>("CurrentDeadline"); }
      set { this.SetCustomProperty("CurrentDeadline", value); }
    }




    public DeadlineRejectionAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// DeadlineRejectionAssignmentChildWrappers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}
