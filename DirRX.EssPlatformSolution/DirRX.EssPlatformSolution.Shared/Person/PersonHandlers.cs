using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Person;

namespace DirRX.EssPlatformSolution
{
  partial class PersonSharedHandlers
  {

    public virtual void IdentityDocumentKindChanged(Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e)
    {
      DirRX.EssPlatformSolution.PublicFunctions.Person.SetIdentityDocumentRequiredAndVisibleProperties(_obj);
      
      if (_obj.IdentityDocumentKind.Equals(DirRX.EssPlatformSolution.Person.IdentityDocumentKind.PassportRF))
      {
        _obj.IdentityDocumentExpirationDate = null;
      }
      else if (_obj.IdentityDocumentKind.Equals(DirRX.EssPlatformSolution.Person.IdentityDocumentKind.OtherDocument) 
               || _obj.IdentityDocumentKind.Equals(DirRX.EssPlatformSolution.Person.IdentityDocumentKind.ForeignPassport))
      {
        _obj.IdentityDocumentIssuerID = null;
      }
      else
      {
        _obj.IdentityDocumentSeries = null;
        _obj.IdentityDocumentNumber = null;
        _obj.IdentityDocumentIssueDate = null;
        _obj.IdentityDocumentIssuedBy = null;
        _obj.IdentityDocumentIssuerID = null;
        _obj.IdentityDocumentExpirationDate = null;
      }
    }

  }
}