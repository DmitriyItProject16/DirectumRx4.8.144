
// ==================================================================
// ApprovalCheckingAssignmentEventArgs.g.cs
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
  public class ApprovalCheckingAssignmentReworkPerformerValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ApprovalCheckingAssignmentReworkPerformerValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// ApprovalCheckingAssignmentHandlers.g.cs
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

  public partial class ApprovalCheckingAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalCheckingAssignmentFilteringClientHandler(global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalCheckingAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ApprovalCheckingAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Entity; }
    }

    public virtual void StageSubjectValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void StageNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void ReworkPerformerValueInput(global::Sungero.Docflow.Client.ApprovalCheckingAssignmentReworkPerformerValueInputEventArgs e) { }


    public ApprovalCheckingAssignmentClientHandlers(global::Sungero.Docflow.IApprovalCheckingAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalCheckingAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ApprovalCheckingAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Entity; }
    }

    public ApprovalCheckingAssignmentFunctions(global::Sungero.Docflow.IApprovalCheckingAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentFunctions.g.cs
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
  internal static class ApprovalCheckingAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalCheckingAssignmentFunctions" />
      internal static global::System.String  GetStagesStateView(global::Sungero.Docflow.IApprovalCheckingAssignment approvalCheckingAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("c09f0ae4-c959-4a57-9895-ae9aaf1f1855"),
          "GetStagesStateView(global::Sungero.Docflow.IApprovalCheckingAssignment)"
          , approvalCheckingAssignment);
      }

    }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentClientPublicFunctions.g.cs
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
  public class ApprovalCheckingAssignmentClientPublicFunctions : global::Sungero.Docflow.Client.IApprovalCheckingAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalCheckingAssignmentActions.g.cs
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
  public partial class ApprovalCheckingAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _obj { get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Entity; } }
    public ApprovalCheckingAssignmentActions(global::Sungero.Docflow.IApprovalCheckingAssignment entity) : base(entity) { }
  }

  public partial class ApprovalCheckingAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalCheckingAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalCheckingAssignment>(this.Entities); }
    }
  }

  public partial class ApprovalCheckingAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ApprovalCheckingAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class ApprovalCheckingAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
