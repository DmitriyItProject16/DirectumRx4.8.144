namespace Sungero.RecordManagement.Structures.ActionItemsExecutionReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.Int32 rowIndex, global::System.Int64 id, global::System.String hyperlink, global::System.String actionItemText, global::System.String author, global::System.String state, global::System.String planDate, global::System.DateTime planDateSort, global::System.String actualDate, global::System.Int32 overdue, global::System.String assignee, global::System.String coAssignees, global::System.String documentInfo, global::System.String reportSessionId)
    {
      return new TableLine
      {
        RowIndex = rowIndex,
        Id = id,
        Hyperlink = hyperlink,
        ActionItemText = actionItemText,
        Author = author,
        State = state,
        PlanDate = planDate,
        PlanDateSort = planDateSort,
        ActualDate = actualDate,
        Overdue = overdue,
        Assignee = assignee,
        CoAssignees = coAssignees,
        DocumentInfo = documentInfo,
        ReportSessionId = reportSessionId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.RowIndex.GetHashCode() * 199) ^ (this.Id.GetHashCode() * 199) ^ ((this.Hyperlink != null ? this.Hyperlink.GetHashCode() : 0) * 199) ^ ((this.ActionItemText != null ? this.ActionItemText.GetHashCode() : 0) * 199) ^ ((this.Author != null ? this.Author.GetHashCode() : 0) * 199) ^ ((this.State != null ? this.State.GetHashCode() : 0) * 199) ^ ((this.PlanDate != null ? this.PlanDate.GetHashCode() : 0) * 199) ^ ((this.PlanDateSort != null ? this.PlanDateSort.GetHashCode() : 0) * 199) ^ ((this.ActualDate != null ? this.ActualDate.GetHashCode() : 0) * 199) ^ (this.Overdue.GetHashCode() * 199) ^ ((this.Assignee != null ? this.Assignee.GetHashCode() : 0) * 199) ^ ((this.CoAssignees != null ? this.CoAssignees.GetHashCode() : 0) * 199) ^ ((this.DocumentInfo != null ? this.DocumentInfo.GetHashCode() : 0) * 199) ^ ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199);
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
      return this.RowIndex == other.RowIndex
             && this.Id == other.Id
             && object.Equals(this.Hyperlink, other.Hyperlink) 
             && object.Equals(this.ActionItemText, other.ActionItemText) 
             && object.Equals(this.Author, other.Author) 
             && object.Equals(this.State, other.State) 
             && object.Equals(this.PlanDate, other.PlanDate) 
             && object.Equals(this.PlanDateSort, other.PlanDateSort) 
             && object.Equals(this.ActualDate, other.ActualDate) 
             && this.Overdue == other.Overdue
             && object.Equals(this.Assignee, other.Assignee) 
             && object.Equals(this.CoAssignees, other.CoAssignees) 
             && object.Equals(this.DocumentInfo, other.DocumentInfo) 
             && object.Equals(this.ReportSessionId, other.ReportSessionId) ;
    }

  }
}