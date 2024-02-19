-- Заполнить свойство Перевыпустить сертификат до окончания срока действия, дн. справочника Настройки подключения к сервисам личного кабинета.
-- Заполнять имеет смысл только в том случае, если в компании подключен ЛК. Совпадает со значением константы DefaultDaysToWarningCertificate.
if exists (SELECT * FROM information_schema.columns 
           WHERE TABLE_NAME = 'DirRX_EssPl_EssSetting' AND COLUMN_NAME = 'DaysToWarnCert')
begin
  UPDATE DirRX_EssPl_EssSetting
  SET DaysToWarnCert = 3
  WHERE DaysToWarnCert is NULL and IsUsedIdentity = 1
end

--Заполнение способа доставки второго фактора в настройках подключения к сервисам ЛК.
if exists (SELECT * FROM information_schema.columns WHERE table_name = 'DirRX_EssPl_EssSetting' AND column_name = 'ConfirmationTy')
begin
  UPDATE DirRX_EssPl_EssSetting
  SET ConfirmationTy = 'DefaultValue'
  WHERE ConfirmationTy is null
end