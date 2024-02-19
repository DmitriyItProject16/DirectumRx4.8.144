namespace Sungero.Docflow.Structures.ApprovalReviewAssignment
{
  [global::System.Serializable]
  public partial class DocumentSignature : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DocumentSignature Create()
    {
      return new DocumentSignature();
    }

    public static DocumentSignature Create(global::System.Int64 signatureId, global::System.DateTime signingDate, global::System.Nullable<global::System.Int32> versionNumber)
    {
      return new DocumentSignature
      {
        SignatureId = signatureId,
        SigningDate = signingDate,
        VersionNumber = versionNumber
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.SignatureId.GetHashCode() * 199) ^ ((this.SigningDate != null ? this.SigningDate.GetHashCode() : 0) * 199) ^ ((this.VersionNumber != null ? this.VersionNumber.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DocumentSignature)obj);
    }

    public static bool operator ==(DocumentSignature left, DocumentSignature right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DocumentSignature left, DocumentSignature right)
    {
      return !(left == right);
    }

    protected bool Equals(DocumentSignature other)
    {
      return this.SignatureId == other.SignatureId
             && object.Equals(this.SigningDate, other.SigningDate) 
             && object.Equals(this.VersionNumber, other.VersionNumber) ;
    }

  }

  public partial class SignaturesInfo : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static SignaturesInfo Create()
    {
      return new SignaturesInfo();
    }

    public static SignaturesInfo Create(global::Sungero.CoreEntities.IUser signatory, global::Sungero.CoreEntities.IUser substitutedUser, global::System.String signatoryType)
    {
      return new SignaturesInfo
      {
        Signatory = signatory,
        SubstitutedUser = substitutedUser,
        SignatoryType = signatoryType
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Signatory != null ? this.Signatory.GetHashCode() : 0) * 199) ^ ((this.SubstitutedUser != null ? this.SubstitutedUser.GetHashCode() : 0) * 199) ^ ((this.SignatoryType != null ? this.SignatoryType.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SignaturesInfo)obj);
    }

    public static bool operator ==(SignaturesInfo left, SignaturesInfo right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SignaturesInfo left, SignaturesInfo right)
    {
      return !(left == right);
    }

    protected bool Equals(SignaturesInfo other)
    {
      return object.Equals(this.Signatory, other.Signatory) 
             && object.Equals(this.SubstitutedUser, other.SubstitutedUser) 
             && object.Equals(this.SignatoryType, other.SignatoryType) ;
    }

  }
}