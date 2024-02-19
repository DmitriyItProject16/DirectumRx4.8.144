
// ==================================================================
// PowerOfAttorneyEventArgs.g.cs
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
}

// ==================================================================
// PowerOfAttorneyHandlers.g.cs
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

  public partial class PowerOfAttorneyFilteringClientHandler
    : global::Sungero.Docflow.PowerOfAttorneyBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.IPowerOfAttorneyFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IPowerOfAttorneyFilterState)this.Filter;
      }
    }

    public PowerOfAttorneyFilteringClientHandler(global::Sungero.Docflow.IPowerOfAttorneyFilterState filter)
    : base(filter)
    {
    }

    protected PowerOfAttorneyFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class PowerOfAttorneyClientHandlers : global::Sungero.Docflow.PowerOfAttorneyBaseClientHandlers
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; }
    }

    public PowerOfAttorneyClientHandlers(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class PowerOfAttorneyFunctions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseFunctions
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; }
    }

    public PowerOfAttorneyFunctions(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyFunctions.g.cs
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
  internal static class PowerOfAttorney
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney> GetActivePowerOfAttorneys(global::Sungero.Company.IEmployee employee, global::System.Nullable<global::System.DateTime> date)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney>>(
          global::System.Guid.Parse("be859f9b-7a04-4f07-82bc-441352bce627"),
          "GetActivePowerOfAttorneys(global::Sungero.Company.IEmployee,global::System.Nullable<global::System.DateTime>)"
      , employee, date);
      }

    }
  }
}

// ==================================================================
// PowerOfAttorneyClientPublicFunctions.g.cs
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
  public class PowerOfAttorneyClientPublicFunctions : global::Sungero.Docflow.Client.IPowerOfAttorneyClientPublicFunctions
  {
  }
}

// ==================================================================
// PowerOfAttorneyActions.g.cs
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
  public partial class PowerOfAttorneyActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseActions
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj { get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; } }
    public PowerOfAttorneyActions(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity) { }
  }

  public partial class PowerOfAttorneyCollectionActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IPowerOfAttorney> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IPowerOfAttorney>(this.Entities); }
    }
  }

  public partial class PowerOfAttorneyCollectionBulkActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class PowerOfAttorneyAnyChildEntityActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseAnyChildEntityActions
  {
  }

  public partial class PowerOfAttorneyAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseAnyChildEntityCollectionActions
  {
  }



}
