
// ==================================================================
// AcquaintanceCompleteNotification.g.cs
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
  public class AcquaintanceCompleteNotification :
    global::Sungero.Workflow.Client.Notice, global::Sungero.RecordManagement.IAcquaintanceCompleteNotification
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8484c5ba-5646-4327-9158-cd9fe0eb082b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.AcquaintanceCompleteNotification.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceCompleteNotification, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Subject; }
        set { this.Subject = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Subject"; }
      }


    public new global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceCompleteNotificationState(this);
    }

    public new global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceCompleteNotificationAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceCompleteNotificationActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceCompleteNotificationCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceCompleteNotificationAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceCompleteNotificationAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.AcquaintanceCompleteNotificationFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceCompleteNotificationFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceCompleteNotificationClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceCompleteNotificationSharedHandlers(this);
    }

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public AcquaintanceCompleteNotification()
    {








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.AcquaintanceCompleteNotificationDocumentGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.AcquaintanceCompleteNotificationAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.AcquaintanceCompleteNotificationOtherGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// AcquaintanceCompleteNotificationPresenter.g.cs
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
  public class AcquaintanceCompleteNotificationPresenter<T> :
    global::Sungero.Workflow.Client.NoticePresenter<T>
    where T : class, global::Sungero.RecordManagement.IAcquaintanceCompleteNotification
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



    #region Constructors

    private void Init()
    {
              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._PerformerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Performer");

              this._TaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "Task");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");


    }

    public AcquaintanceCompleteNotificationPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// AcquaintanceCompleteNotificationCollectionPresenter.g.cs
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
  public class AcquaintanceCompleteNotificationCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.NoticeCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IAcquaintanceCompleteNotification
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public AcquaintanceCompleteNotificationCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public AcquaintanceCompleteNotificationCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public AcquaintanceCompleteNotificationCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public AcquaintanceCompleteNotificationCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// AcquaintanceCompleteNotificationRepositoryImplementer.g.cs
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
  public class AcquaintanceCompleteNotificationRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.NoticeRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IAcquaintanceCompleteNotification
    {
       public new global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationInfo Info
       {
          get { return (global::Sungero.RecordManagement.IAcquaintanceCompleteNotificationInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.AcquaintanceCompleteNotificationTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// AcquaintanceCompleteNotificationAccessRights.g.cs
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
  public class AcquaintanceCompleteNotificationAccessRights : 
    Sungero.Workflow.Client.NoticeAccessRights, Sungero.RecordManagement.IAcquaintanceCompleteNotificationAccessRights
  {

    public AcquaintanceCompleteNotificationAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class AcquaintanceCompleteNotificationTypeAccessRights : 
    Sungero.Workflow.Client.NoticeTypeAccessRights, Sungero.RecordManagement.IAcquaintanceCompleteNotificationAccessRights
  {

    public AcquaintanceCompleteNotificationTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// AcquaintanceCompleteNotificationBlocksInfo.g.cs
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
}
