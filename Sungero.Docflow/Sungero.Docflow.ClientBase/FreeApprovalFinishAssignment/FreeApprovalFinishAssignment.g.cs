
// ==================================================================
// FreeApprovalFinishAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
}

// ==================================================================
// FreeApprovalFinishAssignmentHandlers.g.cs
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

  public partial class FreeApprovalFinishAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public FreeApprovalFinishAssignmentFilteringClientHandler(global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected FreeApprovalFinishAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class FreeApprovalFinishAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalFinishAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignment)this.Entity; }
    }

    public FreeApprovalFinishAssignmentClientHandlers(global::Sungero.Docflow.IFreeApprovalFinishAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// FreeApprovalFinishAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class FreeApprovalFinishAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalFinishAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignment)this.Entity; }
    }

    public FreeApprovalFinishAssignmentFunctions(global::Sungero.Docflow.IFreeApprovalFinishAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentFunctions.g.cs
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
  internal static class FreeApprovalFinishAssignment
  {
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class FreeApprovalFinishAssignmentClientPublicFunctions : global::Sungero.Docflow.Client.IFreeApprovalFinishAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public partial class FreeApprovalFinishAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.Docflow.IFreeApprovalFinishAssignment _obj { get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignment)this.Entity; } }
    public FreeApprovalFinishAssignmentActions(global::Sungero.Docflow.IFreeApprovalFinishAssignment entity) : base(entity) { }
  }

  public partial class FreeApprovalFinishAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IFreeApprovalFinishAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IFreeApprovalFinishAssignment>(this.Entities); }
    }
  }

  public partial class FreeApprovalFinishAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class FreeApprovalFinishAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class FreeApprovalFinishAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
