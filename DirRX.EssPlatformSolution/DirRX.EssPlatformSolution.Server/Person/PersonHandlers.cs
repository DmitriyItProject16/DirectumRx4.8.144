using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Person;

namespace DirRX.EssPlatformSolution
{
  partial class PersonCreatingFromServerHandler
  {

    public override void CreatingFrom(Sungero.Domain.CreatingFromEventArgs e)
    {
      base.CreatingFrom(e);
      e.Without(_info.Properties.TIN);
      e.Without(_info.Properties.INILA);
      e.Without(_info.Properties.IdentityDocumentKind);
      e.Without(_info.Properties.IdentityDocumentSeries);
      e.Without(_info.Properties.IdentityDocumentNumber);
      e.Without(_info.Properties.IdentityDocumentIssueDate);
      e.Without(_info.Properties.IdentityDocumentIssuedBy);
      e.Without(_info.Properties.IdentityDocumentIssuerID);
      e.Without(_info.Properties.IdentityDocumentExpirationDate);
    }
  }


  partial class PersonServerHandlers
  {
    
    public override void BeforeSave(Sungero.Domain.BeforeSaveEventArgs e)
    {
      base.BeforeSave(e);
      
      if (_obj.IdentityDocumentKind == null)
      {
        return;
      }
      
      // Проверить реквизиты документа, удостоверяющего личность.
      var errors = DirRX.EssPlatformSolution.PublicFunctions.Person.CheckPersonIdentityDocument(_obj);
      foreach (var error in errors)
      {
        e.AddError(error.Key, error.Value);
      }
      
      // Проверть корректность СНИЛС.
      if (_obj.Nonresident != true)
      {
        var errorMessage = Functions.Person.CheckInila(_obj.INILA);
        if (!string.IsNullOrEmpty(errorMessage))
          e.AddError(_obj.Info.Properties.INILA, errorMessage);
      }
      
      // Проверить дату рождения
      if (_obj.DateOfBirth != null && _obj.DateOfBirth > Calendar.Now)
      {
          e.AddError(_obj.Info.Properties.DateOfBirth, DirRX.EssPlatformSolution.People.Resources.DateOfBirthError);
      }
    }
    
  }

}