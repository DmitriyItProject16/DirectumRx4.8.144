do $$
begin
if not exists (select column_name
               from information_schema.columns
               where table_name='sungero_excore_queueitem' 
                 and column_name = 'documentid_docflow_sungero'
                 and data_type = 'bigint') then
			 
  alter table sungero_excore_queueitem
  add column documentid_docflow_sungero bigint;
end if;
end $$
