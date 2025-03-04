USE HotelManagementSystem
GO

SET NOCOUNT ON;
GO

INSERT INTO Room_Status (RStatus, RSDescription) VALUES
('Available', N'Phòng trống, sẵn sàng đón khách'),
('Occupied', N'Phòng đang có khách'),
('Reserved', N'Phòng đã được đặt trước'),
('Maintenance', N'Phòng đang bảo trì'),
('Cleaning', N'Phòng đang được dọn dẹp');
GO


INSERT INTO Room_Type (RType, RTBedCount, RTMaxGuests, RTDescription) VALUES
('Standard', 1, 2, N'Phòng tiêu chuẩn với 1 giường đôi'),
('Deluxe', 2, 4, N'Phòng cao cấp với 2 giường đôi'),
('Suite', 1, 2, N'Phòng hạng sang với nội thất cao cấp'),
('Family', 2, 6, N'Phòng gia đình rộng rãi với 2 giường lớn'),
('VIP', 1, 2, N'Phòng VIP với dịch vụ đặc biệt');
GO


INSERT INTO Rooms (RFloor, RNo, RPricePerNight, RDescription, RStatus, RType) VALUES
(1, 1, 100.00, N'Phòng tiêu chuẩn tầng 1', 'Available','Standard' ),
(1, 2, 150.00, N'Phòng Deluxe tầng 1', 'Reserved', 'Deluxe'),
(2, 1, 200.00, N'Phòng Suite tầng 2', 'Occupied', 'Suite'),
(2, 2, 180.00, N'Phòng Family tầng 2', 'Available', 'Family'),
(3, 1, 300.00, N'Phòng VIP tầng 3', 'Cleaning', 'VIP'),
(3, 2, 250.00, N'Phòng Deluxe tầng 3', 'Maintenance', 'Deluxe');
GO

SELECT * FROM Rooms


INSERT INTO Customers (CID, CName, CGender, CPhone, CEmail, CAddress, CType) VALUES
('CUST001', N'Nguyễn Văn A', 'Male', '0987654321', 'nguyenvana@gmail.com', N'123 Đường ABC, Hà Nội', 'Regular'),
('CUST002', N'Trần Thị B', 'Female', '0978123456', 'tranthib@example.com', N'456 Đường XYZ, TP Hồ Chí Minh', 'VIP'),
('CUST003', N'Phạm Văn C', 'Male', '0909123456', 'phamvanc@example.com', N'789 Đường DEF, Đà Nẵng', 'New'),
('CUST004', N'Lê Thị D', 'Female', '0912345678', 'lethid@example.com', N'101 Đường MNO, Cần Thơ', 'Regular'),
('CUST005', N'Hoàng Minh E', 'Other', '0922334455', 'hoangminhe@example.com', N'202 Đường PQR, Hải Phòng', 'VIP'),
('CUST006', N'Đặng Văn F', 'Male', '0933445566', 'dangvanf@example.com', N'303 Đường STU, Nha Trang', 'New'),
('CUST007', N'Bùi Thị G', 'Female', '0944556677', 'buithig@example.com', N'404 Đường VWX, Huế', 'Regular'),
('CUST008', N'Ngô Minh H', 'Male', '0955667788', 'ngominhh@example.com', N'505 Đường YZ, Bình Dương', 'VIP'),
('CUST009', N'Vũ Văn I', 'Male', '0966778899', 'vuvani@example.com', N'606 Đường QWE, Đồng Nai', 'New'),
('CUST010', N'Đỗ Thị J', 'Female', '0977889900', 'dothij@example.com', N'707 Đường RTY, Vũng Tàu', 'Regular');
GO


INSERT INTO Employee_Role (ERole, ERDescription) VALUES
('Admin', N'Quản trị hệ thống, có quyền cao nhất'),
('Manager', N'Quản lý khách sạn, có quyền quản lý nhân viên và đặt phòng'),
('Receptionist', N'Nhân viên lễ tân, xử lý check-in và check-out'),
('Housekeeping', N'Nhân viên dọn phòng, đảm bảo vệ sinh phòng khách'),
('Security', N'Nhân viên bảo vệ, đảm bảo an ninh trong khách sạn'),
('Accountant', N'Nhân viên kế toán, quản lý tài chính và thanh toán');
GO


INSERT INTO Employees (EID, EName, EGender, EPhone, EEmail, EAddress, EStatus, ERole) VALUES
('E001', N'Nguyễn Văn A', 'Male', '0987654321', 'nva@example.com', N'123 Đường ABC, Hà Nội', 'Active', 'Admin'),
('E002', N'Trần Thị B', 'Female', '0978123456', 'ttb@example.com', N'456 Đường XYZ, TP. HCM', 'Active', 'Manager'),
('E003', N'Lê Văn C', 'Male', '0968543210', 'lvc@example.com', N'789 Đường DEF, Đà Nẵng', 'On Leave', 'Receptionist'),
('E004', N'Phạm Hồng D', 'Female', '0912345678', 'phd@example.com', N'321 Đường GHI, Cần Thơ', 'Inactive', 'Housekeeping'),
('E005', N'Hoàng Minh E', 'Male', '0909876543', 'hme@example.com', N'654 Đường JKL, Hải Phòng', 'Active', 'Security'),
('E006', N'Vũ Thanh F', 'Other', '0923456789', 'vtf@example.com', N'987 Đường MNO, Nha Trang', 'Active', 'Accountant');
GO


INSERT INTO Services (SName, SPrice, SDescription) VALUES
('Room Cleaning', 10.00, N'Dịch vụ dọn phòng hàng ngày'),
('Laundry', 15.50, N'Dịch vụ giặt ủi quần áo'),
('Breakfast', 5.00, N'Bữa sáng tự chọn với nhiều món ăn ngon'),
('Airport Pickup', 25.00, N'Dịch vụ đưa đón sân bay'),
('Spa', 50.00, N'Liệu pháp spa thư giãn và massage chuyên nghiệp'),
('Gym Access', 7.00, N'Truy cập phòng tập thể dục 24/7'),
('Minibar', 12.00, N'Dịch vụ minibar trong phòng'),
('Car Rental', 40.00, N'Thuê xe du lịch với tài xế'),
('Swimming Pool', 8.00, N'Truy cập hồ bơi trong khách sạn'),
('City Tour', 60.00, N'Tour tham quan thành phố với hướng dẫn viên');
GO


INSERT INTO Booking_Status (BStatus, BKDescription) VALUES
('Pending', N'Đang chờ xác nhận, khách chưa nhận phòng.'),
('Confirmed', N'Đặt phòng đã được xác nhận, khách sắp nhận phòng.'),
('Checked-in', N'Khách đã nhận phòng và đang lưu trú.'),
('Checked-out', N'Khách đã trả phòng, hoàn tất đặt chỗ.'),
('Cancelled', N'Đặt phòng đã bị hủy bởi khách hoặc hệ thống.'),
('No-show', N'Khách không đến nhận phòng theo lịch đặt.');
GO


INSERT INTO Payment_Method (PMethod, Description) VALUES
('Cash', N'Thanh toán bằng tiền mặt'),
('Credit Card', N'Thanh toán bằng thẻ tín dụng'),
('Debit Card', N'Thanh toán bằng thẻ ghi nợ'),
('Bank Transfer', N'Thanh toán chuyển khoản ngân hàng'),
('E-Wallet', N'Thanh toán qua ví điện tử'),
('Crypto', N'Thanh toán bằng tiền điện tử');
GO


INSERT INTO Payment_Status (PStatus, Description) VALUES
('Pending', N'Chờ thanh toán'),
('Completed', N'Thanh toán thành công'),
('Failed', N'Thanh toán thất bại'),
('Refunded', N'Đã hoàn tiền'),
('Cancelled', N'Thanh toán bị hủy');
GO

--INSERT INTO Booking - Booking_Payments - ServiceUsage
EXEC When_INSERT_INTO_Bookings 'B001', 1, 'CUST001', 'E001', '2025-03-10 14:00:00', '2025-03-12 12:00:00', 'Confirmed'
EXEC When_INSERT_INTO_Bookings 'B002', 2, 'CUST002', 'E002', '2025-03-11 15:00:00', '2025-03-14 11:00:00', 'Pending'
EXEC When_INSERT_INTO_Bookings 'B003', 3, 'CUST003', 'E003', '2025-03-01 13:00:00', '2025-03-18 10:00:00', 'Checked-in'
EXEC When_INSERT_INTO_Bookings 'B004', 4, 'CUST004', 'E004', '2025-03-16 16:00:00', '2025-03-20 12:00:00', 'Checked-in'
EXEC When_INSERT_INTO_Bookings 'B005', 5, 'CUST005', 'E005', '2025-03-20 14:00:00', '2025-03-25 11:00:00', 'Confirmed'
GO


SELECT * from Booking_Payments

------------------------------------------------



