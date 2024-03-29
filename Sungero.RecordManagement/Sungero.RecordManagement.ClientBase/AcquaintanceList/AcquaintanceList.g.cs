
// ==================================================================
// AcquaintanceListEventArgs.g.cs
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
// AcquaintanceListHandlers.g.cs
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

  public partial class AcquaintanceListFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IAcquaintanceListFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IAcquaintanceListFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public AcquaintanceListFilteringClientHandler(global::Sungero.RecordManagement.IAcquaintanceListFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected AcquaintanceListFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class AcquaintanceListClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceList _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceList)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }




    public AcquaintanceListClientHandlers(global::Sungero.RecordManagement.IAcquaintanceList entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceListParticipantsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceListParticipants _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceListParticipants)this.Entity; }
    }
    public virtual void ParticipantsParticipantValueInput(global::Sungero.RecordManagement.Client.AcquaintanceListParticipantsParticipantValueInputEventArgs e) { }


    public AcquaintanceListParticipantsClientHandlers(global::Sungero.RecordManagement.IAcquaintanceListParticipants entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceListExcludedParticipantsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants)this.Entity; }
    }
    public virtual void ExcludedParticipantsExcludedParticipantValueInput(global::Sungero.RecordManagement.Client.AcquaintanceListExcludedParticipantsExcludedParticipantValueInputEventArgs e) { }


    public AcquaintanceListExcludedParticipantsClientHandlers(global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AcquaintanceListClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class AcquaintanceListFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.RecordManagement.IAcquaintanceList _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceList)this.Entity; }
    }

    public AcquaintanceListFunctions(global::Sungero.RecordManagement.IAcquaintanceList entity) : base(entity) { }
  }
}

// ==================================================================
// AcquaintanceListFunctions.g.cs
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
  internal static class AcquaintanceList
  {
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.AcquaintanceListFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetParticipants(global::Sungero.RecordManagement.IAcquaintanceList acquaintanceList)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)acquaintanceList).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetParticipants", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// AcquaintanceListClientPublicFunctions.g.cs
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
  public class AcquaintanceListClientPublicFunctions : global::Sungero.RecordManagement.Client.IAcquaintanceListClientPublicFunctions
  {
  }
}

// ==================================================================
// AcquaintanceListActions.g.cs
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
  public partial class AcquaintanceListActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.RecordManagement.IAcquaintanceList _obj { get { return (global::Sungero.RecordManagement.IAcquaintanceList)this.Entity; } }
    public AcquaintanceListActions(global::Sungero.RecordManagement.IAcquaintanceList entity) : base(entity) { }
  }

  public partial class AcquaintanceListCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IAcquaintanceList> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IAcquaintanceList>(this.Entities); }
    }
  }

  public partial class AcquaintanceListCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AcquaintanceListAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class AcquaintanceListAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
