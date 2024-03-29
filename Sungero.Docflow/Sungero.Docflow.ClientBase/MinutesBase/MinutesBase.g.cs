
// ==================================================================
// MinutesBaseEventArgs.g.cs
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
// MinutesBaseHandlers.g.cs
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

  public partial class MinutesBaseFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.IMinutesBaseFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IMinutesBaseFilterState)this.Filter;
      }
    }

    public MinutesBaseFilteringClientHandler(global::Sungero.Docflow.IMinutesBaseFilterState filter)
    : base(filter)
    {
    }

    protected MinutesBaseFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class MinutesBaseClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.Docflow.IMinutesBase _obj
    {
      get { return (global::Sungero.Docflow.IMinutesBase)this.Entity; }
    }

    public MinutesBaseClientHandlers(global::Sungero.Docflow.IMinutesBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// MinutesBaseClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class MinutesBaseFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.IMinutesBase _obj
    {
      get { return (global::Sungero.Docflow.IMinutesBase)this.Entity; }
    }

    public MinutesBaseFunctions(global::Sungero.Docflow.IMinutesBase entity) : base(entity) { }
  }
}

// ==================================================================
// MinutesBaseFunctions.g.cs
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
  internal static class MinutesBase
  {
  }
}

// ==================================================================
// MinutesBaseClientPublicFunctions.g.cs
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
  public class MinutesBaseClientPublicFunctions : global::Sungero.Docflow.Client.IMinutesBaseClientPublicFunctions
  {
  }
}

// ==================================================================
// MinutesBaseActions.g.cs
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
  public partial class MinutesBaseActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.Docflow.IMinutesBase _obj { get { return (global::Sungero.Docflow.IMinutesBase)this.Entity; } }
    public MinutesBaseActions(global::Sungero.Docflow.IMinutesBase entity) : base(entity) { }
  }

  public partial class MinutesBaseCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IMinutesBase> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IMinutesBase>(this.Entities); }
    }
  }

  public partial class MinutesBaseCollectionBulkActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class MinutesBaseAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class MinutesBaseAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
