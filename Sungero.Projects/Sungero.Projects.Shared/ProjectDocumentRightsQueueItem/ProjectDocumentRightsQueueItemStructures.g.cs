namespace Sungero.Projects.Structures.ProjectDocumentRightsQueueItem
{
  [global::System.Serializable]
  public partial class ProxyQueueItem : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ProxyQueueItem Create()
    {
      return new ProxyQueueItem();
    }

    public static ProxyQueueItem Create(global::System.Int64 id, global::System.Guid discriminator, global::System.Int64 projectIdProjectSungero, global::System.Int64 documentIdProjectSungero)
    {
      return new ProxyQueueItem
      {
        Id = id,
        Discriminator = discriminator,
        ProjectId_Project_Sungero = projectIdProjectSungero,
        DocumentId_Project_Sungero = documentIdProjectSungero
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Discriminator != null ? this.Discriminator.GetHashCode() : 0) * 199) ^ (this.ProjectId_Project_Sungero.GetHashCode() * 199) ^ (this.DocumentId_Project_Sungero.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ProxyQueueItem)obj);
    }

    public static bool operator ==(ProxyQueueItem left, ProxyQueueItem right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ProxyQueueItem left, ProxyQueueItem right)
    {
      return !(left == right);
    }

    protected bool Equals(ProxyQueueItem other)
    {
      return this.Id == other.Id
             && object.Equals(this.Discriminator, other.Discriminator) 
             && this.ProjectId_Project_Sungero == other.ProjectId_Project_Sungero
             && this.DocumentId_Project_Sungero == other.DocumentId_Project_Sungero;
    }

  }
}