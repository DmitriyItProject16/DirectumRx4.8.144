namespace Sungero.Docflow.Structures.ApprovalRuleCardReport
{
  [global::System.Serializable]
  public partial class CriteriaTableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static CriteriaTableLine Create()
    {
      return new CriteriaTableLine();
    }

    public static CriteriaTableLine Create(global::System.String reportSessionId, global::System.String criterion, global::System.String value, global::System.Nullable<global::System.Int64> valueId, global::System.String valueHyperlink)
    {
      return new CriteriaTableLine
      {
        ReportSessionId = reportSessionId,
        Criterion = criterion,
        Value = value,
        ValueId = valueId,
        ValueHyperlink = valueHyperlink
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ ((this.Criterion != null ? this.Criterion.GetHashCode() : 0) * 199) ^ ((this.Value != null ? this.Value.GetHashCode() : 0) * 199) ^ ((this.ValueId != null ? this.ValueId.GetHashCode() : 0) * 199) ^ ((this.ValueHyperlink != null ? this.ValueHyperlink.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((CriteriaTableLine)obj);
    }

    public static bool operator ==(CriteriaTableLine left, CriteriaTableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(CriteriaTableLine left, CriteriaTableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(CriteriaTableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && object.Equals(this.Criterion, other.Criterion) 
             && object.Equals(this.Value, other.Value) 
             && object.Equals(this.ValueId, other.ValueId) 
             && object.Equals(this.ValueHyperlink, other.ValueHyperlink) ;
    }

  }

  [global::System.Serializable]
  public partial class ConditionTableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ConditionTableLine Create()
    {
      return new ConditionTableLine();
    }

    public static ConditionTableLine Create(global::System.String reportSessionId, global::System.String prefix, global::System.String header, global::System.String stageType, global::System.String performers, global::System.String deadline, global::System.String parameters, global::System.String item, global::System.String text, global::System.String ruleId, global::System.String hyperlink, global::System.Int32 level, global::System.Int32 id, global::System.Boolean isCondition, global::System.Int32 tableLineId)
    {
      return new ConditionTableLine
      {
        ReportSessionId = reportSessionId,
        Prefix = prefix,
        Header = header,
        StageType = stageType,
        Performers = performers,
        Deadline = deadline,
        Parameters = parameters,
        Item = item,
        Text = text,
        RuleId = ruleId,
        Hyperlink = hyperlink,
        Level = level,
        Id = id,
        IsCondition = isCondition,
        TableLineId = tableLineId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ ((this.Prefix != null ? this.Prefix.GetHashCode() : 0) * 199) ^ ((this.Header != null ? this.Header.GetHashCode() : 0) * 199) ^ ((this.StageType != null ? this.StageType.GetHashCode() : 0) * 199) ^ ((this.Performers != null ? this.Performers.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Parameters != null ? this.Parameters.GetHashCode() : 0) * 199) ^ ((this.Item != null ? this.Item.GetHashCode() : 0) * 199) ^ ((this.Text != null ? this.Text.GetHashCode() : 0) * 199) ^ ((this.RuleId != null ? this.RuleId.GetHashCode() : 0) * 199) ^ ((this.Hyperlink != null ? this.Hyperlink.GetHashCode() : 0) * 199) ^ (this.Level.GetHashCode() * 199) ^ (this.Id.GetHashCode() * 199) ^ (this.IsCondition.GetHashCode() * 199) ^ (this.TableLineId.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ConditionTableLine)obj);
    }

    public static bool operator ==(ConditionTableLine left, ConditionTableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ConditionTableLine left, ConditionTableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(ConditionTableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && object.Equals(this.Prefix, other.Prefix) 
             && object.Equals(this.Header, other.Header) 
             && object.Equals(this.StageType, other.StageType) 
             && object.Equals(this.Performers, other.Performers) 
             && object.Equals(this.Deadline, other.Deadline) 
             && object.Equals(this.Parameters, other.Parameters) 
             && object.Equals(this.Item, other.Item) 
             && object.Equals(this.Text, other.Text) 
             && object.Equals(this.RuleId, other.RuleId) 
             && object.Equals(this.Hyperlink, other.Hyperlink) 
             && this.Level == other.Level
             && this.Id == other.Id
             && this.IsCondition == other.IsCondition
             && this.TableLineId == other.TableLineId;
    }

  }

  [global::System.Serializable]
  public partial class SignatureSettingsTableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static SignatureSettingsTableLine Create()
    {
      return new SignatureSettingsTableLine();
    }

    public static SignatureSettingsTableLine Create(global::System.String reportSessionId, global::System.Int32 orderNumber, global::System.String name, global::System.Int64 id, global::System.String hyperlink, global::System.String unitsAndDeps, global::System.String kindsAndCategories, global::System.Int32 priority, global::System.String limits, global::System.String validTill, global::System.String note)
    {
      return new SignatureSettingsTableLine
      {
        ReportSessionId = reportSessionId,
        OrderNumber = orderNumber,
        Name = name,
        Id = id,
        Hyperlink = hyperlink,
        UnitsAndDeps = unitsAndDeps,
        KindsAndCategories = kindsAndCategories,
        Priority = priority,
        Limits = limits,
        ValidTill = validTill,
        Note = note
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ (this.OrderNumber.GetHashCode() * 199) ^ ((this.Name != null ? this.Name.GetHashCode() : 0) * 199) ^ (this.Id.GetHashCode() * 199) ^ ((this.Hyperlink != null ? this.Hyperlink.GetHashCode() : 0) * 199) ^ ((this.UnitsAndDeps != null ? this.UnitsAndDeps.GetHashCode() : 0) * 199) ^ ((this.KindsAndCategories != null ? this.KindsAndCategories.GetHashCode() : 0) * 199) ^ (this.Priority.GetHashCode() * 199) ^ ((this.Limits != null ? this.Limits.GetHashCode() : 0) * 199) ^ ((this.ValidTill != null ? this.ValidTill.GetHashCode() : 0) * 199) ^ ((this.Note != null ? this.Note.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SignatureSettingsTableLine)obj);
    }

    public static bool operator ==(SignatureSettingsTableLine left, SignatureSettingsTableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SignatureSettingsTableLine left, SignatureSettingsTableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(SignatureSettingsTableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && this.OrderNumber == other.OrderNumber
             && object.Equals(this.Name, other.Name) 
             && this.Id == other.Id
             && object.Equals(this.Hyperlink, other.Hyperlink) 
             && object.Equals(this.UnitsAndDeps, other.UnitsAndDeps) 
             && object.Equals(this.KindsAndCategories, other.KindsAndCategories) 
             && this.Priority == other.Priority
             && object.Equals(this.Limits, other.Limits) 
             && object.Equals(this.ValidTill, other.ValidTill) 
             && object.Equals(this.Note, other.Note) ;
    }

  }

  [global::System.Serializable]
  public partial class Transition : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static Transition Create()
    {
      return new Transition();
    }

    public static Transition Create(global::System.Nullable<global::System.Int32> sourceStage, global::System.Nullable<global::System.Boolean> conditionValue)
    {
      return new Transition
      {
        SourceStage = sourceStage,
        ConditionValue = conditionValue
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.SourceStage != null ? this.SourceStage.GetHashCode() : 0) * 199) ^ ((this.ConditionValue != null ? this.ConditionValue.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Transition)obj);
    }

    public static bool operator ==(Transition left, Transition right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(Transition left, Transition right)
    {
      return !(left == right);
    }

    protected bool Equals(Transition other)
    {
      return object.Equals(this.SourceStage, other.SourceStage) 
             && object.Equals(this.ConditionValue, other.ConditionValue) ;
    }

  }
}