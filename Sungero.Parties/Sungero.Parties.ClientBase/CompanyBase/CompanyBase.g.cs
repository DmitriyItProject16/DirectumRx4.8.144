
// ==================================================================
// CompanyBaseEventArgs.g.cs
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
  public class CompanyBaseHeadCompanyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICompany>
  {
    public CompanyBaseHeadCompanyValueInputEventArgs(global::Sungero.Parties.ICompany oldValue, global::Sungero.Parties.ICompany newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }






}

// ==================================================================
// CompanyBaseHandlers.g.cs
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

  public partial class CompanyBaseFilteringClientHandler
    : global::Sungero.Parties.CounterpartyFilteringClientHandler
  {
    private global::Sungero.Parties.ICompanyBaseFilterState _filter
    {
      get
      {
        return (Sungero.Parties.ICompanyBaseFilterState)this.Filter;
      }
    }

    public CompanyBaseFilteringClientHandler(global::Sungero.Parties.ICompanyBaseFilterState filter)
    : base(filter)
    {
    }

    protected CompanyBaseFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class CompanyBaseClientHandlers : global::Sungero.Parties.CounterpartyClientHandlers
  {
    private global::Sungero.Parties.ICompanyBase _obj
    {
      get { return (global::Sungero.Parties.ICompanyBase)this.Entity; }
    }

    public virtual void HeadCompanyValueInput(global::Sungero.Parties.Client.CompanyBaseHeadCompanyValueInputEventArgs e) { }



    public virtual void IsCardReadOnlyValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void LegalNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void ReliabilityValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ReliabilityFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public CompanyBaseClientHandlers(global::Sungero.Parties.ICompanyBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CompanyBaseClientFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Client
{
  public partial class CompanyBaseFunctions : global::Sungero.Parties.Client.CounterpartyFunctions
  {
    private global::Sungero.Parties.ICompanyBase _obj
    {
      get { return (global::Sungero.Parties.ICompanyBase)this.Entity; }
    }

    public CompanyBaseFunctions(global::Sungero.Parties.ICompanyBase entity) : base(entity) { }
  }
}

// ==================================================================
// CompanyBaseFunctions.g.cs
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
  internal static class CompanyBase
  {
    /// <redirect project="Sungero.Parties.Client" type="Sungero.Parties.Client.CompanyBaseFunctions" />
    internal static  global::System.Boolean ValidateTinTrrcBeforeExchange(global::Sungero.Parties.ICompanyBase companyBase, Sungero.Domain.Client.ExecuteActionArgs args)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)companyBase).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateTinTrrcBeforeExchange", new System.Type[] { typeof(Sungero.Domain.Client.ExecuteActionArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { args });
    }

    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CompanyBaseFunctions" />
    internal static  global::System.String GetCounterpartyDuplicatesErrorText(global::Sungero.Parties.ICompanyBase companyBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)companyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterpartyDuplicatesErrorText", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CompanyBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicates(global::Sungero.Parties.ICompanyBase companyBase, global::System.Boolean excludeClosed)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)companyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDuplicates", new System.Type[] { typeof(global::System.Boolean) });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { excludeClosed });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CompanyBaseFunctions" />
    internal static  global::System.Boolean IsSelfEmployed(global::Sungero.Parties.ICompanyBase companyBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)companyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsSelfEmployed", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CompanyBaseFunctions" />
    internal static  global::System.String CheckPsrnLength(global::Sungero.Parties.ICompanyBase companyBase, global::System.String psrn)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)companyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckPsrnLength", new System.Type[] { typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { psrn });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CompanyBaseFunctions" />
    internal static  global::System.String CheckNceoLength(global::Sungero.Parties.ICompanyBase companyBase, global::System.String nceo)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)companyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckNceoLength", new System.Type[] { typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { nceo });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.CompanyBaseFunctions" />
    internal static  global::System.String CheckTRRC(global::System.String trrc)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.CompanyBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CheckTRRC",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { trrc });
      }
      else
      {
        return global::Sungero.Parties.Shared.CompanyBaseFunctions.CheckTRRC(trrc);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.CompanyBaseFunctions" />
      internal static  global::Sungero.Parties.Structures.CompanyBase.FoundCompanies FillFromService(global::Sungero.Parties.ICompanyBase companyBase, global::System.String specifiedPSRN)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Parties.Structures.CompanyBase.FoundCompanies>(
          global::System.Guid.Parse("78278dd7-f0d2-4e35-b543-13d0bd462cd6"),
          "FillFromService(global::Sungero.Parties.ICompanyBase,global::System.String)"
          , companyBase, specifiedPSRN);
      }

    }
  }
}

// ==================================================================
// CompanyBaseClientPublicFunctions.g.cs
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
  public class CompanyBaseClientPublicFunctions : global::Sungero.Parties.Client.ICompanyBaseClientPublicFunctions
  {
  }
}

// ==================================================================
// CompanyBaseActions.g.cs
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
  public partial class CompanyBaseActions : global::Sungero.Parties.Client.CounterpartyActions
  {
    private global::Sungero.Parties.ICompanyBase _obj { get { return (global::Sungero.Parties.ICompanyBase)this.Entity; } }
    public CompanyBaseActions(global::Sungero.Parties.ICompanyBase entity) : base(entity) { }
  }

  public partial class CompanyBaseCollectionActions : global::Sungero.Parties.Client.CounterpartyCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Parties.ICompanyBase> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Parties.ICompanyBase>(this.Entities); }
    }
  }

  public partial class CompanyBaseCollectionBulkActions : global::Sungero.Parties.Client.CounterpartyCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class CompanyBaseAnyChildEntityActions : global::Sungero.Parties.Client.CounterpartyAnyChildEntityActions
  {
  }

  public partial class CompanyBaseAnyChildEntityCollectionActions : global::Sungero.Parties.Client.CounterpartyAnyChildEntityCollectionActions
  {
  }



}
