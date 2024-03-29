
// ==================================================================
// IncomingLetter.g.cs
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
  public class IncomingLetter :
    global::Sungero.Docflow.Client.IncomingDocumentBase, global::Sungero.RecordManagement.IIncomingLetter
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8dd00491-8fd0-4a7a-9cf3-8b6dc2e6455d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.IncomingLetter.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IIncomingLetter, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IIncomingLetterState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IIncomingLetterState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.IncomingLetterState(this);
    }

    public new global::Sungero.RecordManagement.IIncomingLetterInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IIncomingLetterInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IIncomingLetterAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IIncomingLetterAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.IncomingLetterAccessRights(this);
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.IContact> _SignedBy;

              public virtual global::Sungero.Parties.IContact SignedBy
              {
              get
              {
                return this._SignedBy.Value as global::Sungero.Parties.IContact;
              }

              set
              {
                (this._SignedBy as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.IContact> _Contact;

              public virtual global::Sungero.Parties.IContact Contact
              {
              get
              {
                return this._Contact.Value as global::Sungero.Parties.IContact;
              }

              set
              {
                (this._Contact as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.IncomingLetterActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.IncomingLetterCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.IncomingLetterAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.IncomingLetterAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.IncomingLetterFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.IncomingLetterFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.IncomingLetterClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.IncomingLetterSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void SignedByChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.IncomingLetterSignedByChangedEventArgs(this.State.Properties.SignedBy, this.SignedBy, this);
     ((global::Sungero.RecordManagement.IIncomingLetterSharedHandlers)this.SharedHandlers).SignedByChanged(args);
    }

    protected void ContactChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.IncomingLetterContactChangedEventArgs(this.State.Properties.Contact, this.Contact, this);
     ((global::Sungero.RecordManagement.IIncomingLetterSharedHandlers)this.SharedHandlers).ContactChanged(args);
    }







  protected global::Sungero.Parties.IContact SignedByValueInputHandler(global::Sungero.Parties.IContact value)
  {
    var args = new global::Sungero.RecordManagement.Client.IncomingLetterSignedByValueInputEventArgs(this.SignedBy, value, this, this.Info.Properties.SignedBy);
    ((global::Sungero.RecordManagement.IncomingLetterClientHandlers)this.Handlers).SignedByValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Parties.IContact ContactValueInputHandler(global::Sungero.Parties.IContact value)
  {
    var args = new global::Sungero.RecordManagement.Client.IncomingLetterContactValueInputEventArgs(this.Contact, value, this, this.Info.Properties.Contact);
    ((global::Sungero.RecordManagement.IncomingLetterClientHandlers)this.Handlers).ContactValueInput(args);
    return args.NewValue;
  }




    #endregion

    #region Constructors


























              protected virtual void InitSignedByNavigationProperty()
              {
                this._SignedBy = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.IContact>("SignedBy", this);
                this._SignedBy.ValueChanged += (sender, e) => { this.SignedByChangedHandler(); };
                this.AddProperty(this._SignedBy as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitContactNavigationProperty()
              {
                this._Contact = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.IContact>("Contact", this);
                this._Contact.ValueChanged += (sender, e) => { this.ContactChangedHandler(); };
                this.AddProperty(this._Contact as global::Sungero.Domain.Client.IProperty);
              }



            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IIncomingLetterVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }


            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IIncomingLetterTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }

            protected override void InitAddresseesCollectionProperty()
            {
              this._Addressees = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IIncomingLetterAddressees>("Addressees", this);
              this._Addressees.ValueChanged += (sender, e) => { this.AddresseesChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Addressees);
              this.SetAddresseesEventHandlers();
            }


    public IncomingLetter()
    {

            this.InitSignedByNavigationProperty();

            this.InitContactNavigationProperty();








    }

    #endregion

  }
}

// ==================================================================
// IncomingLetterPresenter.g.cs
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
  public class IncomingLetterPresenter<T> :
    global::Sungero.Docflow.Client.IncomingDocumentBasePresenter<T>
    where T : class, global::Sungero.RecordManagement.IIncomingLetter
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _ShowDuplicatesCommand;

          public global::System.Windows.Input.ICommand ShowDuplicatesCommand
          {
            get
            {
              if (this._ShowDuplicatesCommand == null)
                  this._ShowDuplicatesCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ShowDuplicates", this, this.ShowDuplicates, this.CanShowDuplicates) { IsEmptyParameterAllowed = true };
              return this._ShowDuplicatesCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.RecordManagement.Client.IncomingLetterActions)(entity as Sungero.RecordManagement.Client.IncomingLetter).ActionsHandlers).CanShowDuplicates(args);
              }

              private void ShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowDuplicates);
                ((Sungero.RecordManagement.Client.IncomingLetterActions)(entity as Sungero.RecordManagement.Client.IncomingLetter).ActionsHandlers).ShowDuplicates(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _SignedByCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter SignedByCollectionPresenter
              {
          get { return this._SignedByCollectionPresenter; }
        }
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ContactCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter ContactCollectionPresenter
              {
          get { return this._ContactCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
              this._DeliveredToCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "DeliveredTo");

              this._ResponsibleForReturnEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleForReturnEmployee");

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

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._AssociatedApplicationCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(T), "AssociatedApplication");

              this._DocumentRegisterCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentRegister>(() => this.Entity, typeof(T), "DocumentRegister");

              this._DeliveryMethodCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IMailDeliveryMethod>(() => this.Entity.Id, typeof(T), "DeliveryMethod");

              this._CaseFileCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ICaseFile>(() => this.Entity, typeof(T), "CaseFile");

              this._DocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentKind>(() => this.Entity, typeof(T), "DocumentKind");

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");

              this._DocumentGroupCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(() => this.Entity, typeof(T), "DocumentGroup");

              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");

              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");

              this._CorrespondentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICounterparty>(() => this.Entity.Id, typeof(T), "Correspondent");

              this._InResponseToCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IOutgoingDocumentBase>(() => this.Entity, typeof(T), "InResponseTo");

              this._AddresseeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Addressee");

                  this._SignedByCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Parties.IContact>(global::System.Guid.Parse("fb7a3a0a-c8a2-4a88-bf5a-d0fb24063114"));
              this._SignedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "SignedBy");

                  this._ContactCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Parties.IContact>(global::System.Guid.Parse("7117b3fd-2c53-4336-bae4-dd580de20646"));
              this._ContactCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "Contact");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IIncomingLetterVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IIncomingLetterVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IIncomingLetterVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IIncomingLetterVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IIncomingLetterTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IIncomingLetterTracking), "ReturnTask");


                        this._AddresseesAddresseeCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IIncomingLetterAddressees), "Addressee");

                        this._AddresseesDepartmentCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForChildNavigationProperty<global::Sungero.Company.IDepartment>(
                          () => this.ChildEntityCollectionPresenters.GetPresenter<global::Sungero.RecordManagement.IIncomingLetterAddressees>().FocusedEntity,
                          typeof(Sungero.RecordManagement.IIncomingLetterAddressees),
                          () => this.Entity,
                          "Department");



    }

    public IncomingLetterPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// IncomingLetterCollectionPresenter.g.cs
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
  public class IncomingLetterCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.IncomingDocumentBaseCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IIncomingLetter
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public IncomingLetterCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public IncomingLetterCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public IncomingLetterCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public IncomingLetterCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// IncomingLetterRepositoryImplementer.g.cs
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
  public class IncomingLetterRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.IncomingDocumentBaseRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IIncomingLetterRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IIncomingLetter
    {
       public new global::Sungero.RecordManagement.IIncomingLetterAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IIncomingLetterAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IIncomingLetterInfo Info
       {
          get { return (global::Sungero.RecordManagement.IIncomingLetterInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.IncomingLetterTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// IncomingLetterAccessRights.g.cs
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
  public class IncomingLetterAccessRights : 
    Sungero.Docflow.Client.IncomingDocumentBaseAccessRights, Sungero.RecordManagement.IIncomingLetterAccessRights
  {

    public IncomingLetterAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class IncomingLetterTypeAccessRights : 
    Sungero.Docflow.Client.IncomingDocumentBaseTypeAccessRights, Sungero.RecordManagement.IIncomingLetterAccessRights
  {

    public IncomingLetterTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
