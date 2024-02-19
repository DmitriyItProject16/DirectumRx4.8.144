using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow;
using Sungero.Content;

namespace HRPro.HRWred.Structures.Module
{
  #region Валидация xml.
  /// <summary>Данные для проверки файла в XML описании</summary>
  [Public]
  partial class FileXml
  {
    /// <summary>Наименование файла приложения к электронному документу, связанному с работой</summary>
    public string File { get; set; }
    
    /// <summary>Размер файла (байт)</summary>
    public Int64 Size { get; set; }
    
    /// <summary>Ошибки при получении сведений</summary>
    public string Error { get; set; }
  }
  
  /// <summary>Файлы для валидации XML</summary>
  [Public]
  partial class ValidationXml
  {
    /// <summary>Описания файлов</summary>
    public List<HRPro.HRWred.Structures.Module.IFileXml> FilesXml { get; set; }
    
    /// <summary>Ошибки</summary>
    public List<string> Errors { get; set; }
  }
  #endregion
  
  #region Комплекты документов.
  /// <summary>
  /// Комплект документов.
  /// </summary>
  [Public]
  partial class DocumentSet
  {
    public IOfficialDocument MainDocument { get; set; }
    public List<Sungero.Docflow.IOfficialDocument> Addenda { get; set; }
  }
  
  /// <summary>
  /// Некомплектные приложения.
  /// </summary>
  [Public]
  partial class NotSetAddenda
  {
    public List<Sungero.Docflow.IOfficialDocument> Addenda { get; set; }
  }
  
  /// <summary>
  /// Комплекты документов и некомплектные приложения.
  /// </summary>
  [Public]
  partial class SetsAndNotSetDocuments
  {
    public List<HRPro.HRWred.Structures.Module.IDocumentSet> Sets { get; set; }
    public HRPro.HRWred.Structures.Module.INotSetAddenda NotSets { get; set; }
  }
  #endregion
  
  #region Результаты выгрузки.
  /// <summary>
  /// Количество успешно выгруженных контейнеров, и контейнеров, при выгрузке которых произошли ошибки.
  /// </summary>
  [Public]
  partial class ExportResult
  {
    public int CountSuccessExportContainers { get; set; }
    public int CountErrorExportContainers { get; set; }
  }
  #endregion
}