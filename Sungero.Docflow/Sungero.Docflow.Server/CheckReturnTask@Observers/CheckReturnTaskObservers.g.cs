
// ==================================================================
// CheckReturnTaskObservers.g.cs
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


  public class CheckReturnTaskObservers :
    global::Sungero.Workflow.Server.TaskObservers, global::Sungero.Docflow.ICheckReturnTaskObservers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1716f04c-7b1c-4aca-a2ae-46c84f99888b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.CheckReturnTaskObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ICheckReturnTaskObservers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.ICheckReturnTaskObserversState State
    {
      get { return (global::Sungero.Docflow.ICheckReturnTaskObserversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.CheckReturnTaskObserversState(this);
    }

    public new virtual global::Sungero.Docflow.ICheckReturnTaskObserversInfo Info
    {
      get { return (global::Sungero.Docflow.ICheckReturnTaskObserversInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public CheckReturnTaskObservers()
    {
    }

  }
}

// ==================================================================
// CheckReturnTaskObserversHandlers.g.cs
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
// CheckReturnTaskObserversEventArgs.g.cs
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
