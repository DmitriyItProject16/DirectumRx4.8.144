
// ==================================================================
// ProjectTeamEventArgs.g.cs
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
// ProjectTeamHandlers.g.cs
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

  public partial class ProjectTeamFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Projects.IProjectTeamFilterState Filter { get; private set; }

    private global::Sungero.Projects.IProjectTeamFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ProjectTeamFilteringClientHandler(global::Sungero.Projects.IProjectTeamFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ProjectTeamFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ProjectTeamClientHandlers : global::Sungero.CoreEntities.GroupClientHandlers
  {
    private global::Sungero.Projects.IProjectTeam _obj
    {
      get { return (global::Sungero.Projects.IProjectTeam)this.Entity; }
    }

    public ProjectTeamClientHandlers(global::Sungero.Projects.IProjectTeam entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectTeamClientFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Client
{
  public partial class ProjectTeamFunctions : global::Sungero.CoreEntities.Client.GroupFunctions
  {
    private global::Sungero.Projects.IProjectTeam _obj
    {
      get { return (global::Sungero.Projects.IProjectTeam)this.Entity; }
    }

    public ProjectTeamFunctions(global::Sungero.Projects.IProjectTeam entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectTeamFunctions.g.cs
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
  internal static class ProjectTeam
  {
  }
}

// ==================================================================
// ProjectTeamClientPublicFunctions.g.cs
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
  public class ProjectTeamClientPublicFunctions : global::Sungero.Projects.Client.IProjectTeamClientPublicFunctions
  {
  }
}

// ==================================================================
// ProjectTeamActions.g.cs
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
  public partial class ProjectTeamActions : global::Sungero.CoreEntities.Client.GroupActions
  {
    private global::Sungero.Projects.IProjectTeam _obj { get { return (global::Sungero.Projects.IProjectTeam)this.Entity; } }
    public ProjectTeamActions(global::Sungero.Projects.IProjectTeam entity) : base(entity) { }
  }

  public partial class ProjectTeamCollectionActions : global::Sungero.CoreEntities.Client.GroupCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Projects.IProjectTeam> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Projects.IProjectTeam>(this.Entities); }
    }
  }

  public partial class ProjectTeamCollectionBulkActions : global::Sungero.CoreEntities.Client.GroupCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ProjectTeamAnyChildEntityActions : global::Sungero.CoreEntities.Client.GroupAnyChildEntityActions
  {
  }

  public partial class ProjectTeamAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.GroupAnyChildEntityCollectionActions
  {
  }



}