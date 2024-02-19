
// ==================================================================
// ApprovalRuleBaseConditions.g.cs
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
  public class ApprovalRuleBaseConditionsFilterForCondition<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IConditionBase
    where TSourceEntity : class, global::Sungero.Docflow.IApprovalRuleBaseConditions
    where TRootEntity : class, global::Sungero.Docflow.IApprovalRuleBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalRuleBaseConditionsConditionPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("ConditionsConditionFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ApprovalRuleBaseConditionsConditionPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ConditionsConditionFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalRuleBaseConditionsFilterForCondition(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ApprovalRuleBaseConditionsSearchFilterForCondition<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IConditionBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalRuleBaseConditionsConditionSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("ConditionsConditionSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ApprovalRuleBaseConditionsConditionSearchPropertyFilteringServerHandler<TQueryEntity>().ConditionsConditionSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalRuleBaseConditionsSearchFilterForCondition(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalRuleBaseConditionsFilterForCondition<global::Sungero.Docflow.IConditionBase, global::Sungero.Docflow.IApprovalRuleBaseConditions, global::Sungero.Docflow.IApprovalRuleBase>), "Condition")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalRuleBaseConditionsSearchFilterForCondition<global::Sungero.Docflow.IConditionBase>), "Condition")]


  public class ApprovalRuleBaseConditions :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalRuleBaseConditions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("924782de-a0ae-4b4c-aabe-2447acc39598");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalRuleBaseConditions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRuleBaseConditions, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Condition == null ? string.Empty : this.Condition.ToString(); }
      set { throw new global::System.NotSupportedException(global::CommonLibrary.Properties.Resources.SpecifiedPropertyIsNotSupportedFormat("DisplayValue")); }
    }

    public new virtual global::Sungero.Docflow.IApprovalRuleBaseConditionsState State
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseConditionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBaseConditionsState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalRuleBaseConditionsInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseConditionsInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalRuleBase ApprovalRuleBase { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalRuleBase; }
      set { this.ApprovalRuleBase = (global::Sungero.Docflow.IApprovalRuleBase)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleBaseConditionsSharedHandlers(this);
    }

    private global::System.Int32? _Number;
    public virtual global::System.Int32? Number
    {
      get
      {
        return this._Number;
      }

      set
      {
        this.SetPropertyValue("Number", this._Number, value, (propertyValue) => { this._Number = propertyValue; }, this.NumberChangedHandler);
      }
    }







    private global::Sungero.Docflow.IConditionBase _Condition;
    public virtual global::Sungero.Docflow.IConditionBase Condition
    {
      get
      {
        return this._Condition;
      }

      set
      {
        this.SetPropertyValue("Condition", this._Condition, value, (propertyValue) => { this._Condition = propertyValue; }, this.ConditionChangedHandler);
      }
    }




    #region Framework events

    protected void NumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Number, this.Number, this);
     ((global::Sungero.Docflow.IApprovalRuleBaseConditionsSharedHandlers)this.SharedHandlers).ConditionsNumberChanged(args);
    }

    protected void ConditionChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalRuleBaseConditionsConditionChangedEventArgs(this.State.Properties.Condition, this.Condition, this);
     ((global::Sungero.Docflow.IApprovalRuleBaseConditionsSharedHandlers)this.SharedHandlers).ConditionsConditionChanged(args);
    }



    #endregion


    public ApprovalRuleBaseConditions()
    {
    }

  }
}

// ==================================================================
// ApprovalRuleBaseConditionsHandlers.g.cs
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
  public partial class ApprovalRuleBaseConditionsConditionPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IConditionBase
  {
    private global::Sungero.Docflow.IApprovalRuleBaseConditions _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseConditions)this.Entity; }
    }

    private global::Sungero.Docflow.IApprovalRuleBase _root
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBase)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> ConditionsConditionFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalRuleBaseConditionsConditionPropertyFilteringServerHandler(global::Sungero.Docflow.IApprovalRuleBaseConditions entity, global::Sungero.Docflow.IApprovalRuleBase root)
      : base(entity, root)
    {
    }
  }

  public partial class ApprovalRuleBaseConditionsConditionSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IConditionBase
  {

    public virtual global::System.Linq.IQueryable<T> ConditionsConditionSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalRuleBaseConditionsConditionSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ApprovalRuleBaseConditionsEventArgs.g.cs
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
