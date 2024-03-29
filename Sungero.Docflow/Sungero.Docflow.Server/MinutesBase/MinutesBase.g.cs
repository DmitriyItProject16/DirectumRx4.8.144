
// ==================================================================
// MinutesBase.g.cs
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
    public class MinutesBaseFilter<T> :
      global::Sungero.Docflow.Server.InternalDocumentBaseFilter<T>
      where T : class, global::Sungero.Docflow.IMinutesBase
    {
      private global::Sungero.Docflow.IMinutesBaseFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IMinutesBaseFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public MinutesBaseFilter(global::Sungero.Docflow.IMinutesBaseFilterState filter)
      : base(filter)
      {
      }

      protected MinutesBaseFilter()
      {
      }
    }
    public class MinutesBaseSearchDialogModel : global::Sungero.Docflow.Server.InternalDocumentBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> PreparedBy { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }




                   public new MinutesBaseVersionsModel Versions { get { return (MinutesBaseVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new MinutesBaseTrackingModel Tracking { get { return (MinutesBaseTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }

        }

      public class MinutesBaseVersionsModel : global::Sungero.Docflow.Server.InternalDocumentBaseVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class MinutesBaseTrackingModel : global::Sungero.Docflow.Server.InternalDocumentBaseTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.MinutesBaseFilter<global::Sungero.Docflow.IMinutesBase>))]

  public class MinutesBase :
    global::Sungero.Docflow.Server.InternalDocumentBase, global::Sungero.Docflow.IMinutesBase, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f9a837b7-289e-4f03-a920-0284a778bcbf");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.MinutesBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IMinutesBase, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IMinutesBaseState State
    {
      get { return (global::Sungero.Docflow.IMinutesBaseState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseState(this);
    }

    public new virtual global::Sungero.Docflow.IMinutesBaseInfo Info
    {
      get { return (global::Sungero.Docflow.IMinutesBaseInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IMinutesBaseAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IMinutesBaseAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.MinutesBaseAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.MinutesBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.MinutesBaseServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.MinutesBaseSharedHandlers(this);
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IMinutesBaseVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IMinutesBaseTracking>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.MinutesBaseCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IMinutesBase)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.MinutesBaseCreatingFromServerHandler((global::Sungero.Docflow.IMinutesBase)entitySource, this.Info);
    }

    #region Framework events





    #endregion


    public MinutesBase()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.MinutesBaseConvertingFromServerHandler", (global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityConvertingFromServerHandler)instance;

      return new global::Sungero.Docflow.MinutesBaseConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// MinutesBaseHandlers.g.cs
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

  public partial class MinutesBaseFilteringServerHandler<T>
    : global::Sungero.Docflow.InternalDocumentBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IMinutesBase
  {
    private global::Sungero.Docflow.IMinutesBaseFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IMinutesBaseFilterState)this.Filter;
      }
    }

    public MinutesBaseFilteringServerHandler(global::Sungero.Docflow.IMinutesBaseFilterState filter)
    : base(filter)
    {
    }

    protected MinutesBaseFilteringServerHandler()
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


  }

  public partial class MinutesBaseSearchDialogServerHandler : global::Sungero.Docflow.InternalDocumentBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.MinutesBaseSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.MinutesBaseSearchDialogModel)this.Dialog;
       }
     }

     public MinutesBaseSearchDialogServerHandler(global::Sungero.Docflow.Server.MinutesBaseSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class MinutesBaseServerHandlers : global::Sungero.Docflow.InternalDocumentBaseServerHandlers
  {
    private global::Sungero.Docflow.IMinutesBase _obj
    {
      get { return (global::Sungero.Docflow.IMinutesBase)this.Entity; }
    }

    public MinutesBaseServerHandlers(global::Sungero.Docflow.IMinutesBase entity)
      : base(entity)
    {
    }
  }

  public partial class MinutesBaseCreatingFromServerHandler : global::Sungero.Docflow.InternalDocumentBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IMinutesBase _source
    {
      get { return (global::Sungero.Docflow.IMinutesBase)this.Source; }
    }

    private global::Sungero.Docflow.IMinutesBaseInfo _info
    {
      get { return (global::Sungero.Docflow.IMinutesBaseInfo)this._Info; }
    }

    public MinutesBaseCreatingFromServerHandler(global::Sungero.Docflow.IMinutesBase source, global::Sungero.Docflow.IMinutesBaseInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// MinutesBaseEventArgs.g.cs
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
// MinutesBaseAccessRights.g.cs
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
  public class MinutesBaseAccessRights : 
    Sungero.Docflow.Server.InternalDocumentBaseAccessRights, Sungero.Docflow.IMinutesBaseAccessRights
  {

    public MinutesBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class MinutesBaseTypeAccessRights : 
    Sungero.Docflow.Server.InternalDocumentBaseTypeAccessRights, Sungero.Docflow.IMinutesBaseAccessRights
  {

    public MinutesBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// MinutesBaseRepositoryImplementer.g.cs
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
    public class MinutesBaseRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.InternalDocumentBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IMinutesBaseRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IMinutesBase 
    {
       public new global::Sungero.Docflow.IMinutesBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IMinutesBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IMinutesBaseInfo Info
       {
          get { return (global::Sungero.Docflow.IMinutesBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.MinutesBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// MinutesBasePanelNavigationFilters.g.cs
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
    public class MinutesBaseDocumentRegisterPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDocumentRegisterPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IMinutesBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentRegister>)query;
        var typedState = (global::Sungero.Docflow.IMinutesBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.MinutesBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentRegisterFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentRegister>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IMinutesBase>(query);
      }
    }

    public class MinutesBaseDocumentKindPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDocumentKindPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IMinutesBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>)query;
        var typedState = (global::Sungero.Docflow.IMinutesBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.MinutesBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentKindFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentKind>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IMinutesBase>(query);
      }
    }

    public class MinutesBaseBusinessUnitPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseBusinessUnitPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IMinutesBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.Docflow.IMinutesBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.MinutesBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IMinutesBase>(query);
      }
    }

    public class MinutesBaseDepartmentPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDepartmentPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.IMinutesBase
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IDepartment>)query;
        var typedState = (global::Sungero.Docflow.IMinutesBaseFilterState)this.State;
        var handlers = new global::Sungero.Docflow.MinutesBaseFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DepartmentFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IDepartment>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.IMinutesBase>(query);
      }
    }

}

// ==================================================================
// MinutesBaseServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class MinutesBaseFunctions : global::Sungero.Docflow.Server.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.IMinutesBase _obj
    {
      get { return (global::Sungero.Docflow.IMinutesBase)this.Entity; }
    }

    public MinutesBaseFunctions(global::Sungero.Docflow.IMinutesBase entity) : base(entity) { }
  }
}

// ==================================================================
// MinutesBaseFunctions.g.cs
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
  internal static class MinutesBase
  {
  }
}

// ==================================================================
// MinutesBaseServerPublicFunctions.g.cs
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
  public class MinutesBaseServerPublicFunctions : global::Sungero.Docflow.Server.IMinutesBaseServerPublicFunctions
  {
  }
}

// ==================================================================
// MinutesBaseQueries.g.cs
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
  public class MinutesBase
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.MinutesBase.MinutesBaseQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// MinutesBaseServerHandlers.g.cs
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
  public partial class MinutesBaseConvertingFromServerHandler : global::Sungero.Docflow.InternalDocumentBaseConvertingFromServerHandler
  { 
    private global::Sungero.Docflow.IMinutesBaseInfo _info
    {
      get { return (global::Sungero.Docflow.IMinutesBaseInfo)this._Info; }
    }

    public MinutesBaseConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.Docflow.IMinutesBaseInfo info)
      : base(source, info)
    {
    }
  }
}
