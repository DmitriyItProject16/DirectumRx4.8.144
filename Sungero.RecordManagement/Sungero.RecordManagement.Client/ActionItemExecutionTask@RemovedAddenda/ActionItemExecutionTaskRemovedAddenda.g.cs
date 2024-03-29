
// ==================================================================
// ActionItemExecutionTaskRemovedAddenda.g.cs
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
  public class ActionItemExecutionTaskRemovedAddenda :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IActionItemExecutionTaskRemovedAddenda
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("17dc81ea-b23e-4b1c-9c6b-ea2c2a1f7b7e");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ActionItemExecutionTaskRemovedAddenda.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemExecutionTaskRemovedAddenda, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskRemovedAddendaState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemExecutionTaskRemovedAddendaState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskRemovedAddendaState(this);
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskRemovedAddendaInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemExecutionTaskRemovedAddendaInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask> _ActionItemExecutionTask;

    public global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemExecutionTask
    {
      get { return this._ActionItemExecutionTask.Value; }
      set { this._ActionItemExecutionTask.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ActionItemExecutionTask; }
      set { this.ActionItemExecutionTask = (global::Sungero.RecordManagement.IActionItemExecutionTask)value; }
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
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskRemovedAddendaClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskRemovedAddendaSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AddendumIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.AddendumId, this.AddendumId, this);
     ((global::Sungero.RecordManagement.IActionItemExecutionTaskRemovedAddendaSharedHandlers)this.SharedHandlers).RemovedAddendaAddendumIdChanged(args);
    }



  protected global::System.Int64? AddendumIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.AddendumId, value, this, this.Info.Properties.AddendumId);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskRemovedAddendaClientHandlers)this.Handlers).RemovedAddendaAddendumIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public ActionItemExecutionTaskRemovedAddenda()
    {
      this._ActionItemExecutionTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask>("ActionItemExecutionTask", this, true);

            this._AddendumId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("AddendumId", this);
            this._AddendumId.ValueChanged += (sender, e) => { this.AddendumIdChangedHandler(); };
            this.AddProperty(this._AddendumId);








    }

    #endregion

  }
}
