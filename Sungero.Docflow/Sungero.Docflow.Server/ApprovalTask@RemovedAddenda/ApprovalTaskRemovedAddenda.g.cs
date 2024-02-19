
// ==================================================================
// ApprovalTaskRemovedAddenda.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{


  public class ApprovalTaskRemovedAddenda :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalTaskRemovedAddenda
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("815cb2ff-2e85-4093-8ee8-8b5a1096b64f");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalTaskRemovedAddenda.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalTaskRemovedAddenda, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalTaskRemovedAddendaState State
    {
      get { return (global::Sungero.Docflow.IApprovalTaskRemovedAddendaState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskRemovedAddendaState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalTaskRemovedAddendaInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalTaskRemovedAddendaInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalTask ApprovalTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalTask; }
      set { this.ApprovalTask = (global::Sungero.Docflow.IApprovalTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalTaskRemovedAddendaSharedHandlers(this);
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
     ((global::Sungero.Docflow.IApprovalTaskRemovedAddendaSharedHandlers)this.SharedHandlers).RemovedAddendaAddendumIdChanged(args);
    }



    #endregion


    public ApprovalTaskRemovedAddenda()
    {
    }

  }
}

// ==================================================================
// ApprovalTaskRemovedAddendaHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{

}

// ==================================================================
// ApprovalTaskRemovedAddendaEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}