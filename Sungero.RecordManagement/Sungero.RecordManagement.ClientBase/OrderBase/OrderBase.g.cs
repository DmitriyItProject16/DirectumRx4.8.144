
// ==================================================================
// OrderBaseEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{ 
}

// ==================================================================
// OrderBaseHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

  public partial class OrderBaseFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.RecordManagement.IOrderBaseFilterState _filter
    {
      get
      {
        return (Sungero.RecordManagement.IOrderBaseFilterState)this.Filter;
      }
    }

    public OrderBaseFilteringClientHandler(global::Sungero.RecordManagement.IOrderBaseFilterState filter)
    : base(filter)
    {
    }

    protected OrderBaseFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class OrderBaseClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.RecordManagement.IOrderBase _obj
    {
      get { return (global::Sungero.RecordManagement.IOrderBase)this.Entity; }
    }

    public OrderBaseClientHandlers(global::Sungero.RecordManagement.IOrderBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// OrderBaseClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class OrderBaseFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.RecordManagement.IOrderBase _obj
    {
      get { return (global::Sungero.RecordManagement.IOrderBase)this.Entity; }
    }

    public OrderBaseFunctions(global::Sungero.RecordManagement.IOrderBase entity) : base(entity) { }
  }
}

// ==================================================================
// OrderBaseFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Functions
{
  internal static class OrderBase
  {
  }
}

// ==================================================================
// OrderBaseClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class OrderBaseClientPublicFunctions : global::Sungero.RecordManagement.Client.IOrderBaseClientPublicFunctions
  {
  }
}

// ==================================================================
// OrderBaseActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public partial class OrderBaseActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.RecordManagement.IOrderBase _obj { get { return (global::Sungero.RecordManagement.IOrderBase)this.Entity; } }
    public OrderBaseActions(global::Sungero.RecordManagement.IOrderBase entity) : base(entity) { }
  }

  public partial class OrderBaseCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IOrderBase> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IOrderBase>(this.Entities); }
    }
  }

  public partial class OrderBaseCollectionBulkActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class OrderBaseAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class OrderBaseAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
