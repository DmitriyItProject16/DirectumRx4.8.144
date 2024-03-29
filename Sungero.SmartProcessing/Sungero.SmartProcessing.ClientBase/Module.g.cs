
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

namespace Sungero.SmartProcessing.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::Sungero.Docflow.IOfficialDocument GetLeadingDocument(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "ClientBase" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.ClientBaseNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.ClientBase";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetLeadingDocument", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)});
        return (global::Sungero.Docflow.IOfficialDocument)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{documents});
      }
      else
      {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase, __finalModuleMetadatda)).GetLeadingDocument(documents);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::System.Int64> DeleteDocumentsDialogInWeb(global::Sungero.SmartProcessing.IVerificationAssignment assignment, global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documentList)
    {
      var __typeName = "Sungero.SmartProcessing.Client.ModuleFunctions";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("DeleteDocumentsDialogInWeb", new global::System.Type[]{typeof(global::Sungero.SmartProcessing.IVerificationAssignment), typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)});
        return (global::System.Collections.Generic.List<global::System.Int64>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{assignment, documentList});
      }
      else
      {
        return global::Sungero.SmartProcessing.Client.ModuleFunctions.DeleteDocumentsDialogInWeb(assignment, documentList);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> TryDeleteDocuments(global::Sungero.SmartProcessing.IVerificationAssignment assignment, global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __typeName = "Sungero.SmartProcessing.Client.ModuleFunctions";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("TryDeleteDocuments", new global::System.Type[]{typeof(global::Sungero.SmartProcessing.IVerificationAssignment), typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)});
        return (global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{assignment, documents});
      }
      else
      {
        return global::Sungero.SmartProcessing.Client.ModuleFunctions.TryDeleteDocuments(assignment, documents);
      }
    }

    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static System.Collections.Generic.IDictionary<System.Type, global::System.Int32> GetPackageDocumentTypePriorities()
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetPackageDocumentTypePriorities", global::System.Array.Empty<global::System.Type>());
        return (System.Collections.Generic.IDictionary<System.Type, global::System.Int32>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, null);
      }
      else
      {
        return ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetPackageDocumentTypePriorities();
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static global::System.Boolean TryLockRepackingSessionDocuments(global::System.Collections.Generic.List<global::Sungero.SmartProcessing.Structures.RepackingSession.RepackingDocument> repackingDocuments)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("TryLockRepackingSessionDocuments", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::Sungero.SmartProcessing.Structures.RepackingSession.RepackingDocument>)});
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{repackingDocuments});
      }
      else
      {
        return ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).TryLockRepackingSessionDocuments(repackingDocuments);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static void UnlockDocumentsWithVersions(global::System.Collections.Generic.List<global::Sungero.SmartProcessing.Structures.RepackingSession.RepackingDocument> repackingDocuments)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("UnlockDocumentsWithVersions", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::Sungero.SmartProcessing.Structures.RepackingSession.RepackingDocument>)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{repackingDocuments});
      }
      else
      {
    ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).UnlockDocumentsWithVersions(repackingDocuments);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static void ClearVerificationState(global::Sungero.Docflow.IOfficialDocument document)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("ClearVerificationState", new global::System.Type[]{typeof(global::Sungero.Docflow.IOfficialDocument)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{document});
      }
      else
      {
    ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).ClearVerificationState(document);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static void DeleteDocumentVersions(global::Sungero.Docflow.IOfficialDocument document)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("DeleteDocumentVersions", new global::System.Type[]{typeof(global::Sungero.Docflow.IOfficialDocument)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{document});
      }
      else
      {
    ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).DeleteDocumentVersions(document);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static void ClearDocumentRelations(global::Sungero.Docflow.IOfficialDocument document)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("ClearDocumentRelations", new global::System.Type[]{typeof(global::Sungero.Docflow.IOfficialDocument)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{document});
      }
      else
      {
    ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).ClearDocumentRelations(document);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static void ConvertDocumentToSimpleObsolete(global::Sungero.Docflow.IOfficialDocument document)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("ConvertDocumentToSimpleObsolete", new global::System.Type[]{typeof(global::Sungero.Docflow.IOfficialDocument)});
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{document});
      }
      else
      {
    ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).ConvertDocumentToSimpleObsolete(document);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static global::System.String RemoveAttachmentsFromVerificationTask(global::Sungero.SmartProcessing.IVerificationAssignment assignment, global::System.Collections.Generic.List<global::System.Int64> deletedDocuments)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("RemoveAttachmentsFromVerificationTask", new global::System.Type[]{typeof(global::Sungero.SmartProcessing.IVerificationAssignment), typeof(global::System.Collections.Generic.List<global::System.Int64>)});
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{assignment, deletedDocuments});
      }
      else
      {
        return ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).RemoveAttachmentsFromVerificationTask(assignment, deletedDocuments);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static global::System.Int32 GetLastAttachmentNumber(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetLastAttachmentNumber", new global::System.Type[]{typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument>)});
        return (global::System.Int32)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{documents});
      }
      else
      {
        return ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).GetLastAttachmentNumber(documents);
      }
    }
    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static global::System.Boolean CanConvertDocument(global::Sungero.Docflow.IOfficialDocument document)
    {
      var __moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
      var __finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(__moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(__moduleId));
      var __funcNamespace = "Shared" == "ClientBase" ? __finalModuleMetadatda.ClientNamespace : __finalModuleMetadatda.SharedNamespace;
      var __typeName = __funcNamespace + ".ModuleFunctions, Sungero.SmartProcessing.Shared";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("CanConvertDocument", new global::System.Type[]{typeof(global::Sungero.Docflow.IOfficialDocument)});
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{document});
      }
      else
      {
        return ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared, __finalModuleMetadatda)).CanConvertDocument(document);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static global::System.Boolean IsEmptyMailBody(global::System.String mailBody, global::System.String mailBodyFileName)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "IsEmptyMailBody(global::System.String,global::System.String)", mailBody, mailBodyFileName);
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static global::Sungero.Docflow.ISimpleDocument CreateSimpleDocumentFromEmailBody(global::Sungero.SmartProcessing.IBlobPackage blobPackage, global::Sungero.Company.IEmployee responsible)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.ISimpleDocument>(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "CreateSimpleDocumentFromEmailBody(global::Sungero.SmartProcessing.IBlobPackage,global::Sungero.Company.IEmployee)", blobPackage, responsible);
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static global::System.Boolean UnpublishClassifierModel(global::System.Int32 classifierId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "UnpublishClassifierModel(global::System.Int32)", classifierId);
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static void RequeueDeleteBlobPackagesJob()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "RequeueDeleteBlobPackagesJob()");
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static global::Sungero.SmartProcessing.IRepackingSession CreateRepackingSession(global::System.Int64 assignmentId, global::System.Collections.Generic.List<global::Sungero.SmartProcessing.Structures.RepackingSession.RepackingDocument> repackingDocuments)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.SmartProcessing.IRepackingSession>(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "CreateRepackingSession(global::System.Int64,global::System.Collections.Generic.List<global::Sungero.SmartProcessing.Structures.RepackingSession.RepackingDocument>)", assignmentId, repackingDocuments);
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static global::System.Boolean TryMakeDocumentDeleted(global::Sungero.Docflow.IOfficialDocument document)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "TryMakeDocumentDeleted(global::Sungero.Docflow.IOfficialDocument)", document);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.SmartProcessing.Client.ModuleFunctions();
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

namespace Sungero.SmartProcessing.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.SmartProcessing.Client.IModuleClientPublicFunctions
  {
    public global::Sungero.Docflow.IOfficialDocument GetLeadingDocument(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      return global::Sungero.SmartProcessing.Functions.Module.GetLeadingDocument(documents);
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

namespace Sungero.SmartProcessing.Client
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

namespace Sungero.SmartProcessing.Client
{

}

