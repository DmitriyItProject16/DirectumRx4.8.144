
// ==================================================================
// ApprovalFunctionQueueItem.g.cs
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
  public class ApprovalFunctionQueueItem :
    global::Sungero.ExchangeCore.Client.QueueItemBase, global::Sungero.Docflow.IApprovalFunctionQueueItem
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e511f4f9-72a3-484c-a5f2-d5fcdd113dde");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalFunctionQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalFunctionQueueItem, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IApprovalFunctionQueueItemState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalFunctionQueueItemState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalFunctionQueueItemState(this);
    }

    public new global::Sungero.Docflow.IApprovalFunctionQueueItemInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalFunctionQueueItemInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IApprovalFunctionQueueItemAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalFunctionQueueItemAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ApprovalFunctionQueueItemAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _TaskId;

        public virtual global::System.Int64? TaskId
        {
          get { return this._TaskId.Value; }
          set { this._TaskId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _TaskStartId;

        public virtual global::System.Int32? TaskStartId
        {
          get { return this._TaskStartId.Value; }
          set { this._TaskStartId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsNoticeSended;

        public virtual global::System.Boolean? IsNoticeSended
        {
          get { return this._IsNoticeSended.Value; }
          set { this._IsNoticeSended.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ProcessingStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.ExchangeCore.Client.QueueItemBase.ProcessingStatusItems,
          typeof(global::Sungero.Docflow.ApprovalFunctionQueueItem.ProcessingStatus),
          typeof(global::Sungero.Docflow.Client.ApprovalFunctionQueueItem),
          "ProcessingStatus");

        public static new global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalFunctionQueueItem._ProcessingStatusItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalFunctionQueueItem.ProcessingStatusItems; }
        }








      protected global::Sungero.Domain.Client.TextProperty _ErrorMessage;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String ErrorMessage
      {
        get { return this._ErrorMessage.Value; }
        set { this._ErrorMessage.Value = value; }
      }



    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalFunctionQueueItemActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalFunctionQueueItemCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalFunctionQueueItemAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalFunctionQueueItemAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ApprovalFunctionQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalFunctionQueueItemFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalFunctionQueueItemClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalFunctionQueueItemSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void TaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.TaskId, this.TaskId, this);
     ((global::Sungero.Docflow.IApprovalFunctionQueueItemSharedHandlers)this.SharedHandlers).TaskIdChanged(args);
    }

    protected void TaskStartIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.TaskStartId, this.TaskStartId, this);
     ((global::Sungero.Docflow.IApprovalFunctionQueueItemSharedHandlers)this.SharedHandlers).TaskStartIdChanged(args);
    }

    protected void ErrorMessageChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ErrorMessage, this.ErrorMessage, this);
     ((global::Sungero.Docflow.IApprovalFunctionQueueItemSharedHandlers)this.SharedHandlers).ErrorMessageChanged(args);
    }

    protected void IsNoticeSendedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsNoticeSended, this.IsNoticeSended, this);
     ((global::Sungero.Docflow.IApprovalFunctionQueueItemSharedHandlers)this.SharedHandlers).IsNoticeSendedChanged(args);
    }



  protected global::System.Int64? TaskIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.TaskId, value, this, this.Info.Properties.TaskId);
    ((global::Sungero.Docflow.ApprovalFunctionQueueItemClientHandlers)this.Handlers).TaskIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? TaskStartIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.TaskStartId, value, this, this.Info.Properties.TaskStartId);
    ((global::Sungero.Docflow.ApprovalFunctionQueueItemClientHandlers)this.Handlers).TaskStartIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ErrorMessageValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.ErrorMessage, value, this, this.Info.Properties.ErrorMessage);
    ((global::Sungero.Docflow.ApprovalFunctionQueueItemClientHandlers)this.Handlers).ErrorMessageValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsNoticeSendedValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsNoticeSended, value, this, this.Info.Properties.IsNoticeSended);
    ((global::Sungero.Docflow.ApprovalFunctionQueueItemClientHandlers)this.Handlers).IsNoticeSendedValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors





    public ApprovalFunctionQueueItem()
    {
            this._TaskId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("TaskId", this);
            this._TaskId.ValueChanged += (sender, e) => { this.TaskIdChangedHandler(); };
            this.AddProperty(this._TaskId);

            this._TaskStartId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("TaskStartId", this);
            this._TaskStartId.ValueChanged += (sender, e) => { this.TaskStartIdChangedHandler(); };
            this.AddProperty(this._TaskStartId);

            this._IsNoticeSended = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsNoticeSended", this);
            this._IsNoticeSended.ValueChanged += (sender, e) => { this.IsNoticeSendedChangedHandler(); };
            this.AddProperty(this._IsNoticeSended);



            this._ErrorMessage = new global::Sungero.Domain.Client.TextProperty("ErrorMessage", this);
            this._ErrorMessage.ValueChanged += (sender, e) => { this.ErrorMessageChangedHandler(); };
            this.AddProperty(this._ErrorMessage);






    }

    #endregion

  }
}

// ==================================================================
// ApprovalFunctionQueueItemPresenter.g.cs
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
  public class ApprovalFunctionQueueItemPresenter<T> :
    global::Sungero.ExchangeCore.Client.QueueItemBasePresenter<T>
    where T : class, global::Sungero.Docflow.IApprovalFunctionQueueItem
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
              this._BoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBoxBase>(() => this.Entity.Id, typeof(T), "Box");

              this._RootBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "RootBox");


    }

    public ApprovalFunctionQueueItemPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalFunctionQueueItemCollectionPresenter.g.cs
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
  public class ApprovalFunctionQueueItemCollectionPresenter<T> : 
    global::Sungero.ExchangeCore.Client.QueueItemBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IApprovalFunctionQueueItem
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalFunctionQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalFunctionQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalFunctionQueueItemCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalFunctionQueueItemCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalFunctionQueueItemRepositoryImplementer.g.cs
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
  public class ApprovalFunctionQueueItemRepositoryImplementer<T> : 
      global::Sungero.ExchangeCore.Client.QueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalFunctionQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalFunctionQueueItem
    {
       public new global::Sungero.Docflow.IApprovalFunctionQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalFunctionQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalFunctionQueueItemInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalFunctionQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ApprovalFunctionQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalFunctionQueueItemAccessRights.g.cs
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
  public class ApprovalFunctionQueueItemAccessRights : 
    Sungero.ExchangeCore.Client.QueueItemBaseAccessRights, Sungero.Docflow.IApprovalFunctionQueueItemAccessRights
  {

    public ApprovalFunctionQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalFunctionQueueItemTypeAccessRights : 
    Sungero.ExchangeCore.Client.QueueItemBaseTypeAccessRights, Sungero.Docflow.IApprovalFunctionQueueItemAccessRights
  {

    public ApprovalFunctionQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
