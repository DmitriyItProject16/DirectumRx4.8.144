
// ==================================================================
// AIManagersAssistant.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Intelligence.Client
{
  public class AIManagersAssistant :
    global::Sungero.Company.Client.ManagersAssistantBase, global::Sungero.Intelligence.IAIManagersAssistant
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("fa9b109f-ec37-4d99-aec0-cf95fd7acdd4");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Intelligence.Client.AIManagersAssistant.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Intelligence.IAIManagersAssistant, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Manager == null ? string.Empty : this.Manager.ToString(); }
        set { throw new global::System.NotSupportedException(global::CommonLibrary.Properties.Resources.SpecifiedPropertyIsNotSupportedFormat("DisplayValue")); }
      }

      public override string DisplayPropertyName
      {
        get { return "Manager"; }
      }


    public new global::Sungero.Intelligence.IAIManagersAssistantState State
    {
      get
      {
        return (global::Sungero.Intelligence.IAIManagersAssistantState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Intelligence.Shared.AIManagersAssistantState(this);
    }

    public new global::Sungero.Intelligence.IAIManagersAssistantInfo Info
    {
      get
      {
        return (global::Sungero.Intelligence.IAIManagersAssistantInfo)base.Info;
      }
    }

    public new global::Sungero.Intelligence.IAIManagersAssistantAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Intelligence.IAIManagersAssistantAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Intelligence.Client.AIManagersAssistantAccessRights(this);
    }







          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.Intelligence.IAIManagersAssistantClassifiers> _Classifiers;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Intelligence.IAIManagersAssistantClassifiers> Classifiers
          {
            get { return this._Classifiers.Value; }
          }






    private object _ClassifiersActionsHandlers;

    public object ClassifiersActionsHandlers
    {
      get
      {
        if (this._ClassifiersActionsHandlers == null)
          this._ClassifiersActionsHandlers = this.CreateClassifiersActionsHandlers();
        return this._ClassifiersActionsHandlers;
      }
    }

    private object _ClassifiersCollectionActionsHandlers;

    public object ClassifiersCollectionActionsHandlers
    {
      get
      {
        if (this._ClassifiersCollectionActionsHandlers == null)
          this._ClassifiersCollectionActionsHandlers = this.CreateClassifiersCollectionActionsHandlers();
        return this._ClassifiersCollectionActionsHandlers;
      }
    }

    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Intelligence.Client.AIManagersAssistantActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Intelligence.Client.AIManagersAssistantCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Intelligence.Client.AIManagersAssistantAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Intelligence.Client.AIManagersAssistantAnyChildEntityCollectionActions();
    }

    protected virtual object CreateClassifiersActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateClassifiersCollectionActionsHandlers()
    {
      return null;
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Intelligence.Client.AIManagersAssistantFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Intelligence.Shared.AIManagersAssistantFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Intelligence.AIManagersAssistantClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Intelligence.AIManagersAssistantSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ClassifiersChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Intelligence.IAIManagersAssistantSharedHandlers)this.SharedHandlers).ClassifiersChanged(args);
    }



    protected virtual global::Sungero.Intelligence.AIManagersAssistantClassifiersSharedCollectionHandlers CreateClassifiersAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Intelligence.AIManagersAssistantClassifiersSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Intelligence.AIManagersAssistantClassifiersSharedCollectionHandlers CreateClassifiersDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Intelligence.AIManagersAssistantClassifiersSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void ClassifiersAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Intelligence.AIManagersAssistantClassifiersSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("ClassifiersAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateClassifiersAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.ClassifiersAdded(args);
        }
      }
    }

    protected virtual void ClassifiersDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Intelligence.AIManagersAssistantClassifiersSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("ClassifiersDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateClassifiersDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.ClassifiersDeleted(args);
        }
      }
    }




    #endregion

    #region Constructors



            protected virtual void InitClassifiersCollectionProperty()
            {
              this._Classifiers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Intelligence.IAIManagersAssistantClassifiers>("Classifiers", this);
              this._Classifiers.ValueChanged += (sender, e) => { this.ClassifiersChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Classifiers);
              this.SetClassifiersEventHandlers();
            }

            protected void SetClassifiersEventHandlers()
            {
              this._Classifiers.ChildEntityAdded += this.ClassifiersAddedHandler;
              this._Classifiers.ChildEntityDeleted += this.ClassifiersDeletedHandler;
            }


    public AIManagersAssistant()
    {


            this.InitClassifiersCollectionProperty();







    }

    #endregion

  }
}

// ==================================================================
// AIManagersAssistantPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Intelligence.Client
{
  public class AIManagersAssistantPresenter<T> :
    global::Sungero.Company.Client.ManagersAssistantBasePresenter<T>
    where T : class, global::Sungero.Intelligence.IAIManagersAssistant
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _UnpublishClassifierModelCommand;

          public global::System.Windows.Input.ICommand UnpublishClassifierModelCommand
          {
            get
            {
              if (this._UnpublishClassifierModelCommand == null)
                  this._UnpublishClassifierModelCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("UnpublishClassifierModel", this, this.UnpublishClassifierModel, this.CanUnpublishClassifierModel) { IsEmptyParameterAllowed = true };
              return this._UnpublishClassifierModelCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanUnpublishClassifierModel(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Intelligence.Client.AIManagersAssistantActions)(entity as Sungero.Intelligence.Client.AIManagersAssistant).ActionsHandlers).CanUnpublishClassifierModel(args);
              }

              private void UnpublishClassifierModel(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.UnpublishClassifierModel);
                ((Sungero.Intelligence.Client.AIManagersAssistantActions)(entity as Sungero.Intelligence.Client.AIManagersAssistant).ActionsHandlers).UnpublishClassifierModel(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion



    #region Constructors

    private void Init()
    {
              this._ManagerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Manager");


    }

    public AIManagersAssistantPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// AIManagersAssistantCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Intelligence.Client
{
  public class AIManagersAssistantCollectionPresenter<T> : 
    global::Sungero.Company.Client.ManagersAssistantBaseCollectionPresenter<T>
    where T: class, global::Sungero.Intelligence.IAIManagersAssistant
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public AIManagersAssistantCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public AIManagersAssistantCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public AIManagersAssistantCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public AIManagersAssistantCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// AIManagersAssistantRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Intelligence.Client
{ 
  public class AIManagersAssistantRepositoryImplementer<T> : 
      global::Sungero.Company.Client.ManagersAssistantBaseRepositoryImplementer<T>,
      global::Sungero.Intelligence.IAIManagersAssistantRepositoryImplementer<T>
      where T : global::Sungero.Intelligence.IAIManagersAssistant
    {
       public new global::Sungero.Intelligence.IAIManagersAssistantAccessRights AccessRights
       {
          get { return (global::Sungero.Intelligence.IAIManagersAssistantAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Intelligence.IAIManagersAssistantInfo Info
       {
          get { return (global::Sungero.Intelligence.IAIManagersAssistantInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Intelligence.Client.AIManagersAssistantTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// AIManagersAssistantAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Intelligence.Client
{
  public class AIManagersAssistantAccessRights : 
    Sungero.Company.Client.ManagersAssistantBaseAccessRights, Sungero.Intelligence.IAIManagersAssistantAccessRights
  {

    public AIManagersAssistantAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class AIManagersAssistantTypeAccessRights : 
    Sungero.Company.Client.ManagersAssistantBaseTypeAccessRights, Sungero.Intelligence.IAIManagersAssistantAccessRights
  {

    public AIManagersAssistantTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}