
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

namespace Sungero.PowerOfAttorneyCore.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.PowerOfAttorneyCore.ClientBase" type="Sungero.PowerOfAttorneyCore.Client.ModuleFunctions" />
    internal static void CreateAndShowServiceAttorneyConnection()
    {
      var __moduleId = new global::System.Guid("1ecb3185-14ae-422d-99c6-babcf2ab059f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.PowerOfAttorneyCore.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("CreateAndShowServiceAttorneyConnection", global::System.Array.Empty<global::System.Type>());
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
    ((global::Sungero.PowerOfAttorneyCore.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).CreateAndShowServiceAttorneyConnection();
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.PowerOfAttorneyCore.Server" type="Sungero.PowerOfAttorneyCore.Server.ModuleFunctions" />
      internal static global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection CreateAttorneyServiceConnection()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection>(
          global::System.Guid.Parse("1ecb3185-14ae-422d-99c6-babcf2ab059f"),
          "CreateAttorneyServiceConnection()");
      }
      /// <redirect project="Sungero.PowerOfAttorneyCore.Server" type="Sungero.PowerOfAttorneyCore.Server.ModuleFunctions" />
      internal static global::System.String GetOrganizationIdFromService(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection poaServiceConnection)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("1ecb3185-14ae-422d-99c6-babcf2ab059f"),
          "GetOrganizationIdFromService(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection)", poaServiceConnection);
      }
      /// <redirect project="Sungero.PowerOfAttorneyCore.Server" type="Sungero.PowerOfAttorneyCore.Server.ModuleFunctions" />
      internal static global::Sungero.PowerOfAttorneyCore.Structures.Module.IPowerOfAttorneyRevocationInfo GetPowerOfAttorneyRevocationInfo(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection serviceConnection, global::System.String unifiedRegistrationNumber)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.PowerOfAttorneyCore.Structures.Module.IPowerOfAttorneyRevocationInfo>(
          global::System.Guid.Parse("1ecb3185-14ae-422d-99c6-babcf2ab059f"),
          "GetPowerOfAttorneyRevocationInfo(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceConnection,global::System.String)", serviceConnection, unifiedRegistrationNumber);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.PowerOfAttorneyCore.Client.ModuleFunctions();
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

namespace Sungero.PowerOfAttorneyCore.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.PowerOfAttorneyCore.Client.IModuleClientPublicFunctions
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

namespace Sungero.PowerOfAttorneyCore.Client
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

namespace Sungero.PowerOfAttorneyCore.Client
{

}

