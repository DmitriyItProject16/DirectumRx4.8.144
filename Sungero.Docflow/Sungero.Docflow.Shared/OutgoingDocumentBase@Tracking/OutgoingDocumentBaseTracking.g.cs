
// ==================================================================
// OutgoingDocumentBaseTrackingState.g.cs
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
  public class OutgoingDocumentBaseTrackingState : 
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingState, global::Sungero.Docflow.IOutgoingDocumentBaseTrackingState
  {
    public OutgoingDocumentBaseTrackingState(global::Sungero.Docflow.IOutgoingDocumentBaseTracking entity) : base(entity) { }

    public new global::Sungero.Docflow.IOutgoingDocumentBaseTrackingPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseTrackingPropertyStates(entity);
    }


  }


  public class OutgoingDocumentBaseTrackingPropertyStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingPropertyStates, global::Sungero.Docflow.IOutgoingDocumentBaseTrackingPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOutgoingDocumentBase> OfficialDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOutgoingDocumentBase>)base.OfficialDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IOutgoingDocumentBase>("OfficialDocument"); }
            }


    protected internal OutgoingDocumentBaseTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class OutgoingDocumentBaseTrackingCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingCollectionPropertyState<T>, global::Sungero.Docflow.IOutgoingDocumentBaseTrackingCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IOutgoingDocumentBaseTracking
  {
    public new global::Sungero.Docflow.IOutgoingDocumentBaseTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal OutgoingDocumentBaseTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class OutgoingDocumentBaseTrackingCollectionPropertyStates :
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingCollectionPropertyStates, global::Sungero.Docflow.IOutgoingDocumentBaseTrackingCollectionPropertyStates
  {

    protected internal OutgoingDocumentBaseTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// OutgoingDocumentBaseTrackingInfo.g.cs
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
  public class OutgoingDocumentBaseTrackingInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingInfo, global::Sungero.Docflow.IOutgoingDocumentBaseTrackingInfo
  {
    public OutgoingDocumentBaseTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IOutgoingDocumentBaseTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseTrackingPropertiesInfo(entityType);
    }

  }

  public class OutgoingDocumentBaseTrackingPropertiesInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentTrackingPropertiesInfo, global::Sungero.Docflow.IOutgoingDocumentBaseTrackingPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IOutgoingDocumentBaseInfo, global::Sungero.Docflow.IOutgoingDocumentBase> OfficialDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IOutgoingDocumentBaseInfo, global::Sungero.Docflow.IOutgoingDocumentBase>(propertyMetadata);
          }
        }


    protected internal OutgoingDocumentBaseTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
