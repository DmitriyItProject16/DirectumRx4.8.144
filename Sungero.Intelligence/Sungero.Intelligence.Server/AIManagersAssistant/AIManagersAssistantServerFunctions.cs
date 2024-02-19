using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Intelligence.AIManagersAssistant;

namespace Sungero.Intelligence.Server
{
  partial class AIManagersAssistantFunctions
  {
    /// <summary>
    /// Создать классификатор.
    /// </summary>
    /// <param name="classifierType">Тип классификатора.</param>
    /// <returns>ИД созданного классификатора.</returns>
    [Public]
    public virtual int? CreateClassifier(Enumeration classifierType)
    {
      try
      {
        var classifierTypeName = _obj.Info.Properties.Classifiers.Properties.ClassifierType.GetLocalizedValue(classifierType);
        var classifierName = string.Format("{0}. {1}", _obj.Manager.DisplayValue, classifierTypeName);
        var classifierId = SmartProcessing.PublicFunctions.Module.CreateClassifier(classifierName,
                                                                                   (double)Constants.AIManagersAssistant.LowerClassificationLimit / 100,
                                                                                   false);
        var classifier = _obj.Classifiers.AddNew();
        classifier.ClassifierName = classifierName;
        classifier.ClassifierType = classifierType;
        classifier.ClassifierId = classifierId;
        _obj.Save();
        Logger.DebugFormat("CreateClassifier. New classifier added for AI manager assistant, ClassifierId={0}, AIManagersAssistantId={1}", classifierId, _obj.Id);
        return classifierId;
      }
      catch (Exception ex)
      {
        Logger.ErrorFormat("CreateClassifier. Error creating classifier, AIManagersAssistantId={0}", ex, _obj.Id);
        return null;
      }

    }
  }
}