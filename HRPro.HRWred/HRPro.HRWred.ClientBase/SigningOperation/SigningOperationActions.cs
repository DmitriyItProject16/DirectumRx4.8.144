using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using HRPro.HRWred.SigningOperation;

namespace HRPro.HRWred.Client
{
  partial class SigningOperationCollectionActions
  {

    public virtual bool CanExport(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

    public virtual void Export(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      // Проверить, сохранена ли карточка текущей операции подписания.
      if (_objs.Count() == 1 &&_objs.Single().State.IsChanged)
      {
        e.AddError(HRPro.HRWred.SigningOperations.Resources.SaveTheSigningOperationCard);
        return;
      }
      
      // Проверить, что пользователь включен в роль Отвественный за выгрузку кадровых документов.
      var users = Sungero.CoreEntities.Substitutions.ActiveSubstitutedUsersWithoutSystem.ToList();
      users.Add(Users.Current);
      if (HRWred.PublicFunctions.Module.Remote.IsHRDocExportManager(users))
      {
        var signingOperationsId = _objs.Where(s => s.IsSignatoryAnOfficial == false &&
                                              (s.OperationState == HRWred.SigningOperation.OperationState.ReadyForExport ||
                                               s.OperationState == HRWred.SigningOperation.OperationState.Formed ||
                                               s.OperationState == HRWred.SigningOperation.OperationState.Error)).Select(a => a.Id).ToList();
        var containsNotAvailableDocs = _objs.Where(s => s.OperationState == HRWred.SigningOperation.OperationState.AwaitingSigning ||
                                                  s.OperationState == HRWred.SigningOperation.OperationState.Registrated).Any();
        var containsNotRightsDocs = _objs.Where(s => !s.Document.AccessRights.CanReadBody()).Any();
        Functions.Module.ShowPointExportDocumentsDialog(signingOperationsId, containsNotAvailableDocs, containsNotRightsDocs);
      }
      else
        Dialogs.ShowMessage(Resources.CanExportHRDocumentsFormat(Resources.RoleNameHRDocExportManager));
    }
  }

}