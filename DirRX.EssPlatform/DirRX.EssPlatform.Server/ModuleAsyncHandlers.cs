using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace DirRX.EssPlatform.Server
{
  public class ModuleAsyncHandlers
  {
    public virtual void SynchronizeEmployee(DirRX.EssPlatform.Server.AsyncHandlerInvokeArgs.SynchronizeEmployeeInvokeArgs args)
    {
      string employeeIds = args.employeeIds;
      var changedEmployee = EssPlatformSolution.Employees.Get(args.changedEmployeeId);
      var exceptionExsist = false;
      var employeesIdsList = employeeIds.Split(';').Select(long.Parse).ToList();
      var personalPhone = args.personalPhone;
      var needNotifyNewHRAssignmentDirRX = args.needNotifyNewHRAssignmentDirRX;
      var needNotifyExpiredHRAssignmentDirRX = args.needNotifyExpiredHRAssignmentDirRX;
      var needNotifyHRRepeatDirRX = args.needNotifyHRRepeatDirRX;
      var confirmationTypeDirRX = args.confirmationTypeDirRX;
      var messagesEmail = args.messagesEmail;
      var inheritFromBusinessUnitDirRX = args.inheritFromBusinessUnitDirRX;
      
      var addedMinutes = Functions.Module.GetMinutesToNextAsyncExecute(args.RetryIteration, Constants.Module.SynchronizeEmployee);
      args.NextRetryTime = Calendar.Now.AddMinutes(addedMinutes);
      
      Logger.DebugFormat("EssPlatform.AsyncHandlers.SynchronizeEmployee started, iteration: {0}, employeeIds: {1}", args.RetryIteration, employeeIds);
      
      if (args.RetryIteration > Constants.Module.SynchronizeEmployee)
      {
        Logger.ErrorFormat("Essplatform.AsyncHandlers.SynchronizeEmployee didn`t update Employees, iteration: {0}, employeeIds: {1}", args.RetryIteration, employeeIds);
        args.Retry = false;
        changedEmployee.LockedByAsync = false;
        changedEmployee.Save();
        return;
      }
      
      foreach (var employeeId in employeesIdsList)
      {
        try
        {
          var employee = EssPlatformSolution.Employees.Get(employeeId);
          if (employee.PersonalPhoneDirRX != personalPhone)
            employee.PersonalPhoneDirRX = personalPhone;
          if (!employee.NeedNotifyNewHRAssignmentDirRX.HasValue ||
              (employee.NeedNotifyNewHRAssignmentDirRX.HasValue && employee.NeedNotifyNewHRAssignmentDirRX.Value.ToString() != needNotifyNewHRAssignmentDirRX))
            employee.NeedNotifyNewHRAssignmentDirRX = EssPlatform.PublicFunctions.Module.GetNeedNotifyNewHRAssignmentDirRXEnum(needNotifyNewHRAssignmentDirRX);
          if (!employee.NeedNotifyExpiredHRAssignmentDirRX.HasValue ||
              (employee.NeedNotifyExpiredHRAssignmentDirRX.HasValue && employee.NeedNotifyExpiredHRAssignmentDirRX.Value.ToString() != needNotifyExpiredHRAssignmentDirRX))
            employee.NeedNotifyExpiredHRAssignmentDirRX = EssPlatform.PublicFunctions.Module.GetNeedNotifyExpiredHRAssignmentDirRXEnum(needNotifyExpiredHRAssignmentDirRX);
          if (!employee.NeedNotifyHRRepeatDirRX.HasValue ||
              (employee.NeedNotifyHRRepeatDirRX.HasValue && employee.NeedNotifyHRRepeatDirRX.Value.ToString() != needNotifyHRRepeatDirRX))
            employee.NeedNotifyHRRepeatDirRX = EssPlatform.PublicFunctions.Module.GetNeedNotifyHRRepeatDirRXEnum(needNotifyHRRepeatDirRX);
          if(!employee.ConfirmationTypeDirRX.HasValue ||
             (employee.ConfirmationTypeDirRX.HasValue && employee.ConfirmationTypeDirRX.Value.ToString() != confirmationTypeDirRX))
            employee.ConfirmationTypeDirRX = EssPlatform.PublicFunctions.Module.GetConfirmationTypeDirRXEnum(confirmationTypeDirRX);
          if (employee.MessagesEmailDirRX != messagesEmail)
            employee.MessagesEmailDirRX = messagesEmail;
          if (employee.InheritFromBusinessUnitDirRX != inheritFromBusinessUnitDirRX)
            employee.InheritFromBusinessUnitDirRX = employee.Department.BusinessUnit == null ? false : inheritFromBusinessUnitDirRX;
          if (employee.State.IsChanged)
            employee.Save();
        }
        catch (Exception ex)
        {
          Logger.ErrorFormat("EssPlatform.AsyncHandlers.SynchronizeEmployee: could not update Employee. EmployeeId: {0}. {1}. {2}", employeeId, ex.Message, ex.StackTrace);
          args.Retry = true;
          exceptionExsist = true;
        }
      }

      if (!exceptionExsist)
      {
        changedEmployee.LockedByAsync = false;
        changedEmployee.Save();
      }
    }

    public virtual void SendMessageToViber(DirRX.EssPlatform.Server.AsyncHandlerInvokeArgs.SendMessageToViberInvokeArgs args)
    {
      Logger.DebugFormat("Essplatform.AsyncHandlers.SendMessageToViber started, user id: {0}, iteration: {1}", args.userid, args.RetryIteration);
      var employee = EssPlatformSolution.Employees.Get(args.userid);
      // После допустимого количества попыток отправить сообщение отправляем уведомление в RX администратору, в логи пишем ошибку и заканчиваем попытки.
      if (args.RetryIteration >= Constants.Module.SendMessagePossibleRetryCount)
      {
        Logger.ErrorFormat("Essplatform.AsyncHandlers.SendMessageToViber didn`t send message, user id: {0}, iteration: {1}", args.userid, args.RetryIteration);
        args.Retry = false;
        var task = Sungero.Workflow.SimpleTasks.CreateWithNotices(DirRX.EssPlatform.Resources.SendMessagesErrorSubject, Roles.Administrators);
        task.ActiveText = DirRX.EssPlatform.Resources.SendMessageToViberNoticeErrorFormat(employee.Name, employee.Id);
        task.Start();
        return;
      }
      
      EssPlatform.PublicFunctions.Module.SendMessageToViber(employee.PersonalPhoneDirRX, args.messageText);
    }

    public virtual void SendEmail(DirRX.EssPlatform.Server.AsyncHandlerInvokeArgs.SendEmailInvokeArgs args)
    {
      Logger.DebugFormat("Essplatform.AsyncHandlers.SendEmail started, user id: {0}, iteration: {1}", args.userid, args.RetryIteration);
      var employee = EssPlatformSolution.Employees.Get(args.userid);
      // После допустимого количества попыток отправить сообщение отправляем уведомление в RX администратору, в логи пишем ошибку и заканчиваем попытки.
      if (args.RetryIteration >= Constants.Module.SendMessagePossibleRetryCount)
      {
        Logger.ErrorFormat("Essplatform.AsyncHandlers.SendEmail didn`t send message, user id: {0}, iteration: {1}", args.userid, args.RetryIteration);
        args.Retry = false;
        var task = Sungero.Workflow.SimpleTasks.CreateWithNotices(DirRX.EssPlatform.Resources.SendMessagesErrorSubject, Roles.Administrators);
        task.ActiveText = DirRX.EssPlatform.Resources.SendEmailNoticeErrorFormat(employee.Name, employee.Id);
        task.Start();
        return;
      }
      
      var assignment = Sungero.Workflow.AssignmentBases.GetAll(e => e.Id == args.assignmentId).FirstOrDefault();
      if (assignment == null)
        return;
      var newAssignmentsResult = EssPlatform.Functions.Module.TrySendNewAssignmentsMailing(assignment, args.targetSystemName);
    }

    public virtual void SendSms(DirRX.EssPlatform.Server.AsyncHandlerInvokeArgs.SendSmsInvokeArgs args)
    {
      Logger.DebugFormat("Essplatform.AsyncHandlers.SendSms started, user id: {0}, iteration: {1}", args.userid, args.RetryIteration);
      var employee = EssPlatformSolution.Employees.Get(args.userid);
      // После допустимого количества попыток отправить сообщение отправляем уведомление в RX администратору, в логи пишем ошибку и заканчиваем попытки.
      if (args.RetryIteration >= Constants.Module.SendMessagePossibleRetryCount)
      {
        Logger.ErrorFormat("Essplatform.AsyncHandlers.SendSms didn`t send message, user id: {0}, iteration {0}", args.userid, args.RetryIteration);
        args.Retry = false;
        var task = Sungero.Workflow.SimpleTasks.CreateWithNotices(DirRX.EssPlatform.Resources.SendMessagesErrorSubject, Roles.Administrators);
        task.ActiveText = DirRX.EssPlatform.Resources.SendSmsNoticeErrorFormat(employee.Name, employee.Id);
        task.Start();
        return;
      }
      
      EssPlatform.PublicFunctions.Module.SendSMS(employee.PersonalPhoneDirRX, args.messageText);
    }
    
    /// <summary>
    /// Добавить пользователей в личный кабинет.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.
    /// "args.businessUnitIds" - ИД наших организаций.
    /// "args.departmentIds" - ИД подразделений.
    /// "args.employeeIds" - ИД сотрудников.
    /// "args.identificationType" - Тип идентификации.
    /// "args.userId" - ИД пользователя, запустившего активацию.
    /// "args.providerId" - ИД провайдера.
    /// "args.includeSubDepartments" - true, если включены подчиненные подразделения.
    /// </param>
    public virtual void ActivateESSUsers(DirRX.EssPlatform.Server.AsyncHandlerInvokeArgs.ActivateESSUsersInvokeArgs args)
    {
      Logger.DebugFormat("Essplatform.AsyncHandlers.ActivateEssUsers started, iteration: {0}", args.RetryIteration);
      
      // После допустимого количества попыток отправить приглашения в ЛК отправляем уведомление в RX, в логи пишем ошибку и заканчиваем попытки.
      if (args.RetryIteration > Constants.Module.ActivateEssUsersPossibleRetryCount)
      {
        Logger.ErrorFormat(DirRX.EssPlatform.Resources.ActivateEssUsersMaxRetryCount, args.RetryIteration);
        args.Retry = false;
        DirRX.EssPlatform.PublicFunctions.Module.SendNoticeAboutInvite(args.userId, Resources.ErrorESSInvites);
        return;
      }
      
      var businessUnitIds = args.businessUnitIds.Split(',').Where(bu => !string.IsNullOrEmpty(bu)).ToList();
      var departmentIds = args.departmentIds.Split(',').Where(dep => !string.IsNullOrEmpty(dep)).ToList();
      var employeeIds = args.employeeIds.Split(',').Where(emp => !string.IsNullOrEmpty(emp)).ToList();
      var result = DirRX.EssPlatform.PublicFunctions.Module.ActivateESSUsers(businessUnitIds, departmentIds, employeeIds, args.identificationType, Users.Get(args.userId), args.providerId, args.includeSubDepartments);
      
      var totalUsersProcessed = result.AlreadyAcceptedUsersCount + result.AlreadyInvitedUsersCount + result.InvitedUsersCount + result.WithoutPhoneUsersCount + result.CatchErrorUsersCount;
      var message = string.Empty;
      message = DirRX.EssPlatform.Resources.InvitesSendFormat(totalUsersProcessed, result.InvitedUsersCount, result.WithoutPhoneUsersCount, result.WithoutEmailUsersCount, result.AlreadyInvitedUsersCount,
                                                              result.AlreadyAcceptedUsersCount);
      
      if (!string.IsNullOrEmpty(result.Error))
      {
        message += Environment.NewLine;
        message += DirRX.EssPlatform.Resources.InviteSendWithErrorsFormat(result.CatchErrorUsersCount);
      }
      
      DirRX.EssPlatform.PublicFunctions.Module.SendNoticeAboutInvite(args.userId, message);
    }

    /// <summary>
    /// Изменить статус сотрудника.
    /// </summary>
    /// <param name="args">Параметры вызова асинхронного обработчика.</param>
    public virtual void ChangeEmployeeEssStatus(DirRX.EssPlatform.Server.AsyncHandlerInvokeArgs.ChangeEmployeeEssStatusInvokeArgs args)
    {
      Logger.DebugFormat("EssPlatform.AsyncHandlers.ChangeEmployeeEssStatus started, employeeID: {0}, iteration: {1}",args.EmployeeId, args.RetryIteration);
      long employeeId = args.EmployeeId;
      var changeTime = args.changeTime;
      var employee = EssPlatformSolution.Employees.Get(employeeId);
      
      // Если статус подключения изменился уже после того, как было запрошено текущее изменение. То текущее изменение отменяем.
      if (changeTime != null && employee.PersonalAccountStatusChangedDirRX != null && employee.PersonalAccountStatusChangedDirRX > changeTime)
      {
        Logger.DebugFormat("EssPlatform.AsyncHandlers.ChangeEmployeeEssStatus stop, new async change status already is done employeeID: {0}, changeTime: {1}",args.EmployeeId, args.changeTime.ToString());
        return;
      }
      
      var partTimeEmployees = EssPlatformSolution.Employees.GetAll(e => e.Status == Sungero.Company.Employee.Status.Active && e.Person.Equals(employee.Person));
      var statusString = args.EssStatus;
      var status = new Sungero.Core.Enumeration(statusString);
      
      foreach (var partTimeEmployee in partTimeEmployees)
      {
        if (Locks.GetLockInfo(partTimeEmployee).IsLocked)
        {
          Logger.DebugFormat("EssPlatform.AsyncHandlers.ChangeEmployeeEssStatus employee id {0} is locked. Trying again later. Message: {1}", partTimeEmployee.Id, Locks.GetLockInfo(partTimeEmployee).LockedMessage);

          args.Retry = true;
          return;
        }
      }
      
      foreach (var partTimeEmployee in partTimeEmployees)
      {
        if (partTimeEmployee.PersonalAccountStatusDirRX != status)
        {
          try
          {
            partTimeEmployee.PersonalAccountStatusDirRX = status;
            Logger.DebugFormat("EssPlatform.AsyncHandlers.ChangeEmployeeEssStatus set new status {0} for employee id {1}", statusString, partTimeEmployee.Id);
            partTimeEmployee.PersonalAccountStatusChangedDirRX = changeTime;
            partTimeEmployee.Save();
            var operation = new Enumeration(DirRX.EssPlatformSolution.PublicConstants.Company.Employee.StatChanged);
            partTimeEmployee.History.Write(operation, operation, string.Format("Статус: {0}. Изменено от имени: {1}", partTimeEmployee.Info.Properties.PersonalAccountStatusDirRX.GetLocalizedValue(partTimeEmployee.PersonalAccountStatusDirRX), args.initiatorName));
          }
          catch (Exception ex)
          {
            Logger.ErrorFormat("EssPlatform.AsyncHandlers.ChangeEmployeeEssStatus: could not update EssStatus. Employee id: {0}. Error: {1}", partTimeEmployee.Id, ex.Message);
            args.Retry = true;
          }
        }
        else
          Logger.DebugFormat("EssPlatform.AsyncHandlers.ChangeEmployeeEssStatus status {0} has already been set for employee id {1}", statusString, partTimeEmployee.Id);
      }  
    }
  }
}