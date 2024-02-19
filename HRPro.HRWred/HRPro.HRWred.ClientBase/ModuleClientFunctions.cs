using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Company;
using Sungero.Docflow;

namespace HRPro.HRWred.Client
{
  public class ModuleFunctions
  {

    // TODO Доработать всю выгрузку из карточки или списка.
    /// <summary>
    /// Выгрузить документы из карточки или списка.
    /// </summary>
    /// <param name="documents">Список выгружаемых документов.</param>
    /// <returns>Ошибка для вывода пользователю. Если ошибок нет, то возврат пустой строки.</returns>
    [Public]
    public string ExportDocumentsFromCardOrList(List<Sungero.Docflow.IOfficialDocument> documents)
    {
      //var docsForExport = new List<Structures.Module.ExportedDocument>();
      //var exportResult = Structures.Module.ExportResult.Create();
      //try
      //{
      //  docsForExport = Functions.Module.Remote.PrepareExportHRDocuments(documents);
      //}
      //catch (Exception ex)
      //{
      //  var addErrorMessage = Resources.ExportDialog_Error_Client_NoReason;
      //  Logger.Error(addErrorMessage, ex);
      //  return addErrorMessage;
      //}
      //exportResult = Functions.Module.Remote.PrepareBodiesAndSignsDocuments(docsForExport, documents, null);
      //var zipModelFilesCount = exportResult.ZipModels.Sum(m => m.ZipFiles.Count());
      //var zipModelFilesSumSize = exportResult.ZipModels.Sum(m => m.ZipFiles.Sum(f => f.Size));
      //var zipModelFilesSumSizeMB = zipModelFilesSumSize / Constants.Module.ConvertMb;
      //if (zipModelFilesCount > Constants.Module.ExportedFilesCountMaxLimit)
      //{
      //  var addErrorMessage = Resources.ExportDialog_Error_ExportedFilesLimitFormat(Constants.Module.ExportedFilesCountMaxLimit);
      //  return addErrorMessage;
      //}
      //if (zipModelFilesSumSize > Constants.Module.ExportedFilesSizeMaxLimitMb * Constants.Module.ConvertMb)
      //{
      //  var addErrorMessage = Resources.ExportDialog_Error_ExportedSizeLimitFormat(Constants.Module.ExportedFilesSizeMaxLimitMb);
      //  return addErrorMessage;
      //}
      //
      //IZip zip = null;
      //try
      //{
      //  zip = Functions.Module.Remote.CreateZipFromZipModel(exportResult.ZipModels, exportResult.ExportedDocuments, null);
      //}
      //catch (Exception ex)
      //{
      //  var addErrorMessage = Resources.ExportDialog_Error_Client_NoReason;
      //  Logger.Error(addErrorMessage, ex);
      //  return addErrorMessage;
      //}
      //
      //zip.Export();
      return string.Empty;
    }

    /// <summary>
    /// Показать диалог выгрузки документов.
    /// </summary>
    [Public]
    public virtual void ShowExportDocumentsDialog()
    {
      // Диалог запроса параметров и его свойства.
      var exportDialog = Dialogs.CreateInputDialog(Resources.ExportDocuments);
      exportDialog.HelpCode = Constants.Module.HelpCodes.ExportPersonellDocumentsDialog;
      
      exportDialog.Text = Resources.ExportParamsDialogInstruction;
      // НОР.
      var businessUnit = Employees.Current == null ? BusinessUnits.Null : Employees.Current.Department.BusinessUnit;
      var businessUnitSelect = exportDialog.AddSelect<IBusinessUnit>(Resources.BusinessUnitFieldName, true, businessUnit);
      // Подразделения.
      var departmentSelect = exportDialog.AddMultilineString(Resources.DeparmentFieldName, false).RowsCount(4);
      departmentSelect.IsEnabled = false;
      var selectedDepartments = new List<IDepartment>();
      // Выбор подразделения.
      var hyperlinkDepartmentSelect = exportDialog.AddHyperlink(Resources.Select);
      hyperlinkDepartmentSelect.SetOnExecute(
        () =>
        {
          var departments = Functions.Module.Remote.GetFilteredDepartmentsAsQueryable(businessUnitSelect.Value, false);
          selectedDepartments = departments.ShowSelectMany().ToList();
          departmentSelect.Value = string.Join("; ", selectedDepartments.Select(s => s.Name));
        });
      // Сотрудники.
      var employeeSelect = exportDialog.AddMultilineString(Resources.EmployeeFieldName, false).RowsCount(4);
      employeeSelect.IsEnabled = false;
      var selectedEmployees = new List<IEmployee>();
      // Выбор сотрудников.
      var hyperlinkEmployeesSelect = exportDialog.AddHyperlink(Resources.Select);
      hyperlinkEmployeesSelect.SetOnExecute(
        () =>
        {
          var empl = Functions.Module.Remote.GetFilteredEmployeesAsQueryable(businessUnitSelect.Value, selectedDepartments.Any() ? selectedDepartments : null, null);
          selectedEmployees = empl.ShowSelectMany().ToList();
          employeeSelect.Value = string.Join("; ", selectedEmployees.Select(s => s.Name));
        });
      // Виды документов.
      var documentKindSelect = exportDialog.AddMultilineString(Resources.DocumentKindsFieldName, false).RowsCount(6);
      documentKindSelect.IsEnabled = false;
      var selectedDocumentKinds = new List<HRProWredSolution.IDocumentKind>();
      // Выбор видов документов.
      var hyperlinkKindSelect = exportDialog.AddHyperlink(Resources.Select);
      hyperlinkKindSelect.SetOnExecute(
        () =>
        {
          var documentKindsIDs = PublicFunctions.Module.Remote.GetHRDocumentKindsIDs();
          selectedDocumentKinds =  HRProWredSolution.DocumentKinds.GetAll(d => documentKindsIDs.Contains(d.Id)).ShowSelectMany().ToList();
          documentKindSelect.Value = string.Join("; ", selectedDocumentKinds.Select(s => s.Name));
        });
      // Даты создания документов - с и по.
      var beginPeriodSelect = exportDialog.AddDate(Resources.PeriodFromFieldName, false);
      var endPeriodSelect = exportDialog.AddDate(Resources.PeriodToFieldName, false);
      
      // Изменение значений свойств.
      businessUnitSelect.SetOnValueChanged(arg =>
                                           {
                                             if (!Equals(arg.NewValue, arg.OldValue))
                                             {
                                               if (arg.NewValue == null || (!string.IsNullOrEmpty(departmentSelect.Value) && selectedDepartments.Any() &&
                                                                            !Equals(arg.NewValue, selectedDepartments.FirstOrDefault().BusinessUnit)))
                                               {
                                                 selectedDepartments = null;
                                                 departmentSelect.Value = string.Empty;
                                               }
                                               if (arg.NewValue == null || (!string.IsNullOrEmpty(employeeSelect.Value) && selectedEmployees.Any() &&
                                                                            !Equals(arg.NewValue, selectedEmployees.FirstOrDefault().Department.BusinessUnit)))
                                               {
                                                 selectedEmployees = null;
                                                 employeeSelect.Value = string.Empty;
                                               }
                                             }
                                           });
      departmentSelect.SetOnValueChanged(arg =>
                                         {
                                           if (!Equals(arg.NewValue, arg.OldValue))
                                           {
                                             selectedEmployees = null;
                                             employeeSelect.Value = string.Empty;
                                           }
                                         });
      
      // Кнопки.
      var nextButton = exportDialog.Buttons.AddCustom(Resources.NextButton);
      var fileListButton = exportDialog.Buttons.AddCustom(Resources.FileListButton);
      fileListButton.IsVisible = false;
      var backButton = exportDialog.Buttons.AddCustom(Resources.BackButton);
      backButton.IsVisible = false;
      var exportButton = exportDialog.Buttons.AddCustom(Resources.ExportButton);
      exportButton.IsVisible = false;
      var closeButton = exportDialog.Buttons.AddCustom(Resources.CloseButton);
      closeButton.IsVisible = false;
      var cancelButton = exportDialog.Buttons.AddCustom(Resources.CancelButton);
      exportDialog.Buttons.Default = nextButton;
      
      // Действия.
      var documentsCount = 0;
      var exportEnabled = false;
      IQueryable<IOfficialDocument> documents = null;
      var idSigningOperations = new List<long>();
      exportDialog.SetOnButtonClick(
        (h) =>
        {
          h.CloseAfterExecute = h.Button == cancelButton || h.Button == closeButton;
          // Проверить корректность введенного периода.
          if (beginPeriodSelect.Value != null && endPeriodSelect.Value != null && beginPeriodSelect.Value > endPeriodSelect.Value)
            h.AddError(Resources.ExportDatesError);
          
          // Далее.
          if (h.Button == nextButton && h.IsValid)
          {
            businessUnitSelect.IsVisible = false;
            departmentSelect.IsVisible = false;
            hyperlinkDepartmentSelect.IsVisible = false;
            employeeSelect.IsVisible = false;
            hyperlinkEmployeesSelect.IsVisible = false;
            documentKindSelect.IsVisible = false;
            hyperlinkKindSelect.IsVisible = false;
            beginPeriodSelect.IsVisible = false;
            endPeriodSelect.IsVisible = false;
            nextButton.IsVisible = false;
            fileListButton.IsVisible = true;
            backButton.IsVisible = true;
            exportButton.IsVisible = true;
            
            var zipModelFilesExportError = false;
            // Вызвать функцию поиска по параметрам и вернуть список найденных операций подписания.
            documents = Functions.Module.Remote.GetDocumentsFromSigningOperations(businessUnitSelect.Value, selectedDepartments, selectedEmployees, selectedDocumentKinds, beginPeriodSelect.Value, endPeriodSelect.Value, null);
            documentsCount = documents.Count();
            if (documentsCount > Constants.Module.ExportedDocumentsCountMaxLimit)
            {
              var addErrorMessage = Resources.ExportDialog_Error_DocumentCountLimitFormat(Constants.Module.ExportedDocumentsCountMaxLimit);
              h.AddError(addErrorMessage);
              zipModelFilesExportError = true;
            }
            
            exportEnabled = !zipModelFilesExportError && (documentsCount > 0);
            exportDialog.Text = (exportEnabled ? Resources.ExportDialog_SuccessInfo + Environment.NewLine : string.Empty) + Resources.ExportDialog_InstructionFormat(documentsCount);
            fileListButton.IsEnabled = documentsCount > 0;
            exportButton.IsEnabled = exportEnabled;
            exportDialog.Buttons.Default = exportButton;
          };
          
          // Назад.
          if (h.Button == backButton)
          {
            businessUnitSelect.IsVisible = true;
            departmentSelect.IsVisible = true;
            hyperlinkDepartmentSelect.IsVisible = true;
            employeeSelect.IsVisible = true;
            hyperlinkEmployeesSelect.IsVisible = true;
            documentKindSelect.IsVisible = true;
            hyperlinkKindSelect.IsVisible = true;
            beginPeriodSelect.IsVisible = true;
            endPeriodSelect.IsVisible = true;
            nextButton.IsVisible = true;
            fileListButton.IsVisible = false;
            backButton.IsVisible = false;
            exportButton.IsVisible = false;
            exportDialog.Buttons.Default = nextButton;
            exportDialog.Text = Resources.ExportParamsDialogInstruction;
          }
          
          // Показать документы.
          if (h.Button == fileListButton)
          {
            documents.ShowModal();
          }
          
          // Выгрузить.
          if (h.Button == exportButton)
          {
            fileListButton.IsVisible = false;
            backButton.IsVisible = false;
            exportButton.IsVisible = false;
            cancelButton.IsVisible = false;
            closeButton.IsVisible = true;
            
            // Сформировать результаты выгрузки и обработать ограничения.
            try
            {
              var zip = Functions.Module.Remote.FormExportPackagesFromClient(businessUnitSelect.Value, selectedDepartments, selectedEmployees, 
                                                                             selectedDocumentKinds, beginPeriodSelect.Value, endPeriodSelect.Value);
              
              if (zip != null)
                zip.Export();
            }
            catch (Exception ex)
            {
              var addErrorMessage = Resources.ExportDialog_Error_Client_NoReason;
              Logger.Error(addErrorMessage, ex);
              h.AddError(addErrorMessage);
              return;
            }
            
            // Обработка ошибок выгрузки.
            var docExportResult = Functions.Module.Remote.ProcessingExportErrors(Employees.Current, businessUnitSelect.Value, selectedDepartments, selectedEmployees, 
                                                                                 selectedDocumentKinds, beginPeriodSelect.Value, endPeriodSelect.Value, null);
            
            // Вывести данные о результатах выгрузки.
            exportDialog.Text = Resources.ExportDialog_MinistryOfLaborResultsInfoFormat(docExportResult.CountSuccessExportContainers, docExportResult.CountErrorExportContainers);
            closeButton.IsEnabled = true;
            exportDialog.Buttons.Default = closeButton;
          }
        });
      exportDialog.Show();
    }
    
    /// <summary>
    /// Показать диалог точечной выгрузки документов.
    /// </summary>
    [Public]
    public virtual void ShowPointExportDocumentsDialog(List<long> signingOperationsId, bool containsNotAvailableDocs, bool containsNotRightsDocs)
    {
      var exportDialog = Dialogs.CreateInputDialog(Resources.ExportDocuments);
      exportDialog.HelpCode = Constants.Module.HelpCodes.ExportPersonellDocumentsDialog;
      
      // Кнопки. 
      var fileListButton = exportDialog.Buttons.AddCustom(Resources.FileListButton);
      fileListButton.IsVisible = true;
      var exportButton = exportDialog.Buttons.AddCustom(Resources.ExportButton);
      exportButton.IsVisible = true;
      var closeButton = exportDialog.Buttons.AddCustom(Resources.CloseButton);
      closeButton.IsVisible = false;
      var cancelButton = exportDialog.Buttons.AddCustom(Resources.CancelButton);
      cancelButton.IsVisible = true;
      exportDialog.Buttons.Default = exportButton;
      
      var exportEnabled = false;
      // Получить документы, содержащиеся в операциях подписания.
      var zipModelFilesExportError = false;
      var documents = Functions.Module.Remote.GetDocumentsFromSigningOperations(null, null, null, null, null, null, signingOperationsId);
      var documentsCount = documents.Count();
      
      exportEnabled = !zipModelFilesExportError && (documentsCount > 0);
      
      exportDialog.Text = (exportEnabled ? Resources.ExportDialog_SuccessInfo + Environment.NewLine : string.Empty) + Resources.PointExportDialogFormat(documentsCount) 
        + (containsNotRightsDocs ? Environment.NewLine + Environment.NewLine + Resources.AccessRightsErrorWhenUploading : string.Empty) 
        + (containsNotAvailableDocs ? Environment.NewLine + Environment.NewLine + Resources.SomeDocumentsAreNotAvailableForUploading : string.Empty);
      fileListButton.IsEnabled = documentsCount > 0;
      exportButton.IsEnabled = exportEnabled;
      
      // Действия.
      exportDialog.SetOnButtonClick(
        (h) =>
        {
          h.CloseAfterExecute = h.Button == cancelButton || h.Button == closeButton;
          
          // Показать документы.
          if (h.Button == fileListButton)
          {
            documents.ShowModal();
          }
          
          // Выгрузить.
          if (h.Button == exportButton)
          {
            fileListButton.IsVisible = false;
            exportButton.IsVisible = false;
            cancelButton.IsVisible = false;
            closeButton.IsVisible = true;
            
            // Сформировать результаты выгрузки и обработать ограничения.
            try
            {
              var zip = Functions.Module.Remote.FormExportPackagesFromClient(signingOperationsId);
              
              if (zip != null)
                zip.Export();
            }
            catch (Exception ex)
            {
              var addErrorMessage = Resources.ExportDialog_Error_Client_NoReason;
              Logger.Error(addErrorMessage, ex);
              return;
            }
            
            // Обработка ошибок выгрузки.
            var docExportResult = Functions.Module.Remote.ProcessingExportErrors(Sungero.Company.Employees.Current, null, null, null, null, null, null, signingOperationsId);
            // Вывести данные о результатах выгрузки.
            exportDialog.Text = Resources.ExportDialog_MinistryOfLaborResultsInfoFormat(docExportResult.CountSuccessExportContainers, docExportResult.CountErrorExportContainers);
          }
        });
      exportDialog.Show();
    }
  }
}