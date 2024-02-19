using System;
using Sungero.Core;

namespace DirRX.SignPlatform.Constants
{
  public static class Module
  {
    
    /// <summary>
    /// Эквивалент HTTP-кода TooManyRequests: пользователь отправил слишком много запросов за определенный период времени.
    /// </summary>
    [Public]
    public const int HttpStatusCodeTooManyRequests = 429;
    
    /// <summary>
    /// Ключ параметра сертификата, содержащего ИД облачного провайдера.
    /// </summary>
    [Public]
    public const string ProviderIdCertificateKeyParameter = "providerId";
    
    /// <summary>
    /// Ключ параметра сертификата, содержащего ИД владельца сертификата.
    /// </summary>
    [Public]
    public const string OwnerIdCertificateKeyParameter = "ownerId";
    
    /// <summary>
    /// Имя параметра с датой последнего запуска ФП "Отправка задач на перевыпуск облачных сертификатов".
    /// </summary>
    public const string LastTaskOfCloudCertificatesExpiration = "LastTaskOfCloudCertificatesExpiration";
    
    /// <summary>
    /// ИД плагина для работы с облачными сертификатами 
    /// </summary>
    [Public]
    public const string PluginIdOfCloudCertificates = "54599f8e-4001-4ac4-8e8b-cc731f5ef757";
    
    /// <summary>
    /// Коды ответов возвращаемых сервисом подписания.
    /// </summary>
    public static class SignServiceResponseCodes
    {
      /// <summary>
      /// Запрос выполнен успешно.
      /// </summary>
      public const string Success = "Ok";

      /// <summary>
      /// Не найден хост
      /// </summary>
      public const string HostNotFound = "HostNotFound";
      
      /// <summary>
      /// Запрос на выпуск сертификата не найден.
      /// </summary>
      public const string CertificateIssueRequestNotFoundErrorCode = "CertificateIssueRequestNotFoundError";
      
      /// <summary>
      /// Произошла временная ошибка.
      /// </summary>
      public const string TemporaryUnavailableError = "TemporaryUnavailableError";
      
      /// <summary>
      /// Произошла внутренняя ошибка сервиса.
      /// </summary>
      public const string InternalServerError = "InternalServerError";
      
      /// <summary>
      /// В переданном запросе есть ошибки заполнения данными.
      /// </summary>
      public const string BadRequest = "BadRequest";
      
      /// <summary>
      /// Слишком частые запросы на подтверждение.
      /// </summary>
      public const string TooManyAttempts = "TooManyAttempts";
      
      /// <summary>
      /// Время жизни кода подтверждения истекло (для типа идентификации Personal).
      /// </summary>
      public const string ConfirmationCodeExpired = "ConfirmationCodeExpired";
      
      /// <summary>
      /// Неверный код подтверждения (для типа идентификации Personal).
      /// </summary>
      public const string WrongConfirmationCode = "WrongConfirmationCode";
      
      /// <summary>
      /// Получатель ещё не подтвердил свою личность (для типа идентификации ESIA)
      /// </summary>
      public const string ConfirmationInProgress = "ConfirmationInProgress";
      
      /// <summary>
      /// Пользователь отклонил запрос (для типа идентификации ESIA).
      /// </summary>
      public const string ConfirmationRejected = "ConfirmationRejected";
      
      /// <summary>
      /// Пользователь c подтвержденной учетной записью не найден (для типа идентификации ESIA).
      /// </summary>
      public const string UserNotFoundInEsia = "UserNotFoundInEsia";
      
      /// <summary>
      /// Не удалось подтвердить личность получателя, подробности во вложенной ошибке (для типа идентификации ESIA).
      /// </summary>
      public const string ConfirmationFailed = "ConfirmationFailed";
      
      /// <summary>
      /// Время на подтверждение личности истекло (для типа идентификации ESIA).
      /// </summary>
      public const string ConfirmationExpired = "ConfirmationExpired";
      
      /// <summary>
      /// До повторной отправки кода подтверждения осталось n секунд(ы).
      /// </summary>
      public const string ConfirmationRetryTooFastException = "ConfirmationRetryTooFastException";
    }

    /// <summary>
    /// Паттерн для проверки кода подтверждения.
    /// </summary>
    public const string ConfirmCodePattern = "^[0-9]*$";

    /// <summary>
    /// Имя сервиса подписания в параметре audience.
    /// </summary>
    public const string SignServiceAudience = "Directum.Core.SignService";

    /// <summary>
    /// Запросы к SignService.
    /// </summary>
    [Public]
    public static class RequestApiSignService
    {
      /// <summary>
      /// Запрос на проверку подключения сервиса подписания.
      /// </summary>
      [Public]
      public const string SignServiceHealth = "health";
      
      /// <summary>
      /// Запрос на получение информации о облачных провайдерах.
      /// </summary>
      public const string GetCloudSignProviderInfos = "/v2/CloudSignProviders";
      
      /// <summary>
      /// Запрос на создание заявления на выпуск сертификата.
      /// </summary>
      public const string CreateStatement = "/v2/{0}/CertificateIssues/{1}/statement";
      
      /// <summary>
      /// Запрос статуса заявления на выпуск сертификата.
      /// </summary>
      public const string GetStatementStatus = "/v2/{0}/CertificateIssues/{1}/status";
      
      /// <summary>
      /// Запрос на выпуск сертификата.
      /// </summary>
      public const string CreateCertificate = "/v2/{0}/CertificateIssues";
      
      /// <summary>
      /// Запрос на подтверждение выпуска сертификата.
      /// </summary>
      public const string ConfirmationRequest = "/v2/{0}/CertificateIssues/{1}/confirmation-request";
      
      /// <summary>
      /// Запрос на подтверждение выпуска сертификата.
      /// </summary>
      public const string RevocationRequest = "/v2/{0}/Certificate/revocation";

      /// <summary>
      /// Запрос на отправку кода подтверждения для выпуска сертификата.
      /// </summary>
      public const string SendConfirmCode = "/v2/{0}/CertificateIssues/{1}/confirm";
      
      /// <summary>
      /// Запрос на получение сертификата.
      /// </summary>
      public const string GetCertificate = "/v2/{0}/Certificate/get?certificateId={1}";
      
      /// <summary>
      /// Запрос на получение способов подтверждения.
      /// </summary>
      public const string GetConfirmationType = "/v2/SigningConfirmationType/all";
      
      /// <summary>
      /// Запрос на изменение способа подтверждения по умолчанию.
      /// </summary>
      public const string ChangeConfirmationType = "/v2/SigningConfirmationType/default";
      
      /// <summary>
      /// Запрос на изменение способа подтверждения для владельца сертификата.
      /// </summary>
      public const string ChangeConfirmationTypeForCertificateOwner = "/v2/SigningConfirmationType/certificateOwner/{0}";
      
    }
    
    /// <summary>
    /// Тип документа удостоверяющего личность.
    /// </summary>
    public static class IdentityDocumentType
    {
      /// <summary>
      /// Паспорт РФ.
      /// </summary>
      public const string Passport = "Passport";
      
      /// <summary>
      /// СНИЛС.
      /// </summary>
      public const string INILA = "Snils";
      
      /// <summary>
      /// Другой документ, удостоверяющий личность.
      /// </summary>
      public const string OtherIdentity = "OtherIdentity";
    }
    
    /// <summary>
    /// Пол.
    /// </summary>
    public static class Gender
    {
      /// <summary>
      /// Мужской.
      /// </summary>
      public const string Male = "Male";
      
      /// <summary>
      /// Женский.
      /// </summary>
      public const string Female = "Female";
    }
    
    /// <summary>
    /// Guid видов документов.
    /// </summary>
    public static class DocumentKind
    {
      /// <summary>
      /// Заявление о выпуске электронной подписи.
      /// </summary>
      public static readonly Guid CertificateIssueKind = Guid.Parse("d29b09f7-cf31-4135-acf2-1504b7ed7023");
    }
    
    /// <summary>
    /// Статусы ответа сервиса подписания.
    /// </summary>
    public static class Response
    {
      /// <summary>
      /// Заявление принято.
      /// </summary>
      public const string Accepted = "Accepted";
      
      /// <summary>
      /// Проверка документов.
      /// </summary>
      public const string DocumentsVerification = "DocumentsVerification";
      
      /// <summary>
      /// Ожидает подтверждения.
      /// </summary>
      public const string NeedConfirm = "NeedConfirm";
      
      /// <summary>
      /// Проверка заявления.
      /// </summary>
      public const string IssueVerification = "IssueVerification";
      
      /// <summary>
      /// В процессе выпуска.
      /// </summary>
      public const string InProgress = "InProgress";
      
      /// <summary>
      /// Сертификат выпущен.
      /// </summary>
      public const string Success = "Success";
      
      /// <summary>
      /// Ошибка.
      /// </summary>
      public const string Error = "Error";
    }
    
    /// <summary>
    /// Ключи параметров Docflow.
    /// </summary>
    public static class ParamKey
    {
      /// <summary>
      /// Ключ периода мониторинга задач на заявления на выдачу сертификатов УНЭП, в минутах.
      /// </summary>
      [Public]
      public const string CertificateIssueTaskMonitoringKey = "DirRX.SignPlatform.MonitoringKey";
      
      /// <summary>
      /// Ключ прекращения выполнения мониторинга задач на заявления на выдачу сертификатов УНЭП, в минутах.
      /// </summary>
      [Public]
      public const string CertificateIssueTaskTimeoutKey = "DirRX.SignPlatform.TimeoutKey";
      
      /// <summary>
      /// Ключ периода мониторинга задач на заявления на выдачу сертификатов УНЭП для фонового процесса, в минутах.
      /// </summary>
      [Public]
      public const string CertificateIssueTaskMonitoringBackgroundProcessKey = "DirRX.SignPlatform.BackgroundProcessKey";
      
      /// <summary>
      /// Ключ прекращения выполнения мониторинга задач на заявления на выдачу сертификатов УНЭП для фонового процесса, в минутах.
      /// </summary>
      [Public]
      public const string CertificateIssueTaskTimeoutBackgroundProcessKey = "DirRX.SignPlatform.BackgroundProcessKey";
    }
    
    /// <summary>
    /// Стандартные значения параметров Docflow.
    /// </summary>
    public static class ParamKeyDefaultValues
    {
      /// <summary>
      /// Стандартное значение периода мониторинга задач на заявления на выдачу сертификатов УНЭП, в минутах.
      /// </summary>
      public const string CertificateIssueTaskMonitoringKey = "1";
      
      /// <summary>
      /// Стандартное значение прекращения выполнения мониторинга задач на заявления на выдачу сертификатов УНЭП, в минутах.
      /// </summary>
      public const string CertificateIssueTaskTimeoutKey = "5";
      
      /// <summary>
      /// Стандартное значение периода мониторинга задач на заявления на выдачу сертификатов УНЭП для фонового процесса, в минутах.
      /// </summary>
      public const string CertificateIssueTaskMonitoringBackgroundProcessKey = "1440";
      
      /// <summary>
      /// Стандартное значение прекращения выполнения мониторинга задач на заявления на выдачу сертификатов УНЭП для фонового процесса, в минутах.
      /// </summary>
      public const string CertificateIssueTaskTimeoutBackgroundProcessKey = "2880";
    }
    
    /// <summary>
    /// Код ошибки результата http-запроса при отзыве сертификата.
    /// </summary>
    [Public]
    public const string RevokeException = "RevokeException";
    
    /// <summary>
    /// Настройки скрытия номера телефона
    /// </summary>
    public static class HiddenPhone
    {
      /// <summary>
      /// Кол-во видимых символов начала номера телефона
      /// </summary>
      public const int FirstPartLength = 2;
      
      /// <summary>
      /// Кол-во видимых символов конца номера телефона
      /// </summary>
      public const int LastPartLength = 3;
    }
  }
}