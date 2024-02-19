
// ==================================================================
// RegionEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{ 
  public class RegionCountryValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.ICountry>
  {
    public RegionCountryValueInputEventArgs(global::Sungero.Commons.ICountry oldValue, global::Sungero.Commons.ICountry newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// RegionHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons
{

  public partial class RegionFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Commons.IRegionFilterState Filter { get; private set; }

    private global::Sungero.Commons.IRegionFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public RegionFilteringClientHandler(global::Sungero.Commons.IRegionFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected RegionFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class RegionClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Commons.IRegion _obj
    {
      get { return (global::Sungero.Commons.IRegion)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void CountryValueInput(global::Sungero.Commons.Client.RegionCountryValueInputEventArgs e) { }


    public virtual void CodeValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public RegionClientHandlers(global::Sungero.Commons.IRegion entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// RegionClientFunctions.g.cs
// ==================================================================

namespace Sungero.Commons.Client
{
  public partial class RegionFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Commons.IRegion _obj
    {
      get { return (global::Sungero.Commons.IRegion)this.Entity; }
    }

    public RegionFunctions(global::Sungero.Commons.IRegion entity) : base(entity) { }
  }
}

// ==================================================================
// RegionFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Functions
{
  internal static class Region
  {
  }
}

// ==================================================================
// RegionClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public class RegionClientPublicFunctions : global::Sungero.Commons.Client.IRegionClientPublicFunctions
  {
  }
}

// ==================================================================
// RegionActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public partial class RegionActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Commons.IRegion _obj { get { return (global::Sungero.Commons.IRegion)this.Entity; } }
    public RegionActions(global::Sungero.Commons.IRegion entity) : base(entity) { }
  }

  public partial class RegionCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Commons.IRegion> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Commons.IRegion>(this.Entities); }
    }
  }

  public partial class RegionCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class RegionAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class RegionAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
