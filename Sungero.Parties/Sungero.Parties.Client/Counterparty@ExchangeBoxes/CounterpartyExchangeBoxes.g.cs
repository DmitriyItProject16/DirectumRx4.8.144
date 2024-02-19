
// ==================================================================
// CounterpartyExchangeBoxes.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class CounterpartyExchangeBoxes :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Parties.ICounterpartyExchangeBoxes
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("fafa1803-bcd1-4b88-9e07-eb6f1ec341c6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Client.CounterpartyExchangeBoxes.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Parties.ICounterpartyExchangeBoxes, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Parties.ICounterpartyExchangeBoxesState State
    {
      get
      {
        return (global::Sungero.Parties.ICounterpartyExchangeBoxesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.CounterpartyExchangeBoxesState(this);
    }

    public new global::Sungero.Parties.ICounterpartyExchangeBoxesInfo Info
    {
      get
      {
        return (global::Sungero.Parties.ICounterpartyExchangeBoxesInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.ICounterparty> _Counterparty;

    public global::Sungero.Parties.ICounterparty Counterparty
    {
      get { return this._Counterparty.Value; }
      set { this._Counterparty.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.Counterparty; }
      set { this.Counterparty = (global::Sungero.Parties.ICounterparty)value; }
    }

        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _Status;

        public virtual global::Sungero.Core.Enumeration? Status
        {
          get { return this._Status.Value; }
          set { this._Status.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _OrganizationId;

        public virtual global::System.String OrganizationId
        {
          get { return this._OrganizationId.Value; }
          set { this._OrganizationId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _InvitationText;

        public virtual global::System.String InvitationText
        {
          get { return this._InvitationText.Value; }
          set { this._InvitationText.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsDefault;

        public virtual global::System.Boolean? IsDefault
        {
          get { return this._IsDefault.Value; }
          set { this._IsDefault.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _CounterpartyBox;

        public virtual global::System.String CounterpartyBox
        {
          get { return this._CounterpartyBox.Value; }
          set { this._CounterpartyBox.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsRoaming;

        public virtual global::System.Boolean? IsRoaming
        {
          get { return this._IsRoaming.Value; }
          set { this._IsRoaming.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _FtsId;

        public virtual global::System.String FtsId
        {
          get { return this._FtsId.Value; }
          set { this._FtsId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _CounterpartyBranchId;

        public virtual global::System.String CounterpartyBranchId
        {
          get { return this._CounterpartyBranchId.Value; }
          set { this._CounterpartyBranchId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _CounterpartyParentBranchId;

        public virtual global::System.String CounterpartyParentBranchId
        {
          get { return this._CounterpartyParentBranchId.Value; }
          set { this._CounterpartyParentBranchId.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _StatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Parties.CounterpartyExchangeBoxes.Status),
          typeof(global::Sungero.Parties.Client.CounterpartyExchangeBoxes),
          "Status");

        public static global::Sungero.Domain.Shared.EnumerationItems StatusItems
        {
          get { return global::Sungero.Parties.Client.CounterpartyExchangeBoxes._StatusItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems StatusAllowedItems
        {
          get { return global::Sungero.Parties.Client.CounterpartyExchangeBoxes.StatusItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox> _Box;

              public virtual global::Sungero.ExchangeCore.IBusinessUnitBox Box
              {
              get
              {
                return this._Box.Value as global::Sungero.ExchangeCore.IBusinessUnitBox;
              }

              set
              {
                (this._Box as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Parties.CounterpartyExchangeBoxesSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void BoxChangedHandler()
    {
      var args = new global::Sungero.Parties.Shared.CounterpartyExchangeBoxesBoxChangedEventArgs(this.State.Properties.Box, this.Box, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesBoxChanged(args);
    }

    protected void StatusChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Status, this.Status, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesStatusChanged(args);
    }

    protected void OrganizationIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.OrganizationId, this.OrganizationId, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesOrganizationIdChanged(args);
    }

    protected void InvitationTextChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.InvitationText, this.InvitationText, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesInvitationTextChanged(args);
    }

    protected void IsDefaultChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsDefault, this.IsDefault, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesIsDefaultChanged(args);
    }

    protected void CounterpartyBoxChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CounterpartyBox, this.CounterpartyBox, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesCounterpartyBoxChanged(args);
    }

    protected void IsRoamingChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsRoaming, this.IsRoaming, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesIsRoamingChanged(args);
    }

    protected void FtsIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FtsId, this.FtsId, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesFtsIdChanged(args);
    }

    protected void CounterpartyBranchIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CounterpartyBranchId, this.CounterpartyBranchId, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesCounterpartyBranchIdChanged(args);
    }

    protected void CounterpartyParentBranchIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CounterpartyParentBranchId, this.CounterpartyParentBranchId, this);
     ((global::Sungero.Parties.ICounterpartyExchangeBoxesSharedHandlers)this.SharedHandlers).ExchangeBoxesCounterpartyParentBranchIdChanged(args);
    }



  protected global::Sungero.ExchangeCore.IBusinessUnitBox BoxValueInputHandler(global::Sungero.ExchangeCore.IBusinessUnitBox value)
  {
    var args = new global::Sungero.Parties.Client.CounterpartyExchangeBoxesBoxValueInputEventArgs(this.Box, value, this, this.Info.Properties.Box);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesBoxValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? StatusValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.Status, value, this, this.Info.Properties.Status);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesStatusValueInput(args);
    return args.NewValue;
  }

  protected global::System.String OrganizationIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.OrganizationId, value, this, this.Info.Properties.OrganizationId);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesOrganizationIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String InvitationTextValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.InvitationText, value, this, this.Info.Properties.InvitationText);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesInvitationTextValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsDefaultValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsDefault, value, this, this.Info.Properties.IsDefault);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesIsDefaultValueInput(args);
    return args.NewValue;
  }

  protected global::System.String CounterpartyBoxValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.CounterpartyBox, value, this, this.Info.Properties.CounterpartyBox);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesCounterpartyBoxValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsRoamingValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsRoaming, value, this, this.Info.Properties.IsRoaming);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesIsRoamingValueInput(args);
    return args.NewValue;
  }

  protected global::System.String FtsIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.FtsId, value, this, this.Info.Properties.FtsId);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesFtsIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String CounterpartyBranchIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.CounterpartyBranchId, value, this, this.Info.Properties.CounterpartyBranchId);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesCounterpartyBranchIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String CounterpartyParentBranchIdValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.CounterpartyParentBranchId, value, this, this.Info.Properties.CounterpartyParentBranchId);
    ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesCounterpartyParentBranchIdValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> StatusFilteringHandler()
  {
    return ((global::Sungero.Parties.CounterpartyExchangeBoxesClientHandlers)this.Handlers).ExchangeBoxesStatusFiltering(this.StatusAllowedItems);
  }










    #endregion

    #region Constructors



              protected virtual void InitBoxNavigationProperty()
              {
                this._Box = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.ExchangeCore.IBusinessUnitBox>("Box", this);
                this._Box.ValueChanged += (sender, e) => { this.BoxChangedHandler(); };
                this.AddProperty(this._Box as global::Sungero.Domain.Client.IProperty);
              }




    public CounterpartyExchangeBoxes()
    {
      this._Counterparty = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.ICounterparty>("Counterparty", this, true);

            this._Status = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("Status", this);
            this._Status.ValueChanged += (sender, e) => { this.StatusChangedHandler(); };
            this.AddProperty(this._Status);

            this._OrganizationId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("OrganizationId", this);
            this._OrganizationId.ValueChanged += (sender, e) => { this.OrganizationIdChangedHandler(); };
            this.AddProperty(this._OrganizationId);

            this._InvitationText = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("InvitationText", this);
            this._InvitationText.ValueChanged += (sender, e) => { this.InvitationTextChangedHandler(); };
            this.AddProperty(this._InvitationText);

            this._IsDefault = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsDefault", this);
            this._IsDefault.ValueChanged += (sender, e) => { this.IsDefaultChangedHandler(); };
            this.AddProperty(this._IsDefault);

            this._CounterpartyBox = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("CounterpartyBox", this);
            this._CounterpartyBox.ValueChanged += (sender, e) => { this.CounterpartyBoxChangedHandler(); };
            this.AddProperty(this._CounterpartyBox);

            this._IsRoaming = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsRoaming", this);
            this._IsRoaming.ValueChanged += (sender, e) => { this.IsRoamingChangedHandler(); };
            this.AddProperty(this._IsRoaming);

            this._FtsId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("FtsId", this);
            this._FtsId.ValueChanged += (sender, e) => { this.FtsIdChangedHandler(); };
            this.AddProperty(this._FtsId);

            this._CounterpartyBranchId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("CounterpartyBranchId", this);
            this._CounterpartyBranchId.ValueChanged += (sender, e) => { this.CounterpartyBranchIdChangedHandler(); };
            this.AddProperty(this._CounterpartyBranchId);

            this._CounterpartyParentBranchId = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("CounterpartyParentBranchId", this);
            this._CounterpartyParentBranchId.ValueChanged += (sender, e) => { this.CounterpartyParentBranchIdChangedHandler(); };
            this.AddProperty(this._CounterpartyParentBranchId);

            this.InitBoxNavigationProperty();








    }

    #endregion

  }
}
