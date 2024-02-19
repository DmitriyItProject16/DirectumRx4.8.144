
// ==================================================================
// OrderBaseVersionsState.g.cs
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
  public class OrderBaseVersionsState : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsState, global::Sungero.RecordManagement.IOrderBaseVersionsState
  {
    public OrderBaseVersionsState(global::Sungero.RecordManagement.IOrderBaseVersions entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IOrderBaseVersionsPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IOrderBaseVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.OrderBaseVersionsPropertyStates(entity);
    }


  }


  public class OrderBaseVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertyStates, global::Sungero.RecordManagement.IOrderBaseVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IOrderBase> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IOrderBase>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.RecordManagement.IOrderBase>("ElectronicDocument"); }
            }


    protected internal OrderBaseVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class OrderBaseVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyState<T>, global::Sungero.RecordManagement.IOrderBaseVersionsCollectionPropertyState<T>
    where T : global::Sungero.RecordManagement.IOrderBaseVersions
  {
    public new global::Sungero.RecordManagement.IOrderBaseVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IOrderBaseVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.RecordManagement.Shared.OrderBaseVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal OrderBaseVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class OrderBaseVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyStates, global::Sungero.RecordManagement.IOrderBaseVersionsCollectionPropertyStates
  {

    protected internal OrderBaseVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// OrderBaseVersionsInfo.g.cs
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
  public class OrderBaseVersionsInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsInfo, global::Sungero.RecordManagement.IOrderBaseVersionsInfo
  {
    public OrderBaseVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IOrderBaseVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IOrderBaseVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.OrderBaseVersionsPropertiesInfo(entityType);
    }

  }

  public class OrderBaseVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertiesInfo, global::Sungero.RecordManagement.IOrderBaseVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.RecordManagement.IOrderBaseInfo, global::Sungero.RecordManagement.IOrderBase> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.RecordManagement.IOrderBaseInfo, global::Sungero.RecordManagement.IOrderBase>(propertyMetadata);
          }
        }


    protected internal OrderBaseVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
