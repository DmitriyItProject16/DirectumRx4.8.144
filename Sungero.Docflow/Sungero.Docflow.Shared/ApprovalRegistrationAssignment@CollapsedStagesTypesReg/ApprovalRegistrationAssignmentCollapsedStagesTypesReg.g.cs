
// ==================================================================
// ApprovalRegistrationAssignmentCollapsedStagesTypesRegState.g.cs
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
  public class ApprovalRegistrationAssignmentCollapsedStagesTypesRegState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegState
  {
    public ApprovalRegistrationAssignmentCollapsedStagesTypesRegState(global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesReg entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertyStates(entity);
    }


  }


  public class ApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRegistrationAssignment> ApprovalRegistrationAssignment 
            {
              get { return this.InternalApprovalRegistrationAssignment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRegistrationAssignment> InternalApprovalRegistrationAssignment
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalRegistrationAssignment>("ApprovalRegistrationAssignment"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> StageType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("StageType"); }
            }


    protected internal ApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesReg
  {
    public new global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalRegistrationAssignment
        {
          get { return this.GetChildPropertySummaryState("ApprovalRegistrationAssignment"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState StageType
        {
          get { return this.GetChildPropertySummaryState("StageType"); }
        }


    protected internal ApprovalRegistrationAssignmentCollapsedStagesTypesRegCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalRegistrationAssignmentCollapsedStagesTypesRegInfo.g.cs
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
  public class ApprovalRegistrationAssignmentCollapsedStagesTypesRegInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegInfo
  {
    public ApprovalRegistrationAssignmentCollapsedStagesTypesRegInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertiesInfo(entityType);
    }

  }

  public class ApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalRegistrationAssignmentInfo, global::Sungero.Docflow.IApprovalRegistrationAssignment> ApprovalRegistrationAssignment 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalRegistrationAssignment");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalRegistrationAssignmentInfo, global::Sungero.Docflow.IApprovalRegistrationAssignment>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo StageType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("StageType");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }


    protected internal ApprovalRegistrationAssignmentCollapsedStagesTypesRegPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
