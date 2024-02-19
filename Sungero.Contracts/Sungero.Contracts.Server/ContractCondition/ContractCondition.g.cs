
// ==================================================================
// ContractCondition.g.cs
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
    public class ContractConditionFilter<T> :
      global::Sungero.Docflow.Server.ConditionBaseFilter<T>
      where T : class, global::Sungero.Contracts.IContractCondition
    {
      private global::Sungero.Contracts.IContractConditionFilterState filter
      {
        get
        {
          return (Sungero.Contracts.IContractConditionFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ContractConditionFilter(global::Sungero.Contracts.IContractConditionFilterState filter)
      : base(filter)
      {
      }

      protected ContractConditionFilter()
      {
      }
    }
      public class ContractConditionUiFilter<T> :
        global::Sungero.Docflow.Server.ConditionBaseUiFilter<T>
        where T : class, global::Sungero.Contracts.IContractCondition
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ContractConditionSearchDialogModel : global::Sungero.Docflow.Server.ConditionBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.Double? Amount { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> AmountOperator { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IApprovalRoleBase> ApprovalRole { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IApprovalRoleBase> ApprovalRoleForComparison { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> RecipientForComparison { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> AddendaDocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ConditionType { get; protected set; }




                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ContractConditionCurrenciesModel Currencies { get { return (ContractConditionCurrenciesModel)base.Currencies; } protected set { base.Currencies = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ContractConditionDocumentKindsModel DocumentKinds { get { return (ContractConditionDocumentKindsModel)base.DocumentKinds; } protected set { base.DocumentKinds = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ContractConditionConditionDocumentKindsModel ConditionDocumentKinds { get { return (ContractConditionConditionDocumentKindsModel)base.ConditionDocumentKinds; } protected set { base.ConditionDocumentKinds = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ContractConditionDeliveryMethodsModel DeliveryMethods { get { return (ContractConditionDeliveryMethodsModel)base.DeliveryMethods; } protected set { base.DeliveryMethods = value; } }

        }

      public class ContractConditionCurrenciesModel : global::Sungero.Docflow.Server.ConditionBaseCurrenciesModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }
      public class ContractConditionDocumentKindsModel : global::Sungero.Docflow.Server.ConditionBaseDocumentKindsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }
      public class ContractConditionConditionDocumentKindsModel : global::Sungero.Docflow.Server.ConditionBaseConditionDocumentKindsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }
      public class ContractConditionDeliveryMethodsModel : global::Sungero.Docflow.Server.ConditionBaseDeliveryMethodsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Contracts.Server.ContractConditionFilter<global::Sungero.Contracts.IContractCondition>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Contracts.Server.ContractConditionUiFilter<global::Sungero.Contracts.IContractCondition>))]

  public class ContractCondition :
    global::Sungero.Docflow.Server.ConditionBase, global::Sungero.Contracts.IContractCondition
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0523387b-a689-41e5-bed3-95892df6922c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ContractCondition.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractCondition, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Contracts.IContractConditionState State
    {
      get { return (global::Sungero.Contracts.IContractConditionState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractConditionState(this);
    }

    public new virtual global::Sungero.Contracts.IContractConditionInfo Info
    {
      get { return (global::Sungero.Contracts.IContractConditionInfo)base.Info; }
    }

    public new virtual global::Sungero.Contracts.IContractConditionAccessRights AccessRights
    {
      get { return (global::Sungero.Contracts.IContractConditionAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Contracts.Server.ContractConditionAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Contracts.Server.ContractConditionFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Contracts.Shared.ContractConditionFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.ContractConditionServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.ContractConditionSharedHandlers(this);
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ConditionTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Docflow.Server.ConditionBase.ConditionTypeItems,
      typeof(global::Sungero.Contracts.ContractCondition.ConditionType),
      typeof(global::Sungero.Contracts.Server.ContractCondition),
      "ConditionType");

    public static new global::Sungero.Domain.Shared.EnumerationItems ConditionTypeItems
    {
      get { return global::Sungero.Contracts.Server.ContractCondition._ConditionTypeItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ConditionTypeAllowedItems
    {
      get { return global::Sungero.Contracts.Server.ContractCondition.ConditionTypeItems; }
    }





    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionBaseCurrencies> CreateCurrenciesCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Contracts.IContractConditionCurrencies>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionBaseDocumentKinds> CreateDocumentKindsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Contracts.IContractConditionDocumentKinds>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionBaseConditionDocumentKinds> CreateConditionDocumentKindsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Contracts.IContractConditionConditionDocumentKinds>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionBaseDeliveryMethods> CreateDeliveryMethodsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Contracts.IContractConditionDeliveryMethods>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Contracts.ContractConditionCreatingFromServerHandler", new object[] { (global::Sungero.Contracts.IContractCondition)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Contracts.ContractConditionCreatingFromServerHandler((global::Sungero.Contracts.IContractCondition)entitySource, this.Info);
    }

    #region Framework events







    #endregion


    public ContractCondition()
    {
    }

  }
}

// ==================================================================
// ContractConditionHandlers.g.cs
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

  public partial class ContractConditionFilteringServerHandler<T>
    : global::Sungero.Docflow.ConditionBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Contracts.IContractCondition
  {
    private global::Sungero.Contracts.IContractConditionFilterState _filter
    {
      get
      {
        return (Sungero.Contracts.IContractConditionFilterState)this.Filter;
      }
    }

    public ContractConditionFilteringServerHandler(global::Sungero.Contracts.IContractConditionFilterState filter)
    : base(filter)
    {
    }

    protected ContractConditionFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ContractConditionUiFilteringServerHandler<T>
    : global::Sungero.Docflow.ConditionBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Contracts.IContractCondition
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ContractConditionSearchDialogServerHandler : global::Sungero.Docflow.ConditionBaseSearchDialogServerHandler
   {
     private global::Sungero.Contracts.Server.ContractConditionSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Contracts.Server.ContractConditionSearchDialogModel)this.Dialog;
       }
     }

     public ContractConditionSearchDialogServerHandler(global::Sungero.Contracts.Server.ContractConditionSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ContractConditionServerHandlers : global::Sungero.Docflow.ConditionBaseServerHandlers
  {
    private global::Sungero.Contracts.IContractCondition _obj
    {
      get { return (global::Sungero.Contracts.IContractCondition)this.Entity; }
    }

    public ContractConditionServerHandlers(global::Sungero.Contracts.IContractCondition entity)
      : base(entity)
    {
    }
  }

  public partial class ContractConditionCreatingFromServerHandler : global::Sungero.Docflow.ConditionBaseCreatingFromServerHandler
  {
    private global::Sungero.Contracts.IContractCondition _source
    {
      get { return (global::Sungero.Contracts.IContractCondition)this.Source; }
    }

    private global::Sungero.Contracts.IContractConditionInfo _info
    {
      get { return (global::Sungero.Contracts.IContractConditionInfo)this._Info; }
    }

    public ContractConditionCreatingFromServerHandler(global::Sungero.Contracts.IContractCondition source, global::Sungero.Contracts.IContractConditionInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ContractConditionEventArgs.g.cs
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
// ContractConditionAccessRights.g.cs
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
  public class ContractConditionAccessRights : 
    Sungero.Docflow.Server.ConditionBaseAccessRights, Sungero.Contracts.IContractConditionAccessRights
  {

    public ContractConditionAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ContractConditionTypeAccessRights : 
    Sungero.Docflow.Server.ConditionBaseTypeAccessRights, Sungero.Contracts.IContractConditionAccessRights
  {

    public ContractConditionTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ContractConditionRepositoryImplementer.g.cs
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
    public class ContractConditionRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.ConditionBaseRepositoryImplementer<T>,
      global::Sungero.Contracts.IContractConditionRepositoryImplementer<T>
      where T : global::Sungero.Contracts.IContractCondition 
    {
       public new global::Sungero.Contracts.IContractConditionAccessRights AccessRights
       {
          get { return (global::Sungero.Contracts.IContractConditionAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Contracts.IContractConditionInfo Info
       {
          get { return (global::Sungero.Contracts.IContractConditionInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Contracts.Server.ContractConditionTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ContractConditionPanelNavigationFilters.g.cs
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
// ContractConditionServerFunctions.g.cs
// ==================================================================

namespace Sungero.Contracts.Server
{
  public partial class ContractConditionFunctions : global::Sungero.Docflow.Server.ConditionBaseFunctions
  {
    private global::Sungero.Contracts.IContractCondition _obj
    {
      get { return (global::Sungero.Contracts.IContractCondition)this.Entity; }
    }

    public ContractConditionFunctions(global::Sungero.Contracts.IContractCondition entity) : base(entity) { }
  }
}

// ==================================================================
// ContractConditionFunctions.g.cs
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
  internal static class ContractCondition
  {
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractConditionFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::Sungero.Contracts.IContractCondition CreateContractCondition()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Contracts.Server.ContractConditionFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CreateContractCondition",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::Sungero.Contracts.IContractCondition)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Contracts.Server.ContractConditionFunctions.CreateContractCondition();
      }
    }
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractConditionFunctions" />
    internal static  global::System.String GetConditionName(global::Sungero.Contracts.IContractCondition contractCondition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetConditionName", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractConditionFunctions" />
    internal static  System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>>> GetSupportedConditions(global::Sungero.Contracts.IContractCondition contractCondition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetSupportedConditions", new System.Type[] {  });
      return (System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>>>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractConditionFunctions" />
    internal static  Docflow.Structures.ConditionBase.ConditionResult CheckCondition(global::Sungero.Contracts.IContractCondition contractCondition, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckCondition", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::Sungero.Docflow.IApprovalTask) });
      return (Docflow.Structures.ConditionBase.ConditionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, task });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractConditionFunctions" />
    internal static  Docflow.Structures.ConditionBase.ConditionResult CheckStandard(global::Sungero.Contracts.IContractCondition contractCondition, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckStandard", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::Sungero.Docflow.IApprovalTask) });
      return (Docflow.Structures.ConditionBase.ConditionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, task });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractConditionFunctions" />
    internal static  Docflow.Structures.ConditionBase.ConditionResult CheckIsFrameworkContract(global::Sungero.Contracts.IContractCondition contractCondition, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckIsFrameworkContract", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::Sungero.Docflow.IApprovalTask) });
      return (Docflow.Structures.ConditionBase.ConditionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, task });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractConditionFunctions" />
    internal static  Sungero.Docflow.Structures.ConditionBase.ConditionResult CheckAmountIsMore(global::Sungero.Contracts.IContractCondition contractCondition, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckAmountIsMore", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::Sungero.Docflow.IApprovalTask) });
      return (Sungero.Docflow.Structures.ConditionBase.ConditionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, task });
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractConditionFunctions" />
    internal static  global::System.String GetNotUsableConditionHint(global::Sungero.Contracts.IContractCondition contractCondition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractCondition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetNotUsableConditionHint", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ContractConditionServerPublicFunctions.g.cs
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
  public class ContractConditionServerPublicFunctions : global::Sungero.Contracts.Server.IContractConditionServerPublicFunctions
  {
  }
}

// ==================================================================
// ContractConditionQueries.g.cs
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
  public class ContractCondition
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Contracts.Server.ContractCondition.ContractConditionQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
