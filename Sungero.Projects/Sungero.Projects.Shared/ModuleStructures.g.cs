namespace Sungero.Projects.Structures.Module
{
  public partial class RecipientRights : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static RecipientRights Create()
    {
      return new RecipientRights();
    }

    public static RecipientRights Create(global::Sungero.CoreEntities.IRecipient recipient, global::System.String accessRights)
    {
      return new RecipientRights
      {
        Recipient = recipient,
        AccessRights = accessRights
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Recipient != null ? this.Recipient.GetHashCode() : 0) * 199) ^ ((this.AccessRights != null ? this.AccessRights.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RecipientRights)obj);
    }

    public static bool operator ==(RecipientRights left, RecipientRights right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RecipientRights left, RecipientRights right)
    {
      return !(left == right);
    }

    protected bool Equals(RecipientRights other)
    {
      return object.Equals(this.Recipient, other.Recipient) 
             && object.Equals(this.AccessRights, other.AccessRights) ;
    }

  }
}