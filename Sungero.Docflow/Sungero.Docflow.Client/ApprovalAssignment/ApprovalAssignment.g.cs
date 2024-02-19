
// ==================================================================
// ApprovalAssignment.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.Docflow.IApprovalAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("daf1900f-e66b-4368-b724-a073266145d7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IApprovalAssignmentState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalAssignmentState(this);
    }

    public new global::Sungero.Docflow.IApprovalAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IApprovalAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ApprovalAssignmentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _StageNumber;

        public virtual global::System.Int32? StageNumber
        {
          get { return this._StageNumber.Value; }
          set { this._StageNumber.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.Docflow.ApprovalAssignment.Result),
          typeof(global::Sungero.Docflow.Client.ApprovalAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalAssignment.ResultItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Docflow.IApprovalStage> _Stage;

              public virtual global::Sungero.Docflow.IApprovalStage Stage
              {
              get
              {
                return this._Stage.Value as global::Sungero.Docflow.IApprovalStage;
              }

              set
              {
                (this._Stage as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Addressee;

              public virtual global::Sungero.Company.IEmployee Addressee
              {
              get
              {
                return this._Addressee.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Addressee as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _ReworkPerformer;

              public virtual global::Sungero.Company.IEmployee ReworkPerformer
              {
              get
              {
                return this._ReworkPerformer.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._ReworkPerformer as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ApprovalAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void StageChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalAssignmentStageChangedEventArgs(this.State.Properties.Stage, this.Stage, this);
     ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).StageChanged(args);
    }

    protected void StageNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.StageNumber, this.StageNumber, this);
     ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).StageNumberChanged(args);
    }

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }

    protected void ReworkPerformerChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalAssignmentReworkPerformerChangedEventArgs(this.State.Properties.ReworkPerformer, this.ReworkPerformer, this);
     ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).ReworkPerformerChanged(args);
    }



  protected global::Sungero.Docflow.IApprovalStage StageValueInputHandler(global::Sungero.Docflow.IApprovalStage value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalAssignmentStageValueInputEventArgs(this.Stage, value, this, this.Info.Properties.Stage);
    ((global::Sungero.Docflow.ApprovalAssignmentClientHandlers)this.Handlers).StageValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? StageNumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.StageNumber, value, this, this.Info.Properties.StageNumber);
    ((global::Sungero.Docflow.ApprovalAssignmentClientHandlers)this.Handlers).StageNumberValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee AddresseeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalAssignmentAddresseeValueInputEventArgs(this.Addressee, value, this, this.Info.Properties.Addressee);
    ((global::Sungero.Docflow.ApprovalAssignmentClientHandlers)this.Handlers).AddresseeValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee ReworkPerformerValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalAssignmentReworkPerformerValueInputEventArgs(this.ReworkPerformer, value, this, this.Info.Properties.ReworkPerformer);
    ((global::Sungero.Docflow.ApprovalAssignmentClientHandlers)this.Handlers).ReworkPerformerValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors








              protected virtual void InitStageNavigationProperty()
              {
                this._Stage = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalStage>("Stage", this);
                this._Stage.ValueChanged += (sender, e) => { this.StageChangedHandler(); };
                this.AddProperty(this._Stage as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitAddresseeNavigationProperty()
              {
                this._Addressee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Addressee", this);
                this._Addressee.ValueChanged += (sender, e) => { this.AddresseeChangedHandler(); };
                this.AddProperty(this._Addressee as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitReworkPerformerNavigationProperty()
              {
                this._ReworkPerformer = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("ReworkPerformer", this);
                this._ReworkPerformer.ValueChanged += (sender, e) => { this.ReworkPerformerChangedHandler(); };
                this.AddProperty(this._ReworkPerformer as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalAssignment()
    {
            this._StageNumber = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("StageNumber", this);
            this._StageNumber.ValueChanged += (sender, e) => { this.StageNumberChangedHandler(); };
            this.AddProperty(this._StageNumber);

            this.InitStageNavigationProperty();

            this.InitAddresseeNavigationProperty();

            this.InitReworkPerformerNavigationProperty();








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IApprovalAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalAssignmentDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalAssignmentDocumentGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ApprovalAssignmentPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.Docflow.IApprovalAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _ApprovedCommand;

          public global::System.Windows.Input.ICommand ApprovedCommand
          {
            get
            {
              if (this._ApprovedCommand == null)
                  this._ApprovedCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Approved", this, this.Approved, this.CanApproved) { IsEmptyParameterAllowed = true };
              return this._ApprovedCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ForRevisionCommand;

          public global::System.Windows.Input.ICommand ForRevisionCommand
          {
            get
            {
              if (this._ForRevisionCommand == null)
                  this._ForRevisionCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("ForRevision", this, this.ForRevision, this.CanForRevision) { IsEmptyParameterAllowed = true };
              return this._ForRevisionCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ApprovalFormCommand;

          public global::System.Windows.Input.ICommand ApprovalFormCommand
          {
            get
            {
              if (this._ApprovalFormCommand == null)
                  this._ApprovalFormCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ApprovalForm", this, this.ApprovalForm, this.CanApprovalForm) { IsEmptyParameterAllowed = true };
              return this._ApprovalFormCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ExtendDeadlineCommand;

          public global::System.Windows.Input.ICommand ExtendDeadlineCommand
          {
            get
            {
              if (this._ExtendDeadlineCommand == null)
                  this._ExtendDeadlineCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ExtendDeadline", this, this.ExtendDeadline, this.CanExtendDeadline) { IsEmptyParameterAllowed = true };
              return this._ExtendDeadlineCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ForwardCommand;

          public global::System.Windows.Input.ICommand ForwardCommand
          {
            get
            {
              if (this._ForwardCommand == null)
                  this._ForwardCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Forward", this, this.Forward, this.CanForward) { IsEmptyParameterAllowed = true };
              return this._ForwardCommand;
            }
          }
          private global::System.Windows.Input.ICommand _AddApproverCommand;

          public global::System.Windows.Input.ICommand AddApproverCommand
          {
            get
            {
              if (this._AddApproverCommand == null)
                  this._AddApproverCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("AddApprover", this, this.AddApprover, this.CanAddApprover) { IsEmptyParameterAllowed = true };
              return this._AddApproverCommand;
            }
          }
          private global::System.Windows.Input.ICommand _WithSuggestionsCommand;

          public global::System.Windows.Input.ICommand WithSuggestionsCommand
          {
            get
            {
              if (this._WithSuggestionsCommand == null)
                  this._WithSuggestionsCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("WithSuggestions", this, this.WithSuggestions, this.CanWithSuggestions) { IsEmptyParameterAllowed = true };
              return this._WithSuggestionsCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanApproved(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).CanApproved(args);
              }

              private void Approved(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Approved);
                ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).Approved(args);
              }
              private bool CanForRevision(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).CanForRevision(args);
              }

              private void ForRevision(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.ForRevision);
                ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).ForRevision(args);
              }
              private bool CanApprovalForm(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).CanApprovalForm(args);
              }

              private void ApprovalForm(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ApprovalForm);
                ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).ApprovalForm(args);
              }
              private bool CanExtendDeadline(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).CanExtendDeadline(args);
              }

              private void ExtendDeadline(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ExtendDeadline);
                ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).ExtendDeadline(args);
              }
              private bool CanForward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).CanForward(args);
              }

              private void Forward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Forward);
                ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).Forward(args);
              }
              private bool CanAddApprover(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).CanAddApprover(args);
              }

              private void AddApprover(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.AddApprover);
                ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).AddApprover(args);
              }
              private bool CanWithSuggestions(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).CanWithSuggestions(args);
              }

              private void WithSuggestions(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.WithSuggestions);
                ((Sungero.Docflow.Client.ApprovalAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalAssignment).ActionsHandlers).WithSuggestions(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _StageCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter StageCollectionPresenter
              {
          get { return this._StageCollectionPresenter; }
        }
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _AddresseeCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter AddresseeCollectionPresenter
              {
          get { return this._AddresseeCollectionPresenter; }
        }
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ReworkPerformerCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter ReworkPerformerCollectionPresenter
              {
          get { return this._ReworkPerformerCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._PerformerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Performer");

              this._TaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "Task");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");

              this._CompletedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "CompletedBy");

                  this._StageCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Docflow.IApprovalStage>(global::System.Guid.Parse("9c0cb3e1-d2f0-4fe7-bc37-3b72808ef6a6"));
              this._StageCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IApprovalStage>(() => this.Entity.Id, typeof(T), "Stage");

                  this._AddresseeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("033c18c2-7ad7-4a0c-9e09-f129f22ce0fb"));
              this._AddresseeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Addressee");

                  this._ReworkPerformerCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("27a6580d-f22b-40ca-bc64-ee76b2af742b"));
              this._ReworkPerformerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "ReworkPerformer");


    }

    public ApprovalAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalAssignmentCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IApprovalAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalAssignmentRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class ApprovalAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalAssignment
    {
       public new global::Sungero.Docflow.IApprovalAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ApprovalAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalAssignmentAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.Docflow.IApprovalAssignmentAccessRights
  {

    public ApprovalAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.Docflow.IApprovalAssignmentAccessRights
  {

    public ApprovalAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalAssignmentBlocksInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
}
