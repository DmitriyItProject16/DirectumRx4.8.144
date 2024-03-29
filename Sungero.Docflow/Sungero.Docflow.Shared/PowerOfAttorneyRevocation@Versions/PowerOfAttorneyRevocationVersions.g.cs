
// ==================================================================
// PowerOfAttorneyRevocationVersionsState.g.cs
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
  public class PowerOfAttorneyRevocationVersionsState : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsState, global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsState
  {
    public PowerOfAttorneyRevocationVersionsState(global::Sungero.Docflow.IPowerOfAttorneyRevocationVersions entity) : base(entity) { }

    public new global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyRevocationVersionsPropertyStates(entity);
    }


  }


  public class PowerOfAttorneyRevocationVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertyStates, global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IPowerOfAttorneyRevocation> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IPowerOfAttorneyRevocation>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IPowerOfAttorneyRevocation>("ElectronicDocument"); }
            }


    protected internal PowerOfAttorneyRevocationVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class PowerOfAttorneyRevocationVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyState<T>, global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IPowerOfAttorneyRevocationVersions
  {
    public new global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyRevocationVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal PowerOfAttorneyRevocationVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class PowerOfAttorneyRevocationVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyStates, global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsCollectionPropertyStates
  {

    protected internal PowerOfAttorneyRevocationVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// PowerOfAttorneyRevocationVersionsInfo.g.cs
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
  public class PowerOfAttorneyRevocationVersionsInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsInfo, global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsInfo
  {
    public PowerOfAttorneyRevocationVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyRevocationVersionsPropertiesInfo(entityType);
    }

  }

  public class PowerOfAttorneyRevocationVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertiesInfo, global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyRevocationInfo, global::Sungero.Docflow.IPowerOfAttorneyRevocation> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IPowerOfAttorneyRevocationInfo, global::Sungero.Docflow.IPowerOfAttorneyRevocation>(propertyMetadata);
          }
        }


    protected internal PowerOfAttorneyRevocationVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
