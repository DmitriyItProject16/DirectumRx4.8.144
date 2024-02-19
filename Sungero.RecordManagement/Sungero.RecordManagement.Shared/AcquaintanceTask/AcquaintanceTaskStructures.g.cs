namespace Sungero.RecordManagement.Structures.AcquaintanceTask
{
  [global::System.Serializable]
  public partial class StartValidationMessage : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static StartValidationMessage Create()
    {
      return new StartValidationMessage();
    }

    public static StartValidationMessage Create(global::System.String message, global::System.Boolean isShowNotAutomatedEmployeesMessage, global::System.Boolean isCantSendTaskByNonEmployeeMessage)
    {
      return new StartValidationMessage
      {
        Message = message,
        IsShowNotAutomatedEmployeesMessage = isShowNotAutomatedEmployeesMessage,
        IsCantSendTaskByNonEmployeeMessage = isCantSendTaskByNonEmployeeMessage
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Message != null ? this.Message.GetHashCode() : 0) * 199) ^ (this.IsShowNotAutomatedEmployeesMessage.GetHashCode() * 199) ^ (this.IsCantSendTaskByNonEmployeeMessage.GetHashCode() * 199);
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
             && this.IsShowNotAutomatedEmployeesMessage == other.IsShowNotAutomatedEmployeesMessage
             && this.IsCantSendTaskByNonEmployeeMessage == other.IsCantSendTaskByNonEmployeeMessage;
    }

  }
}