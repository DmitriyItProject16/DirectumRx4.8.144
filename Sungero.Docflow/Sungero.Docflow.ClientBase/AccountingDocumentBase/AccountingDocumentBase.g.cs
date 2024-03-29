
// ==================================================================
// AccountingDocumentBaseEventArgs.g.cs
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
  public class AccountingDocumentBaseCurrencyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.ICurrency>
  {
    public AccountingDocumentBaseCurrencyValueInputEventArgs(global::Sungero.Commons.ICurrency oldValue, global::Sungero.Commons.ICurrency newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class AccountingDocumentBaseCounterpartyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public AccountingDocumentBaseCounterpartyValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class AccountingDocumentBaseResponsibleEmployeeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public AccountingDocumentBaseResponsibleEmployeeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class AccountingDocumentBaseContactValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.IContact>
  {
    public AccountingDocumentBaseContactValueInputEventArgs(global::Sungero.Parties.IContact oldValue, global::Sungero.Parties.IContact newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




  public class AccountingDocumentBaseCounterpartySignatoryValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.IContact>
  {
    public AccountingDocumentBaseCounterpartySignatoryValueInputEventArgs(global::Sungero.Parties.IContact oldValue, global::Sungero.Parties.IContact newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



  public class AccountingDocumentBaseBusinessUnitBoxValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IBusinessUnitBox>
  {
    public AccountingDocumentBaseBusinessUnitBoxValueInputEventArgs(global::Sungero.ExchangeCore.IBusinessUnitBox oldValue, global::Sungero.ExchangeCore.IBusinessUnitBox newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class AccountingDocumentBaseCorrectedValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IAccountingDocumentBase>
  {
    public AccountingDocumentBaseCorrectedValueInputEventArgs(global::Sungero.Docflow.IAccountingDocumentBase oldValue, global::Sungero.Docflow.IAccountingDocumentBase newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }






  public class AccountingDocumentBaseVatRateValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.IVatRate>
  {
    public AccountingDocumentBaseVatRateValueInputEventArgs(global::Sungero.Commons.IVatRate oldValue, global::Sungero.Commons.IVatRate newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




}

// ==================================================================
// AccountingDocumentBaseHandlers.g.cs
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

  public partial class AccountingDocumentBaseFilteringClientHandler
    : global::Sungero.Docflow.OfficialDocumentFilteringClientHandler
  {
    private global::Sungero.Docflow.IAccountingDocumentBaseFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IAccountingDocumentBaseFilterState)this.Filter;
      }
    }

    public AccountingDocumentBaseFilteringClientHandler(global::Sungero.Docflow.IAccountingDocumentBaseFilterState filter)
    : base(filter)
    {
    }

    protected AccountingDocumentBaseFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class AccountingDocumentBaseClientHandlers : global::Sungero.Docflow.OfficialDocumentClientHandlers
  {
    private global::Sungero.Docflow.IAccountingDocumentBase _obj
    {
      get { return (global::Sungero.Docflow.IAccountingDocumentBase)this.Entity; }
    }

    public virtual void NumberValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }






    public virtual void ResponsibleEmployeeValueInput(global::Sungero.Docflow.Client.AccountingDocumentBaseResponsibleEmployeeValueInputEventArgs e) { }


    public virtual void ContactValueInput(global::Sungero.Docflow.Client.AccountingDocumentBaseContactValueInputEventArgs e) { }


    public virtual void IsFormalizedValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void SellerTitleIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void BuyerTitleIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void CounterpartySignatoryValueInput(global::Sungero.Docflow.Client.AccountingDocumentBaseCounterpartySignatoryValueInputEventArgs e) { }


    public virtual void SellerSignatureIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void BuyerSignatureIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void BusinessUnitBoxValueInput(global::Sungero.Docflow.Client.AccountingDocumentBaseBusinessUnitBoxValueInputEventArgs e) { }



    public virtual void CorrectedValueInput(global::Sungero.Docflow.Client.AccountingDocumentBaseCorrectedValueInputEventArgs e) { }


    public virtual void FormalizedServiceTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void FormalizedFunctionValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void IsRevisionValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void IsFormalizedSignatoryEmptyValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void CounterpartySigningReasonValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }





    public virtual void PurchaseOrderNumberValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> FormalizedServiceTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> FormalizedFunctionFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }









    public AccountingDocumentBaseClientHandlers(global::Sungero.Docflow.IAccountingDocumentBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AccountingDocumentBaseClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class AccountingDocumentBaseFunctions : global::Sungero.Docflow.Client.OfficialDocumentFunctions
  {
    private global::Sungero.Docflow.IAccountingDocumentBase _obj
    {
      get { return (global::Sungero.Docflow.IAccountingDocumentBase)this.Entity; }
    }

    public AccountingDocumentBaseFunctions(global::Sungero.Docflow.IAccountingDocumentBase entity) : base(entity) { }
  }
}

// ==================================================================
// AccountingDocumentBaseFunctions.g.cs
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
  internal static class AccountingDocumentBase
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.AccountingDocumentBaseFunctions" />
    internal static  void SellerTitlePropertiesFillingDialog(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SellerTitlePropertiesFillingDialog", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.AccountingDocumentBaseFunctions" />
    internal static  void BuyerTitlePropertiesFillingDialog(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("BuyerTitlePropertiesFillingDialog", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.AccountingDocumentBaseFunctions" />
    internal static  void GenerateDefaultBuyerTitle(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GenerateDefaultBuyerTitle", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.AccountingDocumentBaseFunctions" />
    internal static  void GenerateDefaultSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GenerateDefaultSellerTitle", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.AccountingDocumentBaseFunctions" />
    internal static  global::System.Boolean CanChangeDocumentType(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanChangeDocumentType", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::Sungero.Docflow.IDocumentGroupBase GetDocumentGroup(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentGroup", new System.Type[] {  });
      return (global::Sungero.Docflow.IDocumentGroupBase)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetCounterparties(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterparties", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::System.String GetCounterpartySigningReason(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterpartySigningReason", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::System.Boolean DefaultRegistrationPaneVisibility(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("DefaultRegistrationPaneVisibility", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::System.Boolean NeedShowRegistrationPane(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.Boolean conditions)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedShowRegistrationPane", new System.Type[] { typeof(global::System.Boolean) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { conditions });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, isRepeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void FillCounterpartySignatory(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::Sungero.Parties.IContact signatory)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillCounterpartySignatory", new System.Type[] { typeof(global::Sungero.Parties.IContact) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { signatory });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void FillCounterpartySigningReason(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.String signingReason)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillCounterpartySigningReason", new System.Type[] { typeof(global::System.String) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { signingReason });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void FillName(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasEmptyRequiredProperties", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void ChangeCounterpartyPropertyAccess(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.Boolean isEnabled)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeCounterpartyPropertyAccess", new System.Type[] { typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeRegistrationPaneVisibility", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needShow, repeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void AddRelatedDocumentsToAttachmentGroup(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentGroup group)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddRelatedDocumentsToAttachmentGroup", new System.Type[] { typeof(Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentGroup) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { group });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void ChangeCounterpartyPropertyAccess(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.Boolean isEnabled, global::System.Boolean counterpartyCodeInNumber, global::System.Boolean enabledState)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeCounterpartyPropertyAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, counterpartyCodeInNumber, enabledState });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::System.Boolean CheckRegistrationNumberUnique(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckRegistrationNumberUnique", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void EnableRegistrationNumberAndDate(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("EnableRegistrationNumberAndDate", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void FillLeadingDocument(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::Sungero.Docflow.IOfficialDocument leadingDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillLeadingDocument", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { leadingDocument });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::System.Boolean NeedCounterpartySign(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::Sungero.ExchangeCore.IBusinessUnitBox senderBox, global::System.Boolean isPrimaryDocument, global::System.Boolean needSign)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedCounterpartySign", new System.Type[] { typeof(global::Sungero.ExchangeCore.IBusinessUnitBox), typeof(global::System.Boolean), typeof(global::System.Boolean) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { senderBox, isPrimaryDocument, needSign });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  global::System.Boolean CheckVatAmount(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.Nullable<global::System.Double> vatAmount)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckVatAmount", new System.Type[] { typeof(global::System.Nullable<global::System.Double>) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { vatAmount });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void FillVatAmount(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.Nullable<global::System.Double> totalAmount, global::Sungero.Commons.IVatRate vatRate)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillVatAmount", new System.Type[] { typeof(global::System.Nullable<global::System.Double>), typeof(global::Sungero.Commons.IVatRate) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { totalAmount, vatRate });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.AccountingDocumentBaseFunctions" />
    internal static  void FillNetAmount(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::System.Nullable<global::System.Double> totalAmount, global::System.Nullable<global::System.Double> vatAmount)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)accountingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillNetAmount", new System.Type[] { typeof(global::System.Nullable<global::System.Double>), typeof(global::System.Nullable<global::System.Double>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { totalAmount, vatAmount });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccountingDocumentBaseFunctions" />
      internal static  void GenerateSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::Sungero.Docflow.Structures.AccountingDocumentBase.ISellerTitle sellerTitle)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("96c4f4f3-dc74-497a-b347-e8faf4afe320"),
          "GenerateSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase,global::Sungero.Docflow.Structures.AccountingDocumentBase.ISellerTitle)"
          , accountingDocumentBase, sellerTitle);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccountingDocumentBaseFunctions" />
      internal static  void GenerateAnswer(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::Sungero.Docflow.Structures.AccountingDocumentBase.IBuyerTitle buyerTitle, global::System.Boolean isAgent)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("96c4f4f3-dc74-497a-b347-e8faf4afe320"),
          "GenerateAnswer(global::Sungero.Docflow.IAccountingDocumentBase,global::Sungero.Docflow.Structures.AccountingDocumentBase.IBuyerTitle,global::System.Boolean)"
          , accountingDocumentBase, buyerTitle, isAgent);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccountingDocumentBaseFunctions" />
      internal static  void GenerateDefaultAnswer(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::Sungero.Company.IEmployee signatory, global::System.Boolean isAgent)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("96c4f4f3-dc74-497a-b347-e8faf4afe320"),
          "GenerateDefaultAnswer(global::Sungero.Docflow.IAccountingDocumentBase,global::Sungero.Company.IEmployee,global::System.Boolean)"
          , accountingDocumentBase, signatory, isAgent);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccountingDocumentBaseFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.AccountingDocumentBase.GenerateTitleError> TitleDialogValidationErrors(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::Sungero.Company.IEmployee signatory, global::Sungero.Company.IEmployee consignee, global::Sungero.Docflow.IPowerOfAttorneyBase consigneePowerOfAttorney, global::System.String consigneeOtherReason, global::Sungero.Docflow.ISignatureSetting signatorySetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.AccountingDocumentBase.GenerateTitleError>>(
          global::System.Guid.Parse("96c4f4f3-dc74-497a-b347-e8faf4afe320"),
          "TitleDialogValidationErrors(global::Sungero.Docflow.IAccountingDocumentBase,global::Sungero.Company.IEmployee,global::Sungero.Company.IEmployee,global::Sungero.Docflow.IPowerOfAttorneyBase,global::System.String,global::Sungero.Docflow.ISignatureSetting)"
          , accountingDocumentBase, signatory, consignee, consigneePowerOfAttorney, consigneeOtherReason, signatorySetting);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccountingDocumentBaseFunctions" />
      internal static  void GenerateDefaultSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase, global::Sungero.Company.IEmployee signatory)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("96c4f4f3-dc74-497a-b347-e8faf4afe320"),
          "GenerateDefaultSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase,global::Sungero.Company.IEmployee)"
          , accountingDocumentBase, signatory);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccountingDocumentBaseFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetEmployeesByIds(global::System.Collections.Generic.List<global::System.Int64> ids)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("96c4f4f3-dc74-497a-b347-e8faf4afe320"),
          "GetEmployeesByIds(global::System.Collections.Generic.List<global::System.Int64>)"
      , ids);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccountingDocumentBaseFunctions" />
      internal static  global::System.String GetTaxDocumentClassifier(global::Sungero.Docflow.IAccountingDocumentBase document)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("96c4f4f3-dc74-497a-b347-e8faf4afe320"),
          "GetTaxDocumentClassifier(global::Sungero.Docflow.IAccountingDocumentBase)"
      , document);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.AccountingDocumentBaseFunctions" />
      internal static  global::System.Boolean HasSpecifiedTypeRelations(global::Sungero.Docflow.IAccountingDocumentBase accountingDocumentBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("96c4f4f3-dc74-497a-b347-e8faf4afe320"),
          "HasSpecifiedTypeRelations(global::Sungero.Docflow.IAccountingDocumentBase)"
          , accountingDocumentBase);
      }

    }
  }
}

// ==================================================================
// AccountingDocumentBaseClientPublicFunctions.g.cs
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
  public class AccountingDocumentBaseClientPublicFunctions : global::Sungero.Docflow.Client.IAccountingDocumentBaseClientPublicFunctions
  {
  }
}

// ==================================================================
// AccountingDocumentBaseActions.g.cs
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
  public partial class AccountingDocumentBaseActions : global::Sungero.Docflow.Client.OfficialDocumentActions
  {
    private global::Sungero.Docflow.IAccountingDocumentBase _obj { get { return (global::Sungero.Docflow.IAccountingDocumentBase)this.Entity; } }
    public AccountingDocumentBaseActions(global::Sungero.Docflow.IAccountingDocumentBase entity) : base(entity) { }
  }

  public partial class AccountingDocumentBaseCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IAccountingDocumentBase> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IAccountingDocumentBase>(this.Entities); }
    }
  }

  public partial class AccountingDocumentBaseCollectionBulkActions : global::Sungero.Docflow.Client.OfficialDocumentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AccountingDocumentBaseAnyChildEntityActions : global::Sungero.Docflow.Client.OfficialDocumentAnyChildEntityActions
  {
  }

  public partial class AccountingDocumentBaseAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentAnyChildEntityCollectionActions
  {
  }



  public partial class AccountingDocumentBaseVersionsActions : global::Sungero.Docflow.Client.OfficialDocumentVersionsActions
  {
    private global::Sungero.Docflow.IAccountingDocumentBaseVersions _obj { get { return (global::Sungero.Docflow.IAccountingDocumentBaseVersions)this.Entity; } }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IAccountingDocumentBaseVersions> _all
    {
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IAccountingDocumentBaseVersions>)this.AllEntities; }
    }
  }

  public partial class AccountingDocumentBaseVersionsCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentVersionsCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IAccountingDocumentBaseVersions> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IAccountingDocumentBaseVersions>(this.Entities); }
    }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IAccountingDocumentBaseVersions> _all
    {
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IAccountingDocumentBaseVersions>)this.AllEntities; }
    }
  }



}
