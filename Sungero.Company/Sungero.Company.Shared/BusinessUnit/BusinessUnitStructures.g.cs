namespace Sungero.Company.Structures.BusinessUnit
{
  public partial class BusinessUnitForRelations : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static BusinessUnitForRelations Create()
    {
      return new BusinessUnitForRelations();
    }

    public static BusinessUnitForRelations Create(global::System.Int64 id, global::Sungero.Company.IBusinessUnit headCompany)
    {
      return new BusinessUnitForRelations
      {
        Id = id,
        HeadCompany = headCompany
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.HeadCompany != null ? this.HeadCompany.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((BusinessUnitForRelations)obj);
    }

    public static bool operator ==(BusinessUnitForRelations left, BusinessUnitForRelations right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(BusinessUnitForRelations left, BusinessUnitForRelations right)
    {
      return !(left == right);
    }

    protected bool Equals(BusinessUnitForRelations other)
    {
      return this.Id == other.Id
             && object.Equals(this.HeadCompany, other.HeadCompany) ;
    }

  }
}