
// ==================================================================
// ProjectKindEventArgs.g.cs
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
// ProjectKindHandlers.g.cs
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

  public partial class ProjectKindFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Projects.IProjectKindFilterState Filter { get; private set; }

    private global::Sungero.Projects.IProjectKindFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ProjectKindFilteringClientHandler(global::Sungero.Projects.IProjectKindFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ProjectKindFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ProjectKindClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Projects.IProjectKind _obj
    {
      get { return (global::Sungero.Projects.IProjectKind)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public ProjectKindClientHandlers(global::Sungero.Projects.IProjectKind entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectKindClientFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Client
{
  public partial class ProjectKindFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Projects.IProjectKind _obj
    {
      get { return (global::Sungero.Projects.IProjectKind)this.Entity; }
    }

    public ProjectKindFunctions(global::Sungero.Projects.IProjectKind entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectKindFunctions.g.cs
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
  internal static class ProjectKind
  {
  }
}

// ==================================================================
// ProjectKindClientPublicFunctions.g.cs
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
  public class ProjectKindClientPublicFunctions : global::Sungero.Projects.Client.IProjectKindClientPublicFunctions
  {
  }
}

// ==================================================================
// ProjectKindActions.g.cs
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
  public partial class ProjectKindActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Projects.IProjectKind _obj { get { return (global::Sungero.Projects.IProjectKind)this.Entity; } }
    public ProjectKindActions(global::Sungero.Projects.IProjectKind entity) : base(entity) { }
  }

  public partial class ProjectKindCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Projects.IProjectKind> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Projects.IProjectKind>(this.Entities); }
    }
  }

  public partial class ProjectKindCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ProjectKindAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class ProjectKindAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
