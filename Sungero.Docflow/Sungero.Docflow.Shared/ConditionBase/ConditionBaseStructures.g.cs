namespace Sungero.Docflow.Structures.ConditionBase
{
  [global::System.Serializable]
  public partial class ConditionResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ConditionResult Create()
    {
      return new ConditionResult();
    }

    public static ConditionResult Create(global::System.Nullable<global::System.Boolean> branch, global::System.String message)
    {
      return new ConditionResult
      {
        Branch = branch,
        Message = message
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Branch != null ? this.Branch.GetHashCode() : 0) * 199) ^ ((this.Message != null ? this.Message.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ConditionResult)obj);
    }

    public static bool operator ==(ConditionResult left, ConditionResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ConditionResult left, ConditionResult right)
    {
      return !(left == right);
    }

    protected bool Equals(ConditionResult other)
    {
      return object.Equals(this.Branch, other.Branch) 
             && object.Equals(this.Message, other.Message) ;
    }

  }
}