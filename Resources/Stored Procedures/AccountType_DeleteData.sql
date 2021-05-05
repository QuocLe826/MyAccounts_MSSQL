if exists(select 1 from sysobjects where type = 'P' and name = 'AccountType_DeleteData')
begin
	drop procedure AccountType_DeleteData
end
go
create procedure AccountType_DeleteData(@code varchar(10))
as
begin

	if exists(select 1 from AccountManagement where AccType = @code)
	begin
		select 'This account type has been used!'
		return
	end

	delete from AccountType where Code = @code
	select ''
end

