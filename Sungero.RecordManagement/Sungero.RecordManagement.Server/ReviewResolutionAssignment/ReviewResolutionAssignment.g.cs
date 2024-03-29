
// ==================================================================
// ReviewResolutionAssignment.g.cs
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
    public class ReviewResolutionAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.RecordManagement.IReviewResolutionAssignment
    {
      protected new global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState Filter { get; private set; }

      private global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState filter
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

      public ReviewResolutionAssignmentFilter(global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ReviewResolutionAssignmentFilter()
      {
      }
    }
    public class ReviewResolutionAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
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





  [global::Sungero.Domain.Filter(typeof(global::Sungero.RecordManagement.Server.ReviewResolutionAssignmentFilter<global::Sungero.RecordManagement.IReviewResolutionAssignment>))]

  public class ReviewResolutionAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.RecordManagement.IReviewResolutionAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("018e582e-5b0e-4e4f-af57-be1e0a468efa");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.ReviewResolutionAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IReviewResolutionAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentState State
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentState(this);
    }

    public new virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo Info
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Server.ReviewResolutionAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.RecordManagement.Server.ReviewResolutionAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ReviewResolutionAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ReviewResolutionAssignmentSharedHandlers(this);
    }



    private global::System.String _ResolutionText;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::System.String ResolutionText
    {
      get
      {
        return this._ResolutionText;
      }

      set
      {
        this.SetPropertyValue("ResolutionText", this._ResolutionText, value, (propertyValue) => { this._ResolutionText = propertyValue; }, this.ResolutionTextChangedHandler);
      }
    }




    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.RecordManagement.ReviewResolutionAssignment.Result),
      typeof(global::Sungero.RecordManagement.Server.ReviewResolutionAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.RecordManagement.Server.ReviewResolutionAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.RecordManagement.Server.ReviewResolutionAssignment.ResultItems; }
    }






    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.RecordManagement.ReviewResolutionAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.RecordManagement.IReviewResolutionAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.RecordManagement.ReviewResolutionAssignmentCreatingFromServerHandler((global::Sungero.RecordManagement.IReviewResolutionAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void ResolutionTextChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ResolutionText, this.ResolutionText, this);
     ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionTextChanged(args);
    }



    #endregion


    public ReviewResolutionAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentResolutionGroupAttachments ResolutionGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentResolutionGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewResolutionAssignmentDocumentForReviewGroupAttachments DocumentForReviewGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewResolutionAssignmentDocumentForReviewGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ReviewResolutionAssignmentHandlers.g.cs
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

  public partial class ReviewResolutionAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.RecordManagement.IReviewResolutionAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ReviewResolutionAssignmentFilteringServerHandler(global::Sungero.RecordManagement.IReviewResolutionAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ReviewResolutionAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ReviewResolutionAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.RecordManagement.Server.ReviewResolutionAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.RecordManagement.Server.ReviewResolutionAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public ReviewResolutionAssignmentSearchDialogServerHandler(global::Sungero.RecordManagement.Server.ReviewResolutionAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ReviewResolutionAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.RecordManagement.IReviewResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignment)this.Entity; }
    }

    public ReviewResolutionAssignmentServerHandlers(global::Sungero.RecordManagement.IReviewResolutionAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ReviewResolutionAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.RecordManagement.IReviewResolutionAssignment _source
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignment)this.Source; }
    }

    private global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo _info
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo)this._Info; }
    }

    public ReviewResolutionAssignmentCreatingFromServerHandler(global::Sungero.RecordManagement.IReviewResolutionAssignment source, global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ReviewResolutionAssignmentEventArgs.g.cs
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
// ReviewResolutionAssignmentAccessRights.g.cs
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
  public class ReviewResolutionAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights
  {

    public ReviewResolutionAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReviewResolutionAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights
  {

    public ReviewResolutionAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ReviewResolutionAssignmentRepositoryImplementer.g.cs
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
    public class ReviewResolutionAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IReviewResolutionAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IReviewResolutionAssignment 
    {
       public new global::Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IReviewResolutionAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Server.ReviewResolutionAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReviewResolutionAssignmentPanelNavigationFilters.g.cs
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
// ReviewResolutionAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Server
{
  public partial class ReviewResolutionAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IReviewResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewResolutionAssignment)this.Entity; }
    }

    public ReviewResolutionAssignmentFunctions(global::Sungero.RecordManagement.IReviewResolutionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewResolutionAssignmentFunctions.g.cs
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
  internal static class ReviewResolutionAssignment
  {
  }
}

// ==================================================================
// ReviewResolutionAssignmentServerPublicFunctions.g.cs
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
  public class ReviewResolutionAssignmentServerPublicFunctions : global::Sungero.RecordManagement.Server.IReviewResolutionAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// ReviewResolutionAssignmentQueries.g.cs
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
  public class ReviewResolutionAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.ReviewResolutionAssignment.ReviewResolutionAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ReviewResolutionAssignmentBlock.g.cs
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
  public class ReviewResolutionAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<ReviewResolutionAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public ReviewResolutionAssignmentArguments(ReviewResolutionAssignmentBlock block) : base(block) { }
  }

  public class ReviewResolutionAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<ReviewResolutionAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.RecordManagement.IReviewResolutionAssignment> 
  {
    public ReviewResolutionAssignmentEndBlockEventArguments(ReviewResolutionAssignmentBlock block) : base(block) { }
  }

  public partial class ReviewResolutionAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {



    public ReviewResolutionAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// ReviewResolutionAssignmentChildWrappers.g.cs
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
