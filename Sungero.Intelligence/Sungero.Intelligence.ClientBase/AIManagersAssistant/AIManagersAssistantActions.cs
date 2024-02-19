using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Intelligence.AIManagersAssistant;

namespace Sungero.Intelligence.Client
{
  partial class AIManagersAssistantAnyChildEntityCollectionActions
  {
    public override void DeleteChildEntity(Sungero.Domain.Client.ExecuteChildCollectionActionArgs e)
    {
      base.DeleteChildEntity(e);
    }

    public override bool CanDeleteChildEntity(Sungero.Domain.Client.CanExecuteChildCollectionActionArgs e)
    {
      return Functions.AIManagersAssistant.CollectionIsAIAssistantClassifiers(_all, e.RootEntity)
        ? false
        : base.CanDeleteChildEntity(e);
    }

  }

  partial class AIManagersAssistantAnyChildEntityActions
  {
    public override void CopyChildEntity(Sungero.Domain.Client.ExecuteChildCollectionActionArgs e)
    {
      base.CopyChildEntity(e);
    }

    public override bool CanCopyChildEntity(Sungero.Domain.Client.CanExecuteChildCollectionActionArgs e)
    {
      return Functions.AIManagersAssistant.CollectionIsAIAssistantClassifiers(_all, e.RootEntity)
        ? false
        : base.CanCopyChildEntity(e);
    }

    public override void AddChildEntity(Sungero.Domain.Client.ExecuteChildCollectionActionArgs e)
    {
      base.AddChildEntity(e);
    }

    public override bool CanAddChildEntity(Sungero.Domain.Client.CanExecuteChildCollectionActionArgs e)
    {
      return Functions.AIManagersAssistant.CollectionIsAIAssistantClassifiers(_all, e.RootEntity)
        ? false
        : base.CanAddChildEntity(e);
    }

  }

  partial class AIManagersAssistantActions
  {
    public virtual void UnpublishClassifierModel(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      bool isConfirmed = Dialogs.CreateConfirmDialog(AIManagersAssistants.Resources.ResetClassifierResults, AIManagersAssistants.Resources.ResetClassifierResultsDescription).Show();
      if (!isConfirmed)
        return;

      var classifier = _obj.Classifiers.First(x => x.ClassifierId.HasValue && x.ClassifierType == Intelligence.AIManagersAssistantClassifiers.ClassifierType.Assignee);
      
      var successfullyUnpublished = SmartProcessing.PublicFunctions.Module.Remote.UnpublishClassifierModel(classifier.ClassifierId.Value);
      if (successfullyUnpublished)
      {
        classifier.ModelId = null;
        classifier.IsModelActive = Intelligence.AIManagersAssistantClassifiers.IsModelActive.No;
        _obj.Save();
        Dialogs.NotifyMessage(string.Format(SmartProcessing.Resources.UnpublishModelSuccess, classifier.ClassifierId.Value, classifier.ClassifierName));
      }
      else
      {
        var errorMessage = string.Format(SmartProcessing.Resources.UnpublishModelError, classifier.ClassifierId.Value, classifier.ClassifierName);
        Dialogs.NotifyMessage(errorMessage);
        Logger.Debug(errorMessage);
      }
    }

    public virtual bool CanUnpublishClassifierModel(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return Users.Current.IncludedIn(Roles.Administrators) && 
        !_obj.State.IsInserted && 
        _obj.Classifiers.Any(x => x.ClassifierId.HasValue && 
                             x.ClassifierType == Intelligence.AIManagersAssistantClassifiers.ClassifierType.Assignee && 
                             x.ModelId.HasValue);
    }

  }

}