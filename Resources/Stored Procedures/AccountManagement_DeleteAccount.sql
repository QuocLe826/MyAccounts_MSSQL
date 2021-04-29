if exists(select 1 from sysobjects where type = 'P' and name = 'AccountManagement_DeleteAccount')
begin
	drop procedure AccountManagement_DeleteAccount
end
go
create procedure AccountManagement_DeleteAccount(@code varchar(10))
as
begin
	
	delete from AccountManagement where Code = @code
	select @@ROWCOUNT

end
