
// ==================================================================
// DistributionListEventArgs.g.cs
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
// DistributionListHandlers.g.cs
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

  public partial class DistributionListFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IDistributionListFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDistributionListFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DistributionListFilteringClientHandler(global::Sungero.Docflow.IDistributionListFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DistributionListFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DistributionListClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Docflow.IDistributionList _obj
    {
      get { return (global::Sungero.Docflow.IDistributionList)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void NoteValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public DistributionListClientHandlers(global::Sungero.Docflow.IDistributionList entity) : base(entity)
    {
    }
  }

  public partial class DistributionListAddresseesClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IDistributionListAddressees _obj
    {
      get { return (global::Sungero.Docflow.IDistributionListAddressees)this.Entity; }
    }
    public virtual void AddresseesCorrespondentValueInput(global::Sungero.Docflow.Client.DistributionListAddresseesCorrespondentValueInputEventArgs e) { }


    public virtual void AddresseesAddresseeValueInput(global::Sungero.Docflow.Client.DistributionListAddresseesAddresseeValueInputEventArgs e) { }


    public virtual void AddresseesDeliveryMethodValueInput(global::Sungero.Docflow.Client.DistributionListAddresseesDeliveryMethodValueInputEventArgs e) { }



    public DistributionListAddresseesClientHandlers(global::Sungero.Docflow.IDistributionListAddressees entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DistributionListClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class DistributionListFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IDistributionList _obj
    {
      get { return (global::Sungero.Docflow.IDistributionList)this.Entity; }
    }

    public DistributionListFunctions(global::Sungero.Docflow.IDistributionList entity) : base(entity) { }
  }
}

// ==================================================================
// DistributionListFunctions.g.cs
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
  internal static class DistributionList
  {
  }
}

// ==================================================================
// DistributionListClientPublicFunctions.g.cs
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
  public class DistributionListClientPublicFunctions : global::Sungero.Docflow.Client.IDistributionListClientPublicFunctions
  {
  }
}

// ==================================================================
// DistributionListActions.g.cs
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
  public partial class DistributionListActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Docflow.IDistributionList _obj { get { return (global::Sungero.Docflow.IDistributionList)this.Entity; } }
    public DistributionListActions(global::Sungero.Docflow.IDistributionList entity) : base(entity) { }
  }

  public partial class DistributionListCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IDistributionList> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IDistributionList>(this.Entities); }
    }
  }

  public partial class DistributionListCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class DistributionListAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class DistributionListAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
