create table AccountManagement
(
	Code varchar(20) primary key not null,
	Name nvarchar(254) null,
	Username varchar(500) null,
	Password varchar(500) null,
	AccGroup varchar(10) null,
	AccType varchar(10) null,
	Status varchar(1) null,
	Descriptions nvarchar(2000) null,
	CreateDate date null,
	CreateTime time null,
	UpdateDate date null,
	UpdateTime time null
)

