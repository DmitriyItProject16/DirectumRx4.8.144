namespace Sungero.Docflow.Structures.Addendum
{
  [global::System.Serializable]
  public partial class LeadingDocument : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static LeadingDocument Create()
    {
      return new LeadingDocument();
    }

    public static LeadingDocument Create(global::System.String name, global::System.String number)
    {
      return new LeadingDocument
      {
        Name = name,
        Number = number
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Name != null ? this.Name.GetHashCode() : 0) * 199) ^ ((this.Number != null ? this.Number.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LeadingDocument)obj);
    }

    public static bool operator ==(LeadingDocument left, LeadingDocument right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LeadingDocument left, LeadingDocument right)
    {
      return !(left == right);
    }

    protected bool Equals(LeadingDocument other)
    {
      return object.Equals(this.Name, other.Name) 
             && object.Equals(this.Number, other.Number) ;
    }

  }
}