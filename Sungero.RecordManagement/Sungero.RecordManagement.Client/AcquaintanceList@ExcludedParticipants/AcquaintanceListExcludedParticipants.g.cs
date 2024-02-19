
// ==================================================================
// AcquaintanceListExcludedParticipants.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class AcquaintanceListExcludedParticipants :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0f1e26fd-415a-4f74-a806-3bd76afb7fca");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.AcquaintanceListExcludedParticipants.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceListExcludedParticipants, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceListExcludedParticipantsState(this);
    }

    public new global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IAcquaintanceList> _AcquaintanceList;

    public global::Sungero.RecordManagement.IAcquaintanceList AcquaintanceList
    {
      get { return this._AcquaintanceList.Value; }
      set { this._AcquaintanceList.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AcquaintanceList; }
      set { this.AcquaintanceList = (global::Sungero.RecordManagement.IAcquaintanceList)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IRecipient> _ExcludedParticipant;

              public virtual global::Sungero.CoreEntities.IRecipient ExcludedParticipant
              {
              get
              {
                return this._ExcludedParticipant.Value as global::Sungero.CoreEntities.IRecipient;
              }

              set
              {
                (this._ExcludedParticipant as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ExcludedParticipantChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.AcquaintanceListExcludedParticipantsExcludedParticipantChangedEventArgs(this.State.Properties.ExcludedParticipant, this.ExcludedParticipant, this);
     ((global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsSharedHandlers)this.SharedHandlers).ExcludedParticipantsExcludedParticipantChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient ExcludedParticipantValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.RecordManagement.Client.AcquaintanceListExcludedParticipantsExcludedParticipantValueInputEventArgs(this.ExcludedParticipant, value, this, this.Info.Properties.ExcludedParticipant);
    ((global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsClientHandlers)this.Handlers).ExcludedParticipantsExcludedParticipantValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitExcludedParticipantNavigationProperty()
              {
                this._ExcludedParticipant = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IRecipient>("ExcludedParticipant", this);
                this._ExcludedParticipant.ValueChanged += (sender, e) => { this.ExcludedParticipantChangedHandler(); };
                this.AddProperty(this._ExcludedParticipant as global::Sungero.Domain.Client.IProperty);
              }




    public AcquaintanceListExcludedParticipants()
    {
      this._AcquaintanceList = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IAcquaintanceList>("AcquaintanceList", this, true);


            this.InitExcludedParticipantNavigationProperty();








    }

    #endregion

  }
}
