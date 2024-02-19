
// ==================================================================
// CheckReturnAssignment.g.cs
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
    public class CheckReturnAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.Docflow.ICheckReturnAssignment
    {
      protected new global::Sungero.Docflow.ICheckReturnAssignmentFilterState Filter { get; private set; }

      private global::Sungero.Docflow.ICheckReturnAssignmentFilterState filter
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

      public CheckReturnAssignmentFilter(global::Sungero.Docflow.ICheckReturnAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected CheckReturnAssignmentFilter()
      {
      }
    }
    public class CheckReturnAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
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





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.CheckReturnAssignmentFilter<global::Sungero.Docflow.ICheckReturnAssignment>))]

  public class CheckReturnAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.Docflow.ICheckReturnAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c9cff422-0936-4dd4-906d-a2fd487e5c2f");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.CheckReturnAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ICheckReturnAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.ICheckReturnAssignmentState State
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentState(this);
    }

    public new virtual global::Sungero.Docflow.ICheckReturnAssignmentInfo Info
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.ICheckReturnAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.CheckReturnAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.CheckReturnAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.CheckReturnAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.CheckReturnAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.CheckReturnAssignmentSharedHandlers(this);
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.Docflow.CheckReturnAssignment.Result),
      typeof(global::Sungero.Docflow.Server.CheckReturnAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.Docflow.Server.CheckReturnAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.Docflow.Server.CheckReturnAssignment.ResultItems; }
    }






    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.CheckReturnAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.ICheckReturnAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.CheckReturnAssignmentCreatingFromServerHandler((global::Sungero.Docflow.ICheckReturnAssignment)entitySource, this.Info);
    }

    #region Framework events



    #endregion


    public CheckReturnAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.Docflow.ICheckReturnAssignmentDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.CheckReturnAssignmentDocumentGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }

    }
    #endregion


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

  public partial class CheckReturnAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.ICheckReturnAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.ICheckReturnAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.ICheckReturnAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public CheckReturnAssignmentFilteringServerHandler(global::Sungero.Docflow.ICheckReturnAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected CheckReturnAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class CheckReturnAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.CheckReturnAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.CheckReturnAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public CheckReturnAssignmentSearchDialogServerHandler(global::Sungero.Docflow.Server.CheckReturnAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class CheckReturnAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.Docflow.ICheckReturnAssignment _obj
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignment)this.Entity; }
    }

    public CheckReturnAssignmentServerHandlers(global::Sungero.Docflow.ICheckReturnAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class CheckReturnAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.Docflow.ICheckReturnAssignment _source
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignment)this.Source; }
    }

    private global::Sungero.Docflow.ICheckReturnAssignmentInfo _info
    {
      get { return (global::Sungero.Docflow.ICheckReturnAssignmentInfo)this._Info; }
    }

    public CheckReturnAssignmentCreatingFromServerHandler(global::Sungero.Docflow.ICheckReturnAssignment source, global::Sungero.Docflow.ICheckReturnAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// CheckReturnAssignmentEventArgs.g.cs
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
// CheckReturnAssignmentAccessRights.g.cs
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
  public class CheckReturnAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.Docflow.ICheckReturnAssignmentAccessRights
  {

    public CheckReturnAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CheckReturnAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.Docflow.ICheckReturnAssignmentAccessRights
  {

    public CheckReturnAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// CheckReturnAssignmentRepositoryImplementer.g.cs
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
    public class CheckReturnAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.ICheckReturnAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.ICheckReturnAssignment 
    {
       public new global::Sungero.Docflow.ICheckReturnAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.ICheckReturnAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.ICheckReturnAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.ICheckReturnAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.CheckReturnAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CheckReturnAssignmentPanelNavigationFilters.g.cs
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
// CheckReturnAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class CheckReturnAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
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
// CheckReturnAssignmentServerPublicFunctions.g.cs
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
  public class CheckReturnAssignmentServerPublicFunctions : global::Sungero.Docflow.Server.ICheckReturnAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// CheckReturnAssignmentQueries.g.cs
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
  public class CheckReturnAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.CheckReturnAssignment.CheckReturnAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// CheckReturnAssignmentBlock.g.cs
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
  public class CheckReturnAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<CheckReturnAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public CheckReturnAssignmentArguments(CheckReturnAssignmentBlock block) : base(block) { }
  }

  public class CheckReturnAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<CheckReturnAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.Docflow.ICheckReturnAssignment> 
  {
    public CheckReturnAssignmentEndBlockEventArguments(CheckReturnAssignmentBlock block) : base(block) { }
  }

  public partial class CheckReturnAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {



    public CheckReturnAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// CheckReturnAssignmentChildWrappers.g.cs
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