
// ==================================================================
// PowerOfAttorneyRevocationVersions.g.cs
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


  public class PowerOfAttorneyRevocationVersions :
    global::Sungero.Docflow.Server.InternalDocumentBaseVersions, global::Sungero.Docflow.IPowerOfAttorneyRevocationVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("3e2d6149-3948-4ccc-9984-19f7e352265d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.PowerOfAttorneyRevocationVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IPowerOfAttorneyRevocationVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsState State
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyRevocationVersionsState(this);
    }

    public new virtual global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsInfo Info
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyRevocationVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public PowerOfAttorneyRevocationVersions()
    {
    }

  }
}

// ==================================================================
// PowerOfAttorneyRevocationVersionsHandlers.g.cs
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
// PowerOfAttorneyRevocationVersionsEventArgs.g.cs
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
