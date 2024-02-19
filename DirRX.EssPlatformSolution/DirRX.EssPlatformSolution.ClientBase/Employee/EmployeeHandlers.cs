using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Employee;

namespace DirRX.EssPlatformSolution
{
  partial class EmployeeClientHandlers
  {

    public override void EmailValueInput(Sungero.Presentation.StringValueInputEventArgs e)
    {
      base.EmailValueInput(e);
      e.Params.AddOrUpdate(EssPlatform.PublicConstants.Module.PhoneEmailChangedParamName, true);
    }
    /// <summary>
    /// Установить обязательность свойств Email и телефона
    /// </summary>
    /// <param name="needNotifyNew"></param>
    /// <param name="needNotifyExpired"></param>
    /// <param name="needNotifyRepeat"></param>
    public void SetRequiredEmailAndPhone(Enumeration? needNotifyNew, Enumeration? needNotifyExpired, Enumeration? needNotifyRepeat)
    {
      _obj.State.Properties.Email.IsRequired = needNotifyNew.HasValue && needNotifyNew.Value.Value == "Email" ||
                                               needNotifyExpired.HasValue && needNotifyExpired.Value.Value == "Email" ||
                                               needNotifyRepeat.HasValue && needNotifyRepeat.Value.Value == "Email"; 
      _obj.State.Properties.MessagesEmailDirRX.IsRequired = needNotifyNew.HasValue && needNotifyNew.Value.Value == "EmailPersonal" ||
                                               needNotifyExpired.HasValue && needNotifyExpired.Value.Value == "EmailPersonal" ||
                                               needNotifyRepeat.HasValue && needNotifyRepeat.Value.Value == "EmailPersonal"; 
      _obj.State.Properties.PersonalPhoneDirRX.IsRequired = needNotifyNew.HasValue && (needNotifyNew.Value.Value == "SMS" || needNotifyNew.Value.Value == "Viber") ||
                                               needNotifyExpired.HasValue && (needNotifyExpired.Value.Value == "SMS" || needNotifyExpired.Value.Value == "Viber") ||
                                               needNotifyRepeat.HasValue && (needNotifyRepeat.Value.Value == "SMS" || needNotifyRepeat.Value.Value == "Viber"); 
    }
    
    public virtual void PersonalAccountStatusDirRXValueInput(Sungero.Presentation.EnumerationValueInputEventArgs e)
    {
      if (e.NewValue != e.OldValue && !EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.State.Properties.Status.OriginalValue))
        e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.PropertyChangedFormat(_obj.Info.Properties.PersonalAccountStatusDirRX.LocalizedName, _obj.Person.Name));
    }

    public virtual void PersonalPhoneDirRXValueInput(Sungero.Presentation.StringValueInputEventArgs e)
    {
      if (e.NewValue != e.OldValue && !EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.State.Properties.Status.OriginalValue))
        e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.PropertyChangedFormat(_obj.Info.Properties.PersonalPhoneDirRX.LocalizedName, _obj.Person.Name));
      var errors = EssPlatform.PublicFunctions.Module.Remote.CheckPersonalPhoneNumber(e.NewValue, _obj);
      if (errors.Any())
      {
        e.AddError(EssPlatform.Resources.EmployeePhoneCheckErrorsListFormat(string.Join("\n", errors)));
      }
      else
        e.NewValue = EssPlatform.PublicFunctions.Module.PhoneNumberToUniversalFormat(e.NewValue);
      
      e.Params.AddOrUpdate(EssPlatform.PublicConstants.Module.PhoneEmailChangedParamName, true);
    }

    public override void Showing(Sungero.Presentation.FormShowingEventArgs e)
    {
      base.Showing(e);

      if (_obj.PersonalAccountStatusDirRX != PersonalAccountStatusDirRX.InviteIsNotSent)
        e.Params.AddOrUpdate(EssPlatform.Resources.ParameterOldPhoneEmpForUpdateFormat(_obj.Id), _obj.PersonalPhoneDirRX);
    }

    public override void Refresh(Sungero.Presentation.FormRefreshEventArgs e)
    {
      base.Refresh(e);

      if (!(string.IsNullOrEmpty(_obj.MessagesEmailDirRX) || Sungero.Parties.PublicFunctions.Module.EmailIsValid(_obj.MessagesEmailDirRX)))
        e.AddWarning(_obj.Info.Properties.MessagesEmailDirRX, Sungero.Parties.Resources.WrongEmailFormat);

      if (!_obj.State.IsInserted)
      {
        var locked = EssPlatform.PublicFunctions.Module.Remote.CheckLockedByAsyncEmployees(_obj);
        if (locked)
        {
          e.AddInformation(Employees.Resources.LockedByAsync);
          _obj.State.Properties.PersonalAccountStatusDirRX.IsEnabled = false;
          _obj.State.Properties.PersonalPhoneDirRX.IsEnabled = false;
          _obj.State.Properties.MessagesEmailDirRX.IsEnabled = false;
          _obj.State.Properties.NeedNotifyNewHRAssignmentDirRX.IsEnabled = false;
          _obj.State.Properties.NeedNotifyExpiredHRAssignmentDirRX.IsEnabled = false;
          _obj.State.Properties.NeedNotifyHRRepeatDirRX.IsEnabled = false;
          _obj.State.Properties.InheritFromBusinessUnitDirRX.IsEnabled = false;
        }
        else
        {
          _obj.State.Properties.PersonalPhoneDirRX.IsEnabled = true;
          _obj.State.Properties.MessagesEmailDirRX.IsEnabled = true;
          _obj.State.Properties.NeedNotifyNewHRAssignmentDirRX.IsEnabled = true;
          _obj.State.Properties.NeedNotifyExpiredHRAssignmentDirRX.IsEnabled = true;
          _obj.State.Properties.NeedNotifyHRRepeatDirRX.IsEnabled = true;
          _obj.State.Properties.InheritFromBusinessUnitDirRX.IsEnabled = true;
        }
      }
      // Обработать наследование способов оповещений от организации.
      var isInheritFromBusinessUnit = _obj.InheritFromBusinessUnitDirRX.HasValue && _obj.InheritFromBusinessUnitDirRX.Value;
      _obj.State.Properties.NeedNotifyNewHRAssignmentDirRX.IsVisible = !isInheritFromBusinessUnit;
      _obj.State.Properties.NeedNotifyExpiredHRAssignmentDirRX.IsVisible = !isInheritFromBusinessUnit;
      _obj.State.Properties.NeedNotifyHRRepeatDirRX.IsVisible = !isInheritFromBusinessUnit;
     
    }

    public virtual void MessagesEmailDirRXValueInput(Sungero.Presentation.StringValueInputEventArgs e)
    {
      if (!(string.IsNullOrEmpty(e.NewValue) || Sungero.Parties.PublicFunctions.Module.EmailIsValid(e.NewValue)))
        e.AddError(Sungero.Parties.Resources.WrongEmailFormat);
      else if (!Sungero.Docflow.PublicFunctions.Module.IsASCII(e.NewValue))
        e.AddWarning(Sungero.Docflow.Resources.ASCIIWarning);
      
      if (e.NewValue != e.OldValue && !EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.State.Properties.Status.OriginalValue))
        e.AddInformation(DirRX.EssPlatformSolution.Employees.Resources.PropertyChangedFormat(_obj.Info.Properties.MessagesEmailDirRX.LocalizedName, _obj.Person.Name));
      
      e.Params.AddOrUpdate(EssPlatform.PublicConstants.Module.PhoneEmailChangedParamName, true);
    }

    public override void StatusValueInput(Sungero.Presentation.EnumerationValueInputEventArgs e)
    {
      base.StatusValueInput(e);
      if (e.NewValue != null && e.NewValue != e.OldValue)
      {
        if (EssPlatform.PublicFunctions.Module.Remote.IsSingleActivePersonEmployee(_obj, _obj.Status) && e.NewValue.Value == Sungero.CoreEntities.DatabookEntry.Status.Closed
            && _obj.PersonalAccountStatusDirRX.Value != DirRX.EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteIsNotSent)
          e.AddWarning(EssPlatform.Resources.ConfirmDeleteEssUser);
      }
    }
  }
}