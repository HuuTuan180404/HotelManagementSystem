USE master
GO

CREATE DATABASE HotelManagementSystem
GO

USE HotelManagementSystem
GO

CREATE TABLE Room
	(
		RooID int identity(1,1) not null,
		RooNo varchar(10) not null unique,
		RooType varchar(100) not null default 'Single',
		RooBed tinyint not null default 1,
		RooFloor tinyint not null default 0,
		RooCustomer tinyint not null default 1,
		RooPrice int not null,
		RooStatus varchar(50) default 'Available',
		RooNote nvarchar(max),
		CONSTRAINT PK_Rooms_RooID PRIMARY KEY (RooID)
	)
GO

DROP TABLE Room
GO

INSERT INTO Room (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo001',N'Single',1,1,100)
INSERT INTO Room (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo002',N'Double',1,2,100)
INSERT INTO Room (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo003',N'Triple',3,3,100)
INSERT INTO Room (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo004',N'Triple',2,3,100)
INSERT INTO Room (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo005',N'Twin',2,2,100)
INSERT INTO Room (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo006',N'Family',3,4,100)


/*
CREATE TABLE Employees
	(
		EmpID int identity(1,1) not null,
		EmpName nvarchar(30) not null,
		EmpPassword varchar(30) not null,
		CONSTRAINT PK_Employees_EmpID PRIMARY KEY (EmpID)
	)
GO

INSERT INTO Employees VALUES(N'Nguyễn Hữu Tuấn','123456')
*/

