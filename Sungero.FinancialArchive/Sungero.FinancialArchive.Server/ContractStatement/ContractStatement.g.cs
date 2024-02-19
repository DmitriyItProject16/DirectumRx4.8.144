
// ==================================================================
// ContractStatement.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
    public class ContractStatementFilter<T> :
      global::Sungero.Docflow.Server.AccountingDocumentBaseFilter<T>
      where T : class, global::Sungero.FinancialArchive.IContractStatement
    {
      private global::Sungero.FinancialArchive.IContractStatementFilterState filter
      {
        get
        {
          return (Sungero.FinancialArchive.IContractStatementFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ContractStatementFilter(global::Sungero.FinancialArchive.IContractStatementFilterState filter)
      : base(filter)
      {
      }

      protected ContractStatementFilter()
      {
      }
    }
    public class ContractStatementSearchDialogModel : global::Sungero.Docflow.Server.AccountingDocumentBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.Int64? SellerTitleId { get; protected set; }
                  public override global::System.Int64? BuyerTitleId { get; protected set; }
                  public override global::System.Int64? SellerSignatureId { get; protected set; }
                  public override global::System.Int64? BuyerSignatureId { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Boolean? IsAdjustment { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> ResponsibleEmployee { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.IContact> Contact { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.IContact> CounterpartySignatory { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IAccountingDocumentBase> Corrected { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> LeadingDocument { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.ICounterparty> Counterparty { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }




                   public new ContractStatementVersionsModel Versions { get { return (ContractStatementVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ContractStatementTrackingModel Tracking { get { return (ContractStatementTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }

        }

      public class ContractStatementVersionsModel : global::Sungero.Docflow.Server.AccountingDocumentBaseVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class ContractStatementTrackingModel : global::Sungero.Docflow.Server.AccountingDocumentBaseTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.FinancialArchive.Server.ContractStatementFilter<global::Sungero.FinancialArchive.IContractStatement>))]

  public class ContractStatement :
    global::Sungero.Docflow.Server.AccountingDocumentBase, global::Sungero.FinancialArchive.IContractStatement, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f2f5774d-5ca3-4725-b31d-ac618f6b8850");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Server.ContractStatement.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IContractStatement, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.FinancialArchive.IContractStatementState State
    {
      get { return (global::Sungero.FinancialArchive.IContractStatementState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.ContractStatementState(this);
    }

    public new virtual global::Sungero.FinancialArchive.IContractStatementInfo Info
    {
      get { return (global::Sungero.FinancialArchive.IContractStatementInfo)base.Info; }
    }

    public new virtual global::Sungero.FinancialArchive.IContractStatementAccessRights AccessRights
    {
      get { return (global::Sungero.FinancialArchive.IContractStatementAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.FinancialArchive.Server.ContractStatementAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.FinancialArchive.Server.ContractStatementFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.FinancialArchive.Shared.ContractStatementFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.FinancialArchive.ContractStatementServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.FinancialArchive.ContractStatementSharedHandlers(this);
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.FinancialArchive.IContractStatementVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.FinancialArchive.IContractStatementTracking>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.FinancialArchive.ContractStatementCreatingFromServerHandler", new object[] { (global::Sungero.FinancialArchive.IContractStatement)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.FinancialArchive.ContractStatementCreatingFromServerHandler((global::Sungero.FinancialArchive.IContractStatement)entitySource, this.Info);
    }

    #region Framework events





    #endregion


    public ContractStatement()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.FinancialArchive.ContractStatementConvertingFromServerHandler", (global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityConvertingFromServerHandler)instance;

      return new global::Sungero.FinancialArchive.ContractStatementConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// ContractStatementHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive
{

  public partial class ContractStatementFilteringServerHandler<T>
    : global::Sungero.Docflow.AccountingDocumentBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.FinancialArchive.IContractStatement
  {
    private global::Sungero.FinancialArchive.IContractStatementFilterState _filter
    {
      get
      {
        return (Sungero.FinancialArchive.IContractStatementFilterState)this.Filter;
      }
    }

    public ContractStatementFilteringServerHandler(global::Sungero.FinancialArchive.IContractStatementFilterState filter)
    : base(filter)
    {
    }

    protected ContractStatementFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }

      public override global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> BusinessUnitFiltering(global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.BusinessUnitFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Company.IDepartment> DepartmentFiltering(global::System.Linq.IQueryable<Sungero.Company.IDepartment> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.DepartmentFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Parties.ICounterparty> CounterpartyFiltering(global::System.Linq.IQueryable<Sungero.Parties.ICounterparty> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.CounterpartyFiltering(query, e);
              return query;
      }


  }

  public partial class ContractStatementSearchDialogServerHandler : global::Sungero.Docflow.AccountingDocumentBaseSearchDialogServerHandler
   {
     private global::Sungero.FinancialArchive.Server.ContractStatementSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.FinancialArchive.Server.ContractStatementSearchDialogModel)this.Dialog;
       }
     }

     public ContractStatementSearchDialogServerHandler(global::Sungero.FinancialArchive.Server.ContractStatementSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ContractStatementServerHandlers : global::Sungero.Docflow.AccountingDocumentBaseServerHandlers
  {
    private global::Sungero.FinancialArchive.IContractStatement _obj
    {
      get { return (global::Sungero.FinancialArchive.IContractStatement)this.Entity; }
    }

    public ContractStatementServerHandlers(global::Sungero.FinancialArchive.IContractStatement entity)
      : base(entity)
    {
    }
  }

  public partial class ContractStatementCreatingFromServerHandler : global::Sungero.Docflow.AccountingDocumentBaseCreatingFromServerHandler
  {
    private global::Sungero.FinancialArchive.IContractStatement _source
    {
      get { return (global::Sungero.FinancialArchive.IContractStatement)this.Source; }
    }

    private global::Sungero.FinancialArchive.IContractStatementInfo _info
    {
      get { return (global::Sungero.FinancialArchive.IContractStatementInfo)this._Info; }
    }

    public ContractStatementCreatingFromServerHandler(global::Sungero.FinancialArchive.IContractStatement source, global::Sungero.FinancialArchive.IContractStatementInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ContractStatementEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
}

// ==================================================================
// ContractStatementAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
  public class ContractStatementAccessRights : 
    Sungero.Docflow.Server.AccountingDocumentBaseAccessRights, Sungero.FinancialArchive.IContractStatementAccessRights
  {

    public ContractStatementAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ContractStatementTypeAccessRights : 
    Sungero.Docflow.Server.AccountingDocumentBaseTypeAccessRights, Sungero.FinancialArchive.IContractStatementAccessRights
  {

    public ContractStatementTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ContractStatementRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
    public class ContractStatementRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.AccountingDocumentBaseRepositoryImplementer<T>,
      global::Sungero.FinancialArchive.IContractStatementRepositoryImplementer<T>
      where T : global::Sungero.FinancialArchive.IContractStatement 
    {
       public new global::Sungero.FinancialArchive.IContractStatementAccessRights AccessRights
       {
          get { return (global::Sungero.FinancialArchive.IContractStatementAccessRights)base.AccessRights; }
       }

       public new global::Sungero.FinancialArchive.IContractStatementInfo Info
       {
          get { return (global::Sungero.FinancialArchive.IContractStatementInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.FinancialArchive.Server.ContractStatementTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ContractStatementPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
    public class ContractStatementBusinessUnitPanelNavigationFilter : global::Sungero.Docflow.Server.AccountingDocumentBaseBusinessUnitPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.FinancialArchive.IContractStatement
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.FinancialArchive.IContractStatementFilterState)this.State;
        var handlers = new global::Sungero.FinancialArchive.ContractStatementFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.FinancialArchive.IContractStatement>(query);
      }
    }

    public class ContractStatementDepartmentPanelNavigationFilter : global::Sungero.Docflow.Server.AccountingDocumentBaseDepartmentPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.FinancialArchive.IContractStatement
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IDepartment>)query;
        var typedState = (global::Sungero.FinancialArchive.IContractStatementFilterState)this.State;
        var handlers = new global::Sungero.FinancialArchive.ContractStatementFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DepartmentFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IDepartment>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.FinancialArchive.IContractStatement>(query);
      }
    }

    public class ContractStatementCounterpartyPanelNavigationFilter : global::Sungero.Docflow.Server.AccountingDocumentBaseCounterpartyPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.FinancialArchive.IContractStatement
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Parties.ICounterparty>)query;
        var typedState = (global::Sungero.FinancialArchive.IContractStatementFilterState)this.State;
        var handlers = new global::Sungero.FinancialArchive.ContractStatementFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.CounterpartyFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Parties.ICounterparty>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.FinancialArchive.IContractStatement>(query);
      }
    }

}

// ==================================================================
// ContractStatementServerFunctions.g.cs
// ==================================================================

namespace Sungero.FinancialArchive.Server
{
  public partial class ContractStatementFunctions : global::Sungero.Docflow.Server.AccountingDocumentBaseFunctions
  {
    private global::Sungero.FinancialArchive.IContractStatement _obj
    {
      get { return (global::Sungero.FinancialArchive.IContractStatement)this.Entity; }
    }

    public ContractStatementFunctions(global::Sungero.FinancialArchive.IContractStatement entity) : base(entity) { }
  }
}

// ==================================================================
// ContractStatementFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Functions
{
  internal static class ContractStatement
  {
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ContractStatementFunctions" />
    internal static  global::System.Boolean CanSendAnswer(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanSendAnswer", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ContractStatementFunctions" />
    internal static  void SendAnswer(global::Sungero.FinancialArchive.IContractStatement contractStatement, global::Sungero.ExchangeCore.IBusinessUnitBox box, global::Sungero.Parties.ICounterparty party, global::Sungero.CoreEntities.ICertificate certificate, global::System.Boolean isAgent)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SendAnswer", new System.Type[] { typeof(global::Sungero.ExchangeCore.IBusinessUnitBox), typeof(global::Sungero.Parties.ICounterparty), typeof(global::Sungero.CoreEntities.ICertificate), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { box, party, certificate, isAgent });
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ContractStatementFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Linq.IQueryable<global::Sungero.FinancialArchive.IContractStatement> GetDuplicates(global::Sungero.FinancialArchive.IContractStatement contractStatement, global::Sungero.Company.IBusinessUnit businessUnit, global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::Sungero.Parties.ICounterparty counterparty, global::Sungero.Docflow.IOfficialDocument leadingDocument)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.FinancialArchive.Server.ContractStatementFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDuplicates",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.FinancialArchive.IContractStatement), typeof(global::Sungero.Company.IBusinessUnit), typeof(global::System.String), typeof(global::System.Nullable<global::System.DateTime>), typeof(global::Sungero.Parties.ICounterparty), typeof(global::Sungero.Docflow.IOfficialDocument) }, null);
        return (global::System.Linq.IQueryable<global::Sungero.FinancialArchive.IContractStatement>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { contractStatement, businessUnit, registrationNumber, registrationDate, counterparty, leadingDocument });
      }
      else
      {
        return global::Sungero.FinancialArchive.Server.ContractStatementFunctions.GetDuplicates(contractStatement, businessUnit, registrationNumber, registrationDate, counterparty, leadingDocument);
      }
    }

    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::System.Boolean HaveDuplicates(global::Sungero.FinancialArchive.IContractStatement contractStatement, global::Sungero.Company.IBusinessUnit businessUnit, global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::Sungero.Parties.ICounterparty counterparty, global::Sungero.Docflow.IOfficialDocument leadingDocument)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.FinancialArchive.Shared.ContractStatementFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("HaveDuplicates",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.FinancialArchive.IContractStatement), typeof(global::Sungero.Company.IBusinessUnit), typeof(global::System.String), typeof(global::System.Nullable<global::System.DateTime>), typeof(global::Sungero.Parties.ICounterparty), typeof(global::Sungero.Docflow.IOfficialDocument) }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { contractStatement, businessUnit, registrationNumber, registrationDate, counterparty, leadingDocument });
      }
      else
      {
        return global::Sungero.FinancialArchive.Shared.ContractStatementFunctions.HaveDuplicates(contractStatement, businessUnit, registrationNumber, registrationDate, counterparty, leadingDocument);
      }
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::System.String GetLeadDocumentNumber(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetLeadDocumentNumber", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  void FillName(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::Sungero.Company.IEmployee GetDocumentResponsibleEmployee(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentResponsibleEmployee", new System.Type[] {  });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee> GetEmailAddressees(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEmailAddressees", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.OfficialDocument.IEmailAddressee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsVerificationModeSupported", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ContractStatementServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
  public class ContractStatementServerPublicFunctions : global::Sungero.FinancialArchive.Server.IContractStatementServerPublicFunctions
  {
  }
}

// ==================================================================
// ContractStatementQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Queries
{
  public class ContractStatement
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.FinancialArchive.Server.ContractStatement.ContractStatementQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ContractStatementServerHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive
{
  public partial class ContractStatementConvertingFromServerHandler : global::Sungero.Docflow.AccountingDocumentBaseConvertingFromServerHandler
  { 
    private global::Sungero.FinancialArchive.IContractStatementInfo _info
    {
      get { return (global::Sungero.FinancialArchive.IContractStatementInfo)this._Info; }
    }

    public ContractStatementConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.FinancialArchive.IContractStatementInfo info)
      : base(source, info)
    {
    }
  }
}
