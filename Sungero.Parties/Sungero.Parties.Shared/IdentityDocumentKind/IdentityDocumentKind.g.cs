
// ==================================================================
// IdentityDocumentKindState.g.cs
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
  public class IdentityDocumentKindState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Parties.IIdentityDocumentKindState
  {
    public IdentityDocumentKindState(global::Sungero.Parties.IIdentityDocumentKind entity) : base(entity) { }

    public new global::Sungero.Parties.IIdentityDocumentKindPropertyStates Properties
    {
      get { return (global::Sungero.Parties.IIdentityDocumentKindPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.IdentityDocumentKindPropertyStates(entity);
    }


    public new global::Sungero.Parties.IIdentityDocumentKindControlStates Controls
    {
      get { return (global::Sungero.Parties.IIdentityDocumentKindControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.IdentityDocumentKindControlStates(entity);
    }

    public new global::Sungero.Parties.IIdentityDocumentKindPageStates Pages
    {
      get { return (global::Sungero.Parties.IIdentityDocumentKindPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.IdentityDocumentKindPageStates(entity);
    }

  }


  public class IdentityDocumentKindControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Parties.IIdentityDocumentKindControlStates
  {

    protected internal IdentityDocumentKindControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class IdentityDocumentKindPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Parties.IIdentityDocumentKindPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal IdentityDocumentKindPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class IdentityDocumentKindPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Parties.IIdentityDocumentKindPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ShortName 
            {
              get { return this.GetPropertyState<global::System.String>("ShortName"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Code 
            {
              get { return this.GetPropertyState<global::System.String>("Code"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> SID 
            {
              get { return this.GetPropertyState<global::System.String>("SID"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState Note 
            {
              get { return this.GetDataPropertyState("Note"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> SpecifyIdentitySeries 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("SpecifyIdentitySeries"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> SpecifyIdentityExpirationDate 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("SpecifyIdentityExpirationDate"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> SpecifyIdentityAuthorityCode 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("SpecifyIdentityAuthorityCode"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> SpecifyBirthPlace 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("SpecifyBirthPlace"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> IdentitySeriesPattern 
            {
              get { return this.GetPropertyState<global::System.String>("IdentitySeriesPattern"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> IdentityNumberPattern 
            {
              get { return this.GetPropertyState<global::System.String>("IdentityNumberPattern"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> IdentityAuthorityCodePattern 
            {
              get { return this.GetPropertyState<global::System.String>("IdentityAuthorityCodePattern"); }
            }


    protected internal IdentityDocumentKindPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// IdentityDocumentKindInfo.g.cs
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
  public class IdentityDocumentKindInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Parties.IIdentityDocumentKindInfo
  {
    public IdentityDocumentKindInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Parties.IIdentityDocumentKindPropertiesInfo Properties
    {
      get { return (global::Sungero.Parties.IIdentityDocumentKindPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Parties.Shared.IdentityDocumentKindPropertiesInfo(entityType);
    }

  }

  public class IdentityDocumentKindPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Parties.IIdentityDocumentKindPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ShortName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ShortName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Code 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Code");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo SID 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("SID");
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
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo SpecifyIdentitySeries 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("SpecifyIdentitySeries");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo SpecifyIdentityExpirationDate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("SpecifyIdentityExpirationDate");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo SpecifyIdentityAuthorityCode 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("SpecifyIdentityAuthorityCode");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo SpecifyBirthPlace 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("SpecifyBirthPlace");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo IdentitySeriesPattern 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("IdentitySeriesPattern");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo IdentityNumberPattern 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("IdentityNumberPattern");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo IdentityAuthorityCodePattern 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("IdentityAuthorityCodePattern");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal IdentityDocumentKindPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// IdentityDocumentKindHandlers.g.cs
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
  public partial class IdentityDocumentKindSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IIdentityDocumentKindSharedHandlers
  {
    private global::Sungero.Parties.IIdentityDocumentKind _obj
    {
      get { return (global::Sungero.Parties.IIdentityDocumentKind)this.Entity; }
    }
    public virtual void ShortNameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void CodeChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void SIDChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void NoteChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }



    public virtual void SpecifyIdentityExpirationDateChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }



    public virtual void SpecifyBirthPlaceChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }


    public virtual void IdentitySeriesPatternChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void IdentityNumberPatternChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void IdentityAuthorityCodePatternChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public IdentityDocumentKindSharedHandlers(global::Sungero.Parties.IIdentityDocumentKind entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// IdentityDocumentKindResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared.IdentityDocumentKind
{
  /// <summary>
  /// Represents IdentityDocumentKind resources.
  /// </summary>
  public class IdentityDocumentKindResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Parties.IdentityDocumentKind.IIdentityDocumentKindResources
  {
    public virtual global::CommonLibrary.LocalizedString InvalidPattern
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IIdentityDocumentKind) , "InvalidPattern");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InvalidPatternFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IIdentityDocumentKind), "InvalidPattern", false, args);
    }

  }
}

// ==================================================================
// IdentityDocumentKindSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Shared
{
  public partial class IdentityDocumentKindFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Parties.IIdentityDocumentKind _obj
    {
      get { return (global::Sungero.Parties.IIdentityDocumentKind)this.Entity; }
    }

    public IdentityDocumentKindFunctions(global::Sungero.Parties.IIdentityDocumentKind entity) : base(entity) { }
  }
}

// ==================================================================
// IdentityDocumentKindFunctions.g.cs
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
  internal static class IdentityDocumentKind
  {
  }
}

// ==================================================================
// IdentityDocumentKindFilterState.g.cs
// ==================================================================

namespace Sungero.Parties.Shared.IdentityDocumentKind
{

  public class IdentityDocumentKindFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Parties.IIdentityDocumentKindFilterInfo
  {
  }

  public class IdentityDocumentKindFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Parties.IIdentityDocumentKindFilterState
  {



    public new Sungero.Parties.IIdentityDocumentKindFilterInfo Info
    {
      get
      {
        return (Sungero.Parties.IIdentityDocumentKindFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Parties.Shared.IdentityDocumentKind.IdentityDocumentKindFilterInfo();
    }

  }
}

// ==================================================================
// IdentityDocumentKindSharedPublicFunctions.g.cs
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
  public class IdentityDocumentKindSharedPublicFunctions : global::Sungero.Parties.Shared.IIdentityDocumentKindSharedPublicFunctions
  {
  }
}