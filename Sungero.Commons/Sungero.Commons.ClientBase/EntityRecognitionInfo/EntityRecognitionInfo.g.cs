
// ==================================================================
// EntityRecognitionInfoEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{ 
  public class EntityRecognitionInfoDocTypeClassifierTrainingSessionValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.IClassifierTrainingSession>
  {
    public EntityRecognitionInfoDocTypeClassifierTrainingSessionValueInputEventArgs(global::Sungero.Commons.IClassifierTrainingSession oldValue, global::Sungero.Commons.IClassifierTrainingSession newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }





  public class EntityRecognitionInfoFirstPageClassifierTrainingSessionValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.IClassifierTrainingSession>
  {
    public EntityRecognitionInfoFirstPageClassifierTrainingSessionValueInputEventArgs(global::Sungero.Commons.IClassifierTrainingSession oldValue, global::Sungero.Commons.IClassifierTrainingSession newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// EntityRecognitionInfoHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons
{

  public partial class EntityRecognitionInfoFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Commons.IEntityRecognitionInfoFilterState Filter { get; private set; }

    private global::Sungero.Commons.IEntityRecognitionInfoFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public EntityRecognitionInfoFilteringClientHandler(global::Sungero.Commons.IEntityRecognitionInfoFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected EntityRecognitionInfoFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class EntityRecognitionInfoClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Commons.IEntityRecognitionInfo _obj
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfo)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void RecognizedClassValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ClassProbabilityValueInput(global::Sungero.Presentation.DoubleValueInputEventArgs e) { }


    public virtual void EntityIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void EntityTypeValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }




    public virtual void DocTypeClassifierTrainingStatusValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void DocTypeClassifierTrainingSessionValueInput(global::Sungero.Commons.Client.EntityRecognitionInfoDocTypeClassifierTrainingSessionValueInputEventArgs e) { }


    public virtual void VerifiedClassValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void CreatedValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void VerifiedValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void FirstPageClassifierTrainingStatusValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void FirstPageClassifierTrainingSessionValueInput(global::Sungero.Commons.Client.EntityRecognitionInfoFirstPageClassifierTrainingSessionValueInputEventArgs e) { }


    public virtual void VerifiedVersionNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> DocTypeClassifierTrainingStatusFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }






    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> FirstPageClassifierTrainingStatusFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }




    public EntityRecognitionInfoClientHandlers(global::Sungero.Commons.IEntityRecognitionInfo entity) : base(entity)
    {
    }
  }

  public partial class EntityRecognitionInfoFactsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Commons.IEntityRecognitionInfoFacts _obj
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfoFacts)this.Entity; }
    }
    public virtual void FactsFactIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void FactsFieldIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void FactsPropertyNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FactsPropertyValueValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FactsFactNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FactsFieldNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FactsFieldValueValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FactsFieldProbabilityValueInput(global::Sungero.Presentation.DoubleValueInputEventArgs e) { }


    public virtual void FactsPositionValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void FactsVerifiedValueValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FactsFactLabelValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FactsCollectionRecordIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void FactsProbabilityValueInput(global::Sungero.Presentation.DoubleValueInputEventArgs e) { }


    public virtual void FactsFieldConfidenceValueInput(global::Sungero.Presentation.DoubleValueInputEventArgs e) { }


    public virtual void FactsFilledValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> FactsFilledFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public EntityRecognitionInfoFactsClientHandlers(global::Sungero.Commons.IEntityRecognitionInfoFacts entity) : base(entity)
    {
    }
  }

  public partial class EntityRecognitionInfoAdditionalClassifiersClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers _obj
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers)this.Entity; }
    }
    public virtual void AdditionalClassifiersClassifierIDValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void AdditionalClassifiersPredictedClassValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void AdditionalClassifiersProbabilityValueInput(global::Sungero.Presentation.DoubleValueInputEventArgs e) { }


    public EntityRecognitionInfoAdditionalClassifiersClientHandlers(global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// EntityRecognitionInfoClientFunctions.g.cs
// ==================================================================

namespace Sungero.Commons.Client
{
  public partial class EntityRecognitionInfoFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Commons.IEntityRecognitionInfo _obj
    {
      get { return (global::Sungero.Commons.IEntityRecognitionInfo)this.Entity; }
    }

    public EntityRecognitionInfoFunctions(global::Sungero.Commons.IEntityRecognitionInfo entity) : base(entity) { }
  }
}

// ==================================================================
// EntityRecognitionInfoFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Functions
{
  internal static class EntityRecognitionInfo
  {
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.EntityRecognitionInfoFunctions" />
    internal static  void SetClassifierTrainingStatus(global::Sungero.Commons.IEntityRecognitionInfo entityRecognitionInfo, global::System.Nullable<global::Sungero.Core.Enumeration> trainingStatus, global::System.Nullable<global::Sungero.Core.Enumeration> classifierType)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)entityRecognitionInfo).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetClassifierTrainingStatus", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { trainingStatus, classifierType });
    }
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.EntityRecognitionInfoFunctions" />
    internal static  void SetDocTypeClassifierTrainingStatus(global::Sungero.Commons.IEntityRecognitionInfo entityRecognitionInfo, global::System.Nullable<global::Sungero.Core.Enumeration> trainingStatus)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)entityRecognitionInfo).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetDocTypeClassifierTrainingStatus", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { trainingStatus });
    }
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.EntityRecognitionInfoFunctions" />
    internal static  void SetFirstPageClassifierTrainingStatus(global::Sungero.Commons.IEntityRecognitionInfo entityRecognitionInfo, global::System.Nullable<global::Sungero.Core.Enumeration> trainingStatus)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)entityRecognitionInfo).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetFirstPageClassifierTrainingStatus", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { trainingStatus });
    }
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.EntityRecognitionInfoFunctions" />
    internal static  void SetClassifierTrainingSession(global::Sungero.Commons.IEntityRecognitionInfo entityRecognitionInfo, global::Sungero.Commons.IClassifierTrainingSession trainingSession)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)entityRecognitionInfo).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetClassifierTrainingSession", new System.Type[] { typeof(global::Sungero.Commons.IClassifierTrainingSession) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { trainingSession });
    }
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.EntityRecognitionInfoFunctions" />
    internal static  void ResetClassifierTrainingSession(global::Sungero.Commons.IEntityRecognitionInfo entityRecognitionInfo, global::System.Nullable<global::Sungero.Core.Enumeration> classifierType)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)entityRecognitionInfo).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ResetClassifierTrainingSession", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { classifierType });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.EntityRecognitionInfoFunctions" />
      internal static  global::Sungero.Commons.IEntityRecognitionInfo GetEntityRecognitionInfo(global::Sungero.Domain.Shared.IEntity entity)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Commons.IEntityRecognitionInfo>(
          global::System.Guid.Parse("32ea0857-adf7-41c2-bc0c-188320e40786"),
          "GetEntityRecognitionInfo(global::Sungero.Domain.Shared.IEntity)"
      , entity);
      }
      /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.EntityRecognitionInfoFunctions" />
      internal static  void Clone(global::Sungero.Commons.IEntityRecognitionInfo entityRecognitionInfo, global::Sungero.Domain.Shared.IEntity targetEntity)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("32ea0857-adf7-41c2-bc0c-188320e40786"),
          "Clone(global::Sungero.Commons.IEntityRecognitionInfo,global::Sungero.Domain.Shared.IEntity)"
          , entityRecognitionInfo, targetEntity);
      }
      /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.EntityRecognitionInfoFunctions" />
      internal static  global::Sungero.Domain.Shared.IEntity GetDocument(global::Sungero.Commons.IEntityRecognitionInfo entityRecognitionInfo)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Domain.Shared.IEntity>(
          global::System.Guid.Parse("32ea0857-adf7-41c2-bc0c-188320e40786"),
          "GetDocument(global::Sungero.Commons.IEntityRecognitionInfo)"
          , entityRecognitionInfo);
      }

    }
  }
}

// ==================================================================
// EntityRecognitionInfoClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public class EntityRecognitionInfoClientPublicFunctions : global::Sungero.Commons.Client.IEntityRecognitionInfoClientPublicFunctions
  {
  }
}

// ==================================================================
// EntityRecognitionInfoActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public partial class EntityRecognitionInfoActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Commons.IEntityRecognitionInfo _obj { get { return (global::Sungero.Commons.IEntityRecognitionInfo)this.Entity; } }
    public EntityRecognitionInfoActions(global::Sungero.Commons.IEntityRecognitionInfo entity) : base(entity) { }
  }

  public partial class EntityRecognitionInfoCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Commons.IEntityRecognitionInfo> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Commons.IEntityRecognitionInfo>(this.Entities); }
    }
  }

  public partial class EntityRecognitionInfoCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class EntityRecognitionInfoAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class EntityRecognitionInfoAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}