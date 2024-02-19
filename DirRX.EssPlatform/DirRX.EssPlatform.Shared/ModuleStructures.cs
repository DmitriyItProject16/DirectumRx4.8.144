using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace DirRX.EssPlatform.Structures.Module
{

  /// <summary>
  /// Данные для синхронизации совместителей.
  /// </summary>
  [Public]
  partial class EmployeeSyncData
  {
    // ИД сотрудника.
    public long Id { get;set; }
    
    // Статус подключения к ЛК.
    public string personalAccountStatus { get;set; }
    
    // Личный телефон
    public string personalPhone { get;set; }
    
    // Признак необходимости рассыки по SMS.
    public bool smsNotification { get;set; }
    
    // Признак необходимости рассыки по Viber.
    public bool viberNotification { get;set; }
    
    // Признак необходимости рассыки по e-mail.
    public bool emailNotification { get;set; }
    
    // E-mail сотрудника.
    public string messagesEmail { get;set; }
  }
  
  /// <summary>
  /// Результаты почтовой рассылки.
  /// </summary>
  partial class MailSendingResult
  {
    public bool IsSuccess { get; set; }
    
    public bool AnyMailSended { get; set; }
  }

  #region Импорт оргструктуры
  /// <summary>
  /// Результат импорта данных с листа Excel.
  /// </summary>
  partial class ImportWorksheetResult
  {
    // Количество записей на листе.
    public int TotalCount { get; set; }
    
    // Ошибки импорта.
    public List<string> Errors { get; set; }
    
    // Данные, которые необходимо дозаполнить после основного импорта.
    public List<DirRX.EssPlatform.Structures.Module.ImportRefillData> RefillData { get; set; }
    
    // Количество импортированных с листа записей.
    public int ImportedCount { get; set; }
    
    // Количество частично импортированных записей (из всех импортированных).
    public int PartiallyImportedCount { get; set; }
    
    // Количество НОР, которые дополнительно созданы в результате импорта (заполнено только Наименование).
    public int EmptyBusinessUnitCreatedCount { get; set; }
    
    // Количество Подразделений, которые дополнительно созданы в результате импорта (заполнено только Наименование).
    public int EmptyDepartmentCreatedCount { get; set; }
    
    // Количество Персон, которые дополнительно созданы в результате импорта.
    public int PersonCreatedCount { get; set; }
    
    // Количество Должностей, которые дополнительно созданы в результате импорта.
    public int JobTitleCreatedCount { get; set; }
  }
  
  /// <summary>
  /// Результат импорта записи из Excel.
  /// </summary>
  partial class ImportRecordResult
  {
    // Импортированная запись.
    public Sungero.CoreEntities.IDatabookEntry Record { get; set; }
    
    // Ошибка импорта.
    public string Error { get; set; }
    
    // Предупреждения.
    public string Warnings { get; set; }
    
    // Наименование НОР, которое необхоидмо дозаполнить после основного импорта.
    public string RefillBusinessUnitName { get; set; }
    
    // Наименование Подразделения, которое необхоидмо дозаполнить после основного импорта.
    public string RefillDepartmentName { get; set; }
    
    // ФИО руководителя, которого необхоидмо дозаполнить после основного импорта.
    public string RefillEmployeeName { get; set; }
    
    // Признак того, что дополнительно в результате импорта записи была создана НОР (заполнено только Наименование).
    public bool IsEmptyBusinessUnitCreated { get; set; }
    
    // Признак того, что дополнительно в результате импорта записи было создано Подразделение (заполнено только Наименование).
    public bool IsEmptyDepartmentCreated { get; set; }
    
    // Признак того, что дополнительно в результате импорта записи была создана Персона.
    public bool IsPersonCreated { get; set; }
    
    // Признак того, что дополнительно в результате импорта записи была создана Должность.
    public bool IsJobTitleCreated { get; set; }
  }
  
  /// <summary>
  /// Данные о записи, которую необходимо дозаполнить после основого импорта.
  /// </summary>
  partial class ImportRefillData
  {
    // Импортированная запись.
    public Sungero.CoreEntities.IDatabookEntry Record { get; set; }
    
    // Наименование НОР, которую нужно дозаполнить после импорта.
    public string BusinessUnitName { get; set; }
    
    // Наименование Подразделения, которое нужно дозаполнить после импорта.
    public string DepartmentName { get; set; }
    
    // Наименование Сотрудника, которого нужно дозаполнить после импорта.
    public string EmployeeName { get; set; }
  }
  #endregion
  
  #region структуры для управления пользователями
  /// <summary>
  /// Результат задания пароля.
  /// </summary>
  partial class LoginResult
  {
    // Зашифрованный пароль.
    public string EncryptedPassword { get; set; }
    
    // Текст ошибки.
    public string Error { get; set; }
  }
  
  /// <summary>
  /// Дополнительный параметр.
  /// </summary>
  [Public]
  partial class Claim
  {
    /// <summary>
    /// ИД персоны.
    /// </summary>
    public long DirectumRX_PersonId { get; set; }
  }
  
  /// <summary>
  /// Структура для формирования данных для обновления пользователя.
  /// </summary>
  partial class UserPatchJson
  {
    
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string givenName { get; set; }
    
    /// <summary>
    /// Фамилия пользователя.
    /// </summary>
    public string surname { get; set; }
    
    /// <summary>
    /// Отчество пользователя.
    /// </summary>
    public string patronym { get; set; }
    
//    /// <summary>
//    /// Электронная почта пользователя.
//    /// </summary>
//    public string email { get; set; }
    
    /// <summary>
    /// Номер персонального телефона пользователя.
    /// </summary>
    public string phoneNumber { get; set; }
  }
  
  /// <summary>
  /// Структура для формирования данных о результатах создания личного кабинета для пользователей.
  /// </summary>
  [Public]
  partial class CreateEssUsersResults
  {
    /// <summary>
    /// Ошибка при выполнении запроса на создание личного кабинета.
    /// </summary>
    public string Error { get; set; }
    
    /// <summary>
    /// Количество приглашенных пользователей.
    /// </summary>
    public int InvitedUsersCount { get; set; }
    
    /// <summary>
    /// Количество пользователей, у которых не заполнен личный телефон.
    /// </summary>
    public int WithoutPhoneUsersCount { get; set; }
    
    /// <summary>
    /// Количество пользователей, у которых не заполнен рабочий либо личный Email.
    /// </summary>
    public int WithoutEmailUsersCount { get; set; }
    
    /// <summary>
    /// Количество пользователей, которым уже отправлено приглашение личный кабинет.
    /// </summary>
    public int AlreadyInvitedUsersCount { get; set; }
    
    /// <summary>
    /// Количество пользователей, у которых уже есть личный кабинет.
    /// </summary>
    public int AlreadyAcceptedUsersCount { get; set; }
    
    /// <summary>
    /// Количество пользователей, отправка приглашений которым привела к ошибке.
    /// </summary>
    public int CatchErrorUsersCount { get; set; }
  }

  /// <summary>
  /// Структура с данными о пользователе IdS.
  /// </summary>
  [Public]
  partial class IdSUserInfo
  {
    /// <summary>
    /// Ид пользователя.
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Полное имя пользователя.
    /// </summary>
    public string FullName { get; set; }
    
    /// <summary>
    /// Сокращенное имя пользователя.
    /// </summary>
    public string ShortName { get; set; }
    
    /// <summary>
    /// Электронная почта пользователя.
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Личный телефон пользователя.
    /// </summary>
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Метод аутентификации.
    /// </summary>
    public string AuthenticationMethod { get; set; }
  }
  
  /// <summary>
  /// Модель входа пользователя для получения токена аутентификациии от Ids.
  /// </summary>
  [Public]
  partial class UserSignIn
  {
    /// <summary>
    /// Логин пользователя.
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Пароль пользователя.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Назначение токена.
    /// </summary>
    public string Audience { get; set; }

    /// <summary>
    /// Тип выпускаемого токена.
    /// </summary>
    public string TokenType { get; set; }
  }
  
  /// <summary>
  /// Структура для создания пользователя в ЛК.
  /// </summary>
  [Public]
  partial class EssUserActivateJson
  {
    public string userName { get; set; }
    
    public DirRX.EssPlatform.Structures.Module.IPersonData person { get; set; }
    
    public DirRX.EssPlatform.Structures.Module.IClaim identities { get; set; }
    
    public DirRX.EssPlatform.Structures.Module.IAuthentication authentication { get; set; }
    
    public string inviteToResource {get; set; }
  }

  /// <summary>
  /// Данные персоны сотрудника для создания пользователя в ЛК.
  /// </summary>
  [Public]
  partial class PersonData
  {
    public string givenName { get; set; }
    
    public string surname { get; set; }
    
    public string patronym { get; set; }
    
    public string phone { get; set; }
  }
  
  /// <summary>
  ///  Данные аутентификации для создания пользователя в ЛК.
  /// </summary>
  [Public]
  partial class Authentication
  {
    public string provider { get; set; }
  }
  #endregion
  
  #region структура для низкоуровневых запросов
  
  /// <summary>
  /// Структура с данными о результате http-запроса.
  /// </summary>
  [Public]
  partial class HttpRequestResult
  {
    /// <summary>
    /// Код результата запроса.
    /// </summary>
    public int StatusCode { get; set; }
    
    /// <summary>
    /// Текст.
    /// </summary>
    public string RequestMessage { get; set; }
  }
  #endregion
  
  #region Сообщения-колокольчики
  [Public]
  partial class MessageBrokerNotification
  {
    public DirRX.EssPlatform.Structures.Module.IMessageBrokerNotificationIdentity Identity { get; set; }
    
    public string Title { get; set; }
    
    public string Content { get; set; }
    
    public int Priority { get; set; }
    
    public int DeliveryMethod { get; set; }
    
    public System.Collections.Generic.Dictionary<string, string> Properties { get; set; }
    
    public List<DirRX.EssPlatform.Structures.Module.IMessageBrokerNotificationAttachment> Attachments { get; set; }
  }
  
  // Получатель уведомления.
  [Public]
  partial class MessageBrokerNotificationIdentity
  {
    public string CredentialType { get; set; }
    
    public string CredentialValue { get; set; }
  }

  // вложения в сообщения
  [Public]
  partial class MessageBrokerNotificationAttachment
  {
    public string Title { get; set; }
    
    public string Url { get; set; }
  }
  #endregion

  #region Сервис интеграции
  
  /// <summary>
  /// Информация о подписи.
  /// </summary>
  partial class SignatureInfo
  {
    /// <summary>
    /// ИД подписанта.
    /// </summary>
    public long? SignatoryId {get; set; }
    
    /// <summary>
    /// ФИО подписанта.
    /// </summary>
    public string SignatoryFullName {get; set; }
    
    /// <summary>
    /// Дата подписания.
    /// </summary>
    public DateTime? SigningDate {get; set; }
    
    /// <summary>
    /// Тип подписи.
    /// </summary>
    public string SignatureType {get; set; }
    
    /// <summary>
    /// Комментарий.
    /// </summary>
    public string Comment {get; set; }
    
    /// <summary>
    /// Отпечаток подписи.
    /// </summary>
    public string CertificateThumbprint {get; set; }
  }
  
  // Вложения задачи/задания.
  [Public]
  partial class AttachmentInfo
  {
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public string EntityId { get; set; }
    
    /// <summary>
    /// Отображаемое значение.
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Тип вложения.
    /// </summary>
    public string EntityType { get; set; }
    
    /// <summary>
    /// Имя объекта вложения.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Группа вложения.
    /// </summary>
    public string Group { get; set; }
    
    /// <summary>
    /// Дата изменения.
    /// </summary>
    public DateTime? Modified { get; set; }
    
    /// <summary>
    /// Расширение (только для документов).
    /// </summary>
    public string Extension { get; set; }
    
    /// <summary>
    /// Размер в байтах (только для документов).
    /// </summary>
    public long? Size { get; set; }
  }

  // Структура для заполнения вложениями задачи/задания.
  [Public]
  partial class AttachDocumentsInfo
  {
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public string EntityId { get; set; }
    
    /// <summary>
    /// Группа вложения.
    /// </summary>
    public string Group { get; set; }
  }
  
  // Список должностей персоны.
  [Public]
  partial class PersonPostListInfo
  {
    /// <summary>
    /// Список должностей.
    /// </summary>
    public List<DirRX.EssPlatform.Structures.Module.IPersonPostInfo> positions { get; set; }
  }
  
  // Принадлежность актора (сотрудника, кандидата и т.п.) к ролям Личного кабинета
  [Public]
  partial class ActorRole
  {
    /// <summary>
    /// идентификатор действующего лица (сотрудника или кандидата)
    /// </summary>
    public long actorId { get; set; }
    
    /// <summary>
    /// Список имен ролей сотрудника
    /// </summary>
    public List<string> roles { get; set; }
  }

  // Роли личного кабинета и её акторы-участники (сотрудники, кандидаты и т.п.)
  [Public]
  partial class RoleActors
  {
    /// <summary>
    /// id роли
    /// </summary>
    public string role { get; set; }

    /// <summary>
    /// список идентификаторов действующего лица (сотрудников, кандидатов и т.д.)
    /// </summary>
    public List<long> actorIds { get; set; }
  }  
  
  // Должность персоны.
  [Public]
  partial class PersonPostInfo
  {
    /// <summary>
    /// Идентификатор сотрудника.
    /// </summary>
    public long id { get; set; }
    
    /// <summary>
    /// Организация.
    /// </summary>
    public string organization { get; set; }
    
    /// <summary>
    /// Подразделение.
    /// </summary>
    public string department { get; set; }
    
    /// <summary>
    /// Должность.
    /// </summary>
    public string title { get; set; }
    
    /// <summary>
    /// Признак должности основного сотрудника.
    /// </summary>
    public bool isPrimary { get; set; }

    /// <summary>
    /// Скрытый личный телефон.
    /// </summary>
    public string HiddenPersonalPhone { get; set; } 
  }
  
  /// <summary>
  /// Инофрмация об исполнителе задачи/задания.
  /// </summary>
  [Public]
  partial class PerformerInfo
  {
    /// <summary>
    /// Полное ФИО сотрудника.
    /// </summary>
    public string FullName { get; set; }
    
    /// <summary>
    /// Наименование НОР.
    /// </summary>
    public string Organization { get; set; }
    
    /// <summary>
    /// Наименование подразделения.
    /// </summary>
    public string Department { get; set; }
    
    /// <summary>
    /// Наименование должности.
    /// </summary>
    public string Position { get; set; }
  }
  
  /// <summary>
  /// Данные о сертификате сотрудника.
  /// </summary>
  [Public]
  partial class CertificateInfo
  {
    /// <summary>
    /// Эмитент.
    /// </summary>
    public string issuerInfo { get;set; }
    
    /// <summary>
    /// Серийный номер.
    /// </summary>
    public string serialNumber { get;set; }
    
    /// <summary>
    /// Инфо о субъекте.
    /// </summary>
    public string subjectInfo { get;set; }
    
    /// <summary>
    /// Отпечаток.
    /// </summary>
    public string thumbprint { get;set; }
    
    /// <summary>
    /// Период действия.
    /// </summary>
    public DirRX.EssPlatform.Structures.Module.IValidPeriod validPeriod { get; set; }
    
    /// <summary>
    /// GUID плагина подписания.
    /// </summary>
    public string pluginId { get;set; }

    /// <summary>
    /// Id провайдера.
    /// </summary>
    public string providerId { get;set; }
    
    /// <summary>
    /// ID владельца сертификата.
    /// </summary>
    public string certificateOwnerId { get; set; }
  }
  
  /// <summary>
  /// Период действия.
  /// </summary>
  [Public]
  partial class ValidPeriod
  {
    public DateTime? from { get;set; }
    
    public DateTime? to { get;set; }
  }
  #endregion
  
}