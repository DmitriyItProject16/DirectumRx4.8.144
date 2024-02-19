
// ==================================================================
// MobileAppSettingEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Client
{ 
  public class MobileAppSettingEmployeeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public MobileAppSettingEmployeeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// MobileAppSettingHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps
{

  public partial class MobileAppSettingFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.MobileApps.IMobileAppSettingFilterState Filter { get; private set; }

    private global::Sungero.MobileApps.IMobileAppSettingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public MobileAppSettingFilteringClientHandler(global::Sungero.MobileApps.IMobileAppSettingFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected MobileAppSettingFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class MobileAppSettingClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.MobileApps.IMobileAppSetting _obj
    {
      get { return (global::Sungero.MobileApps.IMobileAppSetting)this.Entity; }
    }

    public virtual void EmployeeValueInput(global::Sungero.MobileApps.Client.MobileAppSettingEmployeeValueInputEventArgs e) { }



    public MobileAppSettingClientHandlers(global::Sungero.MobileApps.IMobileAppSetting entity) : base(entity)
    {
    }
  }

  public partial class MobileAppSettingVisibleFoldersClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.MobileApps.IMobileAppSettingVisibleFolders _obj
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingVisibleFolders)this.Entity; }
    }
    public virtual void VisibleFoldersFolderIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void VisibleFoldersFolderNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public MobileAppSettingVisibleFoldersClientHandlers(global::Sungero.MobileApps.IMobileAppSettingVisibleFolders entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// MobileAppSettingClientFunctions.g.cs
// ==================================================================

namespace Sungero.MobileApps.Client
{
  public partial class MobileAppSettingFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.MobileApps.IMobileAppSetting _obj
    {
      get { return (global::Sungero.MobileApps.IMobileAppSetting)this.Entity; }
    }

    public MobileAppSettingFunctions(global::Sungero.MobileApps.IMobileAppSetting entity) : base(entity) { }
  }
}

// ==================================================================
// MobileAppSettingFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Functions
{
  internal static class MobileAppSetting
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.MobileApps.Server" type="Sungero.MobileApps.Server.MobileAppSettingFunctions" />
      internal static  void SendMobileAppSettingChanged(global::Sungero.MobileApps.IMobileAppSetting mobileAppSetting)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("210b9d5c-0218-43c5-b950-c69a65caec9b"),
          "SendMobileAppSettingChanged(global::Sungero.MobileApps.IMobileAppSetting)"
          , mobileAppSetting);
      }
      /// <redirect project="Sungero.MobileApps.Server" type="Sungero.MobileApps.Server.MobileAppSettingFunctions" />
      internal static  global::System.Boolean IsUnique(global::Sungero.MobileApps.IMobileAppSetting mobileAppSetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("210b9d5c-0218-43c5-b950-c69a65caec9b"),
          "IsUnique(global::Sungero.MobileApps.IMobileAppSetting)"
          , mobileAppSetting);
      }
      /// <redirect project="Sungero.MobileApps.Server" type="Sungero.MobileApps.Server.MobileAppSettingFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.MobileApps.Structures.MobileAppSetting.FolderNameWithId> GetFolderNameWithIds(global::Sungero.MobileApps.IMobileAppSetting mobileAppSetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.MobileApps.Structures.MobileAppSetting.FolderNameWithId>>(
          global::System.Guid.Parse("210b9d5c-0218-43c5-b950-c69a65caec9b"),
          "GetFolderNameWithIds(global::Sungero.MobileApps.IMobileAppSetting)"
          , mobileAppSetting);
      }

    }
  }
}

// ==================================================================
// MobileAppSettingClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Client
{
  public class MobileAppSettingClientPublicFunctions : global::Sungero.MobileApps.Client.IMobileAppSettingClientPublicFunctions
  {
  }
}

// ==================================================================
// MobileAppSettingActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Client
{
  public partial class MobileAppSettingActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.MobileApps.IMobileAppSetting _obj { get { return (global::Sungero.MobileApps.IMobileAppSetting)this.Entity; } }
    public MobileAppSettingActions(global::Sungero.MobileApps.IMobileAppSetting entity) : base(entity) { }
  }

  public partial class MobileAppSettingCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.MobileApps.IMobileAppSetting> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.MobileApps.IMobileAppSetting>(this.Entities); }
    }
  }

  public partial class MobileAppSettingCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class MobileAppSettingAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class MobileAppSettingAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
