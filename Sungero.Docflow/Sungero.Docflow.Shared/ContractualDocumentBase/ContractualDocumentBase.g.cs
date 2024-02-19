
// ==================================================================
// ContractualDocumentBaseState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ContractualDocumentBaseState : 
    global::Sungero.Docflow.Shared.OfficialDocumentState, global::Sungero.Docflow.IContractualDocumentBaseState
  {
    public ContractualDocumentBaseState(global::Sungero.Docflow.IContractualDocumentBase entity) : base(entity) { }

    public new global::Sungero.Docflow.IContractualDocumentBasePropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBasePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBasePropertyStates(entity);
    }


    public new global::Sungero.Docflow.IContractualDocumentBaseControlStates Controls
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBaseControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBaseControlStates(entity);
    }

    public new global::Sungero.Docflow.IContractualDocumentBasePageStates Pages
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBasePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBasePageStates(entity);
    }

  }


  public class ContractualDocumentBaseControlStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentControlStates, global::Sungero.Docflow.IContractualDocumentBaseControlStates
  {

    protected internal ContractualDocumentBaseControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ContractualDocumentBasePageStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentPageStates, global::Sungero.Docflow.IContractualDocumentBasePageStates
  {

    protected internal ContractualDocumentBasePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ContractualDocumentBasePropertyStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentPropertyStates, global::Sungero.Docflow.IContractualDocumentBasePropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> Counterparty 
            {
              get { return this.InternalCounterparty; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> InternalCounterparty
            {
              get { return this.GetPropertyState<global::Sungero.Parties.ICounterparty>("Counterparty"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IContact> CounterpartySignatory 
            {
              get { return this.InternalCounterpartySignatory; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IContact> InternalCounterpartySignatory
            {
              get { return this.GetPropertyState<global::Sungero.Parties.IContact>("CounterpartySignatory"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Double?> TotalAmount 
            {
              get { return this.GetPropertyState<global::System.Double?>("TotalAmount"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Commons.ICurrency> Currency 
            {
              get { return this.InternalCurrency; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Commons.ICurrency> InternalCurrency
            {
              get { return this.GetPropertyState<global::Sungero.Commons.ICurrency>("Currency"); }
            }
            public new global::Sungero.Docflow.IContractualDocumentBaseVersionsCollectionPropertyState<global::Sungero.Docflow.IContractualDocumentBaseVersions> Versions
            {
              get { return (global::Sungero.Docflow.IContractualDocumentBaseVersionsCollectionPropertyState<global::Sungero.Docflow.IContractualDocumentBaseVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ContractualDocumentBaseVersionsCollectionPropertyState<global::Sungero.Docflow.IContractualDocumentBaseVersions>(entity, propertyName);
            }
            public new global::Sungero.Docflow.IContractualDocumentBaseTrackingCollectionPropertyState<global::Sungero.Docflow.IContractualDocumentBaseTracking> Tracking
            {
              get { return (global::Sungero.Docflow.IContractualDocumentBaseTrackingCollectionPropertyState<global::Sungero.Docflow.IContractualDocumentBaseTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ContractualDocumentBaseTrackingCollectionPropertyState<global::Sungero.Docflow.IContractualDocumentBaseTracking>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> CounterpartySigningReason 
            {
              get { return this.GetPropertyState<global::System.String>("CounterpartySigningReason"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Commons.IVatRate> VatRate 
            {
              get { return this.InternalVatRate; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Commons.IVatRate> InternalVatRate
            {
              get { return this.GetPropertyState<global::Sungero.Commons.IVatRate>("VatRate"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Double?> VatAmount 
            {
              get { return this.GetPropertyState<global::System.Double?>("VatAmount"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Double?> NetAmount 
            {
              get { return this.GetPropertyState<global::System.Double?>("NetAmount"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> PurchaseOrderNumber 
            {
              get { return this.GetPropertyState<global::System.String>("PurchaseOrderNumber"); }
            }


    protected internal ContractualDocumentBasePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ContractualDocumentBaseInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ContractualDocumentBaseInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentInfo, global::Sungero.Docflow.IContractualDocumentBaseInfo
  {
    public ContractualDocumentBaseInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IContractualDocumentBasePropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBasePropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.IContractualDocumentBaseActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBaseActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBasePropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBaseActionsInfo(entityType);
    }
  }

  public class ContractualDocumentBasePropertiesInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentPropertiesInfo, global::Sungero.Docflow.IContractualDocumentBasePropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.ICounterpartyInfo, global::Sungero.Parties.ICounterparty> Counterparty 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Counterparty");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.ICounterpartyInfo, global::Sungero.Parties.ICounterparty>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.IContactInfo, global::Sungero.Parties.IContact> CounterpartySignatory 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("CounterpartySignatory");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.IContactInfo, global::Sungero.Parties.IContact>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDoublePropertyInfo TotalAmount 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DoublePropertyMetadata>("TotalAmount");
             return new global::Sungero.Domain.Shared.DoublePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Commons.ICurrencyInfo, global::Sungero.Commons.ICurrency> Currency 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Currency");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Commons.ICurrencyInfo, global::Sungero.Commons.ICurrency>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IContractualDocumentBaseVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IContractualDocumentBaseVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IContractualDocumentBaseTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IContractualDocumentBaseTrackingPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo CounterpartySigningReason 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("CounterpartySigningReason");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Commons.IVatRateInfo, global::Sungero.Commons.IVatRate> VatRate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("VatRate");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Commons.IVatRateInfo, global::Sungero.Commons.IVatRate>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDoublePropertyInfo VatAmount 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DoublePropertyMetadata>("VatAmount");
             return new global::Sungero.Domain.Shared.DoublePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDoublePropertyInfo NetAmount 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DoublePropertyMetadata>("NetAmount");
             return new global::Sungero.Domain.Shared.DoublePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo PurchaseOrderNumber 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("PurchaseOrderNumber");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal ContractualDocumentBasePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ContractualDocumentBaseActionsInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentActionsInfo, global::Sungero.Docflow.IContractualDocumentBaseActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo PrintEnvelope 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("PrintEnvelope")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo PrintEnvelopeCard 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("PrintEnvelopeCard")); }
        }


    protected internal ContractualDocumentBaseActionsInfo(global::System.Type entityType) : base(entityType) { }
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
  public partial class ContractualDocumentBaseSharedHandlers : global::Sungero.Docflow.OfficialDocumentSharedHandlers, IContractualDocumentBaseSharedHandlers
  {
    private global::Sungero.Docflow.IContractualDocumentBase _obj
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBase)this.Entity; }
    }
    public virtual void CounterpartyChanged(global::Sungero.Docflow.Shared.ContractualDocumentBaseCounterpartyChangedEventArgs e) { }



    public virtual void TotalAmountChanged(global::Sungero.Domain.Shared.DoublePropertyChangedEventArgs e) { }


    public virtual void CurrencyChanged(global::Sungero.Docflow.Shared.ContractualDocumentBaseCurrencyChangedEventArgs e) { }





    public virtual void VatRateChanged(global::Sungero.Docflow.Shared.ContractualDocumentBaseVatRateChangedEventArgs e) { }


    public virtual void VatAmountChanged(global::Sungero.Domain.Shared.DoublePropertyChangedEventArgs e) { }


    public virtual void NetAmountChanged(global::Sungero.Domain.Shared.DoublePropertyChangedEventArgs e) { }


    public virtual void PurchaseOrderNumberChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public ContractualDocumentBaseSharedHandlers(global::Sungero.Docflow.IContractualDocumentBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ContractualDocumentBaseResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.ContractualDocumentBase
{
  /// <summary>
  /// Represents ContractualDocumentBase resources.
  /// </summary>
  public class ContractualDocumentBaseResources : global::Sungero.Docflow.Shared.OfficialDocument.OfficialDocumentResources, global::Sungero.Docflow.ContractualDocumentBase.IContractualDocumentBaseResources
  {
  }
}

// ==================================================================
// ContractualDocumentBaseSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class ContractualDocumentBaseFunctions : global::Sungero.Docflow.Shared.OfficialDocumentFunctions
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
// ContractualDocumentBaseFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.ContractualDocumentBase
{

  public class ContractualDocumentBaseFilterInfo : global::Sungero.Docflow.Shared.OfficialDocument.OfficialDocumentFilterInfo,
    global::Sungero.Docflow.IContractualDocumentBaseFilterInfo
  {
  }

  public class ContractualDocumentBaseFilterState : global::Sungero.Docflow.Shared.OfficialDocument.OfficialDocumentFilterState,
    global::Sungero.Docflow.IContractualDocumentBaseFilterState
  {



    public new Sungero.Docflow.IContractualDocumentBaseFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IContractualDocumentBaseFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.ContractualDocumentBase.ContractualDocumentBaseFilterInfo();
    }

  }
}

// ==================================================================
// ContractualDocumentBaseSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ContractualDocumentBaseSharedPublicFunctions : global::Sungero.Docflow.Shared.IContractualDocumentBaseSharedPublicFunctions
  {
    public global::System.Boolean CheckVatAmount(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Nullable<global::System.Double> vatAmount)
    {
      return global::Sungero.Docflow.Functions.ContractualDocumentBase.CheckVatAmount(contractualDocumentBase, vatAmount);
    }
    public void FillNetAmount(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Nullable<global::System.Double> totalAmount, global::System.Nullable<global::System.Double> vatAmount)
    {
global::Sungero.Docflow.Functions.ContractualDocumentBase.FillNetAmount(contractualDocumentBase, totalAmount, vatAmount);
    }
    public void FillVatAmount(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase, global::System.Nullable<global::System.Double> totalAmount, global::Sungero.Commons.IVatRate vatRate)
    {
global::Sungero.Docflow.Functions.ContractualDocumentBase.FillVatAmount(contractualDocumentBase, totalAmount, vatRate);
    }
    public global::System.String GetCounterpartySigningReason(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase)
    {
      return global::Sungero.Docflow.Functions.ContractualDocumentBase.GetCounterpartySigningReason(contractualDocumentBase);
    }
    public global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Docflow.IContractualDocumentBase contractualDocumentBase)
    {
      return global::Sungero.Docflow.Functions.ContractualDocumentBase.HasEmptyRequiredProperties(contractualDocumentBase);
    }
  }
}
