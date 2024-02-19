namespace Sungero.Docflow.Structures.ApprovalFunctionStageBase
{
  [global::System.Serializable]
  public partial class ExecutionResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExecutionResult Create()
    {
      return new ExecutionResult();
    }

    public static ExecutionResult Create(global::System.Boolean success, global::System.Boolean retry, global::System.String errorMessage)
    {
      return new ExecutionResult
      {
        Success = success,
        Retry = retry,
        ErrorMessage = errorMessage
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Success.GetHashCode() * 199) ^ (this.Retry.GetHashCode() * 199) ^ ((this.ErrorMessage != null ? this.ErrorMessage.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExecutionResult)obj);
    }

    public static bool operator ==(ExecutionResult left, ExecutionResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExecutionResult left, ExecutionResult right)
    {
      return !(left == right);
    }

    protected bool Equals(ExecutionResult other)
    {
      return this.Success == other.Success
             && this.Retry == other.Retry
             && object.Equals(this.ErrorMessage, other.ErrorMessage) ;
    }

  }
}