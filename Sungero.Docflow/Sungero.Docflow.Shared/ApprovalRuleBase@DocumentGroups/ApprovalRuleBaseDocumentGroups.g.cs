
// ==================================================================
// ApprovalRuleBaseDocumentGroupsState.g.cs
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
  public class ApprovalRuleBaseDocumentGroupsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsState
  {
    public ApprovalRuleBaseDocumentGroupsState(global::Sungero.Docflow.IApprovalRuleBaseDocumentGroups entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentGroupsPropertyStates(entity);
    }


  }


  public class ApprovalRuleBaseDocumentGroupsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> ApprovalRuleBase 
            {
              get { return this.InternalApprovalRuleBase; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> InternalApprovalRuleBase
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalRuleBase>("ApprovalRuleBase"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentGroupBase> DocumentGroup 
            {
              get { return this.InternalDocumentGroup; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentGroupBase> InternalDocumentGroup
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IDocumentGroupBase>("DocumentGroup"); }
            }


    protected internal ApprovalRuleBaseDocumentGroupsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalRuleBaseDocumentGroupsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalRuleBaseDocumentGroups
  {
    public new global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentGroupsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalRuleBaseDocumentGroupsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalRuleBaseDocumentGroupsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalRuleBase
        {
          get { return this.GetChildPropertySummaryState("ApprovalRuleBase"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DocumentGroup
        {
          get { return this.GetChildPropertySummaryState("DocumentGroup"); }
        }


    protected internal ApprovalRuleBaseDocumentGroupsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalRuleBaseDocumentGroupsInfo.g.cs
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
  public class ApprovalRuleBaseDocumentGroupsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsInfo
  {
    public ApprovalRuleBaseDocumentGroupsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentGroupsPropertiesInfo(entityType);
    }

  }

  public class ApprovalRuleBaseDocumentGroupsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalRuleBaseDocumentGroupsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalRuleBaseInfo, global::Sungero.Docflow.IApprovalRuleBase> ApprovalRuleBase 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalRuleBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalRuleBaseInfo, global::Sungero.Docflow.IApprovalRuleBase>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IDocumentGroupBaseInfo, global::Sungero.Docflow.IDocumentGroupBase> DocumentGroup 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DocumentGroup");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IDocumentGroupBaseInfo, global::Sungero.Docflow.IDocumentGroupBase>(propertyMetadata);
          }
        }


    protected internal ApprovalRuleBaseDocumentGroupsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}