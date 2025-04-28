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
('Pending',        N'Đang chờ xác nhận'),
('Confirmed',      N'Đã được xác nhận'),
('CheckedIn',      N'Khách đã nhận phòng'),
('CheckedOut',     N'Khách đã trả phòng'),
('Cancelled',      N'Đã huỷ'),
('NoShow',         N'Khách không đến'),
('Refunded',       N'Đã hoàn tiền'),
('InProgress',     N'Đang lưu trú'),
('Rejected',       N'Bị từ chối');
GO

INSERT INTO Employees (EId, Name, Gender, Phone, Email, Address, Status, ERole)
VALUES 
('E001', N'Nguyễn Văn A', 'Male', '0911111111', 'nguyenvana@example.com', N'123 Lê Lợi, Q1, TP.HCM', 'Active', 'Manager'),
('E002', N'Trần Thị B', 'Female', '0922222222', 'tranthib@example.com', N'456 Nguyễn Trãi, Q5, TP.HCM', 'On Leave', 'Receptionist'),
('E003', N'Lê Văn C', 'Male', '0933333333', 'levanc@example.com', N'789 Hai Bà Trưng, Q3, TP.HCM', 'Active', 'Housekeeping'),
('E004', N'Phạm Thị D', 'Female', '0944444444', 'phamthid@example.com', N'321 Cách Mạng Tháng 8, Q10', 'Inactive', 'Housekeeping'),
('E005', N'Hoàng Văn E', 'Male', '0955555555', 'hoangvane@example.com', N'12 Nguyễn Huệ, Q1', 'Active', 'Receptionist'),
('E006', N'Đỗ Thị F', 'Female', '0966666666', 'dothif@example.com', N'34 Trần Hưng Đạo, Q1', 'Active', 'Manager'),
('E007', N'Ngô Văn G', 'Male', '0977777777', 'ngovang@example.com', N'56 Lý Thường Kiệt, Q5', 'On Leave', 'Housekeeping'),
('E008', N'Võ Thị H', 'Female', '0988888888', 'vothih@example.com', N'78 Phạm Ngũ Lão, Q1', 'Active', 'Receptionist'),
('E009', N'Trịnh Văn I', 'Male', '0999999999', 'trinhvani@example.com', N'90 Trường Chinh, Tân Bình', 'Inactive', 'Manager'),
('E010', N'Bùi Thị J', 'Other', '0900000000', 'buithij@example.com', N'11 Hùng Vương, Q6', 'Active', 'Receptionist');
GO

INSERT INTO EmployeeRole (ERole, Description)
VALUES 
('Manager', N'Quản lý chung của cửa hàng'),
('Receptionist', N'Lễ tân, tiếp nhận khách'),
('Housekeeping', N'Nhân viên dọn phòng');
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