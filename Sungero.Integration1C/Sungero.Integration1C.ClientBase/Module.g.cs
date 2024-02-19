
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

namespace Sungero.Integration1C.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity> GetChangedEntitiesFromSyncDate(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.Int32 processedEntitiesCount, global::System.Int32 entitiesCountForProcessing, global::System.String extEntityType, global::System.String systemId)
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetChangedEntitiesFromSyncDate", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::System.Guid>), typeof(global::System.Int32), typeof(global::System.Int32), typeof(global::System.String), typeof(global::System.String)});
        return (global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId});
      }
      else
      {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetChangedEntitiesFromSyncDate(entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId);
      }
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.Int32 GetChangedEntitiesFromSyncDateCount(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.String extEntityType, global::System.String systemId)
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetChangedEntitiesFromSyncDateCount", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::System.Guid>), typeof(global::System.String), typeof(global::System.String)});
        return (global::System.Int32)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{entityTypeGuids, extEntityType, systemId});
      }
      else
      {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetChangedEntitiesFromSyncDateCount(entityTypeGuids, extEntityType, systemId);
      }
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity> GetChangedBankAccountsFromSyncDate(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.Int32 processedEntitiesCount, global::System.Int32 entitiesCountForProcessing, global::System.String extEntityType, global::System.String systemId)
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetChangedBankAccountsFromSyncDate", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::System.Guid>), typeof(global::System.Int32), typeof(global::System.Int32), typeof(global::System.String), typeof(global::System.String)});
        return (global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId});
      }
      else
      {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetChangedBankAccountsFromSyncDate(entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId);
      }
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.Int32 GetChangedBankAccountsFromSyncDateCount(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.String extEntityType, global::System.String systemId)
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetChangedBankAccountsFromSyncDateCount", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::System.Guid>), typeof(global::System.String), typeof(global::System.String)});
        return (global::System.Int32)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{entityTypeGuids, extEntityType, systemId});
      }
      else
      {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetChangedBankAccountsFromSyncDateCount(entityTypeGuids, extEntityType, systemId);
      }
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::Sungero.Docflow.ISimpleDocument GetTodayDocument(global::System.Boolean fileExists)
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetTodayDocument", new global::System.Type[]{typeof(global::System.Boolean)});
        return (global::Sungero.Docflow.ISimpleDocument)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{fileExists});
      }
      else
      {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetTodayDocument(fileExists);
      }
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.Boolean IsSummaryProtocolExist()
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("IsSummaryProtocolExist", global::System.Array.Empty<global::System.Type>());
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).IsSummaryProtocolExist();
      }
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static void SendNotificationBySimpleTaskRemote(global::System.String title, global::System.String text)
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("SendNotificationBySimpleTaskRemote", new global::System.Type[]{typeof(global::System.String), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{title, text});
      }
      else
      {
    ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).SendNotificationBySimpleTaskRemote(title, text);
      }
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static void UpdateLastNotificationDateRemote(global::System.DateTime date, global::System.String systemId)
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("UpdateLastNotificationDateRemote", new global::System.Type[]{typeof(global::System.DateTime), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{date, systemId});
      }
      else
      {
    ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).UpdateLastNotificationDateRemote(date, systemId);
      }
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.String GetLastNotificationDateRemote(global::System.String systemId)
    {
      var __moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Integration1C.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetLastNotificationDateRemote", new global::System.Type[]{typeof(global::System.String)});
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{systemId});
      }
      else
      {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetLastNotificationDateRemote(systemId);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity> GetChangedEntitiesFromSyncDateRemote(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.Int32 processedEntitiesCount, global::System.Int32 entitiesCountForProcessing, global::System.String extEntityType, global::System.String systemId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity>>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetChangedEntitiesFromSyncDateRemote(global::System.Collections.Generic.List<global::System.Guid>,global::System.Int32,global::System.Int32,global::System.String,global::System.String)", entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.Int32 GetChangedEntitiesFromSyncDateRemoteCount(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.String extEntityType, global::System.String systemId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Int32>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetChangedEntitiesFromSyncDateRemoteCount(global::System.Collections.Generic.List<global::System.Guid>,global::System.String,global::System.String)", entityTypeGuids, extEntityType, systemId);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity> GetChangedBankAccountsFromSyncDateRemote(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.Int32 processedEntitiesCount, global::System.Int32 entitiesCountForProcessing, global::System.String extEntityType, global::System.String systemId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity>>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetChangedBankAccountsFromSyncDateRemote(global::System.Collections.Generic.List<global::System.Guid>,global::System.Int32,global::System.Int32,global::System.String,global::System.String)", entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.Int32 GetChangedBankAccountsFromSyncDateRemoteCount(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.String extEntityType, global::System.String systemId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Int32>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetChangedBankAccountsFromSyncDateRemoteCount(global::System.Collections.Generic.List<global::System.Guid>,global::System.String,global::System.String)", entityTypeGuids, extEntityType, systemId);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static void SendNotificationBySimpleTask(global::System.String title, global::System.String text)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "SendNotificationBySimpleTask(global::System.String,global::System.String)", title, text);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::Sungero.Docflow.ISimpleDocument GetTodayDocumentRemote(global::System.Boolean fileExists)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.ISimpleDocument>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetTodayDocumentRemote(global::System.Boolean)", fileExists);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.Boolean IsSummaryProtocolExistRemote()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "IsSummaryProtocolExistRemote()");
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static void UpdateLastNotificationDate(global::System.DateTime date, global::System.String systemId)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "UpdateLastNotificationDate(global::System.DateTime,global::System.String)", date, systemId);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.String GetLastNotificationDate(global::System.String systemId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetLastNotificationDate(global::System.String)", systemId);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Integration1C.Client.ModuleFunctions();
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
// ModuleClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Integration1C.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.Integration1C.Client.IModuleClientPublicFunctions
  {
  }
}

// ==================================================================
// ModuleWidgetHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Integration1C.Client
{
}

// ==================================================================
// ModuleHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Integration1C.Client
{

}

