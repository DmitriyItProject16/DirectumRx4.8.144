
// ==================================================================
// Module.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public partial class CompanyModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"); }
    }

    public override string Name
    {
      get { return "Sungero.Company"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("eff95720-181f-4f7d-892d-dec034c7b2ab"), new Sungero.Company.Shared.BusinessUnitInfo(typeof(global::Sungero.Company.IBusinessUnit)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IBusinessUnitClientPublicFunctions, global::Sungero.Company.Client.BusinessUnitClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IBusinessUnitSharedPublicFunctions, global::Sungero.Company.Shared.BusinessUnitSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("2e3f162d-ef11-4ebc-84ef-c39069e5e94e"), new Sungero.Company.Shared.BusinessUnitRecipientLinksInfo(typeof(global::Sungero.Company.IBusinessUnitRecipientLinks)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("61b1c19f-26e2-49a5-b3d3-0d3618151e12"), new Sungero.Company.Shared.DepartmentInfo(typeof(global::Sungero.Company.IDepartment)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IDepartmentClientPublicFunctions, global::Sungero.Company.Client.DepartmentClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IDepartmentSharedPublicFunctions, global::Sungero.Company.Shared.DepartmentSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("a9e935d5-3b72-4e3a-9e43-711d8f32b84e"), new Sungero.Company.Shared.DepartmentRecipientLinksInfo(typeof(global::Sungero.Company.IDepartmentRecipientLinks)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("b7905516-2be5-4931-961c-cb38d5677565"), new Sungero.Company.Shared.EmployeeInfo(typeof(global::Sungero.Company.IEmployee)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IEmployeeClientPublicFunctions, global::Sungero.Company.Client.EmployeeClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IEmployeeSharedPublicFunctions, global::Sungero.Company.Shared.EmployeeSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("4a37aec4-764c-4c14-8887-e1ecafa5b4c5"), new Sungero.Company.Shared.JobTitleInfo(typeof(global::Sungero.Company.IJobTitle)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IJobTitleClientPublicFunctions, global::Sungero.Company.Client.JobTitleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IJobTitleSharedPublicFunctions, global::Sungero.Company.Shared.JobTitleSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("c2200a86-5d5d-47d6-930d-c3ce8b11f04b"), new Sungero.Company.Shared.ManagersAssistantInfo(typeof(global::Sungero.Company.IManagersAssistant)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IManagersAssistantClientPublicFunctions, global::Sungero.Company.Client.ManagersAssistantClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IManagersAssistantSharedPublicFunctions, global::Sungero.Company.Shared.ManagersAssistantSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("a03d0912-5ff1-4261-9d4b-64e210bca325"), new Sungero.Company.Shared.ManagersAssistantBaseInfo(typeof(global::Sungero.Company.IManagersAssistantBase)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IManagersAssistantBaseClientPublicFunctions, global::Sungero.Company.Client.ManagersAssistantBaseClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IManagersAssistantBaseSharedPublicFunctions, global::Sungero.Company.Shared.ManagersAssistantBaseSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("023eab79-c456-46bb-97b5-fbc764be9308"), new Sungero.Company.Shared.VisibilityRuleInfo(typeof(global::Sungero.Company.IVisibilityRule)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IVisibilityRuleClientPublicFunctions, global::Sungero.Company.Client.VisibilityRuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IVisibilityRuleSharedPublicFunctions, global::Sungero.Company.Shared.VisibilityRuleSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("b7dd2935-25a9-4dd2-802b-711cf4549df2"), new Sungero.Company.Shared.VisibilityRuleExcludedMembersInfo(typeof(global::Sungero.Company.IVisibilityRuleExcludedMembers)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("356ea70e-0e49-40e9-8eb2-4ea73e030539"), new Sungero.Company.Shared.VisibilityRuleRecipientsInfo(typeof(global::Sungero.Company.IVisibilityRuleRecipients)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("71565a4d-9d61-4783-9c7f-b001b7bc417c"), new Sungero.Company.Shared.VisibilityRuleVisibleMembersInfo(typeof(global::Sungero.Company.IVisibilityRuleVisibleMembers)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("435ba4a4-ee0a-4c43-b334-c243257f400f"), new Sungero.Company.Shared.VisibilitySettingInfo(typeof(global::Sungero.Company.IVisibilitySetting)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IVisibilitySettingClientPublicFunctions, global::Sungero.Company.Client.VisibilitySettingClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IVisibilitySettingSharedPublicFunctions, global::Sungero.Company.Shared.VisibilitySettingSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("e3186c22-e557-43ae-aa99-87dd89dcc1b0"), new Sungero.Company.Shared.VisibilitySettingHiddenRecipientsInfo(typeof(global::Sungero.Company.IVisibilitySettingHiddenRecipients)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("1bb06c07-eafe-4248-ac43-a0daaa30dd8c"), new Sungero.Company.Shared.VisibilitySettingUnrestrictedRecipientsInfo(typeof(global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients)));


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.IBusinessUnitFilterState, global::Sungero.Company.Shared.BusinessUnit.BusinessUnitFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.IDepartmentFilterState, global::Sungero.Company.Shared.Department.DepartmentFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.IEmployeeFilterState, global::Sungero.Company.Shared.Employee.EmployeeFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.IJobTitleFilterState, global::Sungero.Company.Shared.JobTitle.JobTitleFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.IManagersAssistantFilterState, global::Sungero.Company.Shared.ManagersAssistant.ManagersAssistantFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.IManagersAssistantBaseFilterState, global::Sungero.Company.Shared.ManagersAssistantBase.ManagersAssistantBaseFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.IVisibilityRuleFilterState, global::Sungero.Company.Shared.VisibilityRule.VisibilityRuleFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.IVisibilitySettingFilterState, global::Sungero.Company.Shared.VisibilitySetting.VisibilitySettingFilterState>();


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.FolderFilterState.IManagersAssistantsFilterState, global::Sungero.Company.Shared.ManagersAssistantsFilterState>();


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Client.IModuleClientPublicFunctions, global::Sungero.Company.Client.ModuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Company.Shared.IModuleSharedPublicFunctions, global::Sungero.Company.Shared.ModuleSharedPublicFunctions>();
    }
  }
}
