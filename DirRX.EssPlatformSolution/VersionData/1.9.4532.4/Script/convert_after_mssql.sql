if exists (SELECT * 
           FROM information_schema.COLUMNS 
           WHERE table_name = 'Sungero_Core_Recipient' 
                 and COLUMN_NAME = 'PersAccStatus_EssPlS_DirRX')
begin
  -- Для всех записей, где еще не заполнено свойство статус регистарции личного кабинета, задать значение по умолчанию.
  UPDATE Sungero_Core_Recipient
  SET PersAccStatus_EssPlS_DirRX = 'InviteIsNotSent'        
  WHERE PersAccStatus_EssPlS_DirRX is NULL and Discriminator = 'B7905516-2BE5-4931-961C-CB38D5677565'
end