
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

namespace Sungero.Company.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static void ShowVisibilitySettings()
    {
      var __moduleId = new global::System.Guid("d534e107-a54d-48ec-85ff-bc44d731a82f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Company.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("ShowVisibilitySettings", global::System.Array.Empty<global::System.Type>());
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
    ((global::Sungero.Company.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).ShowVisibilitySettings();
      }
    }
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static void CreateEmployee()
    {
      var __moduleId = new global::System.Guid("d534e107-a54d-48ec-85ff-bc44d731a82f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Company.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("CreateEmployee", global::System.Array.Empty<global::System.Type>());
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
    ((global::Sungero.Company.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).CreateEmployee();
      }
    }
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static void CreateBusinessUnit()
    {
      var __moduleId = new global::System.Guid("d534e107-a54d-48ec-85ff-bc44d731a82f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Company.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("CreateBusinessUnit", global::System.Array.Empty<global::System.Type>());
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
    ((global::Sungero.Company.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).CreateBusinessUnit();
      }
    }
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static void CreateDepartment()
    {
      var __moduleId = new global::System.Guid("d534e107-a54d-48ec-85ff-bc44d731a82f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Company.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("CreateDepartment", global::System.Array.Empty<global::System.Type>());
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
    ((global::Sungero.Company.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).CreateDepartment();
      }
    }
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient> GetAllActiveNoSystemGroups()
    {
      var __typeName = "Sungero.Company.Client.ModuleFunctions";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetAllActiveNoSystemGroups", global::System.Array.Empty<global::System.Type>());
        return (global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
        return global::Sungero.Company.Client.ModuleFunctions.GetAllActiveNoSystemGroups();
      }
    }

    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::System.Guid> GetSystemRecipientsSidWithoutAllUsers(global::System.Boolean fullSystemRecipientList)
    {
      var __moduleId = new global::System.Guid("d534e107-a54d-48ec-85ff-bc44d731a82f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Company.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetSystemRecipientsSidWithoutAllUsers", new global::System.Type[]{typeof(global::System.Boolean)});
        return (global::System.Collections.Generic.List<global::System.Guid>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{fullSystemRecipientList});
      }
      else
      {
        return ((global::Sungero.Company.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetSystemRecipientsSidWithoutAllUsers(fullSystemRecipientList);
      }
    }
    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant> GetActiveManagersAssistants()
    {
      var __moduleId = new global::System.Guid("d534e107-a54d-48ec-85ff-bc44d731a82f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.Company.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetActiveManagersAssistants", global::System.Array.Empty<global::System.Type>());
        return (global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
        return ((global::Sungero.Company.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetActiveManagersAssistants();
      }
    }
    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetNotSystemEmployees(global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient> recipients)
    {
      var __typeName = "Sungero.Company.Shared.ModuleFunctions";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetNotSystemEmployees", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient>)});
        return (global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{recipients});
      }
      else
      {
        return global::Sungero.Company.Shared.ModuleFunctions.GetNotSystemEmployees(recipients);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IEmployee CreateEmployee()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IEmployee>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "CreateEmployee()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IBusinessUnit CreateBusinessUnit()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IBusinessUnit>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "CreateBusinessUnit()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IDepartment CreateDepartment()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IDepartment>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "CreateDepartment()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IVisibilitySetting GetVisibilitySettings()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IVisibilitySetting>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetVisibilitySettings()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.CoreEntities.IRole GetCEORole()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.CoreEntities.IRole>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetCEORole()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IEmployee GetEmployeeById(global::System.Int64 id)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IEmployee>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetEmployeeById(global::System.Int64)", id);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetEmployeesByIds(global::System.Collections.Generic.List<global::System.Int64> ids)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetEmployeesByIds(global::System.Collections.Generic.List<global::System.Int64>)", ids);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IDepartment GetDepartmentById(global::System.Int64 id)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IDepartment>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetDepartmentById(global::System.Int64)", id);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.CoreEntities.ICertificate> GetCertificatesOfEmployee(global::Sungero.Company.IEmployee employee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.CoreEntities.ICertificate>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetCertificatesOfEmployee(global::Sungero.Company.IEmployee)", employee);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Company.IEmployee> GetNotAutomatedEmployees(global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> employees)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetNotAutomatedEmployees(global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)", employees);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetEmployeesFromRecipientsRemote(global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient> recipients)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetEmployeesFromRecipientsRemote(global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient>)", recipients);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.String GetCountResponsibilitiesReportData(global::Sungero.Company.IEmployee employee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetCountResponsibilitiesReportData(global::Sungero.Company.IEmployee)", employee);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient> GetAllRecipients()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetAllRecipients()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Boolean IsRecipientRestrict()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "IsRecipientRestrict()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Boolean IsRecipientRestrictModeOn()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "IsRecipientRestrictModeOn()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::System.Int64> GetVisibleRecipientIds(global::System.String recipientTypeGuid)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::System.Int64>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetVisibleRecipientIds(global::System.String)", recipientTypeGuid);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant> GetActiveManagerAssistants()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetActiveManagerAssistants()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant> GetAssistants()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetAssistants()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant> GetResolutionPreparers()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetResolutionPreparers()");
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Company.Client.ModuleFunctions();
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

namespace Sungero.Company.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.Company.Client.IModuleClientPublicFunctions
  {
    public global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient> GetAllActiveNoSystemGroups()
    {
      return global::Sungero.Company.Functions.Module.GetAllActiveNoSystemGroups();
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

namespace Sungero.Company.Client
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

namespace Sungero.Company.Client
{

  public partial class ManagersAssistantsFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Company.FolderFilterState.IManagersAssistantsFilterState Filter { get; private set; }

    private global::Sungero.Company.FolderFilterState.IManagersAssistantsFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void ManagersAssistantsValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public ManagersAssistantsFolderHandlers(global::Sungero.Company.FolderFilterState.IManagersAssistantsFilterState filter)
    {
      this.Filter = filter;
    }

  }

}

