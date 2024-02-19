using System;

namespace Sungero.RecordManagement.Constants
{
  public static class Module
  {
    // Срок рассмотрения документа по умолчанию в днях.
    public const int DocumentReviewDefaultDays = 3;
    
    #region Связи
    
    // Имя типа связи "Переписка".
    [Sungero.Core.Public]
    public const string CorrespondenceRelationName = "Correspondence";
    
    // Имя типа связи "Ответное письмо".
    [Sungero.Core.Public]
    public const string ResponseRelationName = "Response";
    
    // Описание типа связи "Ответное письмо".
    [Sungero.Core.Public]
    public const string ResponseRelationDescription = "Для указания ответного письма";
    
    // Имя типа связи "Доп. соглашение".
    [Sungero.Core.Public]
    public const string SupAgreementRelationName = "SupAgreement";
    
    // Описание типа связи "Доп. соглашение".
    [Sungero.Core.Public]
    public const string SupAgreementRelationDescription = "Для указания дополнительного соглашения к договору";
    
    // Имя типа связи "Прочие".
    [Sungero.Core.Public]
    public const string SimpleRelationRelationName = "Simple relation";
    
    #endregion
    
    public static class Initialize
    {
      [Sungero.Core.Public]
      public static readonly Guid IncomingLetterKind = Guid.Parse("0002C3CB-43E1-4A01-A4FE-35ABC8994D66");
      [Sungero.Core.Public]
      public static readonly Guid OutgoingLetterKind = Guid.Parse("352EC449-E344-48EE-AD32-D0B2BABDC56E");
      [Sungero.Core.Public]
      public static readonly Guid OrderKind = Guid.Parse("8F529647-3F37-484A-B83A-A793B69D013E");
      [Sungero.Core.Public]
      public static readonly Guid CompanyDirective = Guid.Parse("8EABA48D-F32C-45F0-9367-4A2B58ACBD20");
    }
    
    [Sungero.Core.Public]
    public const string IncomingLetterGuid = "8dd00491-8fd0-4a7a-9cf3-8b6dc2e6455d";

    #region Диалог заполнения пунктов составного поручения
    
    // Высота контрола текста поручения.
    [Sungero.Core.Public]
    public const int ActionItemPartTextRowsCount = 6;
    
    // Высота контрола заполнения соисполнителей.
    [Sungero.Core.Public]
    public const int CoAssigneesTextRowsCount = 3;
    
    #endregion
    
    // Задача на исполнение поручения.
    // Текст параметра, отвечающего за ИД пользователя, на который нужно заменить значение свойства Стартовал.
    // Сделано для корректной работы отчёта "Контроль исполнения поручений по совещаниям" (270972).
    public const string StartedByUserId = "StartedBy User Id";
    
    /// <summary>
    /// Имя параметра для хранения даты и времени последней обработки очереди обучения классификатора для поручений.
    /// </summary>
    public const string LastActionItemTrainQueueDateParamName = "LastActionItemTrainQueueDate";
    
    /// <summary>
    /// Максимальное количество итераций асинхронных обработчиков обучения классификаторов.
    /// </summary>
    public const int ClassifierTrainingRetryLimit = 50;
    
    /// <summary>
    /// Имя параметра для минимального количества документов в обучающей выборке для публикации модели.
    /// </summary>
    public const string MinTrainingSetSizeToPublishClassifierModelParamName = "MinTrainingSetSizeToPublishClassifierModel";
    
    /// <summary>
    /// Минимальное количество документов в обучающей выборке для публикации модели.
    /// </summary>
    public const int MinTrainingSetSizeToPublishClassifierModel = 100;
    
    /// <summary>
    /// Минимальное количество документов в классе для обучения.
    /// </summary>
    public const int MinItemsInClassFirstTrainingCount = 10;

    /// <summary>
    /// Минимальное количество классов для первичного обучения.
    /// </summary>
    public const int MinClassesFirstTrainingCount = 2;
  }
}