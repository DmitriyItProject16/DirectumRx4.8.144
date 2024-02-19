
// ==================================================================
// ActionItemTrainQueueItem.g.cs
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
    public class ActionItemTrainQueueItemFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.RecordManagement.IActionItemTrainQueueItem
    {
      protected new global::Sungero.RecordManagement.IActionItemTrainQueueItemFilterState Filter { get; private set; }

      private global::Sungero.RecordManagement.IActionItemTrainQueueItemFilterState filter
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

      public ActionItemTrainQueueItemFilter(global::Sungero.RecordManagement.IActionItemTrainQueueItemFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ActionItemTrainQueueItemFilter()
      {
      }
    }
      public class ActionItemTrainQueueItemUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.RecordManagement.IActionItemTrainQueueItem
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ActionItemTrainQueueItemSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.Int64? ActionItemId { get; protected set; }
                  public virtual global::System.Int64? AIManagersAssistantId { get; protected set; }
                  public virtual global::System.Int32? ClassifierId { get; protected set; }
                  public virtual global::System.Int32? ArioTaskId { get; protected set; }
                  public virtual global::System.Int64? ExtractTextQueueItemId { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ProcessingStatus { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.RecordManagement.Server.ActionItemTrainQueueItemFilter<global::Sungero.RecordManagement.IActionItemTrainQueueItem>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.RecordManagement.Server.ActionItemTrainQueueItemUiFilter<global::Sungero.RecordManagement.IActionItemTrainQueueItem>))]

  public class ActionItemTrainQueueItem :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.RecordManagement.IActionItemTrainQueueItem
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("302469c6-3f82-46c9-961f-5954f03bae22");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.ActionItemTrainQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemTrainQueueItem, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.RecordManagement.IActionItemTrainQueueItemState State
    {
      get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItemState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemTrainQueueItemState(this);
    }

    public new virtual global::Sungero.RecordManagement.IActionItemTrainQueueItemInfo Info
    {
      get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItemInfo)base.Info; }
    }

    public new virtual global::Sungero.RecordManagement.IActionItemTrainQueueItemAccessRights AccessRights
    {
      get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItemAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Server.ActionItemTrainQueueItemAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.RecordManagement.Server.ActionItemTrainQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemTrainQueueItemFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ActionItemTrainQueueItemServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemTrainQueueItemSharedHandlers(this);
    }

    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }
    private global::System.Int64? _ActionItemId;
    public virtual global::System.Int64? ActionItemId
    {
      get
      {
        return this._ActionItemId;
      }

      set
      {
        this.SetPropertyValue("ActionItemId", this._ActionItemId, value, (propertyValue) => { this._ActionItemId = propertyValue; }, this.ActionItemIdChangedHandler);
      }
    }
    private global::System.Int64? _AIManagersAssistantId;
    public virtual global::System.Int64? AIManagersAssistantId
    {
      get
      {
        return this._AIManagersAssistantId;
      }

      set
      {
        this.SetPropertyValue("AIManagersAssistantId", this._AIManagersAssistantId, value, (propertyValue) => { this._AIManagersAssistantId = propertyValue; }, this.AIManagersAssistantIdChangedHandler);
      }
    }
    private global::System.Int32? _ClassifierId;
    public virtual global::System.Int32? ClassifierId
    {
      get
      {
        return this._ClassifierId;
      }

      set
      {
        this.SetPropertyValue("ClassifierId", this._ClassifierId, value, (propertyValue) => { this._ClassifierId = propertyValue; }, this.ClassifierIdChangedHandler);
      }
    }
    private global::System.Int32? _ArioTaskId;
    public virtual global::System.Int32? ArioTaskId
    {
      get
      {
        return this._ArioTaskId;
      }

      set
      {
        this.SetPropertyValue("ArioTaskId", this._ArioTaskId, value, (propertyValue) => { this._ArioTaskId = propertyValue; }, this.ArioTaskIdChangedHandler);
      }
    }
    private global::System.Int64? _ExtractTextQueueItemId;
    public virtual global::System.Int64? ExtractTextQueueItemId
    {
      get
      {
        return this._ExtractTextQueueItemId;
      }

      set
      {
        this.SetPropertyValue("ExtractTextQueueItemId", this._ExtractTextQueueItemId, value, (propertyValue) => { this._ExtractTextQueueItemId = propertyValue; }, this.ExtractTextQueueItemIdChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ProcessingStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.RecordManagement.ActionItemTrainQueueItem.ProcessingStatus),
      typeof(global::Sungero.RecordManagement.Server.ActionItemTrainQueueItem),
      "ProcessingStatus");

    public static global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusItems
    {
      get { return global::Sungero.RecordManagement.Server.ActionItemTrainQueueItem._ProcessingStatusItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusAllowedItems
    {
      get { return global::Sungero.RecordManagement.Server.ActionItemTrainQueueItem.ProcessingStatusItems; }
    }

    private global::Sungero.Core.Enumeration? _ProcessingStatus;

    public virtual global::Sungero.Core.Enumeration? ProcessingStatus
    {
      get { return this._ProcessingStatus; }
      set { this.SetEnumPropertyValue("ProcessingStatus", this._ProcessingStatus, value, (propertyValue) => { this._ProcessingStatus = propertyValue; }, this.ProcessingStatusChangedHandler, this.ProcessingStatusAllowedItems); }
    }





    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.RecordManagement.ActionItemTrainQueueItemCreatingFromServerHandler", new object[] { (global::Sungero.RecordManagement.IActionItemTrainQueueItem)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.RecordManagement.ActionItemTrainQueueItemCreatingFromServerHandler((global::Sungero.RecordManagement.IActionItemTrainQueueItem)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.RecordManagement.IActionItemTrainQueueItemSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void ActionItemIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.ActionItemId, this.ActionItemId, this);
     ((global::Sungero.RecordManagement.IActionItemTrainQueueItemSharedHandlers)this.SharedHandlers).ActionItemIdChanged(args);
    }

    protected void AIManagersAssistantIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.AIManagersAssistantId, this.AIManagersAssistantId, this);
     ((global::Sungero.RecordManagement.IActionItemTrainQueueItemSharedHandlers)this.SharedHandlers).AIManagersAssistantIdChanged(args);
    }

    protected void ClassifierIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ClassifierId, this.ClassifierId, this);
     ((global::Sungero.RecordManagement.IActionItemTrainQueueItemSharedHandlers)this.SharedHandlers).ClassifierIdChanged(args);
    }

    protected void ProcessingStatusChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ProcessingStatus, this.ProcessingStatus, this);
     ((global::Sungero.RecordManagement.IActionItemTrainQueueItemSharedHandlers)this.SharedHandlers).ProcessingStatusChanged(args);
    }

    protected void ArioTaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ArioTaskId, this.ArioTaskId, this);
     ((global::Sungero.RecordManagement.IActionItemTrainQueueItemSharedHandlers)this.SharedHandlers).ArioTaskIdChanged(args);
    }

    protected void ExtractTextQueueItemIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.ExtractTextQueueItemId, this.ExtractTextQueueItemId, this);
     ((global::Sungero.RecordManagement.IActionItemTrainQueueItemSharedHandlers)this.SharedHandlers).ExtractTextQueueItemIdChanged(args);
    }



    #endregion


    public ActionItemTrainQueueItem()
    {
    }

  }
}

// ==================================================================
// ActionItemTrainQueueItemHandlers.g.cs
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

  public partial class ActionItemTrainQueueItemFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.RecordManagement.IActionItemTrainQueueItem
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.RecordManagement.IActionItemTrainQueueItemFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IActionItemTrainQueueItemFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ActionItemTrainQueueItemFilteringServerHandler(global::Sungero.RecordManagement.IActionItemTrainQueueItemFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ActionItemTrainQueueItemFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ActionItemTrainQueueItemUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.RecordManagement.IActionItemTrainQueueItem
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ActionItemTrainQueueItemSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.RecordManagement.Server.ActionItemTrainQueueItemSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.RecordManagement.Server.ActionItemTrainQueueItemSearchDialogModel)this.Dialog;
       }
     }

     public ActionItemTrainQueueItemSearchDialogServerHandler(global::Sungero.RecordManagement.Server.ActionItemTrainQueueItemSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ActionItemTrainQueueItemServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.RecordManagement.IActionItemTrainQueueItem _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItem)this.Entity; }
    }

    public ActionItemTrainQueueItemServerHandlers(global::Sungero.RecordManagement.IActionItemTrainQueueItem entity)
      : base(entity)
    {
    }
  }

  public partial class ActionItemTrainQueueItemCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.RecordManagement.IActionItemTrainQueueItem _source
    {
      get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItem)this.Source; }
    }

    private global::Sungero.RecordManagement.IActionItemTrainQueueItemInfo _info
    {
      get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItemInfo)this._Info; }
    }

    public ActionItemTrainQueueItemCreatingFromServerHandler(global::Sungero.RecordManagement.IActionItemTrainQueueItem source, global::Sungero.RecordManagement.IActionItemTrainQueueItemInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ActionItemTrainQueueItemEventArgs.g.cs
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
// ActionItemTrainQueueItemAccessRights.g.cs
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
  public class ActionItemTrainQueueItemAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.RecordManagement.IActionItemTrainQueueItemAccessRights
  {

    public ActionItemTrainQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ActionItemTrainQueueItemTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.RecordManagement.IActionItemTrainQueueItemAccessRights
  {

    public ActionItemTrainQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ActionItemTrainQueueItemRepositoryImplementer.g.cs
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
    public class ActionItemTrainQueueItemRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.RecordManagement.IActionItemTrainQueueItemRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IActionItemTrainQueueItem 
    {
       public new global::Sungero.RecordManagement.IActionItemTrainQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IActionItemTrainQueueItemInfo Info
       {
          get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Server.ActionItemTrainQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ActionItemTrainQueueItemPanelNavigationFilters.g.cs
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
// ActionItemTrainQueueItemServerFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Server
{
  public partial class ActionItemTrainQueueItemFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.RecordManagement.IActionItemTrainQueueItem _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemTrainQueueItem)this.Entity; }
    }

    public ActionItemTrainQueueItemFunctions(global::Sungero.RecordManagement.IActionItemTrainQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// ActionItemTrainQueueItemFunctions.g.cs
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
  internal static class ActionItemTrainQueueItem
  {
    /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemTrainQueueItemFunctions" />
    internal static  void SetProcessedStatus(global::Sungero.RecordManagement.IActionItemTrainQueueItem actionItemTrainQueueItem, global::System.Nullable<global::Sungero.Core.Enumeration> status)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)actionItemTrainQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetProcessedStatus", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { status });
    }

  }
}

// ==================================================================
// ActionItemTrainQueueItemServerPublicFunctions.g.cs
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
  public class ActionItemTrainQueueItemServerPublicFunctions : global::Sungero.RecordManagement.Server.IActionItemTrainQueueItemServerPublicFunctions
  {
  }
}

// ==================================================================
// ActionItemTrainQueueItemQueries.g.cs
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
  public class ActionItemTrainQueueItem
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.ActionItemTrainQueueItem.ActionItemTrainQueueItemQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
