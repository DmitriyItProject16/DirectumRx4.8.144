--Заполнение способа доставки второго фактора в сотрудниках
IF EXISTS (SELECT * FROM information_schema.columns 
WHERE table_name = 'sungero_core_recipient' AND column_name = 'confirmationty_esspls_dirrx')
  BEGIN
    UPDATE sungero_core_recipient
    SET confirmationty_esspls_dirrx = 'DefaultValue'
    WHERE discriminator = 'b7905516-2be5-4931-961c-cb38d5677565' 
    AND confirmationty_esspls_dirrx is null
  END
