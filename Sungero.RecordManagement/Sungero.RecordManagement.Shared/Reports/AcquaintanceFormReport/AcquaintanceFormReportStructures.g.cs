namespace Sungero.RecordManagement.Structures.AcquaintanceFormReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.Int32 rowNumber, global::System.String shortName, global::System.String lastName, global::System.String jobTitle, global::System.String department, global::System.String reportSessionId)
    {
      return new TableLine
      {
        RowNumber = rowNumber,
        ShortName = shortName,
        LastName = lastName,
        JobTitle = jobTitle,
        Department = department,
        ReportSessionId = reportSessionId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.RowNumber.GetHashCode() * 199) ^ ((this.ShortName != null ? this.ShortName.GetHashCode() : 0) * 199) ^ ((this.LastName != null ? this.LastName.GetHashCode() : 0) * 199) ^ ((this.JobTitle != null ? this.JobTitle.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199) ^ ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199);
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
      return this.RowNumber == other.RowNumber
             && object.Equals(this.ShortName, other.ShortName) 
             && object.Equals(this.LastName, other.LastName) 
             && object.Equals(this.JobTitle, other.JobTitle) 
             && object.Equals(this.Department, other.Department) 
             && object.Equals(this.ReportSessionId, other.ReportSessionId) ;
    }

  }
}