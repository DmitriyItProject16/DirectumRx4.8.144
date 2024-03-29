
// ==================================================================
// AcquaintanceAssignmentAcquaintanceVersions.g.cs
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
  public class AcquaintanceAssignmentAcquaintanceVersions :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("21540d9d-4b87-45b3-9a28-7bb1adebfe65");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.AcquaintanceAssignmentAcquaintanceVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersionsState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceAssignmentAcquaintanceVersionsState(this);
    }

    public new global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersionsInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersionsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IAcquaintanceAssignment> _AcquaintanceAssignment;

    public global::Sungero.RecordManagement.IAcquaintanceAssignment AcquaintanceAssignment
    {
      get { return this._AcquaintanceAssignment.Value; }
      set { this._AcquaintanceAssignment.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AcquaintanceAssignment; }
      set { this.AcquaintanceAssignment = (global::Sungero.RecordManagement.IAcquaintanceAssignment)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _Number;

        public virtual global::System.Int32? Number
        {
          get { return this._Number.Value; }
          set { this._Number.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Hash;

        public virtual global::System.String Hash
        {
          get { return this._Hash.Value; }
          set { this._Hash.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsMainDocument;

        public virtual global::System.Boolean? IsMainDocument
        {
          get { return this._IsMainDocument.Value; }
          set { this._IsMainDocument.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _DocumentId;

        public virtual global::System.Int64? DocumentId
        {
          get { return this._DocumentId.Value; }
          set { this._DocumentId.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Number, this.Number, this);
     ((global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersionsSharedHandlers)this.SharedHandlers).AcquaintanceVersionsNumberChanged(args);
    }

    protected void HashChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Hash, this.Hash, this);
     ((global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersionsSharedHandlers)this.SharedHandlers).AcquaintanceVersionsHashChanged(args);
    }

    protected void IsMainDocumentChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsMainDocument, this.IsMainDocument, this);
     ((global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersionsSharedHandlers)this.SharedHandlers).AcquaintanceVersionsIsMainDocumentChanged(args);
    }

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersionsSharedHandlers)this.SharedHandlers).AcquaintanceVersionsDocumentIdChanged(args);
    }



  protected global::System.Int32? NumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.Number, value, this, this.Info.Properties.Number);
    ((global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsClientHandlers)this.Handlers).AcquaintanceVersionsNumberValueInput(args);
    return args.NewValue;
  }

  protected global::System.String HashValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Hash, value, this, this.Info.Properties.Hash);
    ((global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsClientHandlers)this.Handlers).AcquaintanceVersionsHashValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsMainDocumentValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsMainDocument, value, this, this.Info.Properties.IsMainDocument);
    ((global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsClientHandlers)this.Handlers).AcquaintanceVersionsIsMainDocumentValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int64? DocumentIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.DocumentId, value, this, this.Info.Properties.DocumentId);
    ((global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsClientHandlers)this.Handlers).AcquaintanceVersionsDocumentIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public AcquaintanceAssignmentAcquaintanceVersions()
    {
      this._AcquaintanceAssignment = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IAcquaintanceAssignment>("AcquaintanceAssignment", this, true);

            this._Number = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("Number", this);
            this._Number.ValueChanged += (sender, e) => { this.NumberChangedHandler(); };
            this.AddProperty(this._Number);

            this._Hash = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Hash", this);
            this._Hash.ValueChanged += (sender, e) => { this.HashChangedHandler(); };
            this.AddProperty(this._Hash);

            this._IsMainDocument = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsMainDocument", this);
            this._IsMainDocument.ValueChanged += (sender, e) => { this.IsMainDocumentChangedHandler(); };
            this.AddProperty(this._IsMainDocument);

            this._DocumentId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("DocumentId", this);
            this._DocumentId.ValueChanged += (sender, e) => { this.DocumentIdChangedHandler(); };
            this.AddProperty(this._DocumentId);








    }

    #endregion

  }
}
