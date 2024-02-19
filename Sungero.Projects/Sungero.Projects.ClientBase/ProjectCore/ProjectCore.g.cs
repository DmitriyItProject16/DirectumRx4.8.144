
// ==================================================================
// ProjectCoreEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{ 
  public class ProjectCoreProjectKindValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Projects.IProjectKind>
  {
    public ProjectCoreProjectKindValueInputEventArgs(global::Sungero.Projects.IProjectKind oldValue, global::Sungero.Projects.IProjectKind newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ProjectCoreInternalCustomerValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ProjectCoreInternalCustomerValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ProjectCoreExternalCustomerValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public ProjectCoreExternalCustomerValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }





  public class ProjectCoreManagerValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ProjectCoreManagerValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ProjectCoreFolderValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.CoreEntities.IFolder>
  {
    public ProjectCoreFolderValueInputEventArgs(global::Sungero.CoreEntities.IFolder oldValue, global::Sungero.CoreEntities.IFolder newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ProjectCoreLeadingProjectValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Projects.IProjectCore>
  {
    public ProjectCoreLeadingProjectValueInputEventArgs(global::Sungero.Projects.IProjectCore oldValue, global::Sungero.Projects.IProjectCore newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ProjectCoreAdministratorValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ProjectCoreAdministratorValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }






}

// ==================================================================
// ProjectCoreHandlers.g.cs
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

  public partial class ProjectCoreFilteringClientHandler
    : global::Sungero.Docflow.ProjectBaseFilteringClientHandler
  {
    private global::Sungero.Projects.IProjectCoreFilterState _filter
    {
      get
      {
        return (Sungero.Projects.IProjectCoreFilterState)this.Filter;
      }
    }

    public ProjectCoreFilteringClientHandler(global::Sungero.Projects.IProjectCoreFilterState filter)
    : base(filter)
    {
    }

    protected ProjectCoreFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ProjectCoreClientHandlers : global::Sungero.Docflow.ProjectBaseClientHandlers
  {
    private global::Sungero.Projects.IProjectCore _obj
    {
      get { return (global::Sungero.Projects.IProjectCore)this.Entity; }
    }

    public virtual void ProjectKindValueInput(global::Sungero.Projects.Client.ProjectCoreProjectKindValueInputEventArgs e) { }




    public virtual void ExternalCustomerValueInput(global::Sungero.Projects.Client.ProjectCoreExternalCustomerValueInputEventArgs e) { }




    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }




    public virtual void FolderValueInput(global::Sungero.Projects.Client.ProjectCoreFolderValueInputEventArgs e) { }








    public virtual void StageValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void ModifiedValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public ProjectCoreClientHandlers(global::Sungero.Projects.IProjectCore entity) : base(entity)
    {
    }
  }

  public partial class ProjectCoreTeamMembersClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Projects.IProjectCoreTeamMembers _obj
    {
      get { return (global::Sungero.Projects.IProjectCoreTeamMembers)this.Entity; }
    }
    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> TeamMembersGroupFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public ProjectCoreTeamMembersClientHandlers(global::Sungero.Projects.IProjectCoreTeamMembers entity) : base(entity)
    {
    }
  }

  public partial class ProjectCoreClassifierClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Projects.IProjectCoreClassifier _obj
    {
      get { return (global::Sungero.Projects.IProjectCoreClassifier)this.Entity; }
    }
    public virtual void ClassifierFolderNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ClassifierDocumentKindValueInput(global::Sungero.Projects.Client.ProjectCoreClassifierDocumentKindValueInputEventArgs e) { }


    public virtual void ClassifierFolderValueInput(global::Sungero.Projects.Client.ProjectCoreClassifierFolderValueInputEventArgs e) { }


    public ProjectCoreClassifierClientHandlers(global::Sungero.Projects.IProjectCoreClassifier entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectCoreClientFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Client
{
  public partial class ProjectCoreFunctions : global::Sungero.Docflow.Client.ProjectBaseFunctions
  {
    private global::Sungero.Projects.IProjectCore _obj
    {
      get { return (global::Sungero.Projects.IProjectCore)this.Entity; }
    }

    public ProjectCoreFunctions(global::Sungero.Projects.IProjectCore entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectCoreFunctions.g.cs
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
  internal static class ProjectCore
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Projects.Server" type="Sungero.Projects.Server.ProjectCoreFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument> GetProjectDocuments(global::Sungero.Projects.IProjectCore projectCore)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument>>(
          global::System.Guid.Parse("561aa8c7-b281-494b-a0e4-0170c0b27f48"),
          "GetProjectDocuments(global::Sungero.Projects.IProjectCore)"
          , projectCore);
      }
      /// <redirect project="Sungero.Projects.Server" type="Sungero.Projects.Server.ProjectCoreFunctions" />
      internal static  global::Sungero.Docflow.IOfficialDocument CreateProjectDocument(global::Sungero.Projects.IProjectCore projectCore)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IOfficialDocument>(
          global::System.Guid.Parse("561aa8c7-b281-494b-a0e4-0170c0b27f48"),
          "CreateProjectDocument(global::Sungero.Projects.IProjectCore)"
          , projectCore);
      }

    }
  }
}

// ==================================================================
// ProjectCoreClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public class ProjectCoreClientPublicFunctions : global::Sungero.Projects.Client.IProjectCoreClientPublicFunctions
  {
  }
}

// ==================================================================
// ProjectCoreActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public partial class ProjectCoreActions : global::Sungero.Docflow.Client.ProjectBaseActions
  {
    private global::Sungero.Projects.IProjectCore _obj { get { return (global::Sungero.Projects.IProjectCore)this.Entity; } }
    public ProjectCoreActions(global::Sungero.Projects.IProjectCore entity) : base(entity) { }
  }

  public partial class ProjectCoreCollectionActions : global::Sungero.Docflow.Client.ProjectBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Projects.IProjectCore> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Projects.IProjectCore>(this.Entities); }
    }
  }

  public partial class ProjectCoreCollectionBulkActions : global::Sungero.Docflow.Client.ProjectBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ProjectCoreAnyChildEntityActions : global::Sungero.Docflow.Client.ProjectBaseAnyChildEntityActions
  {
  }

  public partial class ProjectCoreAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.ProjectBaseAnyChildEntityCollectionActions
  {
  }



}
