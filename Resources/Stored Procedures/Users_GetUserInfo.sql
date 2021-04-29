if exists(select 1 from sysobjects where type = 'P' and name = 'Users_GetUserInfo')
begin
	drop procedure Users_GetUserInfo
end
go
create procedure Users_GetUserInfo(@username varchar(20))
as
begin
	
	select UserID, UserCode, Password, FirstName, LastName, Status from Users

end
