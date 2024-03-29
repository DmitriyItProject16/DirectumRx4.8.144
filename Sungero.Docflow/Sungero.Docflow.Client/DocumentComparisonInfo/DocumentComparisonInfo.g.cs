
// ==================================================================
// DocumentComparisonInfo.g.cs
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
  public class DocumentComparisonInfo :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.Docflow.IDocumentComparisonInfo
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0af2153a-ef3e-47fc-aa8a-aa995031019b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.DocumentComparisonInfo.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentComparisonInfo, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IDocumentComparisonInfoState State
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentComparisonInfoState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentComparisonInfoState(this);
    }

    public new global::Sungero.Docflow.IDocumentComparisonInfoInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentComparisonInfoInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IDocumentComparisonInfoAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentComparisonInfoAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.DocumentComparisonInfoAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _FirstDocumentId;

        public virtual global::System.Int64? FirstDocumentId
        {
          get { return this._FirstDocumentId.Value; }
          set { this._FirstDocumentId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _SecondDocumentId;

        public virtual global::System.Int64? SecondDocumentId
        {
          get { return this._SecondDocumentId.Value; }
          set { this._SecondDocumentId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _FirstVersionExtension;

        public virtual global::System.String FirstVersionExtension
        {
          get { return this._FirstVersionExtension.Value; }
          set { this._FirstVersionExtension.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _SecondVersionExtension;

        public virtual global::System.String SecondVersionExtension
        {
          get { return this._SecondVersionExtension.Value; }
          set { this._SecondVersionExtension.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _FirstArioTaskId;

        public virtual global::System.Int32? FirstArioTaskId
        {
          get { return this._FirstArioTaskId.Value; }
          set { this._FirstArioTaskId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _SecondArioTaskId;

        public virtual global::System.Int32? SecondArioTaskId
        {
          get { return this._SecondArioTaskId.Value; }
          set { this._SecondArioTaskId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _DifferencesCount;

        public virtual global::System.Int32? DifferencesCount
        {
          get { return this._DifferencesCount.Value; }
          set { this._DifferencesCount.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _ErrorMessage;

        public virtual global::System.String ErrorMessage
        {
          get { return this._ErrorMessage.Value; }
          set { this._ErrorMessage.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _ProcessingStatus;

        public virtual global::Sungero.Core.Enumeration? ProcessingStatus
        {
          get { return this._ProcessingStatus.Value; }
          set { this._ProcessingStatus.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _DeletionDate;

        public virtual global::System.DateTime? DeletionDate
        {
          get { return this._DeletionDate.Value; }
          set { this._DeletionDate.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _FirstVersionNumber;

        public virtual global::System.Int32? FirstVersionNumber
        {
          get { return this._FirstVersionNumber.Value; }
          set { this._FirstVersionNumber.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _SecondVersionNumber;

        public virtual global::System.Int32? SecondVersionNumber
        {
          get { return this._SecondVersionNumber.Value; }
          set { this._SecondVersionNumber.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _FirstVersionHash;

        public virtual global::System.String FirstVersionHash
        {
          get { return this._FirstVersionHash.Value; }
          set { this._FirstVersionHash.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _SecondVersionHash;

        public virtual global::System.String SecondVersionHash
        {
          get { return this._SecondVersionHash.Value; }
          set { this._SecondVersionHash.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ProcessingStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.DocumentComparisonInfo.ProcessingStatus),
          typeof(global::Sungero.Docflow.Client.DocumentComparisonInfo),
          "ProcessingStatus");

        public static global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusItems
        {
          get { return global::Sungero.Docflow.Client.DocumentComparisonInfo._ProcessingStatusItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusAllowedItems
        {
          get { return global::Sungero.Docflow.Client.DocumentComparisonInfo.ProcessingStatusItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IUser> _Author;

              public virtual global::Sungero.CoreEntities.IUser Author
              {
              get
              {
                return this._Author.Value as global::Sungero.CoreEntities.IUser;
              }

              set
              {
                (this._Author as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }





        protected global::Sungero.Domain.Client.BinaryDataProperty<global::Sungero.Domain.Client.BinaryData> _FirstPdfVersion;

        [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
        public virtual global::Sungero.Domain.Shared.IBinaryData FirstPdfVersion
        {
          get { return this._FirstPdfVersion.Value; }
          set
          {
            this._FirstPdfVersion.Value = (global::Sungero.Domain.Client.BinaryData)value;
            if (value != null)
              this._FirstPdfVersion.Value.RootEntity = this;
          }
        }
        protected global::Sungero.Domain.Client.BinaryDataProperty<global::Sungero.Domain.Client.BinaryData> _SecondPdfVersion;

        [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
        public virtual global::Sungero.Domain.Shared.IBinaryData SecondPdfVersion
        {
          get { return this._SecondPdfVersion.Value; }
          set
          {
            this._SecondPdfVersion.Value = (global::Sungero.Domain.Client.BinaryData)value;
            if (value != null)
              this._SecondPdfVersion.Value.RootEntity = this;
          }
        }
        protected global::Sungero.Domain.Client.BinaryDataProperty<global::Sungero.Domain.Client.BinaryData> _ResultPdf;

        [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
        public virtual global::Sungero.Domain.Shared.IBinaryData ResultPdf
        {
          get { return this._ResultPdf.Value; }
          set
          {
            this._ResultPdf.Value = (global::Sungero.Domain.Client.BinaryData)value;
            if (value != null)
              this._ResultPdf.Value.RootEntity = this;
          }
        }






    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentComparisonInfoActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentComparisonInfoCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentComparisonInfoAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentComparisonInfoAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.DocumentComparisonInfoFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DocumentComparisonInfoFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DocumentComparisonInfoClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentComparisonInfoSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void AuthorChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DocumentComparisonInfoAuthorChangedEventArgs(this.State.Properties.Author, this.Author, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).AuthorChanged(args);
    }

    protected void FirstDocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.FirstDocumentId, this.FirstDocumentId, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).FirstDocumentIdChanged(args);
    }

    protected void SecondDocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.SecondDocumentId, this.SecondDocumentId, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).SecondDocumentIdChanged(args);
    }

    protected void FirstVersionExtensionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FirstVersionExtension, this.FirstVersionExtension, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).FirstVersionExtensionChanged(args);
    }

    protected void SecondVersionExtensionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.SecondVersionExtension, this.SecondVersionExtension, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).SecondVersionExtensionChanged(args);
    }

    protected void FirstArioTaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.FirstArioTaskId, this.FirstArioTaskId, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).FirstArioTaskIdChanged(args);
    }

    protected void SecondArioTaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.SecondArioTaskId, this.SecondArioTaskId, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).SecondArioTaskIdChanged(args);
    }

    protected void FirstPdfVersionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BinaryDataPropertyChangedEventArgs(this.State.Properties.FirstPdfVersion, this.FirstPdfVersion, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).FirstPdfVersionChanged(args);
    }

    protected void SecondPdfVersionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BinaryDataPropertyChangedEventArgs(this.State.Properties.SecondPdfVersion, this.SecondPdfVersion, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).SecondPdfVersionChanged(args);
    }

    protected void ResultPdfChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BinaryDataPropertyChangedEventArgs(this.State.Properties.ResultPdf, this.ResultPdf, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).ResultPdfChanged(args);
    }

    protected void DifferencesCountChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DifferencesCount, this.DifferencesCount, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).DifferencesCountChanged(args);
    }

    protected void ErrorMessageChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ErrorMessage, this.ErrorMessage, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).ErrorMessageChanged(args);
    }

    protected void ProcessingStatusChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ProcessingStatus, this.ProcessingStatus, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).ProcessingStatusChanged(args);
    }

    protected void DeletionDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.DeletionDate, this.DeletionDate, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).DeletionDateChanged(args);
    }

    protected void FirstVersionNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.FirstVersionNumber, this.FirstVersionNumber, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).FirstVersionNumberChanged(args);
    }

    protected void SecondVersionNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.SecondVersionNumber, this.SecondVersionNumber, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).SecondVersionNumberChanged(args);
    }

    protected void FirstVersionHashChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FirstVersionHash, this.FirstVersionHash, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).FirstVersionHashChanged(args);
    }

    protected void SecondVersionHashChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.SecondVersionHash, this.SecondVersionHash, this);
     ((global::Sungero.Docflow.IDocumentComparisonInfoSharedHandlers)this.SharedHandlers).SecondVersionHashChanged(args);
    }



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.CoreEntities.IUser AuthorValueInputHandler(global::Sungero.CoreEntities.IUser value)
  {
    var args = new global::Sungero.Docflow.Client.DocumentComparisonInfoAuthorValueInputEventArgs(this.Author, value, this, this.Info.Properties.Author);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).AuthorValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int64? FirstDocumentIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.FirstDocumentId, value, this, this.Info.Properties.FirstDocumentId);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).FirstDocumentIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int64? SecondDocumentIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.SecondDocumentId, value, this, this.Info.Properties.SecondDocumentId);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).SecondDocumentIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String FirstVersionExtensionValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.FirstVersionExtension, value, this, this.Info.Properties.FirstVersionExtension);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).FirstVersionExtensionValueInput(args);
    return args.NewValue;
  }

  protected global::System.String SecondVersionExtensionValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.SecondVersionExtension, value, this, this.Info.Properties.SecondVersionExtension);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).SecondVersionExtensionValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? FirstArioTaskIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.FirstArioTaskId, value, this, this.Info.Properties.FirstArioTaskId);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).FirstArioTaskIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? SecondArioTaskIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.SecondArioTaskId, value, this, this.Info.Properties.SecondArioTaskId);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).SecondArioTaskIdValueInput(args);
    return args.NewValue;
  }




  protected global::System.Int32? DifferencesCountValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.DifferencesCount, value, this, this.Info.Properties.DifferencesCount);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).DifferencesCountValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ErrorMessageValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.ErrorMessage, value, this, this.Info.Properties.ErrorMessage);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).ErrorMessageValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? ProcessingStatusValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.ProcessingStatus, value, this, this.Info.Properties.ProcessingStatus);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).ProcessingStatusValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? DeletionDateValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.DeletionDate, value, this, this.Info.Properties.DeletionDate);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).DeletionDateValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? FirstVersionNumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.FirstVersionNumber, value, this, this.Info.Properties.FirstVersionNumber);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).FirstVersionNumberValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? SecondVersionNumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.SecondVersionNumber, value, this, this.Info.Properties.SecondVersionNumber);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).SecondVersionNumberValueInput(args);
    return args.NewValue;
  }

  protected global::System.String FirstVersionHashValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.FirstVersionHash, value, this, this.Info.Properties.FirstVersionHash);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).FirstVersionHashValueInput(args);
    return args.NewValue;
  }

  protected global::System.String SecondVersionHashValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.SecondVersionHash, value, this, this.Info.Properties.SecondVersionHash);
    ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).SecondVersionHashValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ProcessingStatusFilteringHandler()
  {
    return ((global::Sungero.Docflow.DocumentComparisonInfoClientHandlers)this.Handlers).ProcessingStatusFiltering(this.ProcessingStatusAllowedItems);
  }







    #endregion

    #region Constructors



              protected virtual void InitAuthorNavigationProperty()
              {
                this._Author = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IUser>("Author", this);
                this._Author.ValueChanged += (sender, e) => { this.AuthorChangedHandler(); };
                this.AddProperty(this._Author as global::Sungero.Domain.Client.IProperty);
              }




    public DocumentComparisonInfo()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._FirstDocumentId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("FirstDocumentId", this);
            this._FirstDocumentId.ValueChanged += (sender, e) => { this.FirstDocumentIdChangedHandler(); };
            this.AddProperty(this._FirstDocumentId);

            this._SecondDocumentId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("SecondDocumentId", this);
            this._SecondDocumentId.ValueChanged += (sender, e) => { this.SecondDocumentIdChangedHandler(); };
            this.AddProperty(this._SecondDocumentId);

            this._FirstVersionExtension = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("FirstVersionExtension", this);
            this._FirstVersionExtension.ValueChanged += (sender, e) => { this.FirstVersionExtensionChangedHandler(); };
            this.AddProperty(this._FirstVersionExtension);

            this._SecondVersionExtension = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("SecondVersionExtension", this);
            this._SecondVersionExtension.ValueChanged += (sender, e) => { this.SecondVersionExtensionChangedHandler(); };
            this.AddProperty(this._SecondVersionExtension);

            this._FirstArioTaskId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("FirstArioTaskId", this);
            this._FirstArioTaskId.ValueChanged += (sender, e) => { this.FirstArioTaskIdChangedHandler(); };
            this.AddProperty(this._FirstArioTaskId);

            this._SecondArioTaskId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("SecondArioTaskId", this);
            this._SecondArioTaskId.ValueChanged += (sender, e) => { this.SecondArioTaskIdChangedHandler(); };
            this.AddProperty(this._SecondArioTaskId);

            this._DifferencesCount = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("DifferencesCount", this);
            this._DifferencesCount.ValueChanged += (sender, e) => { this.DifferencesCountChangedHandler(); };
            this.AddProperty(this._DifferencesCount);

            this._ErrorMessage = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("ErrorMessage", this);
            this._ErrorMessage.ValueChanged += (sender, e) => { this.ErrorMessageChangedHandler(); };
            this.AddProperty(this._ErrorMessage);

            this._ProcessingStatus = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("ProcessingStatus", this);
            this._ProcessingStatus.ValueChanged += (sender, e) => { this.ProcessingStatusChangedHandler(); };
            this.AddProperty(this._ProcessingStatus);

            this._DeletionDate = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("DeletionDate", this);
            this._DeletionDate.ValueChanged += (sender, e) => { this.DeletionDateChangedHandler(); };
            this.AddProperty(this._DeletionDate);

            this._FirstVersionNumber = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("FirstVersionNumber", this);
            this._FirstVersionNumber.ValueChanged += (sender, e) => { this.FirstVersionNumberChangedHandler(); };
            this.AddProperty(this._FirstVersionNumber);

            this._SecondVersionNumber = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("SecondVersionNumber", this);
            this._SecondVersionNumber.ValueChanged += (sender, e) => { this.SecondVersionNumberChangedHandler(); };
            this.AddProperty(this._SecondVersionNumber);

            this._FirstVersionHash = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("FirstVersionHash", this);
            this._FirstVersionHash.ValueChanged += (sender, e) => { this.FirstVersionHashChangedHandler(); };
            this.AddProperty(this._FirstVersionHash);

            this._SecondVersionHash = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("SecondVersionHash", this);
            this._SecondVersionHash.ValueChanged += (sender, e) => { this.SecondVersionHashChangedHandler(); };
            this.AddProperty(this._SecondVersionHash);

            this.InitAuthorNavigationProperty();







            this._FirstPdfVersion = new global::Sungero.Domain.Client.BinaryDataProperty<global::Sungero.Domain.Client.BinaryData>("FirstPdfVersion", this);
            this._FirstPdfVersion.Value = new global::Sungero.Domain.Client.BinaryData() { RootEntity = this };
            this._FirstPdfVersion.ValueChanged += (sender, e) => { this.FirstPdfVersionChangedHandler(); };
            this.AddProperty(this._FirstPdfVersion);

            this._SecondPdfVersion = new global::Sungero.Domain.Client.BinaryDataProperty<global::Sungero.Domain.Client.BinaryData>("SecondPdfVersion", this);
            this._SecondPdfVersion.Value = new global::Sungero.Domain.Client.BinaryData() { RootEntity = this };
            this._SecondPdfVersion.ValueChanged += (sender, e) => { this.SecondPdfVersionChangedHandler(); };
            this.AddProperty(this._SecondPdfVersion);

            this._ResultPdf = new global::Sungero.Domain.Client.BinaryDataProperty<global::Sungero.Domain.Client.BinaryData>("ResultPdf", this);
            this._ResultPdf.Value = new global::Sungero.Domain.Client.BinaryData() { RootEntity = this };
            this._ResultPdf.ValueChanged += (sender, e) => { this.ResultPdfChangedHandler(); };
            this.AddProperty(this._ResultPdf);


    }

    #endregion

  }
}

// ==================================================================
// DocumentComparisonInfoPresenter.g.cs
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
  public class DocumentComparisonInfoPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.Docflow.IDocumentComparisonInfo
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _OpenResultPdfCommand;

          public global::System.Windows.Input.ICommand OpenResultPdfCommand
          {
            get
            {
              if (this._OpenResultPdfCommand == null)
                  this._OpenResultPdfCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("OpenResultPdf", this, this.OpenResultPdf, this.CanOpenResultPdf) { IsEmptyParameterAllowed = true };
              return this._OpenResultPdfCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanOpenResultPdf(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.DocumentComparisonInfoActions)(entity as Sungero.Docflow.Client.DocumentComparisonInfo).ActionsHandlers).CanOpenResultPdf(args);
              }

              private void OpenResultPdf(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.OpenResultPdf);
                ((Sungero.Docflow.Client.DocumentComparisonInfoActions)(entity as Sungero.Docflow.Client.DocumentComparisonInfo).ActionsHandlers).OpenResultPdf(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _AuthorCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter AuthorCollectionPresenter
              {
          get { return this._AuthorCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
                  this._AuthorCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IUser>(global::System.Guid.Parse("6c4ca209-49a8-4489-b91f-84d4bb95f3ed"));
              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");


    }

    public DocumentComparisonInfoPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// DocumentComparisonInfoCollectionPresenter.g.cs
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
  public class DocumentComparisonInfoCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IDocumentComparisonInfo
  {
    #region Actions

          private global::System.Windows.Input.ICommand _OpenResultPdfCommand;  

          public global::System.Windows.Input.ICommand OpenResultPdfCommand 
          { 
            get
            { 
              if (this._OpenResultPdfCommand == null)
                this._OpenResultPdfCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("OpenResultPdf", this, this.OpenResultPdf, this.CanOpenResultPdf) { IsEmptyParameterAllowed = true };
              return this._OpenResultPdfCommand; 
            }
          }



    #endregion

    #region Methods

        private bool CanOpenResultPdf(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this);
          return ((Sungero.Docflow.Client.DocumentComparisonInfoActions)(entity as Sungero.Docflow.Client.DocumentComparisonInfo).ActionsHandlers).CanOpenResultPdf(args);
        }

        private void OpenResultPdf(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this, entity.Info.Actions.OpenResultPdf);
          ((Sungero.Docflow.Client.DocumentComparisonInfoActions)(entity as Sungero.Docflow.Client.DocumentComparisonInfo).ActionsHandlers).OpenResultPdf(args);
        }



    #endregion

    public DocumentComparisonInfoCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public DocumentComparisonInfoCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public DocumentComparisonInfoCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public DocumentComparisonInfoCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// DocumentComparisonInfoRepositoryImplementer.g.cs
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
  public class DocumentComparisonInfoRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.Docflow.IDocumentComparisonInfoRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDocumentComparisonInfo
    {
       public new global::Sungero.Docflow.IDocumentComparisonInfoAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDocumentComparisonInfoAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDocumentComparisonInfoInfo Info
       {
          get { return (global::Sungero.Docflow.IDocumentComparisonInfoInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.DocumentComparisonInfoTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DocumentComparisonInfoAccessRights.g.cs
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
  public class DocumentComparisonInfoAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.Docflow.IDocumentComparisonInfoAccessRights
  {

    public DocumentComparisonInfoAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DocumentComparisonInfoTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.Docflow.IDocumentComparisonInfoAccessRights
  {

    public DocumentComparisonInfoTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
