
// ==================================================================
// CounterpartyConflictProcessingTask.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingTask :
    global::Sungero.Workflow.Client.Task, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("03a51b42-a322-4574-90bb-212ea03ed71e");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTask.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.ICounterpartyConflictProcessingTask, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Subject; }
        set { this.Subject = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Subject"; }
      }


    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskState State
    {
      get
      {
        return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskState(this);
    }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskInfo Info
    {
      get
      {
        return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskInfo)base.Info;
      }
    }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _CounterpartyOrganizationId;

        public virtual global::System.String CounterpartyOrganizationId
        {
          get { return this._CounterpartyOrganizationId.Value; }
          set { this._CounterpartyOrganizationId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _CounterpartyBranchId;

        public virtual global::System.String CounterpartyBranchId
        {
          get { return this._CounterpartyBranchId.Value; }
          set { this._CounterpartyBranchId.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Assignee;

              public virtual global::Sungero.Company.IEmployee Assignee
              {
              get
              {
                return this._Assignee.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Assignee as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.ExchangeCore.CounterpartyConflictProcessingTaskClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.ExchangeCore.CounterpartyConflictProcessingTaskSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AssigneeChangedHandler()
    {
      var args = new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskAssigneeChangedEventArgs(this.State.Properties.Assignee, this.Assignee, this);
     ((global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskSharedHandlers)this.SharedHandlers).AssigneeChanged(args);
    }


    protected void CounterpartyOrganizationIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CounterpartyOrganizationId, this.CounterpartyOrganizationId, this);
     ((global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskSharedHandlers)this.SharedHandlers).CounterpartyOrganizationIdChanged(args);
    }

    protected void CounterpartyBranchIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CounterpartyBranchId, this.CounterpartyBranchId, this);
     ((global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskSharedHandlers)this.SharedHandlers).CounterpartyBranchIdChanged(args);
    }




  protected global::Sungero.Company.IEmployee AssigneeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskAssigneeValueInputEventArgs(this.Assignee, value, this, this.Info.Properties.Assignee);
    ((global::Sungero.ExchangeCore.CounterpartyConflictProcessingTaskClientHandlers)this.Handlers).AssigneeValueInput(args);
    return args.NewValue;
  }


  protected global::System.String CounterpartyOrganizationIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.CounterpartyOrganizationId, value, this, this.Info.Properties.CounterpartyOrganizationId);
    ((global::Sungero.ExchangeCore.CounterpartyConflictProcessingTaskClientHandlers)this.Handlers).CounterpartyOrganizationIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String CounterpartyBranchIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.CounterpartyBranchId, value, this, this.Info.Properties.CounterpartyBranchId);
    ((global::Sungero.ExchangeCore.CounterpartyConflictProcessingTaskClientHandlers)this.Handlers).CounterpartyBranchIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors









              protected virtual void InitAssigneeNavigationProperty()
              {
                this._Assignee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Assignee", this);
                this._Assignee.ValueChanged += (sender, e) => { this.AssigneeChangedHandler(); };
                this.AddProperty(this._Assignee as global::Sungero.Domain.Client.IProperty);
              }



            protected override void InitObserversCollectionProperty()
            {
              this._Observers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObservers>("Observers", this);
              this._Observers.ValueChanged += (sender, e) => { this.ObserversChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Observers);
              this.SetObserversEventHandlers();
            }


    public CounterpartyConflictProcessingTask()
    {
            this._CounterpartyOrganizationId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("CounterpartyOrganizationId", this);
            this._CounterpartyOrganizationId.ValueChanged += (sender, e) => { this.CounterpartyOrganizationIdChangedHandler(); };
            this.AddProperty(this._CounterpartyOrganizationId);

            this._CounterpartyBranchId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("CounterpartyBranchId", this);
            this._CounterpartyBranchId.ValueChanged += (sender, e) => { this.CounterpartyBranchIdChangedHandler(); };
            this.AddProperty(this._CounterpartyBranchId);

            this.InitAssigneeNavigationProperty();








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

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
// CounterpartyConflictProcessingTaskPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingTaskPresenter<T> :
    global::Sungero.Workflow.Client.TaskPresenter<T>
    where T : class, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask
  {
    #region Fields and properties




    #endregion

    #region Methods


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _AssigneeCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter AssigneeCollectionPresenter
              {
          get { return this._AssigneeCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
              this._ProcessKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.IProcessKind>(() => this.Entity.Id, typeof(T), "ProcessKind");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.CoreEntities.IUser>(() => this.Entity, typeof(T), "Author");

              this._StartedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "StartedBy");

              this._ParentTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "ParentTask");

              this._ParentAssignmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.IAssignmentBase>(() => this.Entity.Id, typeof(T), "ParentAssignment");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");

                  this._AssigneeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("0fc5b8a0-2256-45e1-975c-f839e3119638"));
              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");


                        this._ObserversObserverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObservers), "Observer");



    }

    public CounterpartyConflictProcessingTaskPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// CounterpartyConflictProcessingTaskCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingTaskCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.TaskCollectionPresenter<T>
    where T: class, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public CounterpartyConflictProcessingTaskCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public CounterpartyConflictProcessingTaskCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public CounterpartyConflictProcessingTaskCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public CounterpartyConflictProcessingTaskCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// CounterpartyConflictProcessingTaskRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{ 
  public class CounterpartyConflictProcessingTaskRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.TaskRepositoryImplementer<T>,
      global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskRepositoryImplementer<T>
      where T : global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask
    {
       public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskAccessRights AccessRights
       {
          get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskAccessRights)base.AccessRights; }
       }

       public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskInfo Info
       {
          get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CounterpartyConflictProcessingTaskAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingTaskAccessRights : 
    Sungero.Workflow.Client.TaskAccessRights, Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskAccessRights
  {

    public CounterpartyConflictProcessingTaskAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CounterpartyConflictProcessingTaskTypeAccessRights : 
    Sungero.Workflow.Client.TaskTypeAccessRights, Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskAccessRights
  {

    public CounterpartyConflictProcessingTaskTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// CounterpartyConflictProcessingTaskBlocksInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
}
