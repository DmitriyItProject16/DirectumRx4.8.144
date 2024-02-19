
// ==================================================================
// DocumentFullTextSearchQueueItem.g.cs
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
  public class DocumentFullTextSearchQueueItem :
    global::Sungero.ExchangeCore.Client.QueueItemBase, global::Sungero.Docflow.IDocumentFullTextSearchQueueItem
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("54351e62-2985-4abf-b17f-ac0289240557");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentFullTextSearchQueueItem, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IDocumentFullTextSearchQueueItemState State
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentFullTextSearchQueueItemState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentFullTextSearchQueueItemState(this);
    }

    public new global::Sungero.Docflow.IDocumentFullTextSearchQueueItemInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentFullTextSearchQueueItemInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IDocumentFullTextSearchQueueItemAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentFullTextSearchQueueItemAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItemAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _DocumentId;

        public virtual global::System.Int64? DocumentId
        {
          get { return this._DocumentId.Value; }
          set { this._DocumentId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _Priority;

        public virtual global::System.Int32? Priority
        {
          get { return this._Priority.Value; }
          set { this._Priority.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _ExtractTextTaskId;

        public virtual global::System.Int32? ExtractTextTaskId
        {
          get { return this._ExtractTextTaskId.Value; }
          set { this._ExtractTextTaskId.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ProcessingStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.ExchangeCore.Client.QueueItemBase.ProcessingStatusItems,
          typeof(global::Sungero.Docflow.DocumentFullTextSearchQueueItem.ProcessingStatus),
          typeof(global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItem),
          "ProcessingStatus");

        public static new global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusItems
        {
          get { return global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItem._ProcessingStatusItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusAllowedItems
        {
          get { return global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItem.ProcessingStatusItems; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItemActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItemCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItemAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItemAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DocumentFullTextSearchQueueItemFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DocumentFullTextSearchQueueItemClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentFullTextSearchQueueItemSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.Docflow.IDocumentFullTextSearchQueueItemSharedHandlers)this.SharedHandlers).DocumentIdChanged(args);
    }

    protected void PriorityChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Priority, this.Priority, this);
     ((global::Sungero.Docflow.IDocumentFullTextSearchQueueItemSharedHandlers)this.SharedHandlers).PriorityChanged(args);
    }

    protected void ExtractTextTaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ExtractTextTaskId, this.ExtractTextTaskId, this);
     ((global::Sungero.Docflow.IDocumentFullTextSearchQueueItemSharedHandlers)this.SharedHandlers).ExtractTextTaskIdChanged(args);
    }



  protected global::System.Int64? DocumentIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.DocumentId, value, this, this.Info.Properties.DocumentId);
    ((global::Sungero.Docflow.DocumentFullTextSearchQueueItemClientHandlers)this.Handlers).DocumentIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? PriorityValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.Priority, value, this, this.Info.Properties.Priority);
    ((global::Sungero.Docflow.DocumentFullTextSearchQueueItemClientHandlers)this.Handlers).PriorityValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? ExtractTextTaskIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.ExtractTextTaskId, value, this, this.Info.Properties.ExtractTextTaskId);
    ((global::Sungero.Docflow.DocumentFullTextSearchQueueItemClientHandlers)this.Handlers).ExtractTextTaskIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors





    public DocumentFullTextSearchQueueItem()
    {
            this._DocumentId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("DocumentId", this);
            this._DocumentId.ValueChanged += (sender, e) => { this.DocumentIdChangedHandler(); };
            this.AddProperty(this._DocumentId);

            this._Priority = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("Priority", this);
            this._Priority.ValueChanged += (sender, e) => { this.PriorityChangedHandler(); };
            this.AddProperty(this._Priority);

            this._ExtractTextTaskId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("ExtractTextTaskId", this);
            this._ExtractTextTaskId.ValueChanged += (sender, e) => { this.ExtractTextTaskIdChangedHandler(); };
            this.AddProperty(this._ExtractTextTaskId);








    }

    #endregion

  }
}

// ==================================================================
// DocumentFullTextSearchQueueItemPresenter.g.cs
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
  public class DocumentFullTextSearchQueueItemPresenter<T> :
    global::Sungero.ExchangeCore.Client.QueueItemBasePresenter<T>
    where T : class, global::Sungero.Docflow.IDocumentFullTextSearchQueueItem
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

    public DocumentFullTextSearchQueueItemPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// DocumentFullTextSearchQueueItemCollectionPresenter.g.cs
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
  public class DocumentFullTextSearchQueueItemCollectionPresenter<T> : 
    global::Sungero.ExchangeCore.Client.QueueItemBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IDocumentFullTextSearchQueueItem
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public DocumentFullTextSearchQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public DocumentFullTextSearchQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public DocumentFullTextSearchQueueItemCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public DocumentFullTextSearchQueueItemCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// DocumentFullTextSearchQueueItemRepositoryImplementer.g.cs
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
  public class DocumentFullTextSearchQueueItemRepositoryImplementer<T> : 
      global::Sungero.ExchangeCore.Client.QueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IDocumentFullTextSearchQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDocumentFullTextSearchQueueItem
    {
       public new global::Sungero.Docflow.IDocumentFullTextSearchQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDocumentFullTextSearchQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDocumentFullTextSearchQueueItemInfo Info
       {
          get { return (global::Sungero.Docflow.IDocumentFullTextSearchQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.DocumentFullTextSearchQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DocumentFullTextSearchQueueItemAccessRights.g.cs
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
  public class DocumentFullTextSearchQueueItemAccessRights : 
    Sungero.ExchangeCore.Client.QueueItemBaseAccessRights, Sungero.Docflow.IDocumentFullTextSearchQueueItemAccessRights
  {

    public DocumentFullTextSearchQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DocumentFullTextSearchQueueItemTypeAccessRights : 
    Sungero.ExchangeCore.Client.QueueItemBaseTypeAccessRights, Sungero.Docflow.IDocumentFullTextSearchQueueItemAccessRights
  {

    public DocumentFullTextSearchQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}