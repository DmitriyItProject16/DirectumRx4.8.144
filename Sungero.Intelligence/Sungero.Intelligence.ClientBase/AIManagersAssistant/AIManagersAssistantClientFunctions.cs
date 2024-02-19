using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Intelligence.AIManagersAssistant;

namespace Sungero.Intelligence.Client
{
  partial class AIManagersAssistantFunctions
  {

    /// <summary>
    /// Проверить, что свойство-коллекция - это классификаторы виртуального ассистента.
    /// </summary>
    /// <param name="collection">Коллекция.</param>
    /// <param name="rootEntity">Родительская сущность.</param>
    /// <returns>Результат проверки.</returns>
    public static bool CollectionIsAIAssistantClassifiers(Sungero.Domain.Shared.IChildEntityCollection<Sungero.Domain.Shared.IChildEntity> collection,
                                                          Sungero.Domain.Shared.IEntity rootEntity)
    {
      var virtualAssistant = Intelligence.AIManagersAssistants.As(rootEntity);
      return virtualAssistant != null && collection == virtualAssistant.Classifiers;
    }

  }
}