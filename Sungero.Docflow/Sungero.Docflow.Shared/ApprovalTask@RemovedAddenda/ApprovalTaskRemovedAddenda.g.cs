
// ==================================================================
// ApprovalTaskRemovedAddendaState.g.cs
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
  public class ApprovalTaskRemovedAddendaState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalTaskRemovedAddendaState
  {
    public ApprovalTaskRemovedAddendaState(global::Sungero.Docflow.IApprovalTaskRemovedAddenda entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalTaskRemovedAddendaPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalTaskRemovedAddendaPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskRemovedAddendaPropertyStates(entity);
    }


  }


  public class ApprovalTaskRemovedAddendaPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalTaskRemovedAddendaPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalTask> ApprovalTask 
            {
              get { return this.InternalApprovalTask; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalTask> InternalApprovalTask
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalTask>("ApprovalTask"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int64?> AddendumId 
            {
              get { return this.GetPropertyState<global::System.Int64?>("AddendumId"); }
            }


    protected internal ApprovalTaskRemovedAddendaPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalTaskRemovedAddendaCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalTaskRemovedAddendaCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalTaskRemovedAddenda
  {
    public new global::Sungero.Docflow.IApprovalTaskRemovedAddendaCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalTaskRemovedAddendaCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskRemovedAddendaCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalTaskRemovedAddendaCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalTaskRemovedAddendaCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalTaskRemovedAddendaCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalTask
        {
          get { return this.GetChildPropertySummaryState("ApprovalTask"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState AddendumId
        {
          get { return this.GetChildPropertySummaryState("AddendumId"); }
        }


    protected internal ApprovalTaskRemovedAddendaCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalTaskRemovedAddendaInfo.g.cs
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
  public class ApprovalTaskRemovedAddendaInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalTaskRemovedAddendaInfo
  {
    public ApprovalTaskRemovedAddendaInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalTaskRemovedAddendaPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalTaskRemovedAddendaPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskRemovedAddendaPropertiesInfo(entityType);
    }

  }

  public class ApprovalTaskRemovedAddendaPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalTaskRemovedAddendaPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalTaskInfo, global::Sungero.Docflow.IApprovalTask> ApprovalTask 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalTask");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalTaskInfo, global::Sungero.Docflow.IApprovalTask>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ILongIntegerPropertyInfo AddendumId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.LongIntegerPropertyMetadata>("AddendumId");
             return new global::Sungero.Domain.Shared.LongIntegerPropertyInfo(propertyMetadata);
          }
        }


    protected internal ApprovalTaskRemovedAddendaPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
