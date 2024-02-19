namespace Sungero.Docflow.Structures.IncomingDocumentBase
{
  [global::System.Serializable]
  public partial class RegistrationStampPosition : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static RegistrationStampPosition Create()
    {
      return new RegistrationStampPosition();
    }

    public static RegistrationStampPosition Create(global::System.Double rightIndent, global::System.Double bottomIndent)
    {
      return new RegistrationStampPosition
      {
        RightIndent = rightIndent,
        BottomIndent = bottomIndent
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.RightIndent.GetHashCode() * 199) ^ (this.BottomIndent.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RegistrationStampPosition)obj);
    }

    public static bool operator ==(RegistrationStampPosition left, RegistrationStampPosition right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RegistrationStampPosition left, RegistrationStampPosition right)
    {
      return !(left == right);
    }

    protected bool Equals(RegistrationStampPosition other)
    {
      return this.RightIndent == other.RightIndent
             && this.BottomIndent == other.BottomIndent;
    }

  }
}