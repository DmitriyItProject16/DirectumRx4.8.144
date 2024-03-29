
// ==================================================================
// ExtractTextQueueItem.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class ExtractTextQueueItem :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.SmartProcessing.IExtractTextQueueItem
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("79ed70e3-bd59-432d-8671-ef6399721f2b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Client.ExtractTextQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IExtractTextQueueItem, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.SmartProcessing.IExtractTextQueueItemState State
    {
      get
      {
        return (global::Sungero.SmartProcessing.IExtractTextQueueItemState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.ExtractTextQueueItemState(this);
    }

    public new global::Sungero.SmartProcessing.IExtractTextQueueItemInfo Info
    {
      get
      {
        return (global::Sungero.SmartProcessing.IExtractTextQueueItemInfo)base.Info;
      }
    }

    public new global::Sungero.SmartProcessing.IExtractTextQueueItemAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.SmartProcessing.IExtractTextQueueItemAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.SmartProcessing.Client.ExtractTextQueueItemAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _DocumentId;

        public virtual global::System.Int64? DocumentId
        {
          get { return this._DocumentId.Value; }
          set { this._DocumentId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _ArioTaskId;

        public virtual global::System.Int32? ArioTaskId
        {
          get { return this._ArioTaskId.Value; }
          set { this._ArioTaskId.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _ProcessingStatus;

        public virtual global::Sungero.Core.Enumeration? ProcessingStatus
        {
          get { return this._ProcessingStatus.Value; }
          set { this._ProcessingStatus.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _DocumentVersionNumber;

        public virtual global::System.Int32? DocumentVersionNumber
        {
          get { return this._DocumentVersionNumber.Value; }
          set { this._DocumentVersionNumber.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _Created;

        public virtual global::System.DateTime? Created
        {
          get { return this._Created.Value; }
          set { this._Created.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ProcessingStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.SmartProcessing.ExtractTextQueueItem.ProcessingStatus),
          typeof(global::Sungero.SmartProcessing.Client.ExtractTextQueueItem),
          "ProcessingStatus");

        public static global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusItems
        {
          get { return global::Sungero.SmartProcessing.Client.ExtractTextQueueItem._ProcessingStatusItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusAllowedItems
        {
          get { return global::Sungero.SmartProcessing.Client.ExtractTextQueueItem.ProcessingStatusItems; }
        }





        protected global::Sungero.Domain.Client.BinaryDataProperty<global::Sungero.Domain.Client.BinaryData> _ExtractedText;

        [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
        public virtual global::Sungero.Domain.Shared.IBinaryData ExtractedText
        {
          get { return this._ExtractedText.Value; }
          set
          {
            this._ExtractedText.Value = (global::Sungero.Domain.Client.BinaryData)value;
            if (value != null)
              this._ExtractedText.Value.RootEntity = this;
          }
        }






    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.ExtractTextQueueItemActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.ExtractTextQueueItemCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.ExtractTextQueueItemAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.SmartProcessing.Client.ExtractTextQueueItemAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.SmartProcessing.Client.ExtractTextQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.SmartProcessing.Shared.ExtractTextQueueItemFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.SmartProcessing.ExtractTextQueueItemClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.SmartProcessing.ExtractTextQueueItemSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).DocumentIdChanged(args);
    }

    protected void ArioTaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ArioTaskId, this.ArioTaskId, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).ArioTaskIdChanged(args);
    }

    protected void ProcessingStatusChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ProcessingStatus, this.ProcessingStatus, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).ProcessingStatusChanged(args);
    }

    protected void ExtractedTextChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BinaryDataPropertyChangedEventArgs(this.State.Properties.ExtractedText, this.ExtractedText, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).ExtractedTextChanged(args);
    }

    protected void DocumentVersionNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DocumentVersionNumber, this.DocumentVersionNumber, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).DocumentVersionNumberChanged(args);
    }

    protected void CreatedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.Created, this.Created, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).CreatedChanged(args);
    }



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.SmartProcessing.ExtractTextQueueItemClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int64? DocumentIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.DocumentId, value, this, this.Info.Properties.DocumentId);
    ((global::Sungero.SmartProcessing.ExtractTextQueueItemClientHandlers)this.Handlers).DocumentIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? ArioTaskIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.ArioTaskId, value, this, this.Info.Properties.ArioTaskId);
    ((global::Sungero.SmartProcessing.ExtractTextQueueItemClientHandlers)this.Handlers).ArioTaskIdValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? ProcessingStatusValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.ProcessingStatus, value, this, this.Info.Properties.ProcessingStatus);
    ((global::Sungero.SmartProcessing.ExtractTextQueueItemClientHandlers)this.Handlers).ProcessingStatusValueInput(args);
    return args.NewValue;
  }


  protected global::System.Int32? DocumentVersionNumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.DocumentVersionNumber, value, this, this.Info.Properties.DocumentVersionNumber);
    ((global::Sungero.SmartProcessing.ExtractTextQueueItemClientHandlers)this.Handlers).DocumentVersionNumberValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? CreatedValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.Created, value, this, this.Info.Properties.Created);
    ((global::Sungero.SmartProcessing.ExtractTextQueueItemClientHandlers)this.Handlers).CreatedValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ProcessingStatusFilteringHandler()
  {
    return ((global::Sungero.SmartProcessing.ExtractTextQueueItemClientHandlers)this.Handlers).ProcessingStatusFiltering(this.ProcessingStatusAllowedItems);
  }





    #endregion

    #region Constructors



    public ExtractTextQueueItem()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._DocumentId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("DocumentId", this);
            this._DocumentId.ValueChanged += (sender, e) => { this.DocumentIdChangedHandler(); };
            this.AddProperty(this._DocumentId);

            this._ArioTaskId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("ArioTaskId", this);
            this._ArioTaskId.ValueChanged += (sender, e) => { this.ArioTaskIdChangedHandler(); };
            this.AddProperty(this._ArioTaskId);

            this._ProcessingStatus = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("ProcessingStatus", this);
            this._ProcessingStatus.ValueChanged += (sender, e) => { this.ProcessingStatusChangedHandler(); };
            this.AddProperty(this._ProcessingStatus);

            this._DocumentVersionNumber = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("DocumentVersionNumber", this);
            this._DocumentVersionNumber.ValueChanged += (sender, e) => { this.DocumentVersionNumberChangedHandler(); };
            this.AddProperty(this._DocumentVersionNumber);

            this._Created = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("Created", this);
            this._Created.ValueChanged += (sender, e) => { this.CreatedChangedHandler(); };
            this.AddProperty(this._Created);







            this._ExtractedText = new global::Sungero.Domain.Client.BinaryDataProperty<global::Sungero.Domain.Client.BinaryData>("ExtractedText", this);
            this._ExtractedText.Value = new global::Sungero.Domain.Client.BinaryData() { RootEntity = this };
            this._ExtractedText.ValueChanged += (sender, e) => { this.ExtractedTextChangedHandler(); };
            this.AddProperty(this._ExtractedText);


    }

    #endregion

  }
}

// ==================================================================
// ExtractTextQueueItemPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class ExtractTextQueueItemPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.SmartProcessing.IExtractTextQueueItem
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _ShowExtractedTextCommand;

          public global::System.Windows.Input.ICommand ShowExtractedTextCommand
          {
            get
            {
              if (this._ShowExtractedTextCommand == null)
                  this._ShowExtractedTextCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ShowExtractedText", this, this.ShowExtractedText, this.CanShowExtractedText) { IsEmptyParameterAllowed = true };
              return this._ShowExtractedTextCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanShowExtractedText(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.SmartProcessing.Client.ExtractTextQueueItemActions)(entity as Sungero.SmartProcessing.Client.ExtractTextQueueItem).ActionsHandlers).CanShowExtractedText(args);
              }

              private void ShowExtractedText(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowExtractedText);
                ((Sungero.SmartProcessing.Client.ExtractTextQueueItemActions)(entity as Sungero.SmartProcessing.Client.ExtractTextQueueItem).ActionsHandlers).ShowExtractedText(args);
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

    }

    public ExtractTextQueueItemPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ExtractTextQueueItemCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class ExtractTextQueueItemCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.SmartProcessing.IExtractTextQueueItem
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ExtractTextQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ExtractTextQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ExtractTextQueueItemCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ExtractTextQueueItemCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ExtractTextQueueItemRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{ 
  public class ExtractTextQueueItemRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.SmartProcessing.IExtractTextQueueItemRepositoryImplementer<T>
      where T : global::Sungero.SmartProcessing.IExtractTextQueueItem
    {
       public new global::Sungero.SmartProcessing.IExtractTextQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.SmartProcessing.IExtractTextQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.SmartProcessing.IExtractTextQueueItemInfo Info
       {
          get { return (global::Sungero.SmartProcessing.IExtractTextQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.SmartProcessing.Client.ExtractTextQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ExtractTextQueueItemAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class ExtractTextQueueItemAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.SmartProcessing.IExtractTextQueueItemAccessRights
  {

    public ExtractTextQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ExtractTextQueueItemTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.SmartProcessing.IExtractTextQueueItemAccessRights
  {

    public ExtractTextQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
