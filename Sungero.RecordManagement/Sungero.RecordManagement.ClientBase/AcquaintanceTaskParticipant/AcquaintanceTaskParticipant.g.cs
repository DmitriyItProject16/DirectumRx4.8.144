
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

namespace Sungero.RecordManagement.Client
{ 
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

  public partial class AcquaintanceTaskParticipantFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public AcquaintanceTaskParticipantFilteringClientHandler(global::Sungero.RecordManagement.IAcquaintanceTaskParticipantFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected AcquaintanceTaskParticipantFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class AcquaintanceTaskParticipantClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipant _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipant)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void TaskIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public AcquaintanceTaskParticipantClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskParticipant entity) : base(entity)
    {
    }
  }

  public partial class AcquaintanceTaskParticipantEmployeesClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees)this.Entity; }
    }
    public virtual void EmployeesEmployeeValueInput(global::Sungero.RecordManagement.Client.AcquaintanceTaskParticipantEmployeesEmployeeValueInputEventArgs e) { }


    public AcquaintanceTaskParticipantEmployeesClientHandlers(global::Sungero.RecordManagement.IAcquaintanceTaskParticipantEmployees entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AcquaintanceTaskParticipantClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class AcquaintanceTaskParticipantFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
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
// AcquaintanceTaskParticipantClientPublicFunctions.g.cs
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
  public class AcquaintanceTaskParticipantClientPublicFunctions : global::Sungero.RecordManagement.Client.IAcquaintanceTaskParticipantClientPublicFunctions
  {
  }
}

// ==================================================================
// AcquaintanceTaskParticipantActions.g.cs
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
  public partial class AcquaintanceTaskParticipantActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.RecordManagement.IAcquaintanceTaskParticipant _obj { get { return (global::Sungero.RecordManagement.IAcquaintanceTaskParticipant)this.Entity; } }
    public AcquaintanceTaskParticipantActions(global::Sungero.RecordManagement.IAcquaintanceTaskParticipant entity) : base(entity) { }
  }

  public partial class AcquaintanceTaskParticipantCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IAcquaintanceTaskParticipant> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IAcquaintanceTaskParticipant>(this.Entities); }
    }
  }

  public partial class AcquaintanceTaskParticipantCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AcquaintanceTaskParticipantAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class AcquaintanceTaskParticipantAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
