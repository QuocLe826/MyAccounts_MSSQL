if exists(select 1 from sysobjects where type = 'P' and name = 'AccountGroups_GetData')
begin
	drop procedure AccountGroups_GetData
end
go
create procedure AccountGroups_GetData
as
begin
	
	select * from AccountGroups 
	order by Code

end
