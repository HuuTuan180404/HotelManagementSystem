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


CREATE TABLE RoomStatus
(
    RStatus VARCHAR(100) PRIMARY KEY,
    RSDescription NVARCHAR(MAX)
)
GO

--Rooms_Type
CREATE TABLE RoomType
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
    RId VARCHAR(50) NOT NULL PRIMARY KEY,
	RType VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES RoomType(RType),
    RStatus VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES RoomStatus(RStatus),
	RPricePerNight DECIMAL(10,2) NOT NULL CHECK (RPricePerNight >= 0) DEFAULT 100,
	RDescription NVARCHAR(MAX)
)
GO

CREATE PROC Table_Rooms_Detail
AS
BEGIN
	SELECT RId,
		   R.RType,
		   RTBedCount, 
		   RTMaxGuests,
		   RStatus,
		   RPricePerNight,
		   RDescription
	FROM [HotelManagementSystem].[dbo].[Rooms] R
		 JOIN [HotelManagementSystem].[dbo].RoomType RT ON R.RType=RT.RType
	
	ORDER BY RId ASC
END;
GO

CREATE PROC Table_RoomType
AS
BEGIN
	SELECT * FROM RoomType
	ORDER BY RType ASC
END;
GO



EXEC Table_RoomType
GO


SET NOCOUNT ON;
GO

INSERT INTO RoomStatus (RStatus, RSDescription) VALUES
('Available', N'Phòng trống, sẵn sàng đón khách'),
('Occupied', N'Phòng đang có khách'),
('Reserved', N'Phòng đã được đặt trước'),
('Maintenance', N'Phòng đang bảo trì'),
('Cleaning', N'Phòng đang được dọn dẹp');
GO


INSERT INTO RoomType (RType, RTBedCount, RTMaxGuests, RTDescription) VALUES
('Standard', 1, 2, N'Phòng tiêu chuẩn với 1 giường đôi'),
('Deluxe', 2, 4, N'Phòng cao cấp với 2 giường đôi'),
('Suite', 1, 2, N'Phòng hạng sang với nội thất cao cấp'),
('Family', 2, 6, N'Phòng gia đình rộng rãi với 2 giường lớn'),
('VIP', 1, 2, N'Phòng VIP với dịch vụ đặc biệt');
GO


INSERT INTO Rooms (RId, RPricePerNight, RDescription, RStatus, RType) VALUES
('Roo1-1', 100.00, N'Phòng tiêu chuẩn tầng 1', 'Available','Standard' ),
('Roo1-2', 150.00, N'Phòng Deluxe tầng 1', 'Reserved', 'Deluxe'),
('Roo2-1', 200.00, N'Phòng Suite tầng 2', 'Occupied', 'Suite'),
('Roo2-2', 180.00, N'Phòng Family tầng 2', 'Available', 'Family'),
('Roo3-1', 300.00, N'Phòng VIP tầng 3', 'Cleaning', 'VIP'),
('Roo3-2', 250.00, N'Phòng Deluxe tầng 3', 'Maintenance', 'Deluxe');
GO

-- ======================================================================================
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

INSERT INTO Employee_Role (ERole, ERDescription)
VALUES 
('Manager', N'Quản lý bộ phận'),
('Developer', N'Lập trình viên'),
('Tester', N'Kiểm thử viên'),
('HR', N'Nhân sự'),
('Support', N'Hỗ trợ kỹ thuật');


INSERT INTO Employees (EID, EName, EGender, EPhone, EEmail, EAddress, EStatus, ERole)
VALUES 
('E001', N'Nguyễn Văn A', 'Male', '0987654321', 'vana@example.com', N'123 Đường A, TP.HCM', 'Active', 'Manager'),
('E002', N'Lê Thị B', 'Female', '0987654322', 'thib@example.com', N'456 Đường B, TP.HCM', 'On Leave', 'HR'),
('E003', N'Trần Văn C', 'Male', '0987654323', 'vanc@example.com', N'789 Đường C, TP.HCM', 'Active', 'Developer'),
('E004', N'Phạm Thị D', 'Female', '0987654324', 'thid@example.com', N'101 Đường D, TP.HCM', 'Inactive', 'Tester'),
('E005', N'Hoàng Văn E', 'Male', '0987654325', 'vane@example.com', N'202 Đường E, TP.HCM', 'Active', 'Support');


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
