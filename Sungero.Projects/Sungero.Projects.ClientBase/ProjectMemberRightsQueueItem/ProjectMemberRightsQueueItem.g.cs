
// ==================================================================
// ProjectMemberRightsQueueItemEventArgs.g.cs
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
// ProjectMemberRightsQueueItemHandlers.g.cs
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

  public partial class ProjectMemberRightsQueueItemFilteringClientHandler
    : global::Sungero.Projects.ProjectQueueItemBaseFilteringClientHandler
  {
    private global::Sungero.Projects.IProjectMemberRightsQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.Projects.IProjectMemberRightsQueueItemFilterState)this.Filter;
      }
    }

    public ProjectMemberRightsQueueItemFilteringClientHandler(global::Sungero.Projects.IProjectMemberRightsQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected ProjectMemberRightsQueueItemFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ProjectMemberRightsQueueItemClientHandlers : global::Sungero.Projects.ProjectQueueItemBaseClientHandlers
  {
    private global::Sungero.Projects.IProjectMemberRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectMemberRightsQueueItem)this.Entity; }
    }

    public ProjectMemberRightsQueueItemClientHandlers(global::Sungero.Projects.IProjectMemberRightsQueueItem entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectMemberRightsQueueItemClientFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Client
{
  public partial class ProjectMemberRightsQueueItemFunctions : global::Sungero.Projects.Client.ProjectQueueItemBaseFunctions
  {
    private global::Sungero.Projects.IProjectMemberRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectMemberRightsQueueItem)this.Entity; }
    }

    public ProjectMemberRightsQueueItemFunctions(global::Sungero.Projects.IProjectMemberRightsQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectMemberRightsQueueItemFunctions.g.cs
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
  internal static class ProjectMemberRightsQueueItem
  {
  }
}

// ==================================================================
// ProjectMemberRightsQueueItemClientPublicFunctions.g.cs
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
  public class ProjectMemberRightsQueueItemClientPublicFunctions : global::Sungero.Projects.Client.IProjectMemberRightsQueueItemClientPublicFunctions
  {
  }
}

// ==================================================================
// ProjectMemberRightsQueueItemActions.g.cs
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
  public partial class ProjectMemberRightsQueueItemActions : global::Sungero.Projects.Client.ProjectQueueItemBaseActions
  {
    private global::Sungero.Projects.IProjectMemberRightsQueueItem _obj { get { return (global::Sungero.Projects.IProjectMemberRightsQueueItem)this.Entity; } }
    public ProjectMemberRightsQueueItemActions(global::Sungero.Projects.IProjectMemberRightsQueueItem entity) : base(entity) { }
  }

  public partial class ProjectMemberRightsQueueItemCollectionActions : global::Sungero.Projects.Client.ProjectQueueItemBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Projects.IProjectMemberRightsQueueItem> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Projects.IProjectMemberRightsQueueItem>(this.Entities); }
    }
  }

  public partial class ProjectMemberRightsQueueItemCollectionBulkActions : global::Sungero.Projects.Client.ProjectQueueItemBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ProjectMemberRightsQueueItemAnyChildEntityActions : global::Sungero.Projects.Client.ProjectQueueItemBaseAnyChildEntityActions
  {
  }

  public partial class ProjectMemberRightsQueueItemAnyChildEntityCollectionActions : global::Sungero.Projects.Client.ProjectQueueItemBaseAnyChildEntityCollectionActions
  {
  }



}
