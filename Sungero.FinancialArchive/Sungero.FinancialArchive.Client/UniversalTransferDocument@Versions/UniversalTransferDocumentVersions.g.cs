
// ==================================================================
// UniversalTransferDocumentVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public class UniversalTransferDocumentVersions :
    global::Sungero.Docflow.Client.AccountingDocumentBaseVersions, global::Sungero.FinancialArchive.IUniversalTransferDocumentVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("7f57a617-9c0e-412e-8dcf-920360cc8976");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Client.UniversalTransferDocumentVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IUniversalTransferDocumentVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.FinancialArchive.IUniversalTransferDocumentVersionsState State
    {
      get
      {
        return (global::Sungero.FinancialArchive.IUniversalTransferDocumentVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.UniversalTransferDocumentVersionsState(this);
    }

    public new global::Sungero.FinancialArchive.IUniversalTransferDocumentVersionsInfo Info
    {
      get
      {
        return (global::Sungero.FinancialArchive.IUniversalTransferDocumentVersionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public UniversalTransferDocumentVersions()
    {








    }

    #endregion

  }
}