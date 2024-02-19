
// ==================================================================
// ContractsApprovalRuleBusinessUnitsState.g.cs
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
  public class ContractsApprovalRuleBusinessUnitsState : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsState, global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsState
  {
    public ContractsApprovalRuleBusinessUnitsState(global::Sungero.Contracts.IContractsApprovalRuleBusinessUnits entity) : base(entity) { }

    public new global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleBusinessUnitsPropertyStates(entity);
    }


  }


  public class ContractsApprovalRuleBusinessUnitsPropertyStates : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsPropertyStates, global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractsApprovalRule> ApprovalRuleBase
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractsApprovalRule>)base.ApprovalRuleBase; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> InternalApprovalRuleBase
            {
              get { return this.GetPropertyState<global::Sungero.Contracts.IContractsApprovalRule>("ApprovalRuleBase"); }
            }


    protected internal ContractsApprovalRuleBusinessUnitsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ContractsApprovalRuleBusinessUnitsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsCollectionPropertyState<T>, global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsCollectionPropertyState<T>
    where T : global::Sungero.Contracts.IContractsApprovalRuleBusinessUnits
  {
    public new global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleBusinessUnitsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ContractsApprovalRuleBusinessUnitsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ContractsApprovalRuleBusinessUnitsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsCollectionPropertyStates, global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsCollectionPropertyStates
  {

    protected internal ContractsApprovalRuleBusinessUnitsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ContractsApprovalRuleBusinessUnitsInfo.g.cs
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
  public class ContractsApprovalRuleBusinessUnitsInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsInfo, global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsInfo
  {
    public ContractsApprovalRuleBusinessUnitsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsPropertiesInfo Properties
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleBusinessUnitsPropertiesInfo(entityType);
    }

  }

  public class ContractsApprovalRuleBusinessUnitsPropertiesInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseBusinessUnitsPropertiesInfo, global::Sungero.Contracts.IContractsApprovalRuleBusinessUnitsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Contracts.IContractsApprovalRuleInfo, global::Sungero.Contracts.IContractsApprovalRule> ApprovalRuleBase
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalRuleBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Contracts.IContractsApprovalRuleInfo, global::Sungero.Contracts.IContractsApprovalRule>(propertyMetadata);
          }
        }


    protected internal ContractsApprovalRuleBusinessUnitsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
