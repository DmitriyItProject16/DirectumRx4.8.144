
// ==================================================================
// ApprovalStageBase.g.cs
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
    public class ApprovalStageBaseFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.Docflow.IApprovalStageBase
    {
      protected new global::Sungero.Docflow.IApprovalStageBaseFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IApprovalStageBaseFilterState filter
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

      public ApprovalStageBaseFilter(global::Sungero.Docflow.IApprovalStageBaseFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ApprovalStageBaseFilter()
      {
      }
    }
      public class ApprovalStageBaseUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.Docflow.IApprovalStageBase
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ApprovalStageBaseSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.Int32? DeadlineInDays { get; protected set; }
                  public virtual global::System.Int32? DeadlineInHours { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ApprovalStageBaseFilter<global::Sungero.Docflow.IApprovalStageBase>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.ApprovalStageBaseUiFilter<global::Sungero.Docflow.IApprovalStageBase>))]

  public class ApprovalStageBase :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.Docflow.IApprovalStageBase
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("25b9ee46-e1e8-4e70-8d82-b2e7f2e03f5d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalStageBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalStageBase, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IApprovalStageBaseState State
    {
      get { return (global::Sungero.Docflow.IApprovalStageBaseState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageBaseState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalStageBaseInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalStageBaseInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IApprovalStageBaseAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IApprovalStageBaseAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ApprovalStageBaseAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ApprovalStageBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageBaseFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalStageBaseServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalStageBaseSharedHandlers(this);
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
    private global::System.String _Note;
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }
    private global::System.Int32? _DeadlineInDays;
    public virtual global::System.Int32? DeadlineInDays
    {
      get
      {
        return this._DeadlineInDays;
      }

      set
      {
        this.SetPropertyValue("DeadlineInDays", this._DeadlineInDays, value, (propertyValue) => { this._DeadlineInDays = propertyValue; }, this.DeadlineInDaysChangedHandler);
      }
    }
    private global::System.Int32? _DeadlineInHours;
    public virtual global::System.Int32? DeadlineInHours
    {
      get
      {
        return this._DeadlineInHours;
      }

      set
      {
        this.SetPropertyValue("DeadlineInHours", this._DeadlineInHours, value, (propertyValue) => { this._DeadlineInHours = propertyValue; }, this.DeadlineInHoursChangedHandler);
      }
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ApprovalStageBaseCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IApprovalStageBase)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ApprovalStageBaseCreatingFromServerHandler((global::Sungero.Docflow.IApprovalStageBase)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Docflow.IApprovalStageBaseSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Docflow.IApprovalStageBaseSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }

    protected void DeadlineInDaysChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DeadlineInDays, this.DeadlineInDays, this);
     ((global::Sungero.Docflow.IApprovalStageBaseSharedHandlers)this.SharedHandlers).DeadlineInDaysChanged(args);
    }

    protected void DeadlineInHoursChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DeadlineInHours, this.DeadlineInHours, this);
     ((global::Sungero.Docflow.IApprovalStageBaseSharedHandlers)this.SharedHandlers).DeadlineInHoursChanged(args);
    }



    #endregion


    public ApprovalStageBase()
    {
    }

  }
}

// ==================================================================
// ApprovalStageBaseHandlers.g.cs
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

  public partial class ApprovalStageBaseFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IApprovalStageBase
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IApprovalStageBaseFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalStageBaseFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalStageBaseFilteringServerHandler(global::Sungero.Docflow.IApprovalStageBaseFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalStageBaseFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ApprovalStageBaseUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IApprovalStageBase
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ApprovalStageBaseSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ApprovalStageBaseSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ApprovalStageBaseSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalStageBaseSearchDialogServerHandler(global::Sungero.Docflow.Server.ApprovalStageBaseSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalStageBaseServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.Docflow.IApprovalStageBase _obj
    {
      get { return (global::Sungero.Docflow.IApprovalStageBase)this.Entity; }
    }

    public ApprovalStageBaseServerHandlers(global::Sungero.Docflow.IApprovalStageBase entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalStageBaseCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IApprovalStageBase _source
    {
      get { return (global::Sungero.Docflow.IApprovalStageBase)this.Source; }
    }

    private global::Sungero.Docflow.IApprovalStageBaseInfo _info
    {
      get { return (global::Sungero.Docflow.IApprovalStageBaseInfo)this._Info; }
    }

    public ApprovalStageBaseCreatingFromServerHandler(global::Sungero.Docflow.IApprovalStageBase source, global::Sungero.Docflow.IApprovalStageBaseInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalStageBaseEventArgs.g.cs
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
// ApprovalStageBaseAccessRights.g.cs
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
  public class ApprovalStageBaseAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.Docflow.IApprovalStageBaseAccessRights
  {

    public ApprovalStageBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalStageBaseTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.Docflow.IApprovalStageBaseAccessRights
  {

    public ApprovalStageBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalStageBaseRepositoryImplementer.g.cs
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
    public class ApprovalStageBaseRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalStageBaseRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalStageBase 
    {
       public new global::Sungero.Docflow.IApprovalStageBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalStageBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalStageBaseInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalStageBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ApprovalStageBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalStageBasePanelNavigationFilters.g.cs
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
// ApprovalStageBaseServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ApprovalStageBaseFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IApprovalStageBase _obj
    {
      get { return (global::Sungero.Docflow.IApprovalStageBase)this.Entity; }
    }

    public ApprovalStageBaseFunctions(global::Sungero.Docflow.IApprovalStageBase entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalStageBaseFunctions.g.cs
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
  internal static class ApprovalStageBase
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalStageBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IApprovalRuleBase> GetApprovalRules(global::Sungero.Docflow.IApprovalStageBase approvalStageBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetApprovalRules", new System.Type[] {  });
      return (global::System.Linq.IQueryable<global::Sungero.Docflow.IApprovalRuleBase>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalStageBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Boolean HasRules(global::Sungero.Docflow.IApprovalStageBase approvalStageBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasRules", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalStageBaseFunctions" />
    internal static  void AddStageToRoute(global::Sungero.Docflow.IApprovalStageBase approvalStageBase, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleCardReport.ConditionTableLine> linedRoute, global::System.String prefix, global::System.Int32 level)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddStageToRoute", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleCardReport.ConditionTableLine>), typeof(global::System.String), typeof(global::System.Int32) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { linedRoute, prefix, level });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalStageBaseFunctions" />
    internal static  global::System.DateTime GetStageMaxDeadline(global::Sungero.Docflow.IApprovalStageBase approvalStageBase, global::Sungero.Docflow.IApprovalTask task, global::System.DateTime maxDeadline, global::System.Boolean stageInProcess)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStageMaxDeadline", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask), typeof(global::System.DateTime), typeof(global::System.Boolean) });
      return (global::System.DateTime)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task, maxDeadline, stageInProcess });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalStageBaseFunctions" />
    internal static  void ValidateStageDeadline(global::Sungero.Docflow.IApprovalStageBase approvalStageBase, Sungero.Domain.BeforeSaveEventArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateStageDeadline", new System.Type[] { typeof(Sungero.Domain.BeforeSaveEventArgs) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalStageBaseFunctions" />
    internal static  void Validate(global::Sungero.Docflow.IApprovalStageBase approvalStageBase, global::Sungero.Docflow.IApprovalRuleBase rule, global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBaseStages> stagesSequence, global::Sungero.Docflow.IApprovalRuleBaseStages stage, Sungero.Domain.BeforeSaveEventArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("Validate", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalRuleBase), typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBaseStages>), typeof(global::Sungero.Docflow.IApprovalRuleBaseStages), typeof(Sungero.Domain.BeforeSaveEventArgs) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { rule, stagesSequence, stage, e });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalStageBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>> GetSupportableRoles(global::Sungero.Docflow.IApprovalStageBase approvalStageBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetSupportableRoles", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalStageBaseFunctions" />
    internal static  global::System.Nullable<global::Sungero.Core.Enumeration> GetStageType(global::Sungero.Docflow.IApprovalStageBase approvalStageBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStageType", new System.Type[] {  });
      return (global::System.Nullable<global::Sungero.Core.Enumeration>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalStageBaseFunctions" />
    internal static  global::System.String GetDeadlineDescription(global::Sungero.Docflow.IApprovalStageBase approvalStageBase, global::System.Int32 performersCount, global::System.String daysHoursSeparator, global::System.Boolean needHoursConvert, global::System.Boolean isParallel)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalStageBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDeadlineDescription", new System.Type[] { typeof(global::System.Int32), typeof(global::System.String), typeof(global::System.Boolean), typeof(global::System.Boolean) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { performersCount, daysHoursSeparator, needHoursConvert, isParallel });
    }

  }
}

// ==================================================================
// ApprovalStageBaseServerPublicFunctions.g.cs
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
  public class ApprovalStageBaseServerPublicFunctions : global::Sungero.Docflow.Server.IApprovalStageBaseServerPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalStageBaseQueries.g.cs
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
  public class ApprovalStageBase
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.ApprovalStageBase.ApprovalStageBaseQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
