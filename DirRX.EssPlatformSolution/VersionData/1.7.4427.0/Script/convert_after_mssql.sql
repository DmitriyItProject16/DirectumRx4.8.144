-- Заполнить новые свойства в справочнике Наши организации. 
if exists (SELECT *
           FROM information_schema.COLUMNS
           WHERE table_name = 'Sungero_Core_Recipient'
                 and COLUMN_NAME = 'SmsAfterTempor_EssPlS_DirRX')
begin
  UPDATE Sungero_Core_Recipient
  SET SmsAfterTempor_EssPlS_DirRX = 'Ваш номер телефона временно отключен от личного кабинета',
      SmsAfterActiva_EssPlS_DirRX = 'Доступ в Личный кабинет - #URL_SITE_ESS'
  WHERE SmsAfterTempor_EssPlS_DirRX is NULL and Discriminator = 'eff95720-181f-4f7d-892d-dec034c7b2ab' and Status = 'Active' and UseESSDirRX_EssPlS_DirRX = '1'
end