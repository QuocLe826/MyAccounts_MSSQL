create table AccountType
(
	Code varchar(20) primary key not null,
	Name nvarchar(254) null,
	Status varchar(1) null,
	Descriptions nvarchar(2000) null,
	CreateDate date null,
	CreateTime time null,
	UpdateDate date null,
	UpdateTime time null
)