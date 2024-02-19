
// ==================================================================
// StatusReportRequestTask.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class StatusReportRequestTask :
    global::Sungero.Workflow.Client.Task, global::Sungero.RecordManagement.IStatusReportRequestTask
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c8aed854-ad26-4ee3-88a3-080bc98c12e1");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.StatusReportRequestTask.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IStatusReportRequestTask, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IStatusReportRequestTaskState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IStatusReportRequestTaskState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.StatusReportRequestTaskState(this);
    }

    public new global::Sungero.RecordManagement.IStatusReportRequestTaskInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IStatusReportRequestTaskInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IStatusReportRequestTaskAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IStatusReportRequestTaskAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.StatusReportRequestTaskAccessRights(this);
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








      protected global::Sungero.Domain.Client.TextProperty _Report;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String Report
      {
        get { return this._Report.Value; }
        set { this._Report.Value = value; }
      }
      protected global::Sungero.Domain.Client.TextProperty _ActionItem;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String ActionItem
      {
        get { return this._ActionItem.Value; }
        set { this._ActionItem.Value = value; }
      }
      protected global::Sungero.Domain.Client.TextProperty _ReportNote;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String ReportNote
      {
        get { return this._ReportNote.Value; }
        set { this._ReportNote.Value = value; }
      }



    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.StatusReportRequestTaskActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.StatusReportRequestTaskCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.StatusReportRequestTaskAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.StatusReportRequestTaskAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.StatusReportRequestTaskFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.StatusReportRequestTaskFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.StatusReportRequestTaskClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.StatusReportRequestTaskSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ReportChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Report, this.Report, this);
     ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).ReportChanged(args);
    }

    protected void ActionItemChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ActionItem, this.ActionItem, this);
     ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).ActionItemChanged(args);
    }

    protected void ReportNoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ReportNote, this.ReportNote, this);
     ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).ReportNoteChanged(args);
    }

    protected void AssigneeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.StatusReportRequestTaskAssigneeChangedEventArgs(this.State.Properties.Assignee, this.Assignee, this);
     ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).AssigneeChanged(args);
    }




  protected global::System.String ReportValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.Report, value, this, this.Info.Properties.Report);
    ((global::Sungero.RecordManagement.StatusReportRequestTaskClientHandlers)this.Handlers).ReportValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ActionItemValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.ActionItem, value, this, this.Info.Properties.ActionItem);
    ((global::Sungero.RecordManagement.StatusReportRequestTaskClientHandlers)this.Handlers).ActionItemValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ReportNoteValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.ReportNote, value, this, this.Info.Properties.ReportNote);
    ((global::Sungero.RecordManagement.StatusReportRequestTaskClientHandlers)this.Handlers).ReportNoteValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee AssigneeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.RecordManagement.Client.StatusReportRequestTaskAssigneeValueInputEventArgs(this.Assignee, value, this, this.Info.Properties.Assignee);
    ((global::Sungero.RecordManagement.StatusReportRequestTaskClientHandlers)this.Handlers).AssigneeValueInput(args);
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
              this._Observers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IStatusReportRequestTaskObservers>("Observers", this);
              this._Observers.ValueChanged += (sender, e) => { this.ObserversChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Observers);
              this.SetObserversEventHandlers();
            }


    public StatusReportRequestTask()
    {

            this.InitAssigneeNavigationProperty();



            this._Report = new global::Sungero.Domain.Client.TextProperty("Report", this);
            this._Report.ValueChanged += (sender, e) => { this.ReportChangedHandler(); };
            this.AddProperty(this._Report);

            this._ActionItem = new global::Sungero.Domain.Client.TextProperty("ActionItem", this);
            this._ActionItem.ValueChanged += (sender, e) => { this.ActionItemChangedHandler(); };
            this.AddProperty(this._ActionItem);

            this._ReportNote = new global::Sungero.Domain.Client.TextProperty("ReportNote", this);
            this._ReportNote.ValueChanged += (sender, e) => { this.ReportNoteChangedHandler(); };
            this.AddProperty(this._ReportNote);






      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IStatusReportRequestTaskDocumentsGroupAttachments DocumentsGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.StatusReportRequestTaskDocumentsGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IStatusReportRequestTaskAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.StatusReportRequestTaskAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IStatusReportRequestTaskOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.StatusReportRequestTaskOtherGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).DocumentsGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).DocumentsGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).DocumentsGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IStatusReportRequestTaskSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// StatusReportRequestTaskPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class StatusReportRequestTaskPresenter<T> :
    global::Sungero.Workflow.Client.TaskPresenter<T>
    where T : class, global::Sungero.RecordManagement.IStatusReportRequestTask
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

                  this._AssigneeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("a8c68359-685b-44dc-92f2-c2d3b8a47a76"));
              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "Assignee");


                        this._ObserversObserverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IStatusReportRequestTaskObservers), "Observer");



    }

    public StatusReportRequestTaskPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// StatusReportRequestTaskCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class StatusReportRequestTaskCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.TaskCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IStatusReportRequestTask
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public StatusReportRequestTaskCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public StatusReportRequestTaskCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public StatusReportRequestTaskCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public StatusReportRequestTaskCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// StatusReportRequestTaskRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{ 
  public class StatusReportRequestTaskRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.TaskRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IStatusReportRequestTaskRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IStatusReportRequestTask
    {
       public new global::Sungero.RecordManagement.IStatusReportRequestTaskAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IStatusReportRequestTaskAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IStatusReportRequestTaskInfo Info
       {
          get { return (global::Sungero.RecordManagement.IStatusReportRequestTaskInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.StatusReportRequestTaskTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// StatusReportRequestTaskAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class StatusReportRequestTaskAccessRights : 
    Sungero.Workflow.Client.TaskAccessRights, Sungero.RecordManagement.IStatusReportRequestTaskAccessRights
  {

    public StatusReportRequestTaskAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class StatusReportRequestTaskTypeAccessRights : 
    Sungero.Workflow.Client.TaskTypeAccessRights, Sungero.RecordManagement.IStatusReportRequestTaskAccessRights
  {

    public StatusReportRequestTaskTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// StatusReportRequestTaskBlocksInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
}
