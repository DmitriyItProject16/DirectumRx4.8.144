
// ==================================================================
// ActionItemExecutionTaskAddedAddenda.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{


  public class ActionItemExecutionTaskAddedAddenda :
    global::Sungero.Domain.ChildEntity, global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddenda
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1ff589b3-bdb9-4900-a1db-0790693052ba");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.ActionItemExecutionTaskAddedAddenda.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemExecutionTaskAddedAddenda, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaState State
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskAddedAddendaState(this);
    }

    public new virtual global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaInfo Info
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaInfo)base.Info; }
    }


    public global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemExecutionTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ActionItemExecutionTask; }
      set { this.ActionItemExecutionTask = (global::Sungero.RecordManagement.IActionItemExecutionTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskAddedAddendaSharedHandlers(this);
    }

    private global::System.Int64? _AddendumId;
    public virtual global::System.Int64? AddendumId
    {
      get
      {
        return this._AddendumId;
      }

      set
      {
        this.SetPropertyValue("AddendumId", this._AddendumId, value, (propertyValue) => { this._AddendumId = propertyValue; }, this.AddendumIdChangedHandler);
      }
    }










    #region Framework events

    protected void AddendumIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.AddendumId, this.AddendumId, this);
     ((global::Sungero.RecordManagement.IActionItemExecutionTaskAddedAddendaSharedHandlers)this.SharedHandlers).AddedAddendaAddendumIdChanged(args);
    }



    #endregion


    public ActionItemExecutionTaskAddedAddenda()
    {
    }

  }
}

// ==================================================================
// ActionItemExecutionTaskAddedAddendaHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

}

// ==================================================================
// ActionItemExecutionTaskAddedAddendaEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}
