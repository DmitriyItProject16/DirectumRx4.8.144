
// ==================================================================
// AddendumVersionsState.g.cs
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
  public class AddendumVersionsState : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsState, global::Sungero.Docflow.IAddendumVersionsState
  {
    public AddendumVersionsState(global::Sungero.Docflow.IAddendumVersions entity) : base(entity) { }

    public new global::Sungero.Docflow.IAddendumVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IAddendumVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.AddendumVersionsPropertyStates(entity);
    }


  }


  public class AddendumVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertyStates, global::Sungero.Docflow.IAddendumVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IAddendum> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IAddendum>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IAddendum>("ElectronicDocument"); }
            }


    protected internal AddendumVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class AddendumVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyState<T>, global::Sungero.Docflow.IAddendumVersionsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IAddendumVersions
  {
    public new global::Sungero.Docflow.IAddendumVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IAddendumVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.AddendumVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal AddendumVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class AddendumVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyStates, global::Sungero.Docflow.IAddendumVersionsCollectionPropertyStates
  {

    protected internal AddendumVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// AddendumVersionsInfo.g.cs
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
  public class AddendumVersionsInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsInfo, global::Sungero.Docflow.IAddendumVersionsInfo
  {
    public AddendumVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IAddendumVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IAddendumVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.AddendumVersionsPropertiesInfo(entityType);
    }

  }

  public class AddendumVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertiesInfo, global::Sungero.Docflow.IAddendumVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IAddendumInfo, global::Sungero.Docflow.IAddendum> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IAddendumInfo, global::Sungero.Docflow.IAddendum>(propertyMetadata);
          }
        }


    protected internal AddendumVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
