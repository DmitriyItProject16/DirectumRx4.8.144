using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Initialization;

namespace Sungero.MobileApps.Server
{
  public partial class ModuleInitializer
  {

    public override void Initializing(Sungero.Domain.ModuleInitializingEventArgs e)
    {
      CreateMobileDevicesIndex();
    }

    #region Создание прикладных индексов в бд

    public static void CreateMobileDevicesIndex()
    {
      var tableName = Constants.Module.SungeroMobAppsMobileDeviceTableName;
      var indexName = Constants.Module.SungeroMobileDeviceIndex0;
      var indexQuery = string.Format(Queries.Module.SungeroMobileDeviceIndex0Query, tableName, indexName);

      Docflow.PublicFunctions.Module.CreateIndexOnTable(tableName, indexName, indexQuery);
    }

    #endregion
  }

}
