if exists(select 1 from sysobjects where type = 'P' and name = 'AccountType_GetData')
begin
	drop procedure AccountType_GetData
end
go
create procedure AccountType_GetData
as
begin
	
	select * from AccountType
	order by Code

end
