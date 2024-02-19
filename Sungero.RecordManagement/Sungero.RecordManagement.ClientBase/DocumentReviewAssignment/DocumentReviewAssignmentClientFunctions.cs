using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.RecordManagement.DocumentReviewAssignment;

namespace Sungero.RecordManagement.Client
{
  partial class DocumentReviewAssignmentFunctions
  {
    /// <summary>
    /// Проверить просроченные поручения, вывести ошибку в случае просрочки.
    /// </summary>
    /// <param name="e">Аргументы события.</param>
    public virtual void CheckOverdueActionItemExecutionTasks(Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var overdueTasks = Functions.DocumentReviewAssignment.GetDraftOverdueActionItemExecutionTasks(_obj);
      if (overdueTasks.Any())
      {
        e.AddError(RecordManagement.Resources.ImpossibleSpecifyDeadlineLessThanTodayCorrectIt);
        e.Cancel();
      }
    }

  }
}