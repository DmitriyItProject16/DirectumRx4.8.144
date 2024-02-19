
// ==================================================================
// CounterpartyDocument.g.cs
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
    public class CounterpartyDocumentFilter<T> :
      global::Sungero.Docflow.Server.InternalDocumentBaseFilter<T>
      where T : class, global::Sungero.Docflow.ICounterpartyDocument
    {
      private global::Sungero.Docflow.ICounterpartyDocumentFilterState filter
      {
        get
        {
          return (Sungero.Docflow.ICounterpartyDocumentFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        var args = new global::Sungero.Domain.FilteringEventArgs();
        global::System.Linq.IQueryable<T> result;
        var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.CounterpartyDocumentFilteringServerHandler`1");
        if (filterType != null)
        {
          var genericType = filterType.MakeGenericType(typeof(T));
          var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { this.filter });
          var methodInfo = genericType.GetMethod("Filtering");
          result = (global::System.Linq.IQueryable<T>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
        }
        else
        {
          result = new global::Sungero.Docflow.CounterpartyDocumentFilteringServerHandler<T>(this.filter).Filtering(query, args);
        }
        if (args.DisableCheckRights)
        global::Sungero.Domain.Security.FilteringAccessRightsOptions.DisableCheckRights<T>();
        return result;
      }

      public CounterpartyDocumentFilter(global::Sungero.Docflow.ICounterpartyDocumentFilterState filter)
      : base(filter)
      {
      }

      protected CounterpartyDocumentFilter()
      {
      }
    }
    public class CounterpartyDocumentSearchDialogModel : global::Sungero.Docflow.Server.InternalDocumentBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> PreparedBy { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Parties.ICounterparty> Counterparty { get; protected set; }


                   public new CounterpartyDocumentVersionsModel Versions { get { return (CounterpartyDocumentVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new CounterpartyDocumentTrackingModel Tracking { get { return (CounterpartyDocumentTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }

        }

      public class CounterpartyDocumentVersionsModel : global::Sungero.Docflow.Server.InternalDocumentBaseVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class CounterpartyDocumentTrackingModel : global::Sungero.Docflow.Server.InternalDocumentBaseTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }




  public class CounterpartyDocumentFilterForCounterparty<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Parties.ICounterparty
    where TSourceEntity : class, global::Sungero.Docflow.ICounterpartyDocument
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.CounterpartyDocumentCounterpartyPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("CounterpartyFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.CounterpartyDocumentCounterpartyPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).CounterpartyFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public CounterpartyDocumentFilterForCounterparty(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class CounterpartyDocumentSearchFilterForCounterparty<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Parties.ICounterparty
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.CounterpartyDocumentCounterpartySearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("CounterpartySearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.CounterpartyDocumentCounterpartySearchPropertyFilteringServerHandler<TQueryEntity>().CounterpartySearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public CounterpartyDocumentSearchFilterForCounterparty(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.CounterpartyDocumentFilter<global::Sungero.Docflow.ICounterpartyDocument>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.CounterpartyDocumentFilterForCounterparty<global::Sungero.Parties.ICounterparty, global::Sungero.Docflow.ICounterpartyDocument>), "Counterparty")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.CounterpartyDocumentSearchFilterForCounterparty<global::Sungero.Parties.ICounterparty>), "Counterparty")]


  public class CounterpartyDocument :
    global::Sungero.Docflow.Server.InternalDocumentBase, global::Sungero.Docflow.ICounterpartyDocument, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("49d0c5e7-7069-44d2-8eb6-6e3098fc8b10");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.CounterpartyDocument.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ICounterpartyDocument, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.ICounterpartyDocumentState State
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.CounterpartyDocumentState(this);
    }

    public new virtual global::Sungero.Docflow.ICounterpartyDocumentInfo Info
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.ICounterpartyDocumentAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.CounterpartyDocumentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.CounterpartyDocumentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.CounterpartyDocumentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.CounterpartyDocumentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.CounterpartyDocumentSharedHandlers(this);
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



    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.ICounterpartyDocumentVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.ICounterpartyDocumentTracking>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.CounterpartyDocumentCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.ICounterpartyDocument)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.CounterpartyDocumentCreatingFromServerHandler((global::Sungero.Docflow.ICounterpartyDocument)entitySource, this.Info);
    }

    #region Framework events

    protected void CounterpartyChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.CounterpartyDocumentCounterpartyChangedEventArgs(this.State.Properties.Counterparty, this.Counterparty, this);
     ((global::Sungero.Docflow.ICounterpartyDocumentSharedHandlers)this.SharedHandlers).CounterpartyChanged(args);
    }





    #endregion


    public CounterpartyDocument()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.CounterpartyDocumentConvertingFromServerHandler", (global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityConvertingFromServerHandler)instance;

      return new global::Sungero.Docflow.CounterpartyDocumentConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// CounterpartyDocumentHandlers.g.cs
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
  public partial class CounterpartyDocumentCounterpartyPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.ICounterparty
  {
    private global::Sungero.Docflow.ICounterpartyDocument _obj
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> CounterpartyFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public CounterpartyDocumentCounterpartyPropertyFilteringServerHandler(global::Sungero.Docflow.ICounterpartyDocument entity)
      : base(entity)
    {
    }
  }

  public partial class CounterpartyDocumentCounterpartySearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.ICounterparty
  {

    public virtual global::System.Linq.IQueryable<T> CounterpartySearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public CounterpartyDocumentCounterpartySearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class CounterpartyDocumentFilteringServerHandler<T>
    : global::Sungero.Docflow.InternalDocumentBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.ICounterpartyDocument
  {
    private global::Sungero.Docflow.ICounterpartyDocumentFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.ICounterpartyDocumentFilterState)this.Filter;
      }
    }

    public CounterpartyDocumentFilteringServerHandler(global::Sungero.Docflow.ICounterpartyDocumentFilterState filter)
    : base(filter)
    {
    }

    protected CounterpartyDocumentFilteringServerHandler()
    {
    }

      public override global::System.Linq.IQueryable<Sungero.Docflow.IDocumentRegister> DocumentRegisterFiltering(global::System.Linq.IQueryable<Sungero.Docflow.IDocumentRegister> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.DocumentRegisterFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Docflow.IDocumentKind> DocumentKindFiltering(global::System.Linq.IQueryable<Sungero.Docflow.IDocumentKind> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.DocumentKindFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> BusinessUnitFiltering(global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.BusinessUnitFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Company.IDepartment> DepartmentFiltering(global::System.Linq.IQueryable<Sungero.Company.IDepartment> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.DepartmentFiltering(query, e);
              return query;
      }



  }

  public partial class CounterpartyDocumentSearchDialogServerHandler : global::Sungero.Docflow.InternalDocumentBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.CounterpartyDocumentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.CounterpartyDocumentSearchDialogModel)this.Dialog;
       }
     }

     public CounterpartyDocumentSearchDialogServerHandler(global::Sungero.Docflow.Server.CounterpartyDocumentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class CounterpartyDocumentServerHandlers : global::Sungero.Docflow.InternalDocumentBaseServerHandlers
  {
    private global::Sungero.Docflow.ICounterpartyDocument _obj
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Entity; }
    }

    public CounterpartyDocumentServerHandlers(global::Sungero.Docflow.ICounterpartyDocument entity)
      : base(entity)
    {
    }
  }

  public partial class CounterpartyDocumentCreatingFromServerHandler : global::Sungero.Docflow.InternalDocumentBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.ICounterpartyDocument _source
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Source; }
    }

    private global::Sungero.Docflow.ICounterpartyDocumentInfo _info
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentInfo)this._Info; }
    }

    public CounterpartyDocumentCreatingFromServerHandler(global::Sungero.Docflow.ICounterpartyDocument source, global::Sungero.Docflow.ICounterpartyDocumentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// CounterpartyDocumentEventArgs.g.cs
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
// CounterpartyDocumentAccessRights.g.cs
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
  public class CounterpartyDocumentAccessRights : 
    Sungero.Docflow.Server.InternalDocumentBaseAccessRights, Sungero.Docflow.ICounterpartyDocumentAccessRights
  {

    public CounterpartyDocumentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CounterpartyDocumentTypeAccessRights : 
    Sungero.Docflow.Server.InternalDocumentBaseTypeAccessRights, Sungero.Docflow.ICounterpartyDocumentAccessRights
  {

    public CounterpartyDocumentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// CounterpartyDocumentRepositoryImplementer.g.cs
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
    public class CounterpartyDocumentRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.InternalDocumentBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.ICounterpartyDocumentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.ICounterpartyDocument 
    {
       public new global::Sungero.Docflow.ICounterpartyDocumentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.ICounterpartyDocumentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.ICounterpartyDocumentInfo Info
       {
          get { return (global::Sungero.Docflow.ICounterpartyDocumentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.CounterpartyDocumentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CounterpartyDocumentPanelNavigationFilters.g.cs
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
    public class CounterpartyDocumentDocumentRegisterPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDocumentRegisterPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ICounterpartyDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentRegister>)query;
        var typedState = (global::Sungero.Docflow.ICounterpartyDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.CounterpartyDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentRegisterFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentRegister>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ICounterpartyDocument>(query);
      }
    }

    public class CounterpartyDocumentDocumentKindPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDocumentKindPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ICounterpartyDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>)query;
        var typedState = (global::Sungero.Docflow.ICounterpartyDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.CounterpartyDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentKindFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentKind>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ICounterpartyDocument>(query);
      }
    }

    public class CounterpartyDocumentBusinessUnitPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseBusinessUnitPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ICounterpartyDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.Docflow.ICounterpartyDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.CounterpartyDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ICounterpartyDocument>(query);
      }
    }

    public class CounterpartyDocumentDepartmentPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDepartmentPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ICounterpartyDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IDepartment>)query;
        var typedState = (global::Sungero.Docflow.ICounterpartyDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.CounterpartyDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DepartmentFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IDepartment>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ICounterpartyDocument>(query);
      }
    }

    public class CounterpartyDocumentKindPanelNavigationFilter : global::Sungero.Domain.PanelNavigationFilterBase
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ICounterpartyDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>)query;
        var typedState = (global::Sungero.Docflow.ICounterpartyDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.CounterpartyDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.KindFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentKind>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ICounterpartyDocument>(query);
      }
    }

}

// ==================================================================
// CounterpartyDocumentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class CounterpartyDocumentFunctions : global::Sungero.Docflow.Server.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.ICounterpartyDocument _obj
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Entity; }
    }

    public CounterpartyDocumentFunctions(global::Sungero.Docflow.ICounterpartyDocument entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyDocumentFunctions.g.cs
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
  internal static class CounterpartyDocument
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetCounterparties(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterparties", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void FillName(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void SetLifeCycleState(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleState", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void RefreshDocumentForm(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RefreshDocumentForm", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// CounterpartyDocumentServerPublicFunctions.g.cs
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
  public class CounterpartyDocumentServerPublicFunctions : global::Sungero.Docflow.Server.ICounterpartyDocumentServerPublicFunctions
  {
  }
}

// ==================================================================
// CounterpartyDocumentQueries.g.cs
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
  public class CounterpartyDocument
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.CounterpartyDocument.CounterpartyDocumentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// CounterpartyDocumentServerHandlers.g.cs
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
  public partial class CounterpartyDocumentConvertingFromServerHandler : global::Sungero.Docflow.InternalDocumentBaseConvertingFromServerHandler
  { 
    private global::Sungero.Docflow.ICounterpartyDocumentInfo _info
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentInfo)this._Info; }
    }

    public CounterpartyDocumentConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.Docflow.ICounterpartyDocumentInfo info)
      : base(source, info)
    {
    }
  }
}
