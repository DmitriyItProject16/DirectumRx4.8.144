namespace Sungero.Exchange.Structures.Module
{
  public partial class ReglamentDocumentWithCertificate : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static ReglamentDocumentWithCertificate Create()
    {
      return new ReglamentDocumentWithCertificate();
    }

    public static ReglamentDocumentWithCertificate Create(global::System.String name, global::System.Byte[] content, global::Sungero.CoreEntities.ICertificate certificate, global::System.Byte[] signature, global::System.String parentDocumentId, global::Sungero.ExchangeCore.IBusinessUnitBox box, global::Sungero.Docflow.IOfficialDocument linkedDocument, global::System.String serviceMessageId, global::System.String serviceDocumentId, global::System.String serviceDocumentStageId, global::System.String serviceCounterpartyId, global::System.Boolean isRootDocumentReceipt, global::Sungero.Exchange.IExchangeDocumentInfo info, global::System.Boolean isInvoiceFlow, global::System.Nullable<global::Sungero.Core.Enumeration> reglamentDocumentType, global::System.String formalizedPoAUnifiedRegNumber)
    {
      return new ReglamentDocumentWithCertificate
      {
        Name = name,
        Content = content,
        Certificate = certificate,
        Signature = signature,
        ParentDocumentId = parentDocumentId,
        Box = box,
        LinkedDocument = linkedDocument,
        ServiceMessageId = serviceMessageId,
        ServiceDocumentId = serviceDocumentId,
        ServiceDocumentStageId = serviceDocumentStageId,
        ServiceCounterpartyId = serviceCounterpartyId,
        IsRootDocumentReceipt = isRootDocumentReceipt,
        Info = info,
        IsInvoiceFlow = isInvoiceFlow,
        ReglamentDocumentType = reglamentDocumentType,
        FormalizedPoAUnifiedRegNumber = formalizedPoAUnifiedRegNumber
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Name != null ? this.Name.GetHashCode() : 0) * 199) ^ (this.Content.GetHashCode() * 199) ^ ((this.Certificate != null ? this.Certificate.GetHashCode() : 0) * 199) ^ (this.Signature.GetHashCode() * 199) ^ ((this.ParentDocumentId != null ? this.ParentDocumentId.GetHashCode() : 0) * 199) ^ ((this.Box != null ? this.Box.GetHashCode() : 0) * 199) ^ ((this.LinkedDocument != null ? this.LinkedDocument.GetHashCode() : 0) * 199) ^ ((this.ServiceMessageId != null ? this.ServiceMessageId.GetHashCode() : 0) * 199) ^ ((this.ServiceDocumentId != null ? this.ServiceDocumentId.GetHashCode() : 0) * 199) ^ ((this.ServiceDocumentStageId != null ? this.ServiceDocumentStageId.GetHashCode() : 0) * 199) ^ ((this.ServiceCounterpartyId != null ? this.ServiceCounterpartyId.GetHashCode() : 0) * 199) ^ (this.IsRootDocumentReceipt.GetHashCode() * 199) ^ ((this.Info != null ? this.Info.GetHashCode() : 0) * 199) ^ (this.IsInvoiceFlow.GetHashCode() * 199) ^ ((this.ReglamentDocumentType != null ? this.ReglamentDocumentType.GetHashCode() : 0) * 199) ^ ((this.FormalizedPoAUnifiedRegNumber != null ? this.FormalizedPoAUnifiedRegNumber.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ReglamentDocumentWithCertificate)obj);
    }

    public static bool operator ==(ReglamentDocumentWithCertificate left, ReglamentDocumentWithCertificate right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ReglamentDocumentWithCertificate left, ReglamentDocumentWithCertificate right)
    {
      return !(left == right);
    }

    protected bool Equals(ReglamentDocumentWithCertificate other)
    {
      return object.Equals(this.Name, other.Name) 
             && ArrayEqual(this.Content, other.Content)
             && object.Equals(this.Certificate, other.Certificate) 
             && ArrayEqual(this.Signature, other.Signature)
             && object.Equals(this.ParentDocumentId, other.ParentDocumentId) 
             && object.Equals(this.Box, other.Box) 
             && object.Equals(this.LinkedDocument, other.LinkedDocument) 
             && object.Equals(this.ServiceMessageId, other.ServiceMessageId) 
             && object.Equals(this.ServiceDocumentId, other.ServiceDocumentId) 
             && object.Equals(this.ServiceDocumentStageId, other.ServiceDocumentStageId) 
             && object.Equals(this.ServiceCounterpartyId, other.ServiceCounterpartyId) 
             && this.IsRootDocumentReceipt == other.IsRootDocumentReceipt
             && object.Equals(this.Info, other.Info) 
             && this.IsInvoiceFlow == other.IsInvoiceFlow
             && object.Equals(this.ReglamentDocumentType, other.ReglamentDocumentType) 
             && object.Equals(this.FormalizedPoAUnifiedRegNumber, other.FormalizedPoAUnifiedRegNumber) ;
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

  public partial class AddendumInfo : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static AddendumInfo Create()
    {
      return new AddendumInfo();
    }

    public static AddendumInfo Create(global::Sungero.Docflow.IOfficialDocument addendum, global::System.Boolean needRejectFirstVersion, global::System.Nullable<global::Sungero.Core.Enumeration> buyerAcceptanceStatus)
    {
      return new AddendumInfo
      {
        Addendum = addendum,
        NeedRejectFirstVersion = needRejectFirstVersion,
        BuyerAcceptanceStatus = buyerAcceptanceStatus
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Addendum != null ? this.Addendum.GetHashCode() : 0) * 199) ^ (this.NeedRejectFirstVersion.GetHashCode() * 199) ^ ((this.BuyerAcceptanceStatus != null ? this.BuyerAcceptanceStatus.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AddendumInfo)obj);
    }

    public static bool operator ==(AddendumInfo left, AddendumInfo right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AddendumInfo left, AddendumInfo right)
    {
      return !(left == right);
    }

    protected bool Equals(AddendumInfo other)
    {
      return object.Equals(this.Addendum, other.Addendum) 
             && this.NeedRejectFirstVersion == other.NeedRejectFirstVersion
             && object.Equals(this.BuyerAcceptanceStatus, other.BuyerAcceptanceStatus) ;
    }

  }

  public partial class SendToCounterpartyInfo : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static SendToCounterpartyInfo Create()
    {
      return new SendToCounterpartyInfo();
    }

    public static SendToCounterpartyInfo Create(global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox> boxes, global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> counterparties, global::System.Collections.Generic.List<global::Sungero.ExchangeCore.ICounterpartyDepartmentBox> counterpartyDepartments, global::Sungero.ExchangeCore.ICounterpartyDepartmentBox counterpartyDepartmentBox, global::Sungero.ExchangeCore.IBusinessUnitBox defaultBox, global::System.String parentDocumentId, global::Sungero.Parties.ICounterparty defaultCounterparty, global::Sungero.Exchange.Structures.Module.DocumentCertificatesInfo certificates, global::System.Collections.Generic.List<global::Sungero.Exchange.Structures.Module.AddendumInfo> addenda, global::System.Boolean hasAddendaToSend, global::System.String error, global::System.Boolean hasError, global::System.Boolean isSignedByUs, global::System.Boolean isSignedByCounterparty, global::System.Boolean answerIsSent, global::System.Boolean needRejectFirstVersion, global::System.Boolean hasApprovalSignature, global::System.Boolean canApprove, global::System.Boolean canSendSignAsAnswer, global::System.Boolean canSendAmendmentRequestAsAnswer, global::System.Boolean canSendInvoiceAmendmentRequestAsAnswer, global::System.Nullable<global::Sungero.Core.Enumeration> buyerAcceptanceStatus)
    {
      return new SendToCounterpartyInfo
      {
        Boxes = boxes,
        Counterparties = counterparties,
        CounterpartyDepartments = counterpartyDepartments,
        CounterpartyDepartmentBox = counterpartyDepartmentBox,
        DefaultBox = defaultBox,
        ParentDocumentId = parentDocumentId,
        DefaultCounterparty = defaultCounterparty,
        Certificates = certificates,
        Addenda = addenda,
        HasAddendaToSend = hasAddendaToSend,
        Error = error,
        HasError = hasError,
        IsSignedByUs = isSignedByUs,
        IsSignedByCounterparty = isSignedByCounterparty,
        AnswerIsSent = answerIsSent,
        NeedRejectFirstVersion = needRejectFirstVersion,
        HasApprovalSignature = hasApprovalSignature,
        CanApprove = canApprove,
        CanSendSignAsAnswer = canSendSignAsAnswer,
        CanSendAmendmentRequestAsAnswer = canSendAmendmentRequestAsAnswer,
        CanSendInvoiceAmendmentRequestAsAnswer = canSendInvoiceAmendmentRequestAsAnswer,
        BuyerAcceptanceStatus = buyerAcceptanceStatus
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Boxes != null ? this.Boxes.GetHashCode() : 0) * 199) ^ ((this.Counterparties != null ? this.Counterparties.GetHashCode() : 0) * 199) ^ ((this.CounterpartyDepartments != null ? this.CounterpartyDepartments.GetHashCode() : 0) * 199) ^ ((this.CounterpartyDepartmentBox != null ? this.CounterpartyDepartmentBox.GetHashCode() : 0) * 199) ^ ((this.DefaultBox != null ? this.DefaultBox.GetHashCode() : 0) * 199) ^ ((this.ParentDocumentId != null ? this.ParentDocumentId.GetHashCode() : 0) * 199) ^ ((this.DefaultCounterparty != null ? this.DefaultCounterparty.GetHashCode() : 0) * 199) ^ ((this.Certificates != null ? this.Certificates.GetHashCode() : 0) * 199) ^ ((this.Addenda != null ? this.Addenda.GetHashCode() : 0) * 199) ^ (this.HasAddendaToSend.GetHashCode() * 199) ^ ((this.Error != null ? this.Error.GetHashCode() : 0) * 199) ^ (this.HasError.GetHashCode() * 199) ^ (this.IsSignedByUs.GetHashCode() * 199) ^ (this.IsSignedByCounterparty.GetHashCode() * 199) ^ (this.AnswerIsSent.GetHashCode() * 199) ^ (this.NeedRejectFirstVersion.GetHashCode() * 199) ^ (this.HasApprovalSignature.GetHashCode() * 199) ^ (this.CanApprove.GetHashCode() * 199) ^ (this.CanSendSignAsAnswer.GetHashCode() * 199) ^ (this.CanSendAmendmentRequestAsAnswer.GetHashCode() * 199) ^ (this.CanSendInvoiceAmendmentRequestAsAnswer.GetHashCode() * 199) ^ ((this.BuyerAcceptanceStatus != null ? this.BuyerAcceptanceStatus.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SendToCounterpartyInfo)obj);
    }

    public static bool operator ==(SendToCounterpartyInfo left, SendToCounterpartyInfo right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SendToCounterpartyInfo left, SendToCounterpartyInfo right)
    {
      return !(left == right);
    }

    protected bool Equals(SendToCounterpartyInfo other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Boxes, other.Boxes)
             && global::System.Linq.Enumerable.SequenceEqual(this.Counterparties, other.Counterparties)
             && global::System.Linq.Enumerable.SequenceEqual(this.CounterpartyDepartments, other.CounterpartyDepartments)
             && object.Equals(this.CounterpartyDepartmentBox, other.CounterpartyDepartmentBox) 
             && object.Equals(this.DefaultBox, other.DefaultBox) 
             && object.Equals(this.ParentDocumentId, other.ParentDocumentId) 
             && object.Equals(this.DefaultCounterparty, other.DefaultCounterparty) 
             && object.Equals(this.Certificates, other.Certificates) 
             && global::System.Linq.Enumerable.SequenceEqual(this.Addenda, other.Addenda)
             && this.HasAddendaToSend == other.HasAddendaToSend
             && object.Equals(this.Error, other.Error) 
             && this.HasError == other.HasError
             && this.IsSignedByUs == other.IsSignedByUs
             && this.IsSignedByCounterparty == other.IsSignedByCounterparty
             && this.AnswerIsSent == other.AnswerIsSent
             && this.NeedRejectFirstVersion == other.NeedRejectFirstVersion
             && this.HasApprovalSignature == other.HasApprovalSignature
             && this.CanApprove == other.CanApprove
             && this.CanSendSignAsAnswer == other.CanSendSignAsAnswer
             && this.CanSendAmendmentRequestAsAnswer == other.CanSendAmendmentRequestAsAnswer
             && this.CanSendInvoiceAmendmentRequestAsAnswer == other.CanSendInvoiceAmendmentRequestAsAnswer
             && object.Equals(this.BuyerAcceptanceStatus, other.BuyerAcceptanceStatus) ;
    }

  }

  public partial class DocumentCertificatesInfo : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DocumentCertificatesInfo Create()
    {
      return new DocumentCertificatesInfo();
    }

    public static DocumentCertificatesInfo Create(global::System.Collections.Generic.List<global::Sungero.CoreEntities.ICertificate> certificates, global::System.Boolean canSign, global::System.Collections.Generic.List<global::Sungero.CoreEntities.ICertificate> myCertificates)
    {
      return new DocumentCertificatesInfo
      {
        Certificates = certificates,
        CanSign = canSign,
        MyCertificates = myCertificates
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Certificates != null ? this.Certificates.GetHashCode() : 0) * 199) ^ (this.CanSign.GetHashCode() * 199) ^ ((this.MyCertificates != null ? this.MyCertificates.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DocumentCertificatesInfo)obj);
    }

    public static bool operator ==(DocumentCertificatesInfo left, DocumentCertificatesInfo right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DocumentCertificatesInfo left, DocumentCertificatesInfo right)
    {
      return !(left == right);
    }

    protected bool Equals(DocumentCertificatesInfo other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Certificates, other.Certificates)
             && this.CanSign == other.CanSign
             && global::System.Linq.Enumerable.SequenceEqual(this.MyCertificates, other.MyCertificates);
    }

  }

  public partial class Certificate : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static Certificate Create()
    {
      return new Certificate();
    }

    public static Certificate Create(global::System.String thumbprint, global::Sungero.CoreEntities.IUser owner)
    {
      return new Certificate
      {
        Thumbprint = thumbprint,
        Owner = owner
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Thumbprint != null ? this.Thumbprint.GetHashCode() : 0) * 199) ^ ((this.Owner != null ? this.Owner.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Certificate)obj);
    }

    public static bool operator ==(Certificate left, Certificate right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(Certificate left, Certificate right)
    {
      return !(left == right);
    }

    protected bool Equals(Certificate other)
    {
      return object.Equals(this.Thumbprint, other.Thumbprint) 
             && object.Equals(this.Owner, other.Owner) ;
    }

  }

  public partial class FormalizedDocumentXML : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static FormalizedDocumentXML Create()
    {
      return new FormalizedDocumentXML();
    }

    public static FormalizedDocumentXML Create(global::System.String documentNumber, global::System.String documentDate, global::System.Boolean isAdjustment, global::System.String comment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Docflow.IContractualDocumentBase contract, global::Sungero.Docflow.IAccountingDocumentBase correctionRevisionParentDocument, global::System.String currencyCode, global::System.Double totalAmount, global::System.Boolean isRevision, global::System.Nullable<global::Sungero.Core.Enumeration> function)
    {
      return new FormalizedDocumentXML
      {
        DocumentNumber = documentNumber,
        DocumentDate = documentDate,
        IsAdjustment = isAdjustment,
        Comment = comment,
        Corrected = corrected,
        Contract = contract,
        CorrectionRevisionParentDocument = correctionRevisionParentDocument,
        CurrencyCode = currencyCode,
        TotalAmount = totalAmount,
        IsRevision = isRevision,
        Function = function
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.DocumentNumber != null ? this.DocumentNumber.GetHashCode() : 0) * 199) ^ ((this.DocumentDate != null ? this.DocumentDate.GetHashCode() : 0) * 199) ^ (this.IsAdjustment.GetHashCode() * 199) ^ ((this.Comment != null ? this.Comment.GetHashCode() : 0) * 199) ^ ((this.Corrected != null ? this.Corrected.GetHashCode() : 0) * 199) ^ ((this.Contract != null ? this.Contract.GetHashCode() : 0) * 199) ^ ((this.CorrectionRevisionParentDocument != null ? this.CorrectionRevisionParentDocument.GetHashCode() : 0) * 199) ^ ((this.CurrencyCode != null ? this.CurrencyCode.GetHashCode() : 0) * 199) ^ (this.TotalAmount.GetHashCode() * 199) ^ (this.IsRevision.GetHashCode() * 199) ^ ((this.Function != null ? this.Function.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((FormalizedDocumentXML)obj);
    }

    public static bool operator ==(FormalizedDocumentXML left, FormalizedDocumentXML right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(FormalizedDocumentXML left, FormalizedDocumentXML right)
    {
      return !(left == right);
    }

    protected bool Equals(FormalizedDocumentXML other)
    {
      return object.Equals(this.DocumentNumber, other.DocumentNumber) 
             && object.Equals(this.DocumentDate, other.DocumentDate) 
             && this.IsAdjustment == other.IsAdjustment
             && object.Equals(this.Comment, other.Comment) 
             && object.Equals(this.Corrected, other.Corrected) 
             && object.Equals(this.Contract, other.Contract) 
             && object.Equals(this.CorrectionRevisionParentDocument, other.CorrectionRevisionParentDocument) 
             && object.Equals(this.CurrencyCode, other.CurrencyCode) 
             && this.TotalAmount == other.TotalAmount
             && this.IsRevision == other.IsRevision
             && object.Equals(this.Function, other.Function) ;
    }

  }

  [global::System.Serializable]
  public partial class Signature : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static Signature Create()
    {
      return new Signature();
    }

    public static Signature Create(global::System.Byte[] body, global::System.Int64 id, global::System.String formalizedPoAUnifiedRegNumber)
    {
      return new Signature
      {
        Body = body,
        Id = id,
        FormalizedPoAUnifiedRegNumber = formalizedPoAUnifiedRegNumber
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Body.GetHashCode() * 199) ^ (this.Id.GetHashCode() * 199) ^ ((this.FormalizedPoAUnifiedRegNumber != null ? this.FormalizedPoAUnifiedRegNumber.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Signature)obj);
    }

    public static bool operator ==(Signature left, Signature right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(Signature left, Signature right)
    {
      return !(left == right);
    }

    protected bool Equals(Signature other)
    {
      return ArrayEqual(this.Body, other.Body)
             && this.Id == other.Id
             && object.Equals(this.FormalizedPoAUnifiedRegNumber, other.FormalizedPoAUnifiedRegNumber) ;
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
}