namespace Sungero.Docflow.Structures.DocumentRegister
{
  [global::System.Serializable]
  public partial class RegistrationNumberIndex : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static RegistrationNumberIndex Create()
    {
      return new RegistrationNumberIndex();
    }

    public static RegistrationNumberIndex Create(global::System.Int32 index, global::System.String postfix, global::System.String correctingPostfix)
    {
      return new RegistrationNumberIndex
      {
        Index = index,
        Postfix = postfix,
        CorrectingPostfix = correctingPostfix
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Index.GetHashCode() * 199) ^ ((this.Postfix != null ? this.Postfix.GetHashCode() : 0) * 199) ^ ((this.CorrectingPostfix != null ? this.CorrectingPostfix.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RegistrationNumberIndex)obj);
    }

    public static bool operator ==(RegistrationNumberIndex left, RegistrationNumberIndex right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RegistrationNumberIndex left, RegistrationNumberIndex right)
    {
      return !(left == right);
    }

    protected bool Equals(RegistrationNumberIndex other)
    {
      return this.Index == other.Index
             && object.Equals(this.Postfix, other.Postfix) 
             && object.Equals(this.CorrectingPostfix, other.CorrectingPostfix) ;
    }

  }

  [global::System.Serializable]
  public partial class RegistrationNumberParts : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static RegistrationNumberParts Create()
    {
      return new RegistrationNumberParts();
    }

    public static RegistrationNumberParts Create(global::System.String prefix, global::System.String postfix)
    {
      return new RegistrationNumberParts
      {
        Prefix = prefix,
        Postfix = postfix
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Prefix != null ? this.Prefix.GetHashCode() : 0) * 199) ^ ((this.Postfix != null ? this.Postfix.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RegistrationNumberParts)obj);
    }

    public static bool operator ==(RegistrationNumberParts left, RegistrationNumberParts right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RegistrationNumberParts left, RegistrationNumberParts right)
    {
      return !(left == right);
    }

    protected bool Equals(RegistrationNumberParts other)
    {
      return object.Equals(this.Prefix, other.Prefix) 
             && object.Equals(this.Postfix, other.Postfix) ;
    }

  }
}