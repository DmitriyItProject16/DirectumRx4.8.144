namespace Sungero.Docflow.Structures.DeadlineExtensionTask
{
  public partial class ActionItemAssignees : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static ActionItemAssignees Create()
    {
      return new ActionItemAssignees();
    }

    public static ActionItemAssignees Create(global::System.Collections.Generic.List<global::Sungero.CoreEntities.IUser> assignees, global::System.Boolean canSelect)
    {
      return new ActionItemAssignees
      {
        Assignees = assignees,
        CanSelect = canSelect
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Assignees != null ? this.Assignees.GetHashCode() : 0) * 199) ^ (this.CanSelect.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ActionItemAssignees)obj);
    }

    public static bool operator ==(ActionItemAssignees left, ActionItemAssignees right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ActionItemAssignees left, ActionItemAssignees right)
    {
      return !(left == right);
    }

    protected bool Equals(ActionItemAssignees other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Assignees, other.Assignees)
             && this.CanSelect == other.CanSelect;
    }

  }
}