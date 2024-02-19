
// ==================================================================
// Bank.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
    public class BankFilter<T> :
      global::Sungero.Parties.Server.CompanyBaseFilter<T>
      where T : class, global::Sungero.Parties.IBank
    {
      private global::Sungero.Parties.IBankFilterState filter
      {
        get
        {
          return (Sungero.Parties.IBankFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public BankFilter(global::Sungero.Parties.IBankFilterState filter)
      : base(filter)
      {
      }

      protected BankFilter()
      {
      }
    }
      public class BankUiFilter<T> :
        global::Sungero.Parties.Server.CompanyBaseUiFilter<T>
        where T : class, global::Sungero.Parties.IBank
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class BankSearchDialogModel : global::Sungero.Parties.Server.CompanyBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.Boolean? CanExchange { get; protected set; }
                  public override global::System.String Phones { get; protected set; }
                  public override global::System.String Email { get; protected set; }
                  public override global::System.String Homepage { get; protected set; }
                  public override global::System.String Note { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String TRRC { get; protected set; }
                  public override global::System.String TIN { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.String PSRN { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.String NCEO { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.String NCEA { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.String Account { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.ICounterpartyKind> Kind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Commons.ICity> City { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Reliability { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Responsible { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.IBank> Bank { get; protected set; }


                  public virtual global::System.String BIC { get; protected set; }
                  public virtual global::System.String CorrespondentAccount { get; protected set; }
                  public virtual global::System.String SWIFT { get; protected set; }



                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new BankExchangeBoxesModel ExchangeBoxes { get { return (BankExchangeBoxesModel)base.ExchangeBoxes; } protected set { base.ExchangeBoxes = value; } }

        }

      public class BankExchangeBoxesModel : global::Sungero.Parties.Server.CompanyBaseExchangeBoxesModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Parties.Server.BankFilter<global::Sungero.Parties.IBank>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Parties.Server.BankUiFilter<global::Sungero.Parties.IBank>))]

  public class Bank :
    global::Sungero.Parties.Server.CompanyBase, global::Sungero.Parties.IBank
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("80c4e311-e95f-449b-984d-1fd540b8f0af");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Server.Bank.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Parties.IBank, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Parties.IBankState State
    {
      get { return (global::Sungero.Parties.IBankState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.BankState(this);
    }

    public new virtual global::Sungero.Parties.IBankInfo Info
    {
      get { return (global::Sungero.Parties.IBankInfo)base.Info; }
    }

    public new virtual global::Sungero.Parties.IBankAccessRights AccessRights
    {
      get { return (global::Sungero.Parties.IBankAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Parties.Server.BankAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Parties.Server.BankFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Parties.Shared.BankFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Parties.BankServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Parties.BankSharedHandlers(this);
    }

    private global::System.String _BIC;
    public virtual global::System.String BIC
    {
      get
      {
        return this._BIC;
      }

      set
      {
        this.SetPropertyValue("BIC", this._BIC, value, (propertyValue) => { this._BIC = propertyValue; }, this.BICChangedHandler);
      }
    }
    private global::System.String _CorrespondentAccount;
    public virtual global::System.String CorrespondentAccount
    {
      get
      {
        return this._CorrespondentAccount;
      }

      set
      {
        this.SetPropertyValue("CorrespondentAccount", this._CorrespondentAccount, value, (propertyValue) => { this._CorrespondentAccount = propertyValue; }, this.CorrespondentAccountChangedHandler);
      }
    }
    private global::System.Boolean? _IsSystem;
    public virtual global::System.Boolean? IsSystem
    {
      get
      {
        return this._IsSystem;
      }

      set
      {
        this.SetPropertyValue("IsSystem", this._IsSystem, value, (propertyValue) => { this._IsSystem = propertyValue; }, this.IsSystemChangedHandler);
      }
    }
    private global::System.String _SWIFT;
    public virtual global::System.String SWIFT
    {
      get
      {
        return this._SWIFT;
      }

      set
      {
        this.SetPropertyValue("SWIFT", this._SWIFT, value, (propertyValue) => { this._SWIFT = propertyValue; }, this.SWIFTChangedHandler);
      }
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Parties.ICounterpartyExchangeBoxes> CreateExchangeBoxesCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Parties.IBankExchangeBoxes>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Parties.BankCreatingFromServerHandler", new object[] { (global::Sungero.Parties.IBank)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Parties.BankCreatingFromServerHandler((global::Sungero.Parties.IBank)entitySource, this.Info);
    }

    #region Framework events

    protected void BICChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.BIC, this.BIC, this);
     ((global::Sungero.Parties.IBankSharedHandlers)this.SharedHandlers).BICChanged(args);
    }

    protected void CorrespondentAccountChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CorrespondentAccount, this.CorrespondentAccount, this);
     ((global::Sungero.Parties.IBankSharedHandlers)this.SharedHandlers).CorrespondentAccountChanged(args);
    }

    protected void IsSystemChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsSystem, this.IsSystem, this);
     ((global::Sungero.Parties.IBankSharedHandlers)this.SharedHandlers).IsSystemChanged(args);
    }


    protected void SWIFTChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.SWIFT, this.SWIFT, this);
     ((global::Sungero.Parties.IBankSharedHandlers)this.SharedHandlers).SWIFTChanged(args);
    }




    #endregion


    public Bank()
    {
    }

  }
}

// ==================================================================
// BankHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties
{

  public partial class BankFilteringServerHandler<T>
    : global::Sungero.Parties.CompanyBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Parties.IBank
  {
    private global::Sungero.Parties.IBankFilterState _filter
    {
      get
      {
        return (Sungero.Parties.IBankFilterState)this.Filter;
      }
    }

    public BankFilteringServerHandler(global::Sungero.Parties.IBankFilterState filter)
    : base(filter)
    {
    }

    protected BankFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }

      public override global::System.Linq.IQueryable<Sungero.Company.IEmployee> ResponsibleFiltering(global::System.Linq.IQueryable<Sungero.Company.IEmployee> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.ResponsibleFiltering(query, e);
              return query;
      }


  }

  public partial class BankUiFilteringServerHandler<T>
    : global::Sungero.Parties.CompanyBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Parties.IBank
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class BankSearchDialogServerHandler : global::Sungero.Parties.CompanyBaseSearchDialogServerHandler
   {
     private global::Sungero.Parties.Server.BankSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Parties.Server.BankSearchDialogModel)this.Dialog;
       }
     }

     public BankSearchDialogServerHandler(global::Sungero.Parties.Server.BankSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class BankServerHandlers : global::Sungero.Parties.CompanyBaseServerHandlers
  {
    private global::Sungero.Parties.IBank _obj
    {
      get { return (global::Sungero.Parties.IBank)this.Entity; }
    }

    public BankServerHandlers(global::Sungero.Parties.IBank entity)
      : base(entity)
    {
    }
  }

  public partial class BankCreatingFromServerHandler : global::Sungero.Parties.CompanyBaseCreatingFromServerHandler
  {
    private global::Sungero.Parties.IBank _source
    {
      get { return (global::Sungero.Parties.IBank)this.Source; }
    }

    private global::Sungero.Parties.IBankInfo _info
    {
      get { return (global::Sungero.Parties.IBankInfo)this._Info; }
    }

    public BankCreatingFromServerHandler(global::Sungero.Parties.IBank source, global::Sungero.Parties.IBankInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// BankEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
}

// ==================================================================
// BankAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
  public class BankAccessRights : 
    Sungero.Parties.Server.CompanyBaseAccessRights, Sungero.Parties.IBankAccessRights
  {

    public BankAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class BankTypeAccessRights : 
    Sungero.Parties.Server.CompanyBaseTypeAccessRights, Sungero.Parties.IBankAccessRights
  {

    public BankTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// BankRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
    public class BankRepositoryImplementer<T> : 
      global::Sungero.Parties.Server.CompanyBaseRepositoryImplementer<T>,
      global::Sungero.Parties.IBankRepositoryImplementer<T>
      where T : global::Sungero.Parties.IBank 
    {
       public new global::Sungero.Parties.IBankAccessRights AccessRights
       {
          get { return (global::Sungero.Parties.IBankAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Parties.IBankInfo Info
       {
          get { return (global::Sungero.Parties.IBankInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Parties.Server.BankTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// BankPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
    public class BankResponsiblePanelNavigationFilter : global::Sungero.Parties.Server.CompanyBaseResponsiblePanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.Parties.IBank
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IEmployee>)query;
        var typedState = (global::Sungero.Parties.IBankFilterState)this.State;
        var handlers = new global::Sungero.Parties.BankFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.ResponsibleFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IEmployee>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.Parties.IBank>(query);
      }
    }

}

// ==================================================================
// BankServerFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Server
{
  public partial class BankFunctions : global::Sungero.Parties.Server.CompanyBaseFunctions
  {
    private global::Sungero.Parties.IBank _obj
    {
      get { return (global::Sungero.Parties.IBank)this.Entity; }
    }

    public BankFunctions(global::Sungero.Parties.IBank entity) : base(entity) { }
  }
}

// ==================================================================
// BankFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Functions
{
  internal static class Bank
  {
    /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.BankFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.IBank> GetBanksWithSameBic(global::Sungero.Parties.IBank bank, global::System.Boolean excludeClosed)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)bank).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetBanksWithSameBic", new System.Type[] { typeof(global::System.Boolean) });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.IBank>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { excludeClosed });
    }
    /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.BankFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.IBank> GetBanksWithSameSwift(global::Sungero.Parties.IBank bank, global::System.Boolean excludeClosed)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)bank).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetBanksWithSameSwift", new System.Type[] { typeof(global::System.Boolean) });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.IBank>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { excludeClosed });
    }
    /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.BankFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Collections.Generic.List<global::System.Int64> GetBankIdsServer()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Server.BankFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetBankIdsServer",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::System.Collections.Generic.List<global::System.Int64>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Parties.Server.BankFunctions.GetBankIdsServer();
      }
    }

    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.BankFunctions" />
    internal static  global::System.String CheckSwift(global::System.String swift)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.BankFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CheckSwift",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { swift });
      }
      else
      {
        return global::Sungero.Parties.Shared.BankFunctions.CheckSwift(swift);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.BankFunctions" />
    internal static  global::System.String CheckBicLength(global::System.String bic)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.BankFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CheckBicLength",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { bic });
      }
      else
      {
        return global::Sungero.Parties.Shared.BankFunctions.CheckBicLength(bic);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.BankFunctions" />
    internal static  global::System.String CheckCorrLength(global::System.String corr)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.BankFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CheckCorrLength",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { corr });
      }
      else
      {
        return global::Sungero.Parties.Shared.BankFunctions.CheckCorrLength(corr);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.BankFunctions" />
    internal static  global::System.String CheckCorrAccountForNonresident(global::System.String corr)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.BankFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CheckCorrAccountForNonresident",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { corr });
      }
      else
      {
        return global::Sungero.Parties.Shared.BankFunctions.CheckCorrAccountForNonresident(corr);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.BankFunctions" />
    internal static  global::System.String GetCounterpartyDuplicatesErrorText(global::Sungero.Parties.IBank bank)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)bank).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterpartyDuplicatesErrorText", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.BankFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.Int64> GetBankIds()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.BankFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetBankIds",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::System.Collections.Generic.List<global::System.Int64>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Parties.Shared.BankFunctions.GetBankIds();
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.BankFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Parties.IBank bank)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)bank).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// BankServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
  public class BankServerPublicFunctions : global::Sungero.Parties.Server.IBankServerPublicFunctions
  {
  }
}

// ==================================================================
// BankQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Queries
{
  public class Bank
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Parties.Server.Bank.BankQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}