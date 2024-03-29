
// ==================================================================
// AcquaintanceTaskParticipant.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
    public class AcquaintanceTaskParticipantFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.RecordManagement.IAcquaintanceTaskParticipant
    {
      protected new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState Filter { get; private set; }

      private global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState filter
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

      public AcquaintanceTaskParticipantFilter(global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected AcquaintanceTaskParticipantFilter()
      {
      }
    }
      public class AcquaintanceTaskParticipantUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.RecordManagement.IAcquaintanceTaskParticipant
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class AcquaintanceTaskParticipantSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.Int64? TaskId { get; protected set; }



                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public AcquaintanceTaskParticipantEmployeesModel Employees { get; protected set; }

        }


      public class AcquaintanceTaskParticipantEmployeesModel : global::Sungero.Domain.CollectionPropertySearchDialogModel
          {
            public override global::System.Int64? Id { get; protected set; }


         }




  [global::Sungero.Domain.Filter(typeof(global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipantFilter<global::Sungero.RecordManagement.IAcquaintanceTaskParticipant>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipantUiFilter<global::Sungero.RecordManagement.IAcquaintanceTaskParticipant>))]

  public class AcquaintanceTaskParticipant :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.RecordManagement.IAcquaintanceTaskParticipant
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("481ce37a-03d3-43b6-ac5b-3d8bcf9d3f9b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipant.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceTaskParticipant, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceTaskParticipantState State
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskParticipantState(this);
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo Info
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo)base.Info; }
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights AccessRights
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipantAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipantFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskParticipantFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantSharedHandlers(this);
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
    private global::System.Int64? _TaskId;
    public virtual global::System.Int64? TaskId
    {
      get
      {
        return this._TaskId;
      }

      set
      {
        this.SetPropertyValue("TaskId", this._TaskId, value, (propertyValue) => { this._TaskId = propertyValue; }, this.TaskIdChangedHandler);
      }
    }








    protected global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees> _Employees;

    public virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees> Employees
    {
      get
      {
        if (this._Employees == null)
        {
          this._Employees = this.CreateEmployeesCollection();
          this.SetEmployeesEventHandlers();
        }
        return this._Employees;
      }

      set
      {
        if (this._Employees != null)
          this.UnsetChildCollectionEventHandlers(this._Employees);

        this._Employees = value;
        this.SetEmployeesEventHandlers();
      }
    }

    protected virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees> CreateEmployeesCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees>() { RootEntity = this };
    }

    private void SetEmployeesEventHandlers()
    {
      this.SetChildCollectionEventHandlers(this._Employees, "Employees");

      var changeNotifier = (global::Sungero.Domain.Shared.INotifyChildEntityCollectionChanged)this._Employees;
      changeNotifier.Added += this.EmployeesAddedHandler;
      changeNotifier.Deleted += this.EmployeesDeletedHandler;
      changeNotifier.Added += this.EmployeesCollectionUpdateEventHandler;
      changeNotifier.Deleted += this.EmployeesCollectionUpdateEventHandler;
      changeNotifier.Updated += this.EmployeesCollectionUpdateEventHandler;
    }

    private void EmployeesCollectionUpdateEventHandler(object sender, global::Sungero.Domain.Shared.BaseChildEntityEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      if (this.IsPropertyChangedHandlerEnabled && this.IsPropertyChangedAppliedHandlerEnabled("Employees"))
        this.EmployeesChangedHandler();
    }



    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.RecordManagement.AcquaintanceTaskParticipantCreatingFromServerHandler", new object[] { (global::Sungero.RecordManagement.IAcquaintanceTaskParticipant)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantCreatingFromServerHandler((global::Sungero.RecordManagement.IAcquaintanceTaskParticipant)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.RecordManagement.IAcquaintanceTaskParticipantSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void EmployeesChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.RecordManagement.IAcquaintanceTaskParticipantSharedHandlers)this.SharedHandlers).EmployeesChanged(args);
    }

    protected void TaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.TaskId, this.TaskId, this);
     ((global::Sungero.RecordManagement.IAcquaintanceTaskParticipantSharedHandlers)this.SharedHandlers).TaskIdChanged(args);
    }



    protected virtual global::Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesSharedCollectionHandlers CreateEmployeesAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesSharedCollectionHandlers CreateEmployeesDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void EmployeesAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("EmployeesAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateEmployeesAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.EmployeesAdded(args);
        }
      }
    }

    protected virtual void EmployeesDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceTaskParticipantEmployeesSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("EmployeesDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateEmployeesDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.EmployeesDeleted(args);
        }
      }
    }


    #endregion


    public AcquaintanceTaskParticipant()
    {
    }

  }
}

// ==================================================================
// AcquaintanceTaskParticipantHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

  public partial class AcquaintanceTaskParticipantFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.RecordManagement.IAcquaintanceTaskParticipant
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public AcquaintanceTaskParticipantFilteringServerHandler(global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected AcquaintanceTaskParticipantFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class AcquaintanceTaskParticipantUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.RecordManagement.IAcquaintanceTaskParticipant
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class AcquaintanceTaskParticipantSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipantSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipantSearchDialogModel)this.Dialog;
       }
     }

     public AcquaintanceTaskParticipantSearchDialogServerHandler(global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipantSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class AcquaintanceTaskParticipantServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipant _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipant)this.Entity; }
    }

    public AcquaintanceTaskParticipantServerHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskParticipant entity)
      : base(entity)
    {
    }
  }

  public partial class AcquaintanceTaskParticipantCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipant _source
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipant)this.Source; }
    }

    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo _info
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo)this._Info; }
    }

    public AcquaintanceTaskParticipantCreatingFromServerHandler(global::Sungero.RecordManagement.IAcquaintanceTaskParticipant source, global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// AcquaintanceTaskParticipantEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}

// ==================================================================
// AcquaintanceTaskParticipantAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class AcquaintanceTaskParticipantAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights
  {

    public AcquaintanceTaskParticipantAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class AcquaintanceTaskParticipantTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights
  {

    public AcquaintanceTaskParticipantTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// AcquaintanceTaskParticipantRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
    public class AcquaintanceTaskParticipantRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.RecordManagement.IAcquaintanceTaskParticipantRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IAcquaintanceTaskParticipant 
    {
       public new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo Info
       {
          get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Server.AcquaintanceTaskParticipantTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// AcquaintanceTaskParticipantPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}

// ==================================================================
// AcquaintanceTaskParticipantServerFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Server
{
  public partial class AcquaintanceTaskParticipantFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipant _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipant)this.Entity; }
    }

    public AcquaintanceTaskParticipantFunctions(global::Sungero.RecordManagement.IAcquaintanceTaskParticipant entity) : base(entity) { }
  }
}

// ==================================================================
// AcquaintanceTaskParticipantFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Functions
{
  internal static class AcquaintanceTaskParticipant
  {
  }
}

// ==================================================================
// AcquaintanceTaskParticipantServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class AcquaintanceTaskParticipantServerPublicFunctions : global::Sungero.RecordManagement.Server.IAcquaintanceTaskParticipantServerPublicFunctions
  {
  }
}

// ==================================================================
// AcquaintanceTaskParticipantQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Queries
{
  public class AcquaintanceTaskParticipant
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.AcquaintanceTaskParticipant.AcquaintanceTaskParticipantQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
