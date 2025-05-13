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

INSERT INTO Employees (EId, Name, Gender, Phone, Email, Address, Status, ERole, Password, Avatar)
VALUES 
    ('E001', N'Nguyen Van A', 'Male', '0901234567', 'nguyenvana@example.com', N'123 Đường Láng, Hà Nội', 'Active', 'Manager', '123456789Vy@', ''),
    ('E002', N'Tran Thi B', 'Female', '0912345678', 'tranthib@example.com', N'456 Cầu Giấy, Hà Nội', 'On Leave', 'Receptionist', '123456789Vy@', '');
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
('CreditCard', N'Thanh toán bằng thẻ tín dụng'),
('DebitCard', N'Thanh toán bằng thẻ ghi nợ'),
('BankTransfer', N'Chuyển khoản ngân hàng'),
('EWallet', N'Thanh toán bằng ví điện tử'),
('QRCode', N'Thanh toán bằng mã QR'),
('Voucher', N'Thanh toán bằng phiếu giảm giá'),
('PayLater', N'Thanh toán sau');
GO