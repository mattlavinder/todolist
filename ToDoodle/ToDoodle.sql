
use ToDoodle
go
drop table if exists Items;
drop table if exists Lists;
drop table if exists Users;
go

create table Users(
	Id int not null identity(1,1),
	LoginName nvarchar(40) not null,
	LoginPassword binary(64),
	UserName nvarchar(255),
	UserMobile nvarchar(32),
	DateCreated smalldatetime NOT NULL CONSTRAINT Users_DateCreate_Default DEFAULT CURRENT_TIMESTAMP,
	DateUpdated smalldatetime,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED (Id ASC),
    CONSTRAINT [AK_Users_LoginName] UNIQUE (LoginName ASC)
)
go
create table Lists
(
	Id int not null identity(1,1),
	OwnerId int not null,
	Title nvarchar(MAX),
	Archived bit,
	Deleted bit,
	DateCreated smalldatetime NOT NULL CONSTRAINT Lists_DateCreate_Default DEFAULT CURRENT_TIMESTAMP,
    DateUpdated smalldatetime,
	CONSTRAINT PK_Lists PRIMARY KEY NONCLUSTERED (Id),
	CONSTRAINT FK_Lists_Owner FOREIGN KEY (OwnerId)     
		REFERENCES Users(Id)
)
go
create table Items
(
	Id int not null identity(1,1), 
	ListId int not null,
	OwnerId int not null,
	Title nvarchar(MAX),
	Complete bit,
	Deleted bit,
	DateCreated smalldatetime NOT NULL CONSTRAINT Items_DateCreate_Default DEFAULT CURRENT_TIMESTAMP,
    DateUpdated smalldatetime,
	CONSTRAINT PK_Items PRIMARY KEY NONCLUSTERED (Id),
	CONSTRAINT FK_Items_Owner FOREIGN KEY (OwnerId)     
		REFERENCES Users(Id),
	CONSTRAINT FK_Items_List FOREIGN KEY (ListId)     
		REFERENCES Lists(Id)
)
go

insert into Users(LoginName, UserName, UserMobile) 
values('mattlavinder@gmail.com', 'Matt Lavinder', '2767345598');
insert into Lists(Title,OwnerId) values('Grocerties', 1);
insert into Items(ListId,Title,OwnerId) values(1,'Milk',1);
insert into Items(ListId,Title,OwnerId) values(1,'Bread',1);
insert into Items(ListId,Title,OwnerId) values(1,'Eggs',1);
go

select * from Users;
select * from Lists;
select * from Items;
go