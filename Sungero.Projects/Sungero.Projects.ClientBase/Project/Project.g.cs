
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

namespace Sungero.Projects.Client
{ 
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

  public partial class ProjectFilteringClientHandler
    : global::Sungero.Projects.ProjectCoreFilteringClientHandler
  {
    private global::Sungero.Projects.IProjectFilterState _filter
    {
      get
      {
        return (Sungero.Projects.IProjectFilterState)this.Filter;
      }
    }

    public ProjectFilteringClientHandler(global::Sungero.Projects.IProjectFilterState filter)
    : base(filter)
    {
    }

    protected ProjectFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ProjectClientHandlers : global::Sungero.Projects.ProjectCoreClientHandlers
  {
    private global::Sungero.Projects.IProject _obj
    {
      get { return (global::Sungero.Projects.IProject)this.Entity; }
    }

    public ProjectClientHandlers(global::Sungero.Projects.IProject entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectClientFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Client
{
  public partial class ProjectFunctions : global::Sungero.Projects.Client.ProjectCoreFunctions
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
    internal static class Remote
    {
      /// <redirect project="Sungero.Projects.Server" type="Sungero.Projects.Server.ProjectFunctions" />
      internal static  global::Sungero.Projects.IProject CreateProject()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Projects.IProject>(
          global::System.Guid.Parse("4383f2ff-56e6-46f4-b4ef-cc17e6aeef40"),
          "CreateProject()"
      );
      }

    }
  }
}

// ==================================================================
// ProjectClientPublicFunctions.g.cs
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
  public class ProjectClientPublicFunctions : global::Sungero.Projects.Client.IProjectClientPublicFunctions
  {
  }
}

// ==================================================================
// ProjectActions.g.cs
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
  public partial class ProjectActions : global::Sungero.Projects.Client.ProjectCoreActions
  {
    private global::Sungero.Projects.IProject _obj { get { return (global::Sungero.Projects.IProject)this.Entity; } }
    public ProjectActions(global::Sungero.Projects.IProject entity) : base(entity) { }
  }

  public partial class ProjectCollectionActions : global::Sungero.Projects.Client.ProjectCoreCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Projects.IProject> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Projects.IProject>(this.Entities); }
    }
  }

  public partial class ProjectCollectionBulkActions : global::Sungero.Projects.Client.ProjectCoreCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ProjectAnyChildEntityActions : global::Sungero.Projects.Client.ProjectCoreAnyChildEntityActions
  {
  }

  public partial class ProjectAnyChildEntityCollectionActions : global::Sungero.Projects.Client.ProjectCoreAnyChildEntityCollectionActions
  {
  }



}
