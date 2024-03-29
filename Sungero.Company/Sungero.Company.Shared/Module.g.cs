
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
      return new global::Sungero.Company.Shared.ModuleFunctions();
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

namespace Sungero.Company
{
  public static class CompanyClientFunctionHyperlinksExtensions
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

namespace Sungero.Company.Shared
{
  public class ModuleResources : global::Sungero.Company.IModuleResources
  {
    public virtual global::CommonLibrary.LocalizedString NoSpacesInCode
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "NoSpacesInCode", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString NoSpacesInCodeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "NoSpacesInCode", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Jobtitle
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Jobtitle", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString JobtitleFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Jobtitle", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Departments
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Departments", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString DepartmentsFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Departments", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString BusinessUnits
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "BusinessUnits", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString BusinessUnitsFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "BusinessUnits", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ManagerOfDepartmens
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "ManagerOfDepartmens", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString ManagerOfDepartmensFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "ManagerOfDepartmens", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString BusinessUnitsCEO
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "BusinessUnitsCEO", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString BusinessUnitsCEOFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "BusinessUnitsCEO", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Roles
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Roles", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString RolesFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Roles", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ManagersAssistants
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "ManagersAssistants", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString ManagersAssistantsFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "ManagersAssistants", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Substitutions
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Substitutions", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString SubstitutionsFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Substitutions", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Manager
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Manager", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString ManagerFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Manager", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Assistant
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Assistant", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString AssistantFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Assistant", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Substitute
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Substitute", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString SubstituteFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Substitute", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Employee
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Employee", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString EmployeeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Employee", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Period
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Period", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString PeriodFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Period", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Permanently
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "Permanently", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString PermanentlyFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "Permanently", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString From
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "From", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString FromFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "From", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString To
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "To", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString ToFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "To", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString VisibilitySettingsNotAvailable
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "VisibilitySettingsNotAvailable", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString VisibilitySettingsNotAvailableFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "VisibilitySettingsNotAvailable", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString BusinessUnitsCAO
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")) , "BusinessUnitsCAO", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString BusinessUnitsCAOFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f")), "BusinessUnitsCAO", false, args);
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

namespace Sungero.Company.Shared
{


public class ManagersAssistantsFilterInfo : global::Sungero.Domain.Shared.FilterInfoBase,
    global::Sungero.Company.FolderFilterInfo.IManagersAssistantsFilterInfo
  {
  }

  public class ManagersAssistantsFilterState : global::Sungero.Domain.Shared.FilterStateBase,
    global::Sungero.Company.FolderFilterState.IManagersAssistantsFilterState
  {



    public new Sungero.Company.FolderFilterInfo.IManagersAssistantsFilterInfo Info
    {
      get
      {
        return (Sungero.Company.FolderFilterInfo.IManagersAssistantsFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new ManagersAssistantsFilterInfo();
    }

  }


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

namespace Sungero.Company.Shared
{
  public partial class ModuleSharedPublicFunctions : global::Sungero.Company.Shared.IModuleSharedPublicFunctions
  {
    public global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant> Remote_GetActiveManagerAssistants()
    {
      return global::Sungero.Company.Functions.Module.Remote.GetActiveManagerAssistants();
    }
    public global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant> Remote_GetAssistants()
    {
      return global::Sungero.Company.Functions.Module.Remote.GetAssistants();
    }
    public global::System.Linq.IQueryable<global::Sungero.CoreEntities.ICertificate> Remote_GetCertificatesOfEmployee(global::Sungero.Company.IEmployee employee)
    {
      return global::Sungero.Company.Functions.Module.Remote.GetCertificatesOfEmployee(employee);
    }
    public global::System.String Remote_GetCountResponsibilitiesReportData(global::Sungero.Company.IEmployee employee)
    {
      return global::Sungero.Company.Functions.Module.Remote.GetCountResponsibilitiesReportData(employee);
    }
    public global::Sungero.Company.IDepartment Remote_GetDepartmentById(global::System.Int64 id)
    {
      return global::Sungero.Company.Functions.Module.Remote.GetDepartmentById(id);
    }
    public global::Sungero.Company.IEmployee Remote_GetEmployeeById(global::System.Int64 id)
    {
      return global::Sungero.Company.Functions.Module.Remote.GetEmployeeById(id);
    }
    public global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> Remote_GetEmployeesByIds(global::System.Collections.Generic.List<global::System.Int64> ids)
    {
      return global::Sungero.Company.Functions.Module.Remote.GetEmployeesByIds(ids);
    }
    public global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> Remote_GetEmployeesFromRecipientsRemote(global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient> recipients)
    {
      return global::Sungero.Company.Functions.Module.Remote.GetEmployeesFromRecipientsRemote(recipients);
    }
    public global::System.Linq.IQueryable<global::Sungero.Company.IEmployee> Remote_GetNotAutomatedEmployees(global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> employees)
    {
      return global::Sungero.Company.Functions.Module.Remote.GetNotAutomatedEmployees(employees);
    }
    public global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetNotSystemEmployees(global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient> recipients)
    {
      return global::Sungero.Company.Functions.Module.GetNotSystemEmployees(recipients);
    }
    public global::System.Linq.IQueryable<global::Sungero.Company.IManagersAssistant> Remote_GetResolutionPreparers()
    {
      return global::Sungero.Company.Functions.Module.Remote.GetResolutionPreparers();
    }
    public global::System.Collections.Generic.List<global::System.Guid> GetSystemRecipientsSidWithoutAllUsers(global::System.Boolean fullSystemRecipientList)
    {
      return global::Sungero.Company.Functions.Module.GetSystemRecipientsSidWithoutAllUsers(fullSystemRecipientList);
    }
    public global::System.Collections.Generic.List<global::System.Int64> Remote_GetVisibleRecipientIds(global::System.String recipientTypeGuid)
    {
      return global::Sungero.Company.Functions.Module.Remote.GetVisibleRecipientIds(recipientTypeGuid);
    }
    public global::System.Boolean Remote_IsRecipientRestrict()
    {
      return global::Sungero.Company.Functions.Module.Remote.IsRecipientRestrict();
    }
    public global::System.Boolean Remote_IsRecipientRestrictModeOn()
    {
      return global::Sungero.Company.Functions.Module.Remote.IsRecipientRestrictModeOn();
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

namespace Sungero.Company.Shared
{  
}
