
// ==================================================================
// CancellationAgreementTrackingState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared
{
  public class CancellationAgreementTrackingState : 
    global::Sungero.Docflow.Shared.ContractualDocumentBaseTrackingState, global::Sungero.Exchange.ICancellationAgreementTrackingState
  {
    public CancellationAgreementTrackingState(global::Sungero.Exchange.ICancellationAgreementTracking entity) : base(entity) { }

    public new global::Sungero.Exchange.ICancellationAgreementTrackingPropertyStates Properties
    {
      get { return (global::Sungero.Exchange.ICancellationAgreementTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Exchange.Shared.CancellationAgreementTrackingPropertyStates(entity);
    }


  }


  public class CancellationAgreementTrackingPropertyStates : 
    global::Sungero.Docflow.Shared.ContractualDocumentBaseTrackingPropertyStates, global::Sungero.Exchange.ICancellationAgreementTrackingPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Exchange.ICancellationAgreement> OfficialDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Exchange.ICancellationAgreement>)base.OfficialDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.Exchange.ICancellationAgreement>("OfficialDocument"); }
            }


    protected internal CancellationAgreementTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CancellationAgreementTrackingCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.ContractualDocumentBaseTrackingCollectionPropertyState<T>, global::Sungero.Exchange.ICancellationAgreementTrackingCollectionPropertyState<T>
    where T : global::Sungero.Exchange.ICancellationAgreementTracking
  {
    public new global::Sungero.Exchange.ICancellationAgreementTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Exchange.ICancellationAgreementTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Exchange.Shared.CancellationAgreementTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal CancellationAgreementTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class CancellationAgreementTrackingCollectionPropertyStates :
    global::Sungero.Docflow.Shared.ContractualDocumentBaseTrackingCollectionPropertyStates, global::Sungero.Exchange.ICancellationAgreementTrackingCollectionPropertyStates
  {

    protected internal CancellationAgreementTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// CancellationAgreementTrackingInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Shared
{
  public class CancellationAgreementTrackingInfo : 
    global::Sungero.Docflow.Shared.ContractualDocumentBaseTrackingInfo, global::Sungero.Exchange.ICancellationAgreementTrackingInfo
  {
    public CancellationAgreementTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Exchange.ICancellationAgreementTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.Exchange.ICancellationAgreementTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Exchange.Shared.CancellationAgreementTrackingPropertiesInfo(entityType);
    }

  }

  public class CancellationAgreementTrackingPropertiesInfo : 
    global::Sungero.Docflow.Shared.ContractualDocumentBaseTrackingPropertiesInfo, global::Sungero.Exchange.ICancellationAgreementTrackingPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Exchange.ICancellationAgreementInfo, global::Sungero.Exchange.ICancellationAgreement> OfficialDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Exchange.ICancellationAgreementInfo, global::Sungero.Exchange.ICancellationAgreement>(propertyMetadata);
          }
        }


    protected internal CancellationAgreementTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}