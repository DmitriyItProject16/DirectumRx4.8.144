
// ==================================================================
// ExternalEntityLinkEventArgs.g.cs
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
}

// ==================================================================
// ExternalEntityLinkHandlers.g.cs
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

  public partial class ExternalEntityLinkFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Commons.IExternalEntityLinkFilterState Filter { get; private set; }

    private global::Sungero.Commons.IExternalEntityLinkFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ExternalEntityLinkFilteringClientHandler(global::Sungero.Commons.IExternalEntityLinkFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ExternalEntityLinkFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ExternalEntityLinkClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Commons.IExternalEntityLink _obj
    {
      get { return (global::Sungero.Commons.IExternalEntityLink)this.Entity; }
    }

    public virtual void EntityTypeValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void EntityIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void ExtEntityTypeValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ExtEntityIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ExtSystemIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void SyncDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void IsDeletedValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public ExternalEntityLinkClientHandlers(global::Sungero.Commons.IExternalEntityLink entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ExternalEntityLinkClientFunctions.g.cs
// ==================================================================

namespace Sungero.Commons.Client
{
  public partial class ExternalEntityLinkFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Commons.IExternalEntityLink _obj
    {
      get { return (global::Sungero.Commons.IExternalEntityLink)this.Entity; }
    }

    public ExternalEntityLinkFunctions(global::Sungero.Commons.IExternalEntityLink entity) : base(entity) { }
  }
}

// ==================================================================
// ExternalEntityLinkFunctions.g.cs
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
  internal static class ExternalEntityLink
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ExternalEntityLinkFunctions" />
      internal static  global::Sungero.Domain.Shared.IEntity GetEntity(global::Sungero.Commons.IExternalEntityLink externalEntityLink)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Domain.Shared.IEntity>(
          global::System.Guid.Parse("4346363e-39b9-40eb-9c12-64f0cf48d87f"),
          "GetEntity(global::Sungero.Commons.IExternalEntityLink)"
          , externalEntityLink);
      }

    }
  }
}

// ==================================================================
// ExternalEntityLinkClientPublicFunctions.g.cs
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
  public class ExternalEntityLinkClientPublicFunctions : global::Sungero.Commons.Client.IExternalEntityLinkClientPublicFunctions
  {
  }
}

// ==================================================================
// ExternalEntityLinkActions.g.cs
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
  public partial class ExternalEntityLinkActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Commons.IExternalEntityLink _obj { get { return (global::Sungero.Commons.IExternalEntityLink)this.Entity; } }
    public ExternalEntityLinkActions(global::Sungero.Commons.IExternalEntityLink entity) : base(entity) { }
  }

  public partial class ExternalEntityLinkCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Commons.IExternalEntityLink> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Commons.IExternalEntityLink>(this.Entities); }
    }
  }

  public partial class ExternalEntityLinkCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class ExternalEntityLinkAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class ExternalEntityLinkAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}