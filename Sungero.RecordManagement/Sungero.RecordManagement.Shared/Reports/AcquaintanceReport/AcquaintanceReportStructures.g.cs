namespace Sungero.RecordManagement.Structures.AcquaintanceReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.String taskDisplayName, global::System.Int64 taskId, global::System.String taskHyperlink, global::System.Int32 rowNumber, global::System.String shortName, global::System.String lastName, global::System.String jobTitle, global::System.String department, global::System.String acquaintanceDate, global::System.String state, global::System.String note, global::System.String assignmentId, global::System.String assignmentHyperlink, global::System.String reportSessionId)
    {
      return new TableLine
      {
        TaskDisplayName = taskDisplayName,
        TaskId = taskId,
        TaskHyperlink = taskHyperlink,
        RowNumber = rowNumber,
        ShortName = shortName,
        LastName = lastName,
        JobTitle = jobTitle,
        Department = department,
        AcquaintanceDate = acquaintanceDate,
        State = state,
        Note = note,
        AssignmentId = assignmentId,
        AssignmentHyperlink = assignmentHyperlink,
        ReportSessionId = reportSessionId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.TaskDisplayName != null ? this.TaskDisplayName.GetHashCode() : 0) * 199) ^ (this.TaskId.GetHashCode() * 199) ^ ((this.TaskHyperlink != null ? this.TaskHyperlink.GetHashCode() : 0) * 199) ^ (this.RowNumber.GetHashCode() * 199) ^ ((this.ShortName != null ? this.ShortName.GetHashCode() : 0) * 199) ^ ((this.LastName != null ? this.LastName.GetHashCode() : 0) * 199) ^ ((this.JobTitle != null ? this.JobTitle.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199) ^ ((this.AcquaintanceDate != null ? this.AcquaintanceDate.GetHashCode() : 0) * 199) ^ ((this.State != null ? this.State.GetHashCode() : 0) * 199) ^ ((this.Note != null ? this.Note.GetHashCode() : 0) * 199) ^ ((this.AssignmentId != null ? this.AssignmentId.GetHashCode() : 0) * 199) ^ ((this.AssignmentHyperlink != null ? this.AssignmentHyperlink.GetHashCode() : 0) * 199) ^ ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199);
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
      return object.Equals(this.TaskDisplayName, other.TaskDisplayName) 
             && this.TaskId == other.TaskId
             && object.Equals(this.TaskHyperlink, other.TaskHyperlink) 
             && this.RowNumber == other.RowNumber
             && object.Equals(this.ShortName, other.ShortName) 
             && object.Equals(this.LastName, other.LastName) 
             && object.Equals(this.JobTitle, other.JobTitle) 
             && object.Equals(this.Department, other.Department) 
             && object.Equals(this.AcquaintanceDate, other.AcquaintanceDate) 
             && object.Equals(this.State, other.State) 
             && object.Equals(this.Note, other.Note) 
             && object.Equals(this.AssignmentId, other.AssignmentId) 
             && object.Equals(this.AssignmentHyperlink, other.AssignmentHyperlink) 
             && object.Equals(this.ReportSessionId, other.ReportSessionId) ;
    }

  }
}