
// ==================================================================
// SmartProcessingSettingEventArgs.g.cs
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
// SmartProcessingSettingHandlers.g.cs
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

  public partial class SmartProcessingSettingFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.ISmartProcessingSettingFilterState Filter { get; private set; }

    private global::Sungero.Docflow.ISmartProcessingSettingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public SmartProcessingSettingFilteringClientHandler(global::Sungero.Docflow.ISmartProcessingSettingFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected SmartProcessingSettingFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class SmartProcessingSettingClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Docflow.ISmartProcessingSetting _obj
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSetting)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ArioUrlValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void LowerConfidenceLimitValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void UpperConfidenceLimitValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void LimitsDescriptionValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void TypeClassifierNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void TypeClassifierIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void FirstPageClassifierNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FirstPageClassifierIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }






    public virtual void PasswordValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void LanguagesValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public SmartProcessingSettingClientHandlers(global::Sungero.Docflow.ISmartProcessingSetting entity) : base(entity)
    {
    }
  }

  public partial class SmartProcessingSettingCaptureSourcesClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.ISmartProcessingSettingCaptureSources _obj
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingCaptureSources)this.Entity; }
    }
    public virtual void CaptureSourcesResponsibleValueInput(global::Sungero.Docflow.Client.SmartProcessingSettingCaptureSourcesResponsibleValueInputEventArgs e) { }


    public virtual void CaptureSourcesNoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public SmartProcessingSettingCaptureSourcesClientHandlers(global::Sungero.Docflow.ISmartProcessingSettingCaptureSources entity) : base(entity)
    {
    }
  }

  public partial class SmartProcessingSettingProcessingRulesClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.ISmartProcessingSettingProcessingRules _obj
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingProcessingRules)this.Entity; }
    }
    public virtual void ProcessingRulesClassNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ProcessingRulesGrammarNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ProcessingRulesFunctionNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ProcessingRulesModuleNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public SmartProcessingSettingProcessingRulesClientHandlers(global::Sungero.Docflow.ISmartProcessingSettingProcessingRules entity) : base(entity)
    {
    }
  }

  public partial class SmartProcessingSettingAdditionalClassifiersClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiers _obj
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiers)this.Entity; }
    }
    public virtual void AdditionalClassifiersClassifierIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void AdditionalClassifiersClassifierNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public SmartProcessingSettingAdditionalClassifiersClientHandlers(global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiers entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// SmartProcessingSettingClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class SmartProcessingSettingFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.ISmartProcessingSetting _obj
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSetting)this.Entity; }
    }

    public SmartProcessingSettingFunctions(global::Sungero.Docflow.ISmartProcessingSetting entity) : base(entity) { }
  }
}

// ==================================================================
// SmartProcessingSettingFunctions.g.cs
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
  internal static class SmartProcessingSetting
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.SmartProcessingSettingFunctions" />
    internal static  global::Sungero.Docflow.Structures.SmartProcessingSetting.ClassifierForDialog RunClassifierSelectionDialog(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting, global::System.String dialogTitle)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RunClassifierSelectionDialog", new System.Type[] { typeof(global::System.String) });
      return (global::Sungero.Docflow.Structures.SmartProcessingSetting.ClassifierForDialog)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { dialogTitle });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.SmartProcessingSettingFunctions" />
    internal static  void SelectTypeClassifier(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SelectTypeClassifier", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.SmartProcessingSettingFunctions" />
    internal static  void SelectFirstPageClassifier(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SelectFirstPageClassifier", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::Sungero.Docflow.ISmartProcessingSetting GetSettings()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.SmartProcessingSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetSettings",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::Sungero.Docflow.ISmartProcessingSetting)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Docflow.Shared.SmartProcessingSettingFunctions.GetSettings();
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::System.String GetArioUrl()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.SmartProcessingSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetArioUrl",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Docflow.Shared.SmartProcessingSettingFunctions.GetArioUrl();
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::System.Boolean SmartProcessingIsEnabled()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.SmartProcessingSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("SmartProcessingIsEnabled",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Docflow.Shared.SmartProcessingSettingFunctions.SmartProcessingIsEnabled();
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::Sungero.Company.IEmployee GetDocumentProcessingResponsible(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting, global::System.String senderLineName)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentProcessingResponsible", new System.Type[] { typeof(global::System.String) });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { senderLineName });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.ISmartProcessingSettingCaptureSources> GetNotUniqueNameSources(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetNotUniqueNameSources", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Docflow.ISmartProcessingSettingCaptureSources>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::System.String ValidateSenderLineName(global::System.String senderLineName)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.SmartProcessingSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("ValidateSenderLineName",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { senderLineName });
      }
      else
      {
        return global::Sungero.Docflow.Shared.SmartProcessingSettingFunctions.ValidateSenderLineName(senderLineName);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage ValidateArioUrl(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateArioUrl", new System.Type[] {  });
      return (global::Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage ValidateClassifiers(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateClassifiers", new System.Type[] {  });
      return (global::Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage ValidateLanguages(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateLanguages", new System.Type[] {  });
      return (global::Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage ValidateConfidenceLimits(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateConfidenceLimits", new System.Type[] {  });
      return (global::Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  void ValidateSettings(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting, global::System.String senderLineName)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateSettings", new System.Type[] { typeof(global::System.String) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { senderLineName });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  void ValidateSenderLineSettingExisting(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting, global::System.String senderLineName)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ValidateSenderLineSettingExisting", new System.Type[] { typeof(global::System.String) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { senderLineName });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.String> GetAdditionalClassifierIds(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)smartProcessingSetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetAdditionalClassifierIds", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::System.String>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SmartProcessingSettingFunctions" />
    internal static  global::System.String ValidateLogin(global::System.String login)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.SmartProcessingSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("ValidateLogin",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { login });
      }
      else
      {
        return global::Sungero.Docflow.Shared.SmartProcessingSettingFunctions.ValidateLogin(login);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  void CreateSettings()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "CreateSettings()"
      );
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  global::System.Int32 GetArioConnectionTimeoutInSeconds()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Int32>(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "GetArioConnectionTimeoutInSeconds()"
      );
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  global::System.String GetArioToken(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "GetArioToken(global::Sungero.Docflow.ISmartProcessingSetting)"
          , smartProcessingSetting);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.SmartProcessingSetting.ClassifierForDialog> GetArioClassifiers(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.SmartProcessingSetting.ClassifierForDialog>>(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "GetArioClassifiers(global::Sungero.Docflow.ISmartProcessingSetting)"
          , smartProcessingSetting);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  global::System.Boolean IsArioClassifiersExist(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "IsArioClassifiersExist(global::Sungero.Docflow.ISmartProcessingSetting)"
          , smartProcessingSetting);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  global::System.Boolean CheckLanguagesSupportedByArio(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "CheckLanguagesSupportedByArio(global::Sungero.Docflow.ISmartProcessingSetting)"
          , smartProcessingSetting);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  global::System.Collections.Generic.List<global::System.String> GetArioSupportedLanguages(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::System.String>>(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "GetArioSupportedLanguages(global::Sungero.Docflow.ISmartProcessingSetting)"
          , smartProcessingSetting);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  global::System.Boolean CheckConnection(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "CheckConnection(global::Sungero.Docflow.ISmartProcessingSetting)"
          , smartProcessingSetting);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SmartProcessingSettingFunctions" />
      internal static  global::Sungero.Docflow.Structures.SmartProcessingSetting.LoginResult Login(global::Sungero.Docflow.ISmartProcessingSetting smartProcessingSetting, global::System.String password, global::System.Boolean passwordIsEncrypted)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.SmartProcessingSetting.LoginResult>(
          global::System.Guid.Parse("22610ea3-dd6d-4aee-b7cc-0ba6cd179eb1"),
          "Login(global::Sungero.Docflow.ISmartProcessingSetting,global::System.String,global::System.Boolean)"
          , smartProcessingSetting, password, passwordIsEncrypted);
      }

    }
  }
}

// ==================================================================
// SmartProcessingSettingClientPublicFunctions.g.cs
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
  public class SmartProcessingSettingClientPublicFunctions : global::Sungero.Docflow.Client.ISmartProcessingSettingClientPublicFunctions
  {
  }
}

// ==================================================================
// SmartProcessingSettingActions.g.cs
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
  public partial class SmartProcessingSettingActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Docflow.ISmartProcessingSetting _obj { get { return (global::Sungero.Docflow.ISmartProcessingSetting)this.Entity; } }
    public SmartProcessingSettingActions(global::Sungero.Docflow.ISmartProcessingSetting entity) : base(entity) { }
  }

  public partial class SmartProcessingSettingCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.ISmartProcessingSetting> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.ISmartProcessingSetting>(this.Entities); }
    }
  }

  public partial class SmartProcessingSettingCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class SmartProcessingSettingAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class SmartProcessingSettingAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
