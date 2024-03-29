
// ==================================================================
// DocumentReviewTaskAddedAddenda.g.cs
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
  public class DocumentReviewTaskAddedAddenda :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddenda
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("5ea8896a-9f98-49bc-8716-d57a68dc60bc");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.DocumentReviewTaskAddedAddenda.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IDocumentReviewTaskAddedAddenda, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddendaState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddendaState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskAddedAddendaState(this);
    }

    public new global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddendaInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddendaInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IDocumentReviewTask> _DocumentReviewTask;

    public global::Sungero.RecordManagement.IDocumentReviewTask DocumentReviewTask
    {
      get { return this._DocumentReviewTask.Value; }
      set { this._DocumentReviewTask.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.DocumentReviewTask; }
      set { this.DocumentReviewTask = (global::Sungero.RecordManagement.IDocumentReviewTask)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _AddendumId;

        public virtual global::System.Int64? AddendumId
        {
          get { return this._AddendumId.Value; }
          set { this._AddendumId.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.DocumentReviewTaskAddedAddendaClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.DocumentReviewTaskAddedAddendaSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AddendumIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.AddendumId, this.AddendumId, this);
     ((global::Sungero.RecordManagement.IDocumentReviewTaskAddedAddendaSharedHandlers)this.SharedHandlers).AddedAddendaAddendumIdChanged(args);
    }



  protected global::System.Int64? AddendumIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.AddendumId, value, this, this.Info.Properties.AddendumId);
    ((global::Sungero.RecordManagement.DocumentReviewTaskAddedAddendaClientHandlers)this.Handlers).AddedAddendaAddendumIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public DocumentReviewTaskAddedAddenda()
    {
      this._DocumentReviewTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IDocumentReviewTask>("DocumentReviewTask", this, true);

            this._AddendumId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("AddendumId", this);
            this._AddendumId.ValueChanged += (sender, e) => { this.AddendumIdChangedHandler(); };
            this.AddProperty(this._AddendumId);








    }

    #endregion

  }
}
