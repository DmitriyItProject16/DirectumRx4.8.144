
// ==================================================================
// RetentionPolicyEventArgs.g.cs
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
// RetentionPolicyHandlers.g.cs
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

  public partial class RetentionPolicyFilteringClientHandler
    : global::Sungero.Docflow.StoragePolicyBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.IRetentionPolicyFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IRetentionPolicyFilterState)this.Filter;
      }
    }

    public RetentionPolicyFilteringClientHandler(global::Sungero.Docflow.IRetentionPolicyFilterState filter)
    : base(filter)
    {
    }

    protected RetentionPolicyFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class RetentionPolicyClientHandlers : global::Sungero.Docflow.StoragePolicyBaseClientHandlers
  {
    private global::Sungero.Docflow.IRetentionPolicy _obj
    {
      get { return (global::Sungero.Docflow.IRetentionPolicy)this.Entity; }
    }

    public virtual void DocumentDateTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }



    public virtual void NextRetentionValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void LastRetentionValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }



    public virtual void RepeatTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void IntervalTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> DocumentDateTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }






    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> RepeatTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> IntervalTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public RetentionPolicyClientHandlers(global::Sungero.Docflow.IRetentionPolicy entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// RetentionPolicyClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class RetentionPolicyFunctions : global::Sungero.Docflow.Client.StoragePolicyBaseFunctions
  {
    private global::Sungero.Docflow.IRetentionPolicy _obj
    {
      get { return (global::Sungero.Docflow.IRetentionPolicy)this.Entity; }
    }

    public RetentionPolicyFunctions(global::Sungero.Docflow.IRetentionPolicy entity) : base(entity) { }
  }
}

// ==================================================================
// RetentionPolicyFunctions.g.cs
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
  internal static class RetentionPolicy
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RetentionPolicyFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.IRetentionPolicy retentionPolicy)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)retentionPolicy).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RetentionPolicyFunctions" />
    internal static  global::System.Nullable<global::System.DateTime> GetNextRetentionDate(global::System.Nullable<global::Sungero.Core.Enumeration> repeatType, global::System.Nullable<global::Sungero.Core.Enumeration> intervalType, global::System.Nullable<global::System.Int32> interval, global::System.DateTime now)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.RetentionPolicyFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetNextRetentionDate",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::System.Int32>), typeof(global::System.DateTime) }, null);
        return (global::System.Nullable<global::System.DateTime>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { repeatType, intervalType, interval, now });
      }
      else
      {
        return global::Sungero.Docflow.Shared.RetentionPolicyFunctions.GetNextRetentionDate(repeatType, intervalType, interval, now);
      }
    }

  }
}

// ==================================================================
// RetentionPolicyClientPublicFunctions.g.cs
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
  public class RetentionPolicyClientPublicFunctions : global::Sungero.Docflow.Client.IRetentionPolicyClientPublicFunctions
  {
  }
}

// ==================================================================
// RetentionPolicyActions.g.cs
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
  public partial class RetentionPolicyActions : global::Sungero.Docflow.Client.StoragePolicyBaseActions
  {
    private global::Sungero.Docflow.IRetentionPolicy _obj { get { return (global::Sungero.Docflow.IRetentionPolicy)this.Entity; } }
    public RetentionPolicyActions(global::Sungero.Docflow.IRetentionPolicy entity) : base(entity) { }
  }

  public partial class RetentionPolicyCollectionActions : global::Sungero.Docflow.Client.StoragePolicyBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IRetentionPolicy> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IRetentionPolicy>(this.Entities); }
    }
  }

  public partial class RetentionPolicyCollectionBulkActions : global::Sungero.Docflow.Client.StoragePolicyBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class RetentionPolicyAnyChildEntityActions : global::Sungero.Docflow.Client.StoragePolicyBaseAnyChildEntityActions
  {
  }

  public partial class RetentionPolicyAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.StoragePolicyBaseAnyChildEntityCollectionActions
  {
  }



}
