if exists(select 1 from sysobjects where type = 'P' and name = 'AccountManagement_ProcessData')
begin
	drop procedure AccountManagement_ProcessData
end
go
create procedure AccountManagement_ProcessData
(
	@code varchar(10), 
	@name nvarchar(254), 
	@username varchar(500), 
	@password varchar(500), 
	@accGroup varchar(10),
	@accType varchar(10),
	@status varchar(1), 
	@descriptions nvarchar(2000), 
	@actionType varchar(1)
)
as
begin
	
	if @actionType = 'A'
	begin
		if exists (select 1 from AccountManagement where Code = @code)
		begin
			select 'This account already exists'
			return
		end

		insert into AccountManagement(Code, Name, Username, Password, AccGroup, AccType, Status, Descriptions, CreateDate, CreateTime)
		values(@code, @name, @username, @password, @accGroup, @accType, @status, @descriptions, GETDATE(), GETDATE())

		select @@ROWCOUNT
		return

	end


	update AccountManagement set
		Name = @name,
		Username = @username,
		Password = @password,
		AccGroup = @accGroup,
		AccType = @accType,
		Status = @status,
		Descriptions = @descriptions,
		UpdateDate = GETDATE(),
		UpdateTime = GETDATE()
	where Code = @code

	select @@ROWCOUNT

end
