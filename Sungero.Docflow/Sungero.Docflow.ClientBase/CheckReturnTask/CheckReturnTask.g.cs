
// ==================================================================
// CheckReturnTaskEventArgs.g.cs
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
  public class CheckReturnTaskAssigneeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public CheckReturnTaskAssigneeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



  public class CheckReturnTaskDocumentToReturnValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Content.IElectronicDocument>
  {
    public CheckReturnTaskDocumentToReturnValueInputEventArgs(global::Sungero.Content.IElectronicDocument oldValue, global::Sungero.Content.IElectronicDocument newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// CheckReturnTaskHandlers.g.cs
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

  public partial class CheckReturnTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.ICheckReturnTaskFilterState Filter { get; private set; }

    private global::Sungero.Docflow.ICheckReturnTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public CheckReturnTaskFilteringClientHandler(global::Sungero.Docflow.ICheckReturnTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected CheckReturnTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class CheckReturnTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.Docflow.ICheckReturnTask _obj
    {
      get { return (global::Sungero.Docflow.ICheckReturnTask)this.Entity; }
    }

    public virtual void AssigneeValueInput(global::Sungero.Docflow.Client.CheckReturnTaskAssigneeValueInputEventArgs e) { }


    public virtual void DeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void AssignmentStartDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void DocumentToReturnValueInput(global::Sungero.Docflow.Client.CheckReturnTaskDocumentToReturnValueInputEventArgs e) { }


    public CheckReturnTaskClientHandlers(global::Sungero.Docflow.ICheckReturnTask entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CheckReturnTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class CheckReturnTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.Docflow.ICheckReturnTask _obj
    {
      get { return (global::Sungero.Docflow.ICheckReturnTask)this.Entity; }
    }

    public CheckReturnTaskFunctions(global::Sungero.Docflow.ICheckReturnTask entity) : base(entity) { }
  }
}

// ==================================================================
// CheckReturnTaskFunctions.g.cs
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
  internal static class CheckReturnTask
  {
  }
}

// ==================================================================
// CheckReturnTaskClientPublicFunctions.g.cs
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
  public class CheckReturnTaskClientPublicFunctions : global::Sungero.Docflow.Client.ICheckReturnTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// CheckReturnTaskActions.g.cs
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
  public partial class CheckReturnTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.Docflow.ICheckReturnTask _obj { get { return (global::Sungero.Docflow.ICheckReturnTask)this.Entity; } }
    public CheckReturnTaskActions(global::Sungero.Docflow.ICheckReturnTask entity) : base(entity) { }
  }

  public partial class CheckReturnTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.ICheckReturnTask> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.ICheckReturnTask>(this.Entities); }
    }
  }

  public partial class CheckReturnTaskCollectionBulkActions : global::Sungero.Workflow.Client.TaskCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class CheckReturnTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class CheckReturnTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }



}
