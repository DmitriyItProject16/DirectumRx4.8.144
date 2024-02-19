
// ==================================================================
// PowerOfAttorney.g.cs
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
    public class PowerOfAttorneyFilter<T> :
      global::Sungero.Docflow.Server.PowerOfAttorneyBaseFilter<T>
      where T : class, global::Sungero.Docflow.IPowerOfAttorney
    {
      private global::Sungero.Docflow.IPowerOfAttorneyFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IPowerOfAttorneyFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public PowerOfAttorneyFilter(global::Sungero.Docflow.IPowerOfAttorneyFilterState filter)
      : base(filter)
      {
      }

      protected PowerOfAttorneyFilter()
      {
      }
    }
    public class PowerOfAttorneySearchDialogModel : global::Sungero.Docflow.Server.PowerOfAttorneyBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String Powers { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> PreparedBy { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> AgentType { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.ICounterparty> IssuedToParty { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.IPerson> Representative { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> ValidFrom { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }




                   public new PowerOfAttorneyVersionsModel Versions { get { return (PowerOfAttorneyVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new PowerOfAttorneyTrackingModel Tracking { get { return (PowerOfAttorneyTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }

        }

      public class PowerOfAttorneyVersionsModel : global::Sungero.Docflow.Server.PowerOfAttorneyBaseVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class PowerOfAttorneyTrackingModel : global::Sungero.Docflow.Server.PowerOfAttorneyBaseTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.PowerOfAttorneyFilter<global::Sungero.Docflow.IPowerOfAttorney>))]

  public class PowerOfAttorney :
    global::Sungero.Docflow.Server.PowerOfAttorneyBase, global::Sungero.Docflow.IPowerOfAttorney, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("be859f9b-7a04-4f07-82bc-441352bce627");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.PowerOfAttorney.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IPowerOfAttorney, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyState State
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyState(this);
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyInfo Info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.PowerOfAttorneyAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.PowerOfAttorneyFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.PowerOfAttorneyServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.PowerOfAttorneySharedHandlers(this);
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IPowerOfAttorneyVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IPowerOfAttorneyTracking>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.PowerOfAttorneyCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IPowerOfAttorney)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.PowerOfAttorneyCreatingFromServerHandler((global::Sungero.Docflow.IPowerOfAttorney)entitySource, this.Info);
    }

    #region Framework events





    #endregion


    public PowerOfAttorney()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.PowerOfAttorneyConvertingFromServerHandler", (global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityConvertingFromServerHandler)instance;

      return new global::Sungero.Docflow.PowerOfAttorneyConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// PowerOfAttorneyHandlers.g.cs
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

  public partial class PowerOfAttorneyFilteringServerHandler<T>
    : global::Sungero.Docflow.PowerOfAttorneyBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IPowerOfAttorney
  {
    private global::Sungero.Docflow.IPowerOfAttorneyFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IPowerOfAttorneyFilterState)this.Filter;
      }
    }

    public PowerOfAttorneyFilteringServerHandler(global::Sungero.Docflow.IPowerOfAttorneyFilterState filter)
    : base(filter)
    {
    }

    protected PowerOfAttorneyFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
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

      public override global::System.Linq.IQueryable<Sungero.Parties.ICounterparty> PerformerFiltering(global::System.Linq.IQueryable<Sungero.Parties.ICounterparty> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.PerformerFiltering(query, e);
              return query;
      }


  }

  public partial class PowerOfAttorneySearchDialogServerHandler : global::Sungero.Docflow.PowerOfAttorneyBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.PowerOfAttorneySearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.PowerOfAttorneySearchDialogModel)this.Dialog;
       }
     }

     public PowerOfAttorneySearchDialogServerHandler(global::Sungero.Docflow.Server.PowerOfAttorneySearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class PowerOfAttorneyServerHandlers : global::Sungero.Docflow.PowerOfAttorneyBaseServerHandlers
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; }
    }

    public PowerOfAttorneyServerHandlers(global::Sungero.Docflow.IPowerOfAttorney entity)
      : base(entity)
    {
    }
  }

  public partial class PowerOfAttorneyCreatingFromServerHandler : global::Sungero.Docflow.PowerOfAttorneyBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IPowerOfAttorney _source
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Source; }
    }

    private global::Sungero.Docflow.IPowerOfAttorneyInfo _info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyInfo)this._Info; }
    }

    public PowerOfAttorneyCreatingFromServerHandler(global::Sungero.Docflow.IPowerOfAttorney source, global::Sungero.Docflow.IPowerOfAttorneyInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyEventArgs.g.cs
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
// PowerOfAttorneyAccessRights.g.cs
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
  public class PowerOfAttorneyAccessRights : 
    Sungero.Docflow.Server.PowerOfAttorneyBaseAccessRights, Sungero.Docflow.IPowerOfAttorneyAccessRights
  {

    public PowerOfAttorneyAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class PowerOfAttorneyTypeAccessRights : 
    Sungero.Docflow.Server.PowerOfAttorneyBaseTypeAccessRights, Sungero.Docflow.IPowerOfAttorneyAccessRights
  {

    public PowerOfAttorneyTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// PowerOfAttorneyRepositoryImplementer.g.cs
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
    public class PowerOfAttorneyRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.PowerOfAttorneyBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IPowerOfAttorneyRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IPowerOfAttorney 
    {
       public new global::Sungero.Docflow.IPowerOfAttorneyAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IPowerOfAttorneyAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IPowerOfAttorneyInfo Info
       {
          get { return (global::Sungero.Docflow.IPowerOfAttorneyInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.PowerOfAttorneyTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// PowerOfAttorneyPanelNavigationFilters.g.cs
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
    public class PowerOfAttorneyDocumentRegisterPanelNavigationFilter : global::Sungero.Docflow.Server.PowerOfAttorneyBaseDocumentRegisterPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorney
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentRegister>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentRegisterFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentRegister>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorney>(query);
      }
    }

    public class PowerOfAttorneyDocumentKindPanelNavigationFilter : global::Sungero.Docflow.Server.PowerOfAttorneyBaseDocumentKindPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorney
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentKindFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentKind>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorney>(query);
      }
    }

    public class PowerOfAttorneyBusinessUnitPanelNavigationFilter : global::Sungero.Docflow.Server.PowerOfAttorneyBaseBusinessUnitPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorney
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorney>(query);
      }
    }

    public class PowerOfAttorneyDepartmentPanelNavigationFilter : global::Sungero.Docflow.Server.PowerOfAttorneyBaseDepartmentPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorney
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IDepartment>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DepartmentFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IDepartment>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorney>(query);
      }
    }

    public class PowerOfAttorneyPerformerPanelNavigationFilter : global::Sungero.Docflow.Server.PowerOfAttorneyBasePerformerPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IPowerOfAttorney
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Parties.ICounterparty>)query;
        var typedState = (global::Sungero.Docflow.IPowerOfAttorneyFilterState)this.State;
        var handlers = new global::Sungero.Docflow.PowerOfAttorneyFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.PerformerFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Parties.ICounterparty>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IPowerOfAttorney>(query);
      }
    }

}

// ==================================================================
// PowerOfAttorneyServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class PowerOfAttorneyFunctions : global::Sungero.Docflow.Server.PowerOfAttorneyBaseFunctions
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; }
    }

    public PowerOfAttorneyFunctions(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyFunctions.g.cs
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
  internal static class PowerOfAttorney
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney> GetActivePowerOfAttorneys(global::Sungero.Company.IEmployee employee, global::System.Nullable<global::System.DateTime> date)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.PowerOfAttorneyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetActivePowerOfAttorneys",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Company.IEmployee), typeof(global::System.Nullable<global::System.DateTime>) }, null);
        return (global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { employee, date });
      }
      else
      {
        return global::Sungero.Docflow.Server.PowerOfAttorneyFunctions.GetActivePowerOfAttorneys(employee, date);
      }
    }

  }
}

// ==================================================================
// PowerOfAttorneyServerPublicFunctions.g.cs
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
  public class PowerOfAttorneyServerPublicFunctions : global::Sungero.Docflow.Server.IPowerOfAttorneyServerPublicFunctions
  {
  }
}

// ==================================================================
// PowerOfAttorneyQueries.g.cs
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
  public class PowerOfAttorney
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.PowerOfAttorney.PowerOfAttorneyQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// PowerOfAttorneyServerHandlers.g.cs
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
  public partial class PowerOfAttorneyConvertingFromServerHandler : global::Sungero.Docflow.PowerOfAttorneyBaseConvertingFromServerHandler
  { 
    private global::Sungero.Docflow.IPowerOfAttorneyInfo _info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyInfo)this._Info; }
    }

    public PowerOfAttorneyConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.Docflow.IPowerOfAttorneyInfo info)
      : base(source, info)
    {
    }
  }
}
