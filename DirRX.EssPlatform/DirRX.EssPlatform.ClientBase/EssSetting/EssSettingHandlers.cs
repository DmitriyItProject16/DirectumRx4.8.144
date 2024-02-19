using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatform.EssSetting;

namespace DirRX.EssPlatform
{
  partial class EssSettingClientHandlers
  {

    public virtual void ConfirmationTypeValueInput(Sungero.Presentation.EnumerationValueInputEventArgs e)
    {
      if (e.NewValue != e.OldValue)
      {
        e.Params.AddOrUpdate(Constants.Module.ConfirmationTypeChangedParamName, true);
      }
    }

    public virtual IEnumerable<Enumeration> ConfirmationTypeFiltering(IEnumerable<Enumeration> query)
    {
      var confirmationTypes = SignPlatform.PublicFunctions.Module.Remote.GetConfirmationTypes();
      return query.Where(t => confirmationTypes.Contains(t.Value));
    }

    public virtual void CertificateMailValueInput(Sungero.Presentation.StringValueInputEventArgs e)
    {
      if (!(string.IsNullOrEmpty(e.NewValue) || Sungero.Parties.PublicFunctions.Module.EmailIsValid(e.NewValue)))
        e.AddError(Sungero.Parties.Resources.WrongEmailFormat);
      else if (!Sungero.Docflow.PublicFunctions.Module.IsASCII(e.NewValue))
        e.AddWarning(Sungero.Docflow.Resources.ASCIIWarning);
    }

    public virtual void IsUsedIdentityServiceValueInput(Sungero.Presentation.BooleanValueInputEventArgs e)
    {
      // Если уже есть подключенные к ЛК сотрудники или сотрудники которым отпрапвлено приглашение или подключенные НОР - не давать снимать галочку.
      if (!e.NewValue.Value)
      {
        if (EssPlatformSolution.Employees.GetAll(emp => emp.PersonalAccountStatusDirRX == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteAccepted ||
                                                 emp.PersonalAccountStatusDirRX == EssPlatformSolution.Employee.PersonalAccountStatusDirRX.InviteSent).Any())
          e.AddError(DirRX.EssPlatform.EssSettings.Resources.DisconnectIdentityServiceError);
        
        if (EssPlatformSolution.BusinessUnits.GetAll(bu => bu.UseESSDirRX == true).Any())
          e.AddError(DirRX.EssPlatform.EssSettings.Resources.DisconnecErrorBusinessUnit);
      }
      
      if (string.IsNullOrEmpty(_obj.AgreementUrl))
        _obj.AgreementUrl = DirRX.EssPlatform.EssSettings.Resources.DefaultAgreementUrl;
      
      if(_obj.ConfirmationType == null)
        _obj.ConfirmationType = ConfirmationType.DefaultValue;
      
    }

    public override void Showing(Sungero.Presentation.FormShowingEventArgs e)
    {
      base.Showing(e);
      Functions.EssSetting.SwitchPropertiesAvailability(_obj);
    }
  }
}