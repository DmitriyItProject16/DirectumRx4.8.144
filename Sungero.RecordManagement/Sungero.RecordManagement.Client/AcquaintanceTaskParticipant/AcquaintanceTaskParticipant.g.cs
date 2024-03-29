
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

namespace Sungero.RecordManagement.Client
{
  public class AcquaintanceTaskParticipant :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.RecordManagement.IAcquaintanceTaskParticipant
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("481ce37a-03d3-43b6-ac5b-3d8bcf9d3f9b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipant.ClassTypeGuid; }
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

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskParticipantState(this);
    }

    public new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?> _TaskId;

        public virtual global::System.Int64? TaskId
        {
          get { return this._TaskId.Value; }
          set { this._TaskId.Value = value; }
        }







          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees> _Employees;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees> Employees
          {
            get { return this._Employees.Value; }
          }






    private object _EmployeesActionsHandlers;

    public object EmployeesActionsHandlers
    {
      get
      {
        if (this._EmployeesActionsHandlers == null)
          this._EmployeesActionsHandlers = this.CreateEmployeesActionsHandlers();
        return this._EmployeesActionsHandlers;
      }
    }

    private object _EmployeesCollectionActionsHandlers;

    public object EmployeesCollectionActionsHandlers
    {
      get
      {
        if (this._EmployeesCollectionActionsHandlers == null)
          this._EmployeesCollectionActionsHandlers = this.CreateEmployeesCollectionActionsHandlers();
        return this._EmployeesCollectionActionsHandlers;
      }
    }

    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantAnyChildEntityCollectionActions();
    }

    protected virtual object CreateEmployeesActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateEmployeesCollectionActionsHandlers()
    {
      return null;
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskParticipantFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceTaskParticipantSharedHandlers(this);
    }

    #endregion

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


  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.RecordManagement.AcquaintanceTaskParticipantClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }


  protected global::System.Int64? TaskIdValueInputHandler(global::System.Int64? value)
  {
    var args = new global::Sungero.Presentation.LongIntegerValueInputEventArgs(this.TaskId, value, this, this.Info.Properties.TaskId);
    ((global::Sungero.RecordManagement.AcquaintanceTaskParticipantClientHandlers)this.Handlers).TaskIdValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors


            protected virtual void InitEmployeesCollectionProperty()
            {
              this._Employees = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees>("Employees", this);
              this._Employees.ValueChanged += (sender, e) => { this.EmployeesChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Employees);
              this.SetEmployeesEventHandlers();
            }

            protected void SetEmployeesEventHandlers()
            {
              this._Employees.ChildEntityAdded += this.EmployeesAddedHandler;
              this._Employees.ChildEntityDeleted += this.EmployeesDeletedHandler;
            }


    public AcquaintanceTaskParticipant()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._TaskId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int64?>("TaskId", this);
            this._TaskId.ValueChanged += (sender, e) => { this.TaskIdChangedHandler(); };
            this.AddProperty(this._TaskId);


            this.InitEmployeesCollectionProperty();







    }

    #endregion

  }
}

// ==================================================================
// AcquaintanceTaskParticipantPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class AcquaintanceTaskParticipantPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.RecordManagement.IAcquaintanceTaskParticipant
  {
    #region Fields and properties




    #endregion

    #region Methods


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion


                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _EmployeesEmployeeCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter EmployeesEmployeeCollectionPresenter
                          {
                  get { return this._EmployeesEmployeeCollectionPresenter; }
                }



    #region Constructors

    private void Init()
    {

                          this._EmployeesEmployeeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("3f4875f3-e1eb-460a-a744-805e2783110a"));
                        this._EmployeesEmployeeCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees), "Employee");


    }

    public AcquaintanceTaskParticipantPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// AcquaintanceTaskParticipantCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class AcquaintanceTaskParticipantCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IAcquaintanceTaskParticipant
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public AcquaintanceTaskParticipantCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public AcquaintanceTaskParticipantCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public AcquaintanceTaskParticipantCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public AcquaintanceTaskParticipantCollectionPresenter()
      : this(null, null) { }
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

namespace Sungero.RecordManagement.Client
{ 
  public class AcquaintanceTaskParticipantRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
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
         return new global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantTypeAccessRights(typeof(T));
       }
    }
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

namespace Sungero.RecordManagement.Client
{
  public class AcquaintanceTaskParticipantAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights
  {

    public AcquaintanceTaskParticipantAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class AcquaintanceTaskParticipantTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.RecordManagement.IAcquaintanceTaskParticipantAccessRights
  {

    public AcquaintanceTaskParticipantTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
