using DataTransferObject;
using System;
using System.Collections.Generic;
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
            var bookings = DB.Bookings.ToList();
            List<BookingDTO> list = new List<BookingDTO>();
            foreach (var booking in bookings) { list.Add(booking.GetBookingDTO()); }
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
    }
}
