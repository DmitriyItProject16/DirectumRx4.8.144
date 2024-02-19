
// ==================================================================
// SupAgreementTrackingState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class SupAgreementTrackingState : 
    global::Sungero.Contracts.Shared.ContractualDocumentTrackingState, global::Sungero.Contracts.ISupAgreementTrackingState
  {
    public SupAgreementTrackingState(global::Sungero.Contracts.ISupAgreementTracking entity) : base(entity) { }

    public new global::Sungero.Contracts.ISupAgreementTrackingPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.ISupAgreementTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.SupAgreementTrackingPropertyStates(entity);
    }


  }


  public class SupAgreementTrackingPropertyStates : 
    global::Sungero.Contracts.Shared.ContractualDocumentTrackingPropertyStates, global::Sungero.Contracts.ISupAgreementTrackingPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.ISupAgreement> OfficialDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.ISupAgreement>)base.OfficialDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.Contracts.ISupAgreement>("OfficialDocument"); }
            }


    protected internal SupAgreementTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class SupAgreementTrackingCollectionPropertyState<T> :
    global::Sungero.Contracts.Shared.ContractualDocumentTrackingCollectionPropertyState<T>, global::Sungero.Contracts.ISupAgreementTrackingCollectionPropertyState<T>
    where T : global::Sungero.Contracts.ISupAgreementTracking
  {
    public new global::Sungero.Contracts.ISupAgreementTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.ISupAgreementTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Contracts.Shared.SupAgreementTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal SupAgreementTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class SupAgreementTrackingCollectionPropertyStates :
    global::Sungero.Contracts.Shared.ContractualDocumentTrackingCollectionPropertyStates, global::Sungero.Contracts.ISupAgreementTrackingCollectionPropertyStates
  {

    protected internal SupAgreementTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// SupAgreementTrackingInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class SupAgreementTrackingInfo : 
    global::Sungero.Contracts.Shared.ContractualDocumentTrackingInfo, global::Sungero.Contracts.ISupAgreementTrackingInfo
  {
    public SupAgreementTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Contracts.ISupAgreementTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.Contracts.ISupAgreementTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.SupAgreementTrackingPropertiesInfo(entityType);
    }

  }

  public class SupAgreementTrackingPropertiesInfo : 
    global::Sungero.Contracts.Shared.ContractualDocumentTrackingPropertiesInfo, global::Sungero.Contracts.ISupAgreementTrackingPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Contracts.ISupAgreementInfo, global::Sungero.Contracts.ISupAgreement> OfficialDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Contracts.ISupAgreementInfo, global::Sungero.Contracts.ISupAgreement>(propertyMetadata);
          }
        }


    protected internal SupAgreementTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
