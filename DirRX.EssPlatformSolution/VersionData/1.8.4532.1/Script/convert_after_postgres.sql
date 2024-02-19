DO $$
begin 
  --Заполнение способа доставки второго фактора в сотрудниках
  IF EXISTS (SELECT * FROM information_schema.columns 
	WHERE table_name = 'sungero_core_recipient' AND column_name = 'confirmationty_esspls_dirrx')
    THEN 
      UPDATE sungero_core_recipient AS scr
      SET confirmationty_esspls_dirrx = 'DefaultValue'
      WHERE discriminator = 'b7905516-2be5-4931-961c-cb38d5677565' 
      AND confirmationty_esspls_dirrx is null;
    END IF;
    
  -- Заполнить свойство "подключение к ЛК". Аналогичный запрос не срабытвает в скрипте версии 0.0.1
  if exists (SELECT *
           FROM information_schema.columns
           WHERE table_name = 'sungero_core_recipient' and column_name = 'persaccstatus_esspls_dirrx')
  then
    -- Для всех записей, где еще не заполнено свойство статус регистарции личного кабинета, задать значение по умолчанию.
    UPDATE sungero_core_recipient
    SET persaccstatus_esspls_dirrx = 'InviteIsNotSent'
    WHERE persaccstatus_esspls_dirrx IS NULL and discriminator = 'b7905516-2be5-4931-961c-cb38d5677565' and status = 'Active';
  end if;
  
 end$$;