using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Initialization;
using DocflowInitFunctions = Sungero.Docflow.PublicInitializationFunctions.Module;

namespace DirRX.SignPlatform.Server
{
  public partial class ModuleInitializer
  {
    public override void Initializing(Sungero.Domain.ModuleInitializingEventArgs e)
    {
      this.CreateDocumentTypes();
      this.GrantRights();
      this.CreateDocumentKinds();
      this.InitializeDocflowParams();
    }
    
    /// <summary>
    /// Создать типы документов.
    /// </summary>
    public virtual void CreateDocumentTypes()
    {
      InitializationLogger.Debug("Init: Create document types.");
      var innerDocumentFlow = Sungero.Docflow.DocumentRegister.DocumentFlow.Inner;
      // Заявление на выпуск сертификата.
      DocflowInitFunctions.CreateDocumentType(Resources.CertificateIssueStatementDocumentName, CertificateIssueStatementDocument.ClassTypeGuid, innerDocumentFlow, true);
    }
    
    /// <summary>
    /// Выдать права.
    /// </summary>
    public virtual void GrantRights()
    {
      // TODO: Выдать права на тип документа Заявление на выпуск сертификата каким-то ролям.
      
      // Выдача прав роли "Администраторы системы электронного взаимодействия с сотрудниками" к действию "Выдать сертификат"
      var adminElRole = Roles.GetAll(g => g.Sid == DirRX.EssPlatform.PublicConstants.Module.AdminElEmployeeInteractionSystem).FirstOrDefault();
      if (adminElRole != null)
      {

        InitializationLogger.Debug("Init: Grant rights on action for CreateCertificateIssueTask and RevokeCertificateIssueTask.");
        Sungero.Company.Employees.AccessRights.Grant(adminElRole, DirRX.EssPlatform.PublicConstants.Module.DefaultAccessRightsTypeSid.CreateCertificateIssueTask);
        Sungero.Company.Employees.AccessRights.Grant(adminElRole, DirRX.EssPlatform.PublicConstants.Module.DefaultAccessRightsTypeSid.RevokeCertificateIssueTask);
        Sungero.Company.Employees.AccessRights.Save();
        CertificateRequests.AccessRights.Grant(adminElRole, DefaultAccessRightsTypes.Read);
        CertificateRequests.AccessRights.Save();
        CertificateIssueTasks.AccessRights.Grant(adminElRole, DefaultAccessRightsTypes.Create);
        CertificateIssueTasks.AccessRights.Save();
        CertificateIssueStatementDocuments.AccessRights.Grant(adminElRole, DefaultAccessRightsTypes.Read);
        CertificateIssueStatementDocuments.AccessRights.Save();
      }
    }
    
    public virtual void CreateDocumentKinds()
    {
      InitializationLogger.Debug("Init: Create document kinds.");

      var notNumerable = Sungero.Docflow.DocumentKind.NumberingType.NotNumerable;
      var innerDocumentFlow = Sungero.Docflow.DocumentRegister.DocumentFlow.Inner;
      
      // Заявление о выпуске электронной подписи.
      DocflowInitFunctions.CreateDocumentKind(Resources.CertificateIssueKind, Resources.CertificateIssueKind,
                                              notNumerable, innerDocumentFlow, false, false, CertificateIssueStatementDocument.ClassTypeGuid, null, Constants.Module.DocumentKind.CertificateIssueKind, false);
    }
    
    /// <summary>
    /// Инициализация параметров Docflow стандартными значениями.
    /// </summary>
    public virtual void InitializeDocflowParams()
    {
      InitializationLogger.Debug("Init: Create docflow params.");
      // Мониторинг в задаче на выпуск сертификата.
      Sungero.Docflow.PublicFunctions.Module.InsertOrUpdateDocflowParam(Constants.Module.ParamKey.CertificateIssueTaskMonitoringKey, Constants.Module.ParamKeyDefaultValues.CertificateIssueTaskMonitoringKey);
      // Завершение в задаче на выпуск сертификата.
      Sungero.Docflow.PublicFunctions.Module.InsertOrUpdateDocflowParam(Constants.Module.ParamKey.CertificateIssueTaskTimeoutKey, Constants.Module.ParamKeyDefaultValues.CertificateIssueTaskTimeoutKey);
      // Мониторинг в задаче на выпуск сертификата для фонового процесса.
      Sungero.Docflow.PublicFunctions.Module.InsertOrUpdateDocflowParam(Constants.Module.ParamKey.CertificateIssueTaskMonitoringBackgroundProcessKey, Constants.Module.ParamKeyDefaultValues.CertificateIssueTaskMonitoringBackgroundProcessKey);
      // Завершение в задаче на выпуск сертификата для фонового процесса.
      Sungero.Docflow.PublicFunctions.Module.InsertOrUpdateDocflowParam(Constants.Module.ParamKey.CertificateIssueTaskTimeoutBackgroundProcessKey, Constants.Module.ParamKeyDefaultValues.CertificateIssueTaskTimeoutBackgroundProcessKey);
    }
  }
}
