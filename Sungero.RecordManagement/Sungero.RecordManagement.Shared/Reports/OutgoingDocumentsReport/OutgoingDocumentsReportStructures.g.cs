namespace Sungero.RecordManagement.Structures.OutgoingDocumentsReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.String reportSessionId, global::System.Int32 lineNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::System.String registrationNumber, global::System.String addressee, global::System.String departmentShortName, global::System.String assigneeName, global::System.String assigneeDepartmentShortName, global::System.String assigneeDepartmentName, global::System.String subject, global::System.String note, global::System.Boolean canRead)
    {
      return new TableLine
      {
        ReportSessionId = reportSessionId,
        LineNumber = lineNumber,
        RegistrationDate = registrationDate,
        RegistrationNumber = registrationNumber,
        Addressee = addressee,
        DepartmentShortName = departmentShortName,
        AssigneeName = assigneeName,
        AssigneeDepartmentShortName = assigneeDepartmentShortName,
        AssigneeDepartmentName = assigneeDepartmentName,
        Subject = subject,
        Note = note,
        CanRead = canRead
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ (this.LineNumber.GetHashCode() * 199) ^ ((this.RegistrationDate != null ? this.RegistrationDate.GetHashCode() : 0) * 199) ^ ((this.RegistrationNumber != null ? this.RegistrationNumber.GetHashCode() : 0) * 199) ^ ((this.Addressee != null ? this.Addressee.GetHashCode() : 0) * 199) ^ ((this.DepartmentShortName != null ? this.DepartmentShortName.GetHashCode() : 0) * 199) ^ ((this.AssigneeName != null ? this.AssigneeName.GetHashCode() : 0) * 199) ^ ((this.AssigneeDepartmentShortName != null ? this.AssigneeDepartmentShortName.GetHashCode() : 0) * 199) ^ ((this.AssigneeDepartmentName != null ? this.AssigneeDepartmentName.GetHashCode() : 0) * 199) ^ ((this.Subject != null ? this.Subject.GetHashCode() : 0) * 199) ^ ((this.Note != null ? this.Note.GetHashCode() : 0) * 199) ^ (this.CanRead.GetHashCode() * 199);
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
             && object.Equals(this.Addressee, other.Addressee) 
             && object.Equals(this.DepartmentShortName, other.DepartmentShortName) 
             && object.Equals(this.AssigneeName, other.AssigneeName) 
             && object.Equals(this.AssigneeDepartmentShortName, other.AssigneeDepartmentShortName) 
             && object.Equals(this.AssigneeDepartmentName, other.AssigneeDepartmentName) 
             && object.Equals(this.Subject, other.Subject) 
             && object.Equals(this.Note, other.Note) 
             && this.CanRead == other.CanRead;
    }

  }
}