
// ==================================================================
// MessageQueueItemEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{ 
  public class MessageQueueItemNoticeTaskValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Workflow.ITask>
  {
    public MessageQueueItemNoticeTaskValueInputEventArgs(global::Sungero.Workflow.ITask oldValue, global::Sungero.Workflow.ITask newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }






  public class MessageQueueItemDownloadSessionValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSession>
  {
    public MessageQueueItemDownloadSessionValueInputEventArgs(global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSession oldValue, global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSession newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// MessageQueueItemHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore
{

  public partial class MessageQueueItemFilteringClientHandler
    : global::Sungero.ExchangeCore.QueueItemBaseFilteringClientHandler
  {
    private global::Sungero.ExchangeCore.IMessageQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.ExchangeCore.IMessageQueueItemFilterState)this.Filter;
      }
    }

    public MessageQueueItemFilteringClientHandler(global::Sungero.ExchangeCore.IMessageQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected MessageQueueItemFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class MessageQueueItemClientHandlers : global::Sungero.ExchangeCore.QueueItemBaseClientHandlers
  {
    private global::Sungero.ExchangeCore.IMessageQueueItem _obj
    {
      get { return (global::Sungero.ExchangeCore.IMessageQueueItem)this.Entity; }
    }

    public virtual void NoticeTaskValueInput(global::Sungero.ExchangeCore.Client.MessageQueueItemNoticeTaskValueInputEventArgs e) { }



    public virtual void CreatedValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void CounterpartyExternalIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void RootMessageIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void IsRootMessageValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void DownloadSessionValueInput(global::Sungero.ExchangeCore.Client.MessageQueueItemDownloadSessionValueInputEventArgs e) { }


    public virtual void IsManualRestartValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public MessageQueueItemClientHandlers(global::Sungero.ExchangeCore.IMessageQueueItem entity) : base(entity)
    {
    }
  }

  public partial class MessageQueueItemDocumentsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.ExchangeCore.IMessageQueueItemDocuments _obj
    {
      get { return (global::Sungero.ExchangeCore.IMessageQueueItemDocuments)this.Entity; }
    }
    public virtual void DocumentsExternalIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void DocumentsTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> DocumentsTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public MessageQueueItemDocumentsClientHandlers(global::Sungero.ExchangeCore.IMessageQueueItemDocuments entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// MessageQueueItemClientFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Client
{
  public partial class MessageQueueItemFunctions : global::Sungero.ExchangeCore.Client.QueueItemBaseFunctions
  {
    private global::Sungero.ExchangeCore.IMessageQueueItem _obj
    {
      get { return (global::Sungero.ExchangeCore.IMessageQueueItem)this.Entity; }
    }

    public MessageQueueItemFunctions(global::Sungero.ExchangeCore.IMessageQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// MessageQueueItemFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Functions
{
  internal static class MessageQueueItem
  {
  }
}

// ==================================================================
// MessageQueueItemClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class MessageQueueItemClientPublicFunctions : global::Sungero.ExchangeCore.Client.IMessageQueueItemClientPublicFunctions
  {
  }
}

// ==================================================================
// MessageQueueItemActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public partial class MessageQueueItemActions : global::Sungero.ExchangeCore.Client.QueueItemBaseActions
  {
    private global::Sungero.ExchangeCore.IMessageQueueItem _obj { get { return (global::Sungero.ExchangeCore.IMessageQueueItem)this.Entity; } }
    public MessageQueueItemActions(global::Sungero.ExchangeCore.IMessageQueueItem entity) : base(entity) { }
  }

  public partial class MessageQueueItemCollectionActions : global::Sungero.ExchangeCore.Client.QueueItemBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.ExchangeCore.IMessageQueueItem> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.ExchangeCore.IMessageQueueItem>(this.Entities); }
    }
  }

  public partial class MessageQueueItemCollectionBulkActions : global::Sungero.ExchangeCore.Client.QueueItemBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class MessageQueueItemAnyChildEntityActions : global::Sungero.ExchangeCore.Client.QueueItemBaseAnyChildEntityActions
  {
  }

  public partial class MessageQueueItemAnyChildEntityCollectionActions : global::Sungero.ExchangeCore.Client.QueueItemBaseAnyChildEntityCollectionActions
  {
  }



}