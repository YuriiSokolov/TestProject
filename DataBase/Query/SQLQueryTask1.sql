CREATE Table Document
(
	ID int identity (1, 1) CONSTRAINT Document_PK primary key(ID), 
	Date varchar(35) not null, 
	Organization varchar(35) not null,
	City varchar(35) not null,
	Country varchar(35) not null,
	Manager varchar(35) not null,
	Count int not null,
	Sum float not null
)

INSERT INTO Document ([Date], Organization, City, Country, Manager, [Count], [Sum])
Values ('01.01.2019', '������', '����', '�������', '������', 1, 100)

INSERT INTO Document ([Date], Organization, City, Country, Manager, [Count], [Sum])
Values ('01.01.2019', '���', '������', '������', '������', 2, 250)

INSERT INTO Document ([Date], Organization, City, Country, Manager, [Count], [Sum])
Values ('01.01.2019', '���', '������', '������', '������', 5, 450)

INSERT INTO Document ([Date], Organization, City, Country, Manager, [Count], [Sum])
Values ('02.01.2019', '������', '����', '�������', '������', 7, 750)

INSERT INTO Document ([Date], Organization, City, Country, Manager, [Count], [Sum])
Values ('02.01.2019', '���', '������', '������', '�������', 10, 1050)

INSERT INTO Document ([Date], Organization, City, Country, Manager, [Count], [Sum])
Values ('02.01.2019', '���', '������', '������', '��������', 10, 1050)

INSERT INTO Document ([Date], Organization, City, Country, Manager, [Count], [Sum])
Values ('01.03.2019', '���', '������', '������', '������', 2, 250)

select * from Document

--�������/////////////////////////////////////////////////////////////
select [Date], [Organization], Sum([Count]), Sum([Sum]) from Document
Group by [Date], Organization

select Manager, Sum([Count]), Sum([Sum]) from Document
Group By Manager
--////////////////////////////////////////////////////////////////////

Select AVG([Sum]) as 'AVG' From Document Where Manager = '������' AND Date LIKE '%.01.2019'

Alter Table Document
drop constraint Document_PK
go
drop table Document

Create table [Authorization]
(
	ID int identity (1, 1) CONSTRAINT Authorization_PK primary key(ID),
	[Name] varchar(35) not null,
	[Login] varchar(35) not null,
	[Password] varchar(64) not null,
	[Admin] bit default 0 not null,
	Ban bit default 0 not null
)

Alter Table [Authorization]
drop constraint Authorization_PK
go
drop table [Authorization]

INSERT INTO [Authorization] (Name, Login, Password)
values ('������', 'Ivanov', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92')

INSERT INTO [Authorization] (Name, Login, Password)
values ('������', 'Petrov', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92')

INSERT INTO [Authorization] (Name, Login, Password)
values ('�������', 'Sidorov', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92')

INSERT INTO [Authorization] (Name, Login, Password)
values ('��������', 'Vasiliev', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92')

INSERT INTO [Authorization] (Name, Login, Password)
values ('�������', 'Komarov', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92')

select * from [Authorization]

UPDATE [Authorization] SET Admin=1 WHERE Login='Petrov'