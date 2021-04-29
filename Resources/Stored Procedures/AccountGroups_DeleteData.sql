if exists(select 1 from sysobjects where type = 'P' and name = 'AccountGroups_DeleteData')
begin
	drop procedure AccountGroups_DeleteData
end
go
create procedure AccountGroups_DeleteData(@code varchar(10))
as
begin
	
	if exists(select 1 from AccountType where Code = @code)
	begin
		select 'This account type is used'
		return
	end

	delete from AccountGroups where Code = @code
	select @@ROWCOUNT
end
