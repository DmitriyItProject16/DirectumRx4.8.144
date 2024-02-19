
// ==================================================================
// ApprovalCheckingAssignment.g.cs
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
    public class ApprovalCheckingAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.Docflow.IApprovalCheckingAssignment
    {
      protected new global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState filter
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

      public ApprovalCheckingAssignmentFilter(global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ApprovalCheckingAssignmentFilter()
      {
      }
    }
    public class ApprovalCheckingAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
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




        }




  public class ApprovalCheckingAssignmentFilterForReworkPerformer<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Docflow.IApprovalCheckingAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalCheckingAssignmentReworkPerformerPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("ReworkPerformerFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ApprovalCheckingAssignmentReworkPerformerPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).ReworkPerformerFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalCheckingAssignmentFilterForReworkPerformer(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ApprovalCheckingAssignmentSearchFilterForReworkPerformer<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalCheckingAssignmentReworkPerformerSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("ReworkPerformerSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Docflow.ApprovalCheckingAssignmentReworkPerformerSearchPropertyFilteringServerHandler<TQueryEntity>().ReworkPerformerSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalCheckingAssignmentSearchFilterForReworkPerformer(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ApprovalCheckingAssignmentFilter<global::Sungero.Docflow.IApprovalCheckingAssignment>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalCheckingAssignmentFilterForReworkPerformer<global::Sungero.Company.IEmployee, global::Sungero.Docflow.IApprovalCheckingAssignment>), "ReworkPerformer")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalCheckingAssignmentSearchFilterForReworkPerformer<global::Sungero.CoreEntities.IRecipient>), "ReworkPerformer")]


  public class ApprovalCheckingAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.Docflow.IApprovalCheckingAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c09f0ae4-c959-4a57-9895-ae9aaf1f1855");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalCheckingAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalCheckingAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.Docflow.IApprovalCheckingAssignmentState State
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalCheckingAssignmentInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IApprovalCheckingAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ApprovalCheckingAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ApprovalCheckingAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalCheckingAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers(this);
    }

    private global::System.String _StageSubject;
    public virtual global::System.String StageSubject
    {
      get
      {
        return this._StageSubject;
      }

      set
      {
        this.SetPropertyValue("StageSubject", this._StageSubject, value, (propertyValue) => { this._StageSubject = propertyValue; }, this.StageSubjectChangedHandler);
      }
    }
    private global::System.Int32? _StageNumber;
    public virtual global::System.Int32? StageNumber
    {
      get
      {
        return this._StageNumber;
      }

      set
      {
        this.SetPropertyValue("StageNumber", this._StageNumber, value, (propertyValue) => { this._StageNumber = propertyValue; }, this.StageNumberChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.Docflow.ApprovalCheckingAssignment.Result),
      typeof(global::Sungero.Docflow.Server.ApprovalCheckingAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalCheckingAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalCheckingAssignment.ResultItems; }
    }



    private global::Sungero.Company.IEmployee _ReworkPerformer;
    public virtual global::Sungero.Company.IEmployee ReworkPerformer
    {
      get
      {
        return this._ReworkPerformer;
      }

      set
      {
        this.SetPropertyValue("ReworkPerformer", this._ReworkPerformer, value, (propertyValue) => { this._ReworkPerformer = propertyValue; }, this.ReworkPerformerChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ApprovalCheckingAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IApprovalCheckingAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ApprovalCheckingAssignmentCreatingFromServerHandler((global::Sungero.Docflow.IApprovalCheckingAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void StageSubjectChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.StageSubject, this.StageSubject, this);
     ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).StageSubjectChanged(args);
    }

    protected void StageNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.StageNumber, this.StageNumber, this);
     ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).StageNumberChanged(args);
    }

    protected void ReworkPerformerChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentReworkPerformerChangedEventArgs(this.State.Properties.ReworkPerformer, this.ReworkPerformer, this);
     ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).ReworkPerformerChanged(args);
    }



    #endregion


    public ApprovalCheckingAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IApprovalCheckingAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalCheckingAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalCheckingAssignmentDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentDocumentGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.IApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }

    }
    #endregion


  }
}

// ==================================================================
// ApprovalCheckingAssignmentHandlers.g.cs
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
  public partial class ApprovalCheckingAssignmentReworkPerformerPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Entity; }
    }

    public ApprovalCheckingAssignmentReworkPerformerPropertyFilteringServerHandler(global::Sungero.Docflow.IApprovalCheckingAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalCheckingAssignmentReworkPerformerSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ReworkPerformerSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalCheckingAssignmentReworkPerformerSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class ApprovalCheckingAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IApprovalCheckingAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalCheckingAssignmentFilteringServerHandler(global::Sungero.Docflow.IApprovalCheckingAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalCheckingAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ApprovalCheckingAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ApprovalCheckingAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ApprovalCheckingAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalCheckingAssignmentSearchDialogServerHandler(global::Sungero.Docflow.Server.ApprovalCheckingAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalCheckingAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Entity; }
    }

    public ApprovalCheckingAssignmentServerHandlers(global::Sungero.Docflow.IApprovalCheckingAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalCheckingAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _source
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Source; }
    }

    private global::Sungero.Docflow.IApprovalCheckingAssignmentInfo _info
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentInfo)this._Info; }
    }

    public ApprovalCheckingAssignmentCreatingFromServerHandler(global::Sungero.Docflow.IApprovalCheckingAssignment source, global::Sungero.Docflow.IApprovalCheckingAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalCheckingAssignmentEventArgs.g.cs
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
// ApprovalCheckingAssignmentAccessRights.g.cs
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
  public class ApprovalCheckingAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.Docflow.IApprovalCheckingAssignmentAccessRights
  {

    public ApprovalCheckingAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalCheckingAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.Docflow.IApprovalCheckingAssignmentAccessRights
  {

    public ApprovalCheckingAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentRepositoryImplementer.g.cs
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
    public class ApprovalCheckingAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalCheckingAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalCheckingAssignment 
    {
       public new global::Sungero.Docflow.IApprovalCheckingAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalCheckingAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ApprovalCheckingAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalCheckingAssignmentPanelNavigationFilters.g.cs
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
// ApprovalCheckingAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ApprovalCheckingAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalCheckingAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalCheckingAssignment)this.Entity; }
    }

    public ApprovalCheckingAssignmentFunctions(global::Sungero.Docflow.IApprovalCheckingAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentFunctions.g.cs
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
  internal static class ApprovalCheckingAssignment
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalCheckingAssignmentFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::Sungero.Core.StateView GetStagesStateView(global::Sungero.Docflow.IApprovalCheckingAssignment approvalCheckingAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalCheckingAssignment).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStagesStateView", new System.Type[] {  });
      return (global::Sungero.Core.StateView)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ApprovalCheckingAssignmentServerPublicFunctions.g.cs
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
  public class ApprovalCheckingAssignmentServerPublicFunctions : global::Sungero.Docflow.Server.IApprovalCheckingAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalCheckingAssignmentQueries.g.cs
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
  public class ApprovalCheckingAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.ApprovalCheckingAssignment.ApprovalCheckingAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ApprovalCheckingAssignmentBlock.g.cs
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
  public class ApprovalCheckingAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<ApprovalCheckingAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public ApprovalCheckingAssignmentArguments(ApprovalCheckingAssignmentBlock block) : base(block) { }
  }

  public class ApprovalCheckingAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<ApprovalCheckingAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.Docflow.IApprovalCheckingAssignment> 
  {
    public ApprovalCheckingAssignmentEndBlockEventArguments(ApprovalCheckingAssignmentBlock block) : base(block) { }
  }

  public partial class ApprovalCheckingAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {
    public virtual global::System.String StageSubject
    {
      get { return this.GetCustomProperty<global::System.String>("StageSubject"); }
      set { this.SetCustomProperty("StageSubject", value); }
    }
    public virtual global::System.Int32? StageNumber
    {
      get { return this.GetCustomProperty<global::System.Int32?>("StageNumber"); }
      set { this.SetCustomProperty("StageNumber", value); }
    }

    public virtual global::Sungero.Company.IEmployee ReworkPerformer
    {
      get { return this.GetCustomNavigationProperty<global::Sungero.Company.IEmployee>("ReworkPerformer"); }
      set { this.SetCustomNavigationProperty("ReworkPerformer", value); }
    }




    public ApprovalCheckingAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentChildWrappers.g.cs
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