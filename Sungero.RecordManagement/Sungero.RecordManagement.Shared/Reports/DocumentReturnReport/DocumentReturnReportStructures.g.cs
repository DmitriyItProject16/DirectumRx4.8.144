namespace Sungero.RecordManagement.Structures.DocumentReturnReport
{
  [global::System.Serializable]
  public partial class DocumentReturnTableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DocumentReturnTableLine Create()
    {
      return new DocumentReturnTableLine();
    }

    public static DocumentReturnTableLine Create(global::System.String reportSessionId, global::System.String fullName, global::System.String docName, global::System.String originalOrCopy, global::System.String deliveryDate, global::System.String scheduledReturnDate, global::System.Int32 overdueDelay, global::System.Int64 docId, global::System.String hyperlink, global::System.String depName, global::System.Int64 depId)
    {
      return new DocumentReturnTableLine
      {
        ReportSessionId = reportSessionId,
        FullName = fullName,
        DocName = docName,
        OriginalOrCopy = originalOrCopy,
        DeliveryDate = deliveryDate,
        ScheduledReturnDate = scheduledReturnDate,
        OverdueDelay = overdueDelay,
        DocId = docId,
        Hyperlink = hyperlink,
        DepName = depName,
        DepId = depId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ ((this.FullName != null ? this.FullName.GetHashCode() : 0) * 199) ^ ((this.DocName != null ? this.DocName.GetHashCode() : 0) * 199) ^ ((this.OriginalOrCopy != null ? this.OriginalOrCopy.GetHashCode() : 0) * 199) ^ ((this.DeliveryDate != null ? this.DeliveryDate.GetHashCode() : 0) * 199) ^ ((this.ScheduledReturnDate != null ? this.ScheduledReturnDate.GetHashCode() : 0) * 199) ^ (this.OverdueDelay.GetHashCode() * 199) ^ (this.DocId.GetHashCode() * 199) ^ ((this.Hyperlink != null ? this.Hyperlink.GetHashCode() : 0) * 199) ^ ((this.DepName != null ? this.DepName.GetHashCode() : 0) * 199) ^ (this.DepId.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DocumentReturnTableLine)obj);
    }

    public static bool operator ==(DocumentReturnTableLine left, DocumentReturnTableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DocumentReturnTableLine left, DocumentReturnTableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(DocumentReturnTableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && object.Equals(this.FullName, other.FullName) 
             && object.Equals(this.DocName, other.DocName) 
             && object.Equals(this.OriginalOrCopy, other.OriginalOrCopy) 
             && object.Equals(this.DeliveryDate, other.DeliveryDate) 
             && object.Equals(this.ScheduledReturnDate, other.ScheduledReturnDate) 
             && this.OverdueDelay == other.OverdueDelay
             && this.DocId == other.DocId
             && object.Equals(this.Hyperlink, other.Hyperlink) 
             && object.Equals(this.DepName, other.DepName) 
             && this.DepId == other.DepId;
    }

  }
}