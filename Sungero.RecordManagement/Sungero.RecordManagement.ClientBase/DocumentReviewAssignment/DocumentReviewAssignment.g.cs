
// ==================================================================
// DocumentReviewAssignmentEventArgs.g.cs
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
  public class DocumentReviewAssignmentAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public DocumentReviewAssignmentAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// DocumentReviewAssignmentHandlers.g.cs
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

  public partial class DocumentReviewAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IDocumentReviewAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IDocumentReviewAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DocumentReviewAssignmentFilteringClientHandler(global::Sungero.RecordManagement.IDocumentReviewAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DocumentReviewAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DocumentReviewAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.RecordManagement.IDocumentReviewAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewAssignment)this.Entity; }
    }

    public virtual void AddresseeValueInput(global::Sungero.RecordManagement.Client.DocumentReviewAssignmentAddresseeValueInputEventArgs e) { }


    public DocumentReviewAssignmentClientHandlers(global::Sungero.RecordManagement.IDocumentReviewAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DocumentReviewAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class DocumentReviewAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IDocumentReviewAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewAssignment)this.Entity; }
    }

    public DocumentReviewAssignmentFunctions(global::Sungero.RecordManagement.IDocumentReviewAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentReviewAssignmentFunctions.g.cs
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
  internal static class DocumentReviewAssignment
  {
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewAssignmentFunctions" />
    internal static  void CheckOverdueActionItemExecutionTasks(global::Sungero.RecordManagement.IDocumentReviewAssignment documentReviewAssignment, Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewAssignment).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckOverdueActionItemExecutionTasks", new System.Type[] { typeof(Sungero.Workflow.Client.ExecuteResultActionArgs) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }

    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewAssignmentFunctions" />
    internal static  global::System.Boolean HasDocumentAndCanRead(global::Sungero.RecordManagement.IDocumentReviewAssignment documentReviewAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasDocumentAndCanRead", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewAssignmentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask> GetDraftOverdueActionItemExecutionTasks(global::Sungero.RecordManagement.IDocumentReviewAssignment documentReviewAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDraftOverdueActionItemExecutionTasks", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewAssignmentFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IDocumentReviewAssignment documentReviewAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("50e39d87-4fc6-4847-8bad-20847b9ba020"),
          "GetStateView(global::Sungero.RecordManagement.IDocumentReviewAssignment)"
          , documentReviewAssignment);
      }

    }
  }
}

// ==================================================================
// DocumentReviewAssignmentClientPublicFunctions.g.cs
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
  public class DocumentReviewAssignmentClientPublicFunctions : global::Sungero.RecordManagement.Client.IDocumentReviewAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// DocumentReviewAssignmentActions.g.cs
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
  public partial class DocumentReviewAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.RecordManagement.IDocumentReviewAssignment _obj { get { return (global::Sungero.RecordManagement.IDocumentReviewAssignment)this.Entity; } }
    public DocumentReviewAssignmentActions(global::Sungero.RecordManagement.IDocumentReviewAssignment entity) : base(entity) { }
  }

  public partial class DocumentReviewAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IDocumentReviewAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IDocumentReviewAssignment>(this.Entities); }
    }
  }

  public partial class DocumentReviewAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class DocumentReviewAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class DocumentReviewAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
