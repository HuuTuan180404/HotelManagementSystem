USE master
GO

CREATE DATABASE HotelManagementSystem
GO

USE HotelManagementSystem
GO

-- 1. RStatus
CREATE TABLE RStatus
(
    RStatus_ VARCHAR(100) PRIMARY KEY,
    Description NVARCHAR(MAX)
)
GO

-- 2. RType
CREATE TABLE RType
(
    RType_ VARCHAR(100) PRIMARY KEY,
    BedCount TINYINT NOT NULL DEFAULT 1,
    MaxGuests TINYINT NOT NULL DEFAULT 1,
    Description NVARCHAR(MAX)
)
GO

-- 3. Rooms
CREATE TABLE Rooms
(
    RId VARCHAR(50) PRIMARY KEY,
    Type VARCHAR(100) NOT NULL,
    Status VARCHAR(100) NOT NULL,
    PricePerNight DECIMAL(10,2) NOT NULL CHECK (PricePerNight >= 0) DEFAULT 100,
    Description NVARCHAR(MAX),
    FOREIGN KEY (Type) REFERENCES RType(RType_),
    FOREIGN KEY (Status) REFERENCES RStatus(RStatus_)
)
GO

-- 4. Customers
CREATE TABLE Customers
(
    CId VARCHAR(100) PRIMARY KEY,   
    Name NVARCHAR(100) NOT NULL,        
    Gender VARCHAR(10) CHECK (Gender IN ('Male', 'Female', 'Other')),  
    Phone VARCHAR(15) UNIQUE NOT NULL,
    Email VARCHAR(100),
    Address NVARCHAR(255),         
    Type VARCHAR(20) CHECK (Type IN ('Regular', 'VIP', 'New')) DEFAULT 'New'
)
GO

-- 5. EmployeeRole
CREATE TABLE EmployeeRole (
    ERole VARCHAR(100) PRIMARY KEY,   
    Description NVARCHAR(100)
)
GO

-- 6. Employees
CREATE TABLE Employees 
(
    EId VARCHAR(100) PRIMARY KEY,   
    Name NVARCHAR(100) NOT NULL,         
    Gender VARCHAR(10) CHECK (Gender IN ('Male', 'Female', 'Other')) NOT NULL,  
    Phone VARCHAR(15) UNIQUE NOT NULL,   
    Email VARCHAR(100) UNIQUE,  
    Address NVARCHAR(255),          
    Status VARCHAR(15) CHECK (Status IN ('Active', 'Inactive', 'On Leave')) NOT NULL,  
    ERole VARCHAR(100),
	FOREIGN KEY (ERole) REFERENCES EmployeeRole(ERole),
	Password VARCHAR(255) NOT NULL,  -- Added field for password
    Avatar VARCHAR(255)           -- Added field for avatar (e.g., file path or URL)
)
GO


-- 8. BookingStatus
CREATE TABLE BookingStatus
(
    BStatus VARCHAR(100) PRIMARY KEY,
    BKDescription NVARCHAR(MAX)
)
GO


-- 11. Bookings
CREATE TABLE Bookings 
(
    BId VARCHAR(100) PRIMARY KEY,
    RId VARCHAR(50) NOT NULL,
    CId VARCHAR(100) NOT NULL,
    BTimeCheckIn DATETIME NOT NULL,
    BTimeCheckOut DATETIME NOT NULL,
    BStatus VARCHAR(100) NOT NULL,
    BCreateAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (RId) REFERENCES Rooms(RId),
    FOREIGN KEY (CId) REFERENCES Customers(CId),
    FOREIGN KEY (BStatus) REFERENCES BookingStatus(BStatus)
)
GO

-- 7. Services
CREATE TABLE Services
(
    SName VARCHAR(100) PRIMARY KEY,
    SPrice DECIMAL(10,2) NOT NULL CHECK (SPrice >= 0),
    SDescription NVARCHAR(MAX)
)
GO

-- 12. ServiceUsage
CREATE TABLE ServiceUsage 
(
    SUId VARCHAR(100) PRIMARY KEY,
    SUDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (SUId) REFERENCES Bookings(BId),
)
GO

-- 13. ServiceUsageDetail
CREATE TABLE ServiceUsageDetail 
(
    SUId VARCHAR(100) NOT NULL,
    SName VARCHAR(100) NOT NULL,
    EId VARCHAR(100) NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
	CreateAt DATETIME NOT NULL,
    PRIMARY KEY (SUId, SName, CreateAt),
    FOREIGN KEY (SUId) REFERENCES ServiceUsage(SUId),
    FOREIGN KEY (SName) REFERENCES Services(SName),
    FOREIGN KEY (EId) REFERENCES Employees(EId)
)
GO


-- 9. PaymentMethod
CREATE TABLE PaymentMethod
(
    PMethod VARCHAR(100) PRIMARY KEY,
    Description NVARCHAR(MAX)
)
GO

CREATE TABLE Payments
(
    BPId VARCHAR(100) PRIMARY KEY,
    BId VARCHAR(100) NOT NULL,
    EId VARCHAR(100) NOT NULL,
    Amount DECIMAL(10,2) NOT NULL CHECK (Amount >= 0),
    Date DATETIME DEFAULT GETDATE(),
    PMethod VARCHAR(100) NOT NULL,
    FOREIGN KEY (BId) REFERENCES Bookings(BId),
    FOREIGN KEY (EId) REFERENCES Employees(EId),
    FOREIGN KEY (PMethod) REFERENCES PaymentMethod(PMethod)
)
GO

CREATE TABLE Booking_Online
(
	CreateAt DATETIME PRIMARY KEY,
	CCCD VARCHAR(100),
	HoTen NVARCHAR(100),
	SoDienThoai VARCHAR(15),
	TGianNhanPhong DATETIME,
	TGianTraPhong DATETIME,
	LoaiPhong VARCHAR(100) FOREIGN KEY REFERENCES RType(RType_)
)
GO

-- data demo
USE HotelManagementSystem
GO

SET NOCOUNT ON;
GO

INSERT INTO RStatus VALUES
('Available', N'Phòng trống, sẵn sàng đón khách'),
('Occupied', N'Phòng đang có khách'),
('Reserved', N'Phòng đã được đặt trước'),
('Maintenance', N'Phòng đang bảo trì'),
('Cleaning', N'Phòng đang được dọn dẹp');
GO

INSERT INTO RType VALUES
('Standard', 1, 2, N'Phòng tiêu chuẩn với 1 giường đôi'),
('Deluxe', 2, 4, N'Phòng cao cấp với 2 giường đôi'),
('Suite', 1, 2, N'Phòng hạng sang với nội thất cao cấp'),
('Family', 2, 6, N'Phòng gia đình rộng rãi với 2 giường lớn'),
('VIP', 1, 2, N'Phòng VIP với dịch vụ đặc biệt');
GO

INSERT INTO Rooms (RId, PricePerNight, Description, Status, Type) VALUES
('Roo1-1', 100.00, N'Phòng tiêu chuẩn tầng 1', 'Available','Standard' ),
('Roo1-2', 150.00, N'Phòng Deluxe tầng 1', 'Reserved', 'Deluxe'),
('Roo2-1', 200.00, N'Phòng Suite tầng 2', 'Occupied', 'Suite'),
('Roo2-2', 180.00, N'Phòng Family tầng 2', 'Available', 'Family'),
('Roo3-1', 300.00, N'Phòng VIP tầng 3', 'Cleaning', 'VIP'),
('Roo3-2', 250.00, N'Phòng Deluxe tầng 3', 'Maintenance', 'Deluxe');
GO

INSERT INTO BookingStatus (BStatus, BKDescription) VALUES
('Confirmed',      N'Đã được xác nhận'),
('CheckedIn',      N'Khách đã nhận phòng'),
('CheckedOut',     N'Khách đã trả phòng'),
('Cancelled',      N'Đã huỷ'),
('NoShow',         N'Khách không đến')
GO

INSERT INTO EmployeeRole (ERole, Description)
VALUES 
('Manager', N'Quản lý chung của cửa hàng'),
('Receptionist', N'Lễ tân, tiếp nhận khách'),
('Housekeeping', N'Nhân viên dọn phòng');
GO

INSERT [dbo].[Employees] ([EId], [Name], [Gender], [Phone], [Email], [Address], [Status], [ERole], [Password], [Avatar]) 
VALUES (N'admin', N'admin', N'Male', N'0123456789', N'a@example.com', N'Việt Nam', N'Active', N'Manager', N'IBvOJFjwClQTDGlcqNFlgxmzIgbUla3xdYR7V71KQVE=', NULL)
GO

INSERT INTO Services (SName, SPrice, SDescription) VALUES
('Laundry', 50000, N'Dịch vụ giặt ủi, giao trong ngày'),
('Airport Transfer', 250000, N'Dịch vụ đưa đón sân bay'),
('Buffet Breakfast', 150000, N'Bữa sáng buffet tại nhà hàng tầng trệt, từ 6h sáng đến 10h sáng'),
('Spa Relaxation', 300000, N'Liệu trình massage toàn thân 60 phút với tinh dầu cao cấp'),
('Motorbike Rental', 120000, N'Cho thuê xe máy theo ngày, bao gồm 1 lít xăng'),
('Room Service', 0, N'Dịch vụ ăn uống phục vụ tận phòng'),
('Extra Cleaning', 30000, N'Dịch vụ dọn phòng ngoài lịch trình thường lệ'),
('Sauna', 100000, N'Phòng xông hơi nam/nữ riêng biệt'),
('Mini Bar', 0, N'Tính phí theo từng món sử dụng từ minibar trong phòng'),
('Document Printing', 5000, N'Dịch vụ in ấn tài liệu đen trắng, tính phí theo trang');
GO

INSERT INTO PaymentMethod (PMethod, Description)
VALUES 
('Cash', N'Thanh toán bằng tiền mặt'),
('BankTransfer', N'Chuyển khoản ngân hàng')
GO


-- một số thử tục để chạy job

-- cập nhật trạng thái từ "dọn vệ sinh" sang "phòng sẵn sàng" 10p sẽ chạy 1 lần
CREATE PROCEDURE UpdateCleaningRoomsToAvailable
AS
BEGIN
    UPDATE Rooms
    SET Status = 'Available'
    WHERE Status = 'Cleaning'
END
GO


-- không đến nhận phòng
CREATE PROCEDURE KhongNhanPhong
AS
BEGIN
    UPDATE Bookings
	SET BStatus = 'NoShow'
	WHERE BStatus = 'Confirmed' AND BTimeCheckOut <= GETDATE(); 
END
GO


-- quá giờ checkout => Expired[CoffeeShop]
CREATE PROCEDURE QuaThoiGianCheckout
AS
BEGIN
    UPDATE Bookings
	SET BStatus = 'Expired'
	WHERE BStatus = 'CheckedIn' AND BTimeCheckOut <= GETDATE(); 
END
GO
