namespace Sungero.Company.Structures.Module
{
  public partial class Substitution : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static Substitution Create()
    {
      return new Substitution();
    }

    public static Substitution Create(global::Sungero.CoreEntities.IUser user, global::Sungero.CoreEntities.IUser substitutedUser)
    {
      return new Substitution
      {
        User = user,
        SubstitutedUser = substitutedUser
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.User != null ? this.User.GetHashCode() : 0) * 199) ^ ((this.SubstitutedUser != null ? this.SubstitutedUser.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Substitution)obj);
    }

    public static bool operator ==(Substitution left, Substitution right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(Substitution left, Substitution right)
    {
      return !(left == right);
    }

    protected bool Equals(Substitution other)
    {
      return object.Equals(this.User, other.User) 
             && object.Equals(this.SubstitutedUser, other.SubstitutedUser) ;
    }

  }
}