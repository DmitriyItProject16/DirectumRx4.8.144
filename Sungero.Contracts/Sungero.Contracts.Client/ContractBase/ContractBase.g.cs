
// ==================================================================
// ContractBase.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractBase :
    global::Sungero.Contracts.Client.ContractualDocument, global::Sungero.Contracts.IContractBase
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("306da7fa-dc27-437c-bb83-42c92436b7e2");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.ContractBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractBase, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Name; }
        set { this.Name = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.Contracts.IContractBaseState State
    {
      get
      {
        return (global::Sungero.Contracts.IContractBaseState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractBaseState(this);
    }

    public new global::Sungero.Contracts.IContractBaseInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.IContractBaseInfo)base.Info;
      }
    }

    public new global::Sungero.Contracts.IContractBaseAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Contracts.IContractBaseAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Contracts.Client.ContractBaseAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsAutomaticRenewal;

        public virtual global::System.Boolean? IsAutomaticRenewal
        {
          get { return this._IsAutomaticRenewal.Value; }
          set { this._IsAutomaticRenewal.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _DaysToFinishWorks;

        public virtual global::System.Int32? DaysToFinishWorks
        {
          get { return this._DaysToFinishWorks.Value; }
          set { this._DaysToFinishWorks.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsFrameworkContract;

        public virtual global::System.Boolean? IsFrameworkContract
        {
          get { return this._IsFrameworkContract.Value; }
          set { this._IsFrameworkContract.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _LifeCycleStateItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Contracts.Client.ContractualDocument.LifeCycleStateItems,
          typeof(global::Sungero.Contracts.ContractBase.LifeCycleState),
          typeof(global::Sungero.Contracts.Client.ContractBase),
          "LifeCycleState");

        public static new global::Sungero.Domain.Shared.EnumerationItems LifeCycleStateItems
        {
          get { return global::Sungero.Contracts.Client.ContractBase._LifeCycleStateItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems LifeCycleStateAllowedItems
        {
          get { return global::Sungero.Contracts.Client.ContractBase.LifeCycleStateItems; }
        }










    #endregion

    #region Methods


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Contracts.Client.ContractBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Contracts.Shared.ContractBaseFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.ContractBaseClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.ContractBaseSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void IsAutomaticRenewalChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsAutomaticRenewal, this.IsAutomaticRenewal, this);
     ((global::Sungero.Contracts.IContractBaseSharedHandlers)this.SharedHandlers).IsAutomaticRenewalChanged(args);
    }

    protected void DaysToFinishWorksChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DaysToFinishWorks, this.DaysToFinishWorks, this);
     ((global::Sungero.Contracts.IContractBaseSharedHandlers)this.SharedHandlers).DaysToFinishWorksChanged(args);
    }


    protected void IsFrameworkContractChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsFrameworkContract, this.IsFrameworkContract, this);
     ((global::Sungero.Contracts.IContractBaseSharedHandlers)this.SharedHandlers).IsFrameworkContractChanged(args);
    }






  protected global::System.Boolean? IsAutomaticRenewalValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsAutomaticRenewal, value, this, this.Info.Properties.IsAutomaticRenewal);
    ((global::Sungero.Contracts.ContractBaseClientHandlers)this.Handlers).IsAutomaticRenewalValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? DaysToFinishWorksValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.DaysToFinishWorks, value, this, this.Info.Properties.DaysToFinishWorks);
    ((global::Sungero.Contracts.ContractBaseClientHandlers)this.Handlers).DaysToFinishWorksValueInput(args);
    return args.NewValue;
  }


  protected global::System.Boolean? IsFrameworkContractValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsFrameworkContract, value, this, this.Info.Properties.IsFrameworkContract);
    ((global::Sungero.Contracts.ContractBaseClientHandlers)this.Handlers).IsFrameworkContractValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors




























            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IContractBaseVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }


            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IContractBaseTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }

            protected override void InitMilestonesCollectionProperty()
            {
              this._Milestones = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IContractBaseStages>("Milestones", this);
              this._Milestones.ValueChanged += (sender, e) => { this.MilestonesChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Milestones);
              this.SetMilestonesEventHandlers();
            }


    public ContractBase()
    {
            this._IsAutomaticRenewal = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsAutomaticRenewal", this);
            this._IsAutomaticRenewal.ValueChanged += (sender, e) => { this.IsAutomaticRenewalChangedHandler(); };
            this.AddProperty(this._IsAutomaticRenewal);

            this._DaysToFinishWorks = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("DaysToFinishWorks", this);
            this._DaysToFinishWorks.ValueChanged += (sender, e) => { this.DaysToFinishWorksChangedHandler(); };
            this.AddProperty(this._DaysToFinishWorks);

            this._IsFrameworkContract = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsFrameworkContract", this);
            this._IsFrameworkContract.ValueChanged += (sender, e) => { this.IsFrameworkContractChangedHandler(); };
            this.AddProperty(this._IsFrameworkContract);








    }

    #endregion

  }
}

// ==================================================================
// ContractBasePresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractBasePresenter<T> :
    global::Sungero.Contracts.Client.ContractualDocumentPresenter<T>
    where T : class, global::Sungero.Contracts.IContractBase
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _CreateSupAgreementCommand;

          public global::System.Windows.Input.ICommand CreateSupAgreementCommand
          {
            get
            {
              if (this._CreateSupAgreementCommand == null)
                  this._CreateSupAgreementCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateSupAgreement", this, this.CreateSupAgreement, this.CanCreateSupAgreement) { IsEmptyParameterAllowed = true };
              return this._CreateSupAgreementCommand;
            }
          }
          private global::System.Windows.Input.ICommand _CreateContractStatementCommand;

          public global::System.Windows.Input.ICommand CreateContractStatementCommand
          {
            get
            {
              if (this._CreateContractStatementCommand == null)
                  this._CreateContractStatementCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateContractStatement", this, this.CreateContractStatement, this.CanCreateContractStatement) { IsEmptyParameterAllowed = true };
              return this._CreateContractStatementCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanCreateSupAgreement(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Contracts.Client.ContractBaseActions)(entity as Sungero.Contracts.Client.ContractBase).ActionsHandlers).CanCreateSupAgreement(args);
              }

              private void CreateSupAgreement(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.CreateSupAgreement);
                ((Sungero.Contracts.Client.ContractBaseActions)(entity as Sungero.Contracts.Client.ContractBase).ActionsHandlers).CreateSupAgreement(args);
              }
              private bool CanCreateContractStatement(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Contracts.Client.ContractBaseActions)(entity as Sungero.Contracts.Client.ContractBase).ActionsHandlers).CanCreateContractStatement(args);
              }

              private void CreateContractStatement(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.CreateContractStatement);
                ((Sungero.Contracts.Client.ContractBaseActions)(entity as Sungero.Contracts.Client.ContractBase).ActionsHandlers).CreateContractStatement(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion



    #region Constructors

    private void Init()
    {
              this._DeliveryMethodCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IMailDeliveryMethod>(() => this.Entity.Id, typeof(T), "DeliveryMethod");

              this._CaseFileCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ICaseFile>(() => this.Entity, typeof(T), "CaseFile");

              this._DeliveredToCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "DeliveredTo");

              this._ResponsibleForReturnEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleForReturnEmployee");

              this._StorageCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IStorage>(() => this.Entity.Id, typeof(T), "Storage");

              this._TopicCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.ITopic>(() => this.Entity.Id, typeof(T), "Topic");

              this._SubtopicCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ITopic>(() => this.Entity, typeof(T), "Subtopic");

              this._VatRateCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.IVatRate>(() => this.Entity.Id, typeof(T), "VatRate");

              this._OurSigningReasonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ISignatureSetting>(() => this.Entity, typeof(T), "OurSigningReason");

              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IOfficialDocument>(() => this.Entity.Id, typeof(T), "LeadingDocument");

              this._CurrencyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.ICurrency>(() => this.Entity.Id, typeof(T), "Currency");

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._AssociatedApplicationCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(T), "AssociatedApplication");

              this._DocumentRegisterCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentRegister>(() => this.Entity, typeof(T), "DocumentRegister");

              this._DocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentKind>(() => this.Entity, typeof(T), "DocumentKind");

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");

              this._DocumentGroupCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(() => this.Entity, typeof(T), "DocumentGroup");

              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");

              this._CounterpartyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICounterparty>(() => this.Entity.Id, typeof(T), "Counterparty");

              this._CounterpartySignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "CounterpartySignatory");

              this._ContactCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "Contact");

              this._ResponsibleEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleEmployee");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractBaseVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractBaseVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractBaseVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractBaseVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractBaseTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractBaseTracking), "ReturnTask");


                        this._MilestonesPerformerCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractBaseStages), "Performer");

                        this._MilestonesTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ISimpleTask>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractBaseStages), "Task");



    }

    public ContractBasePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ContractBaseCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractBaseCollectionPresenter<T> : 
    global::Sungero.Contracts.Client.ContractualDocumentCollectionPresenter<T>
    where T: class, global::Sungero.Contracts.IContractBase
  {
    #region Actions

          private global::System.Windows.Input.ICommand _CreateSupAgreementCommand;  

          public global::System.Windows.Input.ICommand CreateSupAgreementCommand 
          { 
            get
            { 
              if (this._CreateSupAgreementCommand == null)
                this._CreateSupAgreementCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateSupAgreement", this, this.CreateSupAgreement, this.CanCreateSupAgreement) { IsEmptyParameterAllowed = true };
              return this._CreateSupAgreementCommand; 
            }
          }
          private global::System.Windows.Input.ICommand _CreateContractStatementCommand;  

          public global::System.Windows.Input.ICommand CreateContractStatementCommand 
          { 
            get
            { 
              if (this._CreateContractStatementCommand == null)
                this._CreateContractStatementCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateContractStatement", this, this.CreateContractStatement, this.CanCreateContractStatement) { IsEmptyParameterAllowed = true };
              return this._CreateContractStatementCommand; 
            }
          }



    #endregion

    #region Methods

        private bool CanCreateSupAgreement(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this);
          return ((Sungero.Contracts.Client.ContractBaseActions)(entity as Sungero.Contracts.Client.ContractBase).ActionsHandlers).CanCreateSupAgreement(args);
        }

        private void CreateSupAgreement(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this, entity.Info.Actions.CreateSupAgreement);
          ((Sungero.Contracts.Client.ContractBaseActions)(entity as Sungero.Contracts.Client.ContractBase).ActionsHandlers).CreateSupAgreement(args);
        }

        private bool CanCreateContractStatement(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this);
          return ((Sungero.Contracts.Client.ContractBaseActions)(entity as Sungero.Contracts.Client.ContractBase).ActionsHandlers).CanCreateContractStatement(args);
        }

        private void CreateContractStatement(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this, entity.Info.Actions.CreateContractStatement);
          ((Sungero.Contracts.Client.ContractBaseActions)(entity as Sungero.Contracts.Client.ContractBase).ActionsHandlers).CreateContractStatement(args);
        }



    #endregion

    public ContractBaseCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ContractBaseCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ContractBaseCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ContractBaseCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ContractBaseRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{ 
  public class ContractBaseRepositoryImplementer<T> : 
      global::Sungero.Contracts.Client.ContractualDocumentRepositoryImplementer<T>,
      global::Sungero.Contracts.IContractBaseRepositoryImplementer<T>
      where T : global::Sungero.Contracts.IContractBase
    {
       public new global::Sungero.Contracts.IContractBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Contracts.IContractBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Contracts.IContractBaseInfo Info
       {
          get { return (global::Sungero.Contracts.IContractBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Contracts.Client.ContractBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ContractBaseAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractBaseAccessRights : 
    Sungero.Contracts.Client.ContractualDocumentAccessRights, Sungero.Contracts.IContractBaseAccessRights
  {

    public ContractBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ContractBaseTypeAccessRights : 
    Sungero.Contracts.Client.ContractualDocumentTypeAccessRights, Sungero.Contracts.IContractBaseAccessRights
  {

    public ContractBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
