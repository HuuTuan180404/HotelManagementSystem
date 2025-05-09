using DataTransferObject;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BookingB
    {
        BookingD BookingD;

        public BookingB() { BookingD = new BookingD(); }

        public List<BookingDTO> GetAllBookings()
        {
            return BookingD.GetAllBookings();
        }

        public BookingDTO GetBooking(string booingId)
        {
            try
            {
                return BookingD.GetBooking(booingId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BookingDTO> GetBookingsByRoomId(string roomId)
        {
            try
            {
                return BookingD.GetAllBookings().Where(b => b.RId == roomId).ToList();
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
                return BookingD.CheckIn(bookingId);
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
                return BookingD.DatPhong(bookingDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
