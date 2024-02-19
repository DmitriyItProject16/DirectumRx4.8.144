
// ==================================================================
// MobileDevice.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Server
{
    public class MobileDeviceFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.MobileApps.IMobileDevice
    {
      protected new global::Sungero.MobileApps.IMobileDeviceFilterState Filter { get; private set; }

      private global::Sungero.MobileApps.IMobileDeviceFilterState filter
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

      public MobileDeviceFilter(global::Sungero.MobileApps.IMobileDeviceFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected MobileDeviceFilter()
      {
      }
    }
      public class MobileDeviceUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.MobileApps.IMobileDevice
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class MobileDeviceSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.String OsVersion { get; protected set; }
                  public virtual global::System.String AppVersion { get; protected set; }
                  public virtual global::System.String DeviceName { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Employee { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> DeviceStatus { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> LastActivity { get; protected set; }


        }




  public class MobileDeviceFilterForEmployee<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.MobileApps.IMobileDevice
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.MobileApps.MobileDeviceEmployeePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("EmployeeFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.MobileApps.MobileDeviceEmployeePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).EmployeeFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public MobileDeviceFilterForEmployee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class MobileDeviceSearchFilterForEmployee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.MobileApps.MobileDeviceEmployeeSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("EmployeeSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.MobileApps.MobileDeviceEmployeeSearchPropertyFilteringServerHandler<TQueryEntity>().EmployeeSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public MobileDeviceSearchFilterForEmployee(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.MobileApps.Server.MobileDeviceFilter<global::Sungero.MobileApps.IMobileDevice>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.MobileApps.Server.MobileDeviceUiFilter<global::Sungero.MobileApps.IMobileDevice>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.MobileApps.Server.MobileDeviceFilterForEmployee<global::Sungero.Company.IEmployee, global::Sungero.MobileApps.IMobileDevice>), "Employee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.MobileApps.Server.MobileDeviceSearchFilterForEmployee<global::Sungero.CoreEntities.IRecipient>), "Employee")]


  public class MobileDevice :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.MobileApps.IMobileDevice
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("2856cdf1-671b-41d1-a442-d1e0badff032");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.MobileApps.Server.MobileDevice.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.MobileApps.IMobileDevice, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.MobileApps.IMobileDeviceState State
    {
      get { return (global::Sungero.MobileApps.IMobileDeviceState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.MobileApps.Shared.MobileDeviceState(this);
    }

    public new virtual global::Sungero.MobileApps.IMobileDeviceInfo Info
    {
      get { return (global::Sungero.MobileApps.IMobileDeviceInfo)base.Info; }
    }

    public new virtual global::Sungero.MobileApps.IMobileDeviceAccessRights AccessRights
    {
      get { return (global::Sungero.MobileApps.IMobileDeviceAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.MobileApps.Server.MobileDeviceAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.MobileApps.Server.MobileDeviceFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.MobileApps.Shared.MobileDeviceFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.MobileApps.MobileDeviceServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.MobileApps.MobileDeviceSharedHandlers(this);
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
    private global::System.String _DeviceId;
    public virtual global::System.String DeviceId
    {
      get
      {
        return this._DeviceId;
      }

      set
      {
        this.SetPropertyValue("DeviceId", this._DeviceId, value, (propertyValue) => { this._DeviceId = propertyValue; }, this.DeviceIdChangedHandler);
      }
    }
    private global::System.String _OsVersion;
    public virtual global::System.String OsVersion
    {
      get
      {
        return this._OsVersion;
      }

      set
      {
        this.SetPropertyValue("OsVersion", this._OsVersion, value, (propertyValue) => { this._OsVersion = propertyValue; }, this.OsVersionChangedHandler);
      }
    }
    private global::System.String _AppVersion;
    public virtual global::System.String AppVersion
    {
      get
      {
        return this._AppVersion;
      }

      set
      {
        this.SetPropertyValue("AppVersion", this._AppVersion, value, (propertyValue) => { this._AppVersion = propertyValue; }, this.AppVersionChangedHandler);
      }
    }
    private global::System.String _DeviceName;
    public virtual global::System.String DeviceName
    {
      get
      {
        return this._DeviceName;
      }

      set
      {
        this.SetPropertyValue("DeviceName", this._DeviceName, value, (propertyValue) => { this._DeviceName = propertyValue; }, this.DeviceNameChangedHandler);
      }
    }
    private global::System.DateTime? _LastActivity;
    public virtual global::System.DateTime? LastActivity
    {
      get
      {
        return this._LastActivity;
      }

      set
      {
        this.SetPropertyValue("LastActivity", this._LastActivity, value, (propertyValue) => { this._LastActivity = propertyValue; }, this.LastActivityChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _DeviceStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.MobileApps.MobileDevice.DeviceStatus),
      typeof(global::Sungero.MobileApps.Server.MobileDevice),
      "DeviceStatus");

    public static global::Sungero.Domain.Shared.EnumerationItems DeviceStatusItems
    {
      get { return global::Sungero.MobileApps.Server.MobileDevice._DeviceStatusItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems DeviceStatusAllowedItems
    {
      get { return global::Sungero.MobileApps.Server.MobileDevice.DeviceStatusItems; }
    }

    private global::Sungero.Core.Enumeration? _DeviceStatus;

    public virtual global::Sungero.Core.Enumeration? DeviceStatus
    {
      get { return this._DeviceStatus; }
      set { this.SetEnumPropertyValue("DeviceStatus", this._DeviceStatus, value, (propertyValue) => { this._DeviceStatus = propertyValue; }, this.DeviceStatusChangedHandler, this.DeviceStatusAllowedItems); }
    }


    private global::Sungero.Company.IEmployee _Employee;
    public virtual global::Sungero.Company.IEmployee Employee
    {
      get
      {
        return this._Employee;
      }

      set
      {
        this.SetPropertyValue("Employee", this._Employee, value, (propertyValue) => { this._Employee = propertyValue; }, this.EmployeeChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.MobileApps.MobileDeviceCreatingFromServerHandler", new object[] { (global::Sungero.MobileApps.IMobileDevice)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.MobileApps.MobileDeviceCreatingFromServerHandler((global::Sungero.MobileApps.IMobileDevice)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.MobileApps.IMobileDeviceSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void EmployeeChangedHandler()
    {
      var args = new global::Sungero.MobileApps.Shared.MobileDeviceEmployeeChangedEventArgs(this.State.Properties.Employee, this.Employee, this);
     ((global::Sungero.MobileApps.IMobileDeviceSharedHandlers)this.SharedHandlers).EmployeeChanged(args);
    }

    protected void DeviceIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.DeviceId, this.DeviceId, this);
     ((global::Sungero.MobileApps.IMobileDeviceSharedHandlers)this.SharedHandlers).DeviceIdChanged(args);
    }

    protected void OsVersionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.OsVersion, this.OsVersion, this);
     ((global::Sungero.MobileApps.IMobileDeviceSharedHandlers)this.SharedHandlers).OsVersionChanged(args);
    }

    protected void AppVersionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.AppVersion, this.AppVersion, this);
     ((global::Sungero.MobileApps.IMobileDeviceSharedHandlers)this.SharedHandlers).AppVersionChanged(args);
    }

    protected void DeviceStatusChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.DeviceStatus, this.DeviceStatus, this);
     ((global::Sungero.MobileApps.IMobileDeviceSharedHandlers)this.SharedHandlers).DeviceStatusChanged(args);
    }

    protected void DeviceNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.DeviceName, this.DeviceName, this);
     ((global::Sungero.MobileApps.IMobileDeviceSharedHandlers)this.SharedHandlers).DeviceNameChanged(args);
    }

    protected void LastActivityChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.LastActivity, this.LastActivity, this);
     ((global::Sungero.MobileApps.IMobileDeviceSharedHandlers)this.SharedHandlers).LastActivityChanged(args);
    }



    #endregion


    public MobileDevice()
    {
    }

  }
}

// ==================================================================
// MobileDeviceHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps
{
  public partial class MobileDeviceEmployeePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.MobileApps.IMobileDevice _obj
    {
      get { return (global::Sungero.MobileApps.IMobileDevice)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> EmployeeFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public MobileDeviceEmployeePropertyFilteringServerHandler(global::Sungero.MobileApps.IMobileDevice entity)
      : base(entity)
    {
    }
  }

  public partial class MobileDeviceEmployeeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> EmployeeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public MobileDeviceEmployeeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class MobileDeviceFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.MobileApps.IMobileDevice
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.MobileApps.IMobileDeviceFilterState Filter { get; private set; }

    private global::Sungero.MobileApps.IMobileDeviceFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public MobileDeviceFilteringServerHandler(global::Sungero.MobileApps.IMobileDeviceFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected MobileDeviceFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class MobileDeviceUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.MobileApps.IMobileDevice
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class MobileDeviceSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.MobileApps.Server.MobileDeviceSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.MobileApps.Server.MobileDeviceSearchDialogModel)this.Dialog;
       }
     }

     public MobileDeviceSearchDialogServerHandler(global::Sungero.MobileApps.Server.MobileDeviceSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class MobileDeviceServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.MobileApps.IMobileDevice _obj
    {
      get { return (global::Sungero.MobileApps.IMobileDevice)this.Entity; }
    }

    public MobileDeviceServerHandlers(global::Sungero.MobileApps.IMobileDevice entity)
      : base(entity)
    {
    }
  }

  public partial class MobileDeviceCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.MobileApps.IMobileDevice _source
    {
      get { return (global::Sungero.MobileApps.IMobileDevice)this.Source; }
    }

    private global::Sungero.MobileApps.IMobileDeviceInfo _info
    {
      get { return (global::Sungero.MobileApps.IMobileDeviceInfo)this._Info; }
    }

    public MobileDeviceCreatingFromServerHandler(global::Sungero.MobileApps.IMobileDevice source, global::Sungero.MobileApps.IMobileDeviceInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// MobileDeviceEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Server
{
}

// ==================================================================
// MobileDeviceAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Server
{
  public class MobileDeviceAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.MobileApps.IMobileDeviceAccessRights
  {

    public MobileDeviceAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class MobileDeviceTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.MobileApps.IMobileDeviceAccessRights
  {

    public MobileDeviceTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// MobileDeviceRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Server
{
    public class MobileDeviceRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.MobileApps.IMobileDeviceRepositoryImplementer<T>
      where T : global::Sungero.MobileApps.IMobileDevice 
    {
       public new global::Sungero.MobileApps.IMobileDeviceAccessRights AccessRights
       {
          get { return (global::Sungero.MobileApps.IMobileDeviceAccessRights)base.AccessRights; }
       }

       public new global::Sungero.MobileApps.IMobileDeviceInfo Info
       {
          get { return (global::Sungero.MobileApps.IMobileDeviceInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.MobileApps.Server.MobileDeviceTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// MobileDevicePanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Server
{
}

// ==================================================================
// MobileDeviceServerFunctions.g.cs
// ==================================================================

namespace Sungero.MobileApps.Server
{
  public partial class MobileDeviceFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.MobileApps.IMobileDevice _obj
    {
      get { return (global::Sungero.MobileApps.IMobileDevice)this.Entity; }
    }

    public MobileDeviceFunctions(global::Sungero.MobileApps.IMobileDevice entity) : base(entity) { }
  }
}

// ==================================================================
// MobileDeviceFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Functions
{
  internal static class MobileDevice
  {
    /// <redirect project="Sungero.MobileApps.Server" type="Sungero.MobileApps.Server.MobileDeviceFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  void RequestLogs(global::Sungero.MobileApps.IMobileDevice mobileDevice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)mobileDevice).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RequestLogs", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.MobileApps.Server" type="Sungero.MobileApps.Server.MobileDeviceFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Int32 GetLogRequestDelay(global::Sungero.MobileApps.IMobileDevice mobileDevice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)mobileDevice).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetLogRequestDelay", new System.Type[] {  });
      return (global::System.Int32)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.MobileApps.Server" type="Sungero.MobileApps.Server.MobileDeviceFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  void DeleteData(global::Sungero.MobileApps.IMobileDevice mobileDevice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)mobileDevice).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("DeleteData", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.MobileApps.Server" type="Sungero.MobileApps.Server.MobileDeviceFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  void ResetSeance(global::Sungero.MobileApps.IMobileDevice mobileDevice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)mobileDevice).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ResetSeance", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.MobileApps.Shared" type="Sungero.MobileApps.Shared.MobileDeviceFunctions" />
    internal static  void SetStatusFromCode(global::Sungero.MobileApps.IMobileDevice mobileDevice, global::System.Int32 intStatus)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)mobileDevice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetStatusFromCode", new System.Type[] { typeof(global::System.Int32) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { intStatus });
    }
    /// <redirect project="Sungero.MobileApps.Shared" type="Sungero.MobileApps.Shared.MobileDeviceFunctions" />
    internal static  void FillName(global::Sungero.MobileApps.IMobileDevice mobileDevice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)mobileDevice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// MobileDeviceServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Server
{
  public class MobileDeviceServerPublicFunctions : global::Sungero.MobileApps.Server.IMobileDeviceServerPublicFunctions
  {
  }
}

// ==================================================================
// MobileDeviceQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Queries
{
  public class MobileDevice
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.MobileApps.Server.MobileDevice.MobileDeviceQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
