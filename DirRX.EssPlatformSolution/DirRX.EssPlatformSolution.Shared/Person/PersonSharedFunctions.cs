using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.EssPlatformSolution.Person;

namespace DirRX.EssPlatformSolution.Shared
{
  partial class PersonFunctions
  {

    /// <summary>
    /// Проверить реквизиты документа, удостоверяющего личность.
    /// </summary>
    /// <returns>Перечень ошибок заполнения.</returns>
    [Public]
    public virtual System.Collections.Generic.IDictionary<Sungero.Domain.Shared.IPropertyInfo, string> CheckPersonIdentityDocument()
    {
      var errors = new Dictionary<Sungero.Domain.Shared.IPropertyInfo, string>();
      
      if (_obj.IdentityDocumentKind == null)
      {
        return errors;
      }
      
      if (_obj.State.Properties.IdentityDocumentSeries.IsRequired && string.IsNullOrWhiteSpace(_obj.IdentityDocumentSeries))
      {
        errors.Add(
          _obj.Info.Properties.IdentityDocumentSeries,
          DirRX.EssPlatformSolution.People.Resources.PropertyIsEmptyFormat(
            _obj.Info.Properties.IdentityDocumentSeries.LocalizedName));
      }
      
      if (_obj.State.Properties.IdentityDocumentNumber.IsRequired && string.IsNullOrWhiteSpace(_obj.IdentityDocumentNumber))
      {
        errors.Add(
          _obj.Info.Properties.IdentityDocumentNumber,
          DirRX.EssPlatformSolution.People.Resources.PropertyIsEmptyFormat(
            _obj.Info.Properties.IdentityDocumentNumber.LocalizedName));
      }
      
      if (_obj.State.Properties.IdentityDocumentIssueDate.IsRequired && !_obj.IdentityDocumentIssueDate.HasValue)
      {
        errors.Add(
          _obj.Info.Properties.IdentityDocumentIssueDate,
          DirRX.EssPlatformSolution.People.Resources.PropertyIsEmptyFormat(
            _obj.Info.Properties.IdentityDocumentIssueDate.LocalizedName));
      }
      
      if (_obj.State.Properties.IdentityDocumentIssueDate.IsRequired && _obj.IdentityDocumentIssueDate.HasValue && _obj.IdentityDocumentIssueDate > Calendar.Now)
      {
        errors.Add(_obj.Info.Properties.IdentityDocumentIssueDate, DirRX.EssPlatformSolution.People.Resources.IdertityDocumentIssueDateError);
      }
		
      if(_obj.IdentityDocumentExpirationDate.HasValue && _obj.IdentityDocumentIssueDate.HasValue && _obj.IdentityDocumentIssueDate.Value >= _obj.IdentityDocumentExpirationDate.Value)
      {
        errors.Add(_obj.Info.Properties.IdentityDocumentIssueDate, DirRX.EssPlatformSolution.People.Resources.ErrorIssueDateLessExpirationDate);
        errors.Add(_obj.Info.Properties.IdentityDocumentExpirationDate, DirRX.EssPlatformSolution.People.Resources.ErrorIssueDateLessExpirationDate);
      }
      
      if (_obj.State.Properties.IdentityDocumentIssuedBy.IsRequired && string.IsNullOrWhiteSpace(_obj.IdentityDocumentIssuedBy))
      {
        errors.Add(
          _obj.Info.Properties.IdentityDocumentIssuedBy,
          DirRX.EssPlatformSolution.People.Resources.PropertyIsEmptyFormat(
            _obj.Info.Properties.IdentityDocumentIssuedBy.LocalizedName));
      }
      
      if (_obj.State.Properties.IdentityDocumentIssuerID.IsRequired && string.IsNullOrWhiteSpace(_obj.IdentityDocumentIssuerID))
      {
        errors.Add(
          _obj.Info.Properties.IdentityDocumentIssuerID,
          DirRX.EssPlatformSolution.People.Resources.PropertyIsEmptyFormat(
            _obj.Info.Properties.IdentityDocumentIssuerID.LocalizedName));
      }
      
      if (_obj.IdentityDocumentKind.Equals(DirRX.EssPlatformSolution.Person.IdentityDocumentKind.PassportRF))
      {
        if (_obj.IdentityDocumentSeries.Length != 4 || !int.TryParse(_obj.IdentityDocumentSeries, out _))
        {
          errors.Add(_obj.Info.Properties.IdentityDocumentSeries, DirRX.EssPlatformSolution.People.Resources.IdentityDocumentSeriesLengthValidation);
        }
        
        if (_obj.IdentityDocumentNumber.Length != 6 || !int.TryParse(_obj.IdentityDocumentNumber, out _))
        {
          errors.Add(_obj.Info.Properties.IdentityDocumentNumber, DirRX.EssPlatformSolution.People.Resources.IdentityDocumentNumberLengthValidation);
        }
        
        if (_obj.IdentityDocumentIssuerID.Length != 6 || !int.TryParse(_obj.IdentityDocumentIssuerID, out _))
        {
          errors.Add(_obj.Info.Properties.IdentityDocumentIssuerID, DirRX.EssPlatformSolution.People.Resources.IdentityDocumentIssuerIDLengthValidation);
        }
      }
      
      return errors;
    }
    
    /// <summary>
    /// Установить обязательность свойств их видимость.
    /// </summary>
    [Public]
    public virtual void SetRequiredAndVisibleProperties()
    {
      if (DirRX.EssPlatform.PublicFunctions.Module.Remote.PersonalDataAvailableForCurrentUser())
      {
        SetPersonalDataVisibility(true);
        SetIdentityDocumentRequiredAndVisibleProperties();
      }
      else
      {
        SetPersonalDataVisibility(false);
        ResetRequiredProperties();
      }
    }
    
    /// <summary>
    /// Установить обязательность свойств в зависимости от вида документа, удостоверяющего личность.
    /// </summary>
    [Public]
    public virtual void SetIdentityDocumentRequiredAndVisibleProperties()
    {
      if (_obj.IdentityDocumentKind.Equals(DirRX.EssPlatformSolution.Person.IdentityDocumentKind.PassportRF))
      {
        _obj.State.Properties.IdentityDocumentSeries.IsRequired = true;
        _obj.State.Properties.IdentityDocumentNumber.IsRequired = true;
        _obj.State.Properties.IdentityDocumentIssueDate.IsRequired = true;
        _obj.State.Properties.IdentityDocumentIssuedBy.IsRequired = false;
        _obj.State.Properties.IdentityDocumentIssuerID.IsRequired = true;
        
        _obj.State.Properties.IdentityDocumentSeries.IsVisible = true;
        _obj.State.Properties.IdentityDocumentNumber.IsVisible = true;
        _obj.State.Properties.IdentityDocumentIssueDate.IsVisible = true;
        _obj.State.Properties.IdentityDocumentIssuedBy.IsVisible = true;
        _obj.State.Properties.IdentityDocumentIssuerID.IsVisible = true;
        _obj.State.Properties.IdentityDocumentBirthPlaceDirRX.IsVisible = true;
        _obj.State.Properties.IdentityDocumentExpirationDate.IsVisible = false;
      }
      else if (_obj.IdentityDocumentKind.Equals(DirRX.EssPlatformSolution.Person.IdentityDocumentKind.OtherDocument) 
               || _obj.IdentityDocumentKind.Equals(DirRX.EssPlatformSolution.Person.IdentityDocumentKind.ForeignPassport))
      {
        _obj.State.Properties.IdentityDocumentSeries.IsRequired = false;
        _obj.State.Properties.IdentityDocumentNumber.IsRequired = true;
        _obj.State.Properties.IdentityDocumentIssueDate.IsRequired = true;
        _obj.State.Properties.IdentityDocumentIssuedBy.IsRequired = true;
        _obj.State.Properties.IdentityDocumentIssuerID.IsRequired = false;
        
        _obj.State.Properties.IdentityDocumentSeries.IsVisible = true;
        _obj.State.Properties.IdentityDocumentNumber.IsVisible = true;
        _obj.State.Properties.IdentityDocumentIssueDate.IsVisible = true;
        _obj.State.Properties.IdentityDocumentIssuedBy.IsVisible = true;
        _obj.State.Properties.IdentityDocumentIssuerID.IsVisible = false;
        _obj.State.Properties.IdentityDocumentBirthPlaceDirRX.IsVisible = false;
        _obj.State.Properties.IdentityDocumentExpirationDate.IsVisible = true;
      }
      else
      {
        ResetRequiredProperties();
        
        _obj.State.Properties.IdentityDocumentSeries.IsVisible = false;
        _obj.State.Properties.IdentityDocumentNumber.IsVisible = false;
        _obj.State.Properties.IdentityDocumentIssueDate.IsVisible = false;
        _obj.State.Properties.IdentityDocumentIssuedBy.IsVisible = false;
        _obj.State.Properties.IdentityDocumentIssuerID.IsVisible = false;
        _obj.State.Properties.IdentityDocumentExpirationDate.IsVisible = false;
        _obj.State.Properties.IdentityDocumentBirthPlaceDirRX.IsVisible = false;
      }
    }
    
    /// <summary>
    /// Сбросить обязательность свойств.
    /// </summary>
    public virtual void ResetRequiredProperties()
    {
      _obj.State.Properties.IdentityDocumentSeries.IsRequired = false;
      _obj.State.Properties.IdentityDocumentNumber.IsRequired = false;
      _obj.State.Properties.IdentityDocumentIssueDate.IsRequired = false;
      _obj.State.Properties.IdentityDocumentIssuedBy.IsRequired = false;
      _obj.State.Properties.IdentityDocumentIssuerID.IsRequired = false;
    }
    
    /// <summary>
    /// Установить видимость вкладки "Документ, удостоверяющий личность" и полей "ИНН" и "СНИЛС".
    /// </summary>
    /// <param name="isVisible">Значение видимости.</param>
    public virtual void SetPersonalDataVisibility(bool isVisible)
    {
      _obj.State.Pages.HRProIdentityDocument.IsVisible = isVisible;
      
      _obj.State.Properties.TIN.IsVisible = isVisible;
      _obj.State.Properties.INILA.IsVisible = isVisible;
    }
    
    /// <summary>
    /// Проверить СНИЛС на валидность.
    /// </summary>
    /// <param name="tin">Строка с СНИЛС.</param>
    /// <returns>Текст ошибки. Пустая строка для верного СНИЛС.</returns>
    [Public]
    public static string CheckInila(string inila)
    {
      if (string.IsNullOrWhiteSpace(inila))
        return string.Empty;
      
      // Во введенных данных проверить кол-во цифр и валидность. Для этого извлечь цифры, пробелы и дефисы (для поддержки различных форм написания)
      // и отдельно извлечь только цифры для проверки на контрольную сумму.
      var inilaWithoutExtraCharacters = new string(inila.ToCharArray().Where(n => n >= '0' && n <= '9' || n == ' ' || n == '-').ToArray());
      var inilaOnlyNumbers = new string(inila.ToCharArray().Where(n => n >= '0' && n <= '9').ToArray());
      // Проверить на кол-во цифр и отсутствие лишних символов.
      if (inilaOnlyNumbers.Length != 11 || inila != inilaWithoutExtraCharacters)
        return DirRX.EssPlatformSolution.People.Resources.IncorrectINILALength;
      else
      {
        // Проверить контрольную сумму.
        var inilaSumError = Functions.Person.CheckInilaSum(inilaOnlyNumbers);
        if (!string.IsNullOrEmpty(inilaSumError))
          return inilaSumError;
      }
      return string.Empty;
    }
    
    /// <summary>
    /// Проверить контрольную сумму СНИЛС.
    /// </summary>
    /// <param name="inila">Строка из цифр СНИЛС. Передавать СНИЛС длиной 11 символов.</param>
    /// <returns>Текст ошибки. Пустая строка для верного СНИЛС.</returns>
    /// <remarks>Информация по ссылке: http://www.kholenkov.ru/data-validation/snils/.</remarks>
    public static string CheckInilaSum(string inila)
    {
      var controlSum = int.Parse(inila.Substring(9, 2));
      var index = 0;
      var sum = 0;
      while (index <= 8)
      {
        var coef = 9 - index;
        var num = int.Parse(inila.Substring(index, 1));
        sum = sum + coef * num;
        index = index + 1;
      }
      if (sum == 100)
        sum = 0;
      else if (sum > 100)
      {
        sum = sum % 101;
        if (sum == 100)
          sum = 0;
      }
      if (sum != controlSum)
        return DirRX.EssPlatformSolution.People.Resources.NotValidINILA;
      return string.Empty;
    }
    
  }
}