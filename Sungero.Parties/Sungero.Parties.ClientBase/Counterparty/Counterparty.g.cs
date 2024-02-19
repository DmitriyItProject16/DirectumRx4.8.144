
// ==================================================================
// CounterpartyEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{ 
  public class CounterpartyCityValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.ICity>
  {
    public CounterpartyCityValueInputEventArgs(global::Sungero.Commons.ICity oldValue, global::Sungero.Commons.ICity newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class CounterpartyRegionValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.IRegion>
  {
    public CounterpartyRegionValueInputEventArgs(global::Sungero.Commons.IRegion oldValue, global::Sungero.Commons.IRegion newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }












  public class CounterpartyBankValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.IBank>
  {
    public CounterpartyBankValueInputEventArgs(global::Sungero.Parties.IBank oldValue, global::Sungero.Parties.IBank newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




  public class CounterpartyResponsibleValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public CounterpartyResponsibleValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class CounterpartyKindValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterpartyKind>
  {
    public CounterpartyKindValueInputEventArgs(global::Sungero.Parties.ICounterpartyKind oldValue, global::Sungero.Parties.ICounterpartyKind newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// CounterpartyHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties
{

  public partial class CounterpartyFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Parties.ICounterpartyFilterState Filter { get; private set; }

    private global::Sungero.Parties.ICounterpartyFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public CounterpartyFilteringClientHandler(global::Sungero.Parties.ICounterpartyFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected CounterpartyFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class CounterpartyClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Parties.ICounterparty _obj
    {
      get { return (global::Sungero.Parties.ICounterparty)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void CityValueInput(global::Sungero.Parties.Client.CounterpartyCityValueInputEventArgs e) { }


    public virtual void RegionValueInput(global::Sungero.Parties.Client.CounterpartyRegionValueInputEventArgs e) { }


    public virtual void LegalAddressValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void PostalAddressValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void PhonesValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void HomepageValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }





    public virtual void NCEAValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void BankValueInput(global::Sungero.Parties.Client.CounterpartyBankValueInputEventArgs e) { }



    public virtual void CanExchangeValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }



    public virtual void ResponsibleValueInput(global::Sungero.Parties.Client.CounterpartyResponsibleValueInputEventArgs e) { }


    public virtual void ExternalIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void KindValueInput(global::Sungero.Parties.Client.CounterpartyKindValueInputEventArgs e) { }


    public CounterpartyClientHandlers(global::Sungero.Parties.ICounterparty entity) : base(entity)
    {
    }
  }

  public partial class CounterpartyExchangeBoxesClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Parties.ICounterpartyExchangeBoxes _obj
    {
      get { return (global::Sungero.Parties.ICounterpartyExchangeBoxes)this.Entity; }
    }
    public virtual void ExchangeBoxesBoxValueInput(global::Sungero.Parties.Client.CounterpartyExchangeBoxesBoxValueInputEventArgs e) { }


    public virtual void ExchangeBoxesStatusValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void ExchangeBoxesOrganizationIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ExchangeBoxesInvitationTextValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ExchangeBoxesIsDefaultValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void ExchangeBoxesCounterpartyBoxValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ExchangeBoxesIsRoamingValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void ExchangeBoxesFtsIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ExchangeBoxesCounterpartyBranchIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ExchangeBoxesCounterpartyParentBranchIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ExchangeBoxesStatusFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }










    public CounterpartyExchangeBoxesClientHandlers(global::Sungero.Parties.ICounterpartyExchangeBoxes entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CounterpartyClientFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Client
{
  public partial class CounterpartyFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Parties.ICounterparty _obj
    {
      get { return (global::Sungero.Parties.ICounterparty)this.Entity; }
    }

    public CounterpartyFunctions(global::Sungero.Parties.ICounterparty entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Functions
{
  internal static class Counterparty
  {
    /// <redirect project="Sungero.Parties.Client" type="Sungero.Parties.Client.CounterpartyFunctions" />
    internal static  void ShowInvitationDialog(global::Sungero.Parties.ICounterpartyExchangeBoxes obj, global::System.Boolean accept)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Client.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("ShowInvitationDialog",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Parties.ICounterpartyExchangeBoxes), typeof(global::System.Boolean) }, null);
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { obj, accept });
      }
      else
      {
    global::Sungero.Parties.Client.CounterpartyFunctions.ShowInvitationDialog(obj, accept);
      }
    }
    /// <redirect project="Sungero.Parties.Client" type="Sungero.Parties.Client.CounterpartyFunctions" />
    internal static  global::System.Boolean ValidateTinTrrcBeforeExchange(global::Sungero.Parties.ICounterparty counterparty, Sungero.Domain.Client.ExecuteActionArgs args)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterparty).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateTinTrrcBeforeExchange", new System.Type[] { typeof(Sungero.Domain.Client.ExecuteActionArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { args });
    }
    /// <redirect project="Sungero.Parties.Client" type="Sungero.Parties.Client.CounterpartyFunctions" />
    internal static  global::Sungero.Parties.Structures.Counterparty.InvitationInfo ValidateExchangeAction(global::Sungero.Parties.ICounterparty counterparty, Sungero.Domain.Client.ExecuteActionArgs args)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterparty).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateExchangeAction", new System.Type[] { typeof(Sungero.Domain.Client.ExecuteActionArgs) });
      return (global::Sungero.Parties.Structures.Counterparty.InvitationInfo)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { args });
    }

    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String CheckTin(global::System.String tin, global::System.Boolean forCompany)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CheckTin",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String), typeof(global::System.Boolean) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { tin, forCompany });
      }
      else
      {
        return global::Sungero.Parties.Shared.CounterpartyFunctions.CheckTin(tin, forCompany);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String CheckTin(global::Sungero.Parties.ICounterparty counterparty, global::System.String tin)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterparty).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckTin", new System.Type[] { typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { tin });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String GetCounterpartyWithSameTinWarning(global::System.String tin, global::System.String trrc, global::System.Nullable<global::System.Int64> companyId)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetCounterpartyWithSameTinWarning",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String), typeof(global::System.String), typeof(global::System.Nullable<global::System.Int64>) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { tin, trrc, companyId });
      }
      else
      {
        return global::Sungero.Parties.Shared.CounterpartyFunctions.GetCounterpartyWithSameTinWarning(tin, trrc, companyId);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String GetCounterpartyDuplicatesErrorText(global::Sungero.Parties.ICounterparty counterparty)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterparty).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterpartyDuplicatesErrorText", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String GenerateCounterpartyDuplicatesErrorText(global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> duplicates, global::System.String trrc)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GenerateCounterpartyDuplicatesErrorText",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>), typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { duplicates, trrc });
      }
      else
      {
        return global::Sungero.Parties.Shared.CounterpartyFunctions.GenerateCounterpartyDuplicatesErrorText(duplicates, trrc);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicates(global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean excludeClosed)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterparty).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDuplicates", new System.Type[] { typeof(global::System.Boolean) });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { excludeClosed });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicateCounterparties(global::System.String tin, global::System.String trrc, global::System.String name, global::System.Boolean excludeClosed)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDuplicateCounterparties",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.Boolean) }, null);
        return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { tin, trrc, name, excludeClosed });
      }
      else
      {
        return global::Sungero.Parties.Shared.CounterpartyFunctions.GetDuplicateCounterparties(tin, trrc, name, excludeClosed);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicateCounterpartiesFromList(global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> source, global::System.String tin, global::System.String trrc, global::System.String name, global::System.Boolean excludeClosed)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDuplicateCounterpartiesFromList",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>), typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.Boolean) }, null);
        return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { source, tin, trrc, name, excludeClosed });
      }
      else
      {
        return global::Sungero.Parties.Shared.CounterpartyFunctions.GetDuplicateCounterpartiesFromList(source, tin, trrc, name, excludeClosed);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicateCounterparties(global::System.String tin, global::System.String trrc, global::System.String name, global::System.Nullable<global::System.Int64> excludedCounterpartyId, global::System.Boolean excludeClosed)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDuplicateCounterparties",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String), typeof(global::System.String), typeof(global::System.String), typeof(global::System.Nullable<global::System.Int64>), typeof(global::System.Boolean) }, null);
        return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { tin, trrc, name, excludedCounterpartyId, excludeClosed });
      }
      else
      {
        return global::Sungero.Parties.Shared.CounterpartyFunctions.GetDuplicateCounterparties(tin, trrc, name, excludedCounterpartyId, excludeClosed);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String CheckPsrnLength(global::Sungero.Parties.ICounterparty counterparty, global::System.String psrn)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterparty).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckPsrnLength", new System.Type[] { typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { psrn });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String CheckNceoLength(global::Sungero.Parties.ICounterparty counterparty, global::System.String nceo)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)counterparty).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckNceoLength", new System.Type[] { typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { nceo });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String CheckAccountLength(global::System.String account)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CheckAccountLength",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { account });
      }
      else
      {
        return global::Sungero.Parties.Shared.CounterpartyFunctions.CheckAccountLength(account);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CounterpartyFunctions" />
    internal static  global::System.String GetTypeDisplayValue(global::Sungero.Domain.Shared.IEntity entity, CommonLibrary.DeclensionCase declension)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CounterpartyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetTypeDisplayValue",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Domain.Shared.IEntity), typeof(CommonLibrary.DeclensionCase) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { entity, declension });
      }
      else
      {
        return global::Sungero.Parties.Shared.CounterpartyFunctions.GetTypeDisplayValue(entity, declension);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.CounterpartyFunctions" />
      internal static  global::Sungero.Parties.Structures.Counterparty.InvitationInfo GetInvitationInfo(global::Sungero.Parties.ICounterparty counterparty)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Parties.Structures.Counterparty.InvitationInfo>(
          global::System.Guid.Parse("294767f1-009f-4fbd-80fc-f98c49ddc560"),
          "GetInvitationInfo(global::Sungero.Parties.ICounterparty)"
          , counterparty);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.CounterpartyFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetExchangeCounterparty(global::Sungero.Company.IBusinessUnit businessUnit)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>>(
          global::System.Guid.Parse("294767f1-009f-4fbd-80fc-f98c49ddc560"),
          "GetExchangeCounterparty(global::Sungero.Company.IBusinessUnit)"
      , businessUnit);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.CounterpartyFunctions" />
      internal static  global::Sungero.Parties.ICounterparty GetDistributionListCounterparty()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Parties.ICounterparty>(
          global::System.Guid.Parse("294767f1-009f-4fbd-80fc-f98c49ddc560"),
          "GetDistributionListCounterparty()"
      );
      }

    }
  }
}

// ==================================================================
// CounterpartyClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class CounterpartyClientPublicFunctions : global::Sungero.Parties.Client.ICounterpartyClientPublicFunctions
  {
  }
}

// ==================================================================
// CounterpartyActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public partial class CounterpartyActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Parties.ICounterparty _obj { get { return (global::Sungero.Parties.ICounterparty)this.Entity; } }
    public CounterpartyActions(global::Sungero.Parties.ICounterparty entity) : base(entity) { }
  }

  public partial class CounterpartyCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Parties.ICounterparty> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Parties.ICounterparty>(this.Entities); }
    }
  }

  public partial class CounterpartyCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class CounterpartyAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class CounterpartyAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



  public partial class CounterpartyExchangeBoxesActions : global::Sungero.Domain.Client.ChildEntityActions
  {
    private global::Sungero.Parties.ICounterpartyExchangeBoxes _obj { get { return (global::Sungero.Parties.ICounterpartyExchangeBoxes)this.Entity; } }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Parties.ICounterpartyExchangeBoxes> _all
    {
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Parties.ICounterpartyExchangeBoxes>)this.AllEntities; }
    }
  }

  public partial class CounterpartyExchangeBoxesCollectionActions : global::Sungero.Domain.Client.ChildEntityCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Parties.ICounterpartyExchangeBoxes> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Parties.ICounterpartyExchangeBoxes>(this.Entities); }
    }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Parties.ICounterpartyExchangeBoxes> _all
    {
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Parties.ICounterpartyExchangeBoxes>)this.AllEntities; }
    }
  }



}
