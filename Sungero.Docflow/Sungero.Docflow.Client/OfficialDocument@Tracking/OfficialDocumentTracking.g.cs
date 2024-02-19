
// ==================================================================
// OfficialDocumentTracking.g.cs
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
  public class OfficialDocumentTracking :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IOfficialDocumentTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("2d7f6507-6d0a-4bb7-b2a1-2f4248b962e7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.OfficialDocumentTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IOfficialDocumentTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IOfficialDocumentTrackingState State
    {
      get
      {
        return (global::Sungero.Docflow.IOfficialDocumentTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.OfficialDocumentTrackingState(this);
    }

    public new global::Sungero.Docflow.IOfficialDocumentTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IOfficialDocumentTrackingInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IOfficialDocument> _OfficialDocument;

    public global::Sungero.Docflow.IOfficialDocument OfficialDocument
    {
      get { return this._OfficialDocument.Value; }
      set { this._OfficialDocument.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.OfficialDocument; }
      set { this.OfficialDocument = (global::Sungero.Docflow.IOfficialDocument)value; }
    }

        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _Action;

        public virtual global::Sungero.Core.Enumeration? Action
        {
          get { return this._Action.Value; }
          set { this._Action.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsOriginal;

        public virtual global::System.Boolean? IsOriginal
        {
          get { return this._IsOriginal.Value; }
          set { this._IsOriginal.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _ReturnDeadline;

        public virtual global::System.DateTime? ReturnDeadline
        {
          get { return this._ReturnDeadline.Value; }
          set { this._ReturnDeadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _ReturnDate;

        public virtual global::System.DateTime? ReturnDate
        {
          get { return this._ReturnDate.Value; }
          set { this._ReturnDate.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _DeliveryDate;

        public virtual global::System.DateTime? DeliveryDate
        {
          get { return this._DeliveryDate.Value; }
          set { this._DeliveryDate.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _ReturnResult;

        public virtual global::Sungero.Core.Enumeration? ReturnResult
        {
          get { return this._ReturnResult.Value; }
          set { this._ReturnResult.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Note;

        public virtual global::System.String Note
        {
          get { return this._Note.Value; }
          set { this._Note.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _Iteration;

        public virtual global::System.Int32? Iteration
        {
          get { return this._Iteration.Value; }
          set { this._Iteration.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _ExternalLinkId;

        public virtual global::System.Int64? ExternalLinkId
        {
          get { return this._ExternalLinkId.Value; }
          set { this._ExternalLinkId.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ActionItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.OfficialDocumentTracking.Action),
          typeof(global::Sungero.Docflow.Client.OfficialDocumentTracking),
          "Action");

        public static global::Sungero.Domain.Shared.EnumerationItems ActionItems
        {
          get { return global::Sungero.Docflow.Client.OfficialDocumentTracking._ActionItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems ActionAllowedItems
        {
          get { return global::Sungero.Docflow.Client.OfficialDocumentTracking.ActionItems; }
        }

        private static global::Sungero.Domain.Shared.EnumerationItems _ReturnResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.OfficialDocumentTracking.ReturnResult),
          typeof(global::Sungero.Docflow.Client.OfficialDocumentTracking),
          "ReturnResult");

        public static global::Sungero.Domain.Shared.EnumerationItems ReturnResultItems
        {
          get { return global::Sungero.Docflow.Client.OfficialDocumentTracking._ReturnResultItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems ReturnResultAllowedItems
        {
          get { return global::Sungero.Docflow.Client.OfficialDocumentTracking.ReturnResultItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _DeliveredTo;

              public virtual global::Sungero.Company.IEmployee DeliveredTo
              {
              get
              {
                return this._DeliveredTo.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._DeliveredTo as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Workflow.ITask> _ReturnTask;

              public virtual global::Sungero.Workflow.ITask ReturnTask
              {
              get
              {
                return this._ReturnTask.Value as global::Sungero.Workflow.ITask;
              }

              set
              {
                (this._ReturnTask as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.OfficialDocumentTrackingSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ActionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Action, this.Action, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingActionChanged(args);
    }

    protected void DeliveredToChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.OfficialDocumentTrackingDeliveredToChangedEventArgs(this.State.Properties.DeliveredTo, this.DeliveredTo, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingDeliveredToChanged(args);
    }

    protected void IsOriginalChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsOriginal, this.IsOriginal, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingIsOriginalChanged(args);
    }

    protected void ReturnDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.ReturnDeadline, this.ReturnDeadline, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingReturnDeadlineChanged(args);
    }

    protected void ReturnDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.ReturnDate, this.ReturnDate, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingReturnDateChanged(args);
    }

    protected void DeliveryDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.DeliveryDate, this.DeliveryDate, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingDeliveryDateChanged(args);
    }

    protected void ReturnResultChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ReturnResult, this.ReturnResult, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingReturnResultChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingNoteChanged(args);
    }

    protected void ReturnTaskChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.OfficialDocumentTrackingReturnTaskChangedEventArgs(this.State.Properties.ReturnTask, this.ReturnTask, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingReturnTaskChanged(args);
    }

    protected void IterationChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Iteration, this.Iteration, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingIterationChanged(args);
    }

    protected void ExternalLinkIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.ExternalLinkId, this.ExternalLinkId, this);
     ((global::Sungero.Docflow.IOfficialDocumentTrackingSharedHandlers)this.SharedHandlers).TrackingExternalLinkIdChanged(args);
    }



  protected global::Sungero.Core.Enumeration? ActionValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.Action, value, this, this.Info.Properties.Action);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingActionValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee DeliveredToValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Docflow.Client.OfficialDocumentTrackingDeliveredToValueInputEventArgs(this.DeliveredTo, value, this, this.Info.Properties.DeliveredTo);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingDeliveredToValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsOriginalValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsOriginal, value, this, this.Info.Properties.IsOriginal);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingIsOriginalValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? ReturnDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.ReturnDeadline, value, this, this.Info.Properties.ReturnDeadline);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingReturnDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? ReturnDateValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.ReturnDate, value, this, this.Info.Properties.ReturnDate);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingReturnDateValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? DeliveryDateValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.DeliveryDate, value, this, this.Info.Properties.DeliveryDate);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingDeliveryDateValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? ReturnResultValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.ReturnResult, value, this, this.Info.Properties.ReturnResult);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingReturnResultValueInput(args);
    return args.NewValue;
  }

  protected global::System.String NoteValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Note, value, this, this.Info.Properties.Note);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingNoteValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Workflow.ITask ReturnTaskValueInputHandler(global::Sungero.Workflow.ITask value)
  {
    var args = new global::Sungero.Docflow.Client.OfficialDocumentTrackingReturnTaskValueInputEventArgs(this.ReturnTask, value, this, this.Info.Properties.ReturnTask);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingReturnTaskValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? IterationValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.Iteration, value, this, this.Info.Properties.Iteration);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingIterationValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int64? ExternalLinkIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.ExternalLinkId, value, this, this.Info.Properties.ExternalLinkId);
    ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingExternalLinkIdValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ActionFilteringHandler()
  {
    return ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingActionFiltering(this.ActionAllowedItems);
  }






  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ReturnResultFilteringHandler()
  {
    return ((global::Sungero.Docflow.OfficialDocumentTrackingClientHandlers)this.Handlers).TrackingReturnResultFiltering(this.ReturnResultAllowedItems);
  }






    #endregion

    #region Constructors



              protected virtual void InitDeliveredToNavigationProperty()
              {
                this._DeliveredTo = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("DeliveredTo", this);
                this._DeliveredTo.ValueChanged += (sender, e) => { this.DeliveredToChangedHandler(); };
                this.AddProperty(this._DeliveredTo as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitReturnTaskNavigationProperty()
              {
                this._ReturnTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Workflow.ITask>("ReturnTask", this);
                this._ReturnTask.ValueChanged += (sender, e) => { this.ReturnTaskChangedHandler(); };
                this.AddProperty(this._ReturnTask as global::Sungero.Domain.Client.IProperty);
              }




    public OfficialDocumentTracking()
    {
      this._OfficialDocument = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IOfficialDocument>("OfficialDocument", this, true);

            this._Action = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("Action", this);
            this._Action.ValueChanged += (sender, e) => { this.ActionChangedHandler(); };
            this.AddProperty(this._Action);

            this._IsOriginal = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsOriginal", this);
            this._IsOriginal.ValueChanged += (sender, e) => { this.IsOriginalChangedHandler(); };
            this.AddProperty(this._IsOriginal);

            this._ReturnDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("ReturnDeadline", this);
            this._ReturnDeadline.ValueChanged += (sender, e) => { this.ReturnDeadlineChangedHandler(); };
            this.AddProperty(this._ReturnDeadline);

            this._ReturnDate = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("ReturnDate", this);
            this._ReturnDate.ValueChanged += (sender, e) => { this.ReturnDateChangedHandler(); };
            this.AddProperty(this._ReturnDate);

            this._DeliveryDate = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("DeliveryDate", this);
            this._DeliveryDate.ValueChanged += (sender, e) => { this.DeliveryDateChangedHandler(); };
            this.AddProperty(this._DeliveryDate);

            this._ReturnResult = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("ReturnResult", this);
            this._ReturnResult.ValueChanged += (sender, e) => { this.ReturnResultChangedHandler(); };
            this.AddProperty(this._ReturnResult);

            this._Note = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Note", this);
            this._Note.ValueChanged += (sender, e) => { this.NoteChangedHandler(); };
            this.AddProperty(this._Note);

            this._Iteration = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("Iteration", this);
            this._Iteration.ValueChanged += (sender, e) => { this.IterationChangedHandler(); };
            this.AddProperty(this._Iteration);

            this._ExternalLinkId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("ExternalLinkId", this);
            this._ExternalLinkId.ValueChanged += (sender, e) => { this.ExternalLinkIdChangedHandler(); };
            this.AddProperty(this._ExternalLinkId);

            this.InitDeliveredToNavigationProperty();

            this.InitReturnTaskNavigationProperty();








    }

    #endregion

  }
}
