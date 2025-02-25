USE master
GO

CREATE DATABASE HotelManagementSystem
GO

USE HotelManagementSystem
GO

-------------Table Rooms_Status---------------

DROP TABLE IF EXISTS Rooms_Status;
GO

CREATE TABLE Rooms_Status
(
    RSID INT IDENTITY(1,1) NOT NULL,
    RSStatus VARCHAR(100) NOT NULL UNIQUE,
    RSDescription NVARCHAR(MAX),
    CONSTRAINT PK_Rooms_Status_RSID PRIMARY KEY (RSID)
)
GO

INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Available',N'Phòng trống')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Reserved',N'Đã nhận phòng')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Occupied',N'Đã đặt')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Dirty',N'Cần vệ sinh')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Cleaning',N'Đang vệ sinh')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Maintenance',N'Đang bảo trì')
GO

------------Table Rooms_Type-------

DROP TABLE IF EXISTS Rooms_Type;
GO

CREATE TABLE Rooms_Type
(
    RTID INT IDENTITY(1,1) NOT NULL,
    RTType VARCHAR(100) NOT NULL UNIQUE,
	RTBedCount TINYINT NOT NULL DEFAULT 1,
	RTMaxGuests TINYINT NOT NULL DEFAULT 1,
	RTDescription NVARCHAR(MAX) DEFAULT '',
    CONSTRAINT PK_Rooms_Type_RSID PRIMARY KEY (RTID)
)
GO
 
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests) VALUES ('Single',1,1)
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests) VALUES ('Double',1,2)
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests,RTDescription) VALUES ('Triple_2',2,3,N'3 giường đơn')
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests,RTDescription) VALUES ('Triple_3',1,3,N'1 giường đôi + 1 giường đơn')
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests) VALUES ('Twin',2,2)
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests,RTDescription) VALUES ('Family',2,4,N'1 giường đôi + 2 giường đơn')
GO

-----------Table Rooms-------

DROP TABLE IF EXISTS Rooms;
GO

CREATE TABLE Rooms
(
    RID INT IDENTITY(1,1) NOT NULL,
	RFloor TINYINT NOT NULL DEFAULT 0,  
    RNo INT NOT NULL,      
	RPricePerNight DECIMAL(10,2) NOT NULL CHECK (RPricePerNight >= 0) DEFAULT 100,
	RDescription NVARCHAR(MAX) DEFAULT '',

    RSID INT NOT NULL, 
	RTID INT NOT NULL, 
    CONSTRAINT PK_Rooms_RID PRIMARY KEY (RID),
    CONSTRAINT FK_Rooms_Rooms_Status FOREIGN KEY (RSID) REFERENCES Rooms_Status(RSID),
	CONSTRAINT FK_Rooms_Rooms_Type FOREIGN KEY (RTID) REFERENCES Rooms_Type(RTID)
)
GO


INSERT INTO Rooms VALUES (0,1,100,'',1,1)
INSERT INTO Rooms VALUES (0,2,100,'',2,2)
INSERT INTO Rooms VALUES (0,3,100,'',3,3)
INSERT INTO Rooms VALUES (0,4,100,'',4,4)
INSERT INTO Rooms VALUES (0,5,100,'',5,5)
INSERT INTO Rooms VALUES (0,6,100,'',6,6)
GO

SELECT RID,
	   RFloor,
	   RNo, 
	   RTType,
	   RTBedCount,
	   RTMaxGuests,
	   RSStatus,
	   RPricePerNight,
	   RDescription
FROM [HotelManagementSystem].[dbo].Rooms R
	 JOIN [HotelManagementSystem].[dbo].Rooms_Type RT ON R.RTID = RT.RTID
	 JOIN [HotelManagementSystem].[dbo].Rooms_Status RS ON R.RSID = RS.RSID;
GO

SELECT RID AS ID, 
	   RFloor AS N'Tầng', 
	   RNo AS N'Phòng', 
	   RTType AS N'Loại',
	   RTBedCount AS N'Số giường', 
	   RTMaxGuests AS N'Số người',
	   RSDescription AS N'Trạng thái',
	   RDescription AS N'Mô tả'
FROM [HotelManagementSystem].[dbo].Rooms R
	 JOIN [HotelManagementSystem].[dbo].Rooms_Type RT ON R.RTID = RT.RTID
	 JOIN [HotelManagementSystem].[dbo].Rooms_Status RS ON R.RSID = RS.RSID
WHERE RSStatus='Available'
GO

SELECT * FROM [HotelManagementSystem].[dbo].[Rooms]
GO



------------Table Customers------------

DROP TABLE IF EXISTS Customers;
GO

CREATE TABLE Customers (
    CID VARCHAR(100) PRIMARY KEY,   
    CName NVARCHAR(100) NOT NULL,        
    CGender CHAR(6) CHECK (CGender IN ('Male', 'Female', 'Other')) NOT NULL,  
    CPhone VARCHAR(15) UNIQUE NOT NULL,
    CEmail VARCHAR(100) UNIQUE ,
    CAddress NVARCHAR(255),         
    CType CHAR(7) CHECK (CType IN ('Regular', 'VIP', 'New')) NOT NULL
)
GO

INSERT INTO Customers (CID,CName, CGender, CPhone, CEmail, CAddress, CType)
VALUES 
('2254',N'Nguyễn Văn An', 'Male', '0987654321', 'an.nguyen@example.com', N'Hà Nội', 'Regular'),
('2255',N'Trần Thị Bình', 'Female', '0978123456', 'binh.tran@example.com', N'TP HCM', 'VIP'),
('2256',N'Lê Văn Cường', 'Male', '0968547321', 'cuong.le@example.com', N'Đà Nẵng', 'New'),
('2257',N'Phạm Thu Dung', 'Female', '0956347821', 'dung.pham@example.com', N'Cần Thơ', 'Regular'),
('2258',N'Hoàng Minh Đức', 'Other', '0945876231', 'duc.hoang@example.com', N'Hải Phòng', 'VIP')
GO

SELECT * FROM [HotelManagementSystem].[dbo].[Customers]
GO



--------------Table Employees_Role-----------------

DROP TABLE IF EXISTS Employees_Role
GO

CREATE TABLE Employees_Role (
    ERID INT IDENTITY(1,1) PRIMARY KEY,   
    ERDescription NVARCHAR(100) NOT NULL  
)
GO


INSERT INTO Employees_Role (ERDescription)
VALUES 
(N'Admin'),
(N'Manager'),
(N'Staff');
GO


-----------------Table Employees-------------------

DROP TABLE IF EXISTS Employees
GO

CREATE TABLE Employees (
    EID VARCHAR(100) PRIMARY KEY,   
    EName NVARCHAR(100) NOT NULL,         
    EGender CHAR(6) CHECK (EGender IN ('Male', 'Female', 'Other')) NOT NULL,  
    EPhone VARCHAR(15) UNIQUE NOT NULL,   
    EEmail VARCHAR(100) UNIQUE ,  
    EAddress NVARCHAR(255) ,          
    EStatus CHAR(10) CHECK (EStatus IN ('Active', 'Inactive', 'On Leave')) NOT NULL,  
    ERID INT NOT NULL,                    
    CONSTRAINT FK_Employees_Employees_Role FOREIGN KEY (ERID) REFERENCES Employees_Role(ERID)
)
GO


INSERT INTO Employees (EID,EName, EGender, EPhone, EEmail, EAddress, EStatus, ERID)
VALUES 
('1',N'Nguyễn Văn An', 'Male', '0987654321', 'an.nguyen@example.com', N'Hà Nội', 'Active', 1),
('2',N'Trần Thị Bình', 'Female', '0978123456', 'binh.tran@example.com', N'TP HCM', 'Active', 2),
('3',N'Lê Văn Cường', 'Male', '0968547321', 'cuong.le@example.com', N'Đà Nẵng', 'On Leave', 3),
('4',N'Phạm Thu Dung', 'Female', '0956347821', 'dung.pham@example.com', N'Cần Thơ', 'Active', 3),
('5',N'Hoàng Minh Đức', 'Other', '0945876231', 'duc.hoang@example.com', N'Hải Phòng', 'Inactive', 3);
GO

SELECT * FROM [HotelManagementSystem].[dbo].[Employees]
GO

SELECT [EID]
      ,[EName]
      ,[EGender]
      ,[EPhone]
      ,[EEmail]
      ,[EAddress]
      ,[EStatus]
      ,E_R.ERDescription AS 'Role'
FROM [HotelManagementSystem].[dbo].[Employees] E
	 JOIN [HotelManagementSystem].[dbo].[Employees_Role] E_R ON E.ERID=E_R.ERID
GO

-----------------Table Services-----

DROP TABLE IF EXISTS Services
GO

CREATE TABLE Services (
    SID INT PRIMARY KEY IDENTITY(1,1),
    SName NVARCHAR(255) UNIQUE NOT NULL,
    SPrice DECIMAL(10,2) NOT NULL CHECK (SPrice >= 0),
    SDescription NVARCHAR(MAX)
);
GO

SELECT * FROM Services
GO

---------------Table Bookings-----------------

DROP TABLE IF EXISTS Bookings
GO

CREATE TABLE Bookings (
    BID INT PRIMARY KEY IDENTITY(1,1),
    RID INT NOT NULL,                -- Mã phòng
    CID VARCHAR(100) NOT NULL,                -- Mã khách hàng
    BTimeCheckIn DATETIME NOT NULL,  -- Ngày giờ check-in
    BTimeCheckOut DATETIME NOT NULL, -- Ngày giờ check-out
    BStatus NVARCHAR(50) NOT NULL,   -- Trạng thái đặt phòng (VD: "Pending", "Confirmed", "Completed")
    BCreateAt DATETIME DEFAULT GETDATE(), -- Ngày tạo booking
    
    FOREIGN KEY (RID) REFERENCES Rooms(RID),
    FOREIGN KEY (CID) REFERENCES Customers(CID)
);
GO

SELECT * FROM Bookings
GO


-----------------Table ServiceUsage-----

DROP TABLE IF EXISTS ServiceUsage
GO

CREATE TABLE ServiceUsage (
    SUID INT PRIMARY KEY IDENTITY(1,1),
    BID INT NOT NULL, -- Mã đặt phòng
    EID VARCHAR(100) NOT NULL, -- Mã nhân viên thực hiện
    SUDate DATETIME NOT NULL DEFAULT GETDATE(), -- Ngày sử dụng dịch vụ

    FOREIGN KEY (BID) REFERENCES Bookings(BID),
    FOREIGN KEY (EID) REFERENCES Employees(EID)
);
GO


SELECT * FROM ServiceUsage
GO


-----------------Table ServiceUsageDetail-----

DROP TABLE IF EXISTS ServiceUsageDetail
GO


CREATE TABLE ServiceUsageDetail (
    SUID INT NOT NULL,
    SID INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL CHECK (UnitPrice > 0),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    Discount DECIMAL(5,2) DEFAULT 0 CHECK (Discount BETWEEN 0 AND 100),

    PRIMARY KEY (SUID, SID),
    FOREIGN KEY (SUID) REFERENCES ServiceUsage(SUID),
    FOREIGN KEY (SID) REFERENCES Services(SID)
);


SELECT * FROM ServiceUsage


---------------Table Payments-----------------

DROP TABLE IF EXISTS Payments
GO

SELECT * FROM ServiceUsageDetail
GO

-----------------Table Payments-----

DROP TABLE IF EXISTS Payments
GO

CREATE TABLE Payments (
    PID INT PRIMARY KEY IDENTITY(1,1),
    BID INT NOT NULL,
    SUID INT NULL,
    EID VARCHAR(100) NOT NULL,
    PAmount DECIMAL(10,2) NOT NULL CHECK (PAmount >= 0),
    PDateGTime DATETIME DEFAULT GETDATE(),
    PMethod VARCHAR(50) CHECK (PMethod IN ('Cash', 'Credit Card', 'Bank Transfer')),
    PStatus VARCHAR(50) CHECK (PStatus IN ('Pending', 'Completed', 'Failed')),

    FOREIGN KEY (BID) REFERENCES Bookings(BID),
    FOREIGN KEY (SUID) REFERENCES ServiceUsage(SUID),
    FOREIGN KEY (EID) REFERENCES Employees(EID),
);
GO


SELECT * FROM Payments
GO


-------ROLE STAFF----------

DROP ROLE IF EXISTS StaffRole
GO

CREATE ROLE StaffRole;
GO

GRANT SELECT ON [HotelManagementSystem].[dbo].Rooms_Status
TO StaffRole
GO

GRANT SELECT ON [HotelManagementSystem].[dbo].Rooms_Type
TO StaffRole
GO

GRANT SELECT ON [HotelManagementSystem].[dbo].Rooms
TO StaffRole
GO

GRANT SELECT ON [HotelManagementSystem].[dbo].Employees_Role
TO StaffRole
GO

GRANT SELECT ON [HotelManagementSystem].[dbo].Employees
TO StaffRole
GO

GRANT SELECT ON [HotelManagementSystem].[dbo].[Services]
TO StaffRole
GO



-- Nhân viên Tuan
CREATE LOGIN Tuan WITH PASSWORD = '123';
CREATE USER Tuan FOR LOGIN Tuan;
ALTER ROLE StaffRole ADD MEMBER Tuan;
GO


----
CREATE ROLE ManagerRole;
GO
-- 🔹 Quản lý 1 & 2
CREATE LOGIN Manager1 WITH PASSWORD = '123';
CREATE USER Manager1 FOR LOGIN Manager1;
ALTER ROLE ManagerRole ADD MEMBER Manager1;

