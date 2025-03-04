USE master
GO

CREATE DATABASE HotelManagementSystem
GO

USE HotelManagementSystem
GO
/*
----------------------------------DROP TABLE IF EXISTS----------------------

DROP TABLE IF EXISTS Payments_Service
GO

DROP TABLE IF EXISTS Payments_Booking
GO

DROP TABLE IF EXISTS ServiceUsageDetail
GO

DROP TABLE IF EXISTS ServiceUsage
GO

DROP TABLE IF EXISTS Bookings
GO

DROP TABLE IF EXISTS Services
GO

DROP TABLE IF EXISTS Employees
GO

DROP TABLE IF EXISTS Customers;
GO

DROP TABLE IF EXISTS Rooms;
GO

DROP TABLE IF EXISTS Employees_Role
GO

DROP TABLE IF EXISTS Rooms_Type;
GO

DROP TABLE IF EXISTS Rooms_Status;
GO
*/
----------------------------------CREATE TABLE----------------------------

--Rooms_Status


CREATE TABLE Room_Status
(
    RStatus VARCHAR(100) PRIMARY KEY,
    RSDescription NVARCHAR(MAX)
)
GO

--Rooms_Type
CREATE TABLE Room_Type
(
    RType VARCHAR(100) NOT NULL PRIMARY KEY,
	RTBedCount TINYINT NOT NULL DEFAULT 1,
	RTMaxGuests TINYINT NOT NULL DEFAULT 1,
	RTDescription NVARCHAR(MAX)
)
GO

--Rooms
CREATE TABLE Rooms
(
	RFloor INT NOT NULL DEFAULT 0,  
    RNo INT NOT NULL,    
	PRIMARY KEY (RFloor,RNo),
	RPricePerNight DECIMAL(10,2) NOT NULL CHECK (RPricePerNight >= 0) DEFAULT 100,
    RStatus VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES Room_Status(RStatus),
	RType VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES Room_Type(RType),
	RDescription NVARCHAR(MAX)
)
GO


--Customers
CREATE TABLE Customers
(
    CID VARCHAR(100) PRIMARY KEY,   
    CName NVARCHAR(100) NOT NULL,        
    CGender CHAR(6) CHECK (CGender IN ('Male', 'Female', 'Other')) NOT NULL,  
    CPhone VARCHAR(15) UNIQUE NOT NULL,
    CEmail VARCHAR(100) UNIQUE,
    CAddress NVARCHAR(255),         
    CType CHAR(20) CHECK (CType IN ('Regular', 'VIP', 'New')) DEFAULT 'New'
)
GO

--Employees_Role
CREATE TABLE Employee_Role (
    ERole VARCHAR(100) PRIMARY KEY,   
    ERDescription NVARCHAR(100)
)
GO

--Employees
CREATE TABLE Employees 
(
    EID VARCHAR(100) PRIMARY KEY,   
    EName NVARCHAR(100) NOT NULL,         
    EGender CHAR(6) CHECK (EGender IN ('Male', 'Female', 'Other')) NOT NULL,  
    EPhone VARCHAR(15) UNIQUE NOT NULL,   
    EEmail VARCHAR(100) UNIQUE ,  
    EAddress NVARCHAR(255) ,          
    EStatus CHAR(10) CHECK (EStatus IN ('Active', 'Inactive', 'On Leave')) NOT NULL,  
    ERole VARCHAR(100) FOREIGN KEY REFERENCES Employee_Role(ERole)                 
)
GO

CREATE TABLE [Services] 
(
    SName VARCHAR(100) PRIMARY KEY,
    SPrice DECIMAL(10,2) NOT NULL CHECK (SPrice >= 0),
    SDescription NVARCHAR(MAX)
);
GO

CREATE TABLE Booking_Status
(
	BStatus VARCHAR(100) PRIMARY KEY,
	BKDescription NVARCHAR(MAX)
)
GO


CREATE TABLE Payment_Method
(
	PMethod VARCHAR(100) PRIMARY KEY,
	Description NVARCHAR(MAX)
)
GO

CREATE TABLE Payment_Status
(
    PStatus VARCHAR(100) PRIMARY KEY,
    Description NVARCHAR(MAX)
)
GO


CREATE TABLE Bookings (
    BID VARCHAR(100) PRIMARY KEY,
    RFloor INT NOT NULL,
	RNo INT NOT NULL,
    CID VARCHAR(100) NOT NULL FOREIGN KEY (CID) REFERENCES Customers(CID),
	EID VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES Employees(EID),
    BTimeCheckIn DATETIME NOT NULL,  
    BTimeCheckOut DATETIME NOT NULL, 
    BStatus VARCHAR(100) NOT NULL,  
    BCreateAt DATETIME DEFAULT GETDATE(),
	FOREIGN KEY (RFloor,RNo) REFERENCES Rooms(RFloor,RNo)
);
GO

CREATE TABLE ServiceUsage 
(
    BID VARCHAR(100) PRIMARY KEY FOREIGN KEY (BID) REFERENCES Bookings(BID), 
    SUDate DATETIME NOT NULL DEFAULT GETDATE(),
	PMethod VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES Payment_Method(PMethod),
    PStatus VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES Payment_Status(PStatus)
);
GO

CREATE TABLE ServiceUsageDetail 
(
    BID VARCHAR(100) FOREIGN KEY REFERENCES ServiceUsage(BID),
    SName VARCHAR(100) FOREIGN KEY REFERENCES Services(SName),
	PRIMARY KEY (BID, SName),

	EID VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES Employees(EID),
    UnitPrice DECIMAL(10,2) NOT NULL CHECK (UnitPrice >= 0),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    Discount DECIMAL(5,2) DEFAULT 0 CHECK (Discount BETWEEN 0 AND 100)    
);
GO

CREATE TABLE Booking_Payments
(
    BID VARCHAR(100) PRIMARY KEY FOREIGN KEY (BID) REFERENCES Bookings(BID),
    EID VARCHAR(100) FOREIGN KEY (EID) REFERENCES Employees(EID),
    BPAmount DECIMAL(10,2) NOT NULL CHECK (BPAmount >= 0),
    BPDate DATETIME DEFAULT GETDATE(),
    PMethod VARCHAR(100) FOREIGN KEY (PMethod) REFERENCES Payment_Method(PMethod),
    PStatus VARCHAR(100) FOREIGN KEY (PStatus) REFERENCES Payment_Status(PStatus)
);
GO

----------------------------PROCEDURE---------------------------

CREATE PROC Table_Rooms_Detail
AS
BEGIN
	SELECT CONCAT('Roo',[RFloor],'-',[RNo]) AS RoomID,
       R.RType,
       RTBedCount, 
       RTMaxGuests,
       R.RStatus,
       RPricePerNight,
       RDescription
	FROM [HotelManagementSystem].[dbo].[Rooms] R
		 JOIN [HotelManagementSystem].[dbo].Room_Type RT ON R.RType = RT.RType
	ORDER BY RoomID ASC
END;
GO


CREATE PROC When_INSERT_INTO_Bookings @BID VARCHAR(100), @RID INT, @CID VARCHAR(100), @EID VARCHAR(100), @BTimeCheckIn DATETIME, @BTimeCheckOut DATETIME, @BStatus VARCHAR(100)
AS
BEGIN
	INSERT INTO Bookings
	VALUES (@BID,@RID,@CID,@EID, @BTimeCheckIn, @BTimeCheckOut,@BStatus,GETDATE())

	INSERT INTO Booking_Payments
	VALUES (@BID, @EID ,0 ,GETDATE(),'Cash','Pending')

	INSERT INTO ServiceUsage
	VALUES (@BID, GETDATE(),'Cash','Pending')
END
GO

/*
CREATE PROC When_Order_Service @BID VARCHAR(100), @RID INT, @CID VARCHAR(100), @EID VARCHAR(100), @BTimeCheckIn DATETIME, @BTimeCheckOut DATETIME, @BStatus VARCHAR(100)
AS
BEGIN
	INSERT INTO Bookings
	VALUES (@BID,@RID,@CID,@EID, @BTimeCheckIn, @BTimeCheckOut,@BStatus,GETDATE())

	INSERT INTO Booking_Payments
	VALUES (@BID, @EID ,0 ,GETDATE(),'Cash','Pending')
END
GO
*/
--------------------------------TRIGGER---------------------------------
