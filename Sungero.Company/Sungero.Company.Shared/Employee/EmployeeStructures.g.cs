namespace Sungero.Company.Structures.Employee
{
  [global::System.Serializable]
  public partial class PersonFullName : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static PersonFullName Create()
    {
      return new PersonFullName();
    }

    public static PersonFullName Create(global::System.String lastName, global::System.String firstName, global::System.String middleName)
    {
      return new PersonFullName
      {
        LastName = lastName,
        FirstName = firstName,
        MiddleName = middleName
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.LastName != null ? this.LastName.GetHashCode() : 0) * 199) ^ ((this.FirstName != null ? this.FirstName.GetHashCode() : 0) * 199) ^ ((this.MiddleName != null ? this.MiddleName.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((PersonFullName)obj);
    }

    public static bool operator ==(PersonFullName left, PersonFullName right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(PersonFullName left, PersonFullName right)
    {
      return !(left == right);
    }

    protected bool Equals(PersonFullName other)
    {
      return object.Equals(this.LastName, other.LastName) 
             && object.Equals(this.FirstName, other.FirstName) 
             && object.Equals(this.MiddleName, other.MiddleName) ;
    }

  }
}