
// ==================================================================
// ContractualDocumentBaseEventArgs.g.cs
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
  public class ContractualDocumentBaseCounterpartyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public ContractualDocumentBaseCounterpartyValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ContractualDocumentBaseCounterpartySignatoryValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.IContact>
  {
    public ContractualDocumentBaseCounterpartySignatoryValueInputEventArgs(global::Sungero.Parties.IContact oldValue, global::Sungero.Parties.IContact newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ContractualDocumentBaseCurrencyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.ICurrency>
  {
    public ContractualDocumentBaseCurrencyValueInputEventArgs(global::Sungero.Commons.ICurrency oldValue, global::Sungero.Commons.ICurrency newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




  public class ContractualDocumentBaseVatRateValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.IVatRate>
  {
    public ContractualDocumentBaseVatRateValueInputEventArgs(global::Sungero.Commons.IVatRate oldValue, global::Sungero.Commons.IVatRate newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




}

// ==================================================================
// ContractualDocumentBaseHandlers.g.cs
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

  public partial class ContractualDocumentBaseFilteringClientHandler
    : global::Sungero.Docflow.OfficialDocumentFilteringClientHandler
  {
    private global::Sungero.Docflow.IContractualDocumentBaseFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IContractualDocumentBaseFilterState)this.Filter;
      }
    }

    public ContractualDocumentBaseFilteringClientHandler(global::Sungero.Docflow.IContractualDocumentBaseFilterState filter)
    : base(filter)
    {
    }

    protected ContractualDocumentBaseFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ContractualDocumentBaseClientHandlers : global::Sungero.Docflow.OfficialDocumentClientHandlers
  {
    private global::Sungero.Docflow.IContractualDocumentBase _obj
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBase)this.Entity; }
    }

    public virtual void CounterpartySigningReasonValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void VatRateValueInput(global::Sungero.Docflow.Client.ContractualDocumentBaseVatRateValueInputEventArgs e) { }


    public virtual void VatAmountValueInput(global::Sungero.Presentation.DoubleValueInputEventArgs e) { }


    public virtual void NetAmountValueInput(global::Sungero.Presentation.DoubleValueInputEventArgs e) { }


    public virtual void PurchaseOrderNumberValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public ContractualDocumentBaseClientHandlers(global::Sungero.Docflow.IContractualDocumentBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ContractualDocumentBaseClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ContractualDocumentBaseFunctions : global::Sungero.Docflow.Client.OfficialDocumentFunctions
  {
    private global::Sungero.Docflow.IContractualDocumentBase _obj
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBase)this.Entity; }
    }

    public ContractualDocumentBaseFunctions(global::Sungero.Docflow.IContractualDocumentBase entity) : base(entity) { }
  }
}

// ==================================================================
// ContractualDocumentBaseFunctions.g.cs
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
  internal static class ContractualDocumentBase
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  global::System.Boolean CheckVatAmount(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Nullable<global::System.Double> vatAmount)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckVatAmount", new System.Type[] { typeof(global::System.Nullable<global::System.Double>) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { vatAmount });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, isRepeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void ChangeCounterpartyPropertyAccess(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Boolean isEnabled, global::System.Boolean counterpartyCodeInNumber, global::System.Boolean enabledState)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeCounterpartyPropertyAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, counterpartyCodeInNumber, enabledState });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetCounterparties(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterparties", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  global::System.String GetCounterpartySigningReason(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterpartySigningReason", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void FillCounterpartySignatory(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::Sungero.Parties.IContact signatory)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillCounterpartySignatory", new System.Type[] { typeof(global::Sungero.Parties.IContact) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { signatory });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void FillCounterpartySigningReason(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.String signingReason)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillCounterpartySigningReason", new System.Type[] { typeof(global::System.String) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { signingReason });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void FillVatAmount(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Nullable<global::System.Double> totalAmount, global::Sungero.Commons.IVatRate vatRate)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillVatAmount", new System.Type[] { typeof(global::System.Nullable<global::System.Double>), typeof(global::Sungero.Commons.IVatRate) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { totalAmount, vatRate });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void FillNetAmount(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Nullable<global::System.Double> totalAmount, global::System.Nullable<global::System.Double> vatAmount)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillNetAmount", new System.Type[] { typeof(global::System.Nullable<global::System.Double>), typeof(global::System.Nullable<global::System.Double>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { totalAmount, vatAmount });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void ChangeCounterpartyPropertyAccess(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Boolean isEnabled)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeCounterpartyPropertyAccess", new System.Type[] { typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasEmptyRequiredProperties", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ContractualDocumentBaseFunctions" />
    internal static  void EnableRegistrationNumberAndDate(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractualDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("EnableRegistrationNumberAndDate", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ContractualDocumentBaseFunctions" />
      internal static  global::System.Boolean HasSpecifiedTypeRelations(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("454df3c6-b850-47cf-897f-a10d767baa77"),
          "HasSpecifiedTypeRelations(global::Sungero.Docflow.IContractualDocumentBase)"
          , contractualDocumentBase);
      }

    }
  }
}

// ==================================================================
// ContractualDocumentBaseClientPublicFunctions.g.cs
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
  public class ContractualDocumentBaseClientPublicFunctions : global::Sungero.Docflow.Client.IContractualDocumentBaseClientPublicFunctions
  {
  }
}

// ==================================================================
// ContractualDocumentBaseActions.g.cs
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
  public partial class ContractualDocumentBaseActions : global::Sungero.Docflow.Client.OfficialDocumentActions
  {
    private global::Sungero.Docflow.IContractualDocumentBase _obj { get { return (global::Sungero.Docflow.IContractualDocumentBase)this.Entity; } }
    public ContractualDocumentBaseActions(global::Sungero.Docflow.IContractualDocumentBase entity) : base(entity) { }
  }

  public partial class ContractualDocumentBaseCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IContractualDocumentBase> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IContractualDocumentBase>(this.Entities); }
    }
  }

  public partial class ContractualDocumentBaseCollectionBulkActions : global::Sungero.Docflow.Client.OfficialDocumentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ContractualDocumentBaseAnyChildEntityActions : global::Sungero.Docflow.Client.OfficialDocumentAnyChildEntityActions
  {
  }

  public partial class ContractualDocumentBaseAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentAnyChildEntityCollectionActions
  {
  }



}
