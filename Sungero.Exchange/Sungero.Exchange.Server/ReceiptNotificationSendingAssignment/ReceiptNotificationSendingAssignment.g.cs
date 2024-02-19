
// ==================================================================
// ReceiptNotificationSendingAssignment.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
    public class ReceiptNotificationSendingAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.Exchange.IReceiptNotificationSendingAssignment
    {
      protected new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterState Filter { get; private set; }

      private global::Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterState filter
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

      public ReceiptNotificationSendingAssignmentFilter(global::Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ReceiptNotificationSendingAssignmentFilter()
      {
      }
    }
    public class ReceiptNotificationSendingAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
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



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBusinessUnitBox> Box { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Addressee { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> NewDeadline { get; protected set; }


        }




  public class ReceiptNotificationSendingAssignmentFilterForBox<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.ExchangeCore.IBusinessUnitBox
    where TSourceEntity : class, global::Sungero.Exchange.IReceiptNotificationSendingAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Exchange.ReceiptNotificationSendingAssignmentBoxPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("BoxFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Exchange.ReceiptNotificationSendingAssignmentBoxPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).BoxFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ReceiptNotificationSendingAssignmentFilterForBox(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ReceiptNotificationSendingAssignmentSearchFilterForBox<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.ExchangeCore.IBusinessUnitBox
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Exchange.ReceiptNotificationSendingAssignmentBoxSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("BoxSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Exchange.ReceiptNotificationSendingAssignmentBoxSearchPropertyFilteringServerHandler<TQueryEntity>().BoxSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ReceiptNotificationSendingAssignmentSearchFilterForBox(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ReceiptNotificationSendingAssignmentFilterForAddressee<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Exchange.IReceiptNotificationSendingAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Exchange.ReceiptNotificationSendingAssignmentAddresseePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("AddresseeFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Exchange.ReceiptNotificationSendingAssignmentAddresseePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).AddresseeFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ReceiptNotificationSendingAssignmentFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ReceiptNotificationSendingAssignmentSearchFilterForAddressee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Exchange.ReceiptNotificationSendingAssignmentAddresseeSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("AddresseeSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Exchange.ReceiptNotificationSendingAssignmentAddresseeSearchPropertyFilteringServerHandler<TQueryEntity>().AddresseeSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ReceiptNotificationSendingAssignmentSearchFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentFilter<global::Sungero.Exchange.IReceiptNotificationSendingAssignment>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentFilterForBox<global::Sungero.ExchangeCore.IBusinessUnitBox, global::Sungero.Exchange.IReceiptNotificationSendingAssignment>), "Box")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentSearchFilterForBox<global::Sungero.ExchangeCore.IBusinessUnitBox>), "Box")]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentFilterForAddressee<global::Sungero.Company.IEmployee, global::Sungero.Exchange.IReceiptNotificationSendingAssignment>), "Addressee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentSearchFilterForAddressee<global::Sungero.CoreEntities.IRecipient>), "Addressee")]


  public class ReceiptNotificationSendingAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.Exchange.IReceiptNotificationSendingAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ad88c31d-5ae1-4821-9615-7d2fa575726b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Exchange.IReceiptNotificationSendingAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Exchange.IReceiptNotificationSendingAssignmentState State
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentState(this);
    }

    public new virtual global::Sungero.Exchange.IReceiptNotificationSendingAssignmentInfo Info
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.Exchange.IReceiptNotificationSendingAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Exchange.ReceiptNotificationSendingAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Exchange.ReceiptNotificationSendingAssignmentSharedHandlers(this);
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






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.Exchange.ReceiptNotificationSendingAssignment.Result),
      typeof(global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignment.ResultItems; }
    }



    private global::Sungero.ExchangeCore.IBusinessUnitBox _Box;
    public virtual global::Sungero.ExchangeCore.IBusinessUnitBox Box
    {
      get
      {
        return this._Box;
      }

      set
      {
        this.SetPropertyValue("Box", this._Box, value, (propertyValue) => { this._Box = propertyValue; }, this.BoxChangedHandler);
      }
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
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Exchange.ReceiptNotificationSendingAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.Exchange.IReceiptNotificationSendingAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Exchange.ReceiptNotificationSendingAssignmentCreatingFromServerHandler((global::Sungero.Exchange.IReceiptNotificationSendingAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void BoxChangedHandler()
    {
      var args = new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentBoxChangedEventArgs(this.State.Properties.Box, this.Box, this);
     ((global::Sungero.Exchange.IReceiptNotificationSendingAssignmentSharedHandlers)this.SharedHandlers).BoxChanged(args);
    }

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.Exchange.Shared.ReceiptNotificationSendingAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.Exchange.IReceiptNotificationSendingAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.Exchange.IReceiptNotificationSendingAssignmentSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }



    #endregion


    public ReceiptNotificationSendingAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments

    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
    }
    #endregion


  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange
{
  public partial class ReceiptNotificationSendingAssignmentBoxPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.ExchangeCore.IBusinessUnitBox
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingAssignment _obj
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignment)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> BoxFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ReceiptNotificationSendingAssignmentBoxPropertyFilteringServerHandler(global::Sungero.Exchange.IReceiptNotificationSendingAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ReceiptNotificationSendingAssignmentBoxSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.ExchangeCore.IBusinessUnitBox
  {

    public virtual global::System.Linq.IQueryable<T> BoxSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ReceiptNotificationSendingAssignmentBoxSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }

  public partial class ReceiptNotificationSendingAssignmentAddresseePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingAssignment _obj
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignment)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> AddresseeFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ReceiptNotificationSendingAssignmentAddresseePropertyFilteringServerHandler(global::Sungero.Exchange.IReceiptNotificationSendingAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ReceiptNotificationSendingAssignmentAddresseeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> AddresseeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ReceiptNotificationSendingAssignmentAddresseeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class ReceiptNotificationSendingAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Exchange.IReceiptNotificationSendingAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ReceiptNotificationSendingAssignmentFilteringServerHandler(global::Sungero.Exchange.IReceiptNotificationSendingAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ReceiptNotificationSendingAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ReceiptNotificationSendingAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public ReceiptNotificationSendingAssignmentSearchDialogServerHandler(global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ReceiptNotificationSendingAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingAssignment _obj
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignment)this.Entity; }
    }

    public ReceiptNotificationSendingAssignmentServerHandlers(global::Sungero.Exchange.IReceiptNotificationSendingAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ReceiptNotificationSendingAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingAssignment _source
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignment)this.Source; }
    }

    private global::Sungero.Exchange.IReceiptNotificationSendingAssignmentInfo _info
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentInfo)this._Info; }
    }

    public ReceiptNotificationSendingAssignmentCreatingFromServerHandler(global::Sungero.Exchange.IReceiptNotificationSendingAssignment source, global::Sungero.Exchange.IReceiptNotificationSendingAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ReceiptNotificationSendingAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
}

// ==================================================================
// ReceiptNotificationSendingAssignmentAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
  public class ReceiptNotificationSendingAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.Exchange.IReceiptNotificationSendingAssignmentAccessRights
  {

    public ReceiptNotificationSendingAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReceiptNotificationSendingAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.Exchange.IReceiptNotificationSendingAssignmentAccessRights
  {

    public ReceiptNotificationSendingAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
    public class ReceiptNotificationSendingAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.Exchange.IReceiptNotificationSendingAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Exchange.IReceiptNotificationSendingAssignment 
    {
       public new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Exchange.IReceiptNotificationSendingAssignmentInfo Info
       {
          get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Exchange.Server.ReceiptNotificationSendingAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
}

// ==================================================================
// ReceiptNotificationSendingAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Exchange.Server
{
  public partial class ReceiptNotificationSendingAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingAssignment _obj
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingAssignment)this.Entity; }
    }

    public ReceiptNotificationSendingAssignmentFunctions(global::Sungero.Exchange.IReceiptNotificationSendingAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Functions
{
  internal static class ReceiptNotificationSendingAssignment
  {
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
  public class ReceiptNotificationSendingAssignmentServerPublicFunctions : global::Sungero.Exchange.Server.IReceiptNotificationSendingAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Queries
{
  public class ReceiptNotificationSendingAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Exchange.Server.ReceiptNotificationSendingAssignment.ReceiptNotificationSendingAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentBlock.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
  public class ReceiptNotificationSendingAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<ReceiptNotificationSendingAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public ReceiptNotificationSendingAssignmentArguments(ReceiptNotificationSendingAssignmentBlock block) : base(block) { }
  }

  public class ReceiptNotificationSendingAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<ReceiptNotificationSendingAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.Exchange.IReceiptNotificationSendingAssignment> 
  {
    public ReceiptNotificationSendingAssignmentEndBlockEventArguments(ReceiptNotificationSendingAssignmentBlock block) : base(block) { }
  }

  public partial class ReceiptNotificationSendingAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {
    public virtual global::System.DateTime? NewDeadline
    {
      get { return this.GetCustomProperty<global::System.DateTime?>("NewDeadline"); }
      set { this.SetCustomProperty("NewDeadline", value); }
    }

    public virtual global::Sungero.ExchangeCore.IBusinessUnitBox Box
    {
      get { return this.GetCustomNavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox>("Box"); }
      set { this.SetCustomNavigationProperty("Box", value); }
    }
    public virtual global::Sungero.Company.IEmployee Addressee
    {
      get { return this.GetCustomNavigationProperty<global::Sungero.Company.IEmployee>("Addressee"); }
      set { this.SetCustomNavigationProperty("Addressee", value); }
    }




    public ReceiptNotificationSendingAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// ReceiptNotificationSendingAssignmentChildWrappers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
}
