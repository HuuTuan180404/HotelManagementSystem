USE master
GO

CREATE DATABASE HotelManagementSystem
GO

USE HotelManagementSystem
GO

----------------------------

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
//
-------------------


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



------------------


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

----------------------

/*
DROP TABLE IF EXISTS Customers
GO

CREATE TABLE Customers
(
    CID INT IDENTITY(1,1) NOT NULL,
    CFullName NVARCHAR(MAX) NOT NULL,
	CPhone VARCHAR(20) UNIQUE,
	CBirthDate DATE,
	CSex VARCHAR(10) CHECK (CSex IN ('Male', 'Female', 'Other')) DEFAULT 'Other',
    CONSTRAINT PK_Customers_CID PRIMARY KEY (CID)
)
GO

INSERT INTO Customers VALUES (N'Nguyễn Hữu Tuấn','0364626275','20040418','Male')
GO

SELECT CID, 
	   CFullName AS 'Họ và Tên',
	   CSex AS 'Giới Tính', 
	   CPhone AS 'SĐT', 
	   CBirthDate AS 'Ngày sinh'
FROM Customers
GO


--------------------
CREATE TABLE Bookings
(
    BID INT IDENTITY(1,1) NOT NULL,
    
    CONSTRAINT PK_Bookings_BID PRIMARY KEY (BID),
    
)
GO



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

