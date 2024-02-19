
// ==================================================================
// ReceiptNotificationSendingTaskEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Client
{ 
  public class ReceiptNotificationSendingTaskBoxValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IBusinessUnitBox>
  {
    public ReceiptNotificationSendingTaskBoxValueInputEventArgs(global::Sungero.ExchangeCore.IBusinessUnitBox oldValue, global::Sungero.ExchangeCore.IBusinessUnitBox newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ReceiptNotificationSendingTaskAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ReceiptNotificationSendingTaskAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// ReceiptNotificationSendingTaskHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange
{

  public partial class ReceiptNotificationSendingTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Exchange.IReceiptNotificationSendingTaskFilterState Filter { get; private set; }

    private global::Sungero.Exchange.IReceiptNotificationSendingTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ReceiptNotificationSendingTaskFilteringClientHandler(global::Sungero.Exchange.IReceiptNotificationSendingTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ReceiptNotificationSendingTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ReceiptNotificationSendingTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingTask _obj
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingTask)this.Entity; }
    }

    public virtual void BoxValueInput(global::Sungero.Exchange.Client.ReceiptNotificationSendingTaskBoxValueInputEventArgs e) { }



    public virtual void AddresseeValueInput(global::Sungero.Exchange.Client.ReceiptNotificationSendingTaskAddresseeValueInputEventArgs e) { }


    public ReceiptNotificationSendingTaskClientHandlers(global::Sungero.Exchange.IReceiptNotificationSendingTask entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ReceiptNotificationSendingTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.Exchange.Client
{
  public partial class ReceiptNotificationSendingTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingTask _obj
    {
      get { return (global::Sungero.Exchange.IReceiptNotificationSendingTask)this.Entity; }
    }

    public ReceiptNotificationSendingTaskFunctions(global::Sungero.Exchange.IReceiptNotificationSendingTask entity) : base(entity) { }
  }
}

// ==================================================================
// ReceiptNotificationSendingTaskFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Functions
{
  internal static class ReceiptNotificationSendingTask
  {
  }
}

// ==================================================================
// ReceiptNotificationSendingTaskClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Client
{
  public class ReceiptNotificationSendingTaskClientPublicFunctions : global::Sungero.Exchange.Client.IReceiptNotificationSendingTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// ReceiptNotificationSendingTaskActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Client
{
  public partial class ReceiptNotificationSendingTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.Exchange.IReceiptNotificationSendingTask _obj { get { return (global::Sungero.Exchange.IReceiptNotificationSendingTask)this.Entity; } }
    public ReceiptNotificationSendingTaskActions(global::Sungero.Exchange.IReceiptNotificationSendingTask entity) : base(entity) { }
  }

  public partial class ReceiptNotificationSendingTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Exchange.IReceiptNotificationSendingTask> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Exchange.IReceiptNotificationSendingTask>(this.Entities); }
    }
  }

  public partial class ReceiptNotificationSendingTaskCollectionBulkActions : global::Sungero.Workflow.Client.TaskCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ReceiptNotificationSendingTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class ReceiptNotificationSendingTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }



}