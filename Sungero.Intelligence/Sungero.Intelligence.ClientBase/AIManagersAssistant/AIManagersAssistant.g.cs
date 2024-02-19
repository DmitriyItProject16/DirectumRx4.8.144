
// ==================================================================
// AIManagersAssistantEventArgs.g.cs
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
}

// ==================================================================
// AIManagersAssistantHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Intelligence
{

  public partial class AIManagersAssistantFilteringClientHandler
    : global::Sungero.Company.ManagersAssistantBaseFilteringClientHandler
  {
    private global::Sungero.Intelligence.IAIManagersAssistantFilterState _filter
    {
      get
      {
        return (Sungero.Intelligence.IAIManagersAssistantFilterState)this.Filter;
      }
    }

    public AIManagersAssistantFilteringClientHandler(global::Sungero.Intelligence.IAIManagersAssistantFilterState filter)
    : base(filter)
    {
    }

    protected AIManagersAssistantFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class AIManagersAssistantClientHandlers : global::Sungero.Company.ManagersAssistantBaseClientHandlers
  {
    private global::Sungero.Intelligence.IAIManagersAssistant _obj
    {
      get { return (global::Sungero.Intelligence.IAIManagersAssistant)this.Entity; }
    }

    public AIManagersAssistantClientHandlers(global::Sungero.Intelligence.IAIManagersAssistant entity) : base(entity)
    {
    }
  }

  public partial class AIManagersAssistantClassifiersClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Intelligence.IAIManagersAssistantClassifiers _obj
    {
      get { return (global::Sungero.Intelligence.IAIManagersAssistantClassifiers)this.Entity; }
    }
    public virtual void ClassifiersClassifierIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void ClassifiersClassifierTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void ClassifiersClassifierNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ClassifiersLowerClassificationLimitValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void ClassifiersModelIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void ClassifiersIsModelActiveValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ClassifiersClassifierTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }





    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ClassifiersIsModelActiveFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public AIManagersAssistantClassifiersClientHandlers(global::Sungero.Intelligence.IAIManagersAssistantClassifiers entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AIManagersAssistantClientFunctions.g.cs
// ==================================================================

namespace Sungero.Intelligence.Client
{
  public partial class AIManagersAssistantFunctions : global::Sungero.Company.Client.ManagersAssistantBaseFunctions
  {
    private global::Sungero.Intelligence.IAIManagersAssistant _obj
    {
      get { return (global::Sungero.Intelligence.IAIManagersAssistant)this.Entity; }
    }

    public AIManagersAssistantFunctions(global::Sungero.Intelligence.IAIManagersAssistant entity) : base(entity) { }
  }
}

// ==================================================================
// AIManagersAssistantFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Intelligence.Functions
{
  internal static class AIManagersAssistant
  {
    /// <redirect project="Sungero.Intelligence.Client" type="Sungero.Intelligence.Client.AIManagersAssistantFunctions" />
    internal static  global::System.Boolean CollectionIsAIAssistantClassifiers(Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Domain.Shared.IChildEntity> collection, global::Sungero.Domain.Shared.IEntity rootEntity)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Intelligence.Client.AIManagersAssistantFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CollectionIsAIAssistantClassifiers",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Domain.Shared.IChildEntity>), typeof(global::Sungero.Domain.Shared.IEntity) }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { collection, rootEntity });
      }
      else
      {
        return global::Sungero.Intelligence.Client.AIManagersAssistantFunctions.CollectionIsAIAssistantClassifiers(collection, rootEntity);
      }
    }

  }
}

// ==================================================================
// AIManagersAssistantClientPublicFunctions.g.cs
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
  public class AIManagersAssistantClientPublicFunctions : global::Sungero.Intelligence.Client.IAIManagersAssistantClientPublicFunctions
  {
  }
}

// ==================================================================
// AIManagersAssistantActions.g.cs
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
  public partial class AIManagersAssistantActions : global::Sungero.Company.Client.ManagersAssistantBaseActions
  {
    private global::Sungero.Intelligence.IAIManagersAssistant _obj { get { return (global::Sungero.Intelligence.IAIManagersAssistant)this.Entity; } }
    public AIManagersAssistantActions(global::Sungero.Intelligence.IAIManagersAssistant entity) : base(entity) { }
  }

  public partial class AIManagersAssistantCollectionActions : global::Sungero.Company.Client.ManagersAssistantBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Intelligence.IAIManagersAssistant> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Intelligence.IAIManagersAssistant>(this.Entities); }
    }
  }

  public partial class AIManagersAssistantCollectionBulkActions : global::Sungero.Company.Client.ManagersAssistantBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AIManagersAssistantAnyChildEntityActions : global::Sungero.Company.Client.ManagersAssistantBaseAnyChildEntityActions
  {
  }

  public partial class AIManagersAssistantAnyChildEntityCollectionActions : global::Sungero.Company.Client.ManagersAssistantBaseAnyChildEntityCollectionActions
  {
  }



}
