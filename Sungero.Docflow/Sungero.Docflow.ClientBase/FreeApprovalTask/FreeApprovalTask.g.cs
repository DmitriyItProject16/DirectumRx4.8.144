
// ==================================================================
// FreeApprovalTaskEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
}

// ==================================================================
// FreeApprovalTaskHandlers.g.cs
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

  public partial class FreeApprovalTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IFreeApprovalTaskFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IFreeApprovalTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public FreeApprovalTaskFilteringClientHandler(global::Sungero.Docflow.IFreeApprovalTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected FreeApprovalTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class FreeApprovalTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalTask _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTask)this.Entity; }
    }

    public virtual void ReceiveNoticeValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void ReceiveOnCompletionValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }





    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ReceiveOnCompletionFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }





    public FreeApprovalTaskClientHandlers(global::Sungero.Docflow.IFreeApprovalTask entity) : base(entity)
    {
    }
  }

  public partial class FreeApprovalTaskApproversClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalTaskApprovers _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTaskApprovers)this.Entity; }
    }
    public virtual void ApproversApproverValueInput(global::Sungero.Docflow.Client.FreeApprovalTaskApproversApproverValueInputEventArgs e) { }


    public FreeApprovalTaskApproversClientHandlers(global::Sungero.Docflow.IFreeApprovalTaskApprovers entity) : base(entity)
    {
    }
  }

  public partial class FreeApprovalTaskAddedAddendaClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalTaskAddedAddenda _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTaskAddedAddenda)this.Entity; }
    }
    public virtual void AddedAddendaAddendumIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public FreeApprovalTaskAddedAddendaClientHandlers(global::Sungero.Docflow.IFreeApprovalTaskAddedAddenda entity) : base(entity)
    {
    }
  }

  public partial class FreeApprovalTaskRemovedAddendaClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalTaskRemovedAddenda _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTaskRemovedAddenda)this.Entity; }
    }
    public virtual void RemovedAddendaAddendumIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public FreeApprovalTaskRemovedAddendaClientHandlers(global::Sungero.Docflow.IFreeApprovalTaskRemovedAddenda entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// FreeApprovalTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class FreeApprovalTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalTask _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalTask)this.Entity; }
    }

    public FreeApprovalTaskFunctions(global::Sungero.Docflow.IFreeApprovalTask entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalTaskFunctions.g.cs
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
  internal static class FreeApprovalTask
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.FreeApprovalTaskFunctions" />
    internal static  global::System.Boolean ValidateBeforeRework(global::Sungero.Workflow.IAssignment assignment, global::System.String errorMessage, Sungero.Domain.Client.ExecuteActionArgs eventArgs)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Client.FreeApprovalTaskFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("ValidateBeforeRework",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Workflow.IAssignment), typeof(global::System.String), typeof(Sungero.Domain.Client.ExecuteActionArgs) }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { assignment, errorMessage, eventArgs });
      }
      else
      {
        return global::Sungero.Docflow.Client.FreeApprovalTaskFunctions.ValidateBeforeRework(assignment, errorMessage, eventArgs);
      }
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.FreeApprovalTask.StartValidationMessage> GetStartValidationMessages(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStartValidationMessages", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.FreeApprovalTask.StartValidationMessage>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  global::System.Boolean ValidateFreeApprovalTaskStart(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask, Sungero.Core.IValidationArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateFreeApprovalTaskStart", new System.Type[] { typeof(Sungero.Core.IValidationArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  void SynchronizeAddendaAndAttachmentsGroup(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SynchronizeAddendaAndAttachmentsGroup", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  void AddedAddendaAppend(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaAppend", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  void RemovedAddendaAppend(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaAppend", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  void AddedAddendaAppend(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaAppend", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  void AddedAddendaRemove(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddedAddendaRemove", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  void RemovedAddendaAppend(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaAppend", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  void RemovedAddendaRemove(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask, global::Sungero.Content.IElectronicDocument addendum)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RemovedAddendaRemove", new System.Type[] { typeof(global::Sungero.Content.IElectronicDocument) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { addendum });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument> GetAddendaGroupAttachments(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAddendaGroupAttachments", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.Int64> GetAddedAddenda(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAddedAddenda", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::System.Int64>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.Int64> GetRemovedAddenda(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRemovedAddenda", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::System.Int64>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument> GetAddedAddendaFromAssignments(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAddedAddendaFromAssignments", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument> GetRemovedAddendaFromAssignments(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRemovedAddendaFromAssignments", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Content.IElectronicDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FreeApprovalTaskFunctions" />
    internal static  global::System.Boolean HasDocumentAndCanRead(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)freeApprovalTask).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasDocumentAndCanRead", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FreeApprovalTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("77f43035-9f23-4a19-9882-5a6a2cd5c9c7"),
          "GetStateView(global::Sungero.Docflow.IFreeApprovalTask)"
          , freeApprovalTask);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FreeApprovalTaskFunctions" />
      internal static  global::Sungero.Docflow.Structures.Module.AttachmentHistoryEntries GetAttachmentHistoryEntriesByGroupId(global::Sungero.Docflow.IFreeApprovalTask freeApprovalTask, global::System.Guid groupId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.Module.AttachmentHistoryEntries>(
          global::System.Guid.Parse("77f43035-9f23-4a19-9882-5a6a2cd5c9c7"),
          "GetAttachmentHistoryEntriesByGroupId(global::Sungero.Docflow.IFreeApprovalTask,global::System.Guid)"
          , freeApprovalTask, groupId);
      }

    }
  }
}

// ==================================================================
// FreeApprovalTaskClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class FreeApprovalTaskClientPublicFunctions : global::Sungero.Docflow.Client.IFreeApprovalTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalTaskActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public partial class FreeApprovalTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.Docflow.IFreeApprovalTask _obj { get { return (global::Sungero.Docflow.IFreeApprovalTask)this.Entity; } }
    public FreeApprovalTaskActions(global::Sungero.Docflow.IFreeApprovalTask entity) : base(entity) { }
  }

  public partial class FreeApprovalTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IFreeApprovalTask> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IFreeApprovalTask>(this.Entities); }
    }
  }

  public partial class FreeApprovalTaskCollectionBulkActions : global::Sungero.Workflow.Client.TaskCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class FreeApprovalTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class FreeApprovalTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }



}
