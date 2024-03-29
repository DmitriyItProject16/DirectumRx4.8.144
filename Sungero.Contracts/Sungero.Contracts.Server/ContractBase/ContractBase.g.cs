
// ==================================================================
// ContractBase.g.cs
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
    public class ContractBaseFilter<T> :
      global::Sungero.Contracts.Server.ContractualDocumentFilter<T>
      where T : class, global::Sungero.Contracts.IContractBase
    {
      private global::Sungero.Contracts.IContractBaseFilterState filter
      {
        get
        {
          return (Sungero.Contracts.IContractBaseFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ContractBaseFilter(global::Sungero.Contracts.IContractBaseFilterState filter)
      : base(filter)
      {
      }

      protected ContractBaseFilter()
      {
      }
    }
    public class ContractBaseSearchDialogModel : global::Sungero.Contracts.Server.ContractualDocumentSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.Double? TotalAmount { get; protected set; }
                  public override global::System.Boolean? IsStandard { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.ICounterparty> Counterparty { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> ResponsibleEmployee { get; protected set; }


                  public virtual global::System.Boolean? IsAutomaticRenewal { get; protected set; }
                  public virtual global::System.Boolean? IsFrameworkContract { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentGroupBase> DocumentGroup { get; protected set; }


                   public new ContractBaseVersionsModel Versions { get { return (ContractBaseVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ContractBaseTrackingModel Tracking { get { return (ContractBaseTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ContractBaseMilestonesModel Milestones { get { return (ContractBaseMilestonesModel)base.Milestones; } protected set { base.Milestones = value; } }

        }

      public class ContractBaseVersionsModel : global::Sungero.Contracts.Server.ContractualDocumentVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class ContractBaseTrackingModel : global::Sungero.Contracts.Server.ContractualDocumentTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }
      public class ContractBaseMilestonesModel : global::Sungero.Contracts.Server.ContractualDocumentMilestonesModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }




  public class ContractBaseFilterForDocumentGroup<TQueryEntity, TSourceEntity>
    : global::Sungero.Docflow.Server.OfficialDocumentFilterForDocumentGroup<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentGroupBase
    where TSourceEntity : class, global::Sungero.Contracts.IContractBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.ContractBaseDocumentGroupPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("DocumentGroupFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Contracts.ContractBaseDocumentGroupPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).DocumentGroupFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContractBaseFilterForDocumentGroup(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Contracts.Server.ContractBaseFilter<global::Sungero.Contracts.IContractBase>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Contracts.Server.ContractBaseFilterForDocumentGroup<global::Sungero.Docflow.IDocumentGroupBase, global::Sungero.Contracts.IContractBase>), "DocumentGroup")]


  public class ContractBase :
    global::Sungero.Contracts.Server.ContractualDocument, global::Sungero.Contracts.IContractBase, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("306da7fa-dc27-437c-bb83-42c92436b7e2");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ContractBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractBase, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Contracts.IContractBaseState State
    {
      get { return (global::Sungero.Contracts.IContractBaseState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractBaseState(this);
    }

    public new virtual global::Sungero.Contracts.IContractBaseInfo Info
    {
      get { return (global::Sungero.Contracts.IContractBaseInfo)base.Info; }
    }

    public new virtual global::Sungero.Contracts.IContractBaseAccessRights AccessRights
    {
      get { return (global::Sungero.Contracts.IContractBaseAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Contracts.Server.ContractBaseAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Contracts.Server.ContractBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Contracts.Shared.ContractBaseFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.ContractBaseServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.ContractBaseSharedHandlers(this);
    }

    private global::System.Boolean? _IsAutomaticRenewal;
    public virtual global::System.Boolean? IsAutomaticRenewal
    {
      get
      {
        return this._IsAutomaticRenewal;
      }

      set
      {
        this.SetPropertyValue("IsAutomaticRenewal", this._IsAutomaticRenewal, value, (propertyValue) => { this._IsAutomaticRenewal = propertyValue; }, this.IsAutomaticRenewalChangedHandler);
      }
    }
    private global::System.Int32? _DaysToFinishWorks;
    public virtual global::System.Int32? DaysToFinishWorks
    {
      get
      {
        return this._DaysToFinishWorks;
      }

      set
      {
        this.SetPropertyValue("DaysToFinishWorks", this._DaysToFinishWorks, value, (propertyValue) => { this._DaysToFinishWorks = propertyValue; }, this.DaysToFinishWorksChangedHandler);
      }
    }
    private global::System.Boolean? _IsFrameworkContract;
    public virtual global::System.Boolean? IsFrameworkContract
    {
      get
      {
        return this._IsFrameworkContract;
      }

      set
      {
        this.SetPropertyValue("IsFrameworkContract", this._IsFrameworkContract, value, (propertyValue) => { this._IsFrameworkContract = propertyValue; }, this.IsFrameworkContractChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _LifeCycleStateItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Contracts.Server.ContractualDocument.LifeCycleStateItems,
      typeof(global::Sungero.Contracts.ContractBase.LifeCycleState),
      typeof(global::Sungero.Contracts.Server.ContractBase),
      "LifeCycleState");

    public static new global::Sungero.Domain.Shared.EnumerationItems LifeCycleStateItems
    {
      get { return global::Sungero.Contracts.Server.ContractBase._LifeCycleStateItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems LifeCycleStateAllowedItems
    {
      get { return global::Sungero.Contracts.Server.ContractBase.LifeCycleStateItems; }
    }





    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Contracts.IContractBaseVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Contracts.IContractBaseTracking>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Contracts.IContractualDocumentMilestones> CreateMilestonesCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Contracts.IContractBaseStages>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Contracts.ContractBaseCreatingFromServerHandler", new object[] { (global::Sungero.Contracts.IContractBase)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Contracts.ContractBaseCreatingFromServerHandler((global::Sungero.Contracts.IContractBase)entitySource, this.Info);
    }

    #region Framework events

    protected void IsAutomaticRenewalChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsAutomaticRenewal, this.IsAutomaticRenewal, this);
     ((global::Sungero.Contracts.IContractBaseSharedHandlers)this.SharedHandlers).IsAutomaticRenewalChanged(args);
    }

    protected void DaysToFinishWorksChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DaysToFinishWorks, this.DaysToFinishWorks, this);
     ((global::Sungero.Contracts.IContractBaseSharedHandlers)this.SharedHandlers).DaysToFinishWorksChanged(args);
    }


    protected void IsFrameworkContractChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsFrameworkContract, this.IsFrameworkContract, this);
     ((global::Sungero.Contracts.IContractBaseSharedHandlers)this.SharedHandlers).IsFrameworkContractChanged(args);
    }






    #endregion


    public ContractBase()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Contracts.ContractBaseConvertingFromServerHandler", (global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityConvertingFromServerHandler)instance;

      return new global::Sungero.Contracts.ContractBaseConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// ContractBaseHandlers.g.cs
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
  public partial class ContractBaseDocumentGroupPropertyFilteringServerHandler<T>
    : global::Sungero.Docflow.OfficialDocumentDocumentGroupPropertyFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IDocumentGroupBase
  {
    private global::Sungero.Contracts.IContractBase _obj
    {
      get { return (global::Sungero.Contracts.IContractBase)this.Entity; }
    }

    public ContractBaseDocumentGroupPropertyFilteringServerHandler(global::Sungero.Contracts.IContractBase entity)
      : base(entity)
    {
    }
  }



  public partial class ContractBaseFilteringServerHandler<T>
    : global::Sungero.Contracts.ContractualDocumentFilteringServerHandler<T>  
    where T : class, global::Sungero.Contracts.IContractBase
  {
    private global::Sungero.Contracts.IContractBaseFilterState _filter
    {
      get
      {
        return (Sungero.Contracts.IContractBaseFilterState)this.Filter;
      }
    }

    public ContractBaseFilteringServerHandler(global::Sungero.Contracts.IContractBaseFilterState filter)
    : base(filter)
    {
    }

    protected ContractBaseFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ContractBaseSearchDialogServerHandler : global::Sungero.Contracts.ContractualDocumentSearchDialogServerHandler
   {
     private global::Sungero.Contracts.Server.ContractBaseSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Contracts.Server.ContractBaseSearchDialogModel)this.Dialog;
       }
     }

     public ContractBaseSearchDialogServerHandler(global::Sungero.Contracts.Server.ContractBaseSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ContractBaseServerHandlers : global::Sungero.Contracts.ContractualDocumentServerHandlers
  {
    private global::Sungero.Contracts.IContractBase _obj
    {
      get { return (global::Sungero.Contracts.IContractBase)this.Entity; }
    }

    public ContractBaseServerHandlers(global::Sungero.Contracts.IContractBase entity)
      : base(entity)
    {
    }
  }

  public partial class ContractBaseCreatingFromServerHandler : global::Sungero.Contracts.ContractualDocumentCreatingFromServerHandler
  {
    private global::Sungero.Contracts.IContractBase _source
    {
      get { return (global::Sungero.Contracts.IContractBase)this.Source; }
    }

    private global::Sungero.Contracts.IContractBaseInfo _info
    {
      get { return (global::Sungero.Contracts.IContractBaseInfo)this._Info; }
    }

    public ContractBaseCreatingFromServerHandler(global::Sungero.Contracts.IContractBase source, global::Sungero.Contracts.IContractBaseInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ContractBaseEventArgs.g.cs
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

// ==================================================================
// ContractBaseAccessRights.g.cs
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
  public class ContractBaseAccessRights : 
    Sungero.Contracts.Server.ContractualDocumentAccessRights, Sungero.Contracts.IContractBaseAccessRights
  {

    public ContractBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ContractBaseTypeAccessRights : 
    Sungero.Contracts.Server.ContractualDocumentTypeAccessRights, Sungero.Contracts.IContractBaseAccessRights
  {

    public ContractBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ContractBaseRepositoryImplementer.g.cs
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
    public class ContractBaseRepositoryImplementer<T> : 
      global::Sungero.Contracts.Server.ContractualDocumentRepositoryImplementer<T>,
      global::Sungero.Contracts.IContractBaseRepositoryImplementer<T>
      where T : global::Sungero.Contracts.IContractBase 
    {
       public new global::Sungero.Contracts.IContractBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Contracts.IContractBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Contracts.IContractBaseInfo Info
       {
          get { return (global::Sungero.Contracts.IContractBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Contracts.Server.ContractBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ContractBasePanelNavigationFilters.g.cs
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

// ==================================================================
// ContractBaseServerFunctions.g.cs
// ==================================================================

namespace Sungero.Contracts.Server
{
  public partial class ContractBaseFunctions : global::Sungero.Contracts.Server.ContractualDocumentFunctions
  {
    private global::Sungero.Contracts.IContractBase _obj
    {
      get { return (global::Sungero.Contracts.IContractBase)this.Entity; }
    }

    public ContractBaseFunctions(global::Sungero.Contracts.IContractBase entity) : base(entity) { }
  }
}

// ==================================================================
// ContractBaseFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Functions
{
  internal static class ContractBase
  {
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Linq.IQueryable<global::Sungero.Contracts.IContractBase> GetDuplicates(global::Sungero.Contracts.IContractBase contract, global::Sungero.Company.IBusinessUnit businessUnit, global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::Sungero.Parties.ICounterparty counterparty)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.Server.ContractBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDuplicates",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Contracts.IContractBase), typeof(global::Sungero.Company.IBusinessUnit), typeof(global::System.String), typeof(global::System.Nullable<global::System.DateTime>), typeof(global::Sungero.Parties.ICounterparty) }, null);
        return (global::System.Linq.IQueryable<global::Sungero.Contracts.IContractBase>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { contract, businessUnit, registrationNumber, registrationDate, counterparty });
      }
      else
      {
        return global::Sungero.Contracts.Server.ContractBaseFunctions.GetDuplicates(contract, businessUnit, registrationNumber, registrationDate, counterparty);
      }
    }
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.String GetNamePartByContractIgnoreAccessRights(global::System.Int64 contractId)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.Server.ContractBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetNamePartByContractIgnoreAccessRights",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Int64) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { contractId });
      }
      else
      {
        return global::Sungero.Contracts.Server.ContractBaseFunctions.GetNamePartByContractIgnoreAccessRights(contractId);
      }
    }
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBase> GetApprovalRules(global::Sungero.Contracts.IContractBase contractBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetApprovalRules", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBase>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::Sungero.Core.StateView GetDocumentSummary(global::Sungero.Contracts.IContractBase contractBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentSummary", new System.Type[] {  });
      return (global::Sungero.Core.StateView)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
    internal static  void SetLifeCycleStateDraft(global::Sungero.Contracts.IContractBase contractBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleStateDraft", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Boolean HasSpecifiedTypeRelations(global::Sungero.Contracts.IContractBase contractBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasSpecifiedTypeRelations", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.Boolean HaveDuplicates(global::Sungero.Contracts.IContractBase contract, global::Sungero.Company.IBusinessUnit businessUnit, global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::Sungero.Parties.ICounterparty counterparty)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.Shared.ContractBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("HaveDuplicates",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Contracts.IContractBase), typeof(global::Sungero.Company.IBusinessUnit), typeof(global::System.String), typeof(global::System.Nullable<global::System.DateTime>), typeof(global::Sungero.Parties.ICounterparty) }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { contract, businessUnit, registrationNumber, registrationDate, counterparty });
      }
      else
      {
        return global::Sungero.Contracts.Shared.ContractBaseFunctions.HaveDuplicates(contract, businessUnit, registrationNumber, registrationDate, counterparty);
      }
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Contracts.IContractBase contractBase, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, isRepeatRegister });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.String GetNamePartByContract(global::Sungero.Contracts.IContractualDocument contract)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.Shared.ContractBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetNamePartByContract",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Contracts.IContractualDocument) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { contract });
      }
      else
      {
        return global::Sungero.Contracts.Shared.ContractBaseFunctions.GetNamePartByContract(contract);
      }
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.String GetContractNamePart(global::Sungero.Contracts.IContractBase contract)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.Shared.ContractBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetContractNamePart",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Contracts.IContractBase) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { contract });
      }
      else
      {
        return global::Sungero.Contracts.Shared.ContractBaseFunctions.GetContractNamePart(contract);
      }
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  void SetObsolete(global::Sungero.Contracts.IContractBase contractBase, global::System.Boolean isActive)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetObsolete", new System.Type[] { typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isActive });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  void FillName(global::Sungero.Contracts.IContractBase contractBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Contracts.IContractBase contractBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.Boolean CheckRegistrationNumberUnique(global::Sungero.Contracts.IContractBase contractBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckRegistrationNumberUnique", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Contracts.IContractBase contractBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasEmptyRequiredProperties", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ContractBaseServerPublicFunctions.g.cs
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
  public class ContractBaseServerPublicFunctions : global::Sungero.Contracts.Server.IContractBaseServerPublicFunctions
  {
  }
}

// ==================================================================
// ContractBaseQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Queries
{
  public class ContractBase
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Contracts.Server.ContractBase.ContractBaseQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ContractBaseServerHandlers.g.cs
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
  public partial class ContractBaseConvertingFromServerHandler : global::Sungero.Contracts.ContractualDocumentConvertingFromServerHandler
  { 
    private global::Sungero.Contracts.IContractBaseInfo _info
    {
      get { return (global::Sungero.Contracts.IContractBaseInfo)this._Info; }
    }

    public ContractBaseConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.Contracts.IContractBaseInfo info)
      : base(source, info)
    {
    }
  }
}
