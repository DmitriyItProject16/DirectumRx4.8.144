
// ==================================================================
// PowerOfAttorneyServiceConnectionEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Client
{ 
  public class PowerOfAttorneyServiceConnectionBusinessUnitValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IBusinessUnit>
  {
    public PowerOfAttorneyServiceConnectionBusinessUnitValueInputEventArgs(global::Sungero.Company.IBusinessUnit oldValue, global::Sungero.Company.IBusinessUnit newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class PowerOfAttorneyServiceConnectionServiceAppValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp>
  {
    public PowerOfAttorneyServiceConnectionServiceAppValueInputEventArgs(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp oldValue, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }





}

// ==================================================================
// PowerOfAttorneyServiceConnectionHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore
{

  public partial class PowerOfAttorneyServiceConnectionFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionFilterState Filter { get; private set; }

    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public PowerOfAttorneyServiceConnectionFilteringClientHandler(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected PowerOfAttorneyServiceConnectionFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class PowerOfAttorneyServiceConnectionClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection _obj
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection)this.Entity; }
    }

    public virtual void BusinessUnitValueInput(global::Sungero.PowerOfAttorneyCore.Client.PowerOfAttorneyServiceConnectionBusinessUnitValueInputEventArgs e) { }


    public virtual void ServiceAppValueInput(global::Sungero.PowerOfAttorneyCore.Client.PowerOfAttorneyServiceConnectionServiceAppValueInputEventArgs e) { }


    public virtual void OrganizationIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ConnectionStatusValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ConnectionStatusFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }




    public PowerOfAttorneyServiceConnectionClientHandlers(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyServiceConnectionClientFunctions.g.cs
// ==================================================================

namespace Sungero.PowerOfAttorneyCore.Client
{
  public partial class PowerOfAttorneyServiceConnectionFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection _obj
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection)this.Entity; }
    }

    public PowerOfAttorneyServiceConnectionFunctions(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyServiceConnectionFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Functions
{
  internal static class PowerOfAttorneyServiceConnection
  {
    /// <redirect project="Sungero.PowerOfAttorneyCore.Shared" type="Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnectionFunctions" />
    internal static  void FillName(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection powerOfAttorneyServiceConnection)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyServiceConnection).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// PowerOfAttorneyServiceConnectionClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Client
{
  public class PowerOfAttorneyServiceConnectionClientPublicFunctions : global::Sungero.PowerOfAttorneyCore.Client.IPowerOfAttorneyServiceConnectionClientPublicFunctions
  {
  }
}

// ==================================================================
// PowerOfAttorneyServiceConnectionActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Client
{
  public partial class PowerOfAttorneyServiceConnectionActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection _obj { get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection)this.Entity; } }
    public PowerOfAttorneyServiceConnectionActions(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection entity) : base(entity) { }
  }

  public partial class PowerOfAttorneyServiceConnectionCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection>(this.Entities); }
    }
  }

  public partial class PowerOfAttorneyServiceConnectionCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class PowerOfAttorneyServiceConnectionAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class PowerOfAttorneyServiceConnectionAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
