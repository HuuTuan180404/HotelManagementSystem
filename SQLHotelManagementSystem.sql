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
    Email VARCHAR(100) UNIQUE,
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
    ERole VARCHAR(100) NOT NULL,
    FOREIGN KEY (ERole) REFERENCES EmployeeRole(ERole)                 
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

-- 8. BookingStatus
CREATE TABLE BookingStatus
(
    BStatus VARCHAR(100) PRIMARY KEY,
    BKDescription NVARCHAR(MAX)
)
GO

-- 9. PaymentMethod
CREATE TABLE PaymentMethod
(
    PMethod VARCHAR(100) PRIMARY KEY,
    Description NVARCHAR(MAX)
)
GO

-- 10. PaymentStatus
CREATE TABLE PaymentStatus
(
    PStatus VARCHAR(100) PRIMARY KEY,
    Description NVARCHAR(MAX)
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
    PRIMARY KEY (SUId, SName,CreateAt),
    FOREIGN KEY (SUId) REFERENCES ServiceUsage(SUId),
    FOREIGN KEY (SName) REFERENCES Services(SName),
    FOREIGN KEY (EId) REFERENCES Employees(EId)
)
GO

-- 14. BookingPayments
CREATE TABLE BookingPayments
(
    BPId VARCHAR(100) PRIMARY KEY,
    BId VARCHAR(100) NOT NULL,
    EId VARCHAR(100) NOT NULL,
    Amount DECIMAL(10,2) NOT NULL CHECK (Amount >= 0),
    Date DATETIME DEFAULT GETDATE(),
    PMethod VARCHAR(100) NOT NULL,
    PStatus VARCHAR(100) NOT NULL,
    FOREIGN KEY (BId) REFERENCES Bookings(BId),
    FOREIGN KEY (EId) REFERENCES Employees(EId),
    FOREIGN KEY (PMethod) REFERENCES PaymentMethod(PMethod),
    FOREIGN KEY (PStatus) REFERENCES PaymentStatus(PStatus)
)
GO
