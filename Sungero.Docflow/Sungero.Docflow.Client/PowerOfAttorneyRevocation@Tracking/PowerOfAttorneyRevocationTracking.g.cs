
// ==================================================================
// PowerOfAttorneyRevocationTracking.g.cs
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
  public class PowerOfAttorneyRevocationTracking :
    global::Sungero.Docflow.Client.InternalDocumentBaseTracking, global::Sungero.Docflow.IPowerOfAttorneyRevocationTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e8ec9b10-bf60-4d4d-a0da-bf2c9cc70d27");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.PowerOfAttorneyRevocationTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IPowerOfAttorneyRevocationTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyRevocationTrackingState State
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyRevocationTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyRevocationTrackingState(this);
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyRevocationTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyRevocationTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public PowerOfAttorneyRevocationTracking()
    {








    }

    #endregion

  }
}