namespace Sungero.Docflow.Structures.OfficialDocument
{
  public partial class DialogResult : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DialogResult Create()
    {
      return new DialogResult();
    }

    public static DialogResult Create(global::Sungero.Docflow.IDocumentRegister register, global::System.DateTime date, global::System.String number)
    {
      return new DialogResult
      {
        Register = register,
        Date = date,
        Number = number
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Register != null ? this.Register.GetHashCode() : 0) * 199) ^ ((this.Date != null ? this.Date.GetHashCode() : 0) * 199) ^ ((this.Number != null ? this.Number.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DialogResult)obj);
    }

    public static bool operator ==(DialogResult left, DialogResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DialogResult left, DialogResult right)
    {
      return !(left == right);
    }

    protected bool Equals(DialogResult other)
    {
      return object.Equals(this.Register, other.Register) 
             && object.Equals(this.Date, other.Date) 
             && object.Equals(this.Number, other.Number) ;
    }

  }

  [global::System.Serializable]
  public partial class ConversionToPdfResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ConversionToPdfResult Create()
    {
      return new ConversionToPdfResult();
    }

    public static ConversionToPdfResult Create(global::System.Boolean isFastConvertion, global::System.Boolean isOnConvertion, global::System.Boolean hasErrors, global::System.Boolean hasConvertionError, global::System.Boolean hasLockError, global::System.String errorTitle, global::System.String errorMessage)
    {
      return new ConversionToPdfResult
      {
        IsFastConvertion = isFastConvertion,
        IsOnConvertion = isOnConvertion,
        HasErrors = hasErrors,
        HasConvertionError = hasConvertionError,
        HasLockError = hasLockError,
        ErrorTitle = errorTitle,
        ErrorMessage = errorMessage
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.IsFastConvertion.GetHashCode() * 199) ^ (this.IsOnConvertion.GetHashCode() * 199) ^ (this.HasErrors.GetHashCode() * 199) ^ (this.HasConvertionError.GetHashCode() * 199) ^ (this.HasLockError.GetHashCode() * 199) ^ ((this.ErrorTitle != null ? this.ErrorTitle.GetHashCode() : 0) * 199) ^ ((this.ErrorMessage != null ? this.ErrorMessage.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ConversionToPdfResult)obj);
    }

    public static bool operator ==(ConversionToPdfResult left, ConversionToPdfResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ConversionToPdfResult left, ConversionToPdfResult right)
    {
      return !(left == right);
    }

    protected bool Equals(ConversionToPdfResult other)
    {
      return this.IsFastConvertion == other.IsFastConvertion
             && this.IsOnConvertion == other.IsOnConvertion
             && this.HasErrors == other.HasErrors
             && this.HasConvertionError == other.HasConvertionError
             && this.HasLockError == other.HasLockError
             && object.Equals(this.ErrorTitle, other.ErrorTitle) 
             && object.Equals(this.ErrorMessage, other.ErrorMessage) ;
    }

  }

  [global::System.Serializable]
  public partial class RecognizedProperty : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static RecognizedProperty Create()
    {
      return new RecognizedProperty();
    }

    public static RecognizedProperty Create(global::System.String name, global::System.Nullable<global::System.Double> probability, global::System.String position)
    {
      return new RecognizedProperty
      {
        Name = name,
        Probability = probability,
        Position = position
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Name != null ? this.Name.GetHashCode() : 0) * 199) ^ ((this.Probability != null ? this.Probability.GetHashCode() : 0) * 199) ^ ((this.Position != null ? this.Position.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RecognizedProperty)obj);
    }

    public static bool operator ==(RecognizedProperty left, RecognizedProperty right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RecognizedProperty left, RecognizedProperty right)
    {
      return !(left == right);
    }

    protected bool Equals(RecognizedProperty other)
    {
      return object.Equals(this.Name, other.Name) 
             && object.Equals(this.Probability, other.Probability) 
             && object.Equals(this.Position, other.Position) ;
    }

  }

  [global::System.Serializable]
  public partial class HistoryOperation : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static HistoryOperation Create()
    {
      return new HistoryOperation();
    }

    public static HistoryOperation Create(global::System.String operation, global::System.String comment)
    {
      return new HistoryOperation
      {
        Operation = operation,
        Comment = comment
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Operation != null ? this.Operation.GetHashCode() : 0) * 199) ^ ((this.Comment != null ? this.Comment.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((HistoryOperation)obj);
    }

    public static bool operator ==(HistoryOperation left, HistoryOperation right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(HistoryOperation left, HistoryOperation right)
    {
      return !(left == right);
    }

    protected bool Equals(HistoryOperation other)
    {
      return object.Equals(this.Operation, other.Operation) 
             && object.Equals(this.Comment, other.Comment) ;
    }

  }
}