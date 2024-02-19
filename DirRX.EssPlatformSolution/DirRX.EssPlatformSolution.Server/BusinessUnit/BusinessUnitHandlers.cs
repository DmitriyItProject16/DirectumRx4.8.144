using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.BusinessUnit;

namespace DirRX.EssPlatformSolution
{
  partial class BusinessUnitServerHandlers
  {

    public override void BeforeSave(Sungero.Domain.BeforeSaveEventArgs e)
    {
      base.BeforeSave(e);
      var settings = EssPlatform.PublicFunctions.EssSetting.GetSettings();
      
      // Если проставлена рассылка сообщений по СМС, то проверить, что НОР подключена к ЛК и подключены сервисы ЛК.
      if (((_obj.NeedNotifyNewHRAssignmentDirRXSungero.HasValue && _obj.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.SMS) ||
           (_obj.NeedNotifyHRRepeatDirRXSungero.HasValue && _obj.NeedNotifyHRRepeatDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyHRRepeatDirRXSungero.SMS) ||
           (_obj.NeedNotifyExpiredHRAssignmentDirRXSungero.HasValue && _obj.NeedNotifyExpiredHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyExpiredHRAssignmentDirRXSungero.SMS)) &&
           ((_obj.UseESSDirRX.HasValue && _obj.UseESSDirRX.Value == false) || (settings.IsUsedIdentityService.HasValue && settings.IsUsedIdentityService.Value == false)))
        e.AddError(EssPlatformSolution.BusinessUnits.Resources.SmsAndViberNotifyEmployeesError);
      
      // Если проставлена рассылка сообщений по Viber, то проверить, что НОР подключена к ЛК и подключены сервисы ЛК.
      if (((_obj.NeedNotifyNewHRAssignmentDirRXSungero.HasValue && _obj.NeedNotifyNewHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.Viber) ||
           (_obj.NeedNotifyHRRepeatDirRXSungero.HasValue && _obj.NeedNotifyHRRepeatDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyHRRepeatDirRXSungero.Viber) ||
           (_obj.NeedNotifyExpiredHRAssignmentDirRXSungero.HasValue && _obj.NeedNotifyExpiredHRAssignmentDirRXSungero.Value == EssPlatformSolution.BusinessUnit.NeedNotifyExpiredHRAssignmentDirRXSungero.Viber)) &&
           ((_obj.UseESSDirRX.HasValue && _obj.UseESSDirRX.Value == false) || (settings.IsUsedIdentityService.HasValue && settings.IsUsedIdentityService.Value == false)))
        e.AddError(EssPlatformSolution.BusinessUnits.Resources.SmsAndViberNotifyEmployeesError);
    }

    public override void Created(Sungero.Domain.CreatedEventArgs e)
    {
      base.Created(e);
      _obj.UseESSDirRX = false;
      _obj.NeedNotifyNewHRAssignmentDirRXSungero = EssPlatformSolution.BusinessUnit.NeedNotifyNewHRAssignmentDirRXSungero.No;
      _obj.NeedNotifyHRRepeatDirRXSungero = EssPlatformSolution.BusinessUnit.NeedNotifyHRRepeatDirRXSungero.No;
      _obj.NeedNotifyExpiredHRAssignmentDirRXSungero = EssPlatformSolution.BusinessUnit.NeedNotifyExpiredHRAssignmentDirRXSungero.No;
    }
  }

}