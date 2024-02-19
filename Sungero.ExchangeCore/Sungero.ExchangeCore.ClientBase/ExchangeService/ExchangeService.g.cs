
// ==================================================================
// ExchangeServiceEventArgs.g.cs
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
}

// ==================================================================
// ExchangeServiceHandlers.g.cs
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

  public partial class ExchangeServiceFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.ExchangeCore.IExchangeServiceFilterState Filter { get; private set; }

    private global::Sungero.ExchangeCore.IExchangeServiceFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ExchangeServiceFilteringClientHandler(global::Sungero.ExchangeCore.IExchangeServiceFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ExchangeServiceFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ExchangeServiceClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.ExchangeCore.IExchangeService _obj
    {
      get { return (global::Sungero.ExchangeCore.IExchangeService)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void UriValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ExchangeProviderValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void LogonUrlValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ExchangeProviderFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }



    public ExchangeServiceClientHandlers(global::Sungero.ExchangeCore.IExchangeService entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ExchangeServiceClientFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Client
{
  public partial class ExchangeServiceFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.ExchangeCore.IExchangeService _obj
    {
      get { return (global::Sungero.ExchangeCore.IExchangeService)this.Entity; }
    }

    public ExchangeServiceFunctions(global::Sungero.ExchangeCore.IExchangeService entity) : base(entity) { }
  }
}

// ==================================================================
// ExchangeServiceFunctions.g.cs
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
  internal static class ExchangeService
  {
    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.ExchangeServiceFunctions" />
    internal static  global::System.String ValidateExchangeAddress(global::Sungero.ExchangeCore.IExchangeService exchangeService)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)exchangeService).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateExchangeAddress", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ExchangeServiceClientPublicFunctions.g.cs
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
  public class ExchangeServiceClientPublicFunctions : global::Sungero.ExchangeCore.Client.IExchangeServiceClientPublicFunctions
  {
  }
}

// ==================================================================
// ExchangeServiceActions.g.cs
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
  public partial class ExchangeServiceActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.ExchangeCore.IExchangeService _obj { get { return (global::Sungero.ExchangeCore.IExchangeService)this.Entity; } }
    public ExchangeServiceActions(global::Sungero.ExchangeCore.IExchangeService entity) : base(entity) { }
  }

  public partial class ExchangeServiceCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.ExchangeCore.IExchangeService> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.ExchangeCore.IExchangeService>(this.Entities); }
    }
  }

  public partial class ExchangeServiceCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ExchangeServiceAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class ExchangeServiceAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
