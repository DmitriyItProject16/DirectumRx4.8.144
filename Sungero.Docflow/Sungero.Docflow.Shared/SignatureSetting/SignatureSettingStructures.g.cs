namespace Sungero.Docflow.Structures.SignatureSetting
{
  [global::System.Serializable]
  public partial class Signatory : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static Signatory Create()
    {
      return new Signatory();
    }

    public static Signatory Create(global::System.Int64 employeeId, global::System.Int32 priority)
    {
      return new Signatory
      {
        EmployeeId = employeeId,
        Priority = priority
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.EmployeeId.GetHashCode() * 199) ^ (this.Priority.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Signatory)obj);
    }

    public static bool operator ==(Signatory left, Signatory right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(Signatory left, Signatory right)
    {
      return !(left == right);
    }

    protected bool Equals(Signatory other)
    {
      return this.EmployeeId == other.EmployeeId
             && this.Priority == other.Priority;
    }

  }

  public partial class SignatoryByDepartment : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static SignatoryByDepartment Create()
    {
      return new SignatoryByDepartment();
    }

    public static SignatoryByDepartment Create(global::Sungero.Company.IEmployee employee, global::Sungero.Company.IDepartment department, global::System.String conditions, global::System.Int32 priority)
    {
      return new SignatoryByDepartment
      {
        Employee = employee,
        Department = department,
        Conditions = conditions,
        Priority = priority
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Employee != null ? this.Employee.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199) ^ ((this.Conditions != null ? this.Conditions.GetHashCode() : 0) * 199) ^ (this.Priority.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SignatoryByDepartment)obj);
    }

    public static bool operator ==(SignatoryByDepartment left, SignatoryByDepartment right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SignatoryByDepartment left, SignatoryByDepartment right)
    {
      return !(left == right);
    }

    protected bool Equals(SignatoryByDepartment other)
    {
      return object.Equals(this.Employee, other.Employee) 
             && object.Equals(this.Department, other.Department) 
             && object.Equals(this.Conditions, other.Conditions) 
             && this.Priority == other.Priority;
    }

  }

  public partial class SignatoriesList : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static SignatoriesList Create()
    {
      return new SignatoriesList();
    }

    public static SignatoriesList Create(global::System.String employees, global::Sungero.Company.IDepartment department)
    {
      return new SignatoriesList
      {
        Employees = employees,
        Department = department
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Employees != null ? this.Employees.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SignatoriesList)obj);
    }

    public static bool operator ==(SignatoriesList left, SignatoriesList right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SignatoriesList left, SignatoriesList right)
    {
      return !(left == right);
    }

    protected bool Equals(SignatoriesList other)
    {
      return object.Equals(this.Employees, other.Employees) 
             && object.Equals(this.Department, other.Department) ;
    }

  }
}