using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Content;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.RecordManagement.DocumentReviewAssignment;

namespace Sungero.RecordManagement.Server
{
  partial class DocumentReviewAssignmentFunctions
  {
    /// <summary>
    /// Построить модель представления.
    /// </summary>
    /// <returns>Xml представление контрола состояние.</returns>
    [Remote(IsPure = true)]
    public Sungero.Core.StateView GetStateView()
    {
      return Functions.Module.GetStateViewForDraftResolution(_obj.ResolutionGroup.ActionItemExecutionTasks.ToList());
    }
  }
}