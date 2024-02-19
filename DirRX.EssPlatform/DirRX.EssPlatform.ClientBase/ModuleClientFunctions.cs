using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Company;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow;

namespace DirRX.EssPlatform.Client
{
  public class ModuleFunctions
  {

    /// <summary>
    /// Запустить фоновый процесс проверки статуса запросов на выдачу сертификата.
    /// </summary>
    [Public]
    public virtual void StartCertificateRequestJob()
    {
      var adminElEmployeeInteraction = Roles.GetAll(w => w.Sid == DirRX.EssPlatform.PublicConstants.Module.AdminElEmployeeInteractionSystem).FirstOrDefault();
      if (adminElEmployeeInteraction != null)
        // Если пользователь не входит в группу "Администраторы системы электронного взаимодействия с сотрудниками", ему не доступен ФП.
        if (!Users.Current.IncludedIn(adminElEmployeeInteraction))
      {
        Dialogs.ShowMessage(DirRX.EssPlatform.Resources.UserNotAdminElEmployeeInteractionSystem, MessageType.Information);
        return;
      }
      
      SignPlatform.Jobs.CertificateIssueTaskMonitoring.Enqueue();
      Dialogs.NotifyMessage(DirRX.EssPlatform.Resources.CertificateRequestJobStarted);
    }

    /// <summary>
    /// Показать все записи справочника запросов на выдачу сертификата.
    /// </summary>
    [Public]
    public virtual void ShowCertificateRequest()
    {
      SignPlatform.CertificateRequests.GetAll().Show();
    }

    /// <summary>
    /// Показать роли модуля.
    /// </summary>
    [Public]
    public virtual void ShowEssRoles()
    {
      Functions.Module.Remote.GetEssRoles().ShowModal();
    }
    
    /// <summary>
    /// Показать настройки взаимодействия с ЛК.
    /// </summary>
    [Public]
    public virtual void ShowEssSettings()
    {
      var essSettings = PublicFunctions.EssSetting.GetSettings();
      essSettings.Show();
    }
    
    /// <summary>
    /// Подключение пользователей к сервису.
    /// </summary>
    [Public]
    public virtual void InviteUsers()
    {
      // Если пользователь не входит в группу Администраторы, ему не доступна отправка приглашений.
      if (!Users.Current.IncludedIn(Roles.Administrators))
      {
        Dialogs.ShowMessage(DirRX.EssPlatform.Resources.UserNotAdministrator, MessageType.Information);
        return;
      }
      
      // Если отключена настройка "Подключить сервисы личного кабинета", то последующие проверки выполняться не будут.
      if (!EssPlatform.PublicFunctions.EssSetting.Remote.SettingsConnected())
      {
        Dialogs.ShowMessage(DirRX.EssPlatform.Resources.NoEssSettings, MessageType.Error);
        return;
      }
      
      var dialog = Dialogs.CreateInputDialog(Resources.BulkSendInvantions);
      dialog.HelpCode = Constants.Module.HelpCodes.BulkSendInvantionsDialog;
      // Выбор НОР.
      var businessUnitString = dialog.AddString(Resources.BusinessUnit, false);
      businessUnitString.IsEnabled = false;
      var selectBU = dialog.AddHyperlink(Resources.SelectBusinessUnits);
      // Выбор подразделений.
      var departmentString = dialog.AddString(Resources.Department, false);
      departmentString.IsEnabled = false;
      var selectDep = dialog.AddHyperlink(Resources.SelectDepartments);
      // Флаг отправки подчиненным подразделениям.
      var includeSubDepartments = dialog.AddBoolean(Resources.IncludeSubordinateDepartments, true);
      // Выбор сотрудников.
      var employeeString = dialog.AddString(Resources.Employee, false);
      employeeString.IsEnabled = false;
      var selectEmp = dialog.AddHyperlink(Resources.SelectEmployees);

      // Выбор способа идентификации.
      var cloudSignProviderInfos = SignPlatform.PublicFunctions.Module.GetCloudSignProviderInfo();
      var signProviderInfo = cloudSignProviderInfos.FirstOrDefault();
      
      if (signProviderInfo == null)
      {
        Dialogs.ShowMessage(DirRX.EssPlatform.Resources.CloudSignError, MessageType.Error);
        return;
      }

      var cloudSignProviderType = dialog
          .AddSelect(SignPlatform.Resources.SetIdentificationTypeDialogCloudProvider, true, signProviderInfo.Name)
          .From(cloudSignProviderInfos.Select(info => info.Name).ToArray());

      var identificationType = dialog
        .AddSelect(SignPlatform.Resources.SetIdentificationTypeDialogIdentificationType, true, signProviderInfo.IdentificationTypes.Select(type => type.Value).First())
        .From(signProviderInfo.IdentificationTypes.Select(type => type.Value).ToArray());
                 
      cloudSignProviderType.SetOnValueChanged((x) =>
                                                {
                                                  if (x.NewValue != x.OldValue)
                                                  {
                                                    signProviderInfo = cloudSignProviderInfos.Single(info => Equals(x.NewValue, info.Name));
                                                    
                                                    identificationType.From(signProviderInfo.IdentificationTypes.Select(type => type.Value).ToArray());
                                                  }
                                                });
      
      // Настроить фильтрации.
      var businessUnitIds = new List<string>();
      var departmentIds = new List<string>();
      var employeeIds = new List<string>();
      
      // Выбрать НОР. Если НОР изменились, очистить Подразделения и Сотрудников.
      selectBU.SetOnExecute(
        () =>
        {
          var businessUnits = EssPlatformSolution.BusinessUnits.GetAll(bu => bu.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                                                       && bu.UseESSDirRX.HasValue
                                                                       && bu.UseESSDirRX.Value);
          var selectbusinessUnits = businessUnits.ShowSelectMany();
          businessUnitString.Value = string.Join("; ", selectbusinessUnits.Select(bu => bu.Name));
          businessUnitIds.Clear();
          businessUnitIds.AddRange(selectbusinessUnits.Select(bu => bu.Id.ToString()));
        });
      
      businessUnitString.SetOnValueChanged(
        e =>
        {
          if (e.OldValue != e.NewValue)
          {
            departmentString.Value = string.Empty;
            departmentIds.Clear();
            employeeString.Value = string.Empty;
            employeeIds.Clear();
          }
        });
      
      // Выбрать Подразделения. Если подразделения изменились, очистить Сотрудников.
      selectDep.SetOnExecute(
        () =>
        {
          var departments = Departments.GetAll(dep => dep.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                               && dep.BusinessUnit != null
                                               && dep.BusinessUnit.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                               && EssPlatformSolution.BusinessUnits.As(dep.BusinessUnit).UseESSDirRX.HasValue
                                               && EssPlatformSolution.BusinessUnits.As(dep.BusinessUnit).UseESSDirRX.Value
                                               && (!businessUnitIds.Any() || (businessUnitIds.Any() && businessUnitIds.Contains(dep.BusinessUnit.Id.ToString()))));
          var selectDepartments = departments.ShowSelectMany();
          departmentString.Value = string.Join("; ", selectDepartments.Select(dep => dep.Name));
          departmentIds.Clear();
          departmentIds.AddRange(selectDepartments.Select(dep => dep.Id.ToString()));
        });
      
      departmentString.SetOnValueChanged(
        e =>
        {
          if (e.OldValue != e.NewValue)
          {
            employeeString.Value = string.Empty;
            employeeIds.Clear();
          }
        });
      
      // Выбрать сотрудников.
      selectEmp.SetOnExecute(
        () =>
        {
          var employees = EssPlatformSolution.Employees.GetAll(emp => emp.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                                               && emp.Department != null
                                                               && emp.Department.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                                               && emp.Department.BusinessUnit != null
                                                               && emp.Department.BusinessUnit.Status == Sungero.CoreEntities.DatabookEntry.Status.Active
                                                               && EssPlatformSolution.BusinessUnits.As(emp.Department.BusinessUnit).UseESSDirRX.HasValue
                                                               && EssPlatformSolution.BusinessUnits.As(emp.Department.BusinessUnit).UseESSDirRX.Value
                                                               && (!businessUnitIds.Any() || (businessUnitIds.Any() && businessUnitIds.Contains(emp.Department.BusinessUnit.Id.ToString())))
                                                               && (!departmentIds.Any() || (departmentIds.Any() && departmentIds.Contains(emp.Department.Id.ToString()))));
          var selectEmployees = employees.ShowSelectMany();
          employeeString.Value = string.Join("; ", selectEmployees.Select(emp => emp.Name));
          
          employeeIds.Clear();
          employeeIds.AddRange(selectEmployees.Select(emp => emp.Id.ToString()));
        });
      
      // Отправить приглашения.
      if (dialog.Show() == DialogButtons.Ok)
      {
        var asyncHandler = AsyncHandlers.ActivateESSUsers.Create();
        asyncHandler.businessUnitIds = string.Join(",", businessUnitIds.ToArray());
        asyncHandler.departmentIds = string.Join(",", departmentIds.ToArray());
        asyncHandler.includeSubDepartments = includeSubDepartments.Value.Value;
        asyncHandler.employeeIds = string.Join(",", employeeIds.ToArray());
        asyncHandler.userId = Users.Current.Id;
        asyncHandler.identificationType = signProviderInfo.IdentificationTypes.FirstOrDefault(k => k.Value == identificationType.Value).Key;
        asyncHandler.providerId = signProviderInfo.ProviderId;
        asyncHandler.ExecuteAsync();
        
        Dialogs.NotifyMessage(Resources.ESSInviteSentToAsync);
      }
    }
  }
}