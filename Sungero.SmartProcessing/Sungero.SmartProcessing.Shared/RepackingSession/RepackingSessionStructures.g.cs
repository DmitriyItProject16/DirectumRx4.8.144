namespace Sungero.SmartProcessing.Structures.RepackingSession
{
  public partial class RepackingDocument : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static RepackingDocument Create()
    {
      return new RepackingDocument();
    }

    public static RepackingDocument Create(global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Content.IElectronicDocumentVersions version)
    {
      return new RepackingDocument
      {
        Document = document,
        Version = version
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Document != null ? this.Document.GetHashCode() : 0) * 199) ^ ((this.Version != null ? this.Version.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RepackingDocument)obj);
    }

    public static bool operator ==(RepackingDocument left, RepackingDocument right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RepackingDocument left, RepackingDocument right)
    {
      return !(left == right);
    }

    protected bool Equals(RepackingDocument other)
    {
      return object.Equals(this.Document, other.Document) 
             && object.Equals(this.Version, other.Version) ;
    }

  }
}