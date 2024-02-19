namespace Sungero.Parties.Structures.CompanyBase
{
  [global::System.Serializable]
  public partial class FoundCompanies : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static FoundCompanies Create()
    {
      return new FoundCompanies();
    }

    public static FoundCompanies Create(global::System.String message, global::System.Collections.Generic.List<global::Sungero.Parties.Structures.CompanyBase.CompanyDisplayValue> companyDisplayValues, global::System.Collections.Generic.List<global::Sungero.Parties.Structures.CompanyBase.FoundContact> foundContacts, global::System.Int32 amount)
    {
      return new FoundCompanies
      {
        Message = message,
        CompanyDisplayValues = companyDisplayValues,
        FoundContacts = foundContacts,
        Amount = amount
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Message != null ? this.Message.GetHashCode() : 0) * 199) ^ ((this.CompanyDisplayValues != null ? this.CompanyDisplayValues.GetHashCode() : 0) * 199) ^ ((this.FoundContacts != null ? this.FoundContacts.GetHashCode() : 0) * 199) ^ (this.Amount.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((FoundCompanies)obj);
    }

    public static bool operator ==(FoundCompanies left, FoundCompanies right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(FoundCompanies left, FoundCompanies right)
    {
      return !(left == right);
    }

    protected bool Equals(FoundCompanies other)
    {
      return object.Equals(this.Message, other.Message) 
             && global::System.Linq.Enumerable.SequenceEqual(this.CompanyDisplayValues, other.CompanyDisplayValues)
             && global::System.Linq.Enumerable.SequenceEqual(this.FoundContacts, other.FoundContacts)
             && this.Amount == other.Amount;
    }

  }

  [global::System.Serializable]
  public partial class CompanyDisplayValue : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static CompanyDisplayValue Create()
    {
      return new CompanyDisplayValue();
    }

    public static CompanyDisplayValue Create(global::System.String displayValue, global::System.String pSRN)
    {
      return new CompanyDisplayValue
      {
        DisplayValue = displayValue,
        PSRN = pSRN
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.DisplayValue != null ? this.DisplayValue.GetHashCode() : 0) * 199) ^ ((this.PSRN != null ? this.PSRN.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((CompanyDisplayValue)obj);
    }

    public static bool operator ==(CompanyDisplayValue left, CompanyDisplayValue right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(CompanyDisplayValue left, CompanyDisplayValue right)
    {
      return !(left == right);
    }

    protected bool Equals(CompanyDisplayValue other)
    {
      return object.Equals(this.DisplayValue, other.DisplayValue) 
             && object.Equals(this.PSRN, other.PSRN) ;
    }

  }

  [global::System.Serializable]
  public partial class FoundContact : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static FoundContact Create()
    {
      return new FoundContact();
    }

    public static FoundContact Create(global::System.String fullName, global::System.String jobTitle, global::System.String phone)
    {
      return new FoundContact
      {
        FullName = fullName,
        JobTitle = jobTitle,
        Phone = phone
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.FullName != null ? this.FullName.GetHashCode() : 0) * 199) ^ ((this.JobTitle != null ? this.JobTitle.GetHashCode() : 0) * 199) ^ ((this.Phone != null ? this.Phone.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((FoundContact)obj);
    }

    public static bool operator ==(FoundContact left, FoundContact right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(FoundContact left, FoundContact right)
    {
      return !(left == right);
    }

    protected bool Equals(FoundContact other)
    {
      return object.Equals(this.FullName, other.FullName) 
             && object.Equals(this.JobTitle, other.JobTitle) 
             && object.Equals(this.Phone, other.Phone) ;
    }

  }

  [global::System.Serializable]
  public partial class BusinessEntity : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static BusinessEntity Create()
    {
      return new BusinessEntity();
    }

    public static BusinessEntity Create(global::System.String fullName, global::System.String shortName)
    {
      return new BusinessEntity
      {
        FullName = fullName,
        ShortName = shortName
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.FullName != null ? this.FullName.GetHashCode() : 0) * 199) ^ ((this.ShortName != null ? this.ShortName.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((BusinessEntity)obj);
    }

    public static bool operator ==(BusinessEntity left, BusinessEntity right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(BusinessEntity left, BusinessEntity right)
    {
      return !(left == right);
    }

    protected bool Equals(BusinessEntity other)
    {
      return object.Equals(this.FullName, other.FullName) 
             && object.Equals(this.ShortName, other.ShortName) ;
    }

  }
}