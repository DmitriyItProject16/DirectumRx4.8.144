
// ==================================================================
// SimpleDocument.g.cs
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
    public class SimpleDocumentFilter<T> :
      global::Sungero.Docflow.Server.InternalDocumentBaseFilter<T>
      where T : class, global::Sungero.Docflow.ISimpleDocument
    {
      private global::Sungero.Docflow.ISimpleDocumentFilterState filter
      {
        get
        {
          return (Sungero.Docflow.ISimpleDocumentFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public SimpleDocumentFilter(global::Sungero.Docflow.ISimpleDocumentFilterState filter)
      : base(filter)
      {
      }

      protected SimpleDocumentFilter()
      {
      }
    }
    public class SimpleDocumentSearchDialogModel : global::Sungero.Docflow.Server.InternalDocumentBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> PreparedBy { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }




                   public new SimpleDocumentVersionsModel Versions { get { return (SimpleDocumentVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new SimpleDocumentTrackingModel Tracking { get { return (SimpleDocumentTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }

        }

      public class SimpleDocumentVersionsModel : global::Sungero.Docflow.Server.InternalDocumentBaseVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class SimpleDocumentTrackingModel : global::Sungero.Docflow.Server.InternalDocumentBaseTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.SimpleDocumentFilter<global::Sungero.Docflow.ISimpleDocument>))]

  public class SimpleDocument :
    global::Sungero.Docflow.Server.InternalDocumentBase, global::Sungero.Docflow.ISimpleDocument, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("09584896-81e2-4c83-8f6c-70eb8321e1d0");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.SimpleDocument.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ISimpleDocument, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.ISimpleDocumentState State
    {
      get { return (global::Sungero.Docflow.ISimpleDocumentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.SimpleDocumentState(this);
    }

    public new virtual global::Sungero.Docflow.ISimpleDocumentInfo Info
    {
      get { return (global::Sungero.Docflow.ISimpleDocumentInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.ISimpleDocumentAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.ISimpleDocumentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.SimpleDocumentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.SimpleDocumentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.SimpleDocumentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.SimpleDocumentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.SimpleDocumentSharedHandlers(this);
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.ISimpleDocumentVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.ISimpleDocumentTracking>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.SimpleDocumentCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.ISimpleDocument)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.SimpleDocumentCreatingFromServerHandler((global::Sungero.Docflow.ISimpleDocument)entitySource, this.Info);
    }

    #region Framework events





    #endregion


    public SimpleDocument()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.SimpleDocumentConvertingFromServerHandler", (global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityConvertingFromServerHandler)instance;

      return new global::Sungero.Docflow.SimpleDocumentConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// SimpleDocumentHandlers.g.cs
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

  public partial class SimpleDocumentFilteringServerHandler<T>
    : global::Sungero.Docflow.InternalDocumentBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.ISimpleDocument
  {
    private global::Sungero.Docflow.ISimpleDocumentFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.ISimpleDocumentFilterState)this.Filter;
      }
    }

    public SimpleDocumentFilteringServerHandler(global::Sungero.Docflow.ISimpleDocumentFilterState filter)
    : base(filter)
    {
    }

    protected SimpleDocumentFilteringServerHandler()
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

  public partial class SimpleDocumentSearchDialogServerHandler : global::Sungero.Docflow.InternalDocumentBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.SimpleDocumentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.SimpleDocumentSearchDialogModel)this.Dialog;
       }
     }

     public SimpleDocumentSearchDialogServerHandler(global::Sungero.Docflow.Server.SimpleDocumentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class SimpleDocumentServerHandlers : global::Sungero.Docflow.InternalDocumentBaseServerHandlers
  {
    private global::Sungero.Docflow.ISimpleDocument _obj
    {
      get { return (global::Sungero.Docflow.ISimpleDocument)this.Entity; }
    }

    public SimpleDocumentServerHandlers(global::Sungero.Docflow.ISimpleDocument entity)
      : base(entity)
    {
    }
  }

  public partial class SimpleDocumentCreatingFromServerHandler : global::Sungero.Docflow.InternalDocumentBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.ISimpleDocument _source
    {
      get { return (global::Sungero.Docflow.ISimpleDocument)this.Source; }
    }

    private global::Sungero.Docflow.ISimpleDocumentInfo _info
    {
      get { return (global::Sungero.Docflow.ISimpleDocumentInfo)this._Info; }
    }

    public SimpleDocumentCreatingFromServerHandler(global::Sungero.Docflow.ISimpleDocument source, global::Sungero.Docflow.ISimpleDocumentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// SimpleDocumentEventArgs.g.cs
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
// SimpleDocumentAccessRights.g.cs
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
  public class SimpleDocumentAccessRights : 
    Sungero.Docflow.Server.InternalDocumentBaseAccessRights, Sungero.Docflow.ISimpleDocumentAccessRights
  {

    public SimpleDocumentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class SimpleDocumentTypeAccessRights : 
    Sungero.Docflow.Server.InternalDocumentBaseTypeAccessRights, Sungero.Docflow.ISimpleDocumentAccessRights
  {

    public SimpleDocumentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// SimpleDocumentRepositoryImplementer.g.cs
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
    public class SimpleDocumentRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.InternalDocumentBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.ISimpleDocumentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.ISimpleDocument 
    {
       public new global::Sungero.Docflow.ISimpleDocumentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.ISimpleDocumentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.ISimpleDocumentInfo Info
       {
          get { return (global::Sungero.Docflow.ISimpleDocumentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.SimpleDocumentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// SimpleDocumentPanelNavigationFilters.g.cs
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
    public class SimpleDocumentDocumentRegisterPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDocumentRegisterPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ISimpleDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentRegister>)query;
        var typedState = (global::Sungero.Docflow.ISimpleDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.SimpleDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentRegisterFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentRegister>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ISimpleDocument>(query);
      }
    }

    public class SimpleDocumentDocumentKindPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDocumentKindPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ISimpleDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>)query;
        var typedState = (global::Sungero.Docflow.ISimpleDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.SimpleDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DocumentKindFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Docflow.IDocumentKind>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ISimpleDocument>(query);
      }
    }

    public class SimpleDocumentBusinessUnitPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseBusinessUnitPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ISimpleDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.Docflow.ISimpleDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.SimpleDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ISimpleDocument>(query);
      }
    }

    public class SimpleDocumentDepartmentPanelNavigationFilter : global::Sungero.Docflow.Server.InternalDocumentBaseDepartmentPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Docflow.ISimpleDocument
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IDepartment>)query;
        var typedState = (global::Sungero.Docflow.ISimpleDocumentFilterState)this.State;
        var handlers = new global::Sungero.Docflow.SimpleDocumentFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DepartmentFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IDepartment>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Docflow.ISimpleDocument>(query);
      }
    }

}

// ==================================================================
// SimpleDocumentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class SimpleDocumentFunctions : global::Sungero.Docflow.Server.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.ISimpleDocument _obj
    {
      get { return (global::Sungero.Docflow.ISimpleDocument)this.Entity; }
    }

    public SimpleDocumentFunctions(global::Sungero.Docflow.ISimpleDocument entity) : base(entity) { }
  }
}

// ==================================================================
// SimpleDocumentFunctions.g.cs
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
  internal static class SimpleDocument
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.ISimpleDocument simpleDocument, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeRegistrationPaneVisibility", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needShow, repeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  void RefreshDocumentForm(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RefreshDocumentForm", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsVerificationModeSupported", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasEmptyRequiredProperties", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// SimpleDocumentServerPublicFunctions.g.cs
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
  public class SimpleDocumentServerPublicFunctions : global::Sungero.Docflow.Server.ISimpleDocumentServerPublicFunctions
  {
  }
}

// ==================================================================
// SimpleDocumentQueries.g.cs
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
  public class SimpleDocument
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.SimpleDocument.SimpleDocumentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// SimpleDocumentServerHandlers.g.cs
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
  public partial class SimpleDocumentConvertingFromServerHandler : global::Sungero.Docflow.InternalDocumentBaseConvertingFromServerHandler
  { 
    private global::Sungero.Docflow.ISimpleDocumentInfo _info
    {
      get { return (global::Sungero.Docflow.ISimpleDocumentInfo)this._Info; }
    }

    public SimpleDocumentConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.Docflow.ISimpleDocumentInfo info)
      : base(source, info)
    {
    }
  }
}
