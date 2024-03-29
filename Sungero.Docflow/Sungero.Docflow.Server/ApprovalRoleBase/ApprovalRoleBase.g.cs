
// ==================================================================
// ApprovalRoleBase.g.cs
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
    public class ApprovalRoleBaseFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.Docflow.IApprovalRoleBase
    {
      protected new global::Sungero.Docflow.IApprovalRoleBaseFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IApprovalRoleBaseFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ApprovalRoleBaseFilter(global::Sungero.Docflow.IApprovalRoleBaseFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ApprovalRoleBaseFilter()
      {
      }
    }
      public class ApprovalRoleBaseUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.Docflow.IApprovalRoleBase
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ApprovalRoleBaseSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.String Description { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Type { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ApprovalRoleBaseFilter<global::Sungero.Docflow.IApprovalRoleBase>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.ApprovalRoleBaseUiFilter<global::Sungero.Docflow.IApprovalRoleBase>))]

  public class ApprovalRoleBase :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.Docflow.IApprovalRoleBase
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("3445f357-1435-4444-9f24-a56a752fc471");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalRoleBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRoleBase, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IApprovalRoleBaseState State
    {
      get { return (global::Sungero.Docflow.IApprovalRoleBaseState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRoleBaseState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalRoleBaseInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalRoleBaseInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IApprovalRoleBaseAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IApprovalRoleBaseAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ApprovalRoleBaseAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ApprovalRoleBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRoleBaseFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalRoleBaseServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRoleBaseSharedHandlers(this);
    }

    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }
    private global::System.String _Description;
    public virtual global::System.String Description
    {
      get
      {
        return this._Description;
      }

      set
      {
        this.SetPropertyValue("Description", this._Description, value, (propertyValue) => { this._Description = propertyValue; }, this.DescriptionChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _TypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.ApprovalRoleBase.Type),
      typeof(global::Sungero.Docflow.Server.ApprovalRoleBase),
      "Type");

    public static global::Sungero.Domain.Shared.EnumerationItems TypeItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalRoleBase._TypeItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems TypeAllowedItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalRoleBase.TypeItems; }
    }

    private global::Sungero.Core.Enumeration? _Type;

    public virtual global::Sungero.Core.Enumeration? Type
    {
      get { return this._Type; }
      set { this.SetEnumPropertyValue("Type", this._Type, value, (propertyValue) => { this._Type = propertyValue; }, this.TypeChangedHandler, this.TypeAllowedItems); }
    }





    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ApprovalRoleBaseCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IApprovalRoleBase)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ApprovalRoleBaseCreatingFromServerHandler((global::Sungero.Docflow.IApprovalRoleBase)entitySource, this.Info);
    }

    #region Framework events

    protected void TypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Type, this.Type, this);
     ((global::Sungero.Docflow.IApprovalRoleBaseSharedHandlers)this.SharedHandlers).TypeChanged(args);
    }

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Docflow.IApprovalRoleBaseSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void DescriptionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Description, this.Description, this);
     ((global::Sungero.Docflow.IApprovalRoleBaseSharedHandlers)this.SharedHandlers).DescriptionChanged(args);
    }



    #endregion


    public ApprovalRoleBase()
    {
    }

  }
}

// ==================================================================
// ApprovalRoleBaseHandlers.g.cs
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

  public partial class ApprovalRoleBaseFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IApprovalRoleBase
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IApprovalRoleBaseFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalRoleBaseFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalRoleBaseFilteringServerHandler(global::Sungero.Docflow.IApprovalRoleBaseFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalRoleBaseFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ApprovalRoleBaseUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IApprovalRoleBase
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ApprovalRoleBaseSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ApprovalRoleBaseSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ApprovalRoleBaseSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalRoleBaseSearchDialogServerHandler(global::Sungero.Docflow.Server.ApprovalRoleBaseSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalRoleBaseServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.Docflow.IApprovalRoleBase _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRoleBase)this.Entity; }
    }

    public ApprovalRoleBaseServerHandlers(global::Sungero.Docflow.IApprovalRoleBase entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalRoleBaseCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IApprovalRoleBase _source
    {
      get { return (global::Sungero.Docflow.IApprovalRoleBase)this.Source; }
    }

    private global::Sungero.Docflow.IApprovalRoleBaseInfo _info
    {
      get { return (global::Sungero.Docflow.IApprovalRoleBaseInfo)this._Info; }
    }

    public ApprovalRoleBaseCreatingFromServerHandler(global::Sungero.Docflow.IApprovalRoleBase source, global::Sungero.Docflow.IApprovalRoleBaseInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalRoleBaseEventArgs.g.cs
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

// ==================================================================
// ApprovalRoleBaseAccessRights.g.cs
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
  public class ApprovalRoleBaseAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.Docflow.IApprovalRoleBaseAccessRights
  {

    public ApprovalRoleBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalRoleBaseTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.Docflow.IApprovalRoleBaseAccessRights
  {

    public ApprovalRoleBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalRoleBaseRepositoryImplementer.g.cs
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
    public class ApprovalRoleBaseRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalRoleBaseRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalRoleBase 
    {
       public new global::Sungero.Docflow.IApprovalRoleBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalRoleBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalRoleBaseInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalRoleBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ApprovalRoleBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalRoleBasePanelNavigationFilters.g.cs
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

// ==================================================================
// ApprovalRoleBaseServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ApprovalRoleBaseFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IApprovalRoleBase _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRoleBase)this.Entity; }
    }

    public ApprovalRoleBaseFunctions(global::Sungero.Docflow.IApprovalRoleBase entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalRoleBaseFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class ApprovalRoleBase
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRoleBaseFunctions" />
    internal static  global::Sungero.Company.IEmployee GetPerformer(global::System.Nullable<global::Sungero.Core.Enumeration> roleType, global::Sungero.Docflow.IApprovalTask task)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.ApprovalRoleBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetPerformer",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::Sungero.Docflow.IApprovalTask) }, null);
        return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { roleType, task });
      }
      else
      {
        return global::Sungero.Docflow.Server.ApprovalRoleBaseFunctions.GetPerformer(roleType, task);
      }
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRoleBaseFunctions" />
    internal static  global::Sungero.Company.IEmployee GetRolePerformer(global::Sungero.Docflow.IApprovalRoleBase approvalRoleBase, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRoleBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRolePerformer", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRoleBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetApproversRolePerformers(global::Sungero.Docflow.IApprovalRoleBase approvalRoleBase, global::Sungero.Docflow.IApprovalTask task, global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient> additionalApprovers)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRoleBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetApproversRolePerformers", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask), typeof(global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient>) });
      return (global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task, additionalApprovers });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRoleBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetAddresseesRolePerformers(global::Sungero.Docflow.IApprovalRoleBase approvalRoleBase, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRoleBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAddresseesRolePerformers", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRoleBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetRolePerformers(global::Sungero.Docflow.IApprovalRoleBase approvalRoleBase, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRoleBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRolePerformers", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRoleBaseFunctions" />
    internal static  global::Sungero.Docflow.IApprovalRoleBase GetRole(global::System.Nullable<global::Sungero.Core.Enumeration> roleType)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.ApprovalRoleBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetRole",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) }, null);
        return (global::Sungero.Docflow.IApprovalRoleBase)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { roleType });
      }
      else
      {
        return global::Sungero.Docflow.Shared.ApprovalRoleBaseFunctions.GetRole(roleType);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRoleBaseFunctions" />
    internal static  global::System.Boolean SupportDocumentKinds(global::Sungero.Docflow.IApprovalRoleBase approvalRoleBase, global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind> kinds)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRoleBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SupportDocumentKinds", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind>) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { kinds });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRoleBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind> Filter(global::Sungero.Docflow.IApprovalRoleBase approvalRoleBase, global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind> kinds)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalRoleBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("Filter", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind>) });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { kinds });
    }

  }
}

// ==================================================================
// ApprovalRoleBaseServerPublicFunctions.g.cs
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
  public class ApprovalRoleBaseServerPublicFunctions : global::Sungero.Docflow.Server.IApprovalRoleBaseServerPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalRoleBaseQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class ApprovalRoleBase
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.ApprovalRoleBase.ApprovalRoleBaseQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
