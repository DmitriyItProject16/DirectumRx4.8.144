
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

namespace Sungero.ExchangeCore.Client
{
  public partial class ExchangeCoreModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"); }
    }

    public override string Name
    {
      get { return "Sungero.ExchangeCore"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("2d30e2aa-1d0b-45f0-8e4d-00318b3a5cfd"), new Sungero.ExchangeCore.Shared.BodyConverterQueueItemInfo(typeof(global::Sungero.ExchangeCore.IBodyConverterQueueItem)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IBodyConverterQueueItemClientPublicFunctions, global::Sungero.ExchangeCore.Client.BodyConverterQueueItemClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IBodyConverterQueueItemSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.BodyConverterQueueItemSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f91dcce6-a914-4c04-aba1-0f940475696b"), new Sungero.ExchangeCore.Shared.BoxBaseInfo(typeof(global::Sungero.ExchangeCore.IBoxBase)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IBoxBaseClientPublicFunctions, global::Sungero.ExchangeCore.Client.BoxBaseClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IBoxBaseSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.BoxBaseSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("2dd7a803-8db7-40e1-9da6-b41c62d367c8"), new Sungero.ExchangeCore.Shared.BusinessUnitBoxInfo(typeof(global::Sungero.ExchangeCore.IBusinessUnitBox)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IBusinessUnitBoxClientPublicFunctions, global::Sungero.ExchangeCore.Client.BusinessUnitBoxClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IBusinessUnitBoxSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.BusinessUnitBoxSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("6b3c4688-1125-4f7e-a24b-7cd485aab591"), new Sungero.ExchangeCore.Shared.BusinessUnitBoxExchangeServiceCertificatesInfo(typeof(global::Sungero.ExchangeCore.IBusinessUnitBoxExchangeServiceCertificates)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("104002d1-f1a5-4ddc-9f4f-cdf25384c9cf"), new Sungero.ExchangeCore.Shared.BusinessUnitBoxFormalizedPoAInfosInfo(typeof(global::Sungero.ExchangeCore.IBusinessUnitBoxFormalizedPoAInfos)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("d4870243-705a-483a-bcc2-89e53b80073f"), new Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentInfo(typeof(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.ICounterpartyConflictProcessingAssignmentClientPublicFunctions, global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.ICounterpartyConflictProcessingAssignmentSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("03a51b42-a322-4574-90bb-212ea03ed71e"), new Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskInfo(typeof(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTask)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.ICounterpartyConflictProcessingTaskClientPublicFunctions, global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingTaskClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.ICounterpartyConflictProcessingTaskSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("a4350ce1-ab53-4c07-8889-e5f3e736fe18"), new Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTaskObserversInfo(typeof(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskObservers)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("06c49e09-4c22-453b-9c96-d55fd38ed048"), new Sungero.ExchangeCore.Shared.CounterpartyDepartmentBoxInfo(typeof(global::Sungero.ExchangeCore.ICounterpartyDepartmentBox)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.ICounterpartyDepartmentBoxClientPublicFunctions, global::Sungero.ExchangeCore.Client.CounterpartyDepartmentBoxClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.ICounterpartyDepartmentBoxSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.CounterpartyDepartmentBoxSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("50a0d7aa-1f04-4e4a-8f0c-044e0ba99949"), new Sungero.ExchangeCore.Shared.CounterpartyQueueItemInfo(typeof(global::Sungero.ExchangeCore.ICounterpartyQueueItem)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.ICounterpartyQueueItemClientPublicFunctions, global::Sungero.ExchangeCore.Client.CounterpartyQueueItemClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.ICounterpartyQueueItemSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.CounterpartyQueueItemSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("fd8945e2-e3b6-43f9-aac1-fb7ce4d984c6"), new Sungero.ExchangeCore.Shared.DepartmentBoxInfo(typeof(global::Sungero.ExchangeCore.IDepartmentBox)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IDepartmentBoxClientPublicFunctions, global::Sungero.ExchangeCore.Client.DepartmentBoxClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IDepartmentBoxSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.DepartmentBoxSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("d6c0fcaf-4ac9-4a6a-9e2c-8fed1e35c08a"), new Sungero.ExchangeCore.Shared.ExchangeServiceInfo(typeof(global::Sungero.ExchangeCore.IExchangeService)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IExchangeServiceClientPublicFunctions, global::Sungero.ExchangeCore.Client.ExchangeServiceClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IExchangeServiceSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.ExchangeServiceSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("66bde409-ecf7-4982-9278-c4da37e57fec"), new Sungero.ExchangeCore.Shared.HistoricalMessagesDownloadSessionInfo(typeof(global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSession)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IHistoricalMessagesDownloadSessionClientPublicFunctions, global::Sungero.ExchangeCore.Client.HistoricalMessagesDownloadSessionClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IHistoricalMessagesDownloadSessionSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.HistoricalMessagesDownloadSessionSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("cf5edde0-03df-4db3-9e1e-15b22cf3198c"), new Sungero.ExchangeCore.Shared.IncomingInvitationAssignmentInfo(typeof(global::Sungero.ExchangeCore.IIncomingInvitationAssignment)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IIncomingInvitationAssignmentClientPublicFunctions, global::Sungero.ExchangeCore.Client.IncomingInvitationAssignmentClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IIncomingInvitationAssignmentSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.IncomingInvitationAssignmentSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("1e5b11de-bd28-4dc2-a03c-74b8db9ac1c4"), new Sungero.ExchangeCore.Shared.IncomingInvitationTaskInfo(typeof(global::Sungero.ExchangeCore.IIncomingInvitationTask)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IIncomingInvitationTaskClientPublicFunctions, global::Sungero.ExchangeCore.Client.IncomingInvitationTaskClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IIncomingInvitationTaskSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.IncomingInvitationTaskSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f987aacd-10e2-4009-bb5c-762bf66ba50d"), new Sungero.ExchangeCore.Shared.IncomingInvitationTaskObserversInfo(typeof(global::Sungero.ExchangeCore.IIncomingInvitationTaskObservers)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f9a3ec37-0fd4-4343-a295-9394ba830a0e"), new Sungero.ExchangeCore.Shared.MessageQueueItemInfo(typeof(global::Sungero.ExchangeCore.IMessageQueueItem)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IMessageQueueItemClientPublicFunctions, global::Sungero.ExchangeCore.Client.MessageQueueItemClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IMessageQueueItemSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.MessageQueueItemSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("ff5abd47-6495-4a84-9efc-3b08afebc6af"), new Sungero.ExchangeCore.Shared.MessageQueueItemDocumentsInfo(typeof(global::Sungero.ExchangeCore.IMessageQueueItemDocuments)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("4e09273f-8b3a-489e-814e-a4ebfbba3e6c"), new Sungero.ExchangeCore.Shared.QueueItemBaseInfo(typeof(global::Sungero.ExchangeCore.IQueueItemBase)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IQueueItemBaseClientPublicFunctions, global::Sungero.ExchangeCore.Client.QueueItemBaseClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IQueueItemBaseSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.QueueItemBaseSharedPublicFunctions>();


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IBodyConverterQueueItemFilterState, global::Sungero.ExchangeCore.Shared.BodyConverterQueueItem.BodyConverterQueueItemFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IBoxBaseFilterState, global::Sungero.ExchangeCore.Shared.BoxBase.BoxBaseFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IBusinessUnitBoxFilterState, global::Sungero.ExchangeCore.Shared.BusinessUnitBox.BusinessUnitBoxFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentFilterState, global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignment.CounterpartyConflictProcessingAssignmentFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingTaskFilterState, global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingTask.CounterpartyConflictProcessingTaskFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.ICounterpartyDepartmentBoxFilterState, global::Sungero.ExchangeCore.Shared.CounterpartyDepartmentBox.CounterpartyDepartmentBoxFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.ICounterpartyQueueItemFilterState, global::Sungero.ExchangeCore.Shared.CounterpartyQueueItem.CounterpartyQueueItemFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IDepartmentBoxFilterState, global::Sungero.ExchangeCore.Shared.DepartmentBox.DepartmentBoxFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IExchangeServiceFilterState, global::Sungero.ExchangeCore.Shared.ExchangeService.ExchangeServiceFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IHistoricalMessagesDownloadSessionFilterState, global::Sungero.ExchangeCore.Shared.HistoricalMessagesDownloadSession.HistoricalMessagesDownloadSessionFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IIncomingInvitationAssignmentFilterState, global::Sungero.ExchangeCore.Shared.IncomingInvitationAssignment.IncomingInvitationAssignmentFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IIncomingInvitationTaskFilterState, global::Sungero.ExchangeCore.Shared.IncomingInvitationTask.IncomingInvitationTaskFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IMessageQueueItemFilterState, global::Sungero.ExchangeCore.Shared.MessageQueueItem.MessageQueueItemFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.IQueueItemBaseFilterState, global::Sungero.ExchangeCore.Shared.QueueItemBase.QueueItemBaseFilterState>();



      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Client.IModuleClientPublicFunctions, global::Sungero.ExchangeCore.Client.ModuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.ExchangeCore.Shared.IModuleSharedPublicFunctions, global::Sungero.ExchangeCore.Shared.ModuleSharedPublicFunctions>();
    }
  }
}
