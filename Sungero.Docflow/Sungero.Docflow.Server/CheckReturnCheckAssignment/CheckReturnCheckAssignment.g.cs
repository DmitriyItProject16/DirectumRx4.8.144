
// ==================================================================
// CheckReturnCheckAssignment.g.cs
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
    public class CheckReturnCheckAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.Docflow.ICheckReturnCheckAssignment
    {
      protected new global::Sungero.Docflow.ICheckReturnCheckAssignmentFilterState Filter { get; private set; }

      private global::Sungero.Docflow.ICheckReturnCheckAssignmentFilterState filter
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

      public CheckReturnCheckAssignmentFilter(global::Sungero.Docflow.ICheckReturnCheckAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected CheckReturnCheckAssignmentFilter()
      {
      }
    }
    public class CheckReturnCheckAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
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




        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.CheckReturnCheckAssignmentFilter<global::Sungero.Docflow.ICheckReturnCheckAssignment>))]

  public class CheckReturnCheckAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.Docflow.ICheckReturnCheckAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0d7f53bd-74bd-42d5-93aa-188ac51e5852");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.CheckReturnCheckAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ICheckReturnCheckAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.ICheckReturnCheckAssignmentState State
    {
      get { return (global::Sungero.Docflow.ICheckReturnCheckAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.CheckReturnCheckAssignmentState(this);
    }

    public new virtual global::Sungero.Docflow.ICheckReturnCheckAssignmentInfo Info
    {
      get { return (global::Sungero.Docflow.ICheckReturnCheckAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.ICheckReturnCheckAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.ICheckReturnCheckAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.CheckReturnCheckAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.CheckReturnCheckAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.CheckReturnCheckAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.CheckReturnCheckAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.CheckReturnCheckAssignmentSharedHandlers(this);
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.Docflow.CheckReturnCheckAssignment.Result),
      typeof(global::Sungero.Docflow.Server.CheckReturnCheckAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.Docflow.Server.CheckReturnCheckAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.Docflow.Server.CheckReturnCheckAssignment.ResultItems; }
    }






    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.CheckReturnCheckAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.ICheckReturnCheckAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.CheckReturnCheckAssignmentCreatingFromServerHandler((global::Sungero.Docflow.ICheckReturnCheckAssignment)entitySource, this.Info);
    }

    #region Framework events



    #endregion


    public CheckReturnCheckAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.Docflow.ICheckReturnCheckAssignmentDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.CheckReturnCheckAssignmentDocumentGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnCheckAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnCheckAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ICheckReturnCheckAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// CheckReturnCheckAssignmentHandlers.g.cs
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

  public partial class CheckReturnCheckAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.ICheckReturnCheckAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.ICheckReturnCheckAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.ICheckReturnCheckAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public CheckReturnCheckAssignmentFilteringServerHandler(global::Sungero.Docflow.ICheckReturnCheckAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected CheckReturnCheckAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class CheckReturnCheckAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.CheckReturnCheckAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.CheckReturnCheckAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public CheckReturnCheckAssignmentSearchDialogServerHandler(global::Sungero.Docflow.Server.CheckReturnCheckAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class CheckReturnCheckAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.Docflow.ICheckReturnCheckAssignment _obj
    {
      get { return (global::Sungero.Docflow.ICheckReturnCheckAssignment)this.Entity; }
    }

    public CheckReturnCheckAssignmentServerHandlers(global::Sungero.Docflow.ICheckReturnCheckAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class CheckReturnCheckAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.Docflow.ICheckReturnCheckAssignment _source
    {
      get { return (global::Sungero.Docflow.ICheckReturnCheckAssignment)this.Source; }
    }

    private global::Sungero.Docflow.ICheckReturnCheckAssignmentInfo _info
    {
      get { return (global::Sungero.Docflow.ICheckReturnCheckAssignmentInfo)this._Info; }
    }

    public CheckReturnCheckAssignmentCreatingFromServerHandler(global::Sungero.Docflow.ICheckReturnCheckAssignment source, global::Sungero.Docflow.ICheckReturnCheckAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// CheckReturnCheckAssignmentEventArgs.g.cs
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
// CheckReturnCheckAssignmentAccessRights.g.cs
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
  public class CheckReturnCheckAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.Docflow.ICheckReturnCheckAssignmentAccessRights
  {

    public CheckReturnCheckAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CheckReturnCheckAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.Docflow.ICheckReturnCheckAssignmentAccessRights
  {

    public CheckReturnCheckAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// CheckReturnCheckAssignmentRepositoryImplementer.g.cs
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
    public class CheckReturnCheckAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.ICheckReturnCheckAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.ICheckReturnCheckAssignment 
    {
       public new global::Sungero.Docflow.ICheckReturnCheckAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.ICheckReturnCheckAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.ICheckReturnCheckAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.ICheckReturnCheckAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.CheckReturnCheckAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CheckReturnCheckAssignmentPanelNavigationFilters.g.cs
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
// CheckReturnCheckAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class CheckReturnCheckAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.Docflow.ICheckReturnCheckAssignment _obj
    {
      get { return (global::Sungero.Docflow.ICheckReturnCheckAssignment)this.Entity; }
    }

    public CheckReturnCheckAssignmentFunctions(global::Sungero.Docflow.ICheckReturnCheckAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// CheckReturnCheckAssignmentFunctions.g.cs
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
  internal static class CheckReturnCheckAssignment
  {
  }
}

// ==================================================================
// CheckReturnCheckAssignmentServerPublicFunctions.g.cs
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
  public class CheckReturnCheckAssignmentServerPublicFunctions : global::Sungero.Docflow.Server.ICheckReturnCheckAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// CheckReturnCheckAssignmentQueries.g.cs
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
  public class CheckReturnCheckAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.CheckReturnCheckAssignment.CheckReturnCheckAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// CheckReturnCheckAssignmentBlock.g.cs
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
  public class CheckReturnCheckAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<CheckReturnCheckAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public CheckReturnCheckAssignmentArguments(CheckReturnCheckAssignmentBlock block) : base(block) { }
  }

  public class CheckReturnCheckAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<CheckReturnCheckAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.Docflow.ICheckReturnCheckAssignment> 
  {
    public CheckReturnCheckAssignmentEndBlockEventArguments(CheckReturnCheckAssignmentBlock block) : base(block) { }
  }

  public partial class CheckReturnCheckAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {



    public CheckReturnCheckAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// CheckReturnCheckAssignmentChildWrappers.g.cs
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
