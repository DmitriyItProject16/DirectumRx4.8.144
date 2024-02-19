using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Initialization;

namespace Sungero.Intelligence.Server
{
  public partial class ModuleInitializer
  {

    public override void Initializing(Sungero.Domain.ModuleInitializingEventArgs e)
    {
      var allUsers = Roles.AllUsers;
      if (allUsers != null)
      {
        // Справочники.
        GrantRightsOnDatabooks(allUsers);
      }
    }
    
    /// <summary>
    /// Выдать права всем пользователям на справочники.
    /// </summary>
    /// <param name="allUsers">Группа "Все пользователи".</param>
    public static void GrantRightsOnDatabooks(IRole allUsers)
    {
      InitializationLogger.Debug("Init: Grant rights on databooks to all users.");
      
      // Модуль Интеллектуальные функции.
      Intelligence.AIManagersAssistants.AccessRights.Grant(allUsers, DefaultAccessRightsTypes.Read);
      Intelligence.AIManagersAssistants.AccessRights.Save();

    }
  }
}
