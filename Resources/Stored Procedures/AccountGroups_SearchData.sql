if exists(select 1 from sysobjects where type = 'P' and name = 'AccountGroups_SearchData')
begin
	drop procedure AccountGroups_SearchData
end
go
create procedure AccountGroups_SearchData(@code varchar(20), @name nvarchar(254), @status varchar(1), @descriptions nvarchar(2000))
as
begin
	
	select * from AccountGroups 
	where
	(Code = '' or Code like '%' + @code + '%') 
	and (Name = '' or Name like '%' + @name + '%') 
	and (Status = '' or Status = @status)
	and (Descriptions = '' or Descriptions like '%' + @descriptions + '%') 
	order by Code

end
