
// ==================================================================
// ExternalEntityLinkState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class ExternalEntityLinkState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Commons.IExternalEntityLinkState
  {
    public ExternalEntityLinkState(global::Sungero.Commons.IExternalEntityLink entity) : base(entity) { }

    public new global::Sungero.Commons.IExternalEntityLinkPropertyStates Properties
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.ExternalEntityLinkPropertyStates(entity);
    }


    public new global::Sungero.Commons.IExternalEntityLinkControlStates Controls
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.ExternalEntityLinkControlStates(entity);
    }

    public new global::Sungero.Commons.IExternalEntityLinkPageStates Pages
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.ExternalEntityLinkPageStates(entity);
    }

  }


  public class ExternalEntityLinkControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Commons.IExternalEntityLinkControlStates
  {

    protected internal ExternalEntityLinkControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ExternalEntityLinkPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Commons.IExternalEntityLinkPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal ExternalEntityLinkPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ExternalEntityLinkPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Commons.IExternalEntityLinkPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> EntityType 
            {
              get { return this.GetPropertyState<global::System.String>("EntityType"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int64?> EntityId 
            {
              get { return this.GetPropertyState<global::System.Int64?>("EntityId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ExtEntityType 
            {
              get { return this.GetPropertyState<global::System.String>("ExtEntityType"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ExtEntityId 
            {
              get { return this.GetPropertyState<global::System.String>("ExtEntityId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ExtSystemId 
            {
              get { return this.GetPropertyState<global::System.String>("ExtSystemId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> SyncDate 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("SyncDate"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> IsDeleted 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("IsDeleted"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }


    protected internal ExternalEntityLinkPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ExternalEntityLinkInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class ExternalEntityLinkInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Commons.IExternalEntityLinkInfo
  {
    public ExternalEntityLinkInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Commons.IExternalEntityLinkPropertiesInfo Properties
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Commons.IExternalEntityLinkActionsInfo Actions
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Commons.Shared.ExternalEntityLinkPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Commons.Shared.ExternalEntityLinkActionsInfo(entityType);
    }
  }

  public class ExternalEntityLinkPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Commons.IExternalEntityLinkPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo EntityType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("EntityType");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ILongIntegerPropertyInfo EntityId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.LongIntegerPropertyMetadata>("EntityId");
             return new global::Sungero.Domain.Shared.LongIntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ExtEntityType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ExtEntityType");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ExtEntityId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ExtEntityId");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ExtSystemId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ExtSystemId");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo SyncDate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("SyncDate");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo IsDeleted 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("IsDeleted");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
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


    protected internal ExternalEntityLinkPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ExternalEntityLinkActionsInfo : 
    global::Sungero.Domain.Shared.EntityActionsInfo, global::Sungero.Commons.IExternalEntityLinkActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo OpenEntity 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("OpenEntity")); }
        }


    protected internal ExternalEntityLinkActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
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
  public partial class ExternalEntityLinkSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IExternalEntityLinkSharedHandlers
  {
    private global::Sungero.Commons.IExternalEntityLink _obj
    {
      get { return (global::Sungero.Commons.IExternalEntityLink)this.Entity; }
    }
    public virtual void EntityTypeChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void EntityIdChanged(global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs e) { }


    public virtual void ExtEntityTypeChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void ExtEntityIdChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void ExtSystemIdChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void SyncDateChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void IsDeletedChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }


    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public ExternalEntityLinkSharedHandlers(global::Sungero.Commons.IExternalEntityLink entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ExternalEntityLinkResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared.ExternalEntityLink
{
  /// <summary>
  /// Represents ExternalEntityLink resources.
  /// </summary>
  public class ExternalEntityLinkResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Commons.ExternalEntityLink.IExternalEntityLinkResources
  {
  }
}

// ==================================================================
// ExternalEntityLinkSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Commons.Shared
{
  public partial class ExternalEntityLinkFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
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
// ExternalEntityLinkFilterState.g.cs
// ==================================================================

namespace Sungero.Commons.Shared.ExternalEntityLink
{

  public class ExternalEntityLinkFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Commons.IExternalEntityLinkFilterInfo
  {
  }

  public class ExternalEntityLinkFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Commons.IExternalEntityLinkFilterState
  {



    public new Sungero.Commons.IExternalEntityLinkFilterInfo Info
    {
      get
      {
        return (Sungero.Commons.IExternalEntityLinkFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Commons.Shared.ExternalEntityLink.ExternalEntityLinkFilterInfo();
    }

  }
}

// ==================================================================
// ExternalEntityLinkSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class ExternalEntityLinkSharedPublicFunctions : global::Sungero.Commons.Shared.IExternalEntityLinkSharedPublicFunctions
  {
  }
}
