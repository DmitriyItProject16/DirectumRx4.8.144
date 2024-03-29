
// ==================================================================
// OutgoingInvoiceEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{ 
}

// ==================================================================
// OutgoingInvoiceHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts
{

  public partial class OutgoingInvoiceFilteringClientHandler
    : global::Sungero.Docflow.AccountingDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Contracts.IOutgoingInvoiceFilterState _filter
    {
      get
      {
        return (Sungero.Contracts.IOutgoingInvoiceFilterState)this.Filter;
      }
    }

    public OutgoingInvoiceFilteringClientHandler(global::Sungero.Contracts.IOutgoingInvoiceFilterState filter)
    : base(filter)
    {
    }

    protected OutgoingInvoiceFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class OutgoingInvoiceClientHandlers : global::Sungero.Docflow.AccountingDocumentBaseClientHandlers
  {
    private global::Sungero.Contracts.IOutgoingInvoice _obj
    {
      get { return (global::Sungero.Contracts.IOutgoingInvoice)this.Entity; }
    }

    public OutgoingInvoiceClientHandlers(global::Sungero.Contracts.IOutgoingInvoice entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// OutgoingInvoiceClientFunctions.g.cs
// ==================================================================

namespace Sungero.Contracts.Client
{
  public partial class OutgoingInvoiceFunctions : global::Sungero.Docflow.Client.AccountingDocumentBaseFunctions
  {
    private global::Sungero.Contracts.IOutgoingInvoice _obj
    {
      get { return (global::Sungero.Contracts.IOutgoingInvoice)this.Entity; }
    }

    public OutgoingInvoiceFunctions(global::Sungero.Contracts.IOutgoingInvoice entity) : base(entity) { }
  }
}

// ==================================================================
// OutgoingInvoiceFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Functions
{
  internal static class OutgoingInvoice
  {
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.OutgoingInvoiceFunctions" />
    internal static  void FillName(global::Sungero.Contracts.IOutgoingInvoice outgoingInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.OutgoingInvoiceFunctions" />
    internal static  void UpdateLifeCycle(global::Sungero.Contracts.IOutgoingInvoice outgoingInvoice, global::System.Nullable<global::Sungero.Core.Enumeration> registrationState, global::System.Nullable<global::Sungero.Core.Enumeration> approvalState, global::System.Nullable<global::Sungero.Core.Enumeration> counterpartyApprovalState)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("UpdateLifeCycle", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { registrationState, approvalState, counterpartyApprovalState });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.OutgoingInvoiceFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee> GetEmailAddressees(global::Sungero.Contracts.IOutgoingInvoice outgoingInvoice)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEmailAddressees", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.OutgoingInvoiceFunctions" />
    internal static  global::System.Boolean NeedCounterpartySign(global::Sungero.Contracts.IOutgoingInvoice outgoingInvoice, global::Sungero.ExchangeCore.IBusinessUnitBox senderBox, global::System.Boolean isPrimaryDocument, global::System.Boolean needSign)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingInvoice).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedCounterpartySign", new System.Type[] { typeof(global::Sungero.ExchangeCore.IBusinessUnitBox), typeof(global::System.Boolean), typeof(global::System.Boolean) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { senderBox, isPrimaryDocument, needSign });
    }

  }
}

// ==================================================================
// OutgoingInvoiceClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class OutgoingInvoiceClientPublicFunctions : global::Sungero.Contracts.Client.IOutgoingInvoiceClientPublicFunctions
  {
  }
}

// ==================================================================
// OutgoingInvoiceActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public partial class OutgoingInvoiceActions : global::Sungero.Docflow.Client.AccountingDocumentBaseActions
  {
    private global::Sungero.Contracts.IOutgoingInvoice _obj { get { return (global::Sungero.Contracts.IOutgoingInvoice)this.Entity; } }
    public OutgoingInvoiceActions(global::Sungero.Contracts.IOutgoingInvoice entity) : base(entity) { }
  }

  public partial class OutgoingInvoiceCollectionActions : global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Contracts.IOutgoingInvoice> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Contracts.IOutgoingInvoice>(this.Entities); }
    }
  }

  public partial class OutgoingInvoiceCollectionBulkActions : global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class OutgoingInvoiceAnyChildEntityActions : global::Sungero.Docflow.Client.AccountingDocumentBaseAnyChildEntityActions
  {
  }

  public partial class OutgoingInvoiceAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.AccountingDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
