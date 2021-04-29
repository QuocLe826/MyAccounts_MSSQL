if exists(select 1 from sysobjects where type = 'P' and name = 'AccountManagement_GetAccountType')
begin
	drop procedure AccountManagement_GetAccountType
end
go
create procedure AccountManagement_GetAccountType
as
begin
	select Code, Name from AccountType where Status = 'Y'
	order by Code
end
