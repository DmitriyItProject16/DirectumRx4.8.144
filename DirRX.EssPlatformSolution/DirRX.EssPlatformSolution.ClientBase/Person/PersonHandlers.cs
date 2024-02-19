using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Person;

namespace DirRX.EssPlatformSolution
{
  partial class PersonClientHandlers
  {

    public override void INILAValueInput(Sungero.Presentation.StringValueInputEventArgs e)
    {
      base.INILAValueInput(e);

      if (_obj.Nonresident != true)
      {
        var inilaError = Functions.Person.CheckInila(e.NewValue);
        if (!string.IsNullOrEmpty(inilaError))
          e.AddError(inilaError);
      }
    }

    public override void Refresh(Sungero.Presentation.FormRefreshEventArgs e)
    {
      base.Refresh(e);
      DirRX.EssPlatformSolution.PublicFunctions.Person.SetRequiredAndVisibleProperties(_obj);
    }
  }

}