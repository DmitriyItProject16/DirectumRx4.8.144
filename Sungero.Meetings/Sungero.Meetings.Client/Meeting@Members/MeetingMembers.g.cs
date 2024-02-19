
// ==================================================================
// MeetingMembers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Client
{
  public class MeetingMembers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Meetings.IMeetingMembers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c6d29374-7baa-4442-96dc-b13aa3ff42b8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Meetings.Client.MeetingMembers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Meetings.IMeetingMembers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Meetings.IMeetingMembersState State
    {
      get
      {
        return (global::Sungero.Meetings.IMeetingMembersState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Meetings.Shared.MeetingMembersState(this);
    }

    public new global::Sungero.Meetings.IMeetingMembersInfo Info
    {
      get
      {
        return (global::Sungero.Meetings.IMeetingMembersInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Meetings.IMeeting> _Meeting;

    public global::Sungero.Meetings.IMeeting Meeting
    {
      get { return this._Meeting.Value; }
      set { this._Meeting.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.Meeting; }
      set { this.Meeting = (global::Sungero.Meetings.IMeeting)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IRecipient> _Member;

              public virtual global::Sungero.CoreEntities.IRecipient Member
              {
              get
              {
                return this._Member.Value as global::Sungero.CoreEntities.IRecipient;
              }

              set
              {
                (this._Member as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Meetings.MeetingMembersClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Meetings.MeetingMembersSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void MemberChangedHandler()
    {
      var args = new global::Sungero.Meetings.Shared.MeetingMembersMemberChangedEventArgs(this.State.Properties.Member, this.Member, this);
     ((global::Sungero.Meetings.IMeetingMembersSharedHandlers)this.SharedHandlers).MembersMemberChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient MemberValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.Meetings.Client.MeetingMembersMemberValueInputEventArgs(this.Member, value, this, this.Info.Properties.Member);
    ((global::Sungero.Meetings.MeetingMembersClientHandlers)this.Handlers).MembersMemberValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitMemberNavigationProperty()
              {
                this._Member = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IRecipient>("Member", this);
                this._Member.ValueChanged += (sender, e) => { this.MemberChangedHandler(); };
                this.AddProperty(this._Member as global::Sungero.Domain.Client.IProperty);
              }




    public MeetingMembers()
    {
      this._Meeting = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Meetings.IMeeting>("Meeting", this, true);


            this.InitMemberNavigationProperty();








    }

    #endregion

  }
}
