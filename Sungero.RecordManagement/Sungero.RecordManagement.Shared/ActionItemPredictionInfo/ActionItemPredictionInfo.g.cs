
// ==================================================================
// ActionItemPredictionInfoState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class ActionItemPredictionInfoState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.RecordManagement.IActionItemPredictionInfoState
  {
    public ActionItemPredictionInfoState(global::Sungero.RecordManagement.IActionItemPredictionInfo entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IActionItemPredictionInfoPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemPredictionInfoPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemPredictionInfoPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IActionItemPredictionInfoControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IActionItemPredictionInfoControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemPredictionInfoControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IActionItemPredictionInfoPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IActionItemPredictionInfoPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemPredictionInfoPageStates(entity);
    }

  }


  public class ActionItemPredictionInfoControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.RecordManagement.IActionItemPredictionInfoControlStates
  {

    protected internal ActionItemPredictionInfoControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ActionItemPredictionInfoPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.RecordManagement.IActionItemPredictionInfoPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal ActionItemPredictionInfoPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ActionItemPredictionInfoPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.RecordManagement.IActionItemPredictionInfoPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int64?> TaskId 
            {
              get { return this.GetPropertyState<global::System.Int64?>("TaskId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> TaskType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("TaskType"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> ArioTaskId 
            {
              get { return this.GetPropertyState<global::System.Int32?>("ArioTaskId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> ArioTaskStatus 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("ArioTaskStatus"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Intelligence.IAIManagersAssistant> AIManagerAssistant 
            {
              get { return this.InternalAIManagerAssistant; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Intelligence.IAIManagersAssistant> InternalAIManagerAssistant
            {
              get { return this.GetPropertyState<global::Sungero.Intelligence.IAIManagersAssistant>("AIManagerAssistant"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState ArioResultJson 
            {
              get { return this.GetDataPropertyState("ArioResultJson"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int64?> ActionItemId 
            {
              get { return this.GetPropertyState<global::System.Int64?>("ActionItemId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Assignee 
            {
              get { return this.InternalAssignee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAssignee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Assignee"); }
            }


    protected internal ActionItemPredictionInfoPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ActionItemPredictionInfoInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class ActionItemPredictionInfoInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.RecordManagement.IActionItemPredictionInfoInfo
  {
    public ActionItemPredictionInfoInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IActionItemPredictionInfoPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemPredictionInfoPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemPredictionInfoPropertiesInfo(entityType);
    }

  }

  public class ActionItemPredictionInfoPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.RecordManagement.IActionItemPredictionInfoPropertiesInfo
  {
        public global::Sungero.Domain.Shared.ILongIntegerPropertyInfo TaskId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.LongIntegerPropertyMetadata>("TaskId");
             return new global::Sungero.Domain.Shared.LongIntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo TaskType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("TaskType");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo ArioTaskId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("ArioTaskId");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo ArioTaskStatus 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("ArioTaskStatus");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Intelligence.IAIManagersAssistantInfo, global::Sungero.Intelligence.IAIManagersAssistant> AIManagerAssistant 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("AIManagerAssistant");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Intelligence.IAIManagersAssistantInfo, global::Sungero.Intelligence.IAIManagersAssistant>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo ArioResultJson 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("ArioResultJson");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ILongIntegerPropertyInfo ActionItemId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.LongIntegerPropertyMetadata>("ActionItemId");
             return new global::Sungero.Domain.Shared.LongIntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Assignee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Assignee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }


    protected internal ActionItemPredictionInfoPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ActionItemPredictionInfoHandlers.g.cs
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
  public partial class ActionItemPredictionInfoSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IActionItemPredictionInfoSharedHandlers
  {
    private global::Sungero.RecordManagement.IActionItemPredictionInfo _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemPredictionInfo)this.Entity; }
    }
    public virtual void TaskIdChanged(global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs e) { }


    public virtual void TaskTypeChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }


    public virtual void ArioTaskIdChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }


    public virtual void ArioTaskStatusChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }


    public virtual void AIManagerAssistantChanged(global::Sungero.RecordManagement.Shared.ActionItemPredictionInfoAIManagerAssistantChangedEventArgs e) { }


    public virtual void ArioResultJsonChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }


    public virtual void ActionItemIdChanged(global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs e) { }


    public virtual void AssigneeChanged(global::Sungero.RecordManagement.Shared.ActionItemPredictionInfoAssigneeChangedEventArgs e) { }




    public ActionItemPredictionInfoSharedHandlers(global::Sungero.RecordManagement.IActionItemPredictionInfo entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ActionItemPredictionInfoResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.ActionItemPredictionInfo
{
  /// <summary>
  /// Represents ActionItemPredictionInfo resources.
  /// </summary>
  public class ActionItemPredictionInfoResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.RecordManagement.ActionItemPredictionInfo.IActionItemPredictionInfoResources
  {
  }
}

// ==================================================================
// ActionItemPredictionInfoSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class ActionItemPredictionInfoFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.RecordManagement.IActionItemPredictionInfo _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemPredictionInfo)this.Entity; }
    }

    public ActionItemPredictionInfoFunctions(global::Sungero.RecordManagement.IActionItemPredictionInfo entity) : base(entity) { }
  }
}

// ==================================================================
// ActionItemPredictionInfoFunctions.g.cs
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
  internal static class ActionItemPredictionInfo
  {
  }
}

// ==================================================================
// ActionItemPredictionInfoFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.ActionItemPredictionInfo
{

  public class ActionItemPredictionInfoFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.RecordManagement.IActionItemPredictionInfoFilterInfo
  {
  }

  public class ActionItemPredictionInfoFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.RecordManagement.IActionItemPredictionInfoFilterState
  {



    public new Sungero.RecordManagement.IActionItemPredictionInfoFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IActionItemPredictionInfoFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.ActionItemPredictionInfo.ActionItemPredictionInfoFilterInfo();
    }

  }
}

// ==================================================================
// ActionItemPredictionInfoSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class ActionItemPredictionInfoSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IActionItemPredictionInfoSharedPublicFunctions
  {
  }
}
