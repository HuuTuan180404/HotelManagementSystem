USE master
GO

CREATE DATABASE HotelManagementSystem
GO

USE HotelManagementSystem
GO

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

----------------------------------CREATE TABLE----------------------------

--Rooms_Status
CREATE TABLE Rooms_Status
(
    RSID INT IDENTITY(1,1) NOT NULL,
    RSStatus VARCHAR(100) NOT NULL UNIQUE,
    RSDescription NVARCHAR(MAX),
    CONSTRAINT PK_Rooms_Status_RSID PRIMARY KEY (RSID)
)
GO


--Rooms_Type
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


--Employees_Role
CREATE TABLE Employees_Role (
    ERID INT IDENTITY(1,1) PRIMARY KEY,   
    ERDescription NVARCHAR(100) NOT NULL  
)
GO


--Rooms
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


--Customers
CREATE TABLE Customers 
(
    CID VARCHAR(100) PRIMARY KEY,   
    CName NVARCHAR(100) NOT NULL,        
    CGender CHAR(6) CHECK (CGender IN ('Male', 'Female', 'Other')) NOT NULL,  
    CPhone VARCHAR(15) UNIQUE NOT NULL,
    CEmail VARCHAR(100) UNIQUE ,
    CAddress NVARCHAR(255),         
    CType CHAR(7) CHECK (CType IN ('Regular', 'VIP', 'New')) NOT NULL
)
GO


--Employees
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


CREATE TABLE Services (
    SID INT PRIMARY KEY IDENTITY(1,1),
    SName NVARCHAR(255) UNIQUE NOT NULL,
    SPrice DECIMAL(10,2) NOT NULL CHECK (SPrice >= 0),
    SDescription NVARCHAR(MAX)
);
GO

CREATE TABLE Bookings_Status
(
	BStatus VARCHAR(50) PRIMARY KEY,
	BKDescription NVARCHAR(MAX)
)
GO


CREATE TABLE Bookings (
    BID INT PRIMARY KEY IDENTITY(1,1),
    RID INT NOT NULL,                -- Mã phòng
    CID VARCHAR(100) NOT NULL,                -- Mã khách hàng
    BTimeCheckIn DATETIME NOT NULL,  -- Ngày giờ check-in
    BTimeCheckOut DATETIME, -- Ngày giờ check-out
    BStatus NVARCHAR(50) NOT NULL,   -- Trạng thái đặt phòng (VD: "Pending", "Confirmed", "Completed")
    BCreateAt DATETIME DEFAULT GETDATE(), -- Ngày tạo booking
    
    FOREIGN KEY (RID) REFERENCES Rooms(RID),
    FOREIGN KEY (CID) REFERENCES Customers(CID)
);
GO


CREATE TABLE ServiceUsage 
(
    SUID INT PRIMARY KEY IDENTITY(1,1),
    BID INT NOT NULL,  -- Mã đặt phòng
    RID INT NOT NULL,  -- Mã phòng sử dụng dịch vụ (Thêm mới)
    EID VARCHAR(100) NOT NULL,  -- Mã nhân viên thực hiện
    SUDate DATETIME NOT NULL DEFAULT GETDATE(),  -- Ngày sử dụng dịch vụ
    
    FOREIGN KEY (BID) REFERENCES Bookings(BID),
    FOREIGN KEY (RID) REFERENCES Rooms(RID),  -- Ràng buộc mới
    FOREIGN KEY (EID) REFERENCES Employees(EID)
);
GO


CREATE TABLE ServiceUsageDetail 
(
    SUID INT NOT NULL,
    SID INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL CHECK (UnitPrice > 0),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    Discount DECIMAL(5,2) DEFAULT 0 CHECK (Discount BETWEEN 0 AND 100),

    PRIMARY KEY (SUID, SID),
    FOREIGN KEY (SUID) REFERENCES ServiceUsage(SUID),
    FOREIGN KEY (SID) REFERENCES Services(SID)
);
GO


CREATE TABLE Payment_Method
(
	PMMethod VARCHAR(50) PRIMARY KEY,
	Description NVARCHAR(50)
)
GO

CREATE TABLE Payment_Status
(
    PSStatus VARCHAR(50) PRIMARY KEY,
    Description NVARCHAR(100)
)
GO


CREATE TABLE Payments_Booking 
(
    PBID INT PRIMARY KEY IDENTITY(1,1),
    BID INT NOT NULL,
    EID VARCHAR(100) NOT NULL,
    PBAmount DECIMAL(10,2) NOT NULL CHECK (PBAmount >= 0),
    PBDate DATETIME DEFAULT GETDATE(),
    PMMethod VARCHAR(50),
    PSStatus VARCHAR(50),
    
    FOREIGN KEY (BID) REFERENCES Bookings(BID),
    FOREIGN KEY (EID) REFERENCES Employees(EID),
	FOREIGN KEY (PMMethod) REFERENCES Payment_Method(PMMethod),
	FOREIGN KEY (PSStatus) REFERENCES Payment_Status(PSStatus)
);
GO


CREATE TABLE Payments_Service (
    PSID INT PRIMARY KEY,
    SUID INT NOT NULL,
    EID VARCHAR(100) NOT NULL,
    PSAmount DECIMAL(10,2) NOT NULL CHECK (PSAmount >= 0),
    PSDate DATETIME DEFAULT GETDATE(),
    PMMethod VARCHAR(50),
    PSStatus VARCHAR(50),
    
	FOREIGN KEY (PSID) REFERENCES Payments_Booking(PBID),
    FOREIGN KEY (SUID) REFERENCES ServiceUsage(SUID),
    FOREIGN KEY (EID) REFERENCES Employees(EID),
	FOREIGN KEY (PMMethod) REFERENCES Payment_Method(PMMethod),
	FOREIGN KEY (PSStatus) REFERENCES Payment_Status(PSStatus)
);
GO

-----------------TRIGGER-------------------------------

CREATE TRIGGER whenBooking
ON Bookings
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Payments_Booking (BID, EID,PBAmount) SELECT MAX(BID), 2004,100 FROM Bookings;
END;
GO

/*CREATE TRIGGER whenBookingService
ON Bookings
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Payments_Service (BID, EID) SELECT MAX(BID), 1 FROM Bookings;
END;
GO
*/

---------------------------------------INSERT INTO----------------------------

SET NOCOUNT ON;
GO

INSERT INTO Payment_Status (PSStatus, Description) 
VALUES ('Completed', N'Thanh toán đã hoàn tất'),
	   ('Failed', N'Thanh toán không thành công'),
	   ('Refunded', N'Đã hoàn tiền'),
	   ('Canceled', N'Thanh toán đã bị hủy'),
	   ('Overdue', N'Thanh toán quá hạn')
GO
	   


INSERT INTO Bookings_Status (BStatus, BKDescription) 
VALUES ('Confirmed', N'Đặt phòng đã được xác nhận và sẵn sàng cho khách.'),
	   ('Checked-in', N'Khách hàng đã đến nhận phòng.'),
	   ('Checked-out', N'Khách hàng đã trả phòng và rời đi.'),
	   ('No-Show', N'Khách hàng không đến nhận phòng như đã đặt.'),
	   ('Canceled', N'Đặt phòng đã bị hủy bởi khách hàng hoặc khách sạn.')
GO

INSERT INTO Payment_Method (PMMethod, Description) 
VALUES ('Cash', N'Tiền mặt'), ('Credit Card', N'Thẻ tín dụng'),
	   ('Debit Card', N'Thẻ ghi nợ'), ('Bank Transfer', N'Chuyển khoản ngân hàng'),
	   ('E-Wallet', N'Ví điện tử'), ('QR Code', N'Thanh toán mã QR'),
	   ('PayPal', N'Thanh toán qua PayPal'), ('Crypto', N'Thanh toán bằng tiền điện tử');
GO


INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Available',N'Phòng trống')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Reserved',N'Đã nhận phòng')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Occupied',N'Đã đặt')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Dirty',N'Cần vệ sinh')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Cleaning',N'Đang vệ sinh')
INSERT INTO Rooms_Status (RSStatus,RSDescription) VALUES ('Maintenance',N'Đang bảo trì')
GO


INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests) VALUES ('Single',1,1)
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests) VALUES ('Double',1,2)
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests,RTDescription) VALUES ('Triple_2',2,3,N'3 giường đơn')
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests,RTDescription) VALUES ('Triple_3',1,3,N'1 giường đôi + 1 giường đơn')
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests) VALUES ('Twin',2,2)
INSERT INTO Rooms_Type (RTType,RTBedCount,RTMaxGuests,RTDescription) VALUES ('Family',2,4,N'1 giường đôi + 2 giường đơn')
GO

INSERT INTO Services (SName, SPrice, SDescription)
VALUES (N'Giặt ủi', 50.00, N'Dịch vụ giặt ủi quần áo cho khách.'),
    (N'Đưa đón sân bay', 200.00, N'Dịch vụ xe đưa đón khách từ/đến sân bay.'),
    (N'Ăn sáng buffet', 150.00, N'Bữa sáng buffet với nhiều món ăn phong phú.'),
    (N'Spa & Massage', 300.00, N'Thư giãn với dịch vụ spa và massage chuyên nghiệp.'),
    (N'Thuê xe', 500.00, N'Dịch vụ cho thuê xe máy và ô tô.');
GO	


INSERT INTO Employees_Role (ERDescription)
VALUES (N'Admin'), (N'Manager'), (N'Staff');
GO

/*
INSERT INTO Customers VALUES ('2025','Tuan','Male','0364626275',NULL,NULL,'New')
GO

INSERT INTO Employees 
VALUES ('2004','Staff','Male','0364626275',NULL,NULL,'Active','1')
GO


INSERT INTO Bookings (RID,CID, BTimeCheckIn,BTimeCheckOut,BStatus,BCreateAt)
VALUES (1,'2025',GETDATE(),NULL,'Pending',GETDATE());
GO

----------------------------------------

select * from Bookings
*/