namespace Sungero.ExchangeCore.Structures.BusinessUnitBox
{
  public partial class ExchangeProcessedDocument : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static ExchangeProcessedDocument Create()
    {
      return new ExchangeProcessedDocument();
    }

    public static ExchangeProcessedDocument Create(global::Sungero.Docflow.IOfficialDocument document, global::System.Nullable<global::System.Boolean> hasDocumentReadPermissions, global::System.Nullable<global::System.Int64> documentId, global::Sungero.Exchange.IExchangeDocumentInfo documentInfo)
    {
      return new ExchangeProcessedDocument
      {
        Document = document,
        HasDocumentReadPermissions = hasDocumentReadPermissions,
        DocumentId = documentId,
        DocumentInfo = documentInfo
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Document != null ? this.Document.GetHashCode() : 0) * 199) ^ ((this.HasDocumentReadPermissions != null ? this.HasDocumentReadPermissions.GetHashCode() : 0) * 199) ^ ((this.DocumentId != null ? this.DocumentId.GetHashCode() : 0) * 199) ^ ((this.DocumentInfo != null ? this.DocumentInfo.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExchangeProcessedDocument)obj);
    }

    public static bool operator ==(ExchangeProcessedDocument left, ExchangeProcessedDocument right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExchangeProcessedDocument left, ExchangeProcessedDocument right)
    {
      return !(left == right);
    }

    protected bool Equals(ExchangeProcessedDocument other)
    {
      return object.Equals(this.Document, other.Document) 
             && object.Equals(this.HasDocumentReadPermissions, other.HasDocumentReadPermissions) 
             && object.Equals(this.DocumentId, other.DocumentId) 
             && object.Equals(this.DocumentInfo, other.DocumentInfo) ;
    }

  }

  public partial class ExchangeDocumentsPackage : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static ExchangeDocumentsPackage Create()
    {
      return new ExchangeDocumentsPackage();
    }

    public static ExchangeDocumentsPackage Create(global::System.Collections.Generic.List<global::Sungero.ExchangeCore.Structures.BusinessUnitBox.ExchangeProcessedDocument> documents, global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IMessageQueueItem> messages)
    {
      return new ExchangeDocumentsPackage
      {
        Documents = documents,
        Messages = messages
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Documents != null ? this.Documents.GetHashCode() : 0) * 199) ^ ((this.Messages != null ? this.Messages.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExchangeDocumentsPackage)obj);
    }

    public static bool operator ==(ExchangeDocumentsPackage left, ExchangeDocumentsPackage right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExchangeDocumentsPackage left, ExchangeDocumentsPackage right)
    {
      return !(left == right);
    }

    protected bool Equals(ExchangeDocumentsPackage other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Documents, other.Documents)
             && global::System.Linq.Enumerable.SequenceEqual(this.Messages, other.Messages);
    }

  }
}