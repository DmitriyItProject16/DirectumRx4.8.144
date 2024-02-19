using System;
using Sungero.Core;

namespace Sungero.MobileApps.Constants
{
  public static class Module
  {
    /// <summary>
    /// Очередь сообщений для сервера мобильных приложений. 
    /// </summary>
    [Public]
    public const string MobileAppQueueName = "mobile_app_events";

    #region Инициализация

    public const string SungeroMobAppsMobileDeviceTableName = "Sungero_MobApps_MobileDevice";

    public const string SungeroMobileDeviceIndex0 = "idx_Devices_Employee_DeviceId";

    #endregion
  }
}