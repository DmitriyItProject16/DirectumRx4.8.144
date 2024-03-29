
// ==================================================================
// CounterpartyDepartmentBoxEventArgs.g.cs
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
  public class CounterpartyDepartmentBoxCounterpartyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public CounterpartyDepartmentBoxCounterpartyValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class CounterpartyDepartmentBoxBoxValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IBusinessUnitBox>
  {
    public CounterpartyDepartmentBoxBoxValueInputEventArgs(global::Sungero.ExchangeCore.IBusinessUnitBox oldValue, global::Sungero.ExchangeCore.IBusinessUnitBox newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }






}

// ==================================================================
// CounterpartyDepartmentBoxHandlers.g.cs
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

  public partial class CounterpartyDepartmentBoxFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState Filter { get; private set; }

    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public CounterpartyDepartmentBoxFilteringClientHandler(global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected CounterpartyDepartmentBoxFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class CounterpartyDepartmentBoxClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBox _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void DepartmentIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void CounterpartyValueInput(global::Sungero.ExchangeCore.Client.CounterpartyDepartmentBoxCounterpartyValueInputEventArgs e) { }


    public virtual void BoxValueInput(global::Sungero.ExchangeCore.Client.CounterpartyDepartmentBoxBoxValueInputEventArgs e) { }


    public virtual void FtsIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void OrganizationIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void AddressValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ParentBranchIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public CounterpartyDepartmentBoxClientHandlers(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CounterpartyDepartmentBoxClientFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Client
{
  public partial class CounterpartyDepartmentBoxFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBox _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)this.Entity; }
    }

    public CounterpartyDepartmentBoxFunctions(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyDepartmentBoxFunctions.g.cs
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
  internal static class CounterpartyDepartmentBox
  {
  }
}

// ==================================================================
// CounterpartyDepartmentBoxClientPublicFunctions.g.cs
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
  public class CounterpartyDepartmentBoxClientPublicFunctions : global::Sungero.ExchangeCore.Client.ICounterpartyDepartmentBoxClientPublicFunctions
  {
  }
}

// ==================================================================
// CounterpartyDepartmentBoxActions.g.cs
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
  public partial class CounterpartyDepartmentBoxActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.ExchangeCore.ICounterpartyDepartmentBox _obj { get { return (global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)this.Entity; } }
    public CounterpartyDepartmentBoxActions(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox entity) : base(entity) { }
  }

  public partial class CounterpartyDepartmentBoxCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.ExchangeCore.ICounterpartyDepartmentBox> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.ExchangeCore.ICounterpartyDepartmentBox>(this.Entities); }
    }
  }

  public partial class CounterpartyDepartmentBoxCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class CounterpartyDepartmentBoxAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class CounterpartyDepartmentBoxAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
