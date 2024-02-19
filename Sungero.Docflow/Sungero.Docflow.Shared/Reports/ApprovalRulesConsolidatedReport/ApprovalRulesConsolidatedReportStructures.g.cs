namespace Sungero.Docflow.Structures.ApprovalRulesConsolidatedReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.String reportSessionId, global::System.String approvalRule, global::System.Nullable<global::System.Int64> approvalRuleId, global::System.String approvalRuleUrl, global::System.Nullable<global::System.Int32> approvalRulePriority, global::System.String status, global::System.String documentKind, global::System.String documentFlow, global::System.String businessUnit, global::System.String department, global::System.String category, global::System.String documentParentType, global::System.String relation)
    {
      return new TableLine
      {
        ReportSessionId = reportSessionId,
        ApprovalRule = approvalRule,
        ApprovalRuleId = approvalRuleId,
        ApprovalRuleUrl = approvalRuleUrl,
        ApprovalRulePriority = approvalRulePriority,
        Status = status,
        DocumentKind = documentKind,
        DocumentFlow = documentFlow,
        BusinessUnit = businessUnit,
        Department = department,
        Category = category,
        DocumentParentType = documentParentType,
        Relation = relation
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ ((this.ApprovalRule != null ? this.ApprovalRule.GetHashCode() : 0) * 199) ^ ((this.ApprovalRuleId != null ? this.ApprovalRuleId.GetHashCode() : 0) * 199) ^ ((this.ApprovalRuleUrl != null ? this.ApprovalRuleUrl.GetHashCode() : 0) * 199) ^ ((this.ApprovalRulePriority != null ? this.ApprovalRulePriority.GetHashCode() : 0) * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199) ^ ((this.DocumentKind != null ? this.DocumentKind.GetHashCode() : 0) * 199) ^ ((this.DocumentFlow != null ? this.DocumentFlow.GetHashCode() : 0) * 199) ^ ((this.BusinessUnit != null ? this.BusinessUnit.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199) ^ ((this.Category != null ? this.Category.GetHashCode() : 0) * 199) ^ ((this.DocumentParentType != null ? this.DocumentParentType.GetHashCode() : 0) * 199) ^ ((this.Relation != null ? this.Relation.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((TableLine)obj);
    }

    public static bool operator ==(TableLine left, TableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(TableLine left, TableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(TableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId) 
             && object.Equals(this.ApprovalRule, other.ApprovalRule) 
             && object.Equals(this.ApprovalRuleId, other.ApprovalRuleId) 
             && object.Equals(this.ApprovalRuleUrl, other.ApprovalRuleUrl) 
             && object.Equals(this.ApprovalRulePriority, other.ApprovalRulePriority) 
             && object.Equals(this.Status, other.Status) 
             && object.Equals(this.DocumentKind, other.DocumentKind) 
             && object.Equals(this.DocumentFlow, other.DocumentFlow) 
             && object.Equals(this.BusinessUnit, other.BusinessUnit) 
             && object.Equals(this.Department, other.Department) 
             && object.Equals(this.Category, other.Category) 
             && object.Equals(this.DocumentParentType, other.DocumentParentType) 
             && object.Equals(this.Relation, other.Relation) ;
    }

  }
}