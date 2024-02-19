
// ==================================================================
// ContractsApprovalRuleConditions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractsApprovalRuleConditions :
    global::Sungero.Docflow.Client.ApprovalRuleBaseConditions, global::Sungero.Contracts.IContractsApprovalRuleConditions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("421977df-8d98-4833-ad4e-a97214c8660b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.ContractsApprovalRuleConditions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractsApprovalRuleConditions, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Condition == null ? string.Empty : this.Condition.ToString(); }
        set { throw new global::System.NotSupportedException(global::CommonLibrary.Properties.Resources.SpecifiedPropertyIsNotSupportedFormat("DisplayValue")); }
      }

      public override string DisplayPropertyName
      {
        get { return "Condition"; }
      }


    public new global::Sungero.Contracts.IContractsApprovalRuleConditionsState State
    {
      get
      {
        return (global::Sungero.Contracts.IContractsApprovalRuleConditionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleConditionsState(this);
    }

    public new global::Sungero.Contracts.IContractsApprovalRuleConditionsInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.IContractsApprovalRuleConditionsInfo)base.Info;
      }
    }





              public new virtual global::Sungero.Contracts.IContractCondition Condition
              {
              get
              {
                return this._Condition.Value as global::Sungero.Contracts.IContractCondition;
              }

              set
              {
                (this._Condition as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors



              protected override void InitConditionNavigationProperty()
              {
                this._Condition = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Contracts.IContractCondition>("Condition", this);
                this._Condition.ValueChanged += (sender, e) => { this.ConditionChangedHandler(); };
                this.AddProperty(this._Condition as global::Sungero.Domain.Client.IProperty);
              }





    public ContractsApprovalRuleConditions()
    {








    }

    #endregion

  }
}