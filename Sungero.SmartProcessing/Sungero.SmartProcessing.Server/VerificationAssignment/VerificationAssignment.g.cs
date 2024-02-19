
// ==================================================================
// VerificationAssignment.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
    public class VerificationAssignmentFilter<T> :
      global::Sungero.Workflow.Server.AssignmentFilter<T>
      where T : class, global::Sungero.SmartProcessing.IVerificationAssignment
    {
      protected new global::Sungero.SmartProcessing.IVerificationAssignmentFilterState Filter { get; private set; }

      private global::Sungero.SmartProcessing.IVerificationAssignmentFilterState filter
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

      public VerificationAssignmentFilter(global::Sungero.SmartProcessing.IVerificationAssignmentFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected VerificationAssignmentFilter()
      {
      }
    }
    public class VerificationAssignmentSearchDialogModel : global::Sungero.Workflow.Server.AssignmentSearchDialogModel
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



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Addressee { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> NewDeadline { get; protected set; }


        }




  public class VerificationAssignmentFilterForAddressee<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.SmartProcessing.IVerificationAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.VerificationAssignmentAddresseePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity });
        var methodInfo = genericType.GetMethod("AddresseeFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.SmartProcessing.VerificationAssignmentAddresseePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).AddresseeFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public VerificationAssignmentFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class VerificationAssignmentSearchFilterForAddressee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.SmartProcessing.VerificationAssignmentAddresseeSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("AddresseeSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.SmartProcessing.VerificationAssignmentAddresseeSearchPropertyFilteringServerHandler<TQueryEntity>().AddresseeSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public VerificationAssignmentSearchFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.SmartProcessing.Server.VerificationAssignmentFilter<global::Sungero.SmartProcessing.IVerificationAssignment>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.SmartProcessing.Server.VerificationAssignmentFilterForAddressee<global::Sungero.Company.IEmployee, global::Sungero.SmartProcessing.IVerificationAssignment>), "Addressee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.SmartProcessing.Server.VerificationAssignmentSearchFilterForAddressee<global::Sungero.CoreEntities.IRecipient>), "Addressee")]


  public class VerificationAssignment :
    global::Sungero.Workflow.Server.Assignment, global::Sungero.SmartProcessing.IVerificationAssignment, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e825fc6a-c82b-4b89-a9fc-33fb181cb161");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Server.VerificationAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IVerificationAssignment, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.SmartProcessing.IVerificationAssignmentState State
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentState(this);
    }

    public new virtual global::Sungero.SmartProcessing.IVerificationAssignmentInfo Info
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentInfo)base.Info; }
    }

    public new virtual global::Sungero.SmartProcessing.IVerificationAssignmentAccessRights AccessRights
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.SmartProcessing.Server.VerificationAssignmentAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.SmartProcessing.Server.VerificationAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.SmartProcessing.VerificationAssignmentServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.SmartProcessing.VerificationAssignmentSharedHandlers(this);
    }

    private global::System.DateTime? _NewDeadline;
    public virtual global::System.DateTime? NewDeadline
    {
      get
      {
        return this._NewDeadline;
      }

      set
      {
        this.SetPropertyValue("NewDeadline", this._NewDeadline, value, (propertyValue) => { this._NewDeadline = propertyValue; }, this.NewDeadlineChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Workflow.Server.Assignment.ResultItems,
      typeof(global::Sungero.SmartProcessing.VerificationAssignment.Result),
      typeof(global::Sungero.SmartProcessing.Server.VerificationAssignment),
      "Result");

    public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
    {
      get { return global::Sungero.SmartProcessing.Server.VerificationAssignment._ResultItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
    {
      get { return global::Sungero.SmartProcessing.Server.VerificationAssignment.ResultItems; }
    }



    private global::Sungero.Company.IEmployee _Addressee;
    public virtual global::Sungero.Company.IEmployee Addressee
    {
      get
      {
        return this._Addressee;
      }

      set
      {
        this.SetPropertyValue("Addressee", this._Addressee, value, (propertyValue) => { this._Addressee = propertyValue; }, this.AddresseeChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.SmartProcessing.VerificationAssignmentCreatingFromServerHandler", new object[] { (global::Sungero.SmartProcessing.IVerificationAssignment)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.SmartProcessing.VerificationAssignmentCreatingFromServerHandler((global::Sungero.SmartProcessing.IVerificationAssignment)entitySource, this.Info);
    }

    #region Framework events

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.SmartProcessing.Shared.VerificationAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.SmartProcessing.IVerificationAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.SmartProcessing.IVerificationAssignmentSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }



    #endregion


    public VerificationAssignment()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments

    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
    }
    #endregion


  }
}

// ==================================================================
// VerificationAssignmentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{
  public partial class VerificationAssignmentAddresseePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.SmartProcessing.IVerificationAssignment _obj
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignment)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> AddresseeFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public VerificationAssignmentAddresseePropertyFilteringServerHandler(global::Sungero.SmartProcessing.IVerificationAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class VerificationAssignmentAddresseeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> AddresseeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public VerificationAssignmentAddresseeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class VerificationAssignmentFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.SmartProcessing.IVerificationAssignment
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.SmartProcessing.IVerificationAssignmentFilterState Filter { get; private set; }

    private global::Sungero.SmartProcessing.IVerificationAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public VerificationAssignmentFilteringServerHandler(global::Sungero.SmartProcessing.IVerificationAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected VerificationAssignmentFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class VerificationAssignmentSearchDialogServerHandler : global::Sungero.Workflow.AssignmentSearchDialogServerHandler
   {
     private global::Sungero.SmartProcessing.Server.VerificationAssignmentSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.SmartProcessing.Server.VerificationAssignmentSearchDialogModel)this.Dialog;
       }
     }

     public VerificationAssignmentSearchDialogServerHandler(global::Sungero.SmartProcessing.Server.VerificationAssignmentSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class VerificationAssignmentServerHandlers : global::Sungero.Workflow.AssignmentServerHandlers
  {
    private global::Sungero.SmartProcessing.IVerificationAssignment _obj
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignment)this.Entity; }
    }

    public VerificationAssignmentServerHandlers(global::Sungero.SmartProcessing.IVerificationAssignment entity)
      : base(entity)
    {
    }
  }

  public partial class VerificationAssignmentCreatingFromServerHandler : global::Sungero.Workflow.AssignmentCreatingFromServerHandler
  {
    private global::Sungero.SmartProcessing.IVerificationAssignment _source
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignment)this.Source; }
    }

    private global::Sungero.SmartProcessing.IVerificationAssignmentInfo _info
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignmentInfo)this._Info; }
    }

    public VerificationAssignmentCreatingFromServerHandler(global::Sungero.SmartProcessing.IVerificationAssignment source, global::Sungero.SmartProcessing.IVerificationAssignmentInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// VerificationAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
}

// ==================================================================
// VerificationAssignmentAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
  public class VerificationAssignmentAccessRights : 
    Sungero.Workflow.Server.AssignmentAccessRights, Sungero.SmartProcessing.IVerificationAssignmentAccessRights
  {

    public VerificationAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class VerificationAssignmentTypeAccessRights : 
    Sungero.Workflow.Server.AssignmentTypeAccessRights, Sungero.SmartProcessing.IVerificationAssignmentAccessRights
  {

    public VerificationAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// VerificationAssignmentRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
    public class VerificationAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.AssignmentRepositoryImplementer<T>,
      global::Sungero.SmartProcessing.IVerificationAssignmentRepositoryImplementer<T>
      where T : global::Sungero.SmartProcessing.IVerificationAssignment 
    {
       public new global::Sungero.SmartProcessing.IVerificationAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.SmartProcessing.IVerificationAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.SmartProcessing.IVerificationAssignmentInfo Info
       {
          get { return (global::Sungero.SmartProcessing.IVerificationAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.SmartProcessing.Server.VerificationAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// VerificationAssignmentPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
}

// ==================================================================
// VerificationAssignmentServerFunctions.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Server
{
  public partial class VerificationAssignmentFunctions : global::Sungero.Workflow.Server.AssignmentFunctions
  {
    private global::Sungero.SmartProcessing.IVerificationAssignment _obj
    {
      get { return (global::Sungero.SmartProcessing.IVerificationAssignment)this.Entity; }
    }

    public VerificationAssignmentFunctions(global::Sungero.SmartProcessing.IVerificationAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// VerificationAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Functions
{
  internal static class VerificationAssignment
  {
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  global::System.String GetInstruction(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetInstruction", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> GetDocumentsSuitableForRepacking(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentsSuitableForRepacking", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> GetOrderedDocuments(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetOrderedDocuments", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetEncryptedDocuments(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEncryptedDocuments", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetInaccesssibleDocuments(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetInaccesssibleDocuments", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetNotSuitableExtensionDocuments(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetNotSuitableExtensionDocuments", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetDocumentsWithoutVersion(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentsWithoutVersion", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> GetDocumentsWithoutBody(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentsWithoutBody", new System.Type[] { typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
      return (System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { documents });
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.VerificationAssignmentFunctions" />
    internal static  void LogDocumentsSuitableForRepackingFilter(global::Sungero.SmartProcessing.IVerificationAssignment verificationAssignment, global::System.String name, System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)verificationAssignment).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("LogDocumentsSuitableForRepackingFilter", new System.Type[] { typeof(global::System.String), typeof(System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOfficialDocument>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { name, documents });
    }

  }
}

// ==================================================================
// VerificationAssignmentServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
  public class VerificationAssignmentServerPublicFunctions : global::Sungero.SmartProcessing.Server.IVerificationAssignmentServerPublicFunctions
  {
  }
}

// ==================================================================
// VerificationAssignmentQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Queries
{
  public class VerificationAssignment
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.SmartProcessing.Server.VerificationAssignment.VerificationAssignmentQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// VerificationAssignmentBlock.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
  public class VerificationAssignmentArguments: global::Sungero.Workflow.Server.Route.AssignmentStartEventArguments<VerificationAssignmentBlock, global::Sungero.Workflow.AssignmentBlock>
  {
    public VerificationAssignmentArguments(VerificationAssignmentBlock block) : base(block) { }
  }

  public class VerificationAssignmentEndBlockEventArguments: global::Sungero.Workflow.Server.Route.AssignmentEndBlockEventArguments<VerificationAssignmentBlock, global::Sungero.Workflow.AssignmentBlock, Sungero.SmartProcessing.IVerificationAssignment> 
  {
    public VerificationAssignmentEndBlockEventArguments(VerificationAssignmentBlock block) : base(block) { }
  }

  public partial class VerificationAssignmentBlock : global::Sungero.Workflow.Blocks.AssignmentBlockWrapper<global::Sungero.Workflow.AssignmentBlock>    
  {
    public virtual global::System.DateTime? NewDeadline
    {
      get { return this.GetCustomProperty<global::System.DateTime?>("NewDeadline"); }
      set { this.SetCustomProperty("NewDeadline", value); }
    }

    public virtual global::Sungero.Company.IEmployee Addressee
    {
      get { return this.GetCustomNavigationProperty<global::Sungero.Company.IEmployee>("Addressee"); }
      set { this.SetCustomNavigationProperty("Addressee", value); }
    }




    public VerificationAssignmentBlock(global::Sungero.Workflow.AssignmentBlock block) : base(block) { }
  }
}

// ==================================================================
// VerificationAssignmentChildWrappers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
}