namespace Sungero.Docflow.Structures.ExchangeServiceDocumentReport
{
  [global::System.Serializable]
  public partial class ExchangeServiceDocumentTableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExchangeServiceDocumentTableLine Create()
    {
      return new ExchangeServiceDocumentTableLine();
    }

    public static ExchangeServiceDocumentTableLine Create(global::System.String reportSessionId, global::System.String businessUnitName, global::System.Int64 businessUnitId, global::System.String docName, global::System.Int64 docId, global::System.String counterparty, global::System.String exchangeService, global::System.String responsible, global::System.String department, global::System.String sendDate, global::System.String hyperlink, global::System.String delay)
    {
      return new ExchangeServiceDocumentTableLine
      {
        ReportSessionId = reportSessionId,
        BusinessUnitName = businessUnitName,
        BusinessUnitId = businessUnitId,
        DocName = docName,
        DocId = docId,
        Counterparty = counterparty,
        ExchangeService = exchangeService,
        Responsible = responsible,
        Department = department,
        SendDate = sendDate,
        Hyperlink = hyperlink,
        Delay = delay
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ ((this.BusinessUnitName != null ? this.BusinessUnitName.GetHashCode() : 0) * 199) ^ (this.BusinessUnitId.GetHashCode() * 199) ^ ((this.DocName != null ? this.DocName.GetHashCode() : 0) * 199) ^ (this.DocId.GetHashCode() * 199) ^ ((this.Counterparty != null ? this.Counterparty.GetHashCode() : 0) * 199) ^ ((this.ExchangeService != null ? this.ExchangeService.GetHashCode() : 0) * 199) ^ ((this.Responsible != null ? this.Responsible.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199) ^ ((this.SendDate != null ? this.SendDate.GetHashCode() : 0) * 199) ^ ((this.Hyperlink != null ? this.Hyperlink.GetHashCode() : 0) * 199) ^ ((this.Delay != null ? this.Delay.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExchangeServiceDocumentTableLine)obj);
    }

    public static bool operator ==(ExchangeServiceDocumentTableLine left, ExchangeServiceDocumentTableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExchangeServiceDocumentTableLine left, ExchangeServiceDocumentTableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(ExchangeServiceDocumentTableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && object.Equals(this.BusinessUnitName, other.BusinessUnitName) 
             && this.BusinessUnitId == other.BusinessUnitId
             && object.Equals(this.DocName, other.DocName) 
             && this.DocId == other.DocId
             && object.Equals(this.Counterparty, other.Counterparty) 
             && object.Equals(this.ExchangeService, other.ExchangeService) 
             && object.Equals(this.Responsible, other.Responsible) 
             && object.Equals(this.Department, other.Department) 
             && object.Equals(this.SendDate, other.SendDate) 
             && object.Equals(this.Hyperlink, other.Hyperlink) 
             && object.Equals(this.Delay, other.Delay) ;
    }

  }
}