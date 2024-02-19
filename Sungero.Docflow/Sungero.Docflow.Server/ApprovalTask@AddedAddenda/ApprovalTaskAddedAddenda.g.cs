
// ==================================================================
// ApprovalTaskAddedAddenda.g.cs
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


  public class ApprovalTaskAddedAddenda :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalTaskAddedAddenda
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("93e77aaa-e991-47a9-a81f-2e749875b1f7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalTaskAddedAddenda.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalTaskAddedAddenda, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalTaskAddedAddendaState State
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddedAddendaState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskAddedAddendaState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalTaskAddedAddendaInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddedAddendaInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalTask ApprovalTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalTask; }
      set { this.ApprovalTask = (global::Sungero.Docflow.IApprovalTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalTaskAddedAddendaSharedHandlers(this);
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
     ((global::Sungero.Docflow.IApprovalTaskAddedAddendaSharedHandlers)this.SharedHandlers).AddedAddendaAddendumIdChanged(args);
    }



    #endregion


    public ApprovalTaskAddedAddenda()
    {
    }

  }
}

// ==================================================================
// ApprovalTaskAddedAddendaHandlers.g.cs
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
// ApprovalTaskAddedAddendaEventArgs.g.cs
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