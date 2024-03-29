
// ==================================================================
// ModuleFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.ModuleFunctions" />
    internal static void SetDepartmentBoxConnectionStatus(global::Sungero.ExchangeCore.IBusinessUnitBox box)
    {
      var __moduleId = new global::System.Guid("bc0d1897-640a-4b4d-a43a-a23c5984a009");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.ExchangeCore.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("SetDepartmentBoxConnectionStatus", new global::System.Type[]{typeof(global::Sungero.ExchangeCore.IBusinessUnitBox)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{box});
      }
      else
      {
    ((global::Sungero.ExchangeCore.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).SetDepartmentBoxConnectionStatus(box);
      }
    }
    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.ModuleFunctions" />
    internal static global::System.String GetParameterValueFromHyperlink(global::System.String hyperlink, global::System.String parameterName)
    {
      var __moduleId = new global::System.Guid("bc0d1897-640a-4b4d-a43a-a23c5984a009");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.ExchangeCore.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetParameterValueFromHyperlink", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String)});
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{hyperlink, parameterName});
      }
      else
      {
        return ((global::Sungero.ExchangeCore.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetParameterValueFromHyperlink(hyperlink, parameterName);
      }
    }
    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.ModuleFunctions" />
    internal static global::System.String GetDocumentGuidFromHyperlink(global::System.String hyperlink)
    {
      var __moduleId = new global::System.Guid("bc0d1897-640a-4b4d-a43a-a23c5984a009");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.ExchangeCore.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetDocumentGuidFromHyperlink", new global::System.Type[]{typeof(global::System.String)});
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{hyperlink});
      }
      else
      {
        return ((global::Sungero.ExchangeCore.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetDocumentGuidFromHyperlink(hyperlink);
      }
    }
    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.ModuleFunctions" />
    internal static global::System.Boolean CheckGuid(global::System.String guid)
    {
      var __moduleId = new global::System.Guid("bc0d1897-640a-4b4d-a43a-a23c5984a009");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.ExchangeCore.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("CheckGuid", new global::System.Type[]{typeof(global::System.String)});
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{guid});
      }
      else
      {
        return ((global::Sungero.ExchangeCore.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).CheckGuid(guid);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.ModuleFunctions" />
      internal static void RequeueCounterpartySync()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"),
          "RequeueCounterpartySync()");
      }
      /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.ModuleFunctions" />
      internal static void RequeueBoxSync()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"),
          "RequeueBoxSync()");
      }
      /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::System.String> FindOrganizationsInExchangeServices(global::System.String tin, global::System.String trrc, global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox> boxes)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::System.String>>(
          global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"),
          "FindOrganizationsInExchangeServices(global::System.String,global::System.String,global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox>)", tin, trrc, boxes);
      }
      /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.ExchangeCore.IMessageQueueItem> GetMessageQueueItems(global::Sungero.ExchangeCore.IBoxBase rootBox)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.ExchangeCore.IMessageQueueItem>>(
          global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"),
          "GetMessageQueueItems(global::Sungero.ExchangeCore.IBoxBase)", rootBox);
      }
      /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.ExchangeCore.ICounterpartyDepartmentBox> GetCounterpartyDepartmentBoxes(global::Sungero.Parties.ICounterparty counterparty, global::Sungero.ExchangeCore.IBusinessUnitBox businessUnitBox, global::System.String parentBranchId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.ExchangeCore.ICounterpartyDepartmentBox>>(
          global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"),
          "GetCounterpartyDepartmentBoxes(global::Sungero.Parties.ICounterparty,global::Sungero.ExchangeCore.IBusinessUnitBox,global::System.String)", counterparty, businessUnitBox, parentBranchId);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.ExchangeCore.Shared.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType, global::Sungero.Metadata.ModuleMetadata finalModuleMetadatda)
    {
      var assemblyName = finalModuleMetadatda.GetAssemblyName(projectType);
      var moduleFunctionsType = global::System.Type.GetType(global::System.String.Format("{0}.{1}, {2}", finalModuleMetadatda.FunctionNamespace, "Module", assemblyName));
      var methodInfo = moduleFunctionsType.GetMethod("GetFunctionsContainer", global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Static);
      return global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, null, null);
    }
  }
}

// ==================================================================
// ModuleHyperlinks.g.cs
// ==================================================================

namespace Sungero.ExchangeCore
{
  public static class ExchangeCoreClientFunctionHyperlinksExtensions
  {
  }
}

// ==================================================================
// ModuleResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class ModuleResources : global::Sungero.ExchangeCore.IModuleResources
  {
    public virtual global::CommonLibrary.LocalizedString WrongWebsite
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009")) , "WrongWebsite", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString WrongWebsiteFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009")), "WrongWebsite", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ExchangeServiceUsersRoleName
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009")) , "ExchangeServiceUsersRoleName", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString ExchangeServiceUsersRoleNameFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009")), "ExchangeServiceUsersRoleName", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ExchangeServiceUsersRoleDescription
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009")) , "ExchangeServiceUsersRoleDescription", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString ExchangeServiceUsersRoleDescriptionFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009")), "ExchangeServiceUsersRoleDescription", false, args);
    }

  }
}

// ==================================================================
// ModuleFoldersFilterStates.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
}

// ==================================================================
// ModuleSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public partial class ModuleSharedPublicFunctions : global::Sungero.ExchangeCore.Shared.IModuleSharedPublicFunctions
  {
    public global::System.Collections.Generic.List<global::System.String> Remote_FindOrganizationsInExchangeServices(global::System.String tin, global::System.String trrc, global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox> boxes)
    {
      return global::Sungero.ExchangeCore.Functions.Module.Remote.FindOrganizationsInExchangeServices(tin, trrc, boxes);
    }
    public global::System.Linq.IQueryable<global::Sungero.ExchangeCore.ICounterpartyDepartmentBox> Remote_GetCounterpartyDepartmentBoxes(global::Sungero.Parties.ICounterparty counterparty, global::Sungero.ExchangeCore.IBusinessUnitBox businessUnitBox, global::System.String parentBranchId)
    {
      return global::Sungero.ExchangeCore.Functions.Module.Remote.GetCounterpartyDepartmentBoxes(counterparty, businessUnitBox, parentBranchId);
    }
    public void Remote_RequeueBoxSync()
    {
global::Sungero.ExchangeCore.Functions.Module.Remote.RequeueBoxSync();
    }
    public void Remote_RequeueCounterpartySync()
    {
global::Sungero.ExchangeCore.Functions.Module.Remote.RequeueCounterpartySync();
    }
  }
}

// ==================================================================
// ModuleWidgetParameters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{  
}
