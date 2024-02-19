
// ==================================================================
// PowerOfAttorneyQueueItem.g.cs
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
    public class PowerOfAttorneyQueueItemFilter<T> :
      global::Sungero.ExchangeCore.Server.QueueItemBaseFilter<T>
      where T : class, global::Sungero.Docflow.IPowerOfAttorneyQueueItem
    {
      private global::Sungero.Docflow.IPowerOfAttorneyQueueItemFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IPowerOfAttorneyQueueItemFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public PowerOfAttorneyQueueItemFilter(global::Sungero.Docflow.IPowerOfAttorneyQueueItemFilterState filter)
      : base(filter)
      {
      }

      protected PowerOfAttorneyQueueItemFilter()
      {
      }
    }
      public class PowerOfAttorneyQueueItemUiFilter<T> :
        global::Sungero.ExchangeCore.Server.QueueItemBaseUiFilter<T>
        where T : class, global::Sungero.Docflow.IPowerOfAttorneyQueueItem
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class PowerOfAttorneyQueueItemSearchDialogModel : global::Sungero.ExchangeCore.Server.QueueItemBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String ExternalId { get; protected set; }
                  public override global::System.Int32? Retries { get; protected set; }
                  public override global::System.String Note { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBoxBase> Box { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ProcessingStatus { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> LastUpdate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBusinessUnitBox> RootBox { get; protected set; }


                  public virtual global::System.String OperationId { get; protected set; }
                  public virtual global::System.Int64? DocumentId { get; protected set; }
                  public virtual global::System.String RejectCode { get; protected set; }
                  public virtual global::System.String OperationState { get; protected set; }
                  public virtual global::System.Int64? TaskId { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> FormalizedPoAServiceStatus { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> OperationType { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> RevocationDate { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.PowerOfAttorneyQueueItemFilter<global::Sungero.Docflow.IPowerOfAttorneyQueueItem>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.PowerOfAttorneyQueueItemUiFilter<global::Sungero.Docflow.IPowerOfAttorneyQueueItem>))]

  public class PowerOfAttorneyQueueItem :
    global::Sungero.ExchangeCore.Server.QueueItemBase, global::Sungero.Docflow.IPowerOfAttorneyQueueItem
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("d8ac70d3-4dd2-49fb-8e32-cd79330e6243");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.PowerOfAttorneyQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IPowerOfAttorneyQueueItem, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyQueueItemState State
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItemState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyQueueItemState(this);
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyQueueItemInfo Info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItemInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyQueueItemAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItemAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.PowerOfAttorneyQueueItemAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.PowerOfAttorneyQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyQueueItemFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.PowerOfAttorneyQueueItemServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.PowerOfAttorneyQueueItemSharedHandlers(this);
    }

    private global::System.String _OperationId;
    public virtual global::System.String OperationId
    {
      get
      {
        return this._OperationId;
      }

      set
      {
        this.SetPropertyValue("OperationId", this._OperationId, value, (propertyValue) => { this._OperationId = propertyValue; }, this.OperationIdChangedHandler);
      }
    }
    private global::System.Int64? _DocumentId;
    public virtual global::System.Int64? DocumentId
    {
      get
      {
        return this._DocumentId;
      }

      set
      {
        this.SetPropertyValue("DocumentId", this._DocumentId, value, (propertyValue) => { this._DocumentId = propertyValue; }, this.DocumentIdChangedHandler);
      }
    }
    private global::System.String _RejectCode;
    public virtual global::System.String RejectCode
    {
      get
      {
        return this._RejectCode;
      }

      set
      {
        this.SetPropertyValue("RejectCode", this._RejectCode, value, (propertyValue) => { this._RejectCode = propertyValue; }, this.RejectCodeChangedHandler);
      }
    }
    private global::System.DateTime? _RevocationDate;
    public virtual global::System.DateTime? RevocationDate
    {
      get
      {
        return this._RevocationDate;
      }

      set
      {
        this.SetPropertyValue("RevocationDate", this._RevocationDate, value, (propertyValue) => { this._RevocationDate = propertyValue; }, this.RevocationDateChangedHandler);
      }
    }
    private global::System.String _OperationState;
    public virtual global::System.String OperationState
    {
      get
      {
        return this._OperationState;
      }

      set
      {
        this.SetPropertyValue("OperationState", this._OperationState, value, (propertyValue) => { this._OperationState = propertyValue; }, this.OperationStateChangedHandler);
      }
    }
    private global::System.Int64? _TaskId;
    public virtual global::System.Int64? TaskId
    {
      get
      {
        return this._TaskId;
      }

      set
      {
        this.SetPropertyValue("TaskId", this._TaskId, value, (propertyValue) => { this._TaskId = propertyValue; }, this.TaskIdChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _FormalizedPoAServiceStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.PowerOfAttorneyQueueItem.FormalizedPoAServiceStatus),
      typeof(global::Sungero.Docflow.Server.PowerOfAttorneyQueueItem),
      "FormalizedPoAServiceStatus");

    public static global::Sungero.Domain.Shared.EnumerationItems FormalizedPoAServiceStatusItems
    {
      get { return global::Sungero.Docflow.Server.PowerOfAttorneyQueueItem._FormalizedPoAServiceStatusItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems FormalizedPoAServiceStatusAllowedItems
    {
      get { return global::Sungero.Docflow.Server.PowerOfAttorneyQueueItem.FormalizedPoAServiceStatusItems; }
    }

    private global::Sungero.Core.Enumeration? _FormalizedPoAServiceStatus;

    public virtual global::Sungero.Core.Enumeration? FormalizedPoAServiceStatus
    {
      get { return this._FormalizedPoAServiceStatus; }
      set { this.SetEnumPropertyValue("FormalizedPoAServiceStatus", this._FormalizedPoAServiceStatus, value, (propertyValue) => { this._FormalizedPoAServiceStatus = propertyValue; }, this.FormalizedPoAServiceStatusChangedHandler, this.FormalizedPoAServiceStatusAllowedItems); }
    }
    private static global::Sungero.Domain.Shared.EnumerationItems _OperationTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.PowerOfAttorneyQueueItem.OperationType),
      typeof(global::Sungero.Docflow.Server.PowerOfAttorneyQueueItem),
      "OperationType");

    public static global::Sungero.Domain.Shared.EnumerationItems OperationTypeItems
    {
      get { return global::Sungero.Docflow.Server.PowerOfAttorneyQueueItem._OperationTypeItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems OperationTypeAllowedItems
    {
      get { return global::Sungero.Docflow.Server.PowerOfAttorneyQueueItem.OperationTypeItems; }
    }

    private global::Sungero.Core.Enumeration? _OperationType;

    public virtual global::Sungero.Core.Enumeration? OperationType
    {
      get { return this._OperationType; }
      set { this.SetEnumPropertyValue("OperationType", this._OperationType, value, (propertyValue) => { this._OperationType = propertyValue; }, this.OperationTypeChangedHandler, this.OperationTypeAllowedItems); }
    }





    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.PowerOfAttorneyQueueItemCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IPowerOfAttorneyQueueItem)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.PowerOfAttorneyQueueItemCreatingFromServerHandler((global::Sungero.Docflow.IPowerOfAttorneyQueueItem)entitySource, this.Info);
    }

    #region Framework events

    protected void FormalizedPoAServiceStatusChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.FormalizedPoAServiceStatus, this.FormalizedPoAServiceStatus, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyQueueItemSharedHandlers)this.SharedHandlers).FormalizedPoAServiceStatusChanged(args);
    }

    protected void OperationIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.OperationId, this.OperationId, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyQueueItemSharedHandlers)this.SharedHandlers).OperationIdChanged(args);
    }

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyQueueItemSharedHandlers)this.SharedHandlers).DocumentIdChanged(args);
    }

    protected void OperationTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.OperationType, this.OperationType, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyQueueItemSharedHandlers)this.SharedHandlers).OperationTypeChanged(args);
    }

    protected void RejectCodeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.RejectCode, this.RejectCode, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyQueueItemSharedHandlers)this.SharedHandlers).RejectCodeChanged(args);
    }

    protected void RevocationDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.RevocationDate, this.RevocationDate, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyQueueItemSharedHandlers)this.SharedHandlers).RevocationDateChanged(args);
    }

    protected void OperationStateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.OperationState, this.OperationState, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyQueueItemSharedHandlers)this.SharedHandlers).OperationStateChanged(args);
    }

    protected void TaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.TaskId, this.TaskId, this);
     ((global::Sungero.Docflow.IPowerOfAttorneyQueueItemSharedHandlers)this.SharedHandlers).TaskIdChanged(args);
    }



    #endregion


    public PowerOfAttorneyQueueItem()
    {
    }

  }
}

// ==================================================================
// PowerOfAttorneyQueueItemHandlers.g.cs
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

  public partial class PowerOfAttorneyQueueItemFilteringServerHandler<T>
    : global::Sungero.ExchangeCore.QueueItemBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IPowerOfAttorneyQueueItem
  {
    private global::Sungero.Docflow.IPowerOfAttorneyQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IPowerOfAttorneyQueueItemFilterState)this.Filter;
      }
    }

    public PowerOfAttorneyQueueItemFilteringServerHandler(global::Sungero.Docflow.IPowerOfAttorneyQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected PowerOfAttorneyQueueItemFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class PowerOfAttorneyQueueItemUiFilteringServerHandler<T>
    : global::Sungero.ExchangeCore.QueueItemBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IPowerOfAttorneyQueueItem
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class PowerOfAttorneyQueueItemSearchDialogServerHandler : global::Sungero.ExchangeCore.QueueItemBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.PowerOfAttorneyQueueItemSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.PowerOfAttorneyQueueItemSearchDialogModel)this.Dialog;
       }
     }

     public PowerOfAttorneyQueueItemSearchDialogServerHandler(global::Sungero.Docflow.Server.PowerOfAttorneyQueueItemSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class PowerOfAttorneyQueueItemServerHandlers : global::Sungero.ExchangeCore.QueueItemBaseServerHandlers
  {
    private global::Sungero.Docflow.IPowerOfAttorneyQueueItem _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItem)this.Entity; }
    }

    public PowerOfAttorneyQueueItemServerHandlers(global::Sungero.Docflow.IPowerOfAttorneyQueueItem entity)
      : base(entity)
    {
    }
  }

  public partial class PowerOfAttorneyQueueItemCreatingFromServerHandler : global::Sungero.ExchangeCore.QueueItemBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IPowerOfAttorneyQueueItem _source
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItem)this.Source; }
    }

    private global::Sungero.Docflow.IPowerOfAttorneyQueueItemInfo _info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItemInfo)this._Info; }
    }

    public PowerOfAttorneyQueueItemCreatingFromServerHandler(global::Sungero.Docflow.IPowerOfAttorneyQueueItem source, global::Sungero.Docflow.IPowerOfAttorneyQueueItemInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyQueueItemEventArgs.g.cs
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
// PowerOfAttorneyQueueItemAccessRights.g.cs
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
  public class PowerOfAttorneyQueueItemAccessRights : 
    Sungero.ExchangeCore.Server.QueueItemBaseAccessRights, Sungero.Docflow.IPowerOfAttorneyQueueItemAccessRights
  {

    public PowerOfAttorneyQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class PowerOfAttorneyQueueItemTypeAccessRights : 
    Sungero.ExchangeCore.Server.QueueItemBaseTypeAccessRights, Sungero.Docflow.IPowerOfAttorneyQueueItemAccessRights
  {

    public PowerOfAttorneyQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// PowerOfAttorneyQueueItemRepositoryImplementer.g.cs
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
    public class PowerOfAttorneyQueueItemRepositoryImplementer<T> : 
      global::Sungero.ExchangeCore.Server.QueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IPowerOfAttorneyQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IPowerOfAttorneyQueueItem 
    {
       public new global::Sungero.Docflow.IPowerOfAttorneyQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IPowerOfAttorneyQueueItemInfo Info
       {
          get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.PowerOfAttorneyQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// PowerOfAttorneyQueueItemPanelNavigationFilters.g.cs
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
// PowerOfAttorneyQueueItemServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class PowerOfAttorneyQueueItemFunctions : global::Sungero.ExchangeCore.Server.QueueItemBaseFunctions
  {
    private global::Sungero.Docflow.IPowerOfAttorneyQueueItem _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyQueueItem)this.Entity; }
    }

    public PowerOfAttorneyQueueItemFunctions(global::Sungero.Docflow.IPowerOfAttorneyQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyQueueItemFunctions.g.cs
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
  internal static class PowerOfAttorneyQueueItem
  {
  }
}

// ==================================================================
// PowerOfAttorneyQueueItemServerPublicFunctions.g.cs
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
  public class PowerOfAttorneyQueueItemServerPublicFunctions : global::Sungero.Docflow.Server.IPowerOfAttorneyQueueItemServerPublicFunctions
  {
  }
}

// ==================================================================
// PowerOfAttorneyQueueItemQueries.g.cs
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
  public class PowerOfAttorneyQueueItem
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.PowerOfAttorneyQueueItem.PowerOfAttorneyQueueItemQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
