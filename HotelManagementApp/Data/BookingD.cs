using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            var bookings = DB.Bookings.ToList();
            List<BookingDTO> list = new List<BookingDTO>();
            foreach (var booking in bookings) { list.Add(booking.GetBookingDTO()); }
            return list;
        }

        public BookingDTO GetBooking(string BId)
        {
            var booking = DB.Bookings.Where(b => b.BId == BId).SingleOrDefault();
            return booking.GetBookingDTO();
        }
    }
}
