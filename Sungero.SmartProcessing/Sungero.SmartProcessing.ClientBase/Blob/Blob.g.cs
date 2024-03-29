
// ==================================================================
// BlobEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{ 
}

// ==================================================================
// BlobHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{

  public partial class BlobFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.SmartProcessing.IBlobFilterState Filter { get; private set; }

    private global::Sungero.SmartProcessing.IBlobFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public BlobFilteringClientHandler(global::Sungero.SmartProcessing.IBlobFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected BlobFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class BlobClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.SmartProcessing.IBlob _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlob)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FilePathValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void OriginalFileNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ArioResultJsonValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }



    public virtual void CreatedValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void ModifiedValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void FileSizeValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void PageCountValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void ArioTaskIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void ArioTaskStatusValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ArioTaskStatusFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public BlobClientHandlers(global::Sungero.SmartProcessing.IBlob entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// BlobClientFunctions.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Client
{
  public partial class BlobFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.SmartProcessing.IBlob _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlob)this.Entity; }
    }

    public BlobFunctions(global::Sungero.SmartProcessing.IBlob entity) : base(entity) { }
  }
}

// ==================================================================
// BlobFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Functions
{
  internal static class Blob
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.BlobFunctions" />
      internal static  global::Sungero.SmartProcessing.IBlob CreateBlob()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.SmartProcessing.IBlob>(
          global::System.Guid.Parse("668418c4-bd08-4aeb-94d7-d0c30869c1a0"),
          "CreateBlob()"
      );
      }

    }
  }
}

// ==================================================================
// BlobClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class BlobClientPublicFunctions : global::Sungero.SmartProcessing.Client.IBlobClientPublicFunctions
  {
  }
}

// ==================================================================
// BlobActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public partial class BlobActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.SmartProcessing.IBlob _obj { get { return (global::Sungero.SmartProcessing.IBlob)this.Entity; } }
    public BlobActions(global::Sungero.SmartProcessing.IBlob entity) : base(entity) { }
  }

  public partial class BlobCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.SmartProcessing.IBlob> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.SmartProcessing.IBlob>(this.Entities); }
    }
  }

  public partial class BlobCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class BlobAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class BlobAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
