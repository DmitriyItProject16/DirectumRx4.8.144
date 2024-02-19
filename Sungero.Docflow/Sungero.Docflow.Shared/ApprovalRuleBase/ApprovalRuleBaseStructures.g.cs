namespace Sungero.Docflow.Structures.ApprovalRuleBase
{
  public partial class StageWithUnsupportedRole : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static StageWithUnsupportedRole Create()
    {
      return new StageWithUnsupportedRole();
    }

    public static StageWithUnsupportedRole Create(global::Sungero.Docflow.IApprovalRuleBaseStages stage, global::Sungero.Core.Enumeration role)
    {
      return new StageWithUnsupportedRole
      {
        Stage = stage,
        Role = role
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Stage != null ? this.Stage.GetHashCode() : 0) * 199) ^ ((this.Role != null ? this.Role.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((StageWithUnsupportedRole)obj);
    }

    public static bool operator ==(StageWithUnsupportedRole left, StageWithUnsupportedRole right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(StageWithUnsupportedRole left, StageWithUnsupportedRole right)
    {
      return !(left == right);
    }

    protected bool Equals(StageWithUnsupportedRole other)
    {
      return object.Equals(this.Stage, other.Stage) 
             && object.Equals(this.Role, other.Role) ;
    }

  }

  [global::System.Serializable]
  public partial class StagesVariants : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static StagesVariants Create()
    {
      return new StagesVariants();
    }

    public static StagesVariants Create(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Int32>> allSteps, global::System.Collections.Generic.List<global::System.Int32> unreachebleSteps)
    {
      return new StagesVariants
      {
        AllSteps = allSteps,
        UnreachebleSteps = unreachebleSteps
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.AllSteps != null ? this.AllSteps.GetHashCode() : 0) * 199) ^ ((this.UnreachebleSteps != null ? this.UnreachebleSteps.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((StagesVariants)obj);
    }

    public static bool operator ==(StagesVariants left, StagesVariants right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(StagesVariants left, StagesVariants right)
    {
      return !(left == right);
    }

    protected bool Equals(StagesVariants other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.AllSteps, other.AllSteps)
             && global::System.Linq.Enumerable.SequenceEqual(this.UnreachebleSteps, other.UnreachebleSteps);
    }

  }

  public partial class StagesIncorrectRoles : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static StagesIncorrectRoles Create()
    {
      return new StagesIncorrectRoles();
    }

    public static StagesIncorrectRoles Create(global::Sungero.Docflow.IApprovalRuleBaseStages stage, global::System.String message)
    {
      return new StagesIncorrectRoles
      {
        Stage = stage,
        Message = message
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Stage != null ? this.Stage.GetHashCode() : 0) * 199) ^ ((this.Message != null ? this.Message.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((StagesIncorrectRoles)obj);
    }

    public static bool operator ==(StagesIncorrectRoles left, StagesIncorrectRoles right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(StagesIncorrectRoles left, StagesIncorrectRoles right)
    {
      return !(left == right);
    }

    protected bool Equals(StagesIncorrectRoles other)
    {
      return object.Equals(this.Stage, other.Stage) 
             && object.Equals(this.Message, other.Message) ;
    }

  }

  public partial class BlockPerformers : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static BlockPerformers Create()
    {
      return new BlockPerformers();
    }

    public static BlockPerformers Create(global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> employees, global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient> recipient, global::System.String message)
    {
      return new BlockPerformers
      {
        Employees = employees,
        Recipient = recipient,
        Message = message
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Employees != null ? this.Employees.GetHashCode() : 0) * 199) ^ ((this.Recipient != null ? this.Recipient.GetHashCode() : 0) * 199) ^ ((this.Message != null ? this.Message.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((BlockPerformers)obj);
    }

    public static bool operator ==(BlockPerformers left, BlockPerformers right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(BlockPerformers left, BlockPerformers right)
    {
      return !(left == right);
    }

    protected bool Equals(BlockPerformers other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Employees, other.Employees)
             && global::System.Linq.Enumerable.SequenceEqual(this.Recipient, other.Recipient)
             && object.Equals(this.Message, other.Message) ;
    }

  }

  [global::System.Serializable]
  public partial class NextStageNumber : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static NextStageNumber Create()
    {
      return new NextStageNumber();
    }

    public static NextStageNumber Create(global::System.Nullable<global::System.Int32> number, global::System.String message)
    {
      return new NextStageNumber
      {
        Number = number,
        Message = message
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Number != null ? this.Number.GetHashCode() : 0) * 199) ^ ((this.Message != null ? this.Message.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((NextStageNumber)obj);
    }

    public static bool operator ==(NextStageNumber left, NextStageNumber right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(NextStageNumber left, NextStageNumber right)
    {
      return !(left == right);
    }

    protected bool Equals(NextStageNumber other)
    {
      return object.Equals(this.Number, other.Number) 
             && object.Equals(this.Message, other.Message) ;
    }

  }

  [global::System.Serializable]
  public partial class RouteStep : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static RouteStep Create()
    {
      return new RouteStep();
    }

    public static RouteStep Create(global::System.Int32 stepNumber, global::System.Boolean branch)
    {
      return new RouteStep
      {
        StepNumber = stepNumber,
        Branch = branch
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.StepNumber.GetHashCode() * 199) ^ (this.Branch.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RouteStep)obj);
    }

    public static bool operator ==(RouteStep left, RouteStep right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RouteStep left, RouteStep right)
    {
      return !(left == right);
    }

    protected bool Equals(RouteStep other)
    {
      return this.StepNumber == other.StepNumber
             && this.Branch == other.Branch;
    }

  }

  [global::System.Serializable]
  public partial class ConditionRouteStep : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ConditionRouteStep Create()
    {
      return new ConditionRouteStep();
    }

    public static ConditionRouteStep Create(global::Sungero.Docflow.Structures.ApprovalRuleBase.RouteStep routeStep, global::System.Nullable<global::Sungero.Core.Enumeration> conditionType)
    {
      return new ConditionRouteStep
      {
        RouteStep = routeStep,
        ConditionType = conditionType
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.RouteStep != null ? this.RouteStep.GetHashCode() : 0) * 199) ^ ((this.ConditionType != null ? this.ConditionType.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ConditionRouteStep)obj);
    }

    public static bool operator ==(ConditionRouteStep left, ConditionRouteStep right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ConditionRouteStep left, ConditionRouteStep right)
    {
      return !(left == right);
    }

    protected bool Equals(ConditionRouteStep other)
    {
      return object.Equals(this.RouteStep, other.RouteStep) 
             && object.Equals(this.ConditionType, other.ConditionType) ;
    }

  }

  [global::System.Serializable]
  public partial class StageStatusInfo : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static StageStatusInfo Create()
    {
      return new StageStatusInfo();
    }

    public static StageStatusInfo Create(global::System.Boolean isLast, global::System.Boolean inProcess, global::System.Boolean isNext)
    {
      return new StageStatusInfo
      {
        IsLast = isLast,
        InProcess = inProcess,
        IsNext = isNext
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.IsLast.GetHashCode() * 199) ^ (this.InProcess.GetHashCode() * 199) ^ (this.IsNext.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((StageStatusInfo)obj);
    }

    public static bool operator ==(StageStatusInfo left, StageStatusInfo right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(StageStatusInfo left, StageStatusInfo right)
    {
      return !(left == right);
    }

    protected bool Equals(StageStatusInfo other)
    {
      return this.IsLast == other.IsLast
             && this.InProcess == other.InProcess
             && this.IsNext == other.IsNext;
    }

  }
}