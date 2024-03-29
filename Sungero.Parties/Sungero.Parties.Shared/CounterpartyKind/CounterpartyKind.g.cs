
// ==================================================================
// CounterpartyKindState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared
{
  public class CounterpartyKindState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Parties.ICounterpartyKindState
  {
    public CounterpartyKindState(global::Sungero.Parties.ICounterpartyKind entity) : base(entity) { }

    public new global::Sungero.Parties.ICounterpartyKindPropertyStates Properties
    {
      get { return (global::Sungero.Parties.ICounterpartyKindPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.CounterpartyKindPropertyStates(entity);
    }


    public new global::Sungero.Parties.ICounterpartyKindControlStates Controls
    {
      get { return (global::Sungero.Parties.ICounterpartyKindControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.CounterpartyKindControlStates(entity);
    }

    public new global::Sungero.Parties.ICounterpartyKindPageStates Pages
    {
      get { return (global::Sungero.Parties.ICounterpartyKindPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.CounterpartyKindPageStates(entity);
    }

  }


  public class CounterpartyKindControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Parties.ICounterpartyKindControlStates
  {

    protected internal CounterpartyKindControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class CounterpartyKindPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Parties.ICounterpartyKindPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal CounterpartyKindPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CounterpartyKindPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Parties.ICounterpartyKindPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState Note 
            {
              get { return this.GetDataPropertyState("Note"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Sid 
            {
              get { return this.GetPropertyState<global::System.String>("Sid"); }
            }


    protected internal CounterpartyKindPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// CounterpartyKindInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared
{
  public class CounterpartyKindInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Parties.ICounterpartyKindInfo
  {
    public CounterpartyKindInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Parties.ICounterpartyKindPropertiesInfo Properties
    {
      get { return (global::Sungero.Parties.ICounterpartyKindPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Parties.Shared.CounterpartyKindPropertiesInfo(entityType);
    }

  }

  public class CounterpartyKindPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Parties.ICounterpartyKindPropertiesInfo
  {
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
        public global::Sungero.Domain.Shared.IStringPropertyInfo Sid 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Sid");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal CounterpartyKindPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// CounterpartyKindHandlers.g.cs
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
  public partial class CounterpartyKindSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, ICounterpartyKindSharedHandlers
  {
    private global::Sungero.Parties.ICounterpartyKind _obj
    {
      get { return (global::Sungero.Parties.ICounterpartyKind)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void NoteChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }


    public virtual void SidChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public CounterpartyKindSharedHandlers(global::Sungero.Parties.ICounterpartyKind entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CounterpartyKindResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared.CounterpartyKind
{
  /// <summary>
  /// Represents CounterpartyKind resources.
  /// </summary>
  public class CounterpartyKindResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Parties.CounterpartyKind.ICounterpartyKindResources
  {
  }
}

// ==================================================================
// CounterpartyKindSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Shared
{
  public partial class CounterpartyKindFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Parties.ICounterpartyKind _obj
    {
      get { return (global::Sungero.Parties.ICounterpartyKind)this.Entity; }
    }

    public CounterpartyKindFunctions(global::Sungero.Parties.ICounterpartyKind entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyKindFunctions.g.cs
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
  internal static class CounterpartyKind
  {
  }
}

// ==================================================================
// CounterpartyKindFilterState.g.cs
// ==================================================================

namespace Sungero.Parties.Shared.CounterpartyKind
{

  public class CounterpartyKindFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Parties.ICounterpartyKindFilterInfo
  {
  }

  public class CounterpartyKindFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Parties.ICounterpartyKindFilterState
  {



    public new Sungero.Parties.ICounterpartyKindFilterInfo Info
    {
      get
      {
        return (Sungero.Parties.ICounterpartyKindFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Parties.Shared.CounterpartyKind.CounterpartyKindFilterInfo();
    }

  }
}

// ==================================================================
// CounterpartyKindSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared
{
  public class CounterpartyKindSharedPublicFunctions : global::Sungero.Parties.Shared.ICounterpartyKindSharedPublicFunctions
  {
  }
}
