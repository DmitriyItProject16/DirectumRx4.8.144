﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Contracts.IncomingInvoice;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.FinancialArchive;

namespace Sungero.Contracts.Client
{
  partial class IncomingInvoiceFunctions
  {
    /// <summary>
    /// Показывать сводку по документу в заданиях на согласование и подписание.
    /// </summary>
    /// <returns>True, если в заданиях нужно показывать сводку по документу.</returns>
    [Public]
    public override bool NeedViewDocumentSummary()
    {
      return true;
    }
    
    /// <summary>
    /// Получить список типов документов, доступных для смены типа.
    /// </summary>
    /// <returns>Список типов документов, доступных для смены типа.</returns>
    public override List<Domain.Shared.IEntityInfo> GetTypesAvailableForChange()
    {
      if (_obj.ExchangeState != null)
        return new List<Domain.Shared.IEntityInfo>() { Docflow.SimpleDocuments.Info };
      
      var types = new List<Domain.Shared.IEntityInfo>();
      types.Add(ContractStatements.Info);
      types.Add(IncomingTaxInvoices.Info);
      types.Add(OutgoingTaxInvoices.Info);
      types.Add(UniversalTransferDocuments.Info);
      types.Add(Waybills.Info);
      return types;
    }
    
    /// <summary>
    /// Дополнительное условие доступности действия "Сменить тип".
    /// </summary>
    /// <returns>True - если действие "Сменить тип" доступно, иначе - false.</returns>
    public override bool CanChangeDocumentType()
    {
      return _obj.VerificationState == VerificationState.InProcess || base.CanChangeDocumentType();
    }
  }
}