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