namespace Sungero.Docflow.Structures.FreeApprovalTask
{
  [global::System.Serializable]
  public partial class AssignmentInfo : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AssignmentInfo Create()
    {
      return new AssignmentInfo();
    }

    public static AssignmentInfo Create(global::System.String performer, global::System.String deadline, global::System.String status)
    {
      return new AssignmentInfo
      {
        Performer = performer,
        Deadline = deadline,
        Status = status
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Performer != null ? this.Performer.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AssignmentInfo)obj);
    }

    public static bool operator ==(AssignmentInfo left, AssignmentInfo right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AssignmentInfo left, AssignmentInfo right)
    {
      return !(left == right);
    }

    protected bool Equals(AssignmentInfo other)
    {
      return object.Equals(this.Performer, other.Performer) 
             && object.Equals(this.Deadline, other.Deadline) 
             && object.Equals(this.Status, other.Status) ;
    }

  }

  [global::System.Serializable]
  public partial class StartValidationMessage : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static StartValidationMessage Create()
    {
      return new StartValidationMessage();
    }

    public static StartValidationMessage Create(global::System.String message, global::System.Boolean isImpossibleSpecifyDeadlineLessThanTodayMessage, global::System.Boolean isCantSendTaskByNonEmployeeMessage)
    {
      return new StartValidationMessage
      {
        Message = message,
        IsImpossibleSpecifyDeadlineLessThanTodayMessage = isImpossibleSpecifyDeadlineLessThanTodayMessage,
        IsCantSendTaskByNonEmployeeMessage = isCantSendTaskByNonEmployeeMessage
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Message != null ? this.Message.GetHashCode() : 0) * 199) ^ (this.IsImpossibleSpecifyDeadlineLessThanTodayMessage.GetHashCode() * 199) ^ (this.IsCantSendTaskByNonEmployeeMessage.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((StartValidationMessage)obj);
    }

    public static bool operator ==(StartValidationMessage left, StartValidationMessage right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(StartValidationMessage left, StartValidationMessage right)
    {
      return !(left == right);
    }

    protected bool Equals(StartValidationMessage other)
    {
      return object.Equals(this.Message, other.Message) 
             && this.IsImpossibleSpecifyDeadlineLessThanTodayMessage == other.IsImpossibleSpecifyDeadlineLessThanTodayMessage
             && this.IsCantSendTaskByNonEmployeeMessage == other.IsCantSendTaskByNonEmployeeMessage;
    }

  }
}