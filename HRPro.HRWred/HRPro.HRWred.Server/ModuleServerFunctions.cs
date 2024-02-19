using System;
using System.Xml;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using IOCompress = System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Content;
using Sungero.Domain;
using Sungero.Domain.LinqExpressions;
using Sungero.Domain.Shared;
using Sungero.Docflow;
using Sungero.Docflow.DocumentKind;
using Sungero.Company;

namespace HRPro.HRWred.Server
{
  public class ModuleFunctions
  {

    #region Выгрузка документов по формату Минтруда.
    
    #region Формирование описателя на xml.
    
    /// <summary>
    /// Сведения о работнике, подписавшем документ.
    /// </summary>
    public Wred.EmployeeInfoType FormEmployeeInfoType(ISigningOperation signingOperation)
    {
      var employeeInfoType = new Wred.EmployeeInfoType();
      employeeInfoType.LastnameInfo = signingOperation.SignatoryLastName;
      employeeInfoType.FirstnameInfo = signingOperation.SignatoryName;
      employeeInfoType.PatronymicInfo = string.IsNullOrEmpty(signingOperation.SignatoryMiddleName) ? null : signingOperation.SignatoryMiddleName;
      employeeInfoType.JobTitle = signingOperation.SignatoryJobTitle;
      employeeInfoType.Signature = FormSignatureWithPOA(signingOperation, signingOperation.Document, signingOperation.SignatureID, signingOperation.SignatureFileName);
      return employeeInfoType;
    }
    
    /// <summary>
    /// Сведения о файле-подписи.
    /// </summary>
    public Wred.X509SignatureType FormX509(Sungero.Domain.Shared.ISignature signature, string filename)
    {
      if (signature.SignCertificate == null)
        return null;
      
      var x509 = new Wred.X509SignatureType();
      x509.File = filename;
      
      var signData = signature.GetDataSignature();
      x509.Size = signData.LongLength;
      return x509;
    }
    
    /// <summary>
    /// Доверенность.
    /// </summary>
    public Wred.PowerOfAttorneyTypeCt FormPowerOfAttorney(ISigningOperation signingOperation)
    {
      var powerOfAttorney = new Wred.PowerOfAttorneyTypeCt();
      powerOfAttorney.File = signingOperation.PowerOfAttorney.FirstOrDefault().DocumentFileName;
      powerOfAttorney.Size = signingOperation.PowerOfAttorney.FirstOrDefault().Document.Versions.FirstOrDefault().Body.Size;
      // TODO Доработать после добавления основания доверенностей на других доверенностях.
      //powerOfAttorney.PowerOfAttorney = ;
      return powerOfAttorney;
    }
    
    /// <summary>
    /// Электронная подпись, уполномоченная по доверенности.
    /// </summary>
    public Wred.SignatureWithPOA FormSignatureWithPOA(ISigningOperation signingOperation, IOfficialDocument document, long? signatureID, string filename)
    {
      var signatureWithPOA = new Wred.SignatureWithPOA();
      
      if (signatureID == null)
        return signatureWithPOA;
      
      var signature = Signatures.Get(document, q => q.Where(s => s.Id == signatureID.Value)).FirstOrDefault();
      signatureWithPOA.Date = signature.SigningDate;
      if (!string.IsNullOrEmpty(signingOperation.SignatoryINILA))
        signatureWithPOA.Snils = signingOperation.SignatoryINILA;
      signatureWithPOA.X509 = FormX509(signature, filename);
      if (signatureWithPOA.X509 == null)
        signatureWithPOA.Simple = signature.SignCertificate == null;
      if (signingOperation.PowerOfAttorney.Any())
        signatureWithPOA.PowerOfAttorney = FormPowerOfAttorney(signingOperation);
      return signatureWithPOA;
    }
    
    /// <summary>
    /// Приложение к электронному документу.
    /// </summary>
    public Wred.AttachmentType FormAttachmentType(ISigningOperation signingOperation, ISigningOperationAttachments attachment)
    {
      var attachmentNode = new Wred.AttachmentType();
      
      if (attachment.Document.AssociatedApplication != null)
        attachmentNode.Extension = attachment.Document.AssociatedApplication.Extension;
      
      attachmentNode.File = attachment.DocumentFileName;
      attachmentNode.Size = attachment.Document.Versions.Where(v => v.Id == attachment.AttachmentDocumentVersion).FirstOrDefault().Body.Size;
      
      if (attachment.DocumentAnnotation == null)
        attachmentNode.Annotation = string.Empty;
      else
      {
        attachmentNode.Annotation = attachment.DocumentAnnotation.Length > 1024 ?
          attachment.DocumentAnnotation.Substring(0, 1024) :
          attachment.DocumentAnnotation;
      }
      
      // Подписи работодателя.
      attachmentNode.EmployerSigns = new List<Wred.SignatureWithPOA>();
      if (signingOperation.EmployerSigningOperation != null && signingOperation.EmployerSigningOperation.Attachments.Any())
      {
        var employerSignatureID = signingOperation.EmployerSigningOperation.Attachments.Where(a => a.AttachmentDocumentVersion == attachment.AttachmentDocumentVersion).FirstOrDefault().SignatureId;
        var employerSignatureFilename = signingOperation.EmployerSigningOperation.Attachments.Where(a => a.AttachmentDocumentVersion == attachment.AttachmentDocumentVersion).FirstOrDefault().SignatureFileName;
        attachmentNode.EmployerSigns.Add(FormSignatureWithPOA(signingOperation.EmployerSigningOperation, attachment.Document, employerSignatureID, employerSignatureFilename));
      }
      // Подписи сотрудника.
      attachmentNode.EmployeeSigns = new List<Wred.SignatureWithPOA>();
      attachmentNode.EmployeeSigns.Add(FormSignatureWithPOA(signingOperation, attachment.Document, attachment.SignatureId, attachment.SignatureFileName));
      
      return attachmentNode;
    }
    
    /// <summary>
    /// Сведения о документе.
    /// </summary>
    public Wred.DocinfoType FormDocinfoType(ISigningOperation signingOperation)
    {
      var docInfo = new Wred.DocinfoType();
      
      docInfo.DocName = signingOperation.DocumentName;
      docInfo.DocNumber = signingOperation.DocumentRegistrationNumber;
      
      if (signingOperation.EmployerSigningOperation != null && signingOperation.EmployerSigningOperation.SignatureID != null && signingOperation.EmployerSigningOperation.SignatureID.HasValue)
        docInfo.Date = Signatures.Get(signingOperation.EmployerSigningOperation.Document, q => q.Where(s => s.Id == signingOperation.EmployerSigningOperation.SignatureID.Value)).FirstOrDefault().SigningDate;
      else if (signingOperation.SignatureID != null && signingOperation.SignatureID.HasValue)
        docInfo.Date = Signatures.Get(signingOperation.Document, q => q.Where(s => s.Id == signingOperation.SignatureID.Value)).FirstOrDefault().SigningDate;
      
      docInfo.DocType = signingOperation.DocumentWredCode;
      docInfo.Annotation = signingOperation.DocumentAnnotation;
      
      docInfo.File = signingOperation.DocumentFileName;
      docInfo.Size = signingOperation.Document.Versions.Where(v => v.Id == signingOperation.DocumentVersion).FirstOrDefault().Body.Size;
      
      docInfo.Signatures = new List<Wred.SignatureWithPOA>();
      if (signingOperation.EmployerSigningOperation != null)
        docInfo.Signatures.Add(FormSignatureWithPOA(signingOperation.EmployerSigningOperation, signingOperation.Document,
                                                    signingOperation.EmployerSigningOperation.SignatureID, signingOperation.EmployerSigningOperation.SignatureFileName));
      
      docInfo.Attachments = new List<Wred.AttachmentType>();
      var attachments = signingOperation.Attachments.AsEnumerable();
      foreach (var attachment in attachments)
      {
        var attachmentNode = FormAttachmentType(signingOperation, attachment);
        docInfo.Attachments.Add(attachmentNode);
      }
      
      docInfo.EmployeeInfo = new List<Wred.EmployeeInfoType>();
      docInfo.EmployeeInfo.Add(FormEmployeeInfoType(signingOperation));
      
      return docInfo;
    }
    
    /// <summary>
    /// Сведения о работодателе.
    /// </summary>
    public Wred.EmployerinfoType FormEmployerinfoType(ISigningOperation signingOperation)
    {
      var employerinfoType = new Wred.EmployerinfoType();
      employerinfoType.EmployerName = signingOperation.BusinessUnitName;
      employerinfoType.InnEmployer = signingOperation.BusinessUnitTIN;
      employerinfoType.Ogrn = signingOperation.BusinessUnitPSRN;
      employerinfoType.Kpp = signingOperation.BusinessUnitTRRC;
      if (!IsDocKindSignedOnlyByEmployee(signingOperation.Document) && signingOperation.EmployerSigningOperation != null &&
          !string.IsNullOrEmpty(signingOperation.EmployerSigningOperation.SignatoryJobTitle))
      {
        employerinfoType.JobTitle = signingOperation.EmployerSigningOperation.SignatoryJobTitle;
      }
      employerinfoType.DocInfo = FormDocinfoType(signingOperation);
      return employerinfoType;
    }
    
    /// <summary>
    /// Данные электронного документа, связанного с работой, для выгрузки XML.
    /// </summary>
    public Wred.WredData FormWredData(ISigningOperation signingOperation)
    {
      // Сгенерировать GUID контейнера, если он еще не был сгенерирован.
      if (string.IsNullOrEmpty(signingOperation.ContainerGUID))
      {
        signingOperation.ContainerGUID = Guid.NewGuid().ToString();
        signingOperation.Save();
      }
      
      var WredData = new Wred.WredData();
      WredData.Id = signingOperation.ContainerGUID;
      WredData.Created = signingOperation.Document.Versions.Where(v => v.Id == signingOperation.DocumentVersion).FirstOrDefault().Created;
      WredData.Version = GetWredXSDVersionByDate(WredData.Created);
      WredData.Content = FormEmployerinfoType(signingOperation);
      
      if (!IsDocKindSignedOnlyByEmployee(signingOperation.Document) && signingOperation.EmployerSigningOperation != null &&
          signingOperation.EmployerSigningOperation.SignatureID != null && signingOperation.EmployerSigningOperation.SignatureID.HasValue)
      {
        var signature = Signatures.Get(signingOperation.EmployerSigningOperation.Document, q => q.Where(s => s.Id == signingOperation.EmployerSigningOperation.SignatureID.Value)).FirstOrDefault();
        if (signature != null)
          WredData.Signature = FormX509(signature, signingOperation.EmployerSigningOperation.SignatureFileName);
      }
      return WredData;
    }
    
    /// <summary>
    /// Сформировать XML файл
    /// </summary>
    [Remote(IsPure = true)]
    public string FormXMLFile(ISigningOperation signingOperation)
    {
      if (string.IsNullOrEmpty(signingOperation.XmlDescription))
      {
        var wredData = FormWredData(signingOperation);
        var serializer = new Wred.Serializer();
        var xml = serializer.Serialize(wredData);
        var wredVersion = GetWredXSDVersionByDate(signingOperation.Document.Versions.Where(v => v.Id == signingOperation.DocumentVersion).FirstOrDefault().Created);
        var validate = serializer.Validate(xml, wredVersion);
        signingOperation.XmlDescription = xml;
        signingOperation.XmlErrors = validate;
        signingOperation.Save();
        
        if (validate != string.Empty)
        {
          Logger.DebugFormat("HRWred.FormXMLFile(). During validation, a discrepancy between the data and the schema was detected. Validation response: {0}", validate);
          return validate;
        }
      }
      return signingOperation.XmlDescription;
    }
    
    /// <summary>
    /// Проверить, сформировалась ли xml без ошибок.
    /// </summary>
    /// <param name="xml">Xml.</param>
    /// <returns>False, если xml состоит из узла error. True в любом другом случае.</returns>
    [Remote]
    public bool CheckFormXml(string xml)
    {
      var buffer = Encoding.Default.GetBytes(xml);
      XmlDocument doc = new XmlDocument();
      MemoryStream ms = new MemoryStream(buffer);
      doc.Load(ms);
      var root = doc.DocumentElement;
      if (root.Name == Constants.Module.XmlErrorNodeName)
        return false;
      return true;
    }
    #endregion
    
    #region Перекрываемыe функции
    /// <summary>
    /// Проверить, является ли документ подписываемым только сотрудником.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <returns>True, если переданный вид относится к виду, который подписывается только сотрудником, иначе false.</returns>
    [Public]
    public virtual bool IsDocKindSignedOnlyByEmployee(IOfficialDocument document)
    {
      return false;
    }
    
    /// <summary>
    /// Получить статус операции.
    /// </summary>
    /// <param name="currentSigningOperation">Текущая операция для которой необходимо получить статус.</param>
    /// <param name="referenceSigningOperation">Операция связанная с текущей операцией.</param>
    /// <returns>Статус операции.</returns>
    /// <remarks>Используется для получения статусов операции сотрудников при создании записи, т.к. для операции организации статус всегда Registrated</remarks>
    [Public]
    public virtual Nullable<Enumeration> GetOperationState(ISigningOperation currentSigningOperation, ISigningOperation referenceSigningOperation)
    {
      return null;
    }
    #endregion
    
    /// <summary>
    /// Найти ID операций подписания по заданным параметрам.
    /// </summary>
    /// <param name="employees">Список сотрудников.</param>
    /// <param name="documentKinds">Виды документов.</param>
    /// <param name="beginPeriod">Дата создания с.</param>
    /// <param name="endPeriod">Дата создания по.</param>
    /// <param name="withErrors">True, если вернуть операции подписания в статусе Ошибка при формировании контейнера. False, если вернуть выгруженные или готовые к выгрузке операции подписания</param>
    /// <returns>ID операций подписания, удовлетворяющих условиям фильтров.</returns>
    public List<long> SearchSigningOperationsIDsByRequisites(List<Sungero.Company.IEmployee> employees,
                                                                            List<HRProWredSolution.IDocumentKind> documentKinds, DateTime? beginPeriod, DateTime? endPeriod, bool withErrors)
    {
      // TODO Выгружаем только последние версии, или все версии, подходящие под условия фильтра? Пока выгружаю все.
      var signingOperations = Enumerable.Empty<ISigningOperation>().AsQueryable();
      
      if (withErrors)
        signingOperations = SigningOperations.GetAll(s => employees.Contains(s.Signatory) && s.IsSignatoryAnOfficial == false &&
                                                     s.OperationState == HRWred.SigningOperation.OperationState.Error);
      else
        signingOperations = SigningOperations.GetAll(s => employees.Contains(s.Signatory) && s.IsSignatoryAnOfficial == false &&
                                                    (s.OperationState == HRWred.SigningOperation.OperationState.ReadyForExport ||
                                                     s.OperationState == HRWred.SigningOperation.OperationState.Formed));
      
      // Фильтрация по видам, ЖЦ - выбрать только операции с действующими документами:
      if (!documentKinds.Any())
      {
        var documentKindsIDs = GetHRDocumentKindsIDs();
        documentKinds = HRProWredSolution.DocumentKinds.GetAll(d => documentKindsIDs.Contains(d.Id)).ToList();
      }
      signingOperations = signingOperations.Where(s => documentKinds.Contains(HRProWredSolution.DocumentKinds.As(s.Document.DocumentKind)) &&
                                  s.Document.LifeCycleState == Sungero.Docflow.OfficialDocument.LifeCycleState.Active);
      
      // По периоду: в период входит дата создания основного документа.
      if (beginPeriod != null)
        signingOperations = signingOperations.Where(s => s.Document.Created >= beginPeriod.Value.BeginningOfDay());
      if (endPeriod != null)
        signingOperations = signingOperations.Where(s => s.Document.Created <= endPeriod.Value.EndOfDay());
      
      return signingOperations.Select(s => s.Id).ToList();
    }
    
    
    /// <summary>
    /// Найти ID операций подписания по заданным параметрам.
    /// </summary>
    /// <param name="employees">Список сотрудников.</param>
    /// <param name="documentKinds">Виды документов.</param>
    /// <param name="beginPeriod">Дата создания с.</param>
    /// <param name="endPeriod">Дата создания по.</param>
    /// <param name="signingOperationsId">Список ИД операций подписания для выгрузки.</param>
    /// <returns>ID операций подписания в статусе "Контейнер готов к выгрузке", "Контейнер выгружен" или "Ошибка при формировании контейнера", удовлетворяющих условиям фильтров.</returns>
    [Public]
    public virtual IQueryable<ISigningOperation> SearchSigningOperationsByRequisitesAsQueryable(IBusinessUnit selectedBusinessUnit, List<IDepartment> selectesDepartments, List<IEmployee> selectedEmployees,
                                                                                                List<HRProWredSolution.IDocumentKind> documentKinds, DateTime? beginPeriod, DateTime? endPeriod, 
                                                                                                List<long> signingOperationsId)
    {
      IQueryable<ISigningOperation> signingOperations = null;
      if (signingOperationsId == null)
      {
        var employees = GetFilteredEmployeesAsQueryable(selectedBusinessUnit, selectesDepartments, selectedEmployees);
      
        // TODO Выгружаем только последние версии, или все версии, подходящие под условия фильтра? Пока выгружаю все.
        signingOperations = SigningOperations.GetAll(s => employees.Contains(s.Signatory) && s.IsSignatoryAnOfficial == false &&
                                                      (s.OperationState == HRWred.SigningOperation.OperationState.ReadyForExport ||
                                                       s.OperationState == HRWred.SigningOperation.OperationState.Formed ||
                                                       s.OperationState == HRWred.SigningOperation.OperationState.Error));
        
        // Фильтрация по видам:
        if (!documentKinds.Any())
        {
          var documentKindsIDs = GetHRDocumentKindsIDs();
          documentKinds = HRProWredSolution.DocumentKinds.GetAll(d => documentKindsIDs.Contains(d.Id)).ToList();
        }
        signingOperations = signingOperations.Where(s => documentKinds.Contains(HRProWredSolution.DocumentKinds.As(s.Document.DocumentKind)));
        
        // По периоду: в период входит дата создания основного документа.
        if (beginPeriod != null)
          signingOperations = signingOperations.Where(s => s.Document.Created >= beginPeriod.Value.BeginningOfDay());
        if (endPeriod != null)
          signingOperations = signingOperations.Where(s => s.Document.Created <= endPeriod.Value.EndOfDay());
      }
      else 
        signingOperations = SigningOperations.GetAll(s => signingOperationsId.Contains(s.Id));

      // Исключить документы на которые нет прав.
      var docs = signingOperations.Select(s => s.Document).Distinct();
      var excludeDocs = new List<long>();

      foreach (var doc in docs)
      {
        if (!doc.AccessRights.CanReadBody())
          excludeDocs.Add(doc.Id);
      }

      signingOperations = signingOperations.Where(s => !excludeDocs.Contains(s.Document.Id));

      return signingOperations;
    }
    
    /// <summary>
    /// Получить документы, содержащиеся в операциях подписания.
    /// </summary>
    /// <param name="selectedBusinessUnit">НОР, указанная в фильтре.</param>
    /// <param name="selectedDepartments">Список подразделений, указанных в фильтре.</param>
    /// <param name="selectedEmployees">Список сотрудников, указанных в фильтре.</param>
    /// <param name="documentKinds">Виды документов.</param>
    /// <param name="beginPeriod">Дата создания документа с.</param>
    /// <param name="endPeriod">Дата создания документа по.</param>
    /// <param name="signingOperationsId">Список ИД операций подписания для выгрузки.</param>
    /// <returns>Документы.</returns>
    [Remote]
    public IQueryable<IOfficialDocument> GetDocumentsFromSigningOperations(IBusinessUnit selectedBusinessUnit, List<IDepartment> selectedDepartments, List<IEmployee> selectedEmployees,
                                                                            List<HRProWredSolution.IDocumentKind> documentKinds, DateTime? beginPeriod, DateTime? endPeriod, List<long> signingOperationsId)
    {
      var signingOperations = SearchSigningOperationsByRequisitesAsQueryable(selectedBusinessUnit, selectedDepartments, selectedEmployees,
                                                                             documentKinds, beginPeriod, endPeriod, signingOperationsId);
      var docIds = signingOperations.Select(s => s.Document.Id);
      return Sungero.Docflow.OfficialDocuments.GetAll(d => docIds.Contains(d.Id));
    }
    
    /// <summary>
    /// Получить сотрудников по выбранным НОР, подразделению, сотруднику.
    /// </summary>
    /// <param name="businessUnit">НОР.</param>
    /// <param name="departments">Подразделения.</param>
    /// <param name="employees">Сотрудники.</param>
    /// <returns>Query для сотрудников.</returns>
    [Remote]
    public IQueryable<IEmployee> GetFilteredEmployeesAsQueryable(IBusinessUnit businessUnit, List<IDepartment> departments, List<IEmployee> employees)
    {
      if (employees != null && employees.Any())
      {
        return Sungero.Company.Employees.GetAll(e => employees.Contains(e));
      }
      if (departments != null && departments.Any())
      {
        return Employees.GetAll().Where(e => departments.Contains(e.Department));
      }
      if (businessUnit != null)
      {
        return Employees.GetAll().Where(e => e.Department.BusinessUnit == businessUnit);
      }
      return Employees.GetAll().Where( e => false);
    }    
    
    /// <summary>
    /// Создать ссылку на документ в справочнике ExternalEntityLink.
    /// </summary>
    /// <param name="document">Документ.</param>
    public string CreateExternalEntityLinks(IOfficialDocument document)
    {
      Sungero.Commons.IExternalEntityLink link = null;
      AccessRights.AllowRead(
        () =>
        {
          link = Sungero.Commons.ExternalEntityLinks.Create();
          link.EntityId = document.Id;
          link.EntityType = document.GetType().ToString();
          link.ExtEntityId = System.Guid.NewGuid().ToString();
          link.Save();
        });
      return link.ExtEntityId;
    }
    
    /// <summary>
    /// Получить приложения к основному документу
    /// </summary>
    [Public, Remote(IsPure = true)]
    public virtual List<Sungero.Docflow.IOfficialDocument> GetDocumentAttachments(Sungero.Docflow.IOfficialDocument mainDocument)
    {
      List<IOfficialDocument> attachments = new List<IOfficialDocument>();
      if (mainDocument.HasRelations)
        attachments = mainDocument.Relations.GetRelated(Sungero.Docflow.PublicConstants.Module.AddendumRelationName).Cast<IOfficialDocument>().ToList();
      return attachments;
    }
    
    /// <summary>
    /// Получить название для выгрузки файла подписи.
    /// </summary>
    /// <param name="signature">Подпись.</param>
    /// <returns></returns>
    public string GetFilenameForSignature(Sungero.Domain.Shared.ISignature signature)
    {
      var partsOfName = signature.SignatoryFullName.Split(' ');
      var shortName = partsOfName[0] + partsOfName[1][0].ToString() + (partsOfName.Length > 2 ? partsOfName[2][0].ToString() : String.Empty);
      var filename = shortName + "_" + signature.Id +  Constants.Module.SignatureFileExtension;
      filename = Functions.Module.ReplaceUnvalidatedSymbols(filename);
      return filename;
    }

    /// <summary>
    /// Обработка ошибок выгрузки.
    /// </summary>
    /// <param name="employee">Сотрудник, которому необходимо отправить задание на обработку ошибок.</param>
    /// <param name="selectedBusinessUnit">НОР, указанная в фильтре.</param>
    /// <param name="selectedDepartments">Список подразделений, указанных в фильтре.</param>
    /// <param name="selectedEmployees">Список сотрудников, указанных в фильтре.</param>
    /// <param name="documentKinds">Виды документов, по которым производилась выгрузка.</param>
    /// <param name="beginPeriod">Дата создания документов с.</param>
    /// <param name="endPeriod">Дата создания документов по.</param>
    /// <param name="signingOperationsId">Список ИД операций подписания для выгрузки.</param>
    /// <returns>Структура с количеством успешно сформированных контейнеров, и с количеством контейнеров, для которых произошла ошибка при формировании xml.</returns>
    [Remote]
    public virtual HRWred.Structures.Module.IExportResult ProcessingExportErrors(IEmployee employee, IBusinessUnit selectedBusinessUnit, List<IDepartment> selectedDepartments, List<IEmployee> selectedEmployees,
                                                                            List<HRProWredSolution.IDocumentKind> documentKinds, DateTime? beginPeriod, DateTime? endPeriod, List<long> signingOperationsId)
    {
      var exportResult = Structures.Module.ExportResult.Create();
      var signingOperations = SearchSigningOperationsByRequisitesAsQueryable(selectedBusinessUnit, selectedDepartments, selectedEmployees, documentKinds, beginPeriod, endPeriod, signingOperationsId);
      
      var signingOperationsWithErrorXml = signingOperations.Where(s => s.OperationState == HRWred.SigningOperation.OperationState.Error);
      if (signingOperationsWithErrorXml.Any())
      {
        // TODO Придумать заголовок задачи.
        var task = Sungero.Workflow.SimpleTasks.Create("Исправьте ошибки, возникшие при выгрузке документов.", employee);
        task.NeedsReview = false;
        foreach (var signingOperationWithErrorXml in signingOperationsWithErrorXml)
          task.Attachments.Add(signingOperationWithErrorXml);
        task.Save();
        task.Start();
      }
      var countErrorContainers = signingOperationsWithErrorXml.Count();
      exportResult.CountSuccessExportContainers = signingOperations.Count() - countErrorContainers;
      exportResult.CountErrorExportContainers = countErrorContainers;
      return exportResult;
    }

    /// <summary>
    /// Сформировать архив для выгрузки. Функция для обхода проверки прав доступа.
    /// </summary>
    /// <param name="selectedBusinessUnit">НОР, указанная в фильтре.</param>
    /// <param name="selectedDepartments">Список подразделений, указанных в фильтре.</param>
    /// <param name="selectedEmployees">Список сотрудников, указанных в фильтре.</param>
    /// <param name="documentKinds">Список документов, по которым выгружаются операции подписания.</param>
    /// <param name="beginPeriod">Дата создания документов с.</param>
    /// <param name="endPeriod">Дата создания документов по.</param>
    /// <returns>Zip-архив.</returns>
    [Remote(IsPure = true)]
    public virtual IZip FormExportPackagesFromClient(IBusinessUnit selectedBusinessUnit, List<IDepartment> selectedDepartments, List<IEmployee> selectedEmployees, 
                                                     List<HRProWredSolution.IDocumentKind> documentKinds, DateTime? beginPeriod, DateTime? endPeriod)
    {
      return this.FormExportPackages(selectedBusinessUnit, selectedDepartments, selectedEmployees, documentKinds, beginPeriod, endPeriod, null);
    }
    
    /// <summary>
    /// Сформировать архив для выгрузки. Функция для обхода проверки прав доступа.
    /// </summary>
    /// <param name="signingOperationsId">Список ИД операций подписания для выгрузки.</param>
    /// <returns>Zip-архив.</returns>
    [Remote(IsPure = true)]
    public virtual IZip FormExportPackagesFromClient(List<long> signingOperationsId)
    {
      return this.FormExportPackages(null, null, null, null, null, null, signingOperationsId);
    }
    
    /// <summary>
    /// Сформировать архив для выгрузки.
    /// </summary>
    /// <param name="selectedBusinessUnit">НОР, указанная в фильтре.</param>
    /// <param name="selectedDepartments">Список подразделений, указанных в фильтре.</param>
    /// <param name="selectedEmployees">Список сотрудников, указанных в фильтре.</param>
    /// <param name="documentKinds">Список документов, по которым выгружаются операции подписания.</param>
    /// <param name="beginPeriod">Дата создания документов с.</param>
    /// <param name="endPeriod">Дата создания документов по.</param>
    /// <param name="signingOperationsId">Список ИД операций подписания для выгрузки.</param>
    /// <returns>Zip-архив.</returns>
    public virtual IZip FormExportPackages(IBusinessUnit selectedBusinessUnit, List<IDepartment> selectedDepartments, List<IEmployee> selectedEmployees,
                                           List<HRProWredSolution.IDocumentKind> documentKinds, DateTime? beginPeriod, DateTime? endPeriod, List<long> signingOperationsId)
    {
      var zip = Zip.Create();
      var internalZip = (Sungero.Domain.IInternalZip)zip;
      var filesXml = new List<HRPro.HRWred.Structures.Module.IFileXml>();
      var errors = new List<string>();
      var numsErrorXmlDescriptions = 0;
      
      var signingOperations = SearchSigningOperationsByRequisitesAsQueryable(selectedBusinessUnit, selectedDepartments, selectedEmployees, documentKinds, beginPeriod, endPeriod, signingOperationsId)
                          .Where(s => s.OperationState == HRWred.SigningOperation.OperationState.Formed || s.OperationState == HRWred.SigningOperation.OperationState.ReadyForExport);
      var signingOperationsCount = signingOperations.Count();
      var employees = signingOperations.Select(s => s.Signatory).Distinct();
      
      // Сформировать папку для каждого сотрудника.
      foreach (var employee in employees)
      {
        var employeeSigningOperations = signingOperations.Where(s => s.Signatory.Equals(employee));
        var employeeFolders = employeeSigningOperations.Select(so => so.SignatoryContainerName).Distinct().ToList();
        foreach (var folder in employeeFolders)
        {
          var currentEmployeeSigningOperations = employeeSigningOperations.Where(so => so.SignatoryContainerName.Equals(folder));
          var path = new string[1] {folder};
          
          foreach (var employeeSigningOperation in currentEmployeeSigningOperations)
          {
            // Имя zip-контейнера операции подписания.
            var containerName = TransformFilenameToWredFormat(employeeSigningOperation.DocumentName, employeeSigningOperation.SignatoryContainerName);
            using (var targetStream = new MemoryStream())
            {
              var xml = string.IsNullOrEmpty(employeeSigningOperation.XmlDescription) ?
                        FormXMLFile(employeeSigningOperation) :
                        employeeSigningOperation.XmlDescription;
              if (CheckFormXml(xml))
              {
                if (employeeSigningOperation.OperationState != HRWred.SigningOperation.OperationState.Formed)
                {
                  employeeSigningOperation.OperationState = HRWred.SigningOperation.OperationState.Formed;
                  employeeSigningOperation.Save();
                }
              }
              else
              {
                employeeSigningOperation.OperationState = HRWred.SigningOperation.OperationState.Error;
                employeeSigningOperation.Save();
                numsErrorXmlDescriptions++;
                continue;
              }
              
              // Xml валидация.
              var xmlToByteArray = Encoding.Default.GetBytes(xml);
              var sourceXmlStream = new MemoryStream(xmlToByteArray);
              this.AppendToZip(targetStream, sourceXmlStream, Constants.Module.ExportXmlFilename + ".xml");
              
              var validationXml = GetValidationFiles(xmlToByteArray, containerName);
              filesXml = validationXml.FilesXml;
              errors.Add(validationXml.Errors);
              
              // Выбираем нужные версии для выгружаемого комплекта документов.
              var documentsVersions = employeeSigningOperation.Attachments.Select(a => a.Document.Versions.Where(v => v.Id == a.AttachmentDocumentVersion).FirstOrDefault())
                                      .Concat(employeeSigningOperation.Document.Versions.Where(v => v.Id == employeeSigningOperation.DocumentVersion));
              
              foreach (var documentVersion in documentsVersions)
              {
                var documentFileName = employeeSigningOperation.DocumentVersion == documentVersion.Id ?
                                       employeeSigningOperation.DocumentFileName :
                                       employeeSigningOperation.Attachments.Where(a => a.AttachmentDocumentVersion == documentVersion.Id).Select(a => a.DocumentFileName).FirstOrDefault();
                if (documentVersion.Body != null)
                {
                  using (var sourceStream = new MemoryStream())
                  {
                    documentVersion.Body.Read().CopyTo(sourceStream);
                    sourceStream.Flush();
                    sourceStream.Position = 0;
                    this.AppendToZip(targetStream, sourceStream, documentFileName);
                  }
                  
                  var errorXmlFile = CheckXMLInfo(filesXml, documentVersion.Body.Size, documentFileName, containerName);
                  if (!string.IsNullOrEmpty(errorXmlFile))
                    errors.Add(errorXmlFile);
                }
                Logger.DebugFormat("Document with Id '{0}', version id '{1}' has been added to zip model", documentVersion.ElectronicDocument.Id, documentVersion.Id);
              }
              
              // Выбираем подписи сотрудника и руководителя (при наличии) со всех документов комплекта в этой операции подписания.
              var signsAndFileNamesSetDocuments = new Dictionary<ISignature, string>();
              if (employeeSigningOperation.SignatureID != null && employeeSigningOperation.SignatureID.HasValue)
              {
                var signature = Signatures.Get(employeeSigningOperation.Document, q => q.Where(s => s.Id == employeeSigningOperation.SignatureID.Value)).FirstOrDefault();
                if (signature != null && signature.SignCertificate != null)
                {
                  signsAndFileNamesSetDocuments.Add(signature, employeeSigningOperation.SignatureFileName);
                }
              }
              foreach (var attachment in employeeSigningOperation.Attachments)
              {
                if (attachment.SignatureId != null && attachment.SignatureId.HasValue)
                {
                  var attachmentSignature = Signatures.Get(attachment.Document, q => q.Where(s => s.Id == attachment.SignatureId.Value)).FirstOrDefault();
                  if (!signsAndFileNamesSetDocuments.ContainsKey(attachmentSignature) && attachmentSignature.SignCertificate != null)
                    signsAndFileNamesSetDocuments.Add(attachmentSignature, attachment.SignatureFileName);
                }
              }
              var employerSigningOperation = employeeSigningOperation.EmployerSigningOperation;
              if (employerSigningOperation != null)
              {
                if (employerSigningOperation.SignatureID != null && employerSigningOperation.SignatureID.HasValue)
                {
                  var signatureForKey = Signatures.Get(employerSigningOperation.Document, q => q.Where(s => s.Id == employerSigningOperation.SignatureID.Value)).FirstOrDefault();
                  if (!signsAndFileNamesSetDocuments.ContainsKey(signatureForKey) && signatureForKey.SignCertificate != null)
                    signsAndFileNamesSetDocuments.Add(signatureForKey, employerSigningOperation.SignatureFileName);
                }
                // Выбираем для руководителя только те версии документов приложений, которые есть в операции подписания сотрудника.
                var attachments = employerSigningOperation.Attachments.Where(a => employeeSigningOperation.Attachments.Select(e => e.AttachmentDocumentVersion).Contains(a.AttachmentDocumentVersion));
                foreach (var attachment in attachments)
                {
                  if (attachment.SignatureId != null && attachment.SignatureId.HasValue)
                  {
                    var attachmentSignature = Signatures.Get(attachment.Document, q => q.Where(s => s.Id == attachment.SignatureId.Value)).FirstOrDefault();
                    if (!signsAndFileNamesSetDocuments.ContainsKey(attachmentSignature) && attachmentSignature.SignCertificate != null)
                      signsAndFileNamesSetDocuments.Add(attachmentSignature, attachment.SignatureFileName);
                  }
                }
              }
              
              // Добавление подписей.
              foreach (var signAndFileName in signsAndFileNamesSetDocuments)
              {
                var signature = signAndFileName.Key;
                var signatureFileName = signAndFileName.Value;
                var errorsSignature = CheckValiditySignature(signature);
                if (!string.IsNullOrEmpty(errorsSignature))
                  errors.Add(errorsSignature);
                
                var errorXmlSign = CheckXMLInfo(filesXml, signature.GetDataSignature().LongLength, signatureFileName, containerName);
                if (!string.IsNullOrEmpty(errorXmlSign))
                  errors.Add(errorXmlSign);
                
                var sourceSignatureStream = new MemoryStream(signature.GetDataSignature());
                this.AppendToZip(targetStream, sourceSignatureStream, signatureFileName);
                Logger.DebugFormat("Signature with Id '{0}' has been added to zip model", signature.Id);
              }
              
              // Добавление доверенности и подписи к доверенности.
              if (employerSigningOperation != null && employerSigningOperation.PowerOfAttorney.Any())
              {
                var powerOfAttorneyDocument = employerSigningOperation.PowerOfAttorney.FirstOrDefault().Document;
                if (powerOfAttorneyDocument.Versions.FirstOrDefault().Body != null)
                {
                  using (var sourceStream = new MemoryStream())
                  {
                    powerOfAttorneyDocument.Versions.FirstOrDefault().Body.Read().CopyTo(sourceStream);
                    sourceStream.Flush();
                    sourceStream.Position = 0;
                    this.AppendToZip(targetStream, sourceStream, employerSigningOperation.PowerOfAttorney.FirstOrDefault().DocumentFileName);
                  }
                  // Добавление подписи к доверенности.
                  if (employerSigningOperation.PowerOfAttorney.FirstOrDefault().SignatureID != null && employerSigningOperation.PowerOfAttorney.FirstOrDefault().SignatureID.HasValue)
                  {
                    var attorneySignature = Signatures.Get(employerSigningOperation.PowerOfAttorney.FirstOrDefault().Document, q => q.Where(s => s.Id == employerSigningOperation.PowerOfAttorney.FirstOrDefault().SignatureID.Value)).FirstOrDefault();
                    var sourceSignatureStream = new MemoryStream(attorneySignature.GetDataSignature());
                    this.AppendToZip(targetStream, sourceSignatureStream, employerSigningOperation.PowerOfAttorney.FirstOrDefault().SignatureFileName);
                  }
                }
              }
              
              // HACK Преобразовать тип к IInternalZip, чтобы можно было добавить массив байт в zip. Убрать после доработки платформы.
              internalZip.Add(targetStream.ToArray(), containerName, "zip", path);
            }
          }
        }
      }
      
      // Создать лог-файл и добавить его к архиву.
      if (errors.Count > 0)
      {
        var errorAllText = string.Join(Environment.NewLine, errors.ToArray());
        using (var logFileStream = new System.IO.MemoryStream(Encoding.UTF8.GetBytes(errorAllText)))
        {
          // HACK Преобразовать тип к IInternalZip, чтобы можно было добавить массив байт в zip. Убрать после доработки платформы
          internalZip.Add(logFileStream.ToArray(), Constants.Module.ExportedLogFileName, "log", (new List<string>()).ToArray());
        }
      }
      
      if (numsErrorXmlDescriptions == signingOperationsCount)
        return null;
      
      var now = Calendar.UserNow;
      var tempFolderName = Resources.ExportDocumentFolderNameFormat(now.ToShortDateString() + " " + now.ToLongTimeString()).ToString();
      tempFolderName = CommonLibrary.FileUtils.NormalizeFileName(tempFolderName);
      zip.Save(tempFolderName);
      return zip;
    }
    
    /// <summary>
    /// Получить структуру файлов из XML
    /// </summary>
    /// <param name="xml">XML файл</param>
    /// <param name="filesInXml">Лист структуры файлов</param>
    /// <param name="errorText">Лист ошибок</param>
    /// <param name="containerName">Имя контейнера</param>
    public static HRPro.HRWred.Structures.Module.IValidationXml GetValidationFiles(byte[] xml, string containerName)
    {
      var filesInXml = new List<HRWred.Structures.Module.IFileXml>();
      var errorText = new List<string>();
      try
      {
        // Добавление файлов из XML описания в лист для сравнения
        XmlDocument doc = new XmlDocument();
        MemoryStream ms = new MemoryStream(xml);
        doc.Load(ms);
        var root = doc.DocumentElement;
        var content = root.FirstChild;
        var docInfo = content.SelectNodes("docinfo").Item(0);
        
        var documentInfo = GetXmlDocumentInfo(docInfo, containerName);
        if(!string.IsNullOrEmpty(documentInfo.Error))
          errorText.Add(documentInfo.Error);
        else
          filesInXml.Add(documentInfo);
        
        var signaturesInfo = GetXmlSignaturesInfo(docInfo, containerName);
        foreach (var signatureInfo in signaturesInfo)
        {
          if(!string.IsNullOrEmpty(signatureInfo.Error))
            errorText.Add(signatureInfo.Error);
          else
            filesInXml.Add(signatureInfo);
        }
        
        var employeeInfos = docInfo.SelectNodes("employeeinfo");
        foreach(System.Xml.XmlNode employeeInfo in employeeInfos)
        {
          var employeeSignaturesInfo = GetXmlSignaturesInfo(employeeInfo, containerName);
          foreach (var employeeSignatureInfo in employeeSignaturesInfo)
          {
            if(!string.IsNullOrEmpty(employeeSignatureInfo.Error))
              errorText.Add(employeeSignatureInfo.Error);
            else
              filesInXml.Add(employeeSignatureInfo);
          }
        }
        
        var attachmentsInfo = GetXmlAttachmentsInfo(docInfo, containerName);
        foreach (var attachmentInfo in attachmentsInfo)
        {
          if(!string.IsNullOrEmpty(attachmentInfo.Error))
            errorText.Add(attachmentInfo.Error);
          else
            filesInXml.Add(attachmentInfo);
        }
        
        var signatureOfEmployerInfo = GetXmlSignatureOfEmployerInfo(root.LastChild, containerName);
        if(!string.IsNullOrEmpty(signatureOfEmployerInfo.Error))
          errorText.Add(signatureOfEmployerInfo.Error);
        else
          filesInXml.Add(signatureOfEmployerInfo);
      }
      catch (Exception ex)
      {
        errorText.Add(string.Format(HRWred.Resources.ErrorReadXML, containerName));
        Logger.Error(ex.ToString());
      }
      
      var validationXml = new Structures.Module.ValidationXml();
      validationXml.FilesXml = filesInXml;
      validationXml.Errors = errorText;
      return validationXml;
    }
    
    /// <summary>
    /// Проверить достоверность подписи.
    /// </summary>
    /// <returns></returns>
    public static string CheckValiditySignature(Sungero.Domain.Shared.ISignature signature)
    {
      var errorList = new List<string>();
      var signatureInfo = Signatures.Verify(signature);
      if (signatureInfo.Errors.Any())
      {
        foreach (var errorMessage in signatureInfo.Errors.Select(x => x.Message))
          errorList.Add(errorMessage);
      }
      return string.Join(" ", errorList);
    }
    
    /// <summary>
    /// Проверить наличия файла в листе файлов из XML
    /// </summary>
    /// <param name="filesXml">Лист файлов из XML</param>
    /// <param name="size">Размер файла</param>
    /// <param name="name">Имя файла</param>
    /// <param name="containerName">Имя контейнера</param>
    /// <returns>Ошибка строкой если файла нет в XML описании, иначе пустая строка</returns>
    public static string CheckXMLInfo (List<HRPro.HRWred.Structures.Module.IFileXml> filesXml, long size, string name, string containerName)
    {
      var file = new HRWred.Structures.Module.FileXml();
      file.Size = size;
      file.File = name;
      if (!filesXml.Contains(file))
        return string.Format(HRWred.Resources.ErrorCheckXMLInfo, name, containerName);
      return string.Empty;
    }
    
    /// <summary>
    /// Получить данные об имени и размеру по главному документу
    /// </summary>
    /// <param name="docInfo">XML узел</param>
    /// <param name="containerName">Имя контейнера</param>
    /// <returns>Структура файла с именем и размером</returns>
    public static HRPro.HRWred.Structures.Module.IFileXml GetXmlDocumentInfo(System.Xml.XmlNode docInfo, string containerName)
    {
      var fileXml = new Structures.Module.FileXml();
      var nodeName = string.Empty;
      try
      {
        nodeName = "file";
        fileXml.File = docInfo.SelectNodes(nodeName).Item(0).InnerText;
        nodeName = "size";
        fileXml.Size = long.Parse(docInfo.SelectNodes(nodeName).Item(0).InnerText);
      }
      catch
      {
        fileXml.Error = string.Format(HRWred.Resources.ErrorWhileGetDataFromXMLNode, docInfo.Name, nodeName, containerName);
      }
      return fileXml;
    }
    
    /// <summary>
    /// Получить структуру подписей из XML узла
    /// </summary>
    /// <param name="docInfo">XML узел</param>
    /// <param name="containerName">Имя контейнера</param>
    /// <returns>Лист структур подписей</returns>
    public static List<HRPro.HRWred.Structures.Module.IFileXml> GetXmlSignaturesInfo(System.Xml.XmlNode docInfo, string containerName)
    {
      var signatures = new List<HRWred.Structures.Module.IFileXml>();
      foreach (XmlNode signatureXml in docInfo.ChildNodes)
      {
        if (signatureXml.Name == "signature" || signatureXml.Name == "employeesign" || signatureXml.Name == "employersign")
        {
          var signature = new Structures.Module.FileXml();
          var nodeName = string.Empty;
          try
          {
            nodeName = "x509";
            var x509 = signatureXml.SelectNodes(nodeName).Item(0);
            if (x509 != null)
            {
              nodeName = "file";
              signature.File = x509.SelectNodes(nodeName).Item(0).InnerText;
              nodeName = "size";
              signature.Size = long.Parse(x509.SelectNodes(nodeName).Item(0).InnerText);
            }
          }
          catch
          {
            signature.Error = string.Format(HRWred.Resources.ErrorWhileGetDataFromXMLNode, signatureXml.Name, nodeName, containerName);
          }
          signatures.Add(signature);
        }
      }
      signatures = signatures.Distinct().ToList();
      return signatures;
    }
    
    /// <summary>
    /// Получить структуру подписи представителя организации.
    /// </summary>
    /// <param name="signatureNode">Узел с подписью представителя организации.</param>
    /// <param name="containerName">Имя контейнера</param>
    /// <returns>Структура подписи представителя организации.</returns>
    public static HRPro.HRWred.Structures.Module.IFileXml GetXmlSignatureOfEmployerInfo(System.Xml.XmlNode signatureNode, string containerName)
    {
      var signature = new Structures.Module.FileXml();
      var nodeName = string.Empty;
      try
      {
        if (signatureNode.Name == "signature")
        {
          nodeName = "file";
          signature.File = signatureNode.SelectNodes(nodeName).Item(0).InnerText;
          nodeName = "size";
          signature.Size = long.Parse(signatureNode.SelectNodes(nodeName).Item(0).InnerText);
        }
      }
      catch
      {
        signature.Error = string.Format(HRWred.Resources.ErrorWhileGetDataFromXMLNode, signatureNode.Name, nodeName, containerName);
      }
      return signature;
    }
    
    /// <summary>
    /// Получить приложений из XML узла
    /// </summary>
    /// <param name="docInfo">XML узел</param>
    /// <param name="containerName">Имя контейнера</param>
    /// <returns>Лист структур приложений</returns>
    public static List<HRPro.HRWred.Structures.Module.IFileXml> GetXmlAttachmentsInfo(System.Xml.XmlNode docInfo, string containerName)
    {
      var attachments = new List<HRWred.Structures.Module.IFileXml>();
      foreach (XmlNode attachmentXml in docInfo.ChildNodes)
      {
        if (attachmentXml.Name == "attachment")
        {
          var attachment = new Structures.Module.FileXml();
          var nodeName = string.Empty;
          try
          {
            nodeName = "file";
            attachment.File = attachmentXml.SelectNodes(nodeName).Item(0).InnerText;
            nodeName = "size";
            attachment.Size = long.Parse(attachmentXml.SelectNodes(nodeName).Item(0).InnerText);
            
            var signatures = GetXmlSignaturesInfo(attachmentXml, containerName).AsEnumerable();
            attachments.AddRange(signatures);
          }
          catch
          {
            attachment.Error = string.Format(HRWred.Resources.ErrorWhileGetDataFromXMLNode, attachmentXml.Name, nodeName, containerName);
          }
          attachments.Add(attachment);
        }
      }
      attachments = attachments.Distinct().ToList();
      return attachments;
    }
    
    /// <summary>
    /// Получить подпись Директора по персоналу, или сотрудника, который ставит подпись от его лица.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <returns>Подпись.</returns>
    public static Sungero.Domain.Shared.ISignature GetHRManagerSignature(IOfficialDocument document)
    {
      var ourSignatory = document.OurSignatory;
      if (ourSignatory == null)
        return null;
      
      foreach (var version in document.Versions)
      {
        // TODO Выгрузка документов в формате Минтруда: Доработать после решения по справочнику HRSettings. Пока временная заглушка, функции не перенес.
        //var signature = HRWred.PublicFunctions.Module.GetVersionSignature(ourSignatory, version, HRWred.PublicFunctions.Module.NeedStaffChiefAdvancedSign(ourSignatory));
        var signature = GetVersionSignature(ourSignatory, version);
        if (signature != null)
          return signature;
      }
      return null;
    }

    /// <summary>
    /// Получить подпись сотрудника.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <returns>Подпись.</returns>
    public static Sungero.Domain.Shared.ISignature GetEmployeeSignature(IOfficialDocument document)
    {
      // TODO Выгрузка документов в формате Минтруда: Добавлена заглушка, поскольку в DocRelatedToWorkBase нет свойства Employee.
      var employee = Employees.Null;
      //var employee = HRManagement.HRDocuments.Is(document) ? HRManagement.HRDocuments.As(document).Employee : HRManagement.HROrders.Is(document) ? HRManagement.HROrders.As(document).Employee : Employees.Null;
      if (employee != null)
      {
        foreach (var version in document.Versions)
        {
          var signature = HRWred.PublicFunctions.Module.GetVersionSignature(employee, version);
          if (signature != null)
            return signature;
        }
      }
      return null;
    }
    
    /// <summary>
    /// Получить последнюю по времени утверждающую или согласующую подпись сотрудника.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="version">Версия документа.</param>
    /// <returns>Подпись сотрудника.</returns>
    [Public]
    public static Sungero.Domain.Shared.ISignature GetVersionSignature(IEmployee employee, IElectronicDocumentVersions version)
    {
      var employeeSignatures = new List<Sungero.Domain.Shared.ISignature>();
      // Получаем всех совместителей, включая основного сотрудника.
      var personEmployeesIds = Functions.Module.GetPersonEmployeeIds(employee.Person.Id);
      var personEmployees = new List<IEmployee>();
      
      foreach (var personEmployeesId in personEmployeesIds)
      {
        personEmployees.Add(Employees.Get(personEmployeesId));
      }
      
      var employeeCertificates = new List<Sungero.CoreEntities.ICertificate>();
      // Получаем все сертификаты сотрудника и совместителей.
      foreach (var personEmployee in personEmployees)
      {
        employeeCertificates.AddRange(Sungero.CoreEntities.Certificates.GetAll(c => c.Owner.Equals(Users.As(personEmployee))));
      }
      
      // Получаем все утверждающие и согласующие подписи на версии документа.
      var versionSignatures = Signatures.Get(version, q => q.Where(s => (s.SignatureType == SignatureType.Approval || s.SignatureType == SignatureType.Endorsing) &&
                                                                   (s.SignatoryFullName == employee.Name || s.SubstitutedUserFullName == employee.Name))).ToList();
      // Берем только подписи, в которых отпечаток сертификата содержится в сертификатах сотрудника, либо его совместителей.
      // Для простых подписей проверяем всех сотрудников персоны. Если какой-то из них совпадает с подписантом из подписи - добавляем эту подпись.
      foreach (var versionSignature in versionSignatures)
      {
        var signature = Signatures.Get(version, q => q.Where(s => s.Id == versionSignature.Id)).FirstOrDefault();
        if (signature.SignCertificate == null)
        {
          foreach (var personEmployee in personEmployees)
          {
            if (signature.Signatory.Equals(Users.As(personEmployee)))
            {
              employeeSignatures.Add(signature);
              break;
            }
          }
        }
        else
        {
          foreach (var certificate in employeeCertificates)
          {
            if (certificate.Thumbprint.ToLower().Equals(signature.SignCertificate.Thumbprint.ToLower()))
            {
              employeeSignatures.Add(signature);
            }
          }
        }
      }
      
      if (employeeSignatures.Any())
      {
        // Взять последнюю по времени.
        return employeeSignatures.OrderByDescending(s => s.SigningDate).FirstOrDefault();
      }
      else
        return null;
    }
    
    /// <summary>
    /// Проверить наличие полного комплекта подписей на документе. Для приказов, трудового договора и доп. соглашения должны стоять обе подписи для полного комплекта.
    /// Для уведомления об отпуске - подпись сотрудника.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <returns>True, если на документе полный комплект подписей.</returns>
    public virtual bool IsFullComplectInDocument(IOfficialDocument document)
    {
      var managerSign = GetHRManagerSignature(document);
      var employeeSign = GetEmployeeSignature(document);
      var isFullComplect = true;
      // TODO Выгрузка документов в формате Минтруда: Доработать после аналитики по видам документов. Добавлена временная заглушка.
      if (this.HasComplectSignInDocKind(document) && (managerSign != null && employeeSign == null))
        //if (this.HasComplectSignInDocKind(document) && (managerSign != null && employeeSign == null) || (document.DocumentKind == DocKindFunctions.GetNativeDocumentKind(DocKind.ScheduledVacationNoticeKind) && employeeSign == null))
        isFullComplect = false;
      return isFullComplect;
    }
    
    // TODO Выгрузка документов в формате Минтруда: Доработать после аналитики по видам документов. Добавлена временная заглушка.
    /// <summary>
    /// Проверить, полный ли комплект подписей должен быть на виде документа. Полный комплект - подпись и сотрудника и подписанта.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <returns>True, если вид документа удовлетворяет проверке.</returns>
    public virtual bool HasComplectSignInDocKind(IOfficialDocument document)
    {
      var docKindGuid = this.GetDocumentKindGuid(document.DocumentKind);
      return true;
      // TODO WRED2.0
      //return docKindGuid == DocKind.EmploymentContractKind;
      /*
      return docKindGuid == DocKind.EmploymentContractKind || docKindGuid == DocKind.TransferAdditionalAgreementKind ||
        docKindGuid == DocKind.ChangeWorkConditionsAdditionalAgreementKind || docKindGuid == DocKind.HiringOrderKind ||
        docKindGuid == DocKind.TransferOrderKind || docKindGuid == DocKind.ChangeWorkConditionsOrderKind ||
        docKindGuid == DocKind.DismissalOrderKind || docKindGuid == DocKind.VacationOrderKind ||
        docKindGuid == DocKind.VacationShiftOrderKind || docKindGuid == DocKind.VacationRecallOrderKind;
       */
    }
    
    // TODO Выгрузка документов в формате Минтруда: Доработать после аналитики по видам документов. Добавлена временная заглушка.
    /// <summary>
    /// Проверить, что для данного вида документа должна быть только подпись сотрудника.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <returns>True, если вид документа удовлетворяет проверке.</returns>
    public virtual bool HasEmployeeSignInDocKind(IOfficialDocument document)
    {
      var docKindGuid = this.GetDocumentKindGuid(document.DocumentKind);
      return false;
      /*
      return docKindGuid == DocKind.AcquaintanceListKind || docKindGuid == DocKind.TransferStatementKind ||
        docKindGuid == DocKind.DismissalStatementKind || docKindGuid == DocKind.ScheduledVacationNoticeKind ||
        docKindGuid == DocKind.VacationStatementKind || docKindGuid == DocKind.VacationShiftStatementKind ||
        docKindGuid == DocKind.VacationRecallStatementKind;
       */
    }
    
    // TODO Выгрузка документов в формате Минтруда: Доработать после аналитики по видам документов. Добавлена временная заглушка.
    /// <summary>
    /// Проверить, что для данного вида документа должна быть только подпись подписанта.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <returns>True, если вид документа удовлетворяет проверке.</returns>
    public virtual bool HasManagerSignInDocKind(IOfficialDocument document)
    {
      var docKindGuid = this.GetDocumentKindGuid(document.DocumentKind);
      return false;
      //return docKindGuid == DocKind.VacationScheduleKind;
    }
    
    /// <summary>
    /// Замена символов, не подходящих для прохождения валидации.
    /// </summary>
    /// <param name="str">Строка, которую необходимо обработать.</param>
    /// <returns>Обработанная строка.</returns>
    public static string ReplaceUnvalidatedSymbols(string str)
    {
      string[] unvalidatedSymbols = {"ё", "Ё", "-"};
      string[] validatedSymbols = {"е", "Е", ""};
      
      for (int i = 0; i < unvalidatedSymbols.Count(); i++)
      {
        str = str.Replace(unvalidatedSymbols[i], validatedSymbols[i]);
      }
      return str;
    }
    
    /// <summary>
    /// Замена символов, не подходящих для прохождения валидации имени персоны.
    /// </summary>
    /// <param name="str">Строка, которую необходимо обработать.</param>
    /// <returns>Обработанная строка.</returns>
    public static string ReplaceUnvalidatedPersonNameSymbols(string str)
    {
      string[] unvalidatedSymbols = {"ё", "Ё"};
      string[] validatedSymbols = {"е", "Е"};
      
      for (int i = 0; i < unvalidatedSymbols.Count(); i++)
      {
        str = str.Replace(unvalidatedSymbols[i], validatedSymbols[i]);
      }
      return str;
    }    
    
    /// <summary>
    /// Транслитерация строки
    /// </summary>
    /// <param name="str">Строка для транслитерации</param>
    /// <returns>Строка транслитом, без символов</returns>
    public static string Transliteration(string str)
    {
      string[] lat = {"a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "sh", "", "y", "", "e", "yu", "ya", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_"};
      string[] rus = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "\\", "/", ":", "*", "?", "\"", "<", ">", "|", "№", "."};
      str = str.ToLower();
      for (int i = 0; i < lat.Count(); i++)
      {
        str = str.Replace(rus[i],lat[i]);
      }
      return str;
    }
    
    /// <summary>
    /// Изменение имени файла в соответствии со схемой валидации Минтруда
    /// </summary>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Имя файла, проходящее валидацию</returns>
    public static string TransformFilenameToWredFormat(string filename)
    {
      string pattern = @"[^a-zA-Zа-яА-ЯёЁ0-9_]";
      filename = Regex.Replace(filename, pattern, "_");
      //Если название короткое то оставляем кириллицу
      if (filename.Length > Constants.Module.MaxRuExportFileNameLength)
        filename = Transliteration(filename);
      if (filename.Length > Constants.Module.MaxExportFileNameLength)
        filename = filename.Substring(0, Constants.Module.MaxExportFileNameLength);
      return filename;
    }
    /// <summary>
    /// Изменение имени файла в соответствии со схемой валидации Минтруда с учетом папки подписанта
    /// </summary>
    /// <param name="fileName">Имя файла</param>
    /// <param name="folder">Имя папки подписанта</param>
    /// <returns>Имя файла, проходящее валидацию</returns>
    public static string TransformFilenameToWredFormat(string filename, string folder)
    {
      string pattern = @"[^a-zA-Zа-яА-ЯёЁ0-9_]";
      filename = Regex.Replace(filename, pattern, "_");
      //Если название короткое то оставляем кириллицу
      if (filename.Length + folder.Length > Constants.Module.MaxRuExportFileNameLength)
        filename = Transliteration(filename);
      if (filename.Length + (folder.Length * Constants.Module.MultiplierFromRuToEn) > Constants.Module.MaxExportFileNameLength)
        filename = filename.Substring(0, Constants.Module.MaxExportFileNameLength - (folder.Length * Constants.Module.MultiplierFromRuToEn));
      return filename;
    }
    
    /// <summary>
    /// Определить версию xsd схемы Минтруда по дате.
    /// </summary>
    /// <param name="date">Дата создания документа.</param>
    /// <returns>Номер версии схемы</returns>
    public virtual string GetWredXSDVersionByDate(DateTime? date)
    {
      if (date != null)
      {
        var checkDate = Int32.Parse(date.Value.ToString("yyyyMMdd"));
        
        // <Версия>;<Действует с>;<Действует по>
        List<string> versionsValidity = new List<string>()
        {
          "1.0;00010101;20230228", // Документы до этого периода еще не обязаны формироваться
          "1.0;20230301;99991231"  // Первая версия xsd
        };
        
        foreach (var versionLine in versionsValidity)
        {
          string[] line = versionLine.Split(';');
          if (checkDate >= Int32.Parse(line[1]) && checkDate <= Int32.Parse(line[2]))
            return line[0];
        }
      }
      return HRWred.Constants.Module.MintrudXSDDefaultVersion;
    }
    #endregion
    
    #region Работа с типами и видами документов
    
    /// <summary>
    /// Получить список ID видов документов КЭДО.
    /// </summary>
    /// <returns>Список ID видов документов КЭДО.</returns>
    [Public, Remote(IsPure = true)]
    public virtual List<long> GetHRDocumentKindsIDs()
    {
      var documentKinds = HRProWredSolution.DocumentKinds.GetAll(k => k.WredcCodeHRPro != null && k.WredcCodeHRPro != string.Empty).Select(d => d.Id);
      return documentKinds.ToList();
    }
    
    /// <summary>
    /// Получить Guid вида документа.
    /// </summary>
    /// <param name="documentKind">Вид документа.</param>
    /// <returns>Guid вида документа.</returns>
    public virtual Guid GetDocumentKindGuid(Sungero.Docflow.IDocumentKind documentKind)
    {
      var externalLink = Sungero.Domain.ModuleFunctions.GetAllExternalLinks().Where(l => l.EntityTypeGuid == HRWred.Constants.Module.DocumentKindTypeGuid &&
                                                                                    l.EntityId == documentKind.Id).FirstOrDefault();
      if (externalLink == null)
        return Guid.Empty;
      
      return Guid.Parse(externalLink.ExternalEntityId);
    }
    #endregion
    
    #region Фильтрации по справочникам модуля Company
    /// <summary>
    /// Получить подразделения по Нашей организации.
    /// </summary>
    /// <param name="businessUnit">Наша организация.</param>
    /// <param name="activeOnly">True если выбрать только действующие подразделения.</param>
    /// <returns>Query для подразделений.</returns>
    [Remote]
    public IQueryable<IDepartment> GetFilteredDepartmentsAsQueryable(IBusinessUnit businessUnit, bool activeOnly)
    {
      var departments = Sungero.Company.PublicFunctions.Department.Remote.GetDepartments();
      if (activeOnly)
        departments = departments.Where(d => d.Status == Sungero.CoreEntities.DatabookEntry.Status.Active);
      return departments.Where(d => Equals(d.BusinessUnit, businessUnit));
    }

    /// <summary>
    /// Получить список действующих сотрудников по подразделению.
    /// </summary>
    /// <param name="departments">Список подразделений.</param>
    /// <returns>Список сотрудников.</returns>
    [Public, Remote]
    public List<IEmployee> GetFilteredEmployees(List<IDepartment> departments)
    {
      return this.GetFilteredEmployees(departments, true);
    }
    
    /// <summary>
    /// Получить список сотрудников по подразделению.
    /// </summary>
    /// <param name="departments">Список подразделений.</param>
    /// <param name="activeOnly">True если выбрать только действующих сотрудников.</param>
    /// <returns>Список сотрудников.</returns>
    [Public, Remote]
    public List<IEmployee> GetFilteredEmployees(List<IDepartment> departments, bool activeOnly)
    {
      var employees = Employees.GetAll();
      if (activeOnly)
        employees = employees.Where(l => l.Status == Sungero.Company.Employee.Status.Active);
      
      // Сотрудники фильтруются по подразделению.
      if (departments.Any())
        return employees.Where(d => departments.Contains(d.Department)).ToList();
      
      // Сотрудники не фильтруются по подразделению.
      return employees.ToList();
    }

    /// <summary>
    /// Получить список действующих сотрудников по Нашей организации.
    /// </summary>
    /// <param name="businessUnit">Наша организация.</param>>
    /// <returns>Список сотрудников.</returns>
    [Remote]
    public List<IEmployee> GetFilteredEmployees(IBusinessUnit businessUnit)
    {
      return this.GetFilteredEmployees(businessUnit, true);
    }
    
    /// <summary>
    /// Получить список сотрудников по Нашей организации.
    /// </summary>
    /// <param name="businessUnit">Наша организация.</param>>
    /// <param name="activeOnly">True если выбрать только действующих сотрудников.</param>
    /// <returns>Список сотрудников.</returns>
    [Public, Remote]
    public List<IEmployee> GetFilteredEmployees(IBusinessUnit businessUnit, bool activeOnly)
    {
      var employees = Employees.GetAll();
      if (activeOnly)
        employees = employees.Where(l => l.Status == Sungero.Company.Employee.Status.Active);
      
      // Сотрудники фильтруются по НОР.
      if (businessUnit != null)
        return employees.Where(d => Equals(d.Department.BusinessUnit, businessUnit)).ToList();
      
      // Сотрудники не фильтруются по НОР.
      return employees.ToList();
    }
    #endregion
    
    #region Работа со справочником SigningOperation
    /// <summary>
    /// Создать стандартную запись в справочнике SigningOperation.
    /// </summary>
    /// <param name="documentSets">Комплект документов.</param>
    /// <param name="signatory">Подписывающий.</param>
    /// <param name="note">Примечание.</param>
    /// <returns>Операция подписания.</returns>
    [Public]
    public ISigningOperation CreateDefaultSigningOperation(HRWred.Structures.Module.IDocumentSet documentSet, IEmployee signatory, string note)
    {
      var signingOperation = SigningOperations.Create();
      signingOperation.Name = HRPro.HRWred.Resources.SigningOperationNameFormat(documentSet.MainDocument.Name, signatory.Person.ShortName);
      
      // Информация о документе.
      signingOperation.Document = documentSet.MainDocument;
      signingOperation.DocumentVersion = documentSet.MainDocument.LastVersion.Id;
      signingOperation.DocumentName = documentSet.MainDocument.Name.Length > 255 ? documentSet.MainDocument.Name.Substring(0, 255) : documentSet.MainDocument.Name;
      signingOperation.DocumentFileName = GetFileNameForSigningOperation(signingOperation, documentSet.MainDocument.LastVersion, documentSet.MainDocument);
      if (!string.IsNullOrEmpty(documentSet.MainDocument.Subject))
        signingOperation.DocumentAnnotation = documentSet.MainDocument.Subject.Length > 1024 ? documentSet.MainDocument.Subject.Substring(0, 1024) : documentSet.MainDocument.Subject;
      if (!string.IsNullOrEmpty(documentSet.MainDocument.RegistrationNumber))
        signingOperation.DocumentRegistrationNumber = documentSet.MainDocument.RegistrationNumber;
      signingOperation.DocumentWredCode = HRProWredSolution.DocumentKinds.As(documentSet.MainDocument.DocumentKind).WredcCodeHRPro;
      
      // Информация о подписи и подписанте.
      var signature = GetVersionSignature(signatory, documentSet.MainDocument.LastVersion);
      if (signature != null)
      {
        signingOperation.SignatureID = signature.Id;
        if (signature.SignCertificate != null)
          signingOperation.SignatureFileName = GetFilenameForSignature(signature);
      }
      signingOperation.Signatory = signatory;
      signingOperation.SignatoryName = Functions.Module.ReplaceUnvalidatedPersonNameSymbols(signatory.Person.FirstName);
      signingOperation.SignatoryLastName = Functions.Module.ReplaceUnvalidatedPersonNameSymbols(signatory.Person.LastName);
      signingOperation.SignatoryMiddleName = String.IsNullOrEmpty(signatory.Person.MiddleName) == true ? null : Functions.Module.ReplaceUnvalidatedPersonNameSymbols(signatory.Person.MiddleName);
      signingOperation.SignatoryJobTitle = signatory.JobTitle != null ? signatory.JobTitle.ToString() : string.Empty;
      signingOperation.SignatoryINILA = signatory.Person.INILA;
      signingOperation.SignatoryContainerName = signatory.Name + " (" + signatory.Id.ToString() +")";
      
      // Информация об организации сотрудника.
      if (signatory.Department.BusinessUnit != null)
      {
        signingOperation.BusinessUnitName = signatory.Department.BusinessUnit.LegalName;
        signingOperation.BusinessUnitTIN = signatory.Department.BusinessUnit.TIN;
        signingOperation.BusinessUnitPSRN = signatory.Department.BusinessUnit.PSRN;
        signingOperation.BusinessUnitTRRC = signatory.Department.BusinessUnit.TRRC;
      }
      
      // Заполнить информацию о приложениях - для каждого приложения создать запись в коллекции.
      foreach (var document in documentSet.Addenda)
      {
        var attachment = signingOperation.Attachments.AddNew();
        attachment.Document = document;
        attachment.AttachmentDocumentVersion = document.LastVersion.Id;
        if (document.Subject != null)
          attachment.DocumentAnnotation = document.Subject.Length > 1024 ? document.Subject.Substring(0, 1024) : document.Subject;
        attachment.DocumentFileName = GetFileNameForSigningOperation(signingOperation, document.LastVersion, document);
        var signatureAttachment = GetVersionSignature(signatory, document.LastVersion);
        attachment.SignatureId = signatureAttachment.Id;
        if (signatureAttachment.SignCertificate != null)
          attachment.SignatureFileName = GetFilenameForSignature(signatureAttachment);
      }
      
      // Заполнить примечание.
      signingOperation.Note = note;
      return signingOperation;
    }
    
    /// <summary>
    /// Получить имя документа для записи в справочник SigningOperation.
    /// </summary>
    /// <param name="signingOperation">Операция подписания.</param>
    /// <param name="version">Версия документа.</param>
    /// <param name="document">Документ.</param>
    /// <returns>Имя документа для выгрузки.</returns>
    public string GetFileNameForSigningOperation(ISigningOperation signingOperation, IElectronicDocumentVersions version, IOfficialDocument document)
    {
      var docName = CommonLibrary.FileUtils.NormalizeFileName(document.Name);
      docName = TransformFilenameToWredFormat(docName);
      docName = ReplaceUnvalidatedSymbols(docName);
      var extension = string.Concat(".", version.BodyAssociatedApplication.Extension);
      if (docName.Length + extension.Length > 250)
        docName = docName.Substring(0, 250 - extension.Length);
      var fileName = string.Concat(docName, extension);
      
      var documentsFileNames = new List<string>();
      if (!signingOperation.Document.Equals(document))
        documentsFileNames.Add(signingOperation.DocumentName);
      foreach (var attachment in signingOperation.Attachments)
      {
        if (!attachment.Document.Equals(document))
          documentsFileNames.Add(attachment.Document.Name);
      }
      if (documentsFileNames.Any(d => d == document.Name))
      {
        var number = documentsFileNames.Count(d => d == document.Name);
        var postfix = string.Concat("_", number.ToString());
        if (docName.Length + postfix.Length + extension.Length > 250)
        {
          docName = docName.Substring(0, 250 - postfix.Length - extension.Length);
        }
        fileName = string.Concat(docName, postfix, extension);
      }
      return fileName;
    }
    
    // TODO Доработать в таске по переформированию xml.
    /// <summary>
    /// Переформировать xml-описатель.
    /// </summary>
    /// <param name="documentExportData">Запись справочника, для которой переформируется xml.</param>
    //[Public]
    //public void RebuildXmlDescription(ISigningOperation signingOperation)
    //{
    //  var document = signingOperation.Document;
    //  var xmlDescription = FormXMLFile(signingOperation, document, true);
    //  if (CheckFormXml(xmlDescription))
    //  {
    //    signingOperation.XmlDescription = xmlDescription;
    //    signingOperation.Save();
    //  }
    //}
    
    /// <summary>
    /// Создать операцию подписания сотрудника.
    /// </summary>
    /// <param name="documentSets">Комплект документов.</param>
    /// <param name="signatory">Подписывающий.</param>
    /// <param name="note">Примечание.</param>
    public void CreateSigningOperationEmployee(List<HRWred.Structures.Module.IDocumentSet> documentSets, IEmployee signatory, string note)
    {
      foreach (var documentSet in documentSets)
      {
        if(IsSigningOperationExist(documentSet, signatory, false))
        {
          Logger.DebugFormat("HRWred.CreateSigningOperationEmployee(). SigningOperation is already exist with document id: {0}, version id: {1}, employee id: {2} and last signature",
                             documentSet.MainDocument.Id, documentSet.MainDocument.LastVersion.Id, signatory.Id);
          continue;
        }
        var signingOperationEmpl = CreateDefaultSigningOperation(documentSet, signatory, note);
        var signingOperationManager = SigningOperations.GetAll(s => s.Document.Equals(signingOperationEmpl.Document) && s.IsSignatoryAnOfficial.Value == true
                                                               && s.DocumentVersion.Equals(signingOperationEmpl.DocumentVersion)).FirstOrDefault();
        signingOperationEmpl.EmployerSigningOperation = signingOperationManager;
        signingOperationEmpl.OperationState = GetOperationState(signingOperationEmpl, signingOperationManager);
        signingOperationEmpl.IsSignatoryAnOfficial = false;
        signingOperationEmpl.Save();
      }
    }
    /// <summary>
    /// Создать операцию подписания руководителя.
    /// </summary>
    /// <param name="documentSets">Комплект документов.</param>
    /// <param name="signatory">Подписывающий.</param>
    /// <param name="note">Примечание.</param>
    public void CreateSigningOperationManager(List<HRWred.Structures.Module.IDocumentSet> documentSets, IEmployee signatory, string note)
    {
      foreach (var documentSet in documentSets)
      {
        if(IsSigningOperationExist(documentSet, signatory, true))
        {
          Logger.DebugFormat("HRWred.CreateSigningOperationManager(). SigningOperation is already exist with document id: {0}, version id: {1}, employee id: {2} and last signature",
                             documentSet.MainDocument.Id, documentSet.MainDocument.LastVersion.Id, signatory.Id);
          continue;
        }
        var signingOperationManager = CreateDefaultSigningOperation(documentSet, signatory, note);
        signingOperationManager.IsSignatoryAnOfficial = true;
        signingOperationManager.OperationState = HRWred.SigningOperation.OperationState.Registrated;
        if (documentSet.MainDocument.OurSigningReason != null && documentSet.MainDocument.OurSigningReason.Reason == Sungero.Docflow.SignatureSetting.Reason.FormalizedPoA)
        {
          var powerOfAttorney = signingOperationManager.PowerOfAttorney.AddNew();
          powerOfAttorney.Document = Sungero.Docflow.FormalizedPowerOfAttorneys.As(documentSet.MainDocument.OurSigningReason.Document);
          powerOfAttorney.DocumentFileName = string.Format(Constants.Module.AttorneyFileExtension,
                                                           TransformFilenameToWredFormat(string.Format(Constants.Module.BasisFileNameOfPoA, powerOfAttorney.Document.UnifiedRegistrationNumber)));
          powerOfAttorney.SignatureID = Signatures.Get(powerOfAttorney.Document).FirstOrDefault().Id;
          powerOfAttorney.SignatureFileName = string.Concat(TransformFilenameToWredFormat(string.Format(Constants.Module.BasisFileNameOfPoA, powerOfAttorney.Document.UnifiedRegistrationNumber)),
                                                            Constants.Module.SignatureFileExtension);
        }
        signingOperationManager.Save();
        
        // Ставим операцию подписания работодателем во все найденные операции подписания сотрудником.
        var signingOperationsEmpl = SigningOperations.GetAll(s => s.Document.Equals(signingOperationManager.Document) && s.IsSignatoryAnOfficial.Value == false &&
                                                             s.DocumentVersion.Equals(signingOperationManager.DocumentVersion) &&
                                                             s.OperationState != HRWred.SigningOperation.OperationState.Formed).ToList();
        foreach (var signingOperation in signingOperationsEmpl)
        {
          signingOperation.EmployerSigningOperation = signingOperationManager;
          signingOperation.OperationState = GetOperationState(signingOperation, signingOperationManager);
          signingOperation.Save();
        }
      }
    }
    
    /// <summary>
    /// Создать операцию подписания.
    /// </summary>
    /// <param name="mainDocs">Список основных документов.</param>
    /// <param name="addendaDocs">Список приложений.</param>
    /// <param name="signatory">Подписант.</param>
    /// <param name="isEmployer">Подписывает руководитель?</param>
    /// <param name="note">Примечание.</param>
    [Public]
    public virtual void CreateSigningOperation(System.Collections.Generic.IEnumerable<IOfficialDocument> mainDocs,
                                               System.Collections.Generic.IEnumerable<IOfficialDocument> addendaDocs, IEmployee signatory, bool isEmployer, string note)
    {
      AccessRights.AllowRead(() => {
        // Разделяем документы на комплекты.
        var documentSets = DivideDocumentsOnSets(mainDocs, addendaDocs).Sets;
        // Создаем запись операции подписания.
        if (isEmployer)
        {
          CreateSigningOperationManager(documentSets, signatory, note);
        }
        else
        {
          CreateSigningOperationEmployee(documentSets, signatory, note);
        }
      });
    }
    
    /// <summary>
    /// Создать операцию подписания.
    /// </summary>
    /// <param name="mainDocs">Список основных документов.</param>
    /// <param name="addendaDocs">Список приложений.</param>
    /// <param name="signatory">Подписант.</param>
    /// <param name="isEmployer">Подписывает руководитель?</param>
    [Public]
    public virtual void CreateSigningOperation(System.Collections.Generic.IEnumerable<IOfficialDocument> mainDocs,
                                               System.Collections.Generic.IEnumerable<IOfficialDocument> addendaDocs, IEmployee signatory, bool isEmployer)
    {
      Functions.Module.CreateSigningOperation(mainDocs, addendaDocs, signatory, isEmployer, string.Empty);
    }
    
    /// <summary>
    /// Создать операцию подписания.
    /// </summary>
    /// <param name="mainDocs">Список основных документов.</param>
    /// <param name="addendaDocs">Список приложений.</param>
    /// <param name="completedBy">Сотрудник, который выполнил задание.</param>
    /// <param name="performer">Сотрудник, которому пришло задание.</param>
    /// <param name="isEmployer">Подписывает руководитель?</param>
    /// <param name="note">Примечание.</param>
    [Public]
    public virtual void CreateSigningOperation(System.Collections.Generic.IEnumerable<IOfficialDocument> mainDocs,
                                               System.Collections.Generic.IEnumerable<IOfficialDocument> addendaDocs, IEmployee completedBy, IEmployee performer, bool isEmployer, string note)
    {
      AccessRights.AllowRead(() => {
        // Определяем подписанта.
        var signatory = Employees.Null;
        if (completedBy != null && performer != null && !completedBy.Equals(performer) && completedBy.Person.Equals(performer.Person))
          signatory = performer;
        else if (completedBy != null && completedBy.IsSystem != true)
          signatory = completedBy;
        else
          signatory = performer;
        
        this.CreateSigningOperation(mainDocs, addendaDocs, signatory, isEmployer, note);
      });
    }
    
    /// <summary>
    /// Создать операцию подписания.
    /// </summary>
    /// <param name="mainDocs">Список основных документов.</param>
    /// <param name="addendaDocs">Список приложений.</param>
    /// <param name="completedBy">Сотрудник, который выполнил задание.</param>
    /// <param name="performer">Сотрудник, которому пришло задание.</param>
    /// <param name="isEmployer">Подписывает руководитель?</param>
    [Public]
    public virtual void CreateSigningOperation(System.Collections.Generic.IEnumerable<IOfficialDocument> mainDocs,
                                               System.Collections.Generic.IEnumerable<IOfficialDocument> addendaDocs, IEmployee completedBy, IEmployee performer, bool isEmployer)
    {
      Functions.Module.CreateSigningOperation(mainDocs, addendaDocs, completedBy, performer, isEmployer, string.Empty);
    }
    
    /// <summary>
    /// Проверить есть ли уже операция подписания у данного сотрудника на эту версию документа с той же подписью.
    /// </summary>
    /// <param name="documentSet">Комплект документов.</param>
    /// <param name="signatory">Подписывающий.</param>
    /// <param name="isSignatoryAnOfficial">Сотрудник подписал документ от имени работодателя.</param>
    /// <returns>True если есть такая операция подписания.</returns>
    public bool IsSigningOperationExist(HRWred.Structures.Module.IDocumentSet documentSet, IEmployee signatory, bool isSignatoryAnOfficial)
    {
      Nullable<long> signatureID = null;
      var signature = GetVersionSignature(signatory, documentSet.MainDocument.LastVersion);
      if (signature != null)
      {
        signatureID = signature.Id;
      }
      return SigningOperations.GetAll(so => so.SignatureID.Equals(signatureID) 
                                      && so.Document.Equals(documentSet.MainDocument) 
                                      && so.DocumentVersion.Equals(documentSet.MainDocument.LastVersion.Id)
                                      && so.Signatory.Equals(signatory)
                                      && so.IsSignatoryAnOfficial.HasValue && so.IsSignatoryAnOfficial.Value == isSignatoryAnOfficial).Any();
    }
    #endregion
    
    /// <summary>
    /// Разбить документы и приложения по группам.
    /// </summary>
    /// <param name="documents">Документы.</param>
    /// <param name="addenda">Приложения.</param>
    /// <returns>Структура, сосотящая из комплектов документов (основной дкоумент плюс приложения) и некомплектных приложений.</returns>
    [Public]
    public virtual HRPro.HRWred.Structures.Module.ISetsAndNotSetDocuments DivideDocumentsOnSets (System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> documents,
                                                                                                 System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> addenda)
    {
      var sets = new List<HRPro.HRWred.Structures.Module.IDocumentSet>();
      var notSets = HRPro.HRWred.Structures.Module.NotSetAddenda.Create(new List<IOfficialDocument>());
      var result = HRPro.HRWred.Structures.Module.SetsAndNotSetDocuments.Create();
      
      // Ищем Некомплект.
      foreach (var ad in addenda)
      {
        // Если у приложения есть связи, то проверяем на связи с основными документами.
        // Иначе - сразу записываем в структуру Некомплекта.
        if (ad.HasRelations)
        {
          // Ищем основные документы приложения в списке основных документов.
          var addendaWithRelation = this.GetMainDocumentsForAddenda(ad, documents);
          // Если у приложения нет связей с документами из основной группу - записываем в структуру Некомплекта.
          if (!addendaWithRelation.Any())
            notSets.Addenda.Add(ad);
        }
        else
          notSets.Addenda.Add(ad);
      }
      
      // Составляем комплекты.
      foreach (var doc in documents)
      {
        var docSet = HRPro.HRWred.Structures.Module.DocumentSet.Create(doc, new List<IOfficialDocument>());
        docSet.MainDocument = doc;
        if (doc.HasRelations)
        {
          var addendas = this.GetAddendaForMainDocument(doc, addenda);
          if (addendas.Any())
          {
            foreach (var addendaDoc in addendas)
              docSet.Addenda.Add(addendaDoc);
          }
        }
        sets.Add(docSet);
      }
      
      // Добавляем все комплекты и некомплекты в результат.
      result.NotSets = notSets;
      result.Sets = sets;
      return result;
    }

    /// <summary>
    /// Получить все главные документы приложения из списка документов.
    /// </summary>
    /// <param name="addenda">Приложение.</param>
    /// <param name="documents">Список документов.</param>
    /// <returns>Главные документы приложения из списка документов.</returns>
    public System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> GetMainDocumentsForAddenda (IOfficialDocument addenda,
                                                                                                                 System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> documents)
    {
      var allMainDocuments = addenda.Relations.GetRelatedFrom(Sungero.Docflow.PublicConstants.Module.AddendumRelationName).Where(x => OfficialDocuments.As(x) != null).Cast<IOfficialDocument>();
      return allMainDocuments.Where(x => documents.Contains(x));
    }
    
    /// <summary>
    /// Получить все приложения из списка приложений для основного документа.
    /// </summary>
    /// <param name="mainDoc">Основной документ.</param>
    /// <param name="addenda">Приложения.</param>
    /// <returns>Приложения из списка приложений для основного документа.</returns>
    public System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> GetAddendaForMainDocument (IOfficialDocument mainDoc,
                                                                                                                System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> addenda)
    {
      var allAddenda = mainDoc.Relations.GetRelated(Sungero.Docflow.PublicConstants.Module.AddendumRelationName).Where(x => OfficialDocuments.As(x) != null).Cast<IOfficialDocument>();
      return allAddenda.Where(x => addenda.Contains(x));
    }
    
    /// <summary>
    /// Получить некомплектные приложения.
    /// </summary>
    /// <param name="documents">Основные документы.</param>
    /// <param name="addenda">Приложения.</param>
    /// <returns>Список некомплектных приложений.</returns>
    [Public]
    public virtual List<IOfficialDocument> GetNotSetDocuments (System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> documents,
                                                               System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> addenda)
    {
      var result = this.DivideDocumentsOnSets(documents, addenda);
      if (result.NotSets.Addenda != null && result.NotSets.Addenda.Any())
        return result.NotSets.Addenda;
      else
        return null;
    }
    
    #region Работа с zip-архивами.
    /// <summary>
    /// Создать/добавить файл в виде потока к zip-архиву.
    /// </summary>
    /// <param name="targetStream">Конечный zip-архив в виде потока.</param>
    /// <param name="sourceStream">Поток файла для добавления в архив.</param>
    /// <param name="filename">Имя файла в архиве.</param>
    [Public]
    public virtual void AppendToZip(System.IO.MemoryStream targetStream, System.IO.MemoryStream sourceStream, string filename)
    {
      var archiveMode = IOCompress.ZipArchiveMode.Create;
      
      if (targetStream.Capacity > 0)
        archiveMode = IOCompress.ZipArchiveMode.Update;
      
      using (var archive = new IOCompress.ZipArchive(targetStream, archiveMode, true))
      {
        IOCompress.ZipArchiveEntry entry = archive.CreateEntry(filename);
        using (StreamWriter newFile = new StreamWriter(entry.Open()))
        {
          using (StreamReader source = new StreamReader(sourceStream))
          {
            source.BaseStream.CopyTo(newFile.BaseStream);
          }
        }
      }
    }
    #endregion
    
    #region Совместители.
    /// <summary>
    /// Возвращает список сотрудников персоны, отсортированный по виду занятости.
    /// Сотрудники сортируются в порядке:
    /// 2. Логин (по убыв.) - сначала сотрудники с созданными учетными записями
    /// 3. Ид (по возр.) - сначала сотрудники, созданные раньше.
    /// После сортировки Основным местом работы считается сотрудник, указанный первым в списке.
    /// </summary>
    /// <param name="personId">Идентификатор персоны.</param>
    /// <returns>Список сотрудников.</returns>
    private IOrderedQueryable<Sungero.Company.IEmployee> EmployeesByPersonId(long personId)
    {
      var employees = Sungero.Company.Employees.GetAll()
        .Where(w => w.Status == Sungero.Company.Employee.Status.Active)
        .Where(w => w.Person != null)
        .Where(w => w.Person.Id == personId)
        .OrderByDescending(e => e.Login)
        .ThenBy(e => e.Id);
      
      return employees;
    }

    /// <summary>
    /// Получить идентификаторы сотрудников указанной персоны.
    /// </summary>
    /// <param name="personId">Ид персоны.</param>
    /// <returns>Список идентификаторов сотрудников.
    /// Если у персоны нет совместителей, возвращется список из одного идентификатора.</returns>
    public virtual List<long> GetPersonEmployeeIds(long personId)
    {
      try
      {
        var employees = EmployeesByPersonId(personId);
        return employees.Select(p => p.Id).ToList();
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("HRWred.GetPersonEmployeeIds(). {0}", ex.Message);
        return new List<long>();
      }
    }
    #endregion
    
    #region Проверка принадлежности пользователя к роли.
    /// <summary>
    /// Проверить, что пользователь включен в роль Отвественный за выгрузку кадровых документов.
    /// </summary>
    /// <param name="users">Пользователи.</param>
    /// <returns>True, если один из пользователей входит в роль Отвественный за выгрузку кадровых документов.</returns>
    [Remote(IsPure = true), Public]
    public bool IsHRDocExportManager(List<IUser> users)
    {
      return this.IsIncludedInRole(users, HRWred.PublicConstants.Module.HRDocExportManager);
    }
    
    /// <summary>
    /// Проверить, что пользователь включен в роль.
    /// </summary>
    /// <param name="users">Пользователи.</param>
    /// <param name="roleGuid">Guid роли.</param>
    /// <returns>True, если один из пользователей входит в роль.</returns>
    [Public]
    public bool IsIncludedInRole(List<IUser> users, Guid roleGuid)
    {
      var role = Functions.Module.GetRole(roleGuid);
      
      if (role == null)
        return false;
      return users.Any(v => v.IncludedIn(role));
    }
    
    /// <summary>
    /// Получить роль.
    /// </summary>
    /// <param name="roleGuid">Guid роли.</param>
    /// <returns>Роль.</returns>
    [Public, Remote]
    public static IRole GetRole(Guid roleGuid)
    {
      return Roles.GetAll(r => r.Sid == roleGuid).FirstOrDefault();
    }
    #endregion
  }
}