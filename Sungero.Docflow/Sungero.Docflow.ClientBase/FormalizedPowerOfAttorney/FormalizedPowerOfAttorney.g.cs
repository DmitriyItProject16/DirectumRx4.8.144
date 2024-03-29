
// ==================================================================
// FormalizedPowerOfAttorneyEventArgs.g.cs
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
// FormalizedPowerOfAttorneyHandlers.g.cs
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

  public partial class FormalizedPowerOfAttorneyFilteringClientHandler
    : global::Sungero.Docflow.PowerOfAttorneyBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.IFormalizedPowerOfAttorneyFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IFormalizedPowerOfAttorneyFilterState)this.Filter;
      }
    }

    public FormalizedPowerOfAttorneyFilteringClientHandler(global::Sungero.Docflow.IFormalizedPowerOfAttorneyFilterState filter)
    : base(filter)
    {
    }

    protected FormalizedPowerOfAttorneyFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class FormalizedPowerOfAttorneyClientHandlers : global::Sungero.Docflow.PowerOfAttorneyBaseClientHandlers
  {
    private global::Sungero.Docflow.IFormalizedPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IFormalizedPowerOfAttorney)this.Entity; }
    }

    public virtual void FtsListStateValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void FtsRejectReasonValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void RegisteredSignatureIdValueInput(global::Sungero.Presentation.LongIntegerValueInputEventArgs e) { }


    public virtual void FormatVersionValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> FtsListStateFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }




    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> FormatVersionFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public FormalizedPowerOfAttorneyClientHandlers(global::Sungero.Docflow.IFormalizedPowerOfAttorney entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// FormalizedPowerOfAttorneyClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class FormalizedPowerOfAttorneyFunctions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseFunctions
  {
    private global::Sungero.Docflow.IFormalizedPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IFormalizedPowerOfAttorney)this.Entity; }
    }

    public FormalizedPowerOfAttorneyFunctions(global::Sungero.Docflow.IFormalizedPowerOfAttorney entity) : base(entity) { }
  }
}

// ==================================================================
// FormalizedPowerOfAttorneyFunctions.g.cs
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
  internal static class FormalizedPowerOfAttorney
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.FormalizedPowerOfAttorneyFunctions" />
    internal static  void ShowCreateRevocationDialog(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ShowCreateRevocationDialog", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean ShowImportVersionWithSignatureDialog(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ShowImportVersionWithSignatureDialog", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.FormalizedPowerOfAttorneyFunctions" />
    internal static  void GeneratePdfWithSignatureMark(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GeneratePdfWithSignatureMark", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.FormalizedPowerOfAttorneyFunctions" />
    internal static  void OpenInFtsRegistry(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("OpenInFtsRegistry", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.String GetFtsRegistryHyperlink(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.String unifiedRegistrationNumber, global::System.String issuerTin, global::System.String representativeTin)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetFtsRegistryHyperlink", new System.Type[] { typeof(global::System.String), typeof(global::System.String), typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { unifiedRegistrationNumber, issuerTin, representativeTin });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeRegistrationPaneVisibility", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needShow, repeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void SetActiveLifeCycleState(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetActiveLifeCycleState", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void SetLifeCycleAndFtsListStates(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleAndFtsListStates", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void SetLifeCycleActiveAfterImport(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleActiveAfterImport", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void SetLifeCycleAndFtsListStates(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.Nullable<global::Sungero.Core.Enumeration> lifeCycleState, global::System.Nullable<global::Sungero.Core.Enumeration> ftsListState)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleAndFtsListStates", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { lifeCycleState, ftsListState });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean CheckRegistrationNumberUnique(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckRegistrationNumberUnique", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void UpdateLifeCycle(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.Nullable<global::Sungero.Core.Enumeration> registrationState, global::System.Nullable<global::Sungero.Core.Enumeration> approvalState, global::System.Nullable<global::Sungero.Core.Enumeration> counterpartyApprovalState)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("UpdateLifeCycle", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { registrationState, approvalState, counterpartyApprovalState });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void FillName(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, isRepeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean CanImportVersionWithSignature(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanImportVersionWithSignature", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean CanGenerateBodyWithPdf(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanGenerateBodyWithPdf", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean CanRegisterWithService(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanRegisterWithService", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean CanCheckStateWithService(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanCheckStateWithService", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean CanCreateRevocation(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CanCreateRevocation", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.String GetDuplicatesErrorText(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDuplicatesErrorText", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IFormalizedPowerOfAttorney> GetDuplicates(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDuplicates", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.IFormalizedPowerOfAttorney>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void SetLifeCycleState(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetLifeCycleState", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean CheckRequiredPropertiesValues(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckRequiredPropertiesValues", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean NeedSetRequiredProperties(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.Boolean hasExternalSignature)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedSetRequiredProperties", new System.Type[] { typeof(global::System.Boolean) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { hasExternalSignature });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  void SetJustImportedParam(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetJustImportedParam", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.FormalizedPowerOfAttorneyFunctions" />
    internal static  global::System.Boolean CheckSearchData(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)formalizedPowerOfAttorney).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckSearchData", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::Sungero.Docflow.IPowerOfAttorneyRevocation GetRevocation(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IPowerOfAttorneyRevocation>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "GetRevocation(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::Sungero.Docflow.IPowerOfAttorneyRevocation CreateRevocation(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.String reason)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IPowerOfAttorneyRevocation>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "CreateRevocation(global::Sungero.Docflow.IFormalizedPowerOfAttorney,global::System.String)"
          , formalizedPowerOfAttorney, reason);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::System.Boolean GenerateFormalizedPowerOfAttorneyBody(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "GenerateFormalizedPowerOfAttorneyBody(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  void ImportFormalizedPowerOfAttorneyFromXmlAndSign(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::Sungero.Docflow.Structures.Module.IByteArray xml, global::Sungero.Docflow.Structures.Module.IByteArray signature)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "ImportFormalizedPowerOfAttorneyFromXmlAndSign(global::Sungero.Docflow.IFormalizedPowerOfAttorney,global::Sungero.Docflow.Structures.Module.IByteArray,global::Sungero.Docflow.Structures.Module.IByteArray)"
          , formalizedPowerOfAttorney, xml, signature);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::Sungero.PowerOfAttorneyCore.Structures.Module.IResponseResult RegisterFormalizedPowerOfAttorneyWithService(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.PowerOfAttorneyCore.Structures.Module.IResponseResult>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "RegisterFormalizedPowerOfAttorneyWithService(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::Sungero.PowerOfAttorneyCore.Structures.Module.IResponseResult RegisterFormalizedPowerOfAttorneyWithService(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.Nullable<global::System.Int64> taskId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.PowerOfAttorneyCore.Structures.Module.IResponseResult>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "RegisterFormalizedPowerOfAttorneyWithService(global::Sungero.Docflow.IFormalizedPowerOfAttorney,global::System.Nullable<global::System.Int64>)"
          , formalizedPowerOfAttorney, taskId);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IFormalizedPowerOfAttorney> GetFormalizedPowerOfAttorneyDuplicates(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IFormalizedPowerOfAttorney>>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "GetFormalizedPowerOfAttorneyDuplicates(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  void GenerateFormalizedPowerOfAttorneyPdf(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "GenerateFormalizedPowerOfAttorneyPdf(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::Sungero.Docflow.Structures.OfficialDocument.ConversionToPdfResult ConvertToPdfWithSignatureMark(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.OfficialDocument.ConversionToPdfResult>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "ConvertToPdfWithSignatureMark(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::Sungero.Docflow.Structures.OfficialDocument.ConversionToPdfResult ConvertToPdfAndAddSignatureMark(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.Int64 versionId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.OfficialDocument.ConversionToPdfResult>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "ConvertToPdfAndAddSignatureMark(global::Sungero.Docflow.IFormalizedPowerOfAttorney,global::System.Int64)"
          , formalizedPowerOfAttorney, versionId);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  void SyncFormalizedPowerOfAttorneyFtsListState(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "SyncFormalizedPowerOfAttorneyFtsListState(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::System.String CheckFormalizedPowerOfAttorneyState(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "CheckFormalizedPowerOfAttorneyState(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  void CreateSetSignatureSettingsValidTillAsyncHandler(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::System.DateTime validTill)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "CreateSetSignatureSettingsValidTillAsyncHandler(global::Sungero.Docflow.IFormalizedPowerOfAttorney,global::System.DateTime)"
          , formalizedPowerOfAttorney, validTill);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  global::System.String ValidateFormalizedPoABeforeSending(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "ValidateFormalizedPoABeforeSending(global::Sungero.Docflow.IFormalizedPowerOfAttorney)"
          , formalizedPowerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FormalizedPowerOfAttorneyFunctions" />
      internal static  void SetDocumentSignatory(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney, global::Sungero.Company.IEmployee employee)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("104472db-b71b-42a8-bca5-581a08d1ca7b"),
          "SetDocumentSignatory(global::Sungero.Docflow.IFormalizedPowerOfAttorney,global::Sungero.Company.IEmployee)"
          , formalizedPowerOfAttorney, employee);
      }

    }
  }
}

// ==================================================================
// FormalizedPowerOfAttorneyClientPublicFunctions.g.cs
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
  public class FormalizedPowerOfAttorneyClientPublicFunctions : global::Sungero.Docflow.Client.IFormalizedPowerOfAttorneyClientPublicFunctions
  {
    public void GeneratePdfWithSignatureMark(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
global::Sungero.Docflow.Functions.FormalizedPowerOfAttorney.GeneratePdfWithSignatureMark(formalizedPowerOfAttorney);
    }
    public void ShowCreateRevocationDialog(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
global::Sungero.Docflow.Functions.FormalizedPowerOfAttorney.ShowCreateRevocationDialog(formalizedPowerOfAttorney);
    }
    public global::System.Boolean ShowImportVersionWithSignatureDialog(global::Sungero.Docflow.IFormalizedPowerOfAttorney formalizedPowerOfAttorney)
    {
      return global::Sungero.Docflow.Functions.FormalizedPowerOfAttorney.ShowImportVersionWithSignatureDialog(formalizedPowerOfAttorney);
    }
  }
}

// ==================================================================
// FormalizedPowerOfAttorneyActions.g.cs
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
  public partial class FormalizedPowerOfAttorneyActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseActions
  {
    private global::Sungero.Docflow.IFormalizedPowerOfAttorney _obj { get { return (global::Sungero.Docflow.IFormalizedPowerOfAttorney)this.Entity; } }
    public FormalizedPowerOfAttorneyActions(global::Sungero.Docflow.IFormalizedPowerOfAttorney entity) : base(entity) { }
  }

  public partial class FormalizedPowerOfAttorneyCollectionActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IFormalizedPowerOfAttorney> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IFormalizedPowerOfAttorney>(this.Entities); }
    }
  }

  public partial class FormalizedPowerOfAttorneyCollectionBulkActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class FormalizedPowerOfAttorneyAnyChildEntityActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseAnyChildEntityActions
  {
  }

  public partial class FormalizedPowerOfAttorneyAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.PowerOfAttorneyBaseAnyChildEntityCollectionActions
  {
  }



  public partial class FormalizedPowerOfAttorneyVersionsActions : global::Sungero.Docflow.Client.OfficialDocumentVersionsActions
  {
    private global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions _obj { get { return (global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions)this.Entity; } }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions> _all
    {
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions>)this.AllEntities; }
    }
  }

  public partial class FormalizedPowerOfAttorneyVersionsCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentVersionsCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions>(this.Entities); }
    }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions> _all
    {
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IFormalizedPowerOfAttorneyVersions>)this.AllEntities; }
    }
  }



}
