
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

namespace Sungero.Contracts.Server
{
    public class ApprovalIncInvoicePaidStageFilter<T> :
      global::Sungero.Docflow.Server.ApprovalFunctionStageBaseFilter<T>
      where T : class, global::Sungero.Contracts.IApprovalIncInvoicePaidStage
    {
      private global::Sungero.Contracts.IApprovalIncInvoicePaidStageFilterState filter
      {
        get
        {
          return (Sungero.Contracts.IApprovalIncInvoicePaidStageFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ApprovalIncInvoicePaidStageFilter(global::Sungero.Contracts.IApprovalIncInvoicePaidStageFilterState filter)
      : base(filter)
      {
      }

      protected ApprovalIncInvoicePaidStageFilter()
      {
      }
    }
      public class ApprovalIncInvoicePaidStageUiFilter<T> :
        global::Sungero.Docflow.Server.ApprovalFunctionStageBaseUiFilter<T>
        where T : class, global::Sungero.Contracts.IApprovalIncInvoicePaidStage
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ApprovalIncInvoicePaidStageSearchDialogModel : global::Sungero.Docflow.Server.ApprovalFunctionStageBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.Int32? DeadlineInDays { get; protected set; }
                  public override global::System.Int32? DeadlineInHours { get; protected set; }
                  public override global::System.String Name { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> TimeoutAction { get; protected set; }




        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStageFilter<global::Sungero.Contracts.IApprovalIncInvoicePaidStage>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStageUiFilter<global::Sungero.Contracts.IApprovalIncInvoicePaidStage>))]

  public class ApprovalIncInvoicePaidStage :
    global::Sungero.Docflow.Server.ApprovalFunctionStageBase, global::Sungero.Contracts.IApprovalIncInvoicePaidStage
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("16aa8863-3f80-486b-be94-069e6f7b4d94");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStage.ClassTypeGuid; }
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

    public new virtual global::Sungero.Contracts.IApprovalIncInvoicePaidStageState State
    {
      get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ApprovalIncInvoicePaidStageState(this);
    }

    public new virtual global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo Info
    {
      get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo)base.Info; }
    }

    public new virtual global::Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights AccessRights
    {
      get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStageAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStageFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Contracts.Shared.ApprovalIncInvoicePaidStageFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.ApprovalIncInvoicePaidStageServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.ApprovalIncInvoicePaidStageSharedHandlers(this);
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Contracts.ApprovalIncInvoicePaidStageCreatingFromServerHandler", new object[] { (global::Sungero.Contracts.IApprovalIncInvoicePaidStage)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Contracts.ApprovalIncInvoicePaidStageCreatingFromServerHandler((global::Sungero.Contracts.IApprovalIncInvoicePaidStage)entitySource, this.Info);
    }

    #region Framework events



    #endregion


    public ApprovalIncInvoicePaidStage()
    {
    }

  }
}

// ==================================================================
// ApprovalIncInvoicePaidStageHandlers.g.cs
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

  public partial class ApprovalIncInvoicePaidStageFilteringServerHandler<T>
    : global::Sungero.Docflow.ApprovalFunctionStageBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Contracts.IApprovalIncInvoicePaidStage
  {
    private global::Sungero.Contracts.IApprovalIncInvoicePaidStageFilterState _filter
    {
      get
      {
        return (Sungero.Contracts.IApprovalIncInvoicePaidStageFilterState)this.Filter;
      }
    }

    public ApprovalIncInvoicePaidStageFilteringServerHandler(global::Sungero.Contracts.IApprovalIncInvoicePaidStageFilterState filter)
    : base(filter)
    {
    }

    protected ApprovalIncInvoicePaidStageFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ApprovalIncInvoicePaidStageUiFilteringServerHandler<T>
    : global::Sungero.Docflow.ApprovalFunctionStageBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Contracts.IApprovalIncInvoicePaidStage
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ApprovalIncInvoicePaidStageSearchDialogServerHandler : global::Sungero.Docflow.ApprovalFunctionStageBaseSearchDialogServerHandler
   {
     private global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStageSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStageSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalIncInvoicePaidStageSearchDialogServerHandler(global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStageSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalIncInvoicePaidStageServerHandlers : global::Sungero.Docflow.ApprovalFunctionStageBaseServerHandlers
  {
    private global::Sungero.Contracts.IApprovalIncInvoicePaidStage _obj
    {
      get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStage)this.Entity; }
    }

    public ApprovalIncInvoicePaidStageServerHandlers(global::Sungero.Contracts.IApprovalIncInvoicePaidStage entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalIncInvoicePaidStageCreatingFromServerHandler : global::Sungero.Docflow.ApprovalFunctionStageBaseCreatingFromServerHandler
  {
    private global::Sungero.Contracts.IApprovalIncInvoicePaidStage _source
    {
      get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStage)this.Source; }
    }

    private global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo _info
    {
      get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo)this._Info; }
    }

    public ApprovalIncInvoicePaidStageCreatingFromServerHandler(global::Sungero.Contracts.IApprovalIncInvoicePaidStage source, global::Sungero.Contracts.IApprovalIncInvoicePaidStageInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalIncInvoicePaidStageEventArgs.g.cs
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
// ApprovalIncInvoicePaidStageAccessRights.g.cs
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
  public class ApprovalIncInvoicePaidStageAccessRights : 
    Sungero.Docflow.Server.ApprovalFunctionStageBaseAccessRights, Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights
  {

    public ApprovalIncInvoicePaidStageAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalIncInvoicePaidStageTypeAccessRights : 
    Sungero.Docflow.Server.ApprovalFunctionStageBaseTypeAccessRights, Sungero.Contracts.IApprovalIncInvoicePaidStageAccessRights
  {

    public ApprovalIncInvoicePaidStageTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
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

namespace Sungero.Contracts.Server
{
    public class ApprovalIncInvoicePaidStageRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.ApprovalFunctionStageBaseRepositoryImplementer<T>,
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
         return new global::Sungero.Contracts.Server.ApprovalIncInvoicePaidStageTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalIncInvoicePaidStagePanelNavigationFilters.g.cs
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
// ApprovalIncInvoicePaidStageServerFunctions.g.cs
// ==================================================================

namespace Sungero.Contracts.Server
{
  public partial class ApprovalIncInvoicePaidStageFunctions : global::Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions
  {
    private global::Sungero.Contracts.IApprovalIncInvoicePaidStage _obj
    {
      get { return (global::Sungero.Contracts.IApprovalIncInvoicePaidStage)this.Entity; }
    }

    public ApprovalIncInvoicePaidStageFunctions(global::Sungero.Contracts.IApprovalIncInvoicePaidStage entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalIncInvoicePaidStageFunctions.g.cs
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
  internal static class ApprovalIncInvoicePaidStage
  {
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ApprovalIncInvoicePaidStageFunctions" />
    internal static  Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult Execute(global::Sungero.Contracts.IApprovalIncInvoicePaidStage approvalIncInvoicePaidStage, global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalIncInvoicePaidStage).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("Execute", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { approvalTask });
    }
    /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ApprovalIncInvoicePaidStageFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Contracts.IIncomingInvoice> GetIncomingInvoicesToSetPaid(global::Sungero.Contracts.IApprovalIncInvoicePaidStage approvalIncInvoicePaidStage, global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalIncInvoicePaidStage).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetIncomingInvoicesToSetPaid", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::System.Collections.Generic.List<global::Sungero.Contracts.IIncomingInvoice>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { approvalTask });
    }

  }
}

// ==================================================================
// ApprovalIncInvoicePaidStageServerPublicFunctions.g.cs
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
  public class ApprovalIncInvoicePaidStageServerPublicFunctions : global::Sungero.Contracts.Server.IApprovalIncInvoicePaidStageServerPublicFunctions
  {
    public global::System.Collections.Generic.List<global::Sungero.Contracts.IIncomingInvoice> GetIncomingInvoicesToSetPaid(global::Sungero.Contracts.IApprovalIncInvoicePaidStage approvalIncInvoicePaidStage, global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      return global::Sungero.Contracts.Functions.ApprovalIncInvoicePaidStage.GetIncomingInvoicesToSetPaid(approvalIncInvoicePaidStage, approvalTask);
    }
  }
}

// ==================================================================
// ApprovalIncInvoicePaidStageQueries.g.cs
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
  public class ApprovalIncInvoicePaidStage
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Contracts.Server.ApprovalIncInvoicePaidStage.ApprovalIncInvoicePaidStageQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
