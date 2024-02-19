using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Initialization;

namespace HRPro.HRWred.Server
{
  public partial class ModuleInitializer
  {

    public override void Initializing(Sungero.Domain.ModuleInitializingEventArgs e)
    {
      // Создание роли Ответственные за выгрузку кадровых документов.
      var HRDocExportManager = CreateRoleHRDocExportManager();
      // Выдача полных прав на справочник SigningOperation роли Ответственные за выгрузку кадровых документов.
      GrantRightOnSigningOperation(HRDocExportManager);
      
    }
    
    /// <summary>
    /// Создать роль Ответственные за выгрузку кадровых документов.
    /// </summary>
    /// <returns>Созданная роль.</returns>
    public IRole CreateRoleHRDocExportManager()
    {
      InitializationLogger.Debug("Init: Create role HR Document Export Manager.");
      return Sungero.Docflow.PublicInitializationFunctions.Module.CreateRole(Resources.RoleNameHRDocExportManager,
                                                                             Resources.RoleDescrHRDocExportManager,
                                                                             HRWred.Constants.Module.HRDocExportManager);
    }
    
    /// <summary>
    /// Выдать права на справочник SigningOperation роли Ответственные за выгрузку кадровых документов.
    /// </summary>
    /// <param name="responsibleForHandlingErrors">Роль Ответственные за выгрузку кадровых документов.</param>
    public static void GrantRightOnSigningOperation(IRole HRDocExportManager)
    {
      InitializationLogger.Debug("Init: Grant rights on SigningOperation for HR Document Export Manager.");
      SigningOperations.AccessRights.Grant(HRDocExportManager, DefaultAccessRightsTypes.Change);
      SigningOperations.AccessRights.Save();
    }
    
  }
}
