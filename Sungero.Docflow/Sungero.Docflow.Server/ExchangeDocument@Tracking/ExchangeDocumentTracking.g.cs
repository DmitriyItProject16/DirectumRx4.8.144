
// ==================================================================
// ExchangeDocumentTracking.g.cs
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


  public class ExchangeDocumentTracking :
    global::Sungero.Docflow.Server.OfficialDocumentTracking, global::Sungero.Docflow.IExchangeDocumentTracking
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0e2940ab-8568-4d47-a112-6d4a5cdb2d6d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ExchangeDocumentTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IExchangeDocumentTracking, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IExchangeDocumentTrackingState State
    {
      get { return (global::Sungero.Docflow.IExchangeDocumentTrackingState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ExchangeDocumentTrackingState(this);
    }

    public new virtual global::Sungero.Docflow.IExchangeDocumentTrackingInfo Info
    {
      get { return (global::Sungero.Docflow.IExchangeDocumentTrackingInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ExchangeDocumentTracking()
    {
    }

  }
}

// ==================================================================
// ExchangeDocumentTrackingHandlers.g.cs
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
// ExchangeDocumentTrackingEventArgs.g.cs
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
