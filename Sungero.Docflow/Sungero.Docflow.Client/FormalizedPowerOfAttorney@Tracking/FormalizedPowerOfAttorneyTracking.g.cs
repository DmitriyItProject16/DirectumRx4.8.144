
// ==================================================================
// FormalizedPowerOfAttorneyTracking.g.cs
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
  public class FormalizedPowerOfAttorneyTracking :
    global::Sungero.Docflow.Client.PowerOfAttorneyBaseTracking, global::Sungero.Docflow.IFormalizedPowerOfAttorneyTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("14c63ddd-aa2e-43c3-9a3b-f5e6a73a1858");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.FormalizedPowerOfAttorneyTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IFormalizedPowerOfAttorneyTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IFormalizedPowerOfAttorneyTrackingState State
    {
      get
      {
        return (global::Sungero.Docflow.IFormalizedPowerOfAttorneyTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.FormalizedPowerOfAttorneyTrackingState(this);
    }

    public new global::Sungero.Docflow.IFormalizedPowerOfAttorneyTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IFormalizedPowerOfAttorneyTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public FormalizedPowerOfAttorneyTracking()
    {








    }

    #endregion

  }
}
