
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

namespace Sungero.RecordManagement.Client
{ 
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

  public partial class AcquaintanceAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public AcquaintanceAssignmentFilteringClientHandler(global::Sungero.RecordManagement.IAcquaintanceAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected AcquaintanceAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class AcquaintanceAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignment)this.Entity; }
    }

    public virtual void DescriptionValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public AcquaintanceAssignmentClientHandlers(global::Sungero.RecordManagement.IAcquaintanceAssignment entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceAssignmentAcquaintanceVersionsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions)this.Entity; }
    }
    public virtual void AcquaintanceVersionsNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void AcquaintanceVersionsHashValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void AcquaintanceVersionsIsMainDocumentValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void AcquaintanceVersionsDocumentIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public AcquaintanceAssignmentAcquaintanceVersionsClientHandlers(global::Sungero.RecordManagement.IAcquaintanceAssignmentAcquaintanceVersions entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AcquaintanceAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class AcquaintanceAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
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
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.AcquaintanceAssignmentFunctions" />
    internal static  void ShowDocument(global::Sungero.RecordManagement.IAcquaintanceAssignment acquaintanceAssignment, global::Sungero.Docflow.IOfficialDocument document, global::System.Int32 versionNumber)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceAssignment).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ShowDocument", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::System.Int32) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, versionNumber });
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

    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.AcquaintanceAssignmentFunctions" />
      internal static  global::System.Boolean IsSubstituteOf(global::Sungero.RecordManagement.IAcquaintanceAssignment acquaintanceAssignment, global::Sungero.CoreEntities.IUser who, global::Sungero.CoreEntities.IUser whom)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("8fee99ee-b3fd-49dd-9b48-e51b83597227"),
          "IsSubstituteOf(global::Sungero.RecordManagement.IAcquaintanceAssignment,global::Sungero.CoreEntities.IUser,global::Sungero.CoreEntities.IUser)"
          , acquaintanceAssignment, who, whom);
      }

    }
  }
}

// ==================================================================
// AcquaintanceAssignmentClientPublicFunctions.g.cs
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
  public class AcquaintanceAssignmentClientPublicFunctions : global::Sungero.RecordManagement.Client.IAcquaintanceAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// AcquaintanceAssignmentActions.g.cs
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
  public partial class AcquaintanceAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.RecordManagement.IAcquaintanceAssignment _obj { get { return (global::Sungero.RecordManagement.IAcquaintanceAssignment)this.Entity; } }
    public AcquaintanceAssignmentActions(global::Sungero.RecordManagement.IAcquaintanceAssignment entity) : base(entity) { }
  }

  public partial class AcquaintanceAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IAcquaintanceAssignment> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IAcquaintanceAssignment>(this.Entities); }
    }
  }

  public partial class AcquaintanceAssignmentCollectionBulkActions : global::Sungero.Workflow.Client.AssignmentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AcquaintanceAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class AcquaintanceAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }



}
