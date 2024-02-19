using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace DirRX.SignPlatform.Structures.Module
{
  
  /// <summary>
  /// Структура с данными о результате http-запроса в случае ошибок.
  /// </summary>
  partial class HttpRequestErrorResult
  {
    /// <summary>
    ///  Код ошибки.
    /// </summary>
    public string Code { get; set; }
    
    /// <summary>
    /// Связанное с ошибкой поле.
    /// </summary>
    public string Field { get; set; }
    
    /// <summary>
    /// Сообщение.
    /// </summary>
    public string Message { get; set; }
    
    /// <summary>
    /// Детали.
    /// </summary>
    public List<DirRX.SignPlatform.Structures.Module.HttpRequestErrorResult> Details { get; set; }
  }
  
  /// <summary>
  /// Код подтверждения запроса на выпуск сертификата.
  /// </summary>
  [Public]
  partial class ConfirmationCode
  {
    /// <summary>
    /// Код подтверждения.
    /// </summary>
    public string code { get; set; }
  }

  /// <summary>
  /// Запрос на подтверждение выпуска сертификата.
  /// </summary>
  [Public]
  partial class CertificateConfirmationRequest
  {
    /// <summary>
    /// Тип идентификации.
    /// </summary>
    public string identificationType { get; set; }
    
    /// <summary>
    /// Номер телефона.
    /// </summary>
    public string phoneNumber { get; set; }
  }
  /// <summary>
  /// Информация об облачном провайдере.
  /// </summary>
  [Public]
  partial class CloudSignProviderInfo
  {
    /// <summary>
    /// Наименование облачного провайдера.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Типы идентификации, которые поддерживает облачный провайдер.
    /// </summary>
    public System.Collections.Generic.Dictionary<string, string> IdentificationTypes { get; set; }
    
    /// <summary>
    /// Id провайдера.
    /// </summary>
    public string ProviderId { get; set; }
  }
  /// <summary>
  /// Параметры подключения пользователя к ЛК.
  /// </summary>
  [Public]
  partial class UserConnectionParams
  {
    /// <summary>
    /// Информация об облачном провайдере.
    /// </summary>
    public DirRX.SignPlatform.Structures.Module.ICloudSignProviderInfo CloudSignProviderInfo { get; set; }
    
    /// <summary>
    /// Признак того, что параметры выбраны и установлены.
    /// </summary>
    public bool IsSet { get; set; }
  }
  
  /// <summary>
  /// Запрос на смену типа второго фактора.
  /// </summary>
  partial class ConfirmationTypeRequest
  {
    /// <summary>
    /// Тип второго фактора.
    /// </summary>
    public string ConfirmationType {get; set;}
  }
  
  /// <summary>
  /// Запрос на выпуск сертификата.
  /// </summary>
  partial class CertificateIssueRequest
  {
    /// <summary>
    /// Логин сотрудника.
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Номер телефона сотрудника.
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    public string GivenName { get; set; }

    /// <summary>
    /// Отчество.
    /// </summary>
    public string Patronym { get; set; }

    /// <summary>
    /// Фамилия.
    /// </summary>
    public string Surname { get; set; }

    /// <summary>
    /// ИНН.
    /// </summary>
    public string Inn { get; set; }

    /// <summary>
    /// Адрес электронной почты.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Тип идентификации.
    /// </summary>
    public string IdentificationType { get; set; }

    /// <summary>
    /// Документы удостоверяющие личность.
    /// </summary>
    public List<DirRX.SignPlatform.Structures.Module.IdentityDocument> IdentityDocuments { get; set; }
  }
  
  /// <summary>
  /// Ответ на запрос выпуска сертификата.
  /// </summary>
  partial class CertificateIssueResponse
  {
    /// <summary>
    /// Идентификатор запроса.
    /// </summary>
    public long RequestId { get; set; }

    /// <summary>
    /// Идентификатор сертификата.
    /// </summary>
    public long? CertificateId { get; set; }

    /// <summary>
    /// Статус запроса.
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Описание ошибки.
    /// </summary>
    public string Error { get; set; }
  }

  /// <summary>
  /// Запрос на отзыв сертификата.
  /// </summary>
  partial class RevokeCertificateRequest
  {
    /// <summary>
    /// Отпечаток сертификата.
    /// </summary>
    public string Thumbprint { get; set; }

    /// <summary>
    /// Причина отзыва.
    /// </summary>
    public string RevocationReason { get; set; }
  }
  
  /// <summary>
  /// Запрос на создание заявления на выпуск сертификата.
  /// </summary>
  partial class CertificateIssueStatementRequest
  {
    /// <summary>
    /// Фамилия.
    /// </summary>
    public string Surname { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    public string GivenName { get; set; }

    /// <summary>
    /// Отчество.
    /// </summary>
    public string Patronym { get; set; }

    /// <summary>
    /// Дата рождения.
    /// </summary>
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// ИНН.
    /// </summary>
    public string Inn { get; set; }

    /// <summary>
    /// Тип идентификации.
    /// </summary>
    public string IdentificationType { get; set; }

    /// <summary>
    /// Документы удостоверяющие личность.
    /// </summary>
    public List<DirRX.SignPlatform.Structures.Module.IdentityDocument> IdentityDocuments { get; set; }

    /// <summary>
    /// Адрес электронной почты.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Номер телефона.
    /// </summary>
    public string PhoneNumber { get; set; }
  }
  
  /// <summary>
  /// Ответ на запрос создания заявления на выпуск сертификата.
  /// </summary>
  partial class CertificateIssueStatementResponse
  {
    /// <summary>
    /// Контент заявления в формате Base64.
    /// </summary>
    public string Base64Content { get; set; }

    /// <summary>
    /// MIME-тип контента.
    /// </summary>
    public string MediaTypeName { get; set; }
  }
  
  /// <summary>
  /// Документ удостоверяющий личность.
  /// </summary>
  partial class IdentityDocument
  {
    /// <summary>
    /// Тип документа удостоверяющего личность.
    /// </summary>
    public string IdentityDocumentType { get; set; }

    /// <summary>
    /// Серия.
    /// </summary>
    public string Series { get; set; }

    /// <summary>
    /// Номер.
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Пол.
    /// </summary>
    public string Gender { get; set; }

    /// <summary>
    /// Дата рождения.
    /// </summary>
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// Дата выдачи документа.
    /// </summary>
    public DateTime IssueDate { get; set; }

    /// <summary>
    /// Срок действия.
    /// </summary>
    public DateTime? ValidityPeriod { get; set; }
    
    /// <summary>
    /// Кем выдан документ.
    /// </summary>
    public string IssuedOrganization { get; set; }

    /// <summary>
    /// Код подразделения, выдавшего документ.
    /// </summary>
    public string IssuedOrganizationId { get; set; }
  }

  /// <summary>
  /// Структура с данными о результате http-запроса.
  /// </summary>
  partial class HttpRequestResult
  {
    /// <summary>
    ///  ИД запроса.
    /// </summary>
    public long RequestId { get; set; }
    
    /// <summary>
    /// ИД сертификата.
    /// </summary>
    public long? CertificateId { get; set; }
    
    /// <summary>
    /// Статус.
    /// </summary>
    public string Status { get; set; }
    
    /// <summary>
    /// Ошибки.
    /// </summary>
    public string Error { get; set; }
  }
  
  /// <summary>
  /// Структура ответа на запрос на создание сертификата.
  /// </summary>
  [Public]
  partial class CertificateIssueRequestResponse
  {
    /// <summary>
    /// ИД запроса.
    /// </summary>
    public long RequestId { get; set; }
    
    /// <summary>
    /// Ошибка.
    /// </summary>
    public string Error { get; set; }
  }
  
  /// <summary>
  /// Сертификат из сервиса подписания.
  /// </summary>
  [Public]
  partial class Certificate
  {    
    /// <summary>
    /// ID сертификата.
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// Кем выдан сертификат.
    /// </summary>
    public string OwnerCommonName { get; set; }
    
    /// <summary>
    /// Кому выдан сертификат.
    /// </summary>
    public string IssuerCommonName { get; set; }
    
    /// <summary>
    /// Начало срока действия.
    /// </summary>
    public DateTime ValidFrom { get; set; }
    
    /// <summary>
    /// Конец срока действия.
    /// </summary>
    public DateTime ValidTo { get; set; }
    
    /// <summary>
    /// Отпечаток сертификата.
    /// </summary>
    public string Thumbprint { get; set; }
    
    /// <summary>
    /// Сертификат (base 64).
    /// </summary>
    public string Content { get; set; }
    
    /// <summary>
    /// Id провайдера.
    /// </summary>
    public string ProviderId { get; set; }
    
    /// <summary>
    /// Id владельца сертификата.
    /// </summary>
    public string OwnerId { get; set; }
  }
  
  /// <summary>
  /// Структура с ошибками и действиями для них.
  /// </summary>
  [Public]
  partial class StartCertificateIssueTaskError
  {
    /// <summary>
    /// Ошибка.
    /// </summary>
    public string Error { get; set; }
    
    /// <summary>
    /// Призак показа действия Показать персону.
    /// </summary>
    public bool ShowPersonAction { get; set; }
  }
  
  /// <summary>
  /// Структура с результатами работы функции запуска задачи на выпуск сертификата.
  /// </summary>
  [Public]
  partial class StartCertificateIssueTaskResult
  {
    /// <summary>
    /// Признак того, что задача запущена.
    /// </summary>
    public bool IsStarted { get; set; }
    
    /// <summary>
    /// Ошибки заполнения данных.
    /// </summary>
    public List<DirRX.SignPlatform.Structures.Module.IStartCertificateIssueTaskError> DataErrorList { get; set; }
    
    /// <summary>
    /// Ошибка запуска задачи.
    /// </summary>
    public string StartTaskError { get; set; }
  }
  
  /// <summary>
  /// Структура с результатами работы функции изменения подтверждения при подписании.
  /// </summary>
  [Public]
  partial class ChangeConfirmationTypeForCertificateOwnerResult
  {
    /// <summary>
    /// Признак того, что изменение подтверждения при подписании успешно.
    /// </summary>
    public bool IsCompleted { get; set; }
    
    /// <summary>
    /// Текст ошибки изменения подтверждения при подписании.
    /// </summary>
    public string ErrorMessage { get; set; }
  }
}
