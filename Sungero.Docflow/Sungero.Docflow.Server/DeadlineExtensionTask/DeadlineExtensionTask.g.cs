
// ==================================================================
// DeadlineExtensionTask.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class DeadlineExtensionTaskFilter<T> :
      global::Sungero.Workflow.Server.TaskFilter<T>
      where T : class, global::Sungero.Docflow.IDeadlineExtensionTask
    {
      protected new global::Sungero.Docflow.IDeadlineExtensionTaskFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IDeadlineExtensionTaskFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public DeadlineExtensionTaskFilter(global::Sungero.Docflow.IDeadlineExtensionTaskFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected DeadlineExtensionTaskFilter()
      {
      }
    }
    public class DeadlineExtensionTaskSearchDialogModel : global::Sungero.Workflow.Server.TaskSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Importance { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Started { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> MaxDeadline { get; protected set; }



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Assignee { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> NewDeadline { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> CurrentDeadline { get; protected set; }


                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new DeadlineExtensionTaskObserversModel Observers { get { return (DeadlineExtensionTaskObserversModel)base.Observers; } protected set { base.Observers = value; } }

        }

      public class DeadlineExtensionTaskObserversModel : global::Sungero.Workflow.Server.TaskObserversModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }




  public class DeadlineExtensionTaskFilterForAssignee<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IUser
    where TSourceEntity : class, global::Sungero.Docflow.IDeadlineExtensionTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.DeadlineExtensionTaskAssigneePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("AssigneeFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.DeadlineExtensionTaskAssigneePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).AssigneeFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DeadlineExtensionTaskFilterForAssignee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class DeadlineExtensionTaskSearchFilterForAssignee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.DeadlineExtensionTaskAssigneeSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("AssigneeSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.DeadlineExtensionTaskAssigneeSearchPropertyFilteringServerHandler<TQueryEntity>().AssigneeSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DeadlineExtensionTaskSearchFilterForAssignee(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.DeadlineExtensionTaskFilter<global::Sungero.Docflow.IDeadlineExtensionTask>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.DeadlineExtensionTaskFilterForAssignee<global::Sungero.CoreEntities.IUser, global::Sungero.Docflow.IDeadlineExtensionTask>), "Assignee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.DeadlineExtensionTaskSearchFilterForAssignee<global::Sungero.CoreEntities.IRecipient>), "Assignee")]


  public class DeadlineExtensionTask :
    global::Sungero.Workflow.Server.Task, global::Sungero.Docflow.IDeadlineExtensionTask, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ef92411f-9fd6-4009-8e8f-92c8a2419a0c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.DeadlineExtensionTask.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDeadlineExtensionTask, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.IDeadlineExtensionTaskState State
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTaskState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DeadlineExtensionTaskState(this);
    }

    public new virtual global::Sungero.Docflow.IDeadlineExtensionTaskInfo Info
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTaskInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IDeadlineExtensionTaskAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTaskAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.DeadlineExtensionTaskAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.DeadlineExtensionTaskFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DeadlineExtensionTaskFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DeadlineExtensionTaskServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DeadlineExtensionTaskSharedHandlers(this);
    }

    private global::System.DateTime? _NewDeadline;
    public virtual global::System.DateTime? NewDeadline
    {
      get
      {
        return this._NewDeadline;
      }

      set
      {
        this.SetPropertyValue("NewDeadline", this._NewDeadline, value, (propertyValue) => { this._NewDeadline = propertyValue; }, this.NewDeadlineChangedHandler);
      }
    }
    private global::System.DateTime? _CurrentDeadline;
    public virtual global::System.DateTime? CurrentDeadline
    {
      get
      {
        return this._CurrentDeadline;
      }

      set
      {
        this.SetPropertyValue("CurrentDeadline", this._CurrentDeadline, value, (propertyValue) => { this._CurrentDeadline = propertyValue; }, this.CurrentDeadlineChangedHandler);
      }
    }







    private global::Sungero.CoreEntities.IUser _Assignee;
    public virtual global::Sungero.CoreEntities.IUser Assignee
    {
      get
      {
        return this._Assignee;
      }

      set
      {
        this.SetPropertyValue("Assignee", this._Assignee, value, (propertyValue) => { this._Assignee = propertyValue; }, this.AssigneeChangedHandler);
      }
    }



    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Workflow.ITaskObservers> CreateObserversCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IDeadlineExtensionTaskObservers>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.DeadlineExtensionTaskCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IDeadlineExtensionTask)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.DeadlineExtensionTaskCreatingFromServerHandler((global::Sungero.Docflow.IDeadlineExtensionTask)entitySource, this.Info);
    }

    #region Framework events

    protected void AssigneeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DeadlineExtensionTaskAssigneeChangedEventArgs(this.State.Properties.Assignee, this.Assignee, this);
     ((global::Sungero.Docflow.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).AssigneeChanged(args);
    }

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.Docflow.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }

    protected void CurrentDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.CurrentDeadline, this.CurrentDeadline, this);
     ((global::Sungero.Docflow.IDeadlineExtensionTaskSharedHandlers)this.SharedHandlers).CurrentDeadlineChanged(args);
    }




    #endregion


    public DeadlineExtensionTask()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments

    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
    }
    #endregion


  }
}

// ==================================================================
// DeadlineExtensionTaskHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{
  public partial class DeadlineExtensionTaskAssigneePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IUser
  {
    private global::Sungero.Docflow.IDeadlineExtensionTask _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTask)this.Entity; }
    }

    public DeadlineExtensionTaskAssigneePropertyFilteringServerHandler(global::Sungero.Docflow.IDeadlineExtensionTask entity)
      : base(entity)
    {
    }
  }

  public partial class DeadlineExtensionTaskAssigneeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> AssigneeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public DeadlineExtensionTaskAssigneeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class DeadlineExtensionTaskFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IDeadlineExtensionTask
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IDeadlineExtensionTaskFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDeadlineExtensionTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DeadlineExtensionTaskFilteringServerHandler(global::Sungero.Docflow.IDeadlineExtensionTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DeadlineExtensionTaskFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class DeadlineExtensionTaskSearchDialogServerHandler : global::Sungero.Workflow.TaskSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.DeadlineExtensionTaskSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.DeadlineExtensionTaskSearchDialogModel)this.Dialog;
       }
     }

     public DeadlineExtensionTaskSearchDialogServerHandler(global::Sungero.Docflow.Server.DeadlineExtensionTaskSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class DeadlineExtensionTaskServerHandlers : global::Sungero.Workflow.TaskServerHandlers
  {
    private global::Sungero.Docflow.IDeadlineExtensionTask _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTask)this.Entity; }
    }

    public DeadlineExtensionTaskServerHandlers(global::Sungero.Docflow.IDeadlineExtensionTask entity)
      : base(entity)
    {
    }
  }

  public partial class DeadlineExtensionTaskCreatingFromServerHandler : global::Sungero.Workflow.TaskCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IDeadlineExtensionTask _source
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTask)this.Source; }
    }

    private global::Sungero.Docflow.IDeadlineExtensionTaskInfo _info
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTaskInfo)this._Info; }
    }

    public DeadlineExtensionTaskCreatingFromServerHandler(global::Sungero.Docflow.IDeadlineExtensionTask source, global::Sungero.Docflow.IDeadlineExtensionTaskInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// DeadlineExtensionTaskEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// DeadlineExtensionTaskAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class DeadlineExtensionTaskAccessRights : 
    Sungero.Workflow.Server.TaskAccessRights, Sungero.Docflow.IDeadlineExtensionTaskAccessRights
  {

    public DeadlineExtensionTaskAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DeadlineExtensionTaskTypeAccessRights : 
    Sungero.Workflow.Server.TaskTypeAccessRights, Sungero.Docflow.IDeadlineExtensionTaskAccessRights
  {

    public DeadlineExtensionTaskTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// DeadlineExtensionTaskRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class DeadlineExtensionTaskRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.TaskRepositoryImplementer<T>,
      global::Sungero.Docflow.IDeadlineExtensionTaskRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDeadlineExtensionTask 
    {
       public new global::Sungero.Docflow.IDeadlineExtensionTaskAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDeadlineExtensionTaskAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDeadlineExtensionTaskInfo Info
       {
          get { return (global::Sungero.Docflow.IDeadlineExtensionTaskInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.DeadlineExtensionTaskTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DeadlineExtensionTaskPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// DeadlineExtensionTaskServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class DeadlineExtensionTaskFunctions : global::Sungero.Workflow.Server.TaskFunctions
  {
    private global::Sungero.Docflow.IDeadlineExtensionTask _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTask)this.Entity; }
    }

    public DeadlineExtensionTaskFunctions(global::Sungero.Docflow.IDeadlineExtensionTask entity) : base(entity) { }
  }
}

// ==================================================================
// DeadlineExtensionTaskFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class DeadlineExtensionTask
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DeadlineExtensionTaskFunctions" />
    internal static  global::System.String GetDesiredDeadlineLabel(global::System.DateTime desiredDeadline)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.DeadlineExtensionTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDesiredDeadlineLabel",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.DateTime) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { desiredDeadline });
      }
      else
      {
        return global::Sungero.Docflow.Server.DeadlineExtensionTaskFunctions.GetDesiredDeadlineLabel(desiredDeadline);
      }
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DeadlineExtensionTaskFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true, PackResultEntityEagerly = true)]
    internal static  global::Sungero.Docflow.Structures.DeadlineExtensionTask.ActionItemAssignees GetAssigneesForActionItemExecutionTask(global::Sungero.RecordManagement.IActionItemExecutionAssignment parent)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.DeadlineExtensionTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetAssigneesForActionItemExecutionTask",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.RecordManagement.IActionItemExecutionAssignment) }, null);
        return (global::Sungero.Docflow.Structures.DeadlineExtensionTask.ActionItemAssignees)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { parent });
      }
      else
      {
        return global::Sungero.Docflow.Server.DeadlineExtensionTaskFunctions.GetAssigneesForActionItemExecutionTask(parent);
      }
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DeadlineExtensionTaskFunctions" />
    [global::Sungero.Core.RemoteAttribute(PackResultEntityEagerly = true)]
    internal static  global::Sungero.Docflow.IDeadlineExtensionTask GetDeadlineExtension(global::Sungero.Workflow.IAssignment assignment)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.DeadlineExtensionTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDeadlineExtension",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Workflow.IAssignment) }, null);
        return (global::Sungero.Docflow.IDeadlineExtensionTask)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { assignment });
      }
      else
      {
        return global::Sungero.Docflow.Server.DeadlineExtensionTaskFunctions.GetDeadlineExtension(assignment);
      }
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DeadlineExtensionTaskFunctions" />
    internal static  global::System.String GetDeadlineExtensionSubject(global::Sungero.Docflow.IDeadlineExtensionTask task, CommonLibrary.LocalizedString beginningSubject)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.DeadlineExtensionTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDeadlineExtensionSubject",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IDeadlineExtensionTask), typeof(CommonLibrary.LocalizedString) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { task, beginningSubject });
      }
      else
      {
        return global::Sungero.Docflow.Server.DeadlineExtensionTaskFunctions.GetDeadlineExtensionSubject(task, beginningSubject);
      }
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DeadlineExtensionTaskFunctions" />
    internal static  global::System.Boolean ValidateDeadlineExtensionTaskStart(global::Sungero.Docflow.IDeadlineExtensionTask deadlineExtensionTask, Sungero.Core.IValidationArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)deadlineExtensionTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateDeadlineExtensionTaskStart", new System.Type[] { typeof(Sungero.Core.IValidationArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }

  }
}

// ==================================================================
// DeadlineExtensionTaskServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class DeadlineExtensionTaskServerPublicFunctions : global::Sungero.Docflow.Server.IDeadlineExtensionTaskServerPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineExtensionTaskQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class DeadlineExtensionTask
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.DeadlineExtensionTask.DeadlineExtensionTaskQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// DeadlineExtensionTaskBlock.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class DeadlineExtensionTaskArguments: global::Sungero.Workflow.Server.Route.TaskStartEventArguments<DeadlineExtensionTaskBlock, global::Sungero.Workflow.TaskBlock>
  {
    public DeadlineExtensionTaskArguments(DeadlineExtensionTaskBlock block) : base(block) { }
  }

  public class DeadlineExtensionTaskEndBlockEventArguments: global::Sungero.Workflow.Server.Route.TaskEndBlockEventArguments<DeadlineExtensionTaskBlock, global::Sungero.Workflow.TaskBlock, Sungero.Docflow.IDeadlineExtensionTask> 
  {
    public DeadlineExtensionTaskEndBlockEventArguments(DeadlineExtensionTaskBlock block) : base(block) { }
  }

  public partial class DeadlineExtensionTaskBlock : global::Sungero.Workflow.Blocks.TaskBlockWrapper<global::Sungero.Workflow.TaskBlock>    
  {
    public virtual global::System.DateTime? NewDeadline
    {
      get { return this.GetCustomProperty<global::System.DateTime?>("NewDeadline"); }
      set { this.SetCustomProperty("NewDeadline", value); }
    }
    public virtual global::System.DateTime? CurrentDeadline
    {
      get { return this.GetCustomProperty<global::System.DateTime?>("CurrentDeadline"); }
      set { this.SetCustomProperty("CurrentDeadline", value); }
    }

    public virtual global::Sungero.CoreEntities.IUser Assignee
    {
      get { return this.GetCustomNavigationProperty<global::Sungero.CoreEntities.IUser>("Assignee"); }
      set { this.SetCustomNavigationProperty("Assignee", value); }
    }




    public DeadlineExtensionTaskBlock(global::Sungero.Workflow.TaskBlock block) : base(block) { }
  }
}

// ==================================================================
// DeadlineExtensionTaskChildWrappers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// DeadlineExtensionTaskRouteHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public partial class DeadlineExtensionTaskRouteHandlers{
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Workflow.ITask Task { get; private set; }

    private global::Sungero.Docflow.IDeadlineExtensionTask _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionTask)this.Task; }
    }


    protected readonly int _schemeVersion;

    public DeadlineExtensionTaskRouteHandlers(global::Sungero.Docflow.IDeadlineExtensionTask task, int schemeVersion) 
    {
      this.Task = task;
      this._schemeVersion = schemeVersion;
    }


    [global::System.ObsoleteAttribute("Необходимо использовать LayerSchemeVersions")]
    private static class SchemeVersions
    {
      public static readonly int V1 = 1;
}

    }
}

// ==================================================================
// DeadlineExtensionTaskBlockHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server.DeadlineExtensionTaskBlocks
{
}

// ==================================================================
// DeadlineExtensionTaskBlocksInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}
