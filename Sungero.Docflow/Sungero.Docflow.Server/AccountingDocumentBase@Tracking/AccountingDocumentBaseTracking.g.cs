
// ==================================================================
// AccountingDocumentBaseTracking.g.cs
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


  public class AccountingDocumentBaseTracking :
    global::Sungero.Docflow.Server.OfficialDocumentTracking, global::Sungero.Docflow.IAccountingDocumentBaseTracking
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("dd454376-144f-461f-a2a5-4b1684ff5c4a");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.AccountingDocumentBaseTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAccountingDocumentBaseTracking, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IAccountingDocumentBaseTrackingState State
    {
      get { return (global::Sungero.Docflow.IAccountingDocumentBaseTrackingState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AccountingDocumentBaseTrackingState(this);
    }

    public new virtual global::Sungero.Docflow.IAccountingDocumentBaseTrackingInfo Info
    {
      get { return (global::Sungero.Docflow.IAccountingDocumentBaseTrackingInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public AccountingDocumentBaseTracking()
    {
    }

  }
}

// ==================================================================
// AccountingDocumentBaseTrackingHandlers.g.cs
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
// AccountingDocumentBaseTrackingEventArgs.g.cs
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