namespace Sungero.RecordManagement.Structures.Module
{
  [global::System.Serializable]
  public partial class LightAssignment : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static LightAssignment Create()
    {
      return new LightAssignment();
    }

    public static LightAssignment Create(global::System.Int64 id, global::System.Nullable<global::Sungero.Core.Enumeration> status, global::System.Nullable<global::System.DateTime> deadline, global::System.Nullable<global::System.DateTime> modified, global::System.Nullable<global::System.DateTime> created)
    {
      return new LightAssignment
      {
        Id = id,
        Status = status,
        Deadline = deadline,
        Modified = modified,
        Created = created
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Modified != null ? this.Modified.GetHashCode() : 0) * 199) ^ ((this.Created != null ? this.Created.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LightAssignment)obj);
    }

    public static bool operator ==(LightAssignment left, LightAssignment right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LightAssignment left, LightAssignment right)
    {
      return !(left == right);
    }

    protected bool Equals(LightAssignment other)
    {
      return this.Id == other.Id
             && object.Equals(this.Status, other.Status) 
             && object.Equals(this.Deadline, other.Deadline) 
             && object.Equals(this.Modified, other.Modified) 
             && object.Equals(this.Created, other.Created) ;
    }

  }

  public partial class LightActionItem : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static LightActionItem Create()
    {
      return new LightActionItem();
    }

    public static LightActionItem Create(global::System.Int64 id, global::System.Nullable<global::Sungero.Core.Enumeration> status, global::System.Nullable<global::System.DateTime> actualDate, global::System.Nullable<global::System.DateTime> deadline, global::Sungero.CoreEntities.IUser author, global::Sungero.Company.IEmployee assignee, global::System.String actionItem, global::System.Nullable<global::Sungero.Core.Enumeration> executionState, global::System.Collections.Generic.List<global::System.String> coAssigneesShortNames)
    {
      return new LightActionItem
      {
        Id = id,
        Status = status,
        ActualDate = actualDate,
        Deadline = deadline,
        Author = author,
        Assignee = assignee,
        ActionItem = actionItem,
        ExecutionState = executionState,
        CoAssigneesShortNames = coAssigneesShortNames
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199) ^ ((this.ActualDate != null ? this.ActualDate.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Author != null ? this.Author.GetHashCode() : 0) * 199) ^ ((this.Assignee != null ? this.Assignee.GetHashCode() : 0) * 199) ^ ((this.ActionItem != null ? this.ActionItem.GetHashCode() : 0) * 199) ^ ((this.ExecutionState != null ? this.ExecutionState.GetHashCode() : 0) * 199) ^ ((this.CoAssigneesShortNames != null ? this.CoAssigneesShortNames.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LightActionItem)obj);
    }

    public static bool operator ==(LightActionItem left, LightActionItem right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LightActionItem left, LightActionItem right)
    {
      return !(left == right);
    }

    protected bool Equals(LightActionItem other)
    {
      return this.Id == other.Id
             && object.Equals(this.Status, other.Status) 
             && object.Equals(this.ActualDate, other.ActualDate) 
             && object.Equals(this.Deadline, other.Deadline) 
             && object.Equals(this.Author, other.Author) 
             && object.Equals(this.Assignee, other.Assignee) 
             && object.Equals(this.ActionItem, other.ActionItem) 
             && object.Equals(this.ExecutionState, other.ExecutionState) 
             && global::System.Linq.Enumerable.SequenceEqual(this.CoAssigneesShortNames, other.CoAssigneesShortNames);
    }

  }

  public partial class LightActionItemForChart : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static LightActionItemForChart Create()
    {
      return new LightActionItemForChart();
    }

    public static LightActionItemForChart Create(global::System.Int64 id, global::System.Nullable<global::Sungero.Core.Enumeration> status, global::System.Nullable<global::System.DateTime> actualDate, global::System.Nullable<global::System.DateTime> deadline, global::Sungero.CoreEntities.IUser author, global::Sungero.Company.IEmployee assignee)
    {
      return new LightActionItemForChart
      {
        Id = id,
        Status = status,
        ActualDate = actualDate,
        Deadline = deadline,
        Author = author,
        Assignee = assignee
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199) ^ ((this.ActualDate != null ? this.ActualDate.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Author != null ? this.Author.GetHashCode() : 0) * 199) ^ ((this.Assignee != null ? this.Assignee.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LightActionItemForChart)obj);
    }

    public static bool operator ==(LightActionItemForChart left, LightActionItemForChart right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LightActionItemForChart left, LightActionItemForChart right)
    {
      return !(left == right);
    }

    protected bool Equals(LightActionItemForChart other)
    {
      return this.Id == other.Id
             && object.Equals(this.Status, other.Status) 
             && object.Equals(this.ActualDate, other.ActualDate) 
             && object.Equals(this.Deadline, other.Deadline) 
             && object.Equals(this.Author, other.Author) 
             && object.Equals(this.Assignee, other.Assignee) ;
    }

  }

  public partial class DocumentRegisterReportParametrs : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DocumentRegisterReportParametrs Create()
    {
      return new DocumentRegisterReportParametrs();
    }

    public static DocumentRegisterReportParametrs Create(global::System.Boolean runReport, global::System.Nullable<global::System.DateTime> periodBegin, global::System.Nullable<global::System.DateTime> periodEnd, global::Sungero.Docflow.IDocumentRegister documentRegister)
    {
      return new DocumentRegisterReportParametrs
      {
        RunReport = runReport,
        PeriodBegin = periodBegin,
        PeriodEnd = periodEnd,
        DocumentRegister = documentRegister
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.RunReport.GetHashCode() * 199) ^ ((this.PeriodBegin != null ? this.PeriodBegin.GetHashCode() : 0) * 199) ^ ((this.PeriodEnd != null ? this.PeriodEnd.GetHashCode() : 0) * 199) ^ ((this.DocumentRegister != null ? this.DocumentRegister.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DocumentRegisterReportParametrs)obj);
    }

    public static bool operator ==(DocumentRegisterReportParametrs left, DocumentRegisterReportParametrs right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DocumentRegisterReportParametrs left, DocumentRegisterReportParametrs right)
    {
      return !(left == right);
    }

    protected bool Equals(DocumentRegisterReportParametrs other)
    {
      return this.RunReport == other.RunReport
             && object.Equals(this.PeriodBegin, other.PeriodBegin) 
             && object.Equals(this.PeriodEnd, other.PeriodEnd) 
             && object.Equals(this.DocumentRegister, other.DocumentRegister) ;
    }

  }

  [global::System.Serializable]
  public partial class ActionItemStatistic : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ActionItemStatistic Create()
    {
      return new ActionItemStatistic();
    }

    public static ActionItemStatistic Create(global::System.Nullable<global::System.Int32> statistic, global::System.DateTime month)
    {
      return new ActionItemStatistic
      {
        Statistic = statistic,
        Month = month
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Statistic != null ? this.Statistic.GetHashCode() : 0) * 199) ^ ((this.Month != null ? this.Month.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ActionItemStatistic)obj);
    }

    public static bool operator ==(ActionItemStatistic left, ActionItemStatistic right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ActionItemStatistic left, ActionItemStatistic right)
    {
      return !(left == right);
    }

    protected bool Equals(ActionItemStatistic other)
    {
      return object.Equals(this.Statistic, other.Statistic) 
             && object.Equals(this.Month, other.Month) ;
    }

  }
}