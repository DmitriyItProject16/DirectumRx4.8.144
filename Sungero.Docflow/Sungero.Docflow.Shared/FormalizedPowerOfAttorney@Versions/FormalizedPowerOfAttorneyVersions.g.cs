
// ==================================================================
// FormalizedPowerOfAttorneyVersionsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class FormalizedPowerOfAttorneyVersionsState : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsState, global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsState
  {
    public FormalizedPowerOfAttorneyVersionsState(global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions entity) : base(entity) { }

    public new global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FormalizedPowerOfAttorneyVersionsPropertyStates(entity);
    }


  }


  public class FormalizedPowerOfAttorneyVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsPropertyStates, global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IFormalizedPowerOfAttorney> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IFormalizedPowerOfAttorney>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IFormalizedPowerOfAttorney>("ElectronicDocument"); }
            }


    protected internal FormalizedPowerOfAttorneyVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class FormalizedPowerOfAttorneyVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsCollectionPropertyState<T>, global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions
  {
    public new global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.FormalizedPowerOfAttorneyVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal FormalizedPowerOfAttorneyVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class FormalizedPowerOfAttorneyVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsCollectionPropertyStates, global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsCollectionPropertyStates
  {

    protected internal FormalizedPowerOfAttorneyVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// FormalizedPowerOfAttorneyVersionsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class FormalizedPowerOfAttorneyVersionsInfo : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsInfo, global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsInfo
  {
    public FormalizedPowerOfAttorneyVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.FormalizedPowerOfAttorneyVersionsPropertiesInfo(entityType);
    }

  }

  public class FormalizedPowerOfAttorneyVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.PowerOfAttorneyBaseVersionsPropertiesInfo, global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IFormalizedPowerOfAttorneyInfo, global::Sungero.Docflow.IFormalizedPowerOfAttorney> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IFormalizedPowerOfAttorneyInfo, global::Sungero.Docflow.IFormalizedPowerOfAttorney>(propertyMetadata);
          }
        }


    protected internal FormalizedPowerOfAttorneyVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}