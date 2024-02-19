﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Company;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Shared;
using Sungero.Metadata;
using Sungero.SmartProcessing.VerificationTask;
using Sungero.Workflow;

namespace Sungero.SmartProcessing.Server
{
  partial class VerificationTaskRouteHandlers
  {

    public virtual void Script6Execute()
    {
      var documentIds = _obj.AllAttachments
        .Where(a => Docflow.OfficialDocuments.Is(a))
        .Select(a => Docflow.OfficialDocuments.As(a)).Distinct()
        .Cast<Docflow.IOfficialDocument>()
        .Where(d => d.VerificationState == Docflow.OfficialDocument.VerificationState.Completed)
        .Select(d => d.Id)
        .ToList();
      
      var assignmentIds = VerificationAssignments.GetAll()
        .Where(a => Equals(a.MainTask, _obj) && a.Status == Workflow.Assignment.Status.Completed)
        .Select(x => x.Id)
        .ToList();
      
      var repackingSessions = SmartProcessing.RepackingSessions.GetAll()
        .Where(x => x.AssignmentId.HasValue && assignmentIds.Contains(x.AssignmentId.Value))
        .ToList();
      
      // Выбор последних версий новых документов по всем сессиям перекомплектования.
      var documentWithVersionIds = new Dictionary<long, int>();
      var newDocumentIds = repackingSessions.SelectMany(x => x.NewDocuments.Select(d => d.DocumentId.Value)).ToList();
      foreach (var newDocumentId in newDocumentIds)
      {
        var document = Docflow.OfficialDocuments.GetAll(x => x.Id == newDocumentId && x.LifeCycleState != Docflow.OfficialDocument.LifeCycleState.Obsolete)
          .FirstOrDefault();
        
        if (document == null)
          continue;
        
        var version = repackingSessions.SelectMany(x => x.OriginalDocuments.Where(k => k.DocumentId == newDocumentId)).Max(x => x.ResultVersionNumber) ?? 1;
        if (document.Versions.Any(x => x.Number == version))
          documentWithVersionIds.Add(newDocumentId, version);
      }
      
      foreach (var documentWithVersion in documentWithVersionIds)
      {
        var recognitionInfo = Commons.EntityRecognitionInfos.Create();
        recognitionInfo.RecognizedClass = string.Empty;
        recognitionInfo.Name = string.Empty;
        recognitionInfo.EntityId = documentWithVersion.Key;
        recognitionInfo.EntityType = Docflow.OfficialDocuments.Get(documentWithVersion.Key).GetEntityMetadata().GetOriginal().NameGuid.ToString();
        recognitionInfo.VerifiedVersionNumber = documentWithVersion.Value;
        recognitionInfo.FirstPageClassifierTrainingStatus = Commons.EntityRecognitionInfo.FirstPageClassifierTrainingStatus.Awaiting;
        recognitionInfo.Save();
      }
    }

    public virtual void Script5Execute()
    {
      var documents = _obj.AllAttachments
        .Where(a => Sungero.Docflow.OfficialDocuments.Is(a))
        .Cast<Docflow.IOfficialDocument>()
        .Where(d => d.VerificationState == Docflow.OfficialDocument.VerificationState.Completed)
        .ToList();
      
      foreach (var document in documents)
        Docflow.PublicFunctions.OfficialDocument.StoreVerifiedPropertiesValues(document);
    }
    
    public virtual void Script4Execute()
    {
      // Если при верификации изменен тип документа, заполнить статус обучения классификатора в результате распознавания.
      var documents = _obj.AllAttachments.Where(a => Sungero.Docflow.OfficialDocuments.Is(a)).ToList();
      foreach (var document in documents)
      {
        var verifiedClass = SmartProcessing.Functions.Module.GetArioClassByEntityType(document);
        if (!string.IsNullOrEmpty(verifiedClass))
        {
          var entityRecognitionInfo = Sungero.Commons.PublicFunctions.EntityRecognitionInfo.Remote.GetEntityRecognitionInfo(document);
          if (entityRecognitionInfo != null &&
              entityRecognitionInfo.DocTypeClassifierTrainingStatus == null &&
              entityRecognitionInfo.RecognizedClass != verifiedClass)
          {
            entityRecognitionInfo.VerifiedClass = verifiedClass;
            entityRecognitionInfo.DocTypeClassifierTrainingStatus = Sungero.Commons.EntityRecognitionInfo.DocTypeClassifierTrainingStatus.Awaiting;
            entityRecognitionInfo.Save();
          }
        }
      }
    }

    public virtual void EndBlock3(Sungero.SmartProcessing.Server.VerificationAssignmentEndBlockEventArguments e)
    {
      // Перевести все документы комплекта в статус верификации "Завершена".
      var documentIds = _obj.AllAttachments
        .Where(a => Content.ElectronicDocuments.Is(a))
        .Select(a => Content.ElectronicDocuments.As(a)).Distinct()
        .Cast<Docflow.IOfficialDocument>()
        .Where(d => d.VerificationState == Docflow.OfficialDocument.VerificationState.InProcess)
        .Select(d => d.Id)
        .ToList();
      
      foreach (var documentId in documentIds)
      {
        var document = Docflow.OfficialDocuments.Get((long)documentId);
        if (document == null)
          continue;
        
        var hasEmptyRequiredProperties = Docflow.PublicFunctions.OfficialDocument.HasEmptyRequiredProperties(document);
        if (hasEmptyRequiredProperties)
        {
          Logger.DebugFormat(Resources.DocumentSkippedByReasonFormat(document.Id, Resources.RequiredPropertyIsEmpty));
          continue;
        }
        
        document.VerificationState = Docflow.OfficialDocument.VerificationState.Completed;
      }
    }

    public virtual void StartBlock3(Sungero.SmartProcessing.Server.VerificationAssignmentArguments e)
    {
      // Заполнить тему задачи.
      e.Block.Subject = _obj.AllAttachments.Count() > 1
        ? Sungero.SmartProcessing.VerificationTasks.Resources.PackageAssignmentSubjectFormatFormat(_obj.LeadingDocumentName)
        : Sungero.SmartProcessing.VerificationTasks.Resources.DocumentAssignmentSubjectFormatFormat(_obj.LeadingDocumentName);
      
      if (e.Block.Subject.Length > Tasks.Info.Properties.Subject.Length)
        e.Block.Subject = e.Block.Subject.Substring(0, Tasks.Info.Properties.Subject.Length);
      
      this.GrantAccessRights(_obj.Assignee, e);
      
      // Отправить запрос на подготовку предпросмотра для документов.
      Docflow.PublicFunctions.Module.PrepareAllAttachmentsPreviews(_obj);
      Functions.VerificationTask.PrepareAllAttachmentsRepackingPreviews(_obj);
    }

    public virtual void StartAssignment3(Sungero.SmartProcessing.IVerificationAssignment assignment, Sungero.SmartProcessing.Server.VerificationAssignmentArguments e)
    {
      if (_obj.Addressee != null)
        this.GrantAccessRights(_obj.Addressee, e);
      
      assignment.Deadline = _obj.Deadline;
    }
    
    public virtual void CompleteAssignment3(Sungero.SmartProcessing.IVerificationAssignment assignment, Sungero.SmartProcessing.Server.VerificationAssignmentArguments e)
    {
      if (assignment.Result == SmartProcessing.VerificationAssignment.Result.Forward)
      {
        _obj.Deadline = assignment.NewDeadline;
        assignment.Forward(assignment.Addressee, ForwardingLocation.Next, assignment.NewDeadline);
      }
    }
    
    /// <summary>
    /// Выдача прав исполнителю на задачу, ее вложения, и связанные с вложениями документы.
    /// </summary>
    /// <param name="performer">Исполнитель.</param>
    /// <param name="e">Аргументы.</param>
    public virtual void GrantAccessRights(IEmployee performer, Sungero.SmartProcessing.Server.VerificationAssignmentArguments e)
    {
      e.Block.Performers.Add(performer);
      
      // Выдать права на вложения исполнителю.
      foreach (var attachment in _obj.AllAttachments)
      {
        if (!attachment.AccessRights.IsGrantedDirectly(DefaultAccessRightsTypes.FullAccess, performer))
          attachment.AccessRights.Grant(performer, DefaultAccessRightsTypes.FullAccess);
        
        // Выдать права на связанные документы.
        if (Sungero.Docflow.OfficialDocuments.Is(attachment))
        {
          var attachedDocument = Sungero.Docflow.OfficialDocuments.As(attachment);
          var relatedDocuments = attachedDocument.Relations.GetRelatedFrom();
          foreach (var relatedDocument in relatedDocuments)
          {
            if (!relatedDocument.AccessRights.IsGrantedDirectly(DefaultAccessRightsTypes.Read, performer))
              relatedDocument.AccessRights.Grant(performer, DefaultAccessRightsTypes.Read);
          }
        }
      }
      
      // Выдать права на задачу.
      _obj.AccessRights.Grant(performer, DefaultAccessRightsTypes.Change);
    }
  }
}