
// ==================================================================
// MinutesBaseTrackingState.g.cs
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
  public class MinutesBaseTrackingState : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingState, global::Sungero.Docflow.IMinutesBaseTrackingState
  {
    public MinutesBaseTrackingState(global::Sungero.Docflow.IMinutesBaseTracking entity) : base(entity) { }

    public new global::Sungero.Docflow.IMinutesBaseTrackingPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IMinutesBaseTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseTrackingPropertyStates(entity);
    }


  }


  public class MinutesBaseTrackingPropertyStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingPropertyStates, global::Sungero.Docflow.IMinutesBaseTrackingPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMinutesBase> OfficialDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMinutesBase>)base.OfficialDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IMinutesBase>("OfficialDocument"); }
            }


    protected internal MinutesBaseTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class MinutesBaseTrackingCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingCollectionPropertyState<T>, global::Sungero.Docflow.IMinutesBaseTrackingCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IMinutesBaseTracking
  {
    public new global::Sungero.Docflow.IMinutesBaseTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IMinutesBaseTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal MinutesBaseTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class MinutesBaseTrackingCollectionPropertyStates :
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingCollectionPropertyStates, global::Sungero.Docflow.IMinutesBaseTrackingCollectionPropertyStates
  {

    protected internal MinutesBaseTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// MinutesBaseTrackingInfo.g.cs
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
  public class MinutesBaseTrackingInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingInfo, global::Sungero.Docflow.IMinutesBaseTrackingInfo
  {
    public MinutesBaseTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IMinutesBaseTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IMinutesBaseTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseTrackingPropertiesInfo(entityType);
    }

  }

  public class MinutesBaseTrackingPropertiesInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingPropertiesInfo, global::Sungero.Docflow.IMinutesBaseTrackingPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IMinutesBaseInfo, global::Sungero.Docflow.IMinutesBase> OfficialDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IMinutesBaseInfo, global::Sungero.Docflow.IMinutesBase>(propertyMetadata);
          }
        }


    protected internal MinutesBaseTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
