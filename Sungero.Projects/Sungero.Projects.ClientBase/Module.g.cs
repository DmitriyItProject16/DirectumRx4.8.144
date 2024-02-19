
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

namespace Sungero.Projects.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.Projects.ClientBase" type="Sungero.Projects.Client.ModuleFunctions" />
    internal static void CreateDocument()
    {
      var __moduleId = new global::System.Guid("356e6500-45bc-482b-9791-189b5adedc28");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Projects.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("CreateDocument", global::System.Array.Empty<global::System.Type>());
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
    ((global::Sungero.Projects.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).CreateDocument();
      }
    }
    /// <redirect project="Sungero.Projects.ClientBase" type="Sungero.Projects.Client.ModuleFunctions" />
    internal static void CreateProject()
    {
      var __moduleId = new global::System.Guid("356e6500-45bc-482b-9791-189b5adedc28");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Projects.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("CreateProject", global::System.Array.Empty<global::System.Type>());
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
    ((global::Sungero.Projects.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).CreateProject();
      }
    }
    /// <redirect project="Sungero.Projects.ClientBase" type="Sungero.Projects.Client.ModuleFunctions" />
    internal static void ShowProjectRightsNotifyOnce(Sungero.Domain.Shared.BaseEventArgs e, global::System.String message)
    {
      var __moduleId = new global::System.Guid("356e6500-45bc-482b-9791-189b5adedc28");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Projects.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("ShowProjectRightsNotifyOnce", new global::System.Type[]{typeof(Sungero.Domain.Shared.BaseEventArgs), typeof(global::System.String)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{e, message});
      }
      else
      {
    ((global::Sungero.Projects.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).ShowProjectRightsNotifyOnce(e, message);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Projects.Server" type="Sungero.Projects.Server.ModuleFunctions" />
      internal static void RequeueProjectDocumentRightsSync()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("356e6500-45bc-482b-9791-189b5adedc28"),
          "RequeueProjectDocumentRightsSync()");
      }
      /// <redirect project="Sungero.Projects.Server" type="Sungero.Projects.Server.ModuleFunctions" />
      internal static void RequeueProjectRightsSync()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("356e6500-45bc-482b-9791-189b5adedc28"),
          "RequeueProjectRightsSync()");
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Projects.Client.ModuleFunctions();
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

namespace Sungero.Projects.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.Projects.Client.IModuleClientPublicFunctions
  {
    public void ShowProjectRightsNotifyOnce(Sungero.Domain.Shared.BaseEventArgs e, global::System.String message)
    {
global::Sungero.Projects.Functions.Module.ShowProjectRightsNotifyOnce(e, message);
    }
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

namespace Sungero.Projects.Client
{
      public partial class ProjectStagesWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Projects.Shared.ProjectStagesWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Projects.Shared.ProjectStagesWidgetParameters)this.InnerParameters;
          }
        }


        public ProjectStagesWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

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

namespace Sungero.Projects.Client
{

  public partial class ProjectDocumentsFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Projects.FolderFilterState.IProjectDocumentsFilterState Filter { get; private set; }

    private global::Sungero.Projects.FolderFilterState.IProjectDocumentsFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void ProjectDocumentsValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public ProjectDocumentsFolderHandlers(global::Sungero.Projects.FolderFilterState.IProjectDocumentsFilterState filter)
    {
      this.Filter = filter;
    }

  }

}
