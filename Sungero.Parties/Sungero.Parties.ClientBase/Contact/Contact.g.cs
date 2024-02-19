
// ==================================================================
// ContactEventArgs.g.cs
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
  public class ContactPersonValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.IPerson>
  {
    public ContactPersonValueInputEventArgs(global::Sungero.Parties.IPerson oldValue, global::Sungero.Parties.IPerson newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ContactCompanyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICompanyBase>
  {
    public ContactCompanyValueInputEventArgs(global::Sungero.Parties.ICompanyBase oldValue, global::Sungero.Parties.ICompanyBase newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }









}

// ==================================================================
// ContactHandlers.g.cs
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

  public partial class ContactFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Parties.IContactFilterState Filter { get; private set; }

    private global::Sungero.Parties.IContactFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ContactFilteringClientHandler(global::Sungero.Parties.IContactFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ContactFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ContactClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Parties.IContact _obj
    {
      get { return (global::Sungero.Parties.IContact)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void PersonValueInput(global::Sungero.Parties.Client.ContactPersonValueInputEventArgs e) { }


    public virtual void CompanyValueInput(global::Sungero.Parties.Client.ContactCompanyValueInputEventArgs e) { }


    public virtual void DepartmentValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void JobTitleValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void PhoneValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FaxValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void NoteValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void HomepageValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public ContactClientHandlers(global::Sungero.Parties.IContact entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ContactClientFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Client
{
  public partial class ContactFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Parties.IContact _obj
    {
      get { return (global::Sungero.Parties.IContact)this.Entity; }
    }

    public ContactFunctions(global::Sungero.Parties.IContact entity) : base(entity) { }
  }
}

// ==================================================================
// ContactFunctions.g.cs
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
  internal static class Contact
  {
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.ContactFunctions" />
    internal static  void UpdateName(global::Sungero.Parties.IContact contact, global::Sungero.Parties.IPerson person)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contact).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("UpdateName", new System.Type[] { typeof(global::Sungero.Parties.IPerson) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { person });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.ContactFunctions" />
    internal static  global::System.Boolean HaveDuplicates(global::Sungero.Parties.IContact contact)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contact).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HaveDuplicates", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ContactFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Parties.IContact> GetDuplicates(global::Sungero.Parties.IContact contact)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Parties.IContact>>(
          global::System.Guid.Parse("c8daaef9-a679-4a29-ac01-b93c1637c72e"),
          "GetDuplicates(global::Sungero.Parties.IContact)"
          , contact);
      }

    }
  }
}

// ==================================================================
// ContactClientPublicFunctions.g.cs
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
  public class ContactClientPublicFunctions : global::Sungero.Parties.Client.IContactClientPublicFunctions
  {
  }
}

// ==================================================================
// ContactActions.g.cs
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
  public partial class ContactActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Parties.IContact _obj { get { return (global::Sungero.Parties.IContact)this.Entity; } }
    public ContactActions(global::Sungero.Parties.IContact entity) : base(entity) { }
  }

  public partial class ContactCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Parties.IContact> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Parties.IContact>(this.Entities); }
    }
  }

  public partial class ContactCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ContactAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class ContactAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}