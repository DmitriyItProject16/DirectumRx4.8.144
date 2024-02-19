
// ==================================================================
// FreeApprovalAssignmentEventArgs.g.cs
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
  public class FreeApprovalAssignmentAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public FreeApprovalAssignmentAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// FreeApprovalAssignmentHandlers.g.cs
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

  public partial class FreeApprovalAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IFreeApprovalAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IFreeApprovalAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public FreeApprovalAssignmentFilteringClientHandler(global::Sungero.Docflow.IFreeApprovalAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected FreeApprovalAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class FreeApprovalAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Entity; }
    }

    public FreeApprovalAssignmentClientHandlers(global::Sungero.Docflow.IFreeApprovalAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// FreeApprovalAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class FreeApprovalAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Entity; }
    }

    public FreeApprovalAssignmentFunctions(global::Sungero.Docflow.IFreeApprovalAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalAssignmentFunctions.g.cs
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
  internal static class FreeApprovalAssignment
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.FreeApprovalAssignmentFunctions" />
    internal static  global::System.Boolean ConfirmCompleteAssignment(global::Sungero.Docflow.IFreeApprovalAssignment freeApprovalAssignment, Domain.Shared.IActionInfo action)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalAssignment).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ConfirmCompleteAssignment", new System.Type[] { typeof(Domain.Shared.IActionInfo) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { action });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FreeApprovalAssignmentFunctions" />
      internal static  global::System.Boolean CanForwardTo(global::Sungero.Docflow.IFreeApprovalAssignment freeApprovalAssignment, global::Sungero.Company.IEmployee employee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("01be6c28-8785-4f74-9877-e3270704452e"),
          "CanForwardTo(global::Sungero.Docflow.IFreeApprovalAssignment,global::Sungero.Company.IEmployee)"
          , freeApprovalAssignment, employee);
      }

    }
  }
}

// ==================================================================
// FreeApprovalAssignmentClientPublicFunctions.g.cs
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
  public class FreeApprovalAssignmentClientPublicFunctions : global::Sungero.Docflow.Client.IFreeApprovalAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalAssignmentActions.g.cs
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
  public partial class FreeApprovalAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _obj { get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Entity; } }
    public FreeApprovalAssignmentActions(global::Sungero.Docflow.IFreeApprovalAssignment entity) : base(entity) { }
  }

  public partial class FreeApprovalAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IFreeApprovalAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IFreeApprovalAssignment>(this.Entities); }
    }
  }

  public partial class FreeApprovalAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class FreeApprovalAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class FreeApprovalAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
