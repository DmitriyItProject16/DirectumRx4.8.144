
// ==================================================================
// ExchangeDocument.g.cs
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
  public class ExchangeDocument :
    global::Sungero.Docflow.Client.OfficialDocument, global::Sungero.Docflow.IExchangeDocument
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("cf8357c3-8266-490d-b75e-0bd3e46b1ae8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ExchangeDocument.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IExchangeDocument, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IExchangeDocumentState State
    {
      get
      {
        return (global::Sungero.Docflow.IExchangeDocumentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ExchangeDocumentState(this);
    }

    public new global::Sungero.Docflow.IExchangeDocumentInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IExchangeDocumentInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IExchangeDocumentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IExchangeDocumentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _CounterpartySigningReason;

        public virtual global::System.String CounterpartySigningReason
        {
          get { return this._CounterpartySigningReason.Value; }
          set { this._CounterpartySigningReason.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.ICounterparty> _Counterparty;

              public virtual global::Sungero.Parties.ICounterparty Counterparty
              {
              get
              {
                return this._Counterparty.Value as global::Sungero.Parties.ICounterparty;
              }

              set
              {
                (this._Counterparty as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox> _BusinessUnitBox;

              public virtual global::Sungero.ExchangeCore.IBusinessUnitBox BusinessUnitBox
              {
              get
              {
                return this._BusinessUnitBox.Value as global::Sungero.ExchangeCore.IBusinessUnitBox;
              }

              set
              {
                (this._BusinessUnitBox as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.IContact> _CounterpartySignatory;

              public virtual global::Sungero.Parties.IContact CounterpartySignatory
              {
              get
              {
                return this._CounterpartySignatory.Value as global::Sungero.Parties.IContact;
              }

              set
              {
                (this._CounterpartySignatory as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentAnyChildEntityCollectionActions();
    }

    protected override object CreateVersionsActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentVersionsActions();
    }

    protected override object CreateVersionsCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentVersionsCollectionActions();
    }
    protected override object CreateTrackingActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentTrackingActions();
    }

    protected override object CreateTrackingCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentTrackingCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ExchangeDocumentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ExchangeDocumentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ExchangeDocumentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ExchangeDocumentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void CounterpartyChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ExchangeDocumentCounterpartyChangedEventArgs(this.State.Properties.Counterparty, this.Counterparty, this);
     ((global::Sungero.Docflow.IExchangeDocumentSharedHandlers)this.SharedHandlers).CounterpartyChanged(args);
    }

    protected void BusinessUnitBoxChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ExchangeDocumentBusinessUnitBoxChangedEventArgs(this.State.Properties.BusinessUnitBox, this.BusinessUnitBox, this);
     ((global::Sungero.Docflow.IExchangeDocumentSharedHandlers)this.SharedHandlers).BusinessUnitBoxChanged(args);
    }

    protected void CounterpartySignatoryChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ExchangeDocumentCounterpartySignatoryChangedEventArgs(this.State.Properties.CounterpartySignatory, this.CounterpartySignatory, this);
     ((global::Sungero.Docflow.IExchangeDocumentSharedHandlers)this.SharedHandlers).CounterpartySignatoryChanged(args);
    }

    protected void CounterpartySigningReasonChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CounterpartySigningReason, this.CounterpartySigningReason, this);
     ((global::Sungero.Docflow.IExchangeDocumentSharedHandlers)this.SharedHandlers).CounterpartySigningReasonChanged(args);
    }





  protected global::Sungero.Parties.ICounterparty CounterpartyValueInputHandler(global::Sungero.Parties.ICounterparty value)
  {
    var args = new global::Sungero.Docflow.Client.ExchangeDocumentCounterpartyValueInputEventArgs(this.Counterparty, value, this, this.Info.Properties.Counterparty);
    ((global::Sungero.Docflow.ExchangeDocumentClientHandlers)this.Handlers).CounterpartyValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.ExchangeCore.IBusinessUnitBox BusinessUnitBoxValueInputHandler(global::Sungero.ExchangeCore.IBusinessUnitBox value)
  {
    var args = new global::Sungero.Docflow.Client.ExchangeDocumentBusinessUnitBoxValueInputEventArgs(this.BusinessUnitBox, value, this, this.Info.Properties.BusinessUnitBox);
    ((global::Sungero.Docflow.ExchangeDocumentClientHandlers)this.Handlers).BusinessUnitBoxValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Parties.IContact CounterpartySignatoryValueInputHandler(global::Sungero.Parties.IContact value)
  {
    var args = new global::Sungero.Docflow.Client.ExchangeDocumentCounterpartySignatoryValueInputEventArgs(this.CounterpartySignatory, value, this, this.Info.Properties.CounterpartySignatory);
    ((global::Sungero.Docflow.ExchangeDocumentClientHandlers)this.Handlers).CounterpartySignatoryValueInput(args);
    return args.NewValue;
  }

  protected global::System.String CounterpartySigningReasonValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.CounterpartySigningReason, value, this, this.Info.Properties.CounterpartySigningReason);
    ((global::Sungero.Docflow.ExchangeDocumentClientHandlers)this.Handlers).CounterpartySigningReasonValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors























              protected virtual void InitCounterpartyNavigationProperty()
              {
                this._Counterparty = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.ICounterparty>("Counterparty", this);
                this._Counterparty.ValueChanged += (sender, e) => { this.CounterpartyChangedHandler(); };
                this.AddProperty(this._Counterparty as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitBusinessUnitBoxNavigationProperty()
              {
                this._BusinessUnitBox = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox>("BusinessUnitBox", this);
                this._BusinessUnitBox.ValueChanged += (sender, e) => { this.BusinessUnitBoxChangedHandler(); };
                this.AddProperty(this._BusinessUnitBox as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitCounterpartySignatoryNavigationProperty()
              {
                this._CounterpartySignatory = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.IContact>("CounterpartySignatory", this);
                this._CounterpartySignatory.ValueChanged += (sender, e) => { this.CounterpartySignatoryChangedHandler(); };
                this.AddProperty(this._CounterpartySignatory as global::Sungero.Domain.Client.IProperty);
              }



            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IExchangeDocumentVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }

            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IExchangeDocumentTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }


    public ExchangeDocument()
    {
            this._CounterpartySigningReason = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("CounterpartySigningReason", this);
            this._CounterpartySigningReason.ValueChanged += (sender, e) => { this.CounterpartySigningReasonChangedHandler(); };
            this.AddProperty(this._CounterpartySigningReason);

            this.InitCounterpartyNavigationProperty();

            this.InitBusinessUnitBoxNavigationProperty();

            this.InitCounterpartySignatoryNavigationProperty();








    }

    #endregion

  }
}

// ==================================================================
// ExchangeDocumentPresenter.g.cs
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
  public class ExchangeDocumentPresenter<T> :
    global::Sungero.Docflow.Client.OfficialDocumentPresenter<T>
    where T : class, global::Sungero.Docflow.IExchangeDocument
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

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _CounterpartyCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter CounterpartyCollectionPresenter
              {
          get { return this._CounterpartyCollectionPresenter; }
        }
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _BusinessUnitBoxCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter BusinessUnitBoxCollectionPresenter
              {
          get { return this._BusinessUnitBoxCollectionPresenter; }
        }
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _CounterpartySignatoryCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter CounterpartySignatoryCollectionPresenter
              {
          get { return this._CounterpartySignatoryCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IOfficialDocument>(() => this.Entity.Id, typeof(T), "LeadingDocument");

              this._StorageCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IStorage>(() => this.Entity.Id, typeof(T), "Storage");

              this._OurSigningReasonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ISignatureSetting>(() => this.Entity, typeof(T), "OurSigningReason");

              this._TopicCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.ITopic>(() => this.Entity.Id, typeof(T), "Topic");

              this._SubtopicCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ITopic>(() => this.Entity, typeof(T), "Subtopic");

              this._DocumentGroupCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(() => this.Entity, typeof(T), "DocumentGroup");

              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._AssociatedApplicationCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(T), "AssociatedApplication");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._DocumentRegisterCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentRegister>(() => this.Entity, typeof(T), "DocumentRegister");

              this._DeliveryMethodCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IMailDeliveryMethod>(() => this.Entity.Id, typeof(T), "DeliveryMethod");

              this._CaseFileCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ICaseFile>(() => this.Entity, typeof(T), "CaseFile");

              this._DeliveredToCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "DeliveredTo");

              this._ResponsibleForReturnEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleForReturnEmployee");

              this._DocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentKind>(() => this.Entity, typeof(T), "DocumentKind");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");

              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

                  this._CounterpartyCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Parties.ICounterparty>(global::System.Guid.Parse("8ea1876b-d705-4aa8-bf8e-d510b4a89c5f"));
              this._CounterpartyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICounterparty>(() => this.Entity.Id, typeof(T), "Counterparty");

                  this._BusinessUnitBoxCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox>(global::System.Guid.Parse("40e129f1-0de3-4a4c-9127-397621c19e13"));
              this._BusinessUnitBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "BusinessUnitBox");

                  this._CounterpartySignatoryCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Parties.IContact>(global::System.Guid.Parse("d252be8b-ad6e-4cb0-8ae0-c0cd187f4bad"));
              this._CounterpartySignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.IContact>(() => this.Entity.Id, typeof(T), "CounterpartySignatory");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Docflow.IExchangeDocumentVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Docflow.IExchangeDocumentVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Docflow.IExchangeDocumentVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Docflow.IExchangeDocumentVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.Docflow.IExchangeDocumentTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.Docflow.IExchangeDocumentTracking), "ReturnTask");



    }

    public ExchangeDocumentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ExchangeDocumentCollectionPresenter.g.cs
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
  public class ExchangeDocumentCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.OfficialDocumentCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IExchangeDocument
  {
    #region Actions



    #endregion

    #region Methods

        protected override bool CanShowDocumentReturn()
        {
          var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, null, this);
          return base.CanShowDocumentReturn() && Sungero.Docflow.Client.ExchangeDocumentStaticActions.CanShowDocumentReturn(args);
        }

        protected override void ShowDocumentReturn()
        {
          base.ShowDocumentReturn();
          var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, null, this);
          Sungero.Docflow.Client.ExchangeDocumentStaticActions.ShowDocumentReturn(args);
        }



    #endregion

    public ExchangeDocumentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ExchangeDocumentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ExchangeDocumentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ExchangeDocumentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ExchangeDocumentRepositoryImplementer.g.cs
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
  public class ExchangeDocumentRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.OfficialDocumentRepositoryImplementer<T>,
      global::Sungero.Docflow.IExchangeDocumentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IExchangeDocument
    {
       public new global::Sungero.Docflow.IExchangeDocumentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IExchangeDocumentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IExchangeDocumentInfo Info
       {
          get { return (global::Sungero.Docflow.IExchangeDocumentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ExchangeDocumentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ExchangeDocumentAccessRights.g.cs
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
  public class ExchangeDocumentAccessRights : 
    Sungero.Docflow.Client.OfficialDocumentAccessRights, Sungero.Docflow.IExchangeDocumentAccessRights
  {

    public ExchangeDocumentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ExchangeDocumentTypeAccessRights : 
    Sungero.Docflow.Client.OfficialDocumentTypeAccessRights, Sungero.Docflow.IExchangeDocumentAccessRights
  {

    public ExchangeDocumentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
