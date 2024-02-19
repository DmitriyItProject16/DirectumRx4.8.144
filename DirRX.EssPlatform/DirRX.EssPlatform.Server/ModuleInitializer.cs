using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Initialization;

namespace DirRX.EssPlatform.Server
{
  public partial class ModuleInitializer
  {

    public override bool IsModuleVisible()
    {
      return true;
    }

    public override void Initializing(Sungero.Domain.ModuleInitializingEventArgs e)
    {
      // Создание/актуализация стандартных ролей, необходимых для работы модуля.
      CreateRoles();
      
      // Создание настроек модуля.
      CreateEssSettings();
      
      // Создание типов прав для модуля.
      CreateEmployeeAccessRightsType();
      
      // Создание типа прав на доступ к действию "Выдать сертификат"
      CreateCertificateIssueAccessRightsType();
      // Создание типа прав на доступ к действию "Отозвать сертификат"
      RevokeCertificateIssueAccessRightsType();
      
      // Выдача прав всем пользователям на справочник EssSetting.
      var allUsers = Roles.AllUsers;
      if (allUsers != null)
      {
        GrantRightOnEssSettings(allUsers);
      }
    }
    
    /// <summary>
    /// Создать настройки взаимодействия с ЛК.
    /// </summary>
    public static void CreateEssSettings()
    {
      InitializationLogger.Debug("Init: Create Ess settings.");
      var essSettings = PublicFunctions.EssSetting.GetSettings();
      if (essSettings == null)
        DirRX.EssPlatform.Functions.EssSetting.CreateSettings();
    }
    
    /// <summary>
    /// Создать типы прав для справочника Сотрудники.
    /// </summary>
    public static void CreateEmployeeAccessRightsType()
    {
      InitializationLogger.Debug("Init: Create access rights type for CreateEssUser action in Employees");
      var mask = EssPlatformSolution.EmployeeOperations.CreateEssUsersDirRX;
      Sungero.Docflow.PublicInitializationFunctions.Module.CreateAccessRightsType(Constants.Module.EmployeeTypeGuid.ToString(), DirRX.EssPlatform.Resources.CreateEssUsers.ToString(), mask,
                                                                                  mask, Sungero.CoreEntities.AccessRightsType.AccessRightsTypeArea.Both,
                                                                                  Constants.Module.DefaultAccessRightsTypeSid.CreateEssUsers, false, string.Empty);
    }
    
    /// <summary>
    /// Создание типа прав на доступ к действию "Выдать сертификат".
    /// </summary>
    public static void CreateCertificateIssueAccessRightsType()
    {
      InitializationLogger.Debug("Init: Create access rights type for CreateCertificateIssueTask action");
      var mask = EssPlatformSolution.EmployeeOperations.CreateCertificateIssueTaskDirRx;
      Sungero.Docflow.PublicInitializationFunctions.Module.CreateAccessRightsType(Constants.Module.EmployeeTypeGuid.ToString(), DirRX.EssPlatform.Resources.CreateCertificateIssueTask.ToString(), mask,
                                                                                  mask, Sungero.CoreEntities.AccessRightsType.AccessRightsTypeArea.Both,
                                                                                  Constants.Module.DefaultAccessRightsTypeSid.CreateCertificateIssueTask, false, string.Empty);
    }
    
    /// <summary>
    /// Создание типа прав на доступ к действию "Отзыв сертификата".
    /// </summary>
    public static void RevokeCertificateIssueAccessRightsType()
    {
      InitializationLogger.Debug("Init: Create access rights type for RevokeCertificateIssueTask action");
      var mask = EssPlatformSolution.EmployeeOperations.RevokeCertificateIssueTaskDirRx;
      Sungero.Docflow.PublicInitializationFunctions.Module.CreateAccessRightsType(Constants.Module.EmployeeTypeGuid.ToString(), 
                                                                                  DirRX.EssPlatform.Resources.RoleDescription_AdminElEmployeeInteractionSystem.ToString(), mask,
                                                                                  mask, Sungero.CoreEntities.AccessRightsType.AccessRightsTypeArea.Both,
                                                                                  Constants.Module.DefaultAccessRightsTypeSid.RevokeCertificateIssueTask, false, string.Empty);
    } 
    
    /// <summary>
    /// Выдача прав всем пользователям на чтение на справочник EssSetting.
    /// </summary>
    /// <param name="allUsers">Роль "все пользователи".</param>
    public static void GrantRightOnEssSettings(IRole allUsers)
    {
      InitializationLogger.Debug("Init: Grant rights on Ess settings to all users.");
      EssSettings.AccessRights.Grant(allUsers, DefaultAccessRightsTypes.Read);
      EssSettings.AccessRights.Save();
    }

    private void CreateRoles()
    {
      InitializationLogger.Debug(DirRX.EssPlatform.Resources.Init_CreateRoles);
      
      var usersWithAccessToIdentityRole = Sungero.Docflow.PublicInitializationFunctions.Module.CreateRole(
        DirRX.EssPlatform.Resources.RoleName_UsersWithAccessToIdentityDocument,
        DirRX.EssPlatform.Resources.RoleDescription_UsersWithAccessToIdentityDocument,
        Constants.Module.UsersWithAccessToIdentityDocument);
      
      // Роль Администраторы системы электронного взаимодействия с сотрудниками
      var adminElRole = Sungero.Docflow.PublicInitializationFunctions.Module.CreateRole(
        DirRX.EssPlatform.Resources.RoleName_AdminElEmployeeInteractionSystem,
        DirRX.EssPlatform.Resources.RoleDescription_AdminElEmployeeInteractionSystem,
        Constants.Module.AdminElEmployeeInteractionSystem);
      
      
      // включаем роль "Администраторы системы электронного взаимодействия с сотрудниками" в роль "Пользователи с доступом к персональным данным"
      if (usersWithAccessToIdentityRole != null && adminElRole != null)
      {
        if (!usersWithAccessToIdentityRole.RecipientLinks.Any(x => Equals(x.Member, adminElRole)))
        {
          usersWithAccessToIdentityRole.RecipientLinks.AddNew().Member = adminElRole;
          usersWithAccessToIdentityRole.Save();
        }
      }
      
    }
  }
}
