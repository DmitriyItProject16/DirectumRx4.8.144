
// ==================================================================
// OutgoingInvoice.g.cs
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
  public class OutgoingInvoice :
    global::Sungero.Docflow.Client.AccountingDocumentBase, global::Sungero.Contracts.IOutgoingInvoice
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("58ad01fb-6805-426b-9152-4de16d83b258");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.OutgoingInvoice.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IOutgoingInvoice, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Contracts.IOutgoingInvoiceState State
    {
      get
      {
        return (global::Sungero.Contracts.IOutgoingInvoiceState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.OutgoingInvoiceState(this);
    }

    public new global::Sungero.Contracts.IOutgoingInvoiceInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.IOutgoingInvoiceInfo)base.Info;
      }
    }

    public new global::Sungero.Contracts.IOutgoingInvoiceAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Contracts.IOutgoingInvoiceAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Contracts.Client.OutgoingInvoiceAccessRights(this);
    }


        private static global::Sungero.Domain.Shared.EnumerationItems _LifeCycleStateItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Docflow.Client.AccountingDocumentBase.LifeCycleStateItems,
          typeof(global::Sungero.Contracts.OutgoingInvoice.LifeCycleState),
          typeof(global::Sungero.Contracts.Client.OutgoingInvoice),
          "LifeCycleState");

        public static new global::Sungero.Domain.Shared.EnumerationItems LifeCycleStateItems
        {
          get { return global::Sungero.Contracts.Client.OutgoingInvoice._LifeCycleStateItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems LifeCycleStateAllowedItems
        {
          get { return global::Sungero.Contracts.Client.OutgoingInvoice.LifeCycleStateItems; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.OutgoingInvoiceActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.OutgoingInvoiceCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.OutgoingInvoiceAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.OutgoingInvoiceAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Contracts.Client.OutgoingInvoiceFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Contracts.Shared.OutgoingInvoiceFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.OutgoingInvoiceClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.OutgoingInvoiceSharedHandlers(this);
    }

    #endregion

    #region Framework events







    #endregion

    #region Constructors






























            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IOutgoingInvoiceVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }

            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IOutgoingInvoiceTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }


    public OutgoingInvoice()
    {








    }

    #endregion

  }
}

// ==================================================================
// OutgoingInvoicePresenter.g.cs
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
  public class OutgoingInvoicePresenter<T> :
    global::Sungero.Docflow.Client.AccountingDocumentBasePresenter<T>
    where T : class, global::Sungero.Contracts.IOutgoingInvoice
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



    #region Constructors

    private void Init()
    {
              this._StorageCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IStorage>(() => this.Entity.Id, typeof(T), "Storage");

              this._TopicCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.ITopic>(() => this.Entity.Id, typeof(T), "Topic");

              this._SubtopicCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ITopic>(() => this.Entity, typeof(T), "Subtopic");

              this._OurSigningReasonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ISignatureSetting>(() => this.Entity, typeof(T), "OurSigningReason");

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

              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");

              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._CounterpartyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICounterparty>(() => this.Entity.Id, typeof(T), "Counterparty");

              this._BusinessUnitBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "BusinessUnitBox");

              this._VatRateCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.IVatRate>(() => this.Entity.Id, typeof(T), "VatRate");

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IContractualDocumentBase>(() => this.Entity, typeof(T), "LeadingDocument");

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");

              this._DocumentGroupCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(() => this.Entity, typeof(T), "DocumentGroup");

              this._ResponsibleEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleEmployee");

              this._ContactCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "Contact");

              this._CounterpartySignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "CounterpartySignatory");

              this._CorrectedCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IAccountingDocumentBase>(() => this.Entity, typeof(T), "Corrected");

              this._CurrencyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.ICurrency>(() => this.Entity.Id, typeof(T), "Currency");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Contracts.IOutgoingInvoiceVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Contracts.IOutgoingInvoiceVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Contracts.IOutgoingInvoiceVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Contracts.IOutgoingInvoiceVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.Contracts.IOutgoingInvoiceTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.Contracts.IOutgoingInvoiceTracking), "ReturnTask");



    }

    public OutgoingInvoicePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// OutgoingInvoiceCollectionPresenter.g.cs
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
  public class OutgoingInvoiceCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionPresenter<T>
    where T: class, global::Sungero.Contracts.IOutgoingInvoice
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public OutgoingInvoiceCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public OutgoingInvoiceCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public OutgoingInvoiceCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public OutgoingInvoiceCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// OutgoingInvoiceRepositoryImplementer.g.cs
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
  public class OutgoingInvoiceRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.AccountingDocumentBaseRepositoryImplementer<T>,
      global::Sungero.Contracts.IOutgoingInvoiceRepositoryImplementer<T>
      where T : global::Sungero.Contracts.IOutgoingInvoice
    {
       public new global::Sungero.Contracts.IOutgoingInvoiceAccessRights AccessRights
       {
          get { return (global::Sungero.Contracts.IOutgoingInvoiceAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Contracts.IOutgoingInvoiceInfo Info
       {
          get { return (global::Sungero.Contracts.IOutgoingInvoiceInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Contracts.Client.OutgoingInvoiceTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// OutgoingInvoiceAccessRights.g.cs
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
  public class OutgoingInvoiceAccessRights : 
    Sungero.Docflow.Client.AccountingDocumentBaseAccessRights, Sungero.Contracts.IOutgoingInvoiceAccessRights
  {

    public OutgoingInvoiceAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class OutgoingInvoiceTypeAccessRights : 
    Sungero.Docflow.Client.AccountingDocumentBaseTypeAccessRights, Sungero.Contracts.IOutgoingInvoiceAccessRights
  {

    public OutgoingInvoiceTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
