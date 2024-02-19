namespace Sungero.Shell.Structures.Module
{
  public partial class DepartmentLoad : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DepartmentLoad Create()
    {
      return new DepartmentLoad();
    }

    public static DepartmentLoad Create(global::Sungero.Company.IDepartment department, global::System.Int32 allAssignment, global::System.Int32 overduedAssignment)
    {
      return new DepartmentLoad
      {
        Department = department,
        AllAssignment = allAssignment,
        OverduedAssignment = overduedAssignment
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Department != null ? this.Department.GetHashCode() : 0) * 199) ^ (this.AllAssignment.GetHashCode() * 199) ^ (this.OverduedAssignment.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DepartmentLoad)obj);
    }

    public static bool operator ==(DepartmentLoad left, DepartmentLoad right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DepartmentLoad left, DepartmentLoad right)
    {
      return !(left == right);
    }

    protected bool Equals(DepartmentLoad other)
    {
      return object.Equals(this.Department, other.Department) 
             && this.AllAssignment == other.AllAssignment
             && this.OverduedAssignment == other.OverduedAssignment;
    }

  }

  public partial class PerformerLoad : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static PerformerLoad Create()
    {
      return new PerformerLoad();
    }

    public static PerformerLoad Create(global::Sungero.Company.IEmployee employee, global::System.Int32 allAssignment, global::System.Int32 overduedAssignment)
    {
      return new PerformerLoad
      {
        Employee = employee,
        AllAssignment = allAssignment,
        OverduedAssignment = overduedAssignment
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Employee != null ? this.Employee.GetHashCode() : 0) * 199) ^ (this.AllAssignment.GetHashCode() * 199) ^ (this.OverduedAssignment.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((PerformerLoad)obj);
    }

    public static bool operator ==(PerformerLoad left, PerformerLoad right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(PerformerLoad left, PerformerLoad right)
    {
      return !(left == right);
    }

    protected bool Equals(PerformerLoad other)
    {
      return object.Equals(this.Employee, other.Employee) 
             && this.AllAssignment == other.AllAssignment
             && this.OverduedAssignment == other.OverduedAssignment;
    }

  }

  [global::System.Serializable]
  public partial class LightAssignment : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static LightAssignment Create()
    {
      return new LightAssignment();
    }

    public static LightAssignment Create(global::System.Int64 id, global::System.Nullable<global::Sungero.Core.Enumeration> status, global::System.Nullable<global::System.DateTime> deadline, global::System.Nullable<global::System.DateTime> modified, global::System.Nullable<global::System.DateTime> created, global::System.Int64 performerId, global::System.Nullable<global::System.DateTime> factDeadline, global::System.Nullable<global::System.DateTime> completed)
    {
      return new LightAssignment
      {
        Id = id,
        Status = status,
        Deadline = deadline,
        Modified = modified,
        Created = created,
        PerformerId = performerId,
        FactDeadline = factDeadline,
        Completed = completed
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Modified != null ? this.Modified.GetHashCode() : 0) * 199) ^ ((this.Created != null ? this.Created.GetHashCode() : 0) * 199) ^ (this.PerformerId.GetHashCode() * 199) ^ ((this.FactDeadline != null ? this.FactDeadline.GetHashCode() : 0) * 199) ^ ((this.Completed != null ? this.Completed.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LightAssignment)obj);
    }

    public static bool operator ==(LightAssignment left, LightAssignment right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LightAssignment left, LightAssignment right)
    {
      return !(left == right);
    }

    protected bool Equals(LightAssignment other)
    {
      return this.Id == other.Id
             && object.Equals(this.Status, other.Status) 
             && object.Equals(this.Deadline, other.Deadline) 
             && object.Equals(this.Modified, other.Modified) 
             && object.Equals(this.Created, other.Created) 
             && this.PerformerId == other.PerformerId
             && object.Equals(this.FactDeadline, other.FactDeadline) 
             && object.Equals(this.Completed, other.Completed) ;
    }

  }

  [global::System.Serializable]
  public partial class PerformerLoadUniqueNames : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static PerformerLoadUniqueNames Create()
    {
      return new PerformerLoadUniqueNames();
    }

    public static PerformerLoadUniqueNames Create(global::System.String uniqueName, global::Sungero.Shell.Structures.Module.PerformerLoad performerLoad)
    {
      return new PerformerLoadUniqueNames
      {
        UniqueName = uniqueName,
        PerformerLoad = performerLoad
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.UniqueName != null ? this.UniqueName.GetHashCode() : 0) * 199) ^ ((this.PerformerLoad != null ? this.PerformerLoad.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((PerformerLoadUniqueNames)obj);
    }

    public static bool operator ==(PerformerLoadUniqueNames left, PerformerLoadUniqueNames right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(PerformerLoadUniqueNames left, PerformerLoadUniqueNames right)
    {
      return !(left == right);
    }

    protected bool Equals(PerformerLoadUniqueNames other)
    {
      return object.Equals(this.UniqueName, other.UniqueName) 
             && object.Equals(this.PerformerLoad, other.PerformerLoad) ;
    }

  }

  [global::System.Serializable]
  public partial class DepartmentLoadUniqueNames : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DepartmentLoadUniqueNames Create()
    {
      return new DepartmentLoadUniqueNames();
    }

    public static DepartmentLoadUniqueNames Create(global::System.String uniqueName, global::Sungero.Shell.Structures.Module.DepartmentLoad departmentLoad)
    {
      return new DepartmentLoadUniqueNames
      {
        UniqueName = uniqueName,
        DepartmentLoad = departmentLoad
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.UniqueName != null ? this.UniqueName.GetHashCode() : 0) * 199) ^ ((this.DepartmentLoad != null ? this.DepartmentLoad.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DepartmentLoadUniqueNames)obj);
    }

    public static bool operator ==(DepartmentLoadUniqueNames left, DepartmentLoadUniqueNames right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DepartmentLoadUniqueNames left, DepartmentLoadUniqueNames right)
    {
      return !(left == right);
    }

    protected bool Equals(DepartmentLoadUniqueNames other)
    {
      return object.Equals(this.UniqueName, other.UniqueName) 
             && object.Equals(this.DepartmentLoad, other.DepartmentLoad) ;
    }

  }

  public partial class DepartmentDiscipline : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DepartmentDiscipline Create()
    {
      return new DepartmentDiscipline();
    }

    public static DepartmentDiscipline Create(global::System.Nullable<global::System.Int32> discipline, global::Sungero.Company.IDepartment department)
    {
      return new DepartmentDiscipline
      {
        Discipline = discipline,
        Department = department
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Discipline != null ? this.Discipline.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DepartmentDiscipline)obj);
    }

    public static bool operator ==(DepartmentDiscipline left, DepartmentDiscipline right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DepartmentDiscipline left, DepartmentDiscipline right)
    {
      return !(left == right);
    }

    protected bool Equals(DepartmentDiscipline other)
    {
      return object.Equals(this.Discipline, other.Discipline) 
             && object.Equals(this.Department, other.Department) ;
    }

  }

  public partial class EmployeeDiscipline : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static EmployeeDiscipline Create()
    {
      return new EmployeeDiscipline();
    }

    public static EmployeeDiscipline Create(global::System.Nullable<global::System.Int32> discipline, global::Sungero.Company.IEmployee employee, global::System.Int32 overdueAsg)
    {
      return new EmployeeDiscipline
      {
        Discipline = discipline,
        Employee = employee,
        OverdueAsg = overdueAsg
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Discipline != null ? this.Discipline.GetHashCode() : 0) * 199) ^ ((this.Employee != null ? this.Employee.GetHashCode() : 0) * 199) ^ (this.OverdueAsg.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((EmployeeDiscipline)obj);
    }

    public static bool operator ==(EmployeeDiscipline left, EmployeeDiscipline right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(EmployeeDiscipline left, EmployeeDiscipline right)
    {
      return !(left == right);
    }

    protected bool Equals(EmployeeDiscipline other)
    {
      return object.Equals(this.Discipline, other.Discipline) 
             && object.Equals(this.Employee, other.Employee) 
             && this.OverdueAsg == other.OverdueAsg;
    }

  }

  [global::System.Serializable]
  public partial class EmployeeDisciplineUniqueName : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static EmployeeDisciplineUniqueName Create()
    {
      return new EmployeeDisciplineUniqueName();
    }

    public static EmployeeDisciplineUniqueName Create(global::System.String uniqueName, global::Sungero.Shell.Structures.Module.EmployeeDiscipline employeeDiscipline)
    {
      return new EmployeeDisciplineUniqueName
      {
        UniqueName = uniqueName,
        EmployeeDiscipline = employeeDiscipline
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.UniqueName != null ? this.UniqueName.GetHashCode() : 0) * 199) ^ ((this.EmployeeDiscipline != null ? this.EmployeeDiscipline.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((EmployeeDisciplineUniqueName)obj);
    }

    public static bool operator ==(EmployeeDisciplineUniqueName left, EmployeeDisciplineUniqueName right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(EmployeeDisciplineUniqueName left, EmployeeDisciplineUniqueName right)
    {
      return !(left == right);
    }

    protected bool Equals(EmployeeDisciplineUniqueName other)
    {
      return object.Equals(this.UniqueName, other.UniqueName) 
             && object.Equals(this.EmployeeDiscipline, other.EmployeeDiscipline) ;
    }

  }

  [global::System.Serializable]
  public partial class DepartmentDisciplineUniqueName : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DepartmentDisciplineUniqueName Create()
    {
      return new DepartmentDisciplineUniqueName();
    }

    public static DepartmentDisciplineUniqueName Create(global::System.String uniqueName, global::Sungero.Shell.Structures.Module.DepartmentDiscipline departmentDiscipline)
    {
      return new DepartmentDisciplineUniqueName
      {
        UniqueName = uniqueName,
        DepartmentDiscipline = departmentDiscipline
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.UniqueName != null ? this.UniqueName.GetHashCode() : 0) * 199) ^ ((this.DepartmentDiscipline != null ? this.DepartmentDiscipline.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DepartmentDisciplineUniqueName)obj);
    }

    public static bool operator ==(DepartmentDisciplineUniqueName left, DepartmentDisciplineUniqueName right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DepartmentDisciplineUniqueName left, DepartmentDisciplineUniqueName right)
    {
      return !(left == right);
    }

    protected bool Equals(DepartmentDisciplineUniqueName other)
    {
      return object.Equals(this.UniqueName, other.UniqueName) 
             && object.Equals(this.DepartmentDiscipline, other.DepartmentDiscipline) ;
    }

  }

  [global::System.Serializable]
  public partial class AssignmentChartGroup : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AssignmentChartGroup Create()
    {
      return new AssignmentChartGroup();
    }

    public static AssignmentChartGroup Create(global::System.String constantName, global::System.String resource, global::System.Int32 count)
    {
      return new AssignmentChartGroup
      {
        ConstantName = constantName,
        Resource = resource,
        Count = count
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ConstantName != null ? this.ConstantName.GetHashCode() : 0) * 199) ^ ((this.Resource != null ? this.Resource.GetHashCode() : 0) * 199) ^ (this.Count.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AssignmentChartGroup)obj);
    }

    public static bool operator ==(AssignmentChartGroup left, AssignmentChartGroup right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AssignmentChartGroup left, AssignmentChartGroup right)
    {
      return !(left == right);
    }

    protected bool Equals(AssignmentChartGroup other)
    {
      return object.Equals(this.ConstantName, other.ConstantName) 
             && object.Equals(this.Resource, other.Resource) 
             && this.Count == other.Count;
    }

  }
}