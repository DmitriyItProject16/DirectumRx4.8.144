
// ==================================================================
// ApprovalConvertPdfStage.g.cs
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
  public class ApprovalConvertPdfStage :
    global::Sungero.Docflow.Client.ApprovalFunctionStageBase, global::Sungero.Docflow.IApprovalConvertPdfStage
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("77fe4545-9220-4cde-9cf7-a254d28b3ba5");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalConvertPdfStage.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalConvertPdfStage, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Name; }
        set { this.Name = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.Docflow.IApprovalConvertPdfStageState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalConvertPdfStageState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalConvertPdfStageState(this);
    }

    public new global::Sungero.Docflow.IApprovalConvertPdfStageInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalConvertPdfStageInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IApprovalConvertPdfStageAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalConvertPdfStageAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ApprovalConvertPdfStageAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _ConvertWithAddenda;

        public virtual global::System.Boolean? ConvertWithAddenda
        {
          get { return this._ConvertWithAddenda.Value; }
          set { this._ConvertWithAddenda.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalConvertPdfStageActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalConvertPdfStageCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalConvertPdfStageAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalConvertPdfStageAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ApprovalConvertPdfStageFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalConvertPdfStageFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalConvertPdfStageClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalConvertPdfStageSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ConvertWithAddendaChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.ConvertWithAddenda, this.ConvertWithAddenda, this);
     ((global::Sungero.Docflow.IApprovalConvertPdfStageSharedHandlers)this.SharedHandlers).ConvertWithAddendaChanged(args);
    }



  protected global::System.Boolean? ConvertWithAddendaValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.ConvertWithAddenda, value, this, this.Info.Properties.ConvertWithAddenda);
    ((global::Sungero.Docflow.ApprovalConvertPdfStageClientHandlers)this.Handlers).ConvertWithAddendaValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public ApprovalConvertPdfStage()
    {
            this._ConvertWithAddenda = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("ConvertWithAddenda", this);
            this._ConvertWithAddenda.ValueChanged += (sender, e) => { this.ConvertWithAddendaChangedHandler(); };
            this.AddProperty(this._ConvertWithAddenda);








    }

    #endregion

  }
}

// ==================================================================
// ApprovalConvertPdfStagePresenter.g.cs
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
  public class ApprovalConvertPdfStagePresenter<T> :
    global::Sungero.Docflow.Client.ApprovalFunctionStageBasePresenter<T>
    where T : class, global::Sungero.Docflow.IApprovalConvertPdfStage
  {
    #region Fields and properties




    #endregion

    #region Methods


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion



    #region Constructors

    private void Init()
    {

    }

    public ApprovalConvertPdfStagePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalConvertPdfStageCollectionPresenter.g.cs
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
  public class ApprovalConvertPdfStageCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.ApprovalFunctionStageBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IApprovalConvertPdfStage
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalConvertPdfStageCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalConvertPdfStageCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalConvertPdfStageCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalConvertPdfStageCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalConvertPdfStageRepositoryImplementer.g.cs
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
  public class ApprovalConvertPdfStageRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.ApprovalFunctionStageBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalConvertPdfStageRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalConvertPdfStage
    {
       public new global::Sungero.Docflow.IApprovalConvertPdfStageAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalConvertPdfStageAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalConvertPdfStageInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalConvertPdfStageInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ApprovalConvertPdfStageTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalConvertPdfStageAccessRights.g.cs
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
  public class ApprovalConvertPdfStageAccessRights : 
    Sungero.Docflow.Client.ApprovalFunctionStageBaseAccessRights, Sungero.Docflow.IApprovalConvertPdfStageAccessRights
  {

    public ApprovalConvertPdfStageAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalConvertPdfStageTypeAccessRights : 
    Sungero.Docflow.Client.ApprovalFunctionStageBaseTypeAccessRights, Sungero.Docflow.IApprovalConvertPdfStageAccessRights
  {

    public ApprovalConvertPdfStageTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
