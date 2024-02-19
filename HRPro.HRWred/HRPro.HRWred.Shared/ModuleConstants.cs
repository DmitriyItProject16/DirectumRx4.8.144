using System;
using Sungero.Core;

namespace HRPro.HRWred.Constants
{
  public static class Module
  {
    #region Guid-ы типов документов
    /// <summary>
    /// Guid типа Кадровый договорной документ.
    /// </summary>
    public static readonly Guid GuidBilaterialDocument = Guid.Parse("270b7392-3114-4759-849e-ce44b9bddb0a");
    
    /// <summary>
    /// Guid типа Локальный нормативный акт.
    /// </summary>
    public static readonly Guid GuidLocalRegulationDocument = Guid.Parse("38686a2c-ec27-4453-9c0b-f540d11854c8");
    
    /// <summary>
    /// Guid типа Кадровый документ.
    /// </summary>
    public static readonly Guid GuidPersonnelDocument = Guid.Parse("ded6a81c-e3cf-4c83-9dfb-3c8b455ecec1");
    
    /// <summary>
    /// Guid типа Заявление.
    /// </summary>
    public static readonly Guid GuidStatementDocument = Guid.Parse("48eb5e1d-a0bd-4fca-ae78-54dff8c193a9");
    
    /// <summary>
    /// Guid типа Кадровый приказ.
    /// </summary>
    public static readonly Guid GuidHROrder = Guid.Parse("0d279f0b-8cd2-4dda-be34-85aacd7b8b93");
    
    /// <summary>
    /// Guid типа Документ по переводу и отпускам.
    /// </summary>
    public static readonly Guid GuidHRDocument = Guid.Parse("c135fb43-9561-45ad-9628-85459f8cf26e");
    #endregion
    
    /// <summary>
    /// Guid справочника видов документов.
    /// </summary>
    public static readonly Guid DocumentKindTypeGuid = Guid.Parse("14a59623-89a2-4ea8-b6e9-2ad4365f358c");
    
    /// <summary>
    /// Guid роли Ответственный за выгрузку кадровых документов.
    /// </summary>
    [Public]
    public static readonly Guid HRDocExportManager = Guid.Parse("9353351b-c7b4-47bc-82f0-84e04a08b432");
    
    /// <summary>
    /// Название Xml-файла для выгрузки.
    /// </summary>
    [Public]
    public const string ExportXmlFilename = "wredc_data";
    
    /// <summary>
    /// Коды документов (кадровых мероприятий) или иных сведений.
    /// </summary>
    [Public]
    public static class DocumentСodes
    {
      // Прием на работу.
      /// <summary>
      /// Трудовой договор.
      /// </summary>
      [Public]
      public const string EmploymentContract = "01.006";
      /// <summary>
      /// Локальный нормативный акт, непосредственно связанный с трудовой деятельностью.
      /// </summary>
      [Public]
      public const string LNARelatedLaborActivity = "01.009";
      /// <summary>
      /// Ознакомление с локальным нормативным актом, непосредственно связанным с трудовой деятельностью.
      /// </summary>
      [Public]
      public const string AcquaintanceWithLNARelatedLaborActivity = "01.010";
      
      // Рабочее время и время отдыха.
      /// <summary>
      /// Согласие работника о выполнении им дополнительной работы.
      /// </summary>
      [Public]
      public const string EmployeesConsentPerformAdditionalWork = "02.001";
      /// <summary>
      /// Отмена поручения о выполнении дополнительной работы.
      /// </summary>
      [Public]
      public const string CancelOrderToPerformAdditionalWork = "02.003";
      /// <summary>
      /// Распоряжение работодателя о привлечении работника к работе в выходные и нерабочие праздничные дни.
      /// </summary>
      [Public]
      public const string OrderInvolvementEmployeeOnWeekendsAndHolidays = "02.011";
      /// <summary>
      /// Заявление работника о переносе ежегодного оплачиваемого отпуска на другой срок.
      /// </summary>
      [Public]
      public const string EmployeesStatementPostponementAnnualPaidLeave = "02.013";
      /// <summary>
      /// Заявление работника о предоставлении отпуска без сохранения заработной платы.
      /// </summary>
      [Public]
      public const string EmployeesApplicationForLeaveWithoutPay = "02.015";
      /// <summary>
      /// Ознакомление работника работодателем со своим правом отказаться от направления в служебную командировку.
      /// </summary>
      [Public]
      public const string AcquaintanceEmployeeWithRightRefuseSentBusinessTrip = "02.017";
      /// <summary>
      /// Извещение о времени начала отпуска.
      /// </summary>
      [Public]
      public const string StartTimeOfVacationNotification = "02.024";
      /// <summary>
      /// Правила внутреннего трудового распорядка.
      /// </summary>
      [Public]
      public const string InternalLaborRegulations = "02.025";
      
      // Материальная ответственность.
      /// <summary>
      /// Договор о полной индивидуальной материальной ответственности.
      /// </summary>
      [Public]
      public const string AgreementFullIndividualFinancialResponsibility = "03.003";
      /// <summary>
      /// Обязательство о добровольном возмещении ущерба.
      /// </summary>
      [Public]
      public const string ObligationVoluntaryCompensationForDamage = "03.006";
      
      // Оплата труда.
      /// <summary>
      /// Уведомление о готовности произвести выплату задержанной заработной платы.
      /// </summary>
      [Public]
      public const string NotificationReadinessMakePaymentDelayedWages = "04.005";
      
      // Образование работника.
      /// <summary>
      /// Ученический договор.
      /// </summary>
      [Public]
      public const string StudentAgreement = "06.001";
      
      // Социальное партнерство.
      /// <summary>
      /// Сообщение работодателя выборному органу первичной профсоюзной организации о принятии решения
      /// о сокращении численности или штата работников и возможном расторжении трудовых договоров с работниками.
      /// </summary>
      [Public]
      public const string DecisionReduceNumberOrStaffOfEmployees = "07.003";
      
      // Персональные данные.
      /// <summary>
      /// Документы работодателя, устанавливающие порядок обработки персональных данных работников,
      /// а также об их правах и обязанностях в этой области.
      /// </summary>
      [Public]
      public const string DocumentsEstablishingProcedureProcessingPersonalEmployeesData = "09.005";
      
      // Изменение условий трудового договора.
      /// <summary>
      /// Соглашение об изменении определенных сторонами условий трудового договора.
      /// </summary>
      [Public]
      public const string AgreementAmendTermsEmploymentContractDefinedByParties = "10.001";
      /// <summary>
      /// Согласие на перевод на другую работу.
      /// </summary>
      [Public]
      public const string ConsentTransferToAnotherJob = "10.002";
      /// <summary>
      /// Предложение работнику о другой имеющейся у работодателя работы.
      /// </summary>
      [Public]
      public const string OfferOfAnotherJob = "10.010";
      
      // Прекращение трудовых отношений.
      /// <summary>
      /// Предупреждение о расторжении трудового договора в связи с неудовлетворительным результатом испытания.
      /// </summary>
      [Public]
      public const string WarningAboutTerminationContractDueUnsatisfactoryTestResult = "11.001";
      /// <summary>
      /// Предупреждение о расторжении трудового договора по собственному желанию.
      /// </summary>
      [Public]
      public const string WarningTerminationOfEmploymentContractAtWill = "11.002";
      /// <summary>
      /// Предупреждение работнику о прекращении трудового договора в связи с истечением срока его действия.
      /// </summary>
      [Public]
      public const string WarningEmployeeAboutTerminationContractDue = "11.003";
      /// <summary>
      /// Согласие работника на расторжение с ним трудового договора.
      /// </summary>
      [Public]
      public const string EmployeesConsentTerminationContract = "11.008";
      /// <summary>
      /// Предупреждение работнику о прекращении трудового договора по совместительству, заключенного на неопределенный срок.
      /// </summary>
      [Public]
      public const string WarningTerminationPartTimeEmploymentContract = "11.010";
      /// <summary>
      /// Предупреждение о предстоящем увольнении в связи с ликвидацией организации, сокращением численности или штата работников.
      /// </summary>
      [Public]
      public const string WarningUpcomingDismissal = "11.011";
      /// <summary>
      /// Предупреждение работнику о прекращении трудового договора.
      /// </summary>
      [Public]
      public const string WarningTerminationOfEmploymentContract = "11.012";
      
      // Иные кадровые мероприятия.
      /// <summary>
      /// Согласие на направление в спортивные сборные команды Российской Федерации.
      /// </summary>
      [Public]
      public const string ConsentToSentToSportsTeams = "12.006";
      /// <summary>
      /// Приказ (распоряжение) работодателя о применении дисциплинарного взыскания.
      /// </summary>
      [Public]
      public const string OrderApplicationDisciplinaryPunishment = "12.008";

      /// <summary>
      /// Заявление о замене части отпуска денежной компенсацией.
      /// </summary>
      [Public]
      public const string ReplaceVacationByMoney = "02.014";
      
      /// <summary>
      /// Заявление об освобождении от работы для прохождения диспансеризации.
      /// </summary>
      [Public]
      public const string MedicalExamination = "05.001";

      /// <summary>
      /// Заявление работника о предоставлении дополнительных оплачиваемых выходных дней для ухода за ребенком-инвалидом.
      /// </summary>
      [Public]
      public const string PaidDaysToCareForDisabledChild = "02.019";

      /// <summary>
      ///  Иные документы.
      /// </summary>
      [Public]
      public const string OtherDocuments = "12.999";
    }
    
    public static class HelpCodes
    {
      public const string ExportPersonellDocumentsDialog = "DirRX_HRWred_ExportPersonellDocuments";
    }
    
    /// <summary>
    /// Версия схемы данных электронного документа, связанного с работой.
    /// </summary>
    public const string MintrudXSDDefaultVersion = "1.0";
    
    /// <summary>
    /// Перевод Мб в байты и наоборот 1024*1024.
    /// </summary>
    public const int ConvertMb = 1048576;
    
    /// <summary>
    /// Максимальное количество файлов в выгружаемом zip архиве.
    /// </summary>
    public const int ExportedFilesCountMaxLimit = 5000;
    
    /// <summary>
    /// Максимальная сумма размеров файлов в выгружаемом zip архиве.
    /// </summary>
    public const int ExportedFilesSizeMaxLimitMb = 450;
    
    /// <summary>
    /// Максимальное количество выгружаемых документов.
    /// </summary>
    public const int ExportedDocumentsCountMaxLimit = 1000;
    
    /// <summary>
    /// Наименование файла лога-протокола выгрузки.
    /// </summary>
    public const string ExportedLogFileName = "Протокол выгрузки";
    
    /// <summary>
    /// Наименование узла в xml с ошибкой.
    /// </summary>
    public const string XmlErrorNodeName = "error";
    
    /// <summary>
    /// Основа наименования файла доверенности.
    /// </summary>
    public const string BasisFileNameOfPoA = "Attorney{0}";
    
    /// <summary>
    /// Расширение для файлов доверенностей.
    /// </summary>
    public const string AttorneyFileExtension = "{0}.xml";
    
    /// <summary>
    /// Расширение для файлов подписи.
    /// </summary>
    public const string SignatureFileExtension = ".sgn";
    
    /// <summary>
    /// Максимальная длинна файла.
    /// </summary>
    public const int MaxExportFileNameLength = 250;
    
    /// <summary>
    /// Максимальная длинна файла на кириллице.
    /// </summary>
    public const int MaxRuExportFileNameLength = 120;
    
    /// <summary>
    /// Умножитель длинны для строк на кириллице.
    /// </summary>
    public const int MultiplierFromRuToEn = 2;
  }
}