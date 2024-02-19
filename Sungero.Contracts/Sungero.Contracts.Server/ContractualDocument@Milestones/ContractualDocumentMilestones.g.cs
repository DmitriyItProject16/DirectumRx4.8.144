
// ==================================================================
// ContractualDocumentMilestones.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Server
{
  public class ContractualDocumentMilestonesFilterForPerformer<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Contracts.IContractualDocumentMilestones
    where TRootEntity : class, global::Sungero.Contracts.IContractualDocument
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.ContractualDocumentMilestonesPerformerPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("MilestonesPerformerFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Contracts.ContractualDocumentMilestonesPerformerPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).MilestonesPerformerFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContractualDocumentMilestonesFilterForPerformer(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ContractualDocumentMilestonesSearchFilterForPerformer<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.ContractualDocumentMilestonesPerformerSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("MilestonesPerformerSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Contracts.ContractualDocumentMilestonesPerformerSearchPropertyFilteringServerHandler<TQueryEntity>().MilestonesPerformerSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContractualDocumentMilestonesSearchFilterForPerformer(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ContractualDocumentMilestonesFilterForTask<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Workflow.ISimpleTask
    where TSourceEntity : class, global::Sungero.Contracts.IContractualDocumentMilestones
    where TRootEntity : class, global::Sungero.Contracts.IContractualDocument
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.ContractualDocumentMilestonesTaskPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("MilestonesTaskFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Contracts.ContractualDocumentMilestonesTaskPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).MilestonesTaskFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContractualDocumentMilestonesFilterForTask(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ContractualDocumentMilestonesSearchFilterForTask<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Workflow.ISimpleTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.ContractualDocumentMilestonesTaskSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("MilestonesTaskSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Contracts.ContractualDocumentMilestonesTaskSearchPropertyFilteringServerHandler<TQueryEntity>().MilestonesTaskSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContractualDocumentMilestonesSearchFilterForTask(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Contracts.Server.ContractualDocumentMilestonesFilterForPerformer<global::Sungero.Company.IEmployee, global::Sungero.Contracts.IContractualDocumentMilestones, global::Sungero.Contracts.IContractualDocument>), "Performer")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Contracts.Server.ContractualDocumentMilestonesSearchFilterForPerformer<global::Sungero.CoreEntities.IRecipient>), "Performer")]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Contracts.Server.ContractualDocumentMilestonesFilterForTask<global::Sungero.Workflow.ISimpleTask, global::Sungero.Contracts.IContractualDocumentMilestones, global::Sungero.Contracts.IContractualDocument>), "Task")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Contracts.Server.ContractualDocumentMilestonesSearchFilterForTask<global::Sungero.Workflow.ISimpleTask>), "Task")]


  public class ContractualDocumentMilestones :
    global::Sungero.Domain.ChildEntity, global::Sungero.Contracts.IContractualDocumentMilestones
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("478d3e3d-4519-4bb0-b009-c43f7fbe0b95");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ContractualDocumentMilestones.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractualDocumentMilestones, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Contracts.IContractualDocumentMilestonesState State
    {
      get { return (global::Sungero.Contracts.IContractualDocumentMilestonesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractualDocumentMilestonesState(this);
    }

    public new virtual global::Sungero.Contracts.IContractualDocumentMilestonesInfo Info
    {
      get { return (global::Sungero.Contracts.IContractualDocumentMilestonesInfo)base.Info; }
    }


    public global::Sungero.Contracts.IContractualDocument ContractualDocument { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ContractualDocument; }
      set { this.ContractualDocument = (global::Sungero.Contracts.IContractualDocument)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers(this);
    }

    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }
    private global::System.DateTime? _Deadline;
    public virtual global::System.DateTime? Deadline
    {
      get
      {
        return this._Deadline;
      }

      set
      {
        this.SetPropertyValue("Deadline", this._Deadline, value, (propertyValue) => { this._Deadline = propertyValue; }, this.DeadlineChangedHandler);
      }
    }
    private global::System.Int32? _DaysToFinishWorks;
    public virtual global::System.Int32? DaysToFinishWorks
    {
      get
      {
        return this._DaysToFinishWorks;
      }

      set
      {
        this.SetPropertyValue("DaysToFinishWorks", this._DaysToFinishWorks, value, (propertyValue) => { this._DaysToFinishWorks = propertyValue; }, this.DaysToFinishWorksChangedHandler);
      }
    }
    private global::System.Boolean? _IsCompleted;
    public virtual global::System.Boolean? IsCompleted
    {
      get
      {
        return this._IsCompleted;
      }

      set
      {
        this.SetPropertyValue("IsCompleted", this._IsCompleted, value, (propertyValue) => { this._IsCompleted = propertyValue; }, this.IsCompletedChangedHandler);
      }
    }
    private global::System.String _Note;
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }







    private global::Sungero.Company.IEmployee _Performer;
    public virtual global::Sungero.Company.IEmployee Performer
    {
      get
      {
        return this._Performer;
      }

      set
      {
        this.SetPropertyValue("Performer", this._Performer, value, (propertyValue) => { this._Performer = propertyValue; }, this.PerformerChangedHandler);
      }
    }
    private global::Sungero.Workflow.ISimpleTask _Task;
    public virtual global::Sungero.Workflow.ISimpleTask Task
    {
      get
      {
        return this._Task;
      }

      set
      {
        this.SetPropertyValue("Task", this._Task, value, (propertyValue) => { this._Task = propertyValue; }, this.TaskChangedHandler);
      }
    }




    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Contracts.IContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesNameChanged(args);
    }

    protected void DeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.Deadline, this.Deadline, this);
     ((global::Sungero.Contracts.IContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesDeadlineChanged(args);
    }

    protected void DaysToFinishWorksChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DaysToFinishWorks, this.DaysToFinishWorks, this);
     ((global::Sungero.Contracts.IContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesDaysToFinishWorksChanged(args);
    }

    protected void PerformerChangedHandler()
    {
      var args = new global::Sungero.Contracts.Shared.ContractualDocumentMilestonesPerformerChangedEventArgs(this.State.Properties.Performer, this.Performer, this);
     ((global::Sungero.Contracts.IContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesPerformerChanged(args);
    }

    protected void IsCompletedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsCompleted, this.IsCompleted, this);
     ((global::Sungero.Contracts.IContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesIsCompletedChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Contracts.IContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesNoteChanged(args);
    }

    protected void TaskChangedHandler()
    {
      var args = new global::Sungero.Contracts.Shared.ContractualDocumentMilestonesTaskChangedEventArgs(this.State.Properties.Task, this.Task, this);
     ((global::Sungero.Contracts.IContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesTaskChanged(args);
    }



    #endregion


    public ContractualDocumentMilestones()
    {
    }

  }
}

// ==================================================================
// ContractualDocumentMilestonesHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts
{
  public partial class ContractualDocumentMilestonesPerformerPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Contracts.IContractualDocumentMilestones _obj
    {
      get { return (global::Sungero.Contracts.IContractualDocumentMilestones)this.Entity; }
    }

    private global::Sungero.Contracts.IContractualDocument _root
    {
      get { return (global::Sungero.Contracts.IContractualDocument)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> MilestonesPerformerFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ContractualDocumentMilestonesPerformerPropertyFilteringServerHandler(global::Sungero.Contracts.IContractualDocumentMilestones entity, global::Sungero.Contracts.IContractualDocument root)
      : base(entity, root)
    {
    }
  }

  public partial class ContractualDocumentMilestonesPerformerSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> MilestonesPerformerSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ContractualDocumentMilestonesPerformerSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }

  public partial class ContractualDocumentMilestonesTaskPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Workflow.ISimpleTask
  {
    private global::Sungero.Contracts.IContractualDocumentMilestones _obj
    {
      get { return (global::Sungero.Contracts.IContractualDocumentMilestones)this.Entity; }
    }

    private global::Sungero.Contracts.IContractualDocument _root
    {
      get { return (global::Sungero.Contracts.IContractualDocument)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> MilestonesTaskFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ContractualDocumentMilestonesTaskPropertyFilteringServerHandler(global::Sungero.Contracts.IContractualDocumentMilestones entity, global::Sungero.Contracts.IContractualDocument root)
      : base(entity, root)
    {
    }
  }

  public partial class ContractualDocumentMilestonesTaskSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Workflow.ISimpleTask
  {

    public virtual global::System.Linq.IQueryable<T> MilestonesTaskSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ContractualDocumentMilestonesTaskSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ContractualDocumentMilestonesEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Server
{
}