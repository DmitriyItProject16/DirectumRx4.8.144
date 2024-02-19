
// ==================================================================
// AcquaintanceCompleteNotificationEventArgs.g.cs
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
// AcquaintanceCompleteNotificationHandlers.g.cs
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

  public partial class AcquaintanceCompleteNotificationFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public AcquaintanceCompleteNotificationFilteringClientHandler(global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected AcquaintanceCompleteNotificationFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class AcquaintanceCompleteNotificationClientHandlers : global::Sungero.Workflow.NoticeClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceCompleteNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceCompleteNotification)this.Entity; }
    }

    public AcquaintanceCompleteNotificationClientHandlers(global::Sungero.RecordManagement.IAcquaintanceCompleteNotification entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AcquaintanceCompleteNotificationClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class AcquaintanceCompleteNotificationFunctions : global::Sungero.Workflow.Client.NoticeFunctions
  {
    private global::Sungero.RecordManagement.IAcquaintanceCompleteNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceCompleteNotification)this.Entity; }
    }

    public AcquaintanceCompleteNotificationFunctions(global::Sungero.RecordManagement.IAcquaintanceCompleteNotification entity) : base(entity) { }
  }
}

// ==================================================================
// AcquaintanceCompleteNotificationFunctions.g.cs
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
  internal static class AcquaintanceCompleteNotification
  {
  }
}

// ==================================================================
// AcquaintanceCompleteNotificationClientPublicFunctions.g.cs
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
  public class AcquaintanceCompleteNotificationClientPublicFunctions : global::Sungero.RecordManagement.Client.IAcquaintanceCompleteNotificationClientPublicFunctions
  {
  }
}

// ==================================================================
// AcquaintanceCompleteNotificationActions.g.cs
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
  public partial class AcquaintanceCompleteNotificationActions : global::Sungero.Workflow.Client.NoticeActions
  {
    private global::Sungero.RecordManagement.IAcquaintanceCompleteNotification _obj { get { return (global::Sungero.RecordManagement.IAcquaintanceCompleteNotification)this.Entity; } }
    public AcquaintanceCompleteNotificationActions(global::Sungero.RecordManagement.IAcquaintanceCompleteNotification entity) : base(entity) { }
  }

  public partial class AcquaintanceCompleteNotificationCollectionActions : global::Sungero.Workflow.Client.NoticeCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IAcquaintanceCompleteNotification> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IAcquaintanceCompleteNotification>(this.Entities); }
    }
  }

  public partial class AcquaintanceCompleteNotificationCollectionBulkActions : global::Sungero.Workflow.Client.NoticeCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AcquaintanceCompleteNotificationAnyChildEntityActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityActions
  {
  }

  public partial class AcquaintanceCompleteNotificationAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityCollectionActions
  {
  }



}
