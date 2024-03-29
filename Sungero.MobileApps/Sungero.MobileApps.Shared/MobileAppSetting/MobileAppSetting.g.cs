
// ==================================================================
// MobileAppSettingState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Shared
{
  public class MobileAppSettingState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.MobileApps.IMobileAppSettingState
  {
    public MobileAppSettingState(global::Sungero.MobileApps.IMobileAppSetting entity) : base(entity) { }

    public new global::Sungero.MobileApps.IMobileAppSettingPropertyStates Properties
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.MobileApps.Shared.MobileAppSettingPropertyStates(entity);
    }


    public new global::Sungero.MobileApps.IMobileAppSettingControlStates Controls
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.MobileApps.Shared.MobileAppSettingControlStates(entity);
    }

    public new global::Sungero.MobileApps.IMobileAppSettingPageStates Pages
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.MobileApps.Shared.MobileAppSettingPageStates(entity);
    }

  }


  public class MobileAppSettingControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.MobileApps.IMobileAppSettingControlStates
  {

    protected internal MobileAppSettingControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class MobileAppSettingPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.MobileApps.IMobileAppSettingPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal MobileAppSettingPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class MobileAppSettingPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.MobileApps.IMobileAppSettingPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Employee 
            {
              get { return this.InternalEmployee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalEmployee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Employee"); }
            }
            public global::Sungero.MobileApps.IMobileAppSettingVisibleFoldersCollectionPropertyState<global::Sungero.MobileApps.IMobileAppSettingVisibleFolders> VisibleFolders 
            {
              get { return this.GetPropertyState("VisibleFolders", this.CreateVisibleFoldersState); }
            }

            protected virtual global::Sungero.MobileApps.IMobileAppSettingVisibleFoldersCollectionPropertyState<global::Sungero.MobileApps.IMobileAppSettingVisibleFolders> CreateVisibleFoldersState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.MobileApps.Shared.MobileAppSettingVisibleFoldersCollectionPropertyState<global::Sungero.MobileApps.IMobileAppSettingVisibleFolders>(entity, propertyName);
            }


    protected internal MobileAppSettingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// MobileAppSettingInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Shared
{
  public class MobileAppSettingInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.MobileApps.IMobileAppSettingInfo
  {
    public MobileAppSettingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.MobileApps.IMobileAppSettingPropertiesInfo Properties
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.MobileApps.IMobileAppSettingActionsInfo Actions
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.MobileApps.Shared.MobileAppSettingPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.MobileApps.Shared.MobileAppSettingActionsInfo(entityType);
    }
  }

  public class MobileAppSettingPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.MobileApps.IMobileAppSettingPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Employee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Employee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.MobileApps.IMobileAppSettingVisibleFoldersPropertiesInfo> VisibleFolders 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("VisibleFolders");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.MobileApps.IMobileAppSettingVisibleFoldersPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal MobileAppSettingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class MobileAppSettingActionsInfo : 
    global::Sungero.Domain.Shared.EntityActionsInfo, global::Sungero.MobileApps.IMobileAppSettingActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Reset 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Reset")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo AddFolder 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("AddFolder")); }
        }


    protected internal MobileAppSettingActionsInfo(global::System.Type entityType) : base(entityType) { }
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
  public partial class MobileAppSettingSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IMobileAppSettingSharedHandlers
  {
    private global::Sungero.MobileApps.IMobileAppSetting _obj
    {
      get { return (global::Sungero.MobileApps.IMobileAppSetting)this.Entity; }
    }
    public virtual void VisibleFoldersChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }




    public MobileAppSettingSharedHandlers(global::Sungero.MobileApps.IMobileAppSetting entity) : base(entity)
    {
    }
  }

  public partial class MobileAppSettingVisibleFoldersSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers, IMobileAppSettingVisibleFoldersSharedHandlers
  {
    private global::Sungero.MobileApps.IMobileAppSettingVisibleFolders _obj
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingVisibleFolders)this.Entity; }
    }
    public virtual void VisibleFoldersFolderIdChanged(global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs e) { }


    public virtual void VisibleFoldersFolderNameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }



    public MobileAppSettingVisibleFoldersSharedHandlers(global::Sungero.MobileApps.IMobileAppSettingVisibleFolders entity) : base(entity)
    {
    }
  }

  public partial class MobileAppSettingVisibleFoldersSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.MobileApps.IMobileAppSetting _obj
    { 
      get { return (global::Sungero.MobileApps.IMobileAppSetting)this.Entity; }
    }

    private global::Sungero.MobileApps.IMobileAppSettingVisibleFolders _added
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingVisibleFolders)this._Added; }
    }

    private global::Sungero.MobileApps.IMobileAppSettingVisibleFolders _deleted
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingVisibleFolders)this._Deleted; }
    }

    private global::Sungero.MobileApps.IMobileAppSettingVisibleFolders _source
    {
      get { return (global::Sungero.MobileApps.IMobileAppSettingVisibleFolders)this._Source; }
    }

    public virtual void VisibleFoldersAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void VisibleFoldersDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public MobileAppSettingVisibleFoldersSharedCollectionHandlers(global::Sungero.MobileApps.IMobileAppSetting entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

}

// ==================================================================
// MobileAppSettingResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Shared.MobileAppSetting
{
  /// <summary>
  /// Represents MobileAppSetting resources.
  /// </summary>
  public class MobileAppSettingResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.MobileApps.MobileAppSetting.IMobileAppSettingResources
  {
    public virtual global::CommonLibrary.LocalizedString NonUniqueUserSetting
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting) , "NonUniqueUserSetting");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NonUniqueUserSettingFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting), "NonUniqueUserSetting", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Bookmarks
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting) , "Bookmarks");
      }
    }

    public virtual global::CommonLibrary.LocalizedString BookmarksFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting), "Bookmarks", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString SelectFolder
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting) , "SelectFolder");
      }
    }

    public virtual global::CommonLibrary.LocalizedString SelectFolderFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting), "SelectFolder", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Folder
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting) , "Folder");
      }
    }

    public virtual global::CommonLibrary.LocalizedString FolderFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting), "Folder", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString FolderListIsAlreadyUpdated
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting) , "FolderListIsAlreadyUpdated");
      }
    }

    public virtual global::CommonLibrary.LocalizedString FolderListIsAlreadyUpdatedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting), "FolderListIsAlreadyUpdated", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString SelectAFolderToAdd
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting) , "SelectAFolderToAdd");
      }
    }

    public virtual global::CommonLibrary.LocalizedString SelectAFolderToAddFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting), "SelectAFolderToAdd", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString AddButton
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting) , "AddButton");
      }
    }

    public virtual global::CommonLibrary.LocalizedString AddButtonFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.MobileApps.IMobileAppSetting), "AddButton", false, args);
    }

  }
}

// ==================================================================
// MobileAppSettingSharedFunctions.g.cs
// ==================================================================

namespace Sungero.MobileApps.Shared
{
  public partial class MobileAppSettingFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
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
// MobileAppSettingFilterState.g.cs
// ==================================================================

namespace Sungero.MobileApps.Shared.MobileAppSetting
{

  public class MobileAppSettingFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.MobileApps.IMobileAppSettingFilterInfo
  {
  }

  public class MobileAppSettingFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.MobileApps.IMobileAppSettingFilterState
  {



    public new Sungero.MobileApps.IMobileAppSettingFilterInfo Info
    {
      get
      {
        return (Sungero.MobileApps.IMobileAppSettingFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.MobileApps.Shared.MobileAppSetting.MobileAppSettingFilterInfo();
    }

  }
}

// ==================================================================
// MobileAppSettingSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.MobileApps.Shared
{
  public class MobileAppSettingSharedPublicFunctions : global::Sungero.MobileApps.Shared.IMobileAppSettingSharedPublicFunctions
  {
  }
}
