using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.SignPlatform.CertificateIssueStatementAcceptAssignment;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DirRX.SignPlatform.Client
{
  partial class CertificateIssueStatementAcceptAssignmentActions
  {
    public virtual void Refuse(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      if (string.IsNullOrWhiteSpace(_obj.ActiveText))
      {
        e.AddError(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.RefuseReasonRequired);
        return;
      }
    }

    public virtual bool CanRefuse(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return true;
    }

    public virtual void Accept(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var task = SignPlatform.CertificateIssueTasks.As(_obj.Task);
      if (!Functions.Module.Remote.ExistsCertificateRequest(task.RequestId.Value))
      {
        e.AddError(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.AcceptExecuteError);
        Logger.DebugFormat("CertificateIssue. AcceptAssignment.Accept(). TaskID={0} RequestId={1} not found in CertificateRequest", _obj.Task.Id, task.RequestId);
        e.Cancel();
      }
      Logger.DebugFormat("CertificateIssue. AcceptAssignment.Accept(). TaskID={0} RequestId={1} started", _obj.Task.Id, task.RequestId);
      var certificateStatement = _obj.CertificateIssueStatementAttachmentGroup.CertificateIssueStatementDocuments.FirstOrDefault();
      
      if (task.IdentificationType == CertificateIssueTask.IdentificationType.Personal)
      {
        #region  Обработаем личную идентификацию
        var result = SignPlatform.PublicFunctions.Module.Remote.SendCertificateIssueConfirmation(task.RequestId.Value, task.IdentificationType.Value.Value, task.Employee.PersonalPhoneDirRX, task.ProviderId);
        var codeResult = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(result).Code;
        if (codeResult == SignPlatform.Constants.Module.SignServiceResponseCodes.Success)
        {
          #region Логика отправки второго фактора
          var isComplete = false;
          var timeCall = Calendar.Now.AddMinutes(1);
          while (!isComplete)
          {
            #region Цикл ввода второго фактора
            var isMinuteDidNotPassAfterCreateDialog = true;
            var text = Resources.CertificateIssueMessageFormat(certificateStatement, SignPlatform.Functions.Module.Remote.GetHiddenPhone(task.Employee.PersonalPhoneDirRX)).ToString();
            while (isMinuteDidNotPassAfterCreateDialog)
            {
              var accessTokenDialog = Dialogs.CreateInputDialog(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.AccessTokenDialogTitle);
              var hyperlink = accessTokenDialog.AddHyperlink(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.AccessTokenDialogHyperLink);
              hyperlink.SetOnExecute(
                () =>
                {
                  certificateStatement.Open();
                }
               );
              accessTokenDialog.Text = text;
              
              var code = accessTokenDialog.AddString(Resources.VerificationCode, true);
              if (accessTokenDialog.Show() == DialogButtons.Ok)
              {
                #region будем отправлять код на проверку
                string result2FA;
                if (Regex.IsMatch(code.Value, Constants.Module.ConfirmCodePattern))
                {
                  result2FA = SignPlatform.PublicFunctions.Module.Remote.SendCertificateIssueConfirmPersonal(task.RequestId.Value, code.Value, task.ProviderId);
                }
                else
                {
                  result2FA = SignPlatform.Constants.Module.SignServiceResponseCodes.WrongConfirmationCode;
                }
                Logger.DebugFormat("CertificateIssue. AcceptAssignment.Accept(). TaskID={0} requestEntry.RequestId={1} result2FA={2}", _obj.Task.Id, task.RequestId, result2FA);
                if (result2FA == SignPlatform.Constants.Module.SignServiceResponseCodes.Success)
                {
                  #region Код принят сервисом
                  Logger.DebugFormat("CertificateIssue. AcceptAssignment.Accept(). TaskID={0} requestEntry.RequestId={1} Code is ok", _obj.Task.Id, task.RequestId);
                  // выполнить задание
                  return;
                  #endregion
                }
                else if (result2FA == SignPlatform.Constants.Module.SignServiceResponseCodes.TooManyAttempts)
                {
                  Dialogs.ShowMessage(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.TooManyAttemptsSMSError, string.Empty, MessageType.Warning, string.Empty);
                  e.Cancel();
                }
                else
                {
                  #region ввели неверный код
                  string s;
                  if (result2FA == SignPlatform.Constants.Module.SignServiceResponseCodes.WrongConfirmationCode)
                    s = DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.WrongConfirmationCodeError;
                  else
                    s = DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.OtherConfirmationCodeError;
                  var confirm = Dialogs.CreateConfirmDialog(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.EnterCodeAgainTitle, string.Format(s, certificateStatement.Name));
                  if (!confirm.Show())
                  {
                    e.Cancel();
                  }
                  #endregion
                }
                #endregion
              }
              else
              {
                #region псевдо-таймер на закрытие окна
                var timeUseButtonCancel = Calendar.Now;
                if (timeCall < timeUseButtonCancel)
                {
                  e.Cancel();
                }
                else
                {
                  text = string.Format(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.PseudoTimerText,
                                       Resources.CertificateIssueMessageFormat(certificateStatement, SignPlatform.Functions.Module.Remote.GetHiddenPhone(task.Employee.PersonalPhoneDirRX)).ToString(),
                                       timeCall.Subtract(timeUseButtonCancel).Seconds);
                }
                #endregion
              }
            }
            #endregion
          }
          #endregion
        }
        else
        {
          #region При выполнении запроса были проблемы, показать сообщения
          Dialogs.ShowMessage(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.ExecuteError, string.Empty, MessageType.Warning, string.Empty);
          // Если была ошибка на этом уровне - то не выполнять задание
          e.Cancel();
          #endregion
        }
        #endregion
      }
      
      if (task.IdentificationType == CertificateIssueTask.IdentificationType.Esia)
      {
        #region Обработать идентификацию через ЕСИА
        var dialog = Dialogs.CreateInputDialog(Resources.ConfirmCertificateIssue);
        dialog.Buttons.AddOk();
        dialog.Buttons.AddCancel();
        dialog.Text = Resources.GosuslugiConfirmMessage;
        dialog.Width = 600;
        var hyperlink = dialog.AddHyperlink(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.OpenStatementHyperLinkText);
        hyperlink.SetOnExecute(
          () =>
          {
            certificateStatement.Open();
          }
         );
        
        //var confirm = dialog.Show();
        if (dialog.Show() == DialogButtons.Ok)
        {
          // Отправить заявление на подписание
          var result = SignPlatform.PublicFunctions.Module.Remote.SendCertificateIssueConfirmation(task.RequestId.Value, task.IdentificationType.Value.Value, task.Employee.PersonalPhoneDirRX, task.ProviderId);
          var codeResult = JsonConvert.DeserializeObject<SignPlatform.Structures.Module.HttpRequestErrorResult>(result).Code;
          Logger.DebugFormat("CertificateIssue. AcceptAssignment.Accept(). TaskID={0} Result after SendCertificateIssueConfirmation() result={1}", _obj.Task.Id, codeResult);
          
          // первый запрос отработал корректно, покажем окно для ввода второго фактора
          if (codeResult == SignPlatform.Constants.Module.SignServiceResponseCodes.Success)
          {
            #region Заявление успешно отправлено в госуслуги.
            return;
            #endregion
          }
          else
          {
            #region При выполнении запроса были проблемы, показать сообщения
            Dialogs.ShowMessage(DirRX.SignPlatform.CertificateIssueStatementAcceptAssignments.Resources.ExecuteError, string.Empty, MessageType.Warning, string.Empty);
            // Если была ошибка на этом уровне - то не выполнять задание
            e.Cancel();
            #endregion
          }
        }
        // если не вышли по успешной ветке, значит надо прекратить выполнение задания
        e.Cancel();
        #endregion
      }
    }

    public virtual bool CanAccept(Sungero.Workflow.Client.CanExecuteResultActionArgs e)
    {
      return true;
    }
  }
}