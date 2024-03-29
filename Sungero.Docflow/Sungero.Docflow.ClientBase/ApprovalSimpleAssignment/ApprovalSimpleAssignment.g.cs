
// ==================================================================
// ApprovalSimpleAssignmentEventArgs.g.cs
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
// ApprovalSimpleAssignmentHandlers.g.cs
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

  public partial class ApprovalSimpleAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalSimpleAssignmentFilteringClientHandler(global::Sungero.Docflow.IApprovalSimpleAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalSimpleAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ApprovalSimpleAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.Docflow.IApprovalSimpleAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignment)this.Entity; }
    }

    public virtual void StageSubjectValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void StageNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public ApprovalSimpleAssignmentClientHandlers(global::Sungero.Docflow.IApprovalSimpleAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalSimpleAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ApprovalSimpleAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalSimpleAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalSimpleAssignment)this.Entity; }
    }

    public ApprovalSimpleAssignmentFunctions(global::Sungero.Docflow.IApprovalSimpleAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalSimpleAssignmentFunctions.g.cs
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
  internal static class ApprovalSimpleAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalSimpleAssignmentFunctions" />
      internal static global::System.String  GetStagesStateView(global::Sungero.Docflow.IApprovalSimpleAssignment approvalSimpleAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("b0931934-7981-4139-a398-f0e39abbb981"),
          "GetStagesStateView(global::Sungero.Docflow.IApprovalSimpleAssignment)"
          , approvalSimpleAssignment);
      }

    }
  }
}

// ==================================================================
// ApprovalSimpleAssignmentClientPublicFunctions.g.cs
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
  public class ApprovalSimpleAssignmentClientPublicFunctions : global::Sungero.Docflow.Client.IApprovalSimpleAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalSimpleAssignmentActions.g.cs
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
  public partial class ApprovalSimpleAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.Docflow.IApprovalSimpleAssignment _obj { get { return (global::Sungero.Docflow.IApprovalSimpleAssignment)this.Entity; } }
    public ApprovalSimpleAssignmentActions(global::Sungero.Docflow.IApprovalSimpleAssignment entity) : base(entity) { }
  }

  public partial class ApprovalSimpleAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalSimpleAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalSimpleAssignment>(this.Entities); }
    }
  }

  public partial class ApprovalSimpleAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ApprovalSimpleAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class ApprovalSimpleAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
