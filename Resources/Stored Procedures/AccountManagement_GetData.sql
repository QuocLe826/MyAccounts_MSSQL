if exists(select 1 from sysobjects where type = 'P' and name = 'AccountManagement_GetData')
begin
	drop procedure AccountManagement_GetData
end
go
create procedure AccountManagement_GetData
as
begin
	select a.Code, a.Name, a.Username, a.Password, a.AccGroup as AccGroupCode, b.Name as AccGroupName, a.AccType as AccTypeCode, c.Name as AccTypeName, a.Status, a.Descriptions 
	from AccountManagement a
	inner join AccountGroups b on a.AccGroup = b.Code
	inner join AccountType c on a.AccType = c.Code
	order by a.Code
end
