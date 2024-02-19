
// ==================================================================
// PowerOfAttorneyServiceConnectionState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Shared
{
  public class PowerOfAttorneyServiceConnectionState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionState
  {
    public PowerOfAttorneyServiceConnectionState(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection entity) : base(entity) { }

    public new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPropertyStates Properties
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnectionPropertyStates(entity);
    }


    public new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionControlStates Controls
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnectionControlStates(entity);
    }

    public new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPageStates Pages
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnectionPageStates(entity);
    }

  }


  public class PowerOfAttorneyServiceConnectionControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionControlStates
  {

    protected internal PowerOfAttorneyServiceConnectionControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class PowerOfAttorneyServiceConnectionPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal PowerOfAttorneyServiceConnectionPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class PowerOfAttorneyServiceConnectionPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IBusinessUnit> BusinessUnit 
            {
              get { return this.InternalBusinessUnit; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IBusinessUnit> InternalBusinessUnit
            {
              get { return this.GetPropertyState<global::Sungero.Company.IBusinessUnit>("BusinessUnit"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp> ServiceApp 
            {
              get { return this.InternalServiceApp; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp> InternalServiceApp
            {
              get { return this.GetPropertyState<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp>("ServiceApp"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> OrganizationId 
            {
              get { return this.GetPropertyState<global::System.String>("OrganizationId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> ConnectionStatus 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("ConnectionStatus"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState Note 
            {
              get { return this.GetDataPropertyState("Note"); }
            }


    protected internal PowerOfAttorneyServiceConnectionPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// PowerOfAttorneyServiceConnectionInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Shared
{
  public class PowerOfAttorneyServiceConnectionInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionInfo
  {
    public PowerOfAttorneyServiceConnectionInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPropertiesInfo Properties
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionActionsInfo Actions
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnectionPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnectionActionsInfo(entityType);
    }
  }

  public class PowerOfAttorneyServiceConnectionPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IBusinessUnitInfo, global::Sungero.Company.IBusinessUnit> BusinessUnit 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("BusinessUnit");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IBusinessUnitInfo, global::Sungero.Company.IBusinessUnit>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp> ServiceApp 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ServiceApp");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo OrganizationId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("OrganizationId");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo ConnectionStatus 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("ConnectionStatus");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo Note 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("Note");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }


    protected internal PowerOfAttorneyServiceConnectionPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class PowerOfAttorneyServiceConnectionActionsInfo : 
    global::Sungero.Domain.Shared.EntityActionsInfo, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo CheckConnection 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("CheckConnection")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ForceSave 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ForceSave")); }
        }


    protected internal PowerOfAttorneyServiceConnectionActionsInfo(global::System.Type entityType) : base(entityType) { }
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
  public partial class PowerOfAttorneyServiceConnectionSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IPowerOfAttorneyServiceConnectionSharedHandlers
  {
    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection _obj
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection)this.Entity; }
    }
    public virtual void OrganizationIdChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void ConnectionStatusChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }


    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void NoteChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }




    public PowerOfAttorneyServiceConnectionSharedHandlers(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyServiceConnectionResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnection
{
  /// <summary>
  /// Represents PowerOfAttorneyServiceConnection resources.
  /// </summary>
  public class PowerOfAttorneyServiceConnectionResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.PowerOfAttorneyCore.PowerOfAttorneyServiceConnection.IPowerOfAttorneyServiceConnectionResources
  {
    public virtual global::CommonLibrary.LocalizedString DuplicateServiceConnection
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection) , "DuplicateServiceConnection");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DuplicateServiceConnectionFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection), "DuplicateServiceConnection", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString PowerOfAttorneyConnectionError
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection) , "PowerOfAttorneyConnectionError");
      }
    }

    public virtual global::CommonLibrary.LocalizedString PowerOfAttorneyConnectionErrorFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection), "PowerOfAttorneyConnectionError", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString PowerOfAttorneyConnectionEstablished
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection) , "PowerOfAttorneyConnectionEstablished");
      }
    }

    public virtual global::CommonLibrary.LocalizedString PowerOfAttorneyConnectionEstablishedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection), "PowerOfAttorneyConnectionEstablished", false, args);
    }

  }
}

// ==================================================================
// PowerOfAttorneyServiceConnectionSharedFunctions.g.cs
// ==================================================================

namespace Sungero.PowerOfAttorneyCore.Shared
{
  public partial class PowerOfAttorneyServiceConnectionFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
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
// PowerOfAttorneyServiceConnectionFilterState.g.cs
// ==================================================================

namespace Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnection
{

  public class PowerOfAttorneyServiceConnectionFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionFilterInfo
  {
  }

  public class PowerOfAttorneyServiceConnectionFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionFilterState
  {



    public new Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionFilterInfo Info
    {
      get
      {
        return (Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnectionFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceConnection.PowerOfAttorneyServiceConnectionFilterInfo();
    }

  }
}

// ==================================================================
// PowerOfAttorneyServiceConnectionSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Shared
{
  public class PowerOfAttorneyServiceConnectionSharedPublicFunctions : global::Sungero.PowerOfAttorneyCore.Shared.IPowerOfAttorneyServiceConnectionSharedPublicFunctions
  {
  }
}
