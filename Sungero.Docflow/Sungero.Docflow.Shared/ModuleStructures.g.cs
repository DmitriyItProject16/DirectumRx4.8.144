namespace Sungero.Docflow.Structures.Module
{
  [global::System.Serializable]
  public partial class PerformerIds : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static PerformerIds Create()
    {
      return new PerformerIds();
    }

    public static PerformerIds Create(global::System.Int64 id)
    {
      return new PerformerIds
      {
        Id = id
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((PerformerIds)obj);
    }

    public static bool operator ==(PerformerIds left, PerformerIds right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(PerformerIds left, PerformerIds right)
    {
      return !(left == right);
    }

    protected bool Equals(PerformerIds other)
    {
      return this.Id == other.Id;
    }

  }

  [global::System.Serializable]
  public partial class MailSendingResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static MailSendingResult Create()
    {
      return new MailSendingResult();
    }

    public static MailSendingResult Create(global::System.Boolean isSuccess, global::System.Boolean anyMailSended)
    {
      return new MailSendingResult
      {
        IsSuccess = isSuccess,
        AnyMailSended = anyMailSended
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.IsSuccess.GetHashCode() * 199) ^ (this.AnyMailSended.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((MailSendingResult)obj);
    }

    public static bool operator ==(MailSendingResult left, MailSendingResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(MailSendingResult left, MailSendingResult right)
    {
      return !(left == right);
    }

    protected bool Equals(MailSendingResult other)
    {
      return this.IsSuccess == other.IsSuccess
             && this.AnyMailSended == other.AnyMailSended;
    }

  }

  [global::System.Serializable]
  public partial class EnvelopeReportTableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static EnvelopeReportTableLine Create()
    {
      return new EnvelopeReportTableLine();
    }

    public static EnvelopeReportTableLine Create(global::System.String reportSessionId, global::System.Int32 id, global::System.String toName, global::System.String fromName, global::System.String toZipCode, global::System.String fromZipCode, global::System.String toPlace, global::System.String fromPlace)
    {
      return new EnvelopeReportTableLine
      {
        ReportSessionId = reportSessionId,
        Id = id,
        ToName = toName,
        FromName = fromName,
        ToZipCode = toZipCode,
        FromZipCode = fromZipCode,
        ToPlace = toPlace,
        FromPlace = fromPlace
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ (this.Id.GetHashCode() * 199) ^ ((this.ToName != null ? this.ToName.GetHashCode() : 0) * 199) ^ ((this.FromName != null ? this.FromName.GetHashCode() : 0) * 199) ^ ((this.ToZipCode != null ? this.ToZipCode.GetHashCode() : 0) * 199) ^ ((this.FromZipCode != null ? this.FromZipCode.GetHashCode() : 0) * 199) ^ ((this.ToPlace != null ? this.ToPlace.GetHashCode() : 0) * 199) ^ ((this.FromPlace != null ? this.FromPlace.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((EnvelopeReportTableLine)obj);
    }

    public static bool operator ==(EnvelopeReportTableLine left, EnvelopeReportTableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(EnvelopeReportTableLine left, EnvelopeReportTableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(EnvelopeReportTableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && this.Id == other.Id
             && object.Equals(this.ToName, other.ToName) 
             && object.Equals(this.FromName, other.FromName) 
             && object.Equals(this.ToZipCode, other.ToZipCode) 
             && object.Equals(this.FromZipCode, other.FromZipCode) 
             && object.Equals(this.ToPlace, other.ToPlace) 
             && object.Equals(this.FromPlace, other.FromPlace) ;
    }

  }

  [global::System.Serializable]
  public partial class DefinedApprovalStages : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DefinedApprovalStages Create()
    {
      return new DefinedApprovalStages();
    }

    public static DefinedApprovalStages Create(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages, global::System.Boolean isConditionsDefined, global::System.String errorMessage)
    {
      return new DefinedApprovalStages
      {
        Stages = stages,
        IsConditionsDefined = isConditionsDefined,
        ErrorMessage = errorMessage
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Stages != null ? this.Stages.GetHashCode() : 0) * 199) ^ (this.IsConditionsDefined.GetHashCode() * 199) ^ ((this.ErrorMessage != null ? this.ErrorMessage.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DefinedApprovalStages)obj);
    }

    public static bool operator ==(DefinedApprovalStages left, DefinedApprovalStages right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DefinedApprovalStages left, DefinedApprovalStages right)
    {
      return !(left == right);
    }

    protected bool Equals(DefinedApprovalStages other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Stages, other.Stages)
             && this.IsConditionsDefined == other.IsConditionsDefined
             && object.Equals(this.ErrorMessage, other.ErrorMessage) ;
    }

  }

  public partial class DefinedApprovalStageLite : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DefinedApprovalStageLite Create()
    {
      return new DefinedApprovalStageLite();
    }

    public static DefinedApprovalStageLite Create(global::Sungero.Docflow.IApprovalStage stage, global::System.Nullable<global::System.Int32> number, global::System.Nullable<global::Sungero.Core.Enumeration> stageType)
    {
      return new DefinedApprovalStageLite
      {
        Stage = stage,
        Number = number,
        StageType = stageType
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Stage != null ? this.Stage.GetHashCode() : 0) * 199) ^ ((this.Number != null ? this.Number.GetHashCode() : 0) * 199) ^ ((this.StageType != null ? this.StageType.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DefinedApprovalStageLite)obj);
    }

    public static bool operator ==(DefinedApprovalStageLite left, DefinedApprovalStageLite right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DefinedApprovalStageLite left, DefinedApprovalStageLite right)
    {
      return !(left == right);
    }

    protected bool Equals(DefinedApprovalStageLite other)
    {
      return object.Equals(this.Stage, other.Stage) 
             && object.Equals(this.Number, other.Number) 
             && object.Equals(this.StageType, other.StageType) ;
    }

  }

  [global::System.Serializable]
  public partial class DefinedApprovalBaseStages : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DefinedApprovalBaseStages Create()
    {
      return new DefinedApprovalBaseStages();
    }

    public static DefinedApprovalBaseStages Create(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalBaseStageLite> baseStages, global::System.Boolean isConditionsDefined, global::System.String errorMessage)
    {
      return new DefinedApprovalBaseStages
      {
        BaseStages = baseStages,
        IsConditionsDefined = isConditionsDefined,
        ErrorMessage = errorMessage
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.BaseStages != null ? this.BaseStages.GetHashCode() : 0) * 199) ^ (this.IsConditionsDefined.GetHashCode() * 199) ^ ((this.ErrorMessage != null ? this.ErrorMessage.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DefinedApprovalBaseStages)obj);
    }

    public static bool operator ==(DefinedApprovalBaseStages left, DefinedApprovalBaseStages right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DefinedApprovalBaseStages left, DefinedApprovalBaseStages right)
    {
      return !(left == right);
    }

    protected bool Equals(DefinedApprovalBaseStages other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.BaseStages, other.BaseStages)
             && this.IsConditionsDefined == other.IsConditionsDefined
             && object.Equals(this.ErrorMessage, other.ErrorMessage) ;
    }

  }

  public partial class DefinedApprovalBaseStageLite : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DefinedApprovalBaseStageLite Create()
    {
      return new DefinedApprovalBaseStageLite();
    }

    public static DefinedApprovalBaseStageLite Create(global::Sungero.Docflow.IApprovalStageBase stageBase, global::System.Nullable<global::System.Int32> number, global::System.Nullable<global::Sungero.Core.Enumeration> stageType)
    {
      return new DefinedApprovalBaseStageLite
      {
        StageBase = stageBase,
        Number = number,
        StageType = stageType
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.StageBase != null ? this.StageBase.GetHashCode() : 0) * 199) ^ ((this.Number != null ? this.Number.GetHashCode() : 0) * 199) ^ ((this.StageType != null ? this.StageType.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DefinedApprovalBaseStageLite)obj);
    }

    public static bool operator ==(DefinedApprovalBaseStageLite left, DefinedApprovalBaseStageLite right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DefinedApprovalBaseStageLite left, DefinedApprovalBaseStageLite right)
    {
      return !(left == right);
    }

    protected bool Equals(DefinedApprovalBaseStageLite other)
    {
      return object.Equals(this.StageBase, other.StageBase) 
             && object.Equals(this.Number, other.Number) 
             && object.Equals(this.StageType, other.StageType) ;
    }

  }

  public partial class AddresseeAndSender : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static AddresseeAndSender Create()
    {
      return new AddresseeAndSender();
    }

    public static AddresseeAndSender Create(global::Sungero.Parties.ICounterparty addresse, global::Sungero.Company.IBusinessUnit sender)
    {
      return new AddresseeAndSender
      {
        Addresse = addresse,
        Sender = sender
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Addresse != null ? this.Addresse.GetHashCode() : 0) * 199) ^ ((this.Sender != null ? this.Sender.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AddresseeAndSender)obj);
    }

    public static bool operator ==(AddresseeAndSender left, AddresseeAndSender right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AddresseeAndSender left, AddresseeAndSender right)
    {
      return !(left == right);
    }

    protected bool Equals(AddresseeAndSender other)
    {
      return object.Equals(this.Addresse, other.Addresse) 
             && object.Equals(this.Sender, other.Sender) ;
    }

  }

  [global::System.Serializable]
  public partial class ZipCodeAndAddress : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ZipCodeAndAddress Create()
    {
      return new ZipCodeAndAddress();
    }

    public static ZipCodeAndAddress Create(global::System.String zipCode, global::System.String address)
    {
      return new ZipCodeAndAddress
      {
        ZipCode = zipCode,
        Address = address
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ZipCode != null ? this.ZipCode.GetHashCode() : 0) * 199) ^ ((this.Address != null ? this.Address.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ZipCodeAndAddress)obj);
    }

    public static bool operator ==(ZipCodeAndAddress left, ZipCodeAndAddress right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ZipCodeAndAddress left, ZipCodeAndAddress right)
    {
      return !(left == right);
    }

    protected bool Equals(ZipCodeAndAddress other)
    {
      return object.Equals(this.ZipCode, other.ZipCode) 
             && object.Equals(this.Address, other.Address) ;
    }

  }

  [global::System.Serializable]
  public partial class TaskIterations : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TaskIterations Create()
    {
      return new TaskIterations();
    }

    public static TaskIterations Create(global::System.DateTime date, global::System.Boolean isRework, global::System.Boolean isRestart)
    {
      return new TaskIterations
      {
        Date = date,
        IsRework = isRework,
        IsRestart = isRestart
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Date != null ? this.Date.GetHashCode() : 0) * 199) ^ (this.IsRework.GetHashCode() * 199) ^ (this.IsRestart.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((TaskIterations)obj);
    }

    public static bool operator ==(TaskIterations left, TaskIterations right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(TaskIterations left, TaskIterations right)
    {
      return !(left == right);
    }

    protected bool Equals(TaskIterations other)
    {
      return object.Equals(this.Date, other.Date) 
             && this.IsRework == other.IsRework
             && this.IsRestart == other.IsRestart;
    }

  }

  [global::System.Serializable]
  public partial class DocumentToSetStorage : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DocumentToSetStorage Create()
    {
      return new DocumentToSetStorage();
    }

    public static DocumentToSetStorage Create(global::System.Int64 documentId, global::System.Int64 storageId)
    {
      return new DocumentToSetStorage
      {
        DocumentId = documentId,
        StorageId = storageId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.DocumentId.GetHashCode() * 199) ^ (this.StorageId.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DocumentToSetStorage)obj);
    }

    public static bool operator ==(DocumentToSetStorage left, DocumentToSetStorage right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DocumentToSetStorage left, DocumentToSetStorage right)
    {
      return !(left == right);
    }

    protected bool Equals(DocumentToSetStorage other)
    {
      return this.DocumentId == other.DocumentId
             && this.StorageId == other.StorageId;
    }

  }

  [global::System.Serializable]
  public partial class ExportReport : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportReport Create()
    {
      return new ExportReport();
    }

    public static ExportReport Create(global::System.String reportSessionId, global::System.String document, global::System.String hyperlink, global::System.Int64 id, global::System.String exported, global::System.String note, global::System.String iOHyperlink, global::System.Int64 orderId)
    {
      return new ExportReport
      {
        ReportSessionId = reportSessionId,
        Document = document,
        Hyperlink = hyperlink,
        Id = id,
        Exported = exported,
        Note = note,
        IOHyperlink = iOHyperlink,
        OrderId = orderId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ ((this.Document != null ? this.Document.GetHashCode() : 0) * 199) ^ ((this.Hyperlink != null ? this.Hyperlink.GetHashCode() : 0) * 199) ^ (this.Id.GetHashCode() * 199) ^ ((this.Exported != null ? this.Exported.GetHashCode() : 0) * 199) ^ ((this.Note != null ? this.Note.GetHashCode() : 0) * 199) ^ ((this.IOHyperlink != null ? this.IOHyperlink.GetHashCode() : 0) * 199) ^ (this.OrderId.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportReport)obj);
    }

    public static bool operator ==(ExportReport left, ExportReport right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportReport left, ExportReport right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportReport other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && object.Equals(this.Document, other.Document) 
             && object.Equals(this.Hyperlink, other.Hyperlink) 
             && this.Id == other.Id
             && object.Equals(this.Exported, other.Exported) 
             && object.Equals(this.Note, other.Note) 
             && object.Equals(this.IOHyperlink, other.IOHyperlink) 
             && this.OrderId == other.OrderId;
    }

  }

  [global::System.Serializable]
  public partial class ExportDialogParams : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportDialogParams Create()
    {
      return new ExportDialogParams();
    }

    public static ExportDialogParams Create(global::System.Boolean groupCounterparty, global::System.Boolean groupDocumentType, global::System.Boolean forPrint, global::System.Boolean isSingleExport, global::System.Boolean addAddendum)
    {
      return new ExportDialogParams
      {
        GroupCounterparty = groupCounterparty,
        GroupDocumentType = groupDocumentType,
        ForPrint = forPrint,
        IsSingleExport = isSingleExport,
        AddAddendum = addAddendum
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.GroupCounterparty.GetHashCode() * 199) ^ (this.GroupDocumentType.GetHashCode() * 199) ^ (this.ForPrint.GetHashCode() * 199) ^ (this.IsSingleExport.GetHashCode() * 199) ^ (this.AddAddendum.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportDialogParams)obj);
    }

    public static bool operator ==(ExportDialogParams left, ExportDialogParams right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportDialogParams left, ExportDialogParams right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportDialogParams other)
    {
      return this.GroupCounterparty == other.GroupCounterparty
             && this.GroupDocumentType == other.GroupDocumentType
             && this.ForPrint == other.ForPrint
             && this.IsSingleExport == other.IsSingleExport
             && this.AddAddendum == other.AddAddendum;
    }

  }

  [global::System.Serializable]
  public partial class AfterExportDialog : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AfterExportDialog Create()
    {
      return new AfterExportDialog();
    }

    public static AfterExportDialog Create(global::System.String rootFolder, global::System.String pathToRoot, global::System.Nullable<global::System.DateTime> dateTime, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.ExportedDocument> documents)
    {
      return new AfterExportDialog
      {
        RootFolder = rootFolder,
        PathToRoot = pathToRoot,
        DateTime = dateTime,
        Documents = documents
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.RootFolder != null ? this.RootFolder.GetHashCode() : 0) * 199) ^ ((this.PathToRoot != null ? this.PathToRoot.GetHashCode() : 0) * 199) ^ ((this.DateTime != null ? this.DateTime.GetHashCode() : 0) * 199) ^ ((this.Documents != null ? this.Documents.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AfterExportDialog)obj);
    }

    public static bool operator ==(AfterExportDialog left, AfterExportDialog right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AfterExportDialog left, AfterExportDialog right)
    {
      return !(left == right);
    }

    protected bool Equals(AfterExportDialog other)
    {
      return object.Equals(this.RootFolder, other.RootFolder) 
             && object.Equals(this.PathToRoot, other.PathToRoot) 
             && object.Equals(this.DateTime, other.DateTime) 
             && global::System.Linq.Enumerable.SequenceEqual(this.Documents, other.Documents);
    }

  }

  [global::System.Serializable]
  public partial class ExportedDocument : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportedDocument Create()
    {
      return new ExportedDocument();
    }

    public static ExportedDocument Create(global::System.Int64 id, global::System.Boolean isFormalized, global::System.Boolean isAddendum, global::System.String parentShortName, global::System.Boolean isFaulted, global::System.Boolean isPrint, global::System.String error, global::Sungero.Docflow.Structures.Module.ExportedFolder folder, global::System.String name, global::System.Nullable<global::System.Int64> leadDocumentId, global::System.Boolean isSingleExport)
    {
      return new ExportedDocument
      {
        Id = id,
        IsFormalized = isFormalized,
        IsAddendum = isAddendum,
        ParentShortName = parentShortName,
        IsFaulted = isFaulted,
        IsPrint = isPrint,
        Error = error,
        Folder = folder,
        Name = name,
        LeadDocumentId = leadDocumentId,
        IsSingleExport = isSingleExport
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ (this.IsFormalized.GetHashCode() * 199) ^ (this.IsAddendum.GetHashCode() * 199) ^ ((this.ParentShortName != null ? this.ParentShortName.GetHashCode() : 0) * 199) ^ (this.IsFaulted.GetHashCode() * 199) ^ (this.IsPrint.GetHashCode() * 199) ^ ((this.Error != null ? this.Error.GetHashCode() : 0) * 199) ^ ((this.Folder != null ? this.Folder.GetHashCode() : 0) * 199) ^ ((this.Name != null ? this.Name.GetHashCode() : 0) * 199) ^ ((this.LeadDocumentId != null ? this.LeadDocumentId.GetHashCode() : 0) * 199) ^ (this.IsSingleExport.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportedDocument)obj);
    }

    public static bool operator ==(ExportedDocument left, ExportedDocument right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportedDocument left, ExportedDocument right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportedDocument other)
    {
      return this.Id == other.Id
             && this.IsFormalized == other.IsFormalized
             && this.IsAddendum == other.IsAddendum
             && object.Equals(this.ParentShortName, other.ParentShortName) 
             && this.IsFaulted == other.IsFaulted
             && this.IsPrint == other.IsPrint
             && object.Equals(this.Error, other.Error) 
             && object.Equals(this.Folder, other.Folder) 
             && object.Equals(this.Name, other.Name) 
             && object.Equals(this.LeadDocumentId, other.LeadDocumentId) 
             && this.IsSingleExport == other.IsSingleExport;
    }

  }

  [global::System.Serializable]
  public partial class ExportResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportResult Create()
    {
      return new ExportResult();
    }

    public static ExportResult Create(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.ExportedDocument> exportedDocuments, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.ZipModel> zipModels)
    {
      return new ExportResult
      {
        ExportedDocuments = exportedDocuments,
        ZipModels = zipModels
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ExportedDocuments != null ? this.ExportedDocuments.GetHashCode() : 0) * 199) ^ ((this.ZipModels != null ? this.ZipModels.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportResult)obj);
    }

    public static bool operator ==(ExportResult left, ExportResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportResult left, ExportResult right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportResult other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.ExportedDocuments, other.ExportedDocuments)
             && global::System.Linq.Enumerable.SequenceEqual(this.ZipModels, other.ZipModels);
    }

  }

  [global::System.Serializable]
  public partial class ExportedFolder : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportedFolder Create()
    {
      return new ExportedFolder();
    }

    public static ExportedFolder Create(global::System.String folderName, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.ExportedFile> files, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.ExportedFolder> folders, global::System.String parentRelativePath)
    {
      return new ExportedFolder
      {
        FolderName = folderName,
        Files = files,
        Folders = folders,
        ParentRelativePath = parentRelativePath
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.FolderName != null ? this.FolderName.GetHashCode() : 0) * 199) ^ ((this.Files != null ? this.Files.GetHashCode() : 0) * 199) ^ ((this.Folders != null ? this.Folders.GetHashCode() : 0) * 199) ^ ((this.ParentRelativePath != null ? this.ParentRelativePath.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportedFolder)obj);
    }

    public static bool operator ==(ExportedFolder left, ExportedFolder right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportedFolder left, ExportedFolder right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportedFolder other)
    {
      return object.Equals(this.FolderName, other.FolderName) 
             && global::System.Linq.Enumerable.SequenceEqual(this.Files, other.Files)
             && global::System.Linq.Enumerable.SequenceEqual(this.Folders, other.Folders)
             && object.Equals(this.ParentRelativePath, other.ParentRelativePath) ;
    }

  }

  [global::System.Serializable]
  public partial class ExportedFile : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportedFile Create()
    {
      return new ExportedFile();
    }

    public static ExportedFile Create(global::System.Int64 id, global::System.String fileName, global::System.Byte[] body, global::System.String servicePath, global::System.String token)
    {
      return new ExportedFile
      {
        Id = id,
        FileName = fileName,
        Body = body,
        ServicePath = servicePath,
        Token = token
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.FileName != null ? this.FileName.GetHashCode() : 0) * 199) ^ (this.Body.GetHashCode() * 199) ^ ((this.ServicePath != null ? this.ServicePath.GetHashCode() : 0) * 199) ^ ((this.Token != null ? this.Token.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportedFile)obj);
    }

    public static bool operator ==(ExportedFile left, ExportedFile right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportedFile left, ExportedFile right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportedFile other)
    {
      return this.Id == other.Id
             && object.Equals(this.FileName, other.FileName) 
             && ArrayEqual(this.Body, other.Body)
             && object.Equals(this.ServicePath, other.ServicePath) 
             && object.Equals(this.Token, other.Token) ;
    }

    private static bool ArrayEqual<TSource>(global::System.Collections.Generic.IEnumerable<TSource> left, global::System.Collections.Generic.IEnumerable<TSource> right)
    {
      if (ReferenceEquals(left, right))
        return true;
      if (ReferenceEquals(null, left))
        return false;
      if (ReferenceEquals(null, right))
        return false;
      if (global::System.Linq.Enumerable.Count(left) != global::System.Linq.Enumerable.Count(right))
        return false;

      return global::System.Linq.Enumerable.SequenceEqual(left, right);
    }
  }

  [global::System.Serializable]
  public partial class ZipModel : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ZipModel Create()
    {
      return new ZipModel();
    }

    public static ZipModel Create(global::System.Int64 documentId, global::System.Int64 versionId, global::System.Boolean isPublicBody, global::System.String fileName, global::System.Collections.Generic.List<global::System.String> folderRelativePath, global::System.Nullable<global::System.Int64> signatureId, global::System.Int64 size)
    {
      return new ZipModel
      {
        DocumentId = documentId,
        VersionId = versionId,
        IsPublicBody = isPublicBody,
        FileName = fileName,
        FolderRelativePath = folderRelativePath,
        SignatureId = signatureId,
        Size = size
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.DocumentId.GetHashCode() * 199) ^ (this.VersionId.GetHashCode() * 199) ^ (this.IsPublicBody.GetHashCode() * 199) ^ ((this.FileName != null ? this.FileName.GetHashCode() : 0) * 199) ^ ((this.FolderRelativePath != null ? this.FolderRelativePath.GetHashCode() : 0) * 199) ^ ((this.SignatureId != null ? this.SignatureId.GetHashCode() : 0) * 199) ^ (this.Size.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ZipModel)obj);
    }

    public static bool operator ==(ZipModel left, ZipModel right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ZipModel left, ZipModel right)
    {
      return !(left == right);
    }

    protected bool Equals(ZipModel other)
    {
      return this.DocumentId == other.DocumentId
             && this.VersionId == other.VersionId
             && this.IsPublicBody == other.IsPublicBody
             && object.Equals(this.FileName, other.FileName) 
             && global::System.Linq.Enumerable.SequenceEqual(this.FolderRelativePath, other.FolderRelativePath)
             && object.Equals(this.SignatureId, other.SignatureId) 
             && this.Size == other.Size;
    }

  }

  [global::System.Serializable]
  public partial class DateTimePeriod : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DateTimePeriod Create()
    {
      return new DateTimePeriod();
    }

    public static DateTimePeriod Create(global::System.DateTime dateFrom, global::System.DateTime dateTo)
    {
      return new DateTimePeriod
      {
        DateFrom = dateFrom,
        DateTo = dateTo
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.DateFrom != null ? this.DateFrom.GetHashCode() : 0) * 199) ^ ((this.DateTo != null ? this.DateTo.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DateTimePeriod)obj);
    }

    public static bool operator ==(DateTimePeriod left, DateTimePeriod right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DateTimePeriod left, DateTimePeriod right)
    {
      return !(left == right);
    }

    protected bool Equals(DateTimePeriod other)
    {
      return object.Equals(this.DateFrom, other.DateFrom) 
             && object.Equals(this.DateTo, other.DateTo) ;
    }

  }

  [global::System.Serializable]
  public partial class DatabooksWithNullCode : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DatabooksWithNullCode Create()
    {
      return new DatabooksWithNullCode();
    }

    public static DatabooksWithNullCode Create(global::System.Boolean hasDepartmentWithNullCode, global::System.Boolean hasBusinessUnitWithNullCode, global::System.Boolean hasDocumentKindWithNullCode)
    {
      return new DatabooksWithNullCode
      {
        HasDepartmentWithNullCode = hasDepartmentWithNullCode,
        HasBusinessUnitWithNullCode = hasBusinessUnitWithNullCode,
        HasDocumentKindWithNullCode = hasDocumentKindWithNullCode
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.HasDepartmentWithNullCode.GetHashCode() * 199) ^ (this.HasBusinessUnitWithNullCode.GetHashCode() * 199) ^ (this.HasDocumentKindWithNullCode.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DatabooksWithNullCode)obj);
    }

    public static bool operator ==(DatabooksWithNullCode left, DatabooksWithNullCode right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DatabooksWithNullCode left, DatabooksWithNullCode right)
    {
      return !(left == right);
    }

    protected bool Equals(DatabooksWithNullCode other)
    {
      return this.HasDepartmentWithNullCode == other.HasDepartmentWithNullCode
             && this.HasBusinessUnitWithNullCode == other.HasBusinessUnitWithNullCode
             && this.HasDocumentKindWithNullCode == other.HasDocumentKindWithNullCode;
    }

  }

  [global::System.Serializable]
  public partial class AttachmentHistoryEntry : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AttachmentHistoryEntry Create()
    {
      return new AttachmentHistoryEntry();
    }

    public static AttachmentHistoryEntry Create(global::System.DateTime date, global::System.Int64 documentId, global::System.Guid groupId, global::System.Nullable<global::Sungero.Core.Enumeration> operationType)
    {
      return new AttachmentHistoryEntry
      {
        Date = date,
        DocumentId = documentId,
        GroupId = groupId,
        OperationType = operationType
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Date != null ? this.Date.GetHashCode() : 0) * 199) ^ (this.DocumentId.GetHashCode() * 199) ^ ((this.GroupId != null ? this.GroupId.GetHashCode() : 0) * 199) ^ ((this.OperationType != null ? this.OperationType.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AttachmentHistoryEntry)obj);
    }

    public static bool operator ==(AttachmentHistoryEntry left, AttachmentHistoryEntry right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AttachmentHistoryEntry left, AttachmentHistoryEntry right)
    {
      return !(left == right);
    }

    protected bool Equals(AttachmentHistoryEntry other)
    {
      return object.Equals(this.Date, other.Date) 
             && this.DocumentId == other.DocumentId
             && object.Equals(this.GroupId, other.GroupId) 
             && object.Equals(this.OperationType, other.OperationType) ;
    }

  }

  [global::System.Serializable]
  public partial class AttachmentHistoryEntries : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AttachmentHistoryEntries Create()
    {
      return new AttachmentHistoryEntries();
    }

    public static AttachmentHistoryEntries Create(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.AttachmentHistoryEntry> added, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.AttachmentHistoryEntry> removed)
    {
      return new AttachmentHistoryEntries
      {
        Added = added,
        Removed = removed
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Added != null ? this.Added.GetHashCode() : 0) * 199) ^ ((this.Removed != null ? this.Removed.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AttachmentHistoryEntries)obj);
    }

    public static bool operator ==(AttachmentHistoryEntries left, AttachmentHistoryEntries right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AttachmentHistoryEntries left, AttachmentHistoryEntries right)
    {
      return !(left == right);
    }

    protected bool Equals(AttachmentHistoryEntries other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Added, other.Added)
             && global::System.Linq.Enumerable.SequenceEqual(this.Removed, other.Removed);
    }

  }

  [global::System.Serializable]
  public partial class LightAssignment : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static LightAssignment Create()
    {
      return new LightAssignment();
    }

    public static LightAssignment Create(global::System.Int64 assignmentId, global::System.Int64 performer, global::System.Int64 department, global::System.Nullable<global::System.DateTime> created, global::System.Nullable<global::System.DateTime> deadline, global::System.Nullable<global::System.DateTime> completed, global::System.Boolean isCompleted, global::System.Boolean isCompletedInPeriod, global::System.Int32 delayInPeriod, global::System.Boolean affectDiscipline)
    {
      return new LightAssignment
      {
        AssignmentId = assignmentId,
        Performer = performer,
        Department = department,
        Created = created,
        Deadline = deadline,
        Completed = completed,
        IsCompleted = isCompleted,
        IsCompletedInPeriod = isCompletedInPeriod,
        DelayInPeriod = delayInPeriod,
        AffectDiscipline = affectDiscipline
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.AssignmentId.GetHashCode() * 199) ^ (this.Performer.GetHashCode() * 199) ^ (this.Department.GetHashCode() * 199) ^ ((this.Created != null ? this.Created.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Completed != null ? this.Completed.GetHashCode() : 0) * 199) ^ (this.IsCompleted.GetHashCode() * 199) ^ (this.IsCompletedInPeriod.GetHashCode() * 199) ^ (this.DelayInPeriod.GetHashCode() * 199) ^ (this.AffectDiscipline.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LightAssignment)obj);
    }

    public static bool operator ==(LightAssignment left, LightAssignment right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LightAssignment left, LightAssignment right)
    {
      return !(left == right);
    }

    protected bool Equals(LightAssignment other)
    {
      return this.AssignmentId == other.AssignmentId
             && this.Performer == other.Performer
             && this.Department == other.Department
             && object.Equals(this.Created, other.Created) 
             && object.Equals(this.Deadline, other.Deadline) 
             && object.Equals(this.Completed, other.Completed) 
             && this.IsCompleted == other.IsCompleted
             && this.IsCompletedInPeriod == other.IsCompletedInPeriod
             && this.DelayInPeriod == other.DelayInPeriod
             && this.AffectDiscipline == other.AffectDiscipline;
    }

  }

  [global::System.Serializable]
  public partial class AssignmentStatistic : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AssignmentStatistic Create()
    {
      return new AssignmentStatistic();
    }

    public static AssignmentStatistic Create(global::System.Int32 totalAssignmentCount, global::System.Int32 overdueCount, global::System.Int32 completedCount, global::System.Int32 completedInTimeCount, global::System.Int32 overdueCompletedCount, global::System.Int32 inWorkCount, global::System.Int32 overdueInWorkCount, global::System.Int32 affectAssignmentCount)
    {
      return new AssignmentStatistic
      {
        TotalAssignmentCount = totalAssignmentCount,
        OverdueCount = overdueCount,
        CompletedCount = completedCount,
        CompletedInTimeCount = completedInTimeCount,
        OverdueCompletedCount = overdueCompletedCount,
        InWorkCount = inWorkCount,
        OverdueInWorkCount = overdueInWorkCount,
        AffectAssignmentCount = affectAssignmentCount
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.TotalAssignmentCount.GetHashCode() * 199) ^ (this.OverdueCount.GetHashCode() * 199) ^ (this.CompletedCount.GetHashCode() * 199) ^ (this.CompletedInTimeCount.GetHashCode() * 199) ^ (this.OverdueCompletedCount.GetHashCode() * 199) ^ (this.InWorkCount.GetHashCode() * 199) ^ (this.OverdueInWorkCount.GetHashCode() * 199) ^ (this.AffectAssignmentCount.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AssignmentStatistic)obj);
    }

    public static bool operator ==(AssignmentStatistic left, AssignmentStatistic right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AssignmentStatistic left, AssignmentStatistic right)
    {
      return !(left == right);
    }

    protected bool Equals(AssignmentStatistic other)
    {
      return this.TotalAssignmentCount == other.TotalAssignmentCount
             && this.OverdueCount == other.OverdueCount
             && this.CompletedCount == other.CompletedCount
             && this.CompletedInTimeCount == other.CompletedInTimeCount
             && this.OverdueCompletedCount == other.OverdueCompletedCount
             && this.InWorkCount == other.InWorkCount
             && this.OverdueInWorkCount == other.OverdueInWorkCount
             && this.AffectAssignmentCount == other.AffectAssignmentCount;
    }

  }

  [global::System.Serializable]
  public partial class LightAssignmentFilter : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static LightAssignmentFilter Create()
    {
      return new LightAssignmentFilter();
    }

    public static LightAssignmentFilter Create(global::System.Collections.Generic.List<global::System.Int64> performerIds, global::System.Boolean needFilter)
    {
      return new LightAssignmentFilter
      {
        PerformerIds = performerIds,
        NeedFilter = needFilter
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.PerformerIds != null ? this.PerformerIds.GetHashCode() : 0) * 199) ^ (this.NeedFilter.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LightAssignmentFilter)obj);
    }

    public static bool operator ==(LightAssignmentFilter left, LightAssignmentFilter right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LightAssignmentFilter left, LightAssignmentFilter right)
    {
      return !(left == right);
    }

    protected bool Equals(LightAssignmentFilter other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.PerformerIds, other.PerformerIds)
             && this.NeedFilter == other.NeedFilter;
    }

  }

  [global::System.Serializable]
  public partial class DocumentSignature : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DocumentSignature Create()
    {
      return new DocumentSignature();
    }

    public static DocumentSignature Create(global::System.Int64 signatureId, global::System.DateTime signingDate, global::System.Nullable<global::System.Int32> versionNumber)
    {
      return new DocumentSignature
      {
        SignatureId = signatureId,
        SigningDate = signingDate,
        VersionNumber = versionNumber
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.SignatureId.GetHashCode() * 199) ^ ((this.SigningDate != null ? this.SigningDate.GetHashCode() : 0) * 199) ^ ((this.VersionNumber != null ? this.VersionNumber.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DocumentSignature)obj);
    }

    public static bool operator ==(DocumentSignature left, DocumentSignature right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DocumentSignature left, DocumentSignature right)
    {
      return !(left == right);
    }

    protected bool Equals(DocumentSignature other)
    {
      return this.SignatureId == other.SignatureId
             && object.Equals(this.SigningDate, other.SigningDate) 
             && object.Equals(this.VersionNumber, other.VersionNumber) ;
    }

  }

  public partial class SignaturesInfo : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static SignaturesInfo Create()
    {
      return new SignaturesInfo();
    }

    public static SignaturesInfo Create(global::Sungero.CoreEntities.IUser signatory, global::Sungero.CoreEntities.IUser substitutedUser, global::System.String signatoryType)
    {
      return new SignaturesInfo
      {
        Signatory = signatory,
        SubstitutedUser = substitutedUser,
        SignatoryType = signatoryType
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Signatory != null ? this.Signatory.GetHashCode() : 0) * 199) ^ ((this.SubstitutedUser != null ? this.SubstitutedUser.GetHashCode() : 0) * 199) ^ ((this.SignatoryType != null ? this.SignatoryType.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SignaturesInfo)obj);
    }

    public static bool operator ==(SignaturesInfo left, SignaturesInfo right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SignaturesInfo left, SignaturesInfo right)
    {
      return !(left == right);
    }

    protected bool Equals(SignaturesInfo other)
    {
      return object.Equals(this.Signatory, other.Signatory) 
             && object.Equals(this.SubstitutedUser, other.SubstitutedUser) 
             && object.Equals(this.SignatoryType, other.SignatoryType) ;
    }

  }
}