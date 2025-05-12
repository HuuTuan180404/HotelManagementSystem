using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Booking_OnlineDTO
    {
        public DateTime CreateAt { get; set; }
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime TGianNhanPhong { get; set; }
        public DateTime TGianTraPhong { get; set; }
        public string LoaiPhong { get; set; }

        public override string ToString()
        {
            return $"[Booking] {HoTen} | CCCD: {CCCD} | SĐT: {SoDienThoai} | Loại phòng: {LoaiPhong} | Nhận: {TGianNhanPhong:dd/MM/yyyy HH:mm} | Trả: {TGianTraPhong:dd/MM/yyyy HH:mm} | Tạo lúc: {CreateAt:dd/MM/yyyy HH:mm}";
        }

    }
}
