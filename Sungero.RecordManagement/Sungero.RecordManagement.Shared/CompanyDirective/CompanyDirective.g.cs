
// ==================================================================
// CompanyDirectiveState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class CompanyDirectiveState : 
    global::Sungero.RecordManagement.Shared.OrderBaseState, global::Sungero.RecordManagement.ICompanyDirectiveState
  {
    public CompanyDirectiveState(global::Sungero.RecordManagement.ICompanyDirective entity) : base(entity) { }

    public new global::Sungero.RecordManagement.ICompanyDirectivePropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.ICompanyDirectivePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.CompanyDirectivePropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.ICompanyDirectiveControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.ICompanyDirectiveControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.CompanyDirectiveControlStates(entity);
    }

    public new global::Sungero.RecordManagement.ICompanyDirectivePageStates Pages
    {
      get { return (global::Sungero.RecordManagement.ICompanyDirectivePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.CompanyDirectivePageStates(entity);
    }

  }


  public class CompanyDirectiveControlStates : 
    global::Sungero.RecordManagement.Shared.OrderBaseControlStates, global::Sungero.RecordManagement.ICompanyDirectiveControlStates
  {

    protected internal CompanyDirectiveControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class CompanyDirectivePageStates : 
    global::Sungero.RecordManagement.Shared.OrderBasePageStates, global::Sungero.RecordManagement.ICompanyDirectivePageStates
  {

    protected internal CompanyDirectivePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CompanyDirectivePropertyStates : 
    global::Sungero.RecordManagement.Shared.OrderBasePropertyStates, global::Sungero.RecordManagement.ICompanyDirectivePropertyStates
  {
            public new global::Sungero.RecordManagement.ICompanyDirectiveVersionsCollectionPropertyState<global::Sungero.RecordManagement.ICompanyDirectiveVersions> Versions
            {
              get { return (global::Sungero.RecordManagement.ICompanyDirectiveVersionsCollectionPropertyState<global::Sungero.RecordManagement.ICompanyDirectiveVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.RecordManagement.Shared.CompanyDirectiveVersionsCollectionPropertyState<global::Sungero.RecordManagement.ICompanyDirectiveVersions>(entity, propertyName);
            }
            public new global::Sungero.RecordManagement.ICompanyDirectiveTrackingCollectionPropertyState<global::Sungero.RecordManagement.ICompanyDirectiveTracking> Tracking
            {
              get { return (global::Sungero.RecordManagement.ICompanyDirectiveTrackingCollectionPropertyState<global::Sungero.RecordManagement.ICompanyDirectiveTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.RecordManagement.Shared.CompanyDirectiveTrackingCollectionPropertyState<global::Sungero.RecordManagement.ICompanyDirectiveTracking>(entity, propertyName);
            }


    protected internal CompanyDirectivePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// CompanyDirectiveInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class CompanyDirectiveInfo : 
    global::Sungero.RecordManagement.Shared.OrderBaseInfo, global::Sungero.RecordManagement.ICompanyDirectiveInfo
  {
    public CompanyDirectiveInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.ICompanyDirectivePropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.ICompanyDirectivePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.CompanyDirectivePropertiesInfo(entityType);
    }

  }

  public class CompanyDirectivePropertiesInfo : 
    global::Sungero.RecordManagement.Shared.OrderBasePropertiesInfo, global::Sungero.RecordManagement.ICompanyDirectivePropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.RecordManagement.ICompanyDirectiveVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.RecordManagement.ICompanyDirectiveVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.RecordManagement.ICompanyDirectiveTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.RecordManagement.ICompanyDirectiveTrackingPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal CompanyDirectivePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// CompanyDirectiveHandlers.g.cs
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
  public partial class CompanyDirectiveSharedHandlers : global::Sungero.RecordManagement.OrderBaseSharedHandlers, ICompanyDirectiveSharedHandlers
  {
    private global::Sungero.RecordManagement.ICompanyDirective _obj
    {
      get { return (global::Sungero.RecordManagement.ICompanyDirective)this.Entity; }
    }


    public CompanyDirectiveSharedHandlers(global::Sungero.RecordManagement.ICompanyDirective entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CompanyDirectiveResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.CompanyDirective
{
  /// <summary>
  /// Represents CompanyDirective resources.
  /// </summary>
  public class CompanyDirectiveResources : global::Sungero.RecordManagement.Shared.OrderBase.OrderBaseResources, global::Sungero.RecordManagement.CompanyDirective.ICompanyDirectiveResources
  {
  }
}

// ==================================================================
// CompanyDirectiveSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class CompanyDirectiveFunctions : global::Sungero.RecordManagement.Shared.OrderBaseFunctions
  {
    private global::Sungero.RecordManagement.ICompanyDirective _obj
    {
      get { return (global::Sungero.RecordManagement.ICompanyDirective)this.Entity; }
    }

    public CompanyDirectiveFunctions(global::Sungero.RecordManagement.ICompanyDirective entity) : base(entity) { }
  }
}

// ==================================================================
// CompanyDirectiveFunctions.g.cs
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
  internal static class CompanyDirective
  {
  }
}

// ==================================================================
// CompanyDirectiveFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.CompanyDirective
{

  public class CompanyDirectiveFilterInfo : global::Sungero.RecordManagement.Shared.OrderBase.OrderBaseFilterInfo,
    global::Sungero.RecordManagement.ICompanyDirectiveFilterInfo
  {
  }

  public class CompanyDirectiveFilterState : global::Sungero.RecordManagement.Shared.OrderBase.OrderBaseFilterState,
    global::Sungero.RecordManagement.ICompanyDirectiveFilterState
  {



    public new Sungero.RecordManagement.ICompanyDirectiveFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.ICompanyDirectiveFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.CompanyDirective.CompanyDirectiveFilterInfo();
    }

  }
}

// ==================================================================
// CompanyDirectiveSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class CompanyDirectiveSharedPublicFunctions : global::Sungero.RecordManagement.Shared.ICompanyDirectiveSharedPublicFunctions
  {
  }
}
