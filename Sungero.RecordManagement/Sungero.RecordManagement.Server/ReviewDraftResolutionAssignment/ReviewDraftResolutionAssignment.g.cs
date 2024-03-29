
// ==================================================================
// ReviewDraftResolutionAssignment.g.cs
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
    public class ReviewDraftResolutionAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.RecordManagement.IReviewDraftResolutionAssignment
    {
      protected new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState Filter { get; private set; }

      private global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState filter
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

      public ReviewDraftResolutionAssignmentFilter(global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ReviewDraftResolutionAssignmentFilter()
      {
      }
    }
    public class ReviewDraftResolutionAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
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



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Addressee { get; protected set; }


        }




  public class ReviewDraftResolutionAssignmentFilterForAddressee<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.RecordManagement.IReviewDraftResolutionAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.ReviewDraftResolutionAssignmentAddresseePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("AddresseeFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.RecordManagement.ReviewDraftResolutionAssignmentAddresseePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).AddresseeFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ReviewDraftResolutionAssignmentFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ReviewDraftResolutionAssignmentSearchFilterForAddressee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.ReviewDraftResolutionAssignmentAddresseeSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("AddresseeSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.RecordManagement.ReviewDraftResolutionAssignmentAddresseeSearchPropertyFilteringServerHandler<TQueryEntity>().AddresseeSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ReviewDraftResolutionAssignmentSearchFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentFilter<global::Sungero.RecordManagement.IReviewDraftResolutionAssignment>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentFilterForAddressee<global::Sungero.Company.IEmployee, global::Sungero.RecordManagement.IReviewDraftResolutionAssignment>), "Addressee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentSearchFilterForAddressee<global::Sungero.CoreEntities.IRecipient>), "Addressee")]


  public class ReviewDraftResolutionAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.RecordManagement.IReviewDraftResolutionAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e2dd5bf3-54c8-4846-b158-9c42d09fbc33");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IReviewDraftResolutionAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentState State
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentState(this);
    }

    public new virtual global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentInfo Info
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ReviewDraftResolutionAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ReviewDraftResolutionAssignmentSharedHandlers(this);
    }

    private global::System.Boolean? _NeedDeleteActionItems;
    public virtual global::System.Boolean? NeedDeleteActionItems
    {
      get
      {
        return this._NeedDeleteActionItems;
      }

      set
      {
        this.SetPropertyValue("NeedDeleteActionItems", this._NeedDeleteActionItems, value, (propertyValue) => { this._NeedDeleteActionItems = propertyValue; }, this.NeedDeleteActionItemsChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.RecordManagement.ReviewDraftResolutionAssignment.Result),
      typeof(global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignment.ResultItems; }
    }



    private global::Sungero.Company.IEmployee _Addressee;
    public virtual global::Sungero.Company.IEmployee Addressee
    {
      get
      {
        return this._Addressee;
      }

      set
      {
        this.SetPropertyValue("Addressee", this._Addressee, value, (propertyValue) => { this._Addressee = propertyValue; }, this.AddresseeChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.RecordManagement.ReviewDraftResolutionAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.RecordManagement.ReviewDraftResolutionAssignmentCreatingFromServerHandler((global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }

    protected void NeedDeleteActionItemsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.NeedDeleteActionItems, this.NeedDeleteActionItems, this);
     ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).NeedDeleteActionItemsChanged(args);
    }



    #endregion


    public ReviewDraftResolutionAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentResolutionGroupAttachments ResolutionGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentResolutionGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentDocumentForReviewGroupAttachments DocumentForReviewGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentDocumentForReviewGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewDraftResolutionAssignmentOtherGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentHandlers.g.cs
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
  public partial class ReviewDraftResolutionAssignmentAddresseePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> AddresseeFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ReviewDraftResolutionAssignmentAddresseePropertyFilteringServerHandler(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ReviewDraftResolutionAssignmentAddresseeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> AddresseeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ReviewDraftResolutionAssignmentAddresseeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class ReviewDraftResolutionAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.RecordManagement.IReviewDraftResolutionAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ReviewDraftResolutionAssignmentFilteringServerHandler(global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ReviewDraftResolutionAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ReviewDraftResolutionAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public ReviewDraftResolutionAssignmentSearchDialogServerHandler(global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ReviewDraftResolutionAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Entity; }
    }

    public ReviewDraftResolutionAssignmentServerHandlers(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ReviewDraftResolutionAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _source
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Source; }
    }

    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentInfo _info
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentInfo)this._Info; }
    }

    public ReviewDraftResolutionAssignmentCreatingFromServerHandler(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment source, global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ReviewDraftResolutionAssignmentEventArgs.g.cs
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
// ReviewDraftResolutionAssignmentAccessRights.g.cs
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
  public class ReviewDraftResolutionAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.RecordManagement.IReviewDraftResolutionAssignmentAccessRights
  {

    public ReviewDraftResolutionAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReviewDraftResolutionAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.RecordManagement.IReviewDraftResolutionAssignmentAccessRights
  {

    public ReviewDraftResolutionAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentRepositoryImplementer.g.cs
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
    public class ReviewDraftResolutionAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IReviewDraftResolutionAssignment 
    {
       public new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReviewDraftResolutionAssignmentPanelNavigationFilters.g.cs
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
// ReviewDraftResolutionAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Server
{
  public partial class ReviewDraftResolutionAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Entity; }
    }

    public ReviewDraftResolutionAssignmentFunctions(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentFunctions.g.cs
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
  internal static class ReviewDraftResolutionAssignment
  {
    /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::Sungero.Core.StateView GetStateView(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment reviewDraftResolutionAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)reviewDraftResolutionAssignment).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStateView", new System.Type[] {  });
      return (global::Sungero.Core.StateView)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentServerPublicFunctions.g.cs
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
  public class ReviewDraftResolutionAssignmentServerPublicFunctions : global::Sungero.RecordManagement.Server.IReviewDraftResolutionAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentQueries.g.cs
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
  public class ReviewDraftResolutionAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.ReviewDraftResolutionAssignment.ReviewDraftResolutionAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentBlock.g.cs
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
  public class ReviewDraftResolutionAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<ReviewDraftResolutionAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public ReviewDraftResolutionAssignmentArguments(ReviewDraftResolutionAssignmentBlock block) : base(block) { }
  }

  public class ReviewDraftResolutionAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<ReviewDraftResolutionAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.RecordManagement.IReviewDraftResolutionAssignment> 
  {
    public ReviewDraftResolutionAssignmentEndBlockEventArguments(ReviewDraftResolutionAssignmentBlock block) : base(block) { }
  }

  public partial class ReviewDraftResolutionAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {
    public virtual global::System.Boolean? NeedDeleteActionItems
    {
      get { return this.GetCustomProperty<global::System.Boolean?>("NeedDeleteActionItems"); }
      set { this.SetCustomProperty("NeedDeleteActionItems", value); }
    }

    public virtual global::Sungero.Company.IEmployee Addressee
    {
      get { return this.GetCustomNavigationProperty<global::Sungero.Company.IEmployee>("Addressee"); }
      set { this.SetCustomNavigationProperty("Addressee", value); }
    }




    public ReviewDraftResolutionAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentChildWrappers.g.cs
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
