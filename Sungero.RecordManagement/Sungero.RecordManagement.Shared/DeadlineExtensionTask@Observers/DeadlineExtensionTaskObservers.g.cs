
// ==================================================================
// DeadlineExtensionTaskObserversState.g.cs
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
  public class DeadlineExtensionTaskObserversState : 
    global::Sungero.Workflow.Shared.TaskObserversState, global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversState
  {
    public DeadlineExtensionTaskObserversState(global::Sungero.RecordManagement.IDeadlineExtensionTaskObservers entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskObserversPropertyStates(entity);
    }


  }


  public class DeadlineExtensionTaskObserversPropertyStates : 
    global::Sungero.Workflow.Shared.TaskObserversPropertyStates, global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IDeadlineExtensionTask> Task
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IDeadlineExtensionTask>)base.Task; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Workflow.ITask> InternalTask
            {
              get { return this.GetPropertyState<global::Sungero.RecordManagement.IDeadlineExtensionTask>("Task"); }
            }


    protected internal DeadlineExtensionTaskObserversPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DeadlineExtensionTaskObserversCollectionPropertyState<T> :
    global::Sungero.Workflow.Shared.TaskObserversCollectionPropertyState<T>, global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversCollectionPropertyState<T>
    where T : global::Sungero.RecordManagement.IDeadlineExtensionTaskObservers
  {
    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversCollectionPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskObserversCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal DeadlineExtensionTaskObserversCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class DeadlineExtensionTaskObserversCollectionPropertyStates :
    global::Sungero.Workflow.Shared.TaskObserversCollectionPropertyStates, global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversCollectionPropertyStates
  {

    protected internal DeadlineExtensionTaskObserversCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// DeadlineExtensionTaskObserversInfo.g.cs
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
  public class DeadlineExtensionTaskObserversInfo : 
    global::Sungero.Workflow.Shared.TaskObserversInfo, global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversInfo
  {
    public DeadlineExtensionTaskObserversInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionTaskObserversPropertiesInfo(entityType);
    }

  }

  public class DeadlineExtensionTaskObserversPropertiesInfo : 
    global::Sungero.Workflow.Shared.TaskObserversPropertiesInfo, global::Sungero.RecordManagement.IDeadlineExtensionTaskObserversPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.RecordManagement.IDeadlineExtensionTaskInfo, global::Sungero.RecordManagement.IDeadlineExtensionTask> Task
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Task");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.RecordManagement.IDeadlineExtensionTaskInfo, global::Sungero.RecordManagement.IDeadlineExtensionTask>(propertyMetadata);
          }
        }


    protected internal DeadlineExtensionTaskObserversPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
