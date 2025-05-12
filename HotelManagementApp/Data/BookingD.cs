using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BookingD
    {
        HotelManagementSystemContext DB;
        public BookingD()
        {
            try
            {
                DB = new HotelManagementSystemContext();
            }
            catch (SqlException ex) { throw ex; }
        }

        public List<BookingDTO> GetAllBookings()
        {
            var bookings = DB.Bookings
                .Select(r => new BookingDTO
                {
                    BId = r.BId,
                    RId = r.RId,
                    CId = r.CId,
                    BTimeCheckIn = r.BTimeCheckIn,
                    BTimeCheckOut = r.BTimeCheckOut,
                    BStatus = r.BStatus,
                    BCreateAt = r.BCreateAt.HasValue ? r.BCreateAt.Value : DateTime.Now
                })
                .ToList();
            return bookings;
        }

        public List<Booking_OnlineDTO> GetAllBookingOnline()
        {
            var bookings = DB.Booking_Online.ToList();
            List<Booking_OnlineDTO> list = new List<Booking_OnlineDTO>();
            foreach (var booking in bookings)
            {
                list.Add(new Booking_OnlineDTO
                {
                    CreateAt = booking.CreateAt,
                    CCCD = booking.CCCD,
                    HoTen = booking.HoTen,
                    SoDienThoai = booking.SoDienThoai,
                    TGianNhanPhong = Convert.ToDateTime(booking.TGianNhanPhong),
                    TGianTraPhong = Convert.ToDateTime(booking.TGianTraPhong),
                    LoaiPhong = booking.LoaiPhong
                });
            }
            return list;
        }

        public BookingDTO GetBooking(string BId)
        {
            try
            {
                var booking = DB.Bookings.Where(b => b.BId == BId).SingleOrDefault();
                return booking.GetBookingDTO();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool CheckIn(string bookingId)
        {
            try
            {
                var booking = DB.Bookings.Where(b => b.BId == bookingId).SingleOrDefault();
                booking.BStatus = "CheckedIn";
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DatPhong(BookingDTO bookingDTO)
        {
            try
            {
                int count = DB.Bookings.ToList().Count;

                bookingDTO.BCreateAt = DateTime.Now;
                bookingDTO.BId = count.ToString();

                DB.Bookings.Add(Bookings.GetBookings(bookingDTO));
                DB.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaBookingTrongBookingOnline(Booking_OnlineDTO booking_OnlineDTO)
        {
            try
            {
                var book = DB.Booking_Online
                    .FirstOrDefault(b => b.CreateAt == booking_OnlineDTO.CreateAt && b.CCCD == booking_OnlineDTO.CCCD);

                DB.Booking_Online.Remove(book);
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ChuyenTrangThai(string id, string status)
        {
            try
            {
                var book = DB.Bookings.FirstOrDefault(b => b.BId == id);
                book.BStatus = status;
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
