
// ==================================================================
// ApprovalSigningAssignmentCollapsedStagesTypesSig.g.cs
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
  public class ApprovalSigningAssignmentCollapsedStagesTypesSig :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSig
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("970a3e40-2343-4cc7-98a6-7db27370ec13");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalSigningAssignmentCollapsedStagesTypesSig.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSig, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalSigningAssignmentCollapsedStagesTypesSigState(this);
    }

    public new global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalSigningAssignment> _ApprovalSigningAssignment;

    public global::Sungero.Docflow.IApprovalSigningAssignment ApprovalSigningAssignment
    {
      get { return this._ApprovalSigningAssignment.Value; }
      set { this._ApprovalSigningAssignment.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalSigningAssignment; }
      set { this.ApprovalSigningAssignment = (global::Sungero.Docflow.IApprovalSigningAssignment)value; }
    }

        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _StageType;

        public virtual global::Sungero.Core.Enumeration? StageType
        {
          get { return this._StageType.Value; }
          set { this._StageType.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _StageTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.ApprovalSigningAssignmentCollapsedStagesTypesSig.StageType),
          typeof(global::Sungero.Docflow.Client.ApprovalSigningAssignmentCollapsedStagesTypesSig),
          "StageType");

        public static global::Sungero.Domain.Shared.EnumerationItems StageTypeItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalSigningAssignmentCollapsedStagesTypesSig._StageTypeItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems StageTypeAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalSigningAssignmentCollapsedStagesTypesSig.StageTypeItems; }
        }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalSigningAssignmentCollapsedStagesTypesSigClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalSigningAssignmentCollapsedStagesTypesSigSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void StageTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.StageType, this.StageType, this);
     ((global::Sungero.Docflow.IApprovalSigningAssignmentCollapsedStagesTypesSigSharedHandlers)this.SharedHandlers).CollapsedStagesTypesSigStageTypeChanged(args);
    }



  protected global::Sungero.Core.Enumeration? StageTypeValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.StageType, value, this, this.Info.Properties.StageType);
    ((global::Sungero.Docflow.ApprovalSigningAssignmentCollapsedStagesTypesSigClientHandlers)this.Handlers).CollapsedStagesTypesSigStageTypeValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> StageTypeFilteringHandler()
  {
    return ((global::Sungero.Docflow.ApprovalSigningAssignmentCollapsedStagesTypesSigClientHandlers)this.Handlers).CollapsedStagesTypesSigStageTypeFiltering(this.StageTypeAllowedItems);
  }


    #endregion

    #region Constructors



    public ApprovalSigningAssignmentCollapsedStagesTypesSig()
    {
      this._ApprovalSigningAssignment = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalSigningAssignment>("ApprovalSigningAssignment", this, true);

            this._StageType = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("StageType", this);
            this._StageType.ValueChanged += (sender, e) => { this.StageTypeChangedHandler(); };
            this.AddProperty(this._StageType);








    }

    #endregion

  }
}
