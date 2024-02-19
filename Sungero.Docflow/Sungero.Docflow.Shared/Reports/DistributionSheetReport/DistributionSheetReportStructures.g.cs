namespace Sungero.Docflow.Structures.DistributionSheetReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.String reportSessionId, global::System.String companyName, global::System.String nameWithJobTitle, global::System.String deliveryMethod, global::System.String contactsInformation)
    {
      return new TableLine
      {
        ReportSessionId = reportSessionId,
        CompanyName = companyName,
        NameWithJobTitle = nameWithJobTitle,
        DeliveryMethod = deliveryMethod,
        ContactsInformation = contactsInformation
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ ((this.CompanyName != null ? this.CompanyName.GetHashCode() : 0) * 199) ^ ((this.NameWithJobTitle != null ? this.NameWithJobTitle.GetHashCode() : 0) * 199) ^ ((this.DeliveryMethod != null ? this.DeliveryMethod.GetHashCode() : 0) * 199) ^ ((this.ContactsInformation != null ? this.ContactsInformation.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((TableLine)obj);
    }

    public static bool operator ==(TableLine left, TableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(TableLine left, TableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(TableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && object.Equals(this.CompanyName, other.CompanyName) 
             && object.Equals(this.NameWithJobTitle, other.NameWithJobTitle) 
             && object.Equals(this.DeliveryMethod, other.DeliveryMethod) 
             && object.Equals(this.ContactsInformation, other.ContactsInformation) ;
    }

  }
}