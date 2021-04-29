if exists(select 1 from sysobjects where type = 'P' and name = 'CreateNewUser')
begin
	drop procedure CreateNewUser
end
go
create procedure CreateNewUser(@firstName nvarchar(50), @lastName nvarchar(80), @username varchar(20), @password varchar(200))
as
begin
	
	delete from Users

	insert into Users(UserID, UserCode, Password, FirstName, LastName, Status, LastLogin, CreateDate, CreateTime)
	values(1, @username, @password, @firstName, @lastName, 'Y', GETDATE(), GETDATE(), GETDATE())

	select @@ROWCOUNT

end
