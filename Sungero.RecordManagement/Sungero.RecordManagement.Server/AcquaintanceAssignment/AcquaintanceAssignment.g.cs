
// ==================================================================
// AcquaintanceAssignment.g.cs
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
    public class AcquaintanceAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.RecordManagement.IAcquaintanceAssignment
    {
      protected new global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState Filter { get; private set; }

      private global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState filter
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

      public AcquaintanceAssignmentFilter(global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected AcquaintanceAssignmentFilter()
      {
      }
    }
    public class AcquaintanceAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Subject { get; protected set; }
                  public override global::System.Boolean? HasSubtasksInProcess { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Performer { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Importance { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Deadline { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Result { get; protected set; }




                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public AcquaintanceAssignmentAcquaintanceVersionsModel AcquaintanceVersions { get; protected set; }

        }


      public class AcquaintanceAssignmentAcquaintanceVersionsModel : global::Sungero.Domain.CollectionPropertySearchDialogModel
          {
            public override global::System.Int64? Id { get; protected set; }


         }




  [global::Sungero.Domain.Filter(typeof(global::Sungero.RecordManagement.Server.AcquaintanceAssignmentFilter<global::Sungero.RecordManagement.IAcquaintanceAssignment>))]

  public class AcquaintanceAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.RecordManagement.IAcquaintanceAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8fee99ee-b3fd-49dd-9b48-e51b83597227");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.AcquaintanceAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceAssignmentState State
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceAssignmentState(this);
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceAssignmentInfo Info
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Server.AcquaintanceAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.RecordManagement.Server.AcquaintanceAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceAssignmentSharedHandlers(this);
    }



    private global::System.String _Description;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
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




    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.RecordManagement.AcquaintanceAssignment.Result),
      typeof(global::Sungero.RecordManagement.Server.AcquaintanceAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.RecordManagement.Server.AcquaintanceAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.RecordManagement.Server.AcquaintanceAssignment.ResultItems; }
    }




    protected global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions> _AcquaintanceVersions;

    public virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions> AcquaintanceVersions
    {
      get
      {
        if (this._AcquaintanceVersions == null)
        {
          this._AcquaintanceVersions = this.CreateAcquaintanceVersionsCollection();
          this.SetAcquaintanceVersionsEventHandlers();
        }
        return this._AcquaintanceVersions;
      }

      set
      {
        if (this._AcquaintanceVersions != null)
          this.UnsetChildCollectionEventHandlers(this._AcquaintanceVersions);

        this._AcquaintanceVersions = value;
        this.SetAcquaintanceVersionsEventHandlers();
      }
    }

    protected virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions> CreateAcquaintanceVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions>() { RootEntity = this };
    }

    private void SetAcquaintanceVersionsEventHandlers()
    {
      this.SetChildCollectionEventHandlers(this._AcquaintanceVersions, "AcquaintanceVersions");

      var changeNotifier = (global::Sungero.Domain.Shared.INotifyChildEntityCollectionChanged)this._AcquaintanceVersions;
      changeNotifier.Added += this.AcquaintanceVersionsAddedHandler;
      changeNotifier.Deleted += this.AcquaintanceVersionsDeletedHandler;
      changeNotifier.Added += this.AcquaintanceVersionsCollectionUpdateEventHandler;
      changeNotifier.Deleted += this.AcquaintanceVersionsCollectionUpdateEventHandler;
      changeNotifier.Updated += this.AcquaintanceVersionsCollectionUpdateEventHandler;
    }

    private void AcquaintanceVersionsCollectionUpdateEventHandler(object sender, global::Sungero.Domain.Shared.BaseChildEntityEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      if (this.IsPropertyChangedHandlerEnabled && this.IsPropertyChangedAppliedHandlerEnabled("AcquaintanceVersions"))
        this.AcquaintanceVersionsChangedHandler();
    }



    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.RecordManagement.AcquaintanceAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.RecordManagement.IAcquaintanceAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.RecordManagement.AcquaintanceAssignmentCreatingFromServerHandler((global::Sungero.RecordManagement.IAcquaintanceAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void AcquaintanceVersionsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).AcquaintanceVersionsChanged(args);
    }

    protected void DescriptionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Description, this.Description, this);
     ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).DescriptionChanged(args);
    }



    protected virtual global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsSharedCollectionHandlers CreateAcquaintanceVersionsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsSharedCollectionHandlers CreateAcquaintanceVersionsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void AcquaintanceVersionsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("AcquaintanceVersionsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateAcquaintanceVersionsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.AcquaintanceVersionsAdded(args);
        }
      }
    }

    protected virtual void AcquaintanceVersionsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceAssignmentAcquaintanceVersionsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("AcquaintanceVersionsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateAcquaintanceVersionsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.AcquaintanceVersionsDeleted(args);
        }
      }
    }


    #endregion


    public AcquaintanceAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IAcquaintanceAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.AcquaintanceAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IAcquaintanceAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.AcquaintanceAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IAcquaintanceAssignmentDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.AcquaintanceAssignmentDocumentGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.RecordManagement.IAcquaintanceAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// AcquaintanceAssignmentHandlers.g.cs
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

  public partial class AcquaintanceAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.RecordManagement.IAcquaintanceAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public AcquaintanceAssignmentFilteringServerHandler(global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected AcquaintanceAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class AcquaintanceAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.RecordManagement.Server.AcquaintanceAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.RecordManagement.Server.AcquaintanceAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public AcquaintanceAssignmentSearchDialogServerHandler(global::Sungero.RecordManagement.Server.AcquaintanceAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class AcquaintanceAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignment)this.Entity; }
    }

    public AcquaintanceAssignmentServerHandlers(global::Sungero.RecordManagement.IAcquaintanceAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class AcquaintanceAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.RecordManagement.IAcquaintanceAssignment _source
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignment)this.Source; }
    }

    private global::Sungero.RecordManagement.IAcquaintanceAssignmentInfo _info
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignmentInfo)this._Info; }
    }

    public AcquaintanceAssignmentCreatingFromServerHandler(global::Sungero.RecordManagement.IAcquaintanceAssignment source, global::Sungero.RecordManagement.IAcquaintanceAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// AcquaintanceAssignmentEventArgs.g.cs
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
// AcquaintanceAssignmentAccessRights.g.cs
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
  public class AcquaintanceAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.RecordManagement.IAcquaintanceAssignmentAccessRights
  {

    public AcquaintanceAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class AcquaintanceAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.RecordManagement.IAcquaintanceAssignmentAccessRights
  {

    public AcquaintanceAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// AcquaintanceAssignmentRepositoryImplementer.g.cs
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
    public class AcquaintanceAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IAcquaintanceAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IAcquaintanceAssignment 
    {
       public new global::Sungero.RecordManagement.IAcquaintanceAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IAcquaintanceAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IAcquaintanceAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IAcquaintanceAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Server.AcquaintanceAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// AcquaintanceAssignmentPanelNavigationFilters.g.cs
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
// AcquaintanceAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Server
{
  public partial class AcquaintanceAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IAcquaintanceAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignment)this.Entity; }
    }

    public AcquaintanceAssignmentFunctions(global::Sungero.RecordManagement.IAcquaintanceAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// AcquaintanceAssignmentFunctions.g.cs
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
  internal static class AcquaintanceAssignment
  {
    /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceAssignmentFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Boolean IsSubstituteOf(global::Sungero.RecordManagement.IAcquaintanceAssignment acquaintanceAssignment, global::Sungero.CoreEntities.IUser who, global::Sungero.CoreEntities.IUser whom)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceAssignment).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("IsSubstituteOf", new System.Type[] { typeof(global::Sungero.CoreEntities.IUser), typeof(global::Sungero.CoreEntities.IUser) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { who, whom });
    }

    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceAssignmentFunctions" />
    internal static  void StoreAcquaintanceVersion(global::Sungero.RecordManagement.IAcquaintanceAssignment acquaintanceAssignment, global::Sungero.Content.IElectronicDocument document, global::System.Boolean isMainDocument, global::System.Nullable<global::System.Int32> mainDocumentTaskVersionNumber)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("StoreAcquaintanceVersion", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument), typeof(global::System.Boolean), typeof(global::System.Nullable<global::System.Int32>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, isMainDocument, mainDocumentTaskVersionNumber });
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceAssignmentFunctions" />
    internal static  global::System.Boolean CanUserCompleteAcquaintanceBySubstitute(global::Sungero.RecordManagement.IAcquaintanceAssignment acquaintanceAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanUserCompleteAcquaintanceBySubstitute", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// AcquaintanceAssignmentServerPublicFunctions.g.cs
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
  public class AcquaintanceAssignmentServerPublicFunctions : global::Sungero.RecordManagement.Server.IAcquaintanceAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// AcquaintanceAssignmentQueries.g.cs
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
  public class AcquaintanceAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.AcquaintanceAssignment.AcquaintanceAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// AcquaintanceAssignmentBlock.g.cs
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
  public class AcquaintanceAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<AcquaintanceAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public AcquaintanceAssignmentArguments(AcquaintanceAssignmentBlock block) : base(block) { }
  }

  public class AcquaintanceAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<AcquaintanceAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.RecordManagement.IAcquaintanceAssignment> 
  {
    public AcquaintanceAssignmentEndBlockEventArguments(AcquaintanceAssignmentBlock block) : base(block) { }
  }

  public partial class AcquaintanceAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {

    private global::Sungero.Workflow.Blocks.IChildCollectionWrapper<global::Sungero.RecordManagement.Server.AcquaintanceAssignmentAcquaintanceVersionsWrapper> _AcquaintanceVersions;

	protected virtual global::Sungero.Workflow.Blocks.IChildCollectionWrapper<global::Sungero.RecordManagement.Server.AcquaintanceAssignmentAcquaintanceVersionsWrapper> GetAcquaintanceAssignmentAcquaintanceVersionsCollectionWrapper(global::System.Collections.ObjectModel.Collection<global::System.Collections.ObjectModel.Collection<global::Sungero.Workflow.CustomTypeProperty>> items)
	{
	  return new global::Sungero.RecordManagement.Server.AcquaintanceAssignmentAcquaintanceVersionsCollectionWrapper(items);
	}

    public virtual global::Sungero.Workflow.Blocks.IChildCollectionWrapper<global::Sungero.RecordManagement.Server.AcquaintanceAssignmentAcquaintanceVersionsWrapper> AcquaintanceVersions
    {
      get 
      {
        if(this._AcquaintanceVersions == null)
        {
          var items = this.GetCustomCollectionPropertyInternalValue("AcquaintanceVersions"); 
          this._AcquaintanceVersions = this.GetAcquaintanceAssignmentAcquaintanceVersionsCollectionWrapper(items);
        }

        return this._AcquaintanceVersions;
      }
    }



    public AcquaintanceAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// AcquaintanceAssignmentChildWrappers.g.cs
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
  public class AcquaintanceAssignmentAcquaintanceVersionsCollectionWrapper :
       global::Sungero.Workflow.Blocks.ChildCollectionWrapper<AcquaintanceAssignmentAcquaintanceVersionsWrapper>
  {
    protected override AcquaintanceAssignmentAcquaintanceVersionsWrapper CreateWrapper(global::System.Collections.ObjectModel.Collection<global::Sungero.Workflow.CustomTypeProperty> value)
    {
      return new AcquaintanceAssignmentAcquaintanceVersionsWrapper(value);
    }

    public AcquaintanceAssignmentAcquaintanceVersionsCollectionWrapper(global::System.Collections.ObjectModel.Collection<global::System.Collections.ObjectModel.Collection<global::Sungero.Workflow.CustomTypeProperty>> items) : base(items) { }
  }

  public class AcquaintanceAssignmentAcquaintanceVersionsWrapper: 
        global::Sungero.Workflow.Blocks.ChildEntityWrapper
  {

        public virtual global::System.Int32? Number
        {
          get { return this.GetCustomProperty<global::System.Int32?>("Number"); }
          set { this.SetCustomProperty("Number", value); }
        }

        public virtual global::System.String Hash
        {
          get { return this.GetCustomProperty<global::System.String>("Hash"); }
          set { this.SetCustomProperty("Hash", value); }
        }

        public virtual global::System.Boolean? IsMainDocument
        {
          get { return this.GetCustomProperty<global::System.Boolean?>("IsMainDocument"); }
          set { this.SetCustomProperty("IsMainDocument", value); }
        }

        public virtual global::System.Int64? DocumentId
        {
          get { return this.GetCustomProperty<global::System.Int64?>("DocumentId"); }
          set { this.SetCustomProperty("DocumentId", value); }
        }


    public AcquaintanceAssignmentAcquaintanceVersionsWrapper(global::System.Collections.ObjectModel.Collection<global::Sungero.Workflow.CustomTypeProperty> properties): base(properties) { }
  }

}