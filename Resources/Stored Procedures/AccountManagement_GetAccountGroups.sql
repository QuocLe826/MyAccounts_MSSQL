if exists(select 1 from sysobjects where type = 'P' and name = 'AccountManagement_GetAccountGroups')
begin
	drop procedure AccountManagement_GetAccountGroups
end
go
create procedure AccountManagement_GetAccountGroups
as
begin
	select Code, Name from AccountGroups 
	union 
	select '', '' from AccountGroups
	where Status = 'Y'
	order by Name
end
