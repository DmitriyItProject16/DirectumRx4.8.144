
// ==================================================================
// ContractsApprovalRuleStages.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Server
{


  public class ContractsApprovalRuleStages :
    global::Sungero.Docflow.Server.ApprovalRuleBaseStages, global::Sungero.Contracts.IContractsApprovalRuleStages
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ea6de446-e4d2-4ae0-97f1-2cba6e7b0424");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ContractsApprovalRuleStages.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractsApprovalRuleStages, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.StageBase == null ? string.Empty : this.StageBase.ToString(); }
      set { throw new global::System.NotSupportedException(global::CommonLibrary.Properties.Resources.SpecifiedPropertyIsNotSupportedFormat("DisplayValue")); }
    }

    public new virtual global::Sungero.Contracts.IContractsApprovalRuleStagesState State
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleStagesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleStagesState(this);
    }

    public new virtual global::Sungero.Contracts.IContractsApprovalRuleStagesInfo Info
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleStagesInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ContractsApprovalRuleStages()
    {
    }

  }
}

// ==================================================================
// ContractsApprovalRuleStagesHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts
{

}

// ==================================================================
// ContractsApprovalRuleStagesEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Server
{
}
