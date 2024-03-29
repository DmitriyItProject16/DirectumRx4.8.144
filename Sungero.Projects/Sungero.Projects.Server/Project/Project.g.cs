
// ==================================================================
// Project.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
    public class ProjectFilter<T> :
      global::Sungero.Projects.Server.ProjectCoreFilter<T>
      where T : class, global::Sungero.Projects.IProject
    {
      private global::Sungero.Projects.IProjectFilterState filter
      {
        get
        {
          return (Sungero.Projects.IProjectFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ProjectFilter(global::Sungero.Projects.IProjectFilterState filter)
      : base(filter)
      {
      }

      protected ProjectFilter()
      {
      }
    }
      public class ProjectUiFilter<T> :
        global::Sungero.Projects.Server.ProjectCoreUiFilter<T>
        where T : class, global::Sungero.Projects.IProject
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ProjectSearchDialogModel : global::Sungero.Projects.Server.ProjectCoreSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String ShortName { get; protected set; }
                  public override global::System.String Note { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Projects.IProjectKind> ProjectKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> InternalCustomer { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.ICounterparty> ExternalCustomer { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> StartDate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> EndDate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Manager { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Administrator { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> ActualStartDate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> ActualFinishDate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Stage { get; protected set; }




                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ProjectTeamMembersModel TeamMembers { get { return (ProjectTeamMembersModel)base.TeamMembers; } protected set { base.TeamMembers = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ProjectClassifierModel Classifier { get { return (ProjectClassifierModel)base.Classifier; } protected set { base.Classifier = value; } }

        }

      public class ProjectTeamMembersModel : global::Sungero.Projects.Server.ProjectCoreTeamMembersModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }
      public class ProjectClassifierModel : global::Sungero.Projects.Server.ProjectCoreClassifierModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Projects.Server.ProjectFilter<global::Sungero.Projects.IProject>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Projects.Server.ProjectUiFilter<global::Sungero.Projects.IProject>))]

  public class Project :
    global::Sungero.Projects.Server.ProjectCore, global::Sungero.Projects.IProject, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4383f2ff-56e6-46f4-b4ef-cc17e6aeef40");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Projects.Server.Project.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Projects.IProject, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Projects.IProjectState State
    {
      get { return (global::Sungero.Projects.IProjectState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Projects.Shared.ProjectState(this);
    }

    public new virtual global::Sungero.Projects.IProjectInfo Info
    {
      get { return (global::Sungero.Projects.IProjectInfo)base.Info; }
    }

    public new virtual global::Sungero.Projects.IProjectAccessRights AccessRights
    {
      get { return (global::Sungero.Projects.IProjectAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Projects.Server.ProjectAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Projects.Server.ProjectFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Projects.Shared.ProjectFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Projects.ProjectServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Projects.ProjectSharedHandlers(this);
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Projects.IProjectCoreTeamMembers> CreateTeamMembersCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Projects.IProjectTeamMembers>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Projects.IProjectCoreClassifier> CreateClassifierCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Projects.IProjectClassifier>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Projects.ProjectCreatingFromServerHandler", new object[] { (global::Sungero.Projects.IProject)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Projects.ProjectCreatingFromServerHandler((global::Sungero.Projects.IProject)entitySource, this.Info);
    }

    #region Framework events





    #endregion


    public Project()
    {
    }

  }
}

// ==================================================================
// ProjectHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects
{

  public partial class ProjectFilteringServerHandler<T>
    : global::Sungero.Projects.ProjectCoreFilteringServerHandler<T>  
    where T : class, global::Sungero.Projects.IProject
  {
    private global::Sungero.Projects.IProjectFilterState _filter
    {
      get
      {
        return (Sungero.Projects.IProjectFilterState)this.Filter;
      }
    }

    public ProjectFilteringServerHandler(global::Sungero.Projects.IProjectFilterState filter)
    : base(filter)
    {
    }

    protected ProjectFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }

      public override global::System.Linq.IQueryable<Sungero.Projects.IProjectKind> ProjectKindFiltering(global::System.Linq.IQueryable<Sungero.Projects.IProjectKind> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.ProjectKindFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Company.IEmployee> ProjectManagerFiltering(global::System.Linq.IQueryable<Sungero.Company.IEmployee> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.ProjectManagerFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Projects.IProjectCore> LeadingProjectFiltering(global::System.Linq.IQueryable<Sungero.Projects.IProjectCore> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.LeadingProjectFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Company.IEmployee> InternalCustomerFiltering(global::System.Linq.IQueryable<Sungero.Company.IEmployee> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.InternalCustomerFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Parties.ICounterparty> ExternalCustomerFiltering(global::System.Linq.IQueryable<Sungero.Parties.ICounterparty> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.ExternalCustomerFiltering(query, e);
              return query;
      }


  }

  public partial class ProjectUiFilteringServerHandler<T>
    : global::Sungero.Projects.ProjectCoreUiFilteringServerHandler<T>
    where T : class, global::Sungero.Projects.IProject
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ProjectSearchDialogServerHandler : global::Sungero.Projects.ProjectCoreSearchDialogServerHandler
   {
     private global::Sungero.Projects.Server.ProjectSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Projects.Server.ProjectSearchDialogModel)this.Dialog;
       }
     }

     public ProjectSearchDialogServerHandler(global::Sungero.Projects.Server.ProjectSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ProjectServerHandlers : global::Sungero.Projects.ProjectCoreServerHandlers
  {
    private global::Sungero.Projects.IProject _obj
    {
      get { return (global::Sungero.Projects.IProject)this.Entity; }
    }

    public ProjectServerHandlers(global::Sungero.Projects.IProject entity)
      : base(entity)
    {
    }
  }

  public partial class ProjectCreatingFromServerHandler : global::Sungero.Projects.ProjectCoreCreatingFromServerHandler
  {
    private global::Sungero.Projects.IProject _source
    {
      get { return (global::Sungero.Projects.IProject)this.Source; }
    }

    private global::Sungero.Projects.IProjectInfo _info
    {
      get { return (global::Sungero.Projects.IProjectInfo)this._Info; }
    }

    public ProjectCreatingFromServerHandler(global::Sungero.Projects.IProject source, global::Sungero.Projects.IProjectInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ProjectEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
}

// ==================================================================
// ProjectAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
  public class ProjectAccessRights : 
    Sungero.Projects.Server.ProjectCoreAccessRights, Sungero.Projects.IProjectAccessRights
  {

    public ProjectAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ProjectTypeAccessRights : 
    Sungero.Projects.Server.ProjectCoreTypeAccessRights, Sungero.Projects.IProjectAccessRights
  {

    public ProjectTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ProjectRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
    public class ProjectRepositoryImplementer<T> : 
      global::Sungero.Projects.Server.ProjectCoreRepositoryImplementer<T>,
      global::Sungero.Projects.IProjectRepositoryImplementer<T>
      where T : global::Sungero.Projects.IProject 
    {
       public new global::Sungero.Projects.IProjectAccessRights AccessRights
       {
          get { return (global::Sungero.Projects.IProjectAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Projects.IProjectInfo Info
       {
          get { return (global::Sungero.Projects.IProjectInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Projects.Server.ProjectTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ProjectPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
    public class ProjectProjectKindPanelNavigationFilter : global::Sungero.Projects.Server.ProjectCoreProjectKindPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Projects.IProject
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Projects.IProjectKind>)query;
        var typedState = (global::Sungero.Projects.IProjectFilterState)this.State;
        var handlers = new global::Sungero.Projects.ProjectFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.ProjectKindFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Projects.IProjectKind>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Projects.IProject>(query);
      }
    }

    public class ProjectProjectManagerPanelNavigationFilter : global::Sungero.Projects.Server.ProjectCoreProjectManagerPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Projects.IProject
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IEmployee>)query;
        var typedState = (global::Sungero.Projects.IProjectFilterState)this.State;
        var handlers = new global::Sungero.Projects.ProjectFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.ProjectManagerFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IEmployee>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Projects.IProject>(query);
      }
    }

    public class ProjectLeadingProjectPanelNavigationFilter : global::Sungero.Projects.Server.ProjectCoreLeadingProjectPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Projects.IProject
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Projects.IProjectCore>)query;
        var typedState = (global::Sungero.Projects.IProjectFilterState)this.State;
        var handlers = new global::Sungero.Projects.ProjectFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.LeadingProjectFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Projects.IProjectCore>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Projects.IProject>(query);
      }
    }

    public class ProjectInternalCustomerPanelNavigationFilter : global::Sungero.Projects.Server.ProjectCoreInternalCustomerPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Projects.IProject
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IEmployee>)query;
        var typedState = (global::Sungero.Projects.IProjectFilterState)this.State;
        var handlers = new global::Sungero.Projects.ProjectFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.InternalCustomerFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IEmployee>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Projects.IProject>(query);
      }
    }

    public class ProjectExternalCustomerPanelNavigationFilter : global::Sungero.Projects.Server.ProjectCoreExternalCustomerPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Projects.IProject
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Parties.ICounterparty>)query;
        var typedState = (global::Sungero.Projects.IProjectFilterState)this.State;
        var handlers = new global::Sungero.Projects.ProjectFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.ExternalCustomerFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Parties.ICounterparty>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Projects.IProject>(query);
      }
    }

}

// ==================================================================
// ProjectServerFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Server
{
  public partial class ProjectFunctions : global::Sungero.Projects.Server.ProjectCoreFunctions
  {
    private global::Sungero.Projects.IProject _obj
    {
      get { return (global::Sungero.Projects.IProject)this.Entity; }
    }

    public ProjectFunctions(global::Sungero.Projects.IProject entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Functions
{
  internal static class Project
  {
    /// <redirect project="Sungero.Projects.Server" type="Sungero.Projects.Server.ProjectFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::Sungero.Projects.IProject CreateProject()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Projects.Server.ProjectFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CreateProject",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::Sungero.Projects.IProject)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Projects.Server.ProjectFunctions.CreateProject();
      }
    }

  }
}

// ==================================================================
// ProjectServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
  public class ProjectServerPublicFunctions : global::Sungero.Projects.Server.IProjectServerPublicFunctions
  {
  }
}

// ==================================================================
// ProjectQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Queries
{
  public class Project
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Projects.Server.Project.ProjectQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
