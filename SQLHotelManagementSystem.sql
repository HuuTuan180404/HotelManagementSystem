USE master
GO

CREATE DATABASE HotelManagementSystem
GO

USE HotelManagementSystem
GO

DROP TABLE IF EXISTS Rooms;
GO

CREATE TABLE Rooms
	(
		RooID int identity(1,1) not null,
		RooNo varchar(10) not null unique,
		RooType varchar(100) not null default 'Single' CHECK (RooType IN ('Single','Double','Triple_2','Triple_3','Twin','Family')),
		RooBed tinyint not null default 1,
		RooFloor tinyint not null default 0,
		RooCustomer tinyint not null default 1,
		RooPrice int not null,
		RooStatus varchar(50) default 'Available' CHECK (RooStatus IN ('Available','Reserved','Occupied','Dirty','Maintenance','Out_of_order')),
		RooNote nvarchar(max) default '',
		CONSTRAINT PK_Rooms_RooID PRIMARY KEY (RooID)
	)
GO



INSERT INTO Rooms (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo001',N'Single',1,1,100)
INSERT INTO Rooms (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo002',N'Double',1,2,100)
INSERT INTO Rooms (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo003',N'Triple_3',3,3,100)
INSERT INTO Rooms (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo004',N'Triple_2',2,3,700)
INSERT INTO Rooms (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo005',N'Twin',2,2,500)
INSERT INTO Rooms (RooNo,RooType,RooBed,RooCustomer,RooPrice) VALUES ('Roo006',N'Family',3,4,100)
INSERT INTO Rooms (RooNo,RooType,RooBed,RooCustomer,RooPrice,RooStatus) VALUES ('Roo007',N'Family',3,4,800,'Dirty')


SELECT * FROM Rooms


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

