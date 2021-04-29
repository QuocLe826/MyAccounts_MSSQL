if exists(select 1 from sysobjects where type = 'P' and name = 'AccountManagement_SearchData')
begin
	drop procedure AccountManagement_SearchData
end
go
create procedure AccountManagement_SearchData(@username varchar(150), @accGroup varchar(20), @accType varchar(20))
as
begin
	
	select a.Code, a.Name, a.Username, a.Password, a.AccGroup as AccGroupCode, b.Name as AccGroupName, a.AccType as AccTypeCode, c.Name as AccTypeName, a.Status, a.Descriptions
	from AccountManagement a
	inner join AccountGroups b on a.AccGroup = b.Code
	inner join AccountType c on a.AccType = c.Code
	where
	(a.Username = '' or a.Username like '%' + @username + '%') 
	and (a.AccGroup = '' or a.AccGroup like '%' + @accGroup + '%') 
	and (a.AccType = '' or a.AccType like '%' + @accType + '%') 
	order by a.Code

end
