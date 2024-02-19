namespace Sungero.Projects.Structures.ProjectCore
{
  public partial class ProjectMemberRights : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static ProjectMemberRights Create()
    {
      return new ProjectMemberRights();
    }

    public static ProjectMemberRights Create(global::Sungero.CoreEntities.IRecipient recipient, global::System.String projectRightsType, global::System.String foldersRightsType)
    {
      return new ProjectMemberRights
      {
        Recipient = recipient,
        ProjectRightsType = projectRightsType,
        FoldersRightsType = foldersRightsType
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Recipient != null ? this.Recipient.GetHashCode() : 0) * 199) ^ ((this.ProjectRightsType != null ? this.ProjectRightsType.GetHashCode() : 0) * 199) ^ ((this.FoldersRightsType != null ? this.FoldersRightsType.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ProjectMemberRights)obj);
    }

    public static bool operator ==(ProjectMemberRights left, ProjectMemberRights right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ProjectMemberRights left, ProjectMemberRights right)
    {
      return !(left == right);
    }

    protected bool Equals(ProjectMemberRights other)
    {
      return object.Equals(this.Recipient, other.Recipient) 
             && object.Equals(this.ProjectRightsType, other.ProjectRightsType) 
             && object.Equals(this.FoldersRightsType, other.FoldersRightsType) ;
    }

  }
}