
// ==================================================================
// ActionItemObserversNotificationEventArgs.g.cs
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
}

// ==================================================================
// ActionItemObserversNotificationHandlers.g.cs
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

  public partial class ActionItemObserversNotificationFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IActionItemObserversNotificationFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IActionItemObserversNotificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ActionItemObserversNotificationFilteringClientHandler(global::Sungero.RecordManagement.IActionItemObserversNotificationFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ActionItemObserversNotificationFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ActionItemObserversNotificationClientHandlers : global::Sungero.Workflow.NoticeClientHandlers
  {
    private global::Sungero.RecordManagement.IActionItemObserversNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemObserversNotification)this.Entity; }
    }

    public ActionItemObserversNotificationClientHandlers(global::Sungero.RecordManagement.IActionItemObserversNotification entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ActionItemObserversNotificationClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class ActionItemObserversNotificationFunctions : global::Sungero.Workflow.Client.NoticeFunctions
  {
    private global::Sungero.RecordManagement.IActionItemObserversNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemObserversNotification)this.Entity; }
    }

    public ActionItemObserversNotificationFunctions(global::Sungero.RecordManagement.IActionItemObserversNotification entity) : base(entity) { }
  }
}

// ==================================================================
// ActionItemObserversNotificationFunctions.g.cs
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
  internal static class ActionItemObserversNotification
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemObserversNotificationFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IActionItemObserversNotification actionItemObserversNotification)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("ab194340-550c-41c7-badd-adc2ee208741"),
          "GetStateView(global::Sungero.RecordManagement.IActionItemObserversNotification)"
          , actionItemObserversNotification);
      }

    }
  }
}

// ==================================================================
// ActionItemObserversNotificationClientPublicFunctions.g.cs
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
  public class ActionItemObserversNotificationClientPublicFunctions : global::Sungero.RecordManagement.Client.IActionItemObserversNotificationClientPublicFunctions
  {
  }
}

// ==================================================================
// ActionItemObserversNotificationActions.g.cs
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
  public partial class ActionItemObserversNotificationActions : global::Sungero.Workflow.Client.NoticeActions
  {
    private global::Sungero.RecordManagement.IActionItemObserversNotification _obj { get { return (global::Sungero.RecordManagement.IActionItemObserversNotification)this.Entity; } }
    public ActionItemObserversNotificationActions(global::Sungero.RecordManagement.IActionItemObserversNotification entity) : base(entity) { }
  }

  public partial class ActionItemObserversNotificationCollectionActions : global::Sungero.Workflow.Client.NoticeCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IActionItemObserversNotification> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IActionItemObserversNotification>(this.Entities); }
    }
  }

  public partial class ActionItemObserversNotificationCollectionBulkActions : global::Sungero.Workflow.Client.NoticeCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ActionItemObserversNotificationAnyChildEntityActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityActions
  {
  }

  public partial class ActionItemObserversNotificationAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityCollectionActions
  {
  }



}