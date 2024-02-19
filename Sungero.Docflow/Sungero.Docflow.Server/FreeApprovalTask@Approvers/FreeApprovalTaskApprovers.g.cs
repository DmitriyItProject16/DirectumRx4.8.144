
// ==================================================================
// FreeApprovalTaskApprovers.g.cs
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
  public class FreeApprovalTaskApproversFilterForApprover<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.Docflow.IFreeApprovalTaskApprovers
    where TRootEntity : class, global::Sungero.Docflow.IFreeApprovalTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalTaskApproversApproverPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("ApproversApproverFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.FreeApprovalTaskApproversApproverPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ApproversApproverFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public FreeApprovalTaskApproversFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class FreeApprovalTaskApproversSearchFilterForApprover<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.FreeApprovalTaskApproversApproverSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("ApproversApproverSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.FreeApprovalTaskApproversApproverSearchPropertyFilteringServerHandler<TQueryEntity>().ApproversApproverSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public FreeApprovalTaskApproversSearchFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.FreeApprovalTaskApproversFilterForApprover<global::Sungero.CoreEntities.IRecipient, global::Sungero.Docflow.IFreeApprovalTaskApprovers, global::Sungero.Docflow.IFreeApprovalTask>), "Approver")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.FreeApprovalTaskApproversSearchFilterForApprover<global::Sungero.CoreEntities.IRecipient>), "Approver")]


  public class FreeApprovalTaskApprovers :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IFreeApprovalTaskApprovers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("14eba997-b59e-4384-9ac7-a53468399b19");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.FreeApprovalTaskApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IFreeApprovalTaskApprovers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalTaskApproversState State
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTaskApproversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalTaskApproversState(this);
    }

    public new virtual global::Sungero.Docflow.IFreeApprovalTaskApproversInfo Info
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTaskApproversInfo)base.Info; }
    }


    public global::Sungero.Docflow.IFreeApprovalTask FreeApprovalTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.FreeApprovalTask; }
      set { this.FreeApprovalTask = (global::Sungero.Docflow.IFreeApprovalTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.FreeApprovalTaskApproversSharedHandlers(this);
    }







    private global::Sungero.CoreEntities.IRecipient _Approver;
    public virtual global::Sungero.CoreEntities.IRecipient Approver
    {
      get
      {
        return this._Approver;
      }

      set
      {
        this.SetPropertyValue("Approver", this._Approver, value, (propertyValue) => { this._Approver = propertyValue; }, this.ApproverChangedHandler);
      }
    }




    #region Framework events

    protected void ApproverChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.FreeApprovalTaskApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.IFreeApprovalTaskApproversSharedHandlers)this.SharedHandlers).ApproversApproverChanged(args);
    }



    #endregion


    public FreeApprovalTaskApprovers()
    {
    }

  }
}

// ==================================================================
// FreeApprovalTaskApproversHandlers.g.cs
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
  public partial class FreeApprovalTaskApproversApproverPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.Docflow.IFreeApprovalTaskApprovers _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTaskApprovers)this.Entity; }
    }

    private global::Sungero.Docflow.IFreeApprovalTask _root
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTask)this.Root; }
    }

    public FreeApprovalTaskApproversApproverPropertyFilteringServerHandler(global::Sungero.Docflow.IFreeApprovalTaskApprovers entity, global::Sungero.Docflow.IFreeApprovalTask root)
      : base(entity, root)
    {
    }
  }

  public partial class FreeApprovalTaskApproversApproverSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ApproversApproverSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public FreeApprovalTaskApproversApproverSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// FreeApprovalTaskApproversEventArgs.g.cs
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
