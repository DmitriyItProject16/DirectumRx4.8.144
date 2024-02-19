
// ==================================================================
// ApprovalIncInvoicePaidStage.g.cs
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
  public class ApprovalIncInvoicePaidStage :
    global::Sungero.Docflow.Client.ApprovalFunctionStageBase, global::Sungero.Contracts.IApprovalIncInvoicePaidStage
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("16aa8863-3f80-486b-be94-069e6f7b4d94");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStage.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IApprovalIncInvoicePaidStage, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Contracts.IApprovalIncInvoicePaidStageState State
    {
      get
      {
        return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ApprovalIncInvoicePaidStageState(this);
    }

    public new global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo)base.Info;
      }
    }

    public new global::Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStageAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStageActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStageCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStageAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStageAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStageFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Contracts.Shared.ApprovalIncInvoicePaidStageFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.ApprovalIncInvoicePaidStageClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.ApprovalIncInvoicePaidStageSharedHandlers(this);
    }

    #endregion

    #region Framework events





    #endregion

    #region Constructors



    public ApprovalIncInvoicePaidStage()
    {








    }

    #endregion

  }
}

// ==================================================================
// ApprovalIncInvoicePaidStagePresenter.g.cs
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
  public class ApprovalIncInvoicePaidStagePresenter<T> :
    global::Sungero.Docflow.Client.ApprovalFunctionStageBasePresenter<T>
    where T : class, global::Sungero.Contracts.IApprovalIncInvoicePaidStage
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

    public ApprovalIncInvoicePaidStagePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalIncInvoicePaidStageCollectionPresenter.g.cs
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
  public class ApprovalIncInvoicePaidStageCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.ApprovalFunctionStageBaseCollectionPresenter<T>
    where T: class, global::Sungero.Contracts.IApprovalIncInvoicePaidStage
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalIncInvoicePaidStageCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalIncInvoicePaidStageCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalIncInvoicePaidStageCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalIncInvoicePaidStageCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalIncInvoicePaidStageRepositoryImplementer.g.cs
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
  public class ApprovalIncInvoicePaidStageRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.ApprovalFunctionStageBaseRepositoryImplementer<T>,
      global::Sungero.Contracts.IApprovalIncInvoicePaidStageRepositoryImplementer<T>
      where T : global::Sungero.Contracts.IApprovalIncInvoicePaidStage
    {
       public new global::Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights AccessRights
       {
          get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo Info
       {
          get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Contracts.Client.ApprovalIncInvoicePaidStageTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalIncInvoicePaidStageAccessRights.g.cs
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
  public class ApprovalIncInvoicePaidStageAccessRights : 
    Sungero.Docflow.Client.ApprovalFunctionStageBaseAccessRights, Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights
  {

    public ApprovalIncInvoicePaidStageAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalIncInvoicePaidStageTypeAccessRights : 
    Sungero.Docflow.Client.ApprovalFunctionStageBaseTypeAccessRights, Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights
  {

    public ApprovalIncInvoicePaidStageTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
