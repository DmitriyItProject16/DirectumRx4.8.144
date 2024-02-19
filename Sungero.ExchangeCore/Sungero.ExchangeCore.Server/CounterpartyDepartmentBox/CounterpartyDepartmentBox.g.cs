
// ==================================================================
// CounterpartyDepartmentBox.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
    public class CounterpartyDepartmentBoxFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox
    {
      protected new global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState Filter { get; private set; }

      private global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState filter
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

      public CounterpartyDepartmentBoxFilter(global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected CounterpartyDepartmentBoxFilter()
      {
      }
    }
      public class CounterpartyDepartmentBoxUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class CounterpartyDepartmentBoxSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }





        }




  public class CounterpartyDepartmentBoxFilterForCounterparty<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Parties.ICounterparty
    where TSourceEntity : class, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.ExchangeCore.CounterpartyDepartmentBoxCounterpartyPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("CounterpartyFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.ExchangeCore.CounterpartyDepartmentBoxCounterpartyPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).CounterpartyFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public CounterpartyDepartmentBoxFilterForCounterparty(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class CounterpartyDepartmentBoxSearchFilterForCounterparty<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Parties.ICounterparty
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.ExchangeCore.CounterpartyDepartmentBoxCounterpartySearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("CounterpartySearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.ExchangeCore.CounterpartyDepartmentBoxCounterpartySearchPropertyFilteringServerHandler<TQueryEntity>().CounterpartySearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public CounterpartyDepartmentBoxSearchFilterForCounterparty(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class CounterpartyDepartmentBoxFilterForBox<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.ExchangeCore.IBusinessUnitBox
    where TSourceEntity : class, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.ExchangeCore.CounterpartyDepartmentBoxBoxPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("BoxFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.ExchangeCore.CounterpartyDepartmentBoxBoxPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).BoxFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public CounterpartyDepartmentBoxFilterForBox(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class CounterpartyDepartmentBoxSearchFilterForBox<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.ExchangeCore.IBusinessUnitBox
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.ExchangeCore.CounterpartyDepartmentBoxBoxSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("BoxSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.ExchangeCore.CounterpartyDepartmentBoxBoxSearchPropertyFilteringServerHandler<TQueryEntity>().BoxSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public CounterpartyDepartmentBoxSearchFilterForBox(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxFilter<global::Sungero.ExchangeCore.ICounterpartyDepartmentBox>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxUiFilter<global::Sungero.ExchangeCore.ICounterpartyDepartmentBox>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxFilterForCounterparty<global::Sungero.Parties.ICounterparty, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox>), "Counterparty")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxSearchFilterForCounterparty<global::Sungero.Parties.ICounterparty>), "Counterparty")]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxFilterForBox<global::Sungero.ExchangeCore.IBusinessUnitBox, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox>), "Box")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxSearchFilterForBox<global::Sungero.ExchangeCore.IBusinessUnitBox>), "Box")]


  public class CounterpartyDepartmentBox :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("06c49e09-4c22-453b-9c96-d55fd38ed048");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBox.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.ICounterpartyDepartmentBox, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxState State
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyDepartmentBoxState(this);
    }

    public new virtual global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxInfo Info
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxInfo)base.Info; }
    }

    public new virtual global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxAccessRights AccessRights
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyDepartmentBoxFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.ExchangeCore.CounterpartyDepartmentBoxServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.ExchangeCore.CounterpartyDepartmentBoxSharedHandlers(this);
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
    private global::System.String _DepartmentId;
    public virtual global::System.String DepartmentId
    {
      get
      {
        return this._DepartmentId;
      }

      set
      {
        this.SetPropertyValue("DepartmentId", this._DepartmentId, value, (propertyValue) => { this._DepartmentId = propertyValue; }, this.DepartmentIdChangedHandler);
      }
    }
    private global::System.String _FtsId;
    public virtual global::System.String FtsId
    {
      get
      {
        return this._FtsId;
      }

      set
      {
        this.SetPropertyValue("FtsId", this._FtsId, value, (propertyValue) => { this._FtsId = propertyValue; }, this.FtsIdChangedHandler);
      }
    }
    private global::System.String _OrganizationId;
    public virtual global::System.String OrganizationId
    {
      get
      {
        return this._OrganizationId;
      }

      set
      {
        this.SetPropertyValue("OrganizationId", this._OrganizationId, value, (propertyValue) => { this._OrganizationId = propertyValue; }, this.OrganizationIdChangedHandler);
      }
    }
    private global::System.String _Note;
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }
    private global::System.String _Address;
    public virtual global::System.String Address
    {
      get
      {
        return this._Address;
      }

      set
      {
        this.SetPropertyValue("Address", this._Address, value, (propertyValue) => { this._Address = propertyValue; }, this.AddressChangedHandler);
      }
    }
    private global::System.String _ParentBranchId;
    public virtual global::System.String ParentBranchId
    {
      get
      {
        return this._ParentBranchId;
      }

      set
      {
        this.SetPropertyValue("ParentBranchId", this._ParentBranchId, value, (propertyValue) => { this._ParentBranchId = propertyValue; }, this.ParentBranchIdChangedHandler);
      }
    }







    private global::Sungero.Parties.ICounterparty _Counterparty;
    public virtual global::Sungero.Parties.ICounterparty Counterparty
    {
      get
      {
        return this._Counterparty;
      }

      set
      {
        this.SetPropertyValue("Counterparty", this._Counterparty, value, (propertyValue) => { this._Counterparty = propertyValue; }, this.CounterpartyChangedHandler);
      }
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




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.ExchangeCore.CounterpartyDepartmentBoxCreatingFromServerHandler", new object[] { (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.ExchangeCore.CounterpartyDepartmentBoxCreatingFromServerHandler((global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void DepartmentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.DepartmentId, this.DepartmentId, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).DepartmentIdChanged(args);
    }

    protected void CounterpartyChangedHandler()
    {
      var args = new global::Sungero.ExchangeCore.Shared.CounterpartyDepartmentBoxCounterpartyChangedEventArgs(this.State.Properties.Counterparty, this.Counterparty, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).CounterpartyChanged(args);
    }

    protected void BoxChangedHandler()
    {
      var args = new global::Sungero.ExchangeCore.Shared.CounterpartyDepartmentBoxBoxChangedEventArgs(this.State.Properties.Box, this.Box, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).BoxChanged(args);
    }

    protected void FtsIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FtsId, this.FtsId, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).FtsIdChanged(args);
    }

    protected void OrganizationIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.OrganizationId, this.OrganizationId, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).OrganizationIdChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }

    protected void AddressChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Address, this.Address, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).AddressChanged(args);
    }

    protected void ParentBranchIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ParentBranchId, this.ParentBranchId, this);
     ((global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxSharedHandlers)this.SharedHandlers).ParentBranchIdChanged(args);
    }



    #endregion


    public CounterpartyDepartmentBox()
    {
    }

  }
}

// ==================================================================
// CounterpartyDepartmentBoxHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore
{
  public partial class CounterpartyDepartmentBoxCounterpartyPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.ICounterparty
  {
    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBox _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> CounterpartyFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public CounterpartyDepartmentBoxCounterpartyPropertyFilteringServerHandler(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox entity)
      : base(entity)
    {
    }
  }

  public partial class CounterpartyDepartmentBoxCounterpartySearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.ICounterparty
  {

    public virtual global::System.Linq.IQueryable<T> CounterpartySearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public CounterpartyDepartmentBoxCounterpartySearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }

  public partial class CounterpartyDepartmentBoxBoxPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.ExchangeCore.IBusinessUnitBox
  {
    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBox _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> BoxFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public CounterpartyDepartmentBoxBoxPropertyFilteringServerHandler(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox entity)
      : base(entity)
    {
    }
  }

  public partial class CounterpartyDepartmentBoxBoxSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.ExchangeCore.IBusinessUnitBox
  {

    public virtual global::System.Linq.IQueryable<T> BoxSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public CounterpartyDepartmentBoxBoxSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class CounterpartyDepartmentBoxFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState Filter { get; private set; }

    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public CounterpartyDepartmentBoxFilteringServerHandler(global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected CounterpartyDepartmentBoxFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class CounterpartyDepartmentBoxUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class CounterpartyDepartmentBoxSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxSearchDialogModel)this.Dialog;
       }
     }

     public CounterpartyDepartmentBoxSearchDialogServerHandler(global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class CounterpartyDepartmentBoxServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBox _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)this.Entity; }
    }

    public CounterpartyDepartmentBoxServerHandlers(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox entity)
      : base(entity)
    {
    }
  }

  public partial class CounterpartyDepartmentBoxCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBox _source
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)this.Source; }
    }

    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxInfo _info
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxInfo)this._Info; }
    }

    public CounterpartyDepartmentBoxCreatingFromServerHandler(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox source, global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// CounterpartyDepartmentBoxEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
}

// ==================================================================
// CounterpartyDepartmentBoxAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
  public class CounterpartyDepartmentBoxAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.ExchangeCore.ICounterpartyDepartmentBoxAccessRights
  {

    public CounterpartyDepartmentBoxAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CounterpartyDepartmentBoxTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.ExchangeCore.ICounterpartyDepartmentBoxAccessRights
  {

    public CounterpartyDepartmentBoxTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// CounterpartyDepartmentBoxRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
    public class CounterpartyDepartmentBoxRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxRepositoryImplementer<T>
      where T : global::Sungero.ExchangeCore.ICounterpartyDepartmentBox 
    {
       public new global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxAccessRights AccessRights
       {
          get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxAccessRights)base.AccessRights; }
       }

       public new global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxInfo Info
       {
          get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.ExchangeCore.Server.CounterpartyDepartmentBoxTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CounterpartyDepartmentBoxPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
}

// ==================================================================
// CounterpartyDepartmentBoxServerFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Server
{
  public partial class CounterpartyDepartmentBoxFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBox _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)this.Entity; }
    }

    public CounterpartyDepartmentBoxFunctions(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyDepartmentBoxFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Functions
{
  internal static class CounterpartyDepartmentBox
  {
  }
}

// ==================================================================
// CounterpartyDepartmentBoxServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
  public class CounterpartyDepartmentBoxServerPublicFunctions : global::Sungero.ExchangeCore.Server.ICounterpartyDepartmentBoxServerPublicFunctions
  {
  }
}

// ==================================================================
// CounterpartyDepartmentBoxQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Queries
{
  public class CounterpartyDepartmentBox
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.ExchangeCore.Server.CounterpartyDepartmentBox.CounterpartyDepartmentBoxQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
