
// ==================================================================
// CancellationAgreementTracking.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{


  public class CancellationAgreementTracking :
    global::Sungero.Docflow.Server.ContractualDocumentBaseTracking, global::Sungero.Exchange.ICancellationAgreementTracking
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("a7cbaaf6-5be8-4cb9-9b07-4a2857669a6e");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Exchange.Server.CancellationAgreementTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Exchange.ICancellationAgreementTracking, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Exchange.ICancellationAgreementTrackingState State
    {
      get { return (global::Sungero.Exchange.ICancellationAgreementTrackingState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Exchange.Shared.CancellationAgreementTrackingState(this);
    }

    public new virtual global::Sungero.Exchange.ICancellationAgreementTrackingInfo Info
    {
      get { return (global::Sungero.Exchange.ICancellationAgreementTrackingInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public CancellationAgreementTracking()
    {
    }

  }
}

// ==================================================================
// CancellationAgreementTrackingHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange
{

}

// ==================================================================
// CancellationAgreementTrackingEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
}
