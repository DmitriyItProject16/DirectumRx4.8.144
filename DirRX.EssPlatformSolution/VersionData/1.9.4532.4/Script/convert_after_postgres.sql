DO $$
begin
if exists (SELECT *
           FROM information_schema.columns
           WHERE table_name = 'sungero_core_recipient' and column_name = 'persaccstatus_esspls_dirrx')
  then
    -- Для всех записей, где еще не заполнено свойство статус регистарции личного кабинета, задать значение по умолчанию.
    UPDATE Sungero_Core_Recipient
    SET PersAccStatus_EssPlS_DirRX = 'InviteIsNotSent'
    WHERE PersAccStatus_EssPlS_DirRX IS NULL and Discriminator = 'b7905516-2be5-4931-961c-cb38d5677565';
  end if;
end$$;