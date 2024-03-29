
// ==================================================================
// FreeApprovalFinishAssignment.g.cs
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
    public class FreeApprovalFinishAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.Docflow.IFreeApprovalFinishAssignment
    {
      protected new global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState filter
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

      public FreeApprovalFinishAssignmentFilter(global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected FreeApprovalFinishAssignmentFilter()
      {
      }
    }
    public class FreeApprovalFinishAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
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





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.FreeApprovalFinishAssignmentFilter<global::Sungero.Docflow.IFreeApprovalFinishAssignment>))]

  public class FreeApprovalFinishAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.Docflow.IFreeApprovalFinishAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("d3277007-c49f-4aaa-a0f7-e397fa4fb9fc");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.FreeApprovalFinishAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IFreeApprovalFinishAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalFinishAssignmentState State
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentState(this);
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalFinishAssignmentInfo Info
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalFinishAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.FreeApprovalFinishAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.FreeApprovalFinishAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.FreeApprovalFinishAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.FreeApprovalFinishAssignmentSharedHandlers(this);
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.Docflow.FreeApprovalFinishAssignment.Result),
      typeof(global::Sungero.Docflow.Server.FreeApprovalFinishAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.Docflow.Server.FreeApprovalFinishAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.Docflow.Server.FreeApprovalFinishAssignment.ResultItems; }
    }






    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.FreeApprovalFinishAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IFreeApprovalFinishAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.FreeApprovalFinishAssignmentCreatingFromServerHandler((global::Sungero.Docflow.IFreeApprovalFinishAssignment)entitySource, this.Info);
    }

    #region Framework events



    #endregion


    public FreeApprovalFinishAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IFreeApprovalFinishAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalFinishAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalFinishAssignmentForApprovalGroupAttachments ForApprovalGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentForApprovalGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.IFreeApprovalFinishAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// FreeApprovalFinishAssignmentHandlers.g.cs
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

  public partial class FreeApprovalFinishAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IFreeApprovalFinishAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public FreeApprovalFinishAssignmentFilteringServerHandler(global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected FreeApprovalFinishAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class FreeApprovalFinishAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.FreeApprovalFinishAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.FreeApprovalFinishAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public FreeApprovalFinishAssignmentSearchDialogServerHandler(global::Sungero.Docflow.Server.FreeApprovalFinishAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class FreeApprovalFinishAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalFinishAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignment)this.Entity; }
    }

    public FreeApprovalFinishAssignmentServerHandlers(global::Sungero.Docflow.IFreeApprovalFinishAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class FreeApprovalFinishAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IFreeApprovalFinishAssignment _source
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignment)this.Source; }
    }

    private global::Sungero.Docflow.IFreeApprovalFinishAssignmentInfo _info
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentInfo)this._Info; }
    }

    public FreeApprovalFinishAssignmentCreatingFromServerHandler(global::Sungero.Docflow.IFreeApprovalFinishAssignment source, global::Sungero.Docflow.IFreeApprovalFinishAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// FreeApprovalFinishAssignmentEventArgs.g.cs
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
// FreeApprovalFinishAssignmentAccessRights.g.cs
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
  public class FreeApprovalFinishAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.Docflow.IFreeApprovalFinishAssignmentAccessRights
  {

    public FreeApprovalFinishAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class FreeApprovalFinishAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.Docflow.IFreeApprovalFinishAssignmentAccessRights
  {

    public FreeApprovalFinishAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentRepositoryImplementer.g.cs
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
    public class FreeApprovalFinishAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.IFreeApprovalFinishAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IFreeApprovalFinishAssignment 
    {
       public new global::Sungero.Docflow.IFreeApprovalFinishAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IFreeApprovalFinishAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.FreeApprovalFinishAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// FreeApprovalFinishAssignmentPanelNavigationFilters.g.cs
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
// FreeApprovalFinishAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class FreeApprovalFinishAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalFinishAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignment)this.Entity; }
    }

    public FreeApprovalFinishAssignmentFunctions(global::Sungero.Docflow.IFreeApprovalFinishAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentFunctions.g.cs
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
  internal static class FreeApprovalFinishAssignment
  {
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentServerPublicFunctions.g.cs
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
  public class FreeApprovalFinishAssignmentServerPublicFunctions : global::Sungero.Docflow.Server.IFreeApprovalFinishAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentQueries.g.cs
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
  public class FreeApprovalFinishAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.FreeApprovalFinishAssignment.FreeApprovalFinishAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentBlock.g.cs
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
  public class FreeApprovalFinishAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<FreeApprovalFinishAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public FreeApprovalFinishAssignmentArguments(FreeApprovalFinishAssignmentBlock block) : base(block) { }
  }

  public class FreeApprovalFinishAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<FreeApprovalFinishAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.Docflow.IFreeApprovalFinishAssignment> 
  {
    public FreeApprovalFinishAssignmentEndBlockEventArguments(FreeApprovalFinishAssignmentBlock block) : base(block) { }
  }

  public partial class FreeApprovalFinishAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {



    public FreeApprovalFinishAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentChildWrappers.g.cs
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
