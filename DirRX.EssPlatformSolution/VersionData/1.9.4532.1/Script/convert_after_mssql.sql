-- Заполнить реквизит Наследовать от организации в справочнике Сотрудники.
IF EXISTS (SELECT * 
           FROM information_schema.COLUMNS 
           WHERE TABLE_NAME = 'sungero_core_recipient' 
                 AND COLUMN_NAME = 'inheritfrombu_esspls_dirrx')
  BEGIN
    UPDATE Sungero_Core_Recipient
    SET InheritFromBU_EssPlS_DirRX = 1
    WHERE InheritFromBU_EssPlS_DirRX is NULL and Discriminator = 'b7905516-2be5-4931-961c-cb38d5677565'
  END
  
-- Заполнить реквизит О новых заданиях в справочнике Наши организации.
IF EXISTS (SELECT * 
           FROM information_schema.COLUMNS 
           WHERE TABLE_NAME = 'sungero_core_recipient' 
                 AND COLUMN_NAME = 'neednotinewbu_esspls_dirrx')
  BEGIN
    UPDATE Sungero_Core_Recipient
    SET NeedNotiNewBU_EssPlS_DirRX = 'No'
    WHERE NeedNotiNewBU_EssPlS_DirRX is NULL and Discriminator = 'eff95720-181f-4f7d-892d-dec034c7b2ab'
  END
  
-- Заполнить реквизит О просроченных заданиях в справочнике Наши организации.
IF EXISTS (SELECT * 
           FROM information_schema.COLUMNS 
           WHERE TABLE_NAME = 'sungero_core_recipient' 
                 AND COLUMN_NAME = 'neednotiexpbu_esspls_dirrx')
  BEGIN
    UPDATE Sungero_Core_Recipient
    SET NeedNotiExpBU_EssPlS_DirRX = 'No'
    WHERE NeedNotiExpBU_EssPlS_DirRX is NULL and Discriminator = 'eff95720-181f-4f7d-892d-dec034c7b2ab'
  END
  
-- Заполнить реквизит О приближении срока ознакомления и подписания в справочнике Наши организации.
IF EXISTS (SELECT * 
           FROM information_schema.COLUMNS 
           WHERE TABLE_NAME = 'sungero_core_recipient' 
                 AND COLUMN_NAME = 'neednotihrrbu_esspls_dirrx')
  BEGIN
    UPDATE Sungero_Core_Recipient
    SET NeedNotiHRRBU_EssPlS_DirRX = 'No'
    WHERE NeedNotiHRRBU_EssPlS_DirRX is NULL and Discriminator = 'eff95720-181f-4f7d-892d-dec034c7b2ab'
  END