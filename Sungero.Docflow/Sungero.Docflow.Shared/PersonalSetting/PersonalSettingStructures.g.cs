namespace Sungero.Docflow.Structures.PersonalSetting
{
  [global::System.Serializable]
  public partial class CompanySiteUrl : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static CompanySiteUrl Create()
    {
      return new CompanySiteUrl();
    }

    public static CompanySiteUrl Create(global::System.String url, global::System.Boolean psrnNeeded, global::System.Boolean tinNeeded)
    {
      return new CompanySiteUrl
      {
        Url = url,
        PsrnNeeded = psrnNeeded,
        TinNeeded = tinNeeded
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Url != null ? this.Url.GetHashCode() : 0) * 199) ^ (this.PsrnNeeded.GetHashCode() * 199) ^ (this.TinNeeded.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((CompanySiteUrl)obj);
    }

    public static bool operator ==(CompanySiteUrl left, CompanySiteUrl right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(CompanySiteUrl left, CompanySiteUrl right)
    {
      return !(left == right);
    }

    protected bool Equals(CompanySiteUrl other)
    {
      return object.Equals(this.Url, other.Url) 
             && this.PsrnNeeded == other.PsrnNeeded
             && this.TinNeeded == other.TinNeeded;
    }

  }
}