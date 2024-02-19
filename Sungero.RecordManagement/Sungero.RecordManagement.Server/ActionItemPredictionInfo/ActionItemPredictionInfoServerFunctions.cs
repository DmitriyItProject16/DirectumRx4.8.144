using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.RecordManagement.ActionItemPredictionInfo;

namespace Sungero.RecordManagement.Server
{
  partial class ActionItemPredictionInfoFunctions
  {
    /// <summary>
    /// Сохранить результат предсказания поручения.
    /// </summary>
    /// <returns>True - если удалось сохранить результат, иначе false.</returns>
    [Public]
    public virtual bool TrySave()
    {
      try
      {
        _obj.Save();
        return true;
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("Cannot save prediction info (ID = {0})", ex, _obj.Id);
        return false;
      }
    }
    
    /// <summary>
    /// Удалить существующий черновик поручений из группы вложений автоматически созданных черновиков родительского задания.
    /// </summary>
    [Public]
    public virtual void RemoveActionItemDraftFromParentAssignment()
    {
      if (!_obj.ActionItemId.HasValue)
        return;
      var draftActionItem = ActionItemExecutionTasks.GetAll(x => x.Id == _obj.ActionItemId.Value).FirstOrDefault();
      if (draftActionItem == null || draftActionItem.ParentAssignment == null)
        return;
      var parentAssignment = ActionItemExecutionAssignments.As(draftActionItem.ParentAssignment);
      if (parentAssignment.ActionItemDraftGroup.ActionItemExecutionTasks.Contains(draftActionItem))
        parentAssignment.ActionItemDraftGroup.ActionItemExecutionTasks.Remove(draftActionItem);
    }
    
  }
}