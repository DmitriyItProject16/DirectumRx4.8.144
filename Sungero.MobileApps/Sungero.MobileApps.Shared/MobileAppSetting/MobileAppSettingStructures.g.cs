namespace Sungero.MobileApps.Structures.MobileAppSetting
{
  [global::System.Serializable]
  public partial class FolderNameWithId : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static FolderNameWithId Create()
    {
      return new FolderNameWithId();
    }

    public static FolderNameWithId Create(global::System.Int64 id, global::System.String folderName)
    {
      return new FolderNameWithId
      {
        Id = id,
        FolderName = folderName
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.FolderName != null ? this.FolderName.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((FolderNameWithId)obj);
    }

    public static bool operator ==(FolderNameWithId left, FolderNameWithId right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(FolderNameWithId left, FolderNameWithId right)
    {
      return !(left == right);
    }

    protected bool Equals(FolderNameWithId other)
    {
      return this.Id == other.Id
             && object.Equals(this.FolderName, other.FolderName) ;
    }

  }
}