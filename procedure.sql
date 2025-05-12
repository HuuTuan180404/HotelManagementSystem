-- cập nhật trạng thái từ "dọn vệ sinh" sang "phòng sẵn sàng" 10p sẽ chạy 1 lần
CREATE PROCEDURE UpdateCleaningRoomsToAvailable
AS
BEGIN
    UPDATE Rooms
    SET Status = 'Available'
    WHERE Status = 'Cleaning'
END


-- không đến nhận phòng
CREATE PROCEDURE KhongNhanPhong
AS
BEGIN
    UPDATE Bookings
	SET BStatus = 'NoShow'
	WHERE BStatus = 'Confirmed' AND BTimeCheckOut <= GETDATE(); 
END



-- quá giờ checkout => Expired
CREATE PROCEDURE QuaThoiGianCheckout
AS
BEGIN
    UPDATE Bookings
	SET BStatus = 'Expired'
	WHERE BStatus = 'CheckedIn' AND BTimeCheckOut <= GETDATE(); 
END