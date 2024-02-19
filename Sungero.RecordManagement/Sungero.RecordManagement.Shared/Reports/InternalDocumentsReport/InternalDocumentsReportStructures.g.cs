namespace Sungero.RecordManagement.Structures.InternalDocumentsReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.String reportSessionId, global::System.Int32 lineNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::System.String registrationNumber, global::System.String preparedByName, global::System.String preparedByDepartmentShortName, global::System.String preparedByDepartmentName, global::System.String subject, global::System.Boolean canRead)
    {
      return new TableLine
      {
        ReportSessionId = reportSessionId,
        LineNumber = lineNumber,
        RegistrationDate = registrationDate,
        RegistrationNumber = registrationNumber,
        PreparedByName = preparedByName,
        PreparedByDepartmentShortName = preparedByDepartmentShortName,
        PreparedByDepartmentName = preparedByDepartmentName,
        Subject = subject,
        CanRead = canRead
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ (this.LineNumber.GetHashCode() * 199) ^ ((this.RegistrationDate != null ? this.RegistrationDate.GetHashCode() : 0) * 199) ^ ((this.RegistrationNumber != null ? this.RegistrationNumber.GetHashCode() : 0) * 199) ^ ((this.PreparedByName != null ? this.PreparedByName.GetHashCode() : 0) * 199) ^ ((this.PreparedByDepartmentShortName != null ? this.PreparedByDepartmentShortName.GetHashCode() : 0) * 199) ^ ((this.PreparedByDepartmentName != null ? this.PreparedByDepartmentName.GetHashCode() : 0) * 199) ^ ((this.Subject != null ? this.Subject.GetHashCode() : 0) * 199) ^ (this.CanRead.GetHashCode() * 199);
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
             && this.LineNumber == other.LineNumber
             && object.Equals(this.RegistrationDate, other.RegistrationDate) 
             && object.Equals(this.RegistrationNumber, other.RegistrationNumber) 
             && object.Equals(this.PreparedByName, other.PreparedByName) 
             && object.Equals(this.PreparedByDepartmentShortName, other.PreparedByDepartmentShortName) 
             && object.Equals(this.PreparedByDepartmentName, other.PreparedByDepartmentName) 
             && object.Equals(this.Subject, other.Subject) 
             && this.CanRead == other.CanRead;
    }

  }
}