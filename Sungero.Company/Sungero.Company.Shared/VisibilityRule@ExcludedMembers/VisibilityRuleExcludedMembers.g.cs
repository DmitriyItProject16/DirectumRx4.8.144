
// ==================================================================
// VisibilityRuleExcludedMembersState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared
{
  public class VisibilityRuleExcludedMembersState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Company.IVisibilityRuleExcludedMembersState
  {
    public VisibilityRuleExcludedMembersState(global::Sungero.Company.IVisibilityRuleExcludedMembers entity) : base(entity) { }

    public new global::Sungero.Company.IVisibilityRuleExcludedMembersPropertyStates Properties
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembersPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Company.Shared.VisibilityRuleExcludedMembersPropertyStates(entity);
    }


  }


  public class VisibilityRuleExcludedMembersPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Company.IVisibilityRuleExcludedMembersPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IVisibilityRule> VisibilityRule 
            {
              get { return this.InternalVisibilityRule; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IVisibilityRule> InternalVisibilityRule
            {
              get { return this.GetPropertyState<global::Sungero.Company.IVisibilityRule>("VisibilityRule"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> Recipient 
            {
              get { return this.InternalRecipient; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> InternalRecipient
            {
              get { return this.GetPropertyState<global::Sungero.CoreEntities.IRecipient>("Recipient"); }
            }


    protected internal VisibilityRuleExcludedMembersPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class VisibilityRuleExcludedMembersCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Company.IVisibilityRuleExcludedMembersCollectionPropertyState<T>
    where T : global::Sungero.Company.IVisibilityRuleExcludedMembers
  {
    public new global::Sungero.Company.IVisibilityRuleExcludedMembersCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembersCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Company.Shared.VisibilityRuleExcludedMembersCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal VisibilityRuleExcludedMembersCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class VisibilityRuleExcludedMembersCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Company.IVisibilityRuleExcludedMembersCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState VisibilityRule
        {
          get { return this.GetChildPropertySummaryState("VisibilityRule"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Recipient
        {
          get { return this.GetChildPropertySummaryState("Recipient"); }
        }


    protected internal VisibilityRuleExcludedMembersCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// VisibilityRuleExcludedMembersInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared
{
  public class VisibilityRuleExcludedMembersInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Company.IVisibilityRuleExcludedMembersInfo
  {
    public VisibilityRuleExcludedMembersInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Company.IVisibilityRuleExcludedMembersPropertiesInfo Properties
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembersPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Company.Shared.VisibilityRuleExcludedMembersPropertiesInfo(entityType);
    }

  }

  public class VisibilityRuleExcludedMembersPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Company.IVisibilityRuleExcludedMembersPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IVisibilityRuleInfo, global::Sungero.Company.IVisibilityRule> VisibilityRule 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("VisibilityRule");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IVisibilityRuleInfo, global::Sungero.Company.IVisibilityRule>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.CoreEntities.IRecipientInfo, global::Sungero.CoreEntities.IRecipient> Recipient 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Recipient");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.CoreEntities.IRecipientInfo, global::Sungero.CoreEntities.IRecipient>(propertyMetadata);
          }
        }


    protected internal VisibilityRuleExcludedMembersPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
