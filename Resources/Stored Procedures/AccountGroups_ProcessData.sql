if exists(select 1 from sysobjects where type = 'P' and name = 'AccountGroups_ProcessData')
begin
	drop procedure AccountGroups_ProcessData
end
go
create procedure AccountGroups_ProcessData(@code varchar(10), @name nvarchar(254), @status varchar(1), @descriptions nvarchar(2000), @actionType varchar(1))
as
begin
	
	if @actionType = 'A'
	begin
		if exists (select 1 from AccountGroups where Code = @code)
		begin
			select 'This account group already exists'
			return
		end

		insert into AccountGroups(Code, Name, Status, Descriptions, CreateDate, CreateTime)
		values(@code, @name, @status, @descriptions, GETDATE(), GETDATE())

		select @@ROWCOUNT
		return

	end


	update AccountGroups set
		Name = @name,
		Status = @status,
		Descriptions = @descriptions,
		UpdateDate = GETDATE(),
		UpdateTime = GETDATE()
	where Code = @code

	select @@ROWCOUNT

end
