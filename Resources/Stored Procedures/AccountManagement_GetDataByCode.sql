if exists(select 1 from sysobjects where type = 'P' and name = 'AccountManagement_GetDataByCode')
begin
	drop procedure AccountManagement_GetDataByCode
end
go
create procedure AccountManagement_GetDataByCode(@code varchar(10))
as
begin
	select a.Code, a.Name, a.Username, a.Password, a.AccGroup as AccGroupCode, b.Name as AccGroupName, a.AccType as AccTypeCode, c.Name as AccTypeName, a.Status, a.Descriptions 
	from AccountManagement a
	inner join AccountGroups b on a.AccGroup = b.Code
	inner join AccountType c on a.AccType = c.Code
	where a.Code = @code
	order by a.Code
end
