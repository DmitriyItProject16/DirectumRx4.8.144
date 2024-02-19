using System;
using Sungero.Core;

namespace DirRX.EssPlatform.Constants
{
  public static class Module
  {

    /// <summary>
    /// Тип подписи для работодателя, при импорте подписи из ЛК.
    /// </summary>
    [Public]
    public const string EmployerSignatureType = "EmployerApproval";
    
    public static class HelpCodes
    {
      public const string BulkSendInvantionsDialog = "DirRX_EssPlatform_BulkSendInvantions";
    }
    
    /// <summary>
    /// Имена целевых систем.
    /// </summary>
    [Public]
    public static class TargetNameSpaces
    {
      /// <summary>
      /// Имя целевой системы EssBase.
      /// </summary>
      [Public]
      public const string EssNameSpace = "EssBase";
    }
    
    /// <summary>
    /// Список имен объектов личного кабинета сотрудника.
    /// </summary>
    [Public]
    public static class ObjectCardTypeNames
    {
      /// <summary>
      /// Уведомление по выпуску сертификата облачной электронной подписи.
      /// </summary>
      [Public]
      public const string CertificateIssueNotice = "ICertificateIssueNotices";
      
      /// <summary>
      /// Уведомление о задании: Согласие с заявлением на выпуск сертификата.
      /// </summary>
      [Public]
      public const string CertificateIssueStatementAcceptAssignment = "ICertificateIssueStatementAcceptAssignments";
      
      /// <summary>
      /// Уведомление о задании: Ошибка при выпуске сертификата.
      /// </summary>
      [Public]
      public const string CertificateIssueErrorAssignment = "ICertificateIssueErrorAssignments";
    }

    /// <summary>
    /// Типы объектов Личного кабинета.
    /// </summary>
    [Public]
    public static class SelfOfficeObjectTypes
    {
      /// <summary>
      /// Тип рабочие элементы.
      /// </summary>
      [Public]
      public const string WorkItems = "workitems";
      
      /// <summary>
      /// Тип группы объектов.
      /// </summary>
      [Public]
      public const string FacilityGroups = "facilitygroups";
      
      /// <summary>
      /// Тип объект.
      /// </summary>
      [Public]
      public const string Facilities = "facilities";
    }

    /// <summary>
    /// Pattern для проверки формата номера телефона.
    /// </summary>
    [Public]
    public const string PhonePattern = @"\+[0-9] \([0-9]{3}\) [0-9]{3}-[0-9]{2}-[0-9]{2}";

    /// <summary>
    /// Guid роли "Администраторы системы электронного взаимодействия с сотрудниками".
    /// </summary>
    [Public]
    public static readonly Guid AdminElEmployeeInteractionSystem = Guid.Parse("DA5AE2FA-B7FE-40A8-A29C-F758F3D2F713");

    /// <summary>
    /// Guid роли "Пользователи с правами на доступ к ПДн".
    /// </summary>
    [Public]
    public static readonly Guid UsersWithAccessToIdentityDocument = Guid.Parse("1FA8995C-895C-43C0-A54E-19FEC8782D72");

    // Листы документы Excel для импорта оргструктуры.
    public static class ExcelImportWorksheetNames
    {
      /// <summary>
      /// Лист "Наши организации".
      /// </summary>
      public const string BusinessUnits = "НашиОрганизации";
      
      /// <summary>
      /// Лист "Подразделения".
      /// </summary>
      public const string Departments = "Подразделения";
      
      /// <summary>
      /// Лист "Сотрудники".
      /// </summary>
      public const string Employees = "Сотрудники";
    }
    
    // Максимальная длина пароля.
    public const int PasswordMaxLength = 50;

    // Имена сервисов ЛК, используемы в параметре audience в общениии сервисами
    public static class Audiences
    {
      /// <summary>
      /// Имя сервиса сообщений.
      /// </summary>
      public const string MessageBroker = "Directum.Core.MessageBroker";

      /// <summary>
      /// Имя сайта ЛК.
      /// </summary>
      public const string EssSite = "Directum.Core.EssSite";
      
      /// <summary>
      /// Имя сервиса ЛК.
      /// </summary>
      public const string EssService = "Directum.Core.EssService";
      
      /// <summary>
      /// Имя текущей системы.
      /// </summary>
      public const string CurrentSystem = "DirectumRX.HRPro";
    }
    
    // Запросы к Identity Service и EssService.
    public static class RequestApiIdentity
    {
      /// <summary>
      /// Запрос на аутентификацию.
      /// </summary>
      public const string Authentication = "api/SignIn/Password";
      
      /// <summary>
      /// Запрос на активацию пользователя.
      /// </summary>
      public const string ActivateUser = "api/accounts/";

      /// <summary>
      /// Запрос на обновление пользователя.
      /// </summary>
      public const string PatchEssUser = "api/accounts/{0}";
      
      /// <summary>
      /// Запрос на удаление пользователя.
      /// </summary>
      public const string DeleteEssUser = "api/accounts/{0}";
      
      /// <summary>
      /// Запрос на временное отключение пользователя.
      /// </summary>
      public const string DisableEssUser = "api/accounts/{0}/disable";
      
      /// <summary>
      /// Запрос на активацию временно отключенного пользователя.
      /// </summary>
      public const string ActivateDisabledEssUser = "api/accounts/{0}/activate";
      
      /// <summary>
      /// Запрос на поиск пользователя.
      /// </summary>
      public const string FindEssUser = "api/Users/{0}";
      
      /// <summary>
      /// Запрос на проверку подключения сервиса ЛК.
      /// </summary>
      public const string EssServiceHealth = "health";

    }
    
    // Тип выпускаемого токена.
    public const string TokenType = "jwt";

    // Запросы к MessageBroker
    public static class RequestApiMessageBroker
    {
      /// <summary>
      /// Запрос отправки sms.
      /// </summary>
      public const string Sms = "Sms?phone={0}";
      
      /// <summary>
      /// Запрос отправки e-mail.
      /// </summary>
      public const string Email = "email?to={0}&subject={1}";
      
      /// <summary>
      /// Запрос отправки сообщения в Viber.
      /// </summary>
      public const string Viber = "viber?phone={0}";
      
      /// <summary>
      /// Запрос на проверку подключения сервиса обмена cообщениями.
      /// </summary>
      public const string MessageBrokerHealth = "health";
      
      /// <summary>
      /// Запрос на отправку уведомления в ЛК.
      /// </summary>
      public const string MessageBrokerMessages = "Messages";
      
      /// <summary>
      /// Тип свойства, по которому идет идентификация пользователя.
      /// </summary>
      public const string CredentialType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
    }
    
    // Запросы к ЛК
    public static class RequestApiESS
    {
      /// <summary>
      /// Запрос на проверку подключения к ЛК.
      /// </summary>
      public const string ESSHealth = "health";
    }
    
    /// <summary>
    /// GUID прав.
    /// </summary>
    [Public]
    public static class DefaultAccessRightsTypeSid
    {
      /// <summary>
      /// Приглашение в ЛК.
      /// </summary>
      [Public]
      public static readonly Guid CreateEssUsers = Guid.Parse("d7df6c99-027e-4ef0-8a05-6ef3b57ab88f");

      /// <summary>
      /// доступ к действию "Выдать сертификат"
      /// </summary>
      [Public]
      public static readonly Guid CreateCertificateIssueTask = Guid.Parse("1DC0D7D6-B82A-49C3-9DD1-046C1DF3F5A8");
      
      /// <summary>
      /// доступ к действию "Отозвать сертификат"
      /// </summary>
      [Public]
      public static readonly Guid RevokeCertificateIssueTask = Guid.Parse("44E8FADD-AD0E-4C9F-AAA2-9B649C869FCD");
    }
    
    /// <summary>
    /// GUID справочника Сотрудники.
    /// </summary>
    public static readonly Guid EmployeeTypeGuid = Guid.Parse("b7905516-2be5-4931-961c-cb38d5677565");
    
    /// <summary>
    /// Допустимое количество попыток обращения к сервисам. До этого количества о неудачной попытке в логи пишем отладочное сообщение, после превышения - ошибку.
    /// </summary>
    public const int SendMessagePossibleRetryCount = 100;
    
    /// <summary>
    /// Допустимое количество попыток отправить приглашения пользователям в ЛК. После превышения пишем ошибку.
    /// </summary>
    public const int ActivateEssUsersPossibleRetryCount = 3;
    
    /// <summary>
    /// Допустимое количество попыток обновить данные сотрудника. После превышения пишем ошибку.
    /// </summary>
    public const int SynchronizeEmployee = 15;

    /// <summary>
    /// Параметр указывающий, что изменился способ подтверждения в сущности EssSetting
    /// </summary>
    [Public]
    public const string ConfirmationTypeChangedParamName = "ConfirmationTypeChanged";
    
    /// <summary>
    /// Параметр указывающий, что изменился телефон\email в сущности Employee
    /// </summary>
    [Public]
    public const string PhoneEmailChangedParamName = "PhoneEmailChanged";
    
    /// GUID роли "Действующий сотрудник" для личного кабинета.
    /// </summary>
    [Public]
    public const string RoleEssEmployeeActive = "ae78da22-9f02-46d1-a2e2-c8fc02d28614";
    
    /// <summary>
    /// Количество дней по умолчанию, за которое запускается задача на выпуск нового сертификата.
    /// </summary>
    [Public]
    public const int DefaultDaysToWarningCertificate = 3;
    
  }
}