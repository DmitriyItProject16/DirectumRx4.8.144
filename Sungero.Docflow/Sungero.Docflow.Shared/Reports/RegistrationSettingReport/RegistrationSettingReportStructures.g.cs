namespace Sungero.Docflow.Structures.RegistrationSettingReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.String reportSessionId, global::System.Int32 id, global::System.String businessUnit, global::System.String documentFlow, global::System.Nullable<global::System.Int32> documentFlowIndex, global::System.String documentKind, global::System.String registrationSetting, global::System.String registrationSettingUri, global::System.Int32 priority, global::System.String departments, global::System.String settingType, global::System.String documentRegister, global::System.String documentRegisterUri, global::System.String numberExample)
    {
      return new TableLine
      {
        ReportSessionId = reportSessionId,
        Id = id,
        BusinessUnit = businessUnit,
        DocumentFlow = documentFlow,
        DocumentFlowIndex = documentFlowIndex,
        DocumentKind = documentKind,
        RegistrationSetting = registrationSetting,
        RegistrationSettingUri = registrationSettingUri,
        Priority = priority,
        Departments = departments,
        SettingType = settingType,
        DocumentRegister = documentRegister,
        DocumentRegisterUri = documentRegisterUri,
        NumberExample = numberExample
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ (this.Id.GetHashCode() * 199) ^ ((this.BusinessUnit != null ? this.BusinessUnit.GetHashCode() : 0) * 199) ^ ((this.DocumentFlow != null ? this.DocumentFlow.GetHashCode() : 0) * 199) ^ ((this.DocumentFlowIndex != null ? this.DocumentFlowIndex.GetHashCode() : 0) * 199) ^ ((this.DocumentKind != null ? this.DocumentKind.GetHashCode() : 0) * 199) ^ ((this.RegistrationSetting != null ? this.RegistrationSetting.GetHashCode() : 0) * 199) ^ ((this.RegistrationSettingUri != null ? this.RegistrationSettingUri.GetHashCode() : 0) * 199) ^ (this.Priority.GetHashCode() * 199) ^ ((this.Departments != null ? this.Departments.GetHashCode() : 0) * 199) ^ ((this.SettingType != null ? this.SettingType.GetHashCode() : 0) * 199) ^ ((this.DocumentRegister != null ? this.DocumentRegister.GetHashCode() : 0) * 199) ^ ((this.DocumentRegisterUri != null ? this.DocumentRegisterUri.GetHashCode() : 0) * 199) ^ ((this.NumberExample != null ? this.NumberExample.GetHashCode() : 0) * 199);
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
             && this.Id == other.Id
             && object.Equals(this.BusinessUnit, other.BusinessUnit) 
             && object.Equals(this.DocumentFlow, other.DocumentFlow) 
             && object.Equals(this.DocumentFlowIndex, other.DocumentFlowIndex) 
             && object.Equals(this.DocumentKind, other.DocumentKind) 
             && object.Equals(this.RegistrationSetting, other.RegistrationSetting) 
             && object.Equals(this.RegistrationSettingUri, other.RegistrationSettingUri) 
             && this.Priority == other.Priority
             && object.Equals(this.Departments, other.Departments) 
             && object.Equals(this.SettingType, other.SettingType) 
             && object.Equals(this.DocumentRegister, other.DocumentRegister) 
             && object.Equals(this.DocumentRegisterUri, other.DocumentRegisterUri) 
             && object.Equals(this.NumberExample, other.NumberExample) ;
    }

  }
}