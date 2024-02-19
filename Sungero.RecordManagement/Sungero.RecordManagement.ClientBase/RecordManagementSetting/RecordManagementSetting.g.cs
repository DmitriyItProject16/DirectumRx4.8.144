
// ==================================================================
// RecordManagementSettingEventArgs.g.cs
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
// RecordManagementSettingHandlers.g.cs
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

  public partial class RecordManagementSettingFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IRecordManagementSettingFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IRecordManagementSettingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public RecordManagementSettingFilteringClientHandler(global::Sungero.RecordManagement.IRecordManagementSettingFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected RecordManagementSettingFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class RecordManagementSettingClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.RecordManagement.IRecordManagementSetting _obj
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSetting)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void AllowActionItemsWithIndefiniteDeadlineValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }




    public virtual void AllowAcquaintanceBySubstituteValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public RecordManagementSettingClientHandlers(global::Sungero.RecordManagement.IRecordManagementSetting entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// RecordManagementSettingClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class RecordManagementSettingFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.RecordManagement.IRecordManagementSetting _obj
    {
      get { return (global::Sungero.RecordManagement.IRecordManagementSetting)this.Entity; }
    }

    public RecordManagementSettingFunctions(global::Sungero.RecordManagement.IRecordManagementSetting entity) : base(entity) { }
  }
}

// ==================================================================
// RecordManagementSettingFunctions.g.cs
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
  internal static class RecordManagementSetting
  {
  }
}

// ==================================================================
// RecordManagementSettingClientPublicFunctions.g.cs
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
  public class RecordManagementSettingClientPublicFunctions : global::Sungero.RecordManagement.Client.IRecordManagementSettingClientPublicFunctions
  {
  }
}

// ==================================================================
// RecordManagementSettingActions.g.cs
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
  public partial class RecordManagementSettingActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.RecordManagement.IRecordManagementSetting _obj { get { return (global::Sungero.RecordManagement.IRecordManagementSetting)this.Entity; } }
    public RecordManagementSettingActions(global::Sungero.RecordManagement.IRecordManagementSetting entity) : base(entity) { }
  }

  public partial class RecordManagementSettingCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IRecordManagementSetting> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IRecordManagementSetting>(this.Entities); }
    }
  }

  public partial class RecordManagementSettingCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class RecordManagementSettingAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class RecordManagementSettingAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}