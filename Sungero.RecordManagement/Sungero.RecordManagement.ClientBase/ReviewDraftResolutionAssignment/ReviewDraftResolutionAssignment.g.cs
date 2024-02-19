
// ==================================================================
// ReviewDraftResolutionAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{ 
  public class ReviewDraftResolutionAssignmentAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ReviewDraftResolutionAssignmentAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// ReviewDraftResolutionAssignmentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

  public partial class ReviewDraftResolutionAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ReviewDraftResolutionAssignmentFilteringClientHandler(global::Sungero.RecordManagement.IReviewDraftResolutionAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ReviewDraftResolutionAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ReviewDraftResolutionAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Entity; }
    }

    public virtual void AddresseeValueInput(global::Sungero.RecordManagement.Client.ReviewDraftResolutionAssignmentAddresseeValueInputEventArgs e) { }


    public virtual void NeedDeleteActionItemsValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public ReviewDraftResolutionAssignmentClientHandlers(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReviewDraftResolutionAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class ReviewDraftResolutionAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Entity; }
    }

    public ReviewDraftResolutionAssignmentFunctions(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Functions
{
  internal static class ReviewDraftResolutionAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ReviewDraftResolutionAssignmentFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment reviewDraftResolutionAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("e2dd5bf3-54c8-4846-b158-9c42d09fbc33"),
          "GetStateView(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)"
          , reviewDraftResolutionAssignment);
      }

    }
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class ReviewDraftResolutionAssignmentClientPublicFunctions : global::Sungero.RecordManagement.Client.IReviewDraftResolutionAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// ReviewDraftResolutionAssignmentActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public partial class ReviewDraftResolutionAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.RecordManagement.IReviewDraftResolutionAssignment _obj { get { return (global::Sungero.RecordManagement.IReviewDraftResolutionAssignment)this.Entity; } }
    public ReviewDraftResolutionAssignmentActions(global::Sungero.RecordManagement.IReviewDraftResolutionAssignment entity) : base(entity) { }
  }

  public partial class ReviewDraftResolutionAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IReviewDraftResolutionAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IReviewDraftResolutionAssignment>(this.Entities); }
    }
  }

  public partial class ReviewDraftResolutionAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ReviewDraftResolutionAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class ReviewDraftResolutionAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
