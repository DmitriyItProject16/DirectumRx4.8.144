
// ==================================================================
// Region.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
    public class RegionFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.Commons.IRegion
    {
      protected new global::Sungero.Commons.IRegionFilterState Filter { get; private set; }

      private global::Sungero.Commons.IRegionFilterState filter
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

      public RegionFilter(global::Sungero.Commons.IRegionFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected RegionFilter()
      {
      }
    }
      public class RegionUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.Commons.IRegion
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class RegionSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.String Code { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Commons.ICountry> Country { get; protected set; }


        }




  public class RegionFilterForCountry<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Commons.ICountry
    where TSourceEntity : class, global::Sungero.Commons.IRegion
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Commons.RegionCountryPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("CountryFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Commons.RegionCountryPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).CountryFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public RegionFilterForCountry(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class RegionSearchFilterForCountry<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Commons.ICountry
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Commons.RegionCountrySearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("CountrySearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Commons.RegionCountrySearchPropertyFilteringServerHandler<TQueryEntity>().CountrySearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public RegionSearchFilterForCountry(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Commons.Server.RegionFilter<global::Sungero.Commons.IRegion>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Commons.Server.RegionUiFilter<global::Sungero.Commons.IRegion>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Commons.Server.RegionFilterForCountry<global::Sungero.Commons.ICountry, global::Sungero.Commons.IRegion>), "Country")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Commons.Server.RegionSearchFilterForCountry<global::Sungero.Commons.ICountry>), "Country")]


  public class Region :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.Commons.IRegion
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4efe2fa9-b1d1-4b47-b366-4128fe0a391c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Commons.Server.Region.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Commons.IRegion, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Commons.IRegionState State
    {
      get { return (global::Sungero.Commons.IRegionState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Commons.Shared.RegionState(this);
    }

    public new virtual global::Sungero.Commons.IRegionInfo Info
    {
      get { return (global::Sungero.Commons.IRegionInfo)base.Info; }
    }

    public new virtual global::Sungero.Commons.IRegionAccessRights AccessRights
    {
      get { return (global::Sungero.Commons.IRegionAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Commons.Server.RegionAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Commons.Server.RegionFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Commons.Shared.RegionFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Commons.RegionServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Commons.RegionSharedHandlers(this);
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
    private global::System.String _Code;
    public virtual global::System.String Code
    {
      get
      {
        return this._Code;
      }

      set
      {
        this.SetPropertyValue("Code", this._Code, value, (propertyValue) => { this._Code = propertyValue; }, this.CodeChangedHandler);
      }
    }







    private global::Sungero.Commons.ICountry _Country;
    public virtual global::Sungero.Commons.ICountry Country
    {
      get
      {
        return this._Country;
      }

      set
      {
        this.SetPropertyValue("Country", this._Country, value, (propertyValue) => { this._Country = propertyValue; }, this.CountryChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Commons.RegionCreatingFromServerHandler", new object[] { (global::Sungero.Commons.IRegion)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Commons.RegionCreatingFromServerHandler((global::Sungero.Commons.IRegion)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Commons.IRegionSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void CountryChangedHandler()
    {
      var args = new global::Sungero.Commons.Shared.RegionCountryChangedEventArgs(this.State.Properties.Country, this.Country, this);
     ((global::Sungero.Commons.IRegionSharedHandlers)this.SharedHandlers).CountryChanged(args);
    }

    protected void CodeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Code, this.Code, this);
     ((global::Sungero.Commons.IRegionSharedHandlers)this.SharedHandlers).CodeChanged(args);
    }



    #endregion


    public Region()
    {
    }

  }
}

// ==================================================================
// RegionHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons
{
  public partial class RegionCountryPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Commons.ICountry
  {
    private global::Sungero.Commons.IRegion _obj
    {
      get { return (global::Sungero.Commons.IRegion)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> CountryFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public RegionCountryPropertyFilteringServerHandler(global::Sungero.Commons.IRegion entity)
      : base(entity)
    {
    }
  }

  public partial class RegionCountrySearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Commons.ICountry
  {

    public virtual global::System.Linq.IQueryable<T> CountrySearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public RegionCountrySearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class RegionFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Commons.IRegion
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Commons.IRegionFilterState Filter { get; private set; }

    private global::Sungero.Commons.IRegionFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public RegionFilteringServerHandler(global::Sungero.Commons.IRegionFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected RegionFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class RegionUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.Commons.IRegion
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class RegionSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.Commons.Server.RegionSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Commons.Server.RegionSearchDialogModel)this.Dialog;
       }
     }

     public RegionSearchDialogServerHandler(global::Sungero.Commons.Server.RegionSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class RegionServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.Commons.IRegion _obj
    {
      get { return (global::Sungero.Commons.IRegion)this.Entity; }
    }

    public RegionServerHandlers(global::Sungero.Commons.IRegion entity)
      : base(entity)
    {
    }
  }

  public partial class RegionCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.Commons.IRegion _source
    {
      get { return (global::Sungero.Commons.IRegion)this.Source; }
    }

    private global::Sungero.Commons.IRegionInfo _info
    {
      get { return (global::Sungero.Commons.IRegionInfo)this._Info; }
    }

    public RegionCreatingFromServerHandler(global::Sungero.Commons.IRegion source, global::Sungero.Commons.IRegionInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// RegionEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
}

// ==================================================================
// RegionAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
  public class RegionAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.Commons.IRegionAccessRights
  {

    public RegionAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class RegionTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.Commons.IRegionAccessRights
  {

    public RegionTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// RegionRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
    public class RegionRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.Commons.IRegionRepositoryImplementer<T>
      where T : global::Sungero.Commons.IRegion 
    {
       public new global::Sungero.Commons.IRegionAccessRights AccessRights
       {
          get { return (global::Sungero.Commons.IRegionAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Commons.IRegionInfo Info
       {
          get { return (global::Sungero.Commons.IRegionInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Commons.Server.RegionTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// RegionPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
}

// ==================================================================
// RegionServerFunctions.g.cs
// ==================================================================

namespace Sungero.Commons.Server
{
  public partial class RegionFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.Commons.IRegion _obj
    {
      get { return (global::Sungero.Commons.IRegion)this.Entity; }
    }

    public RegionFunctions(global::Sungero.Commons.IRegion entity) : base(entity) { }
  }
}

// ==================================================================
// RegionFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Functions
{
  internal static class Region
  {
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.RegionFunctions" />
    internal static  global::Sungero.Commons.IRegion GetRegionFromAddress(global::System.String address)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Commons.Server.RegionFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetRegionFromAddress",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::Sungero.Commons.IRegion)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { address });
      }
      else
      {
        return global::Sungero.Commons.Server.RegionFunctions.GetRegionFromAddress(address);
      }
    }

  }
}

// ==================================================================
// RegionServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
  public class RegionServerPublicFunctions : global::Sungero.Commons.Server.IRegionServerPublicFunctions
  {
    public global::Sungero.Commons.IRegion GetRegionFromAddress(global::System.String address)
    {
      return global::Sungero.Commons.Functions.Region.GetRegionFromAddress(address);
    }
  }
}

// ==================================================================
// RegionQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Queries
{
  public class Region
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Commons.Server.Region.RegionQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
