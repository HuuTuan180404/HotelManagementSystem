using DataTransferObject;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        public List<BookingDTO> BookingHieuLuc()
        {
            return BookingD.GetAllBookings().Where(r => (r.BStatus != "Cancelled" && r.BStatus != "NoShow")).ToList();
        }

        public List<Booking_OnlineDTO> GetAllBookingOnline()
        {
            try
            {
                return BookingD.GetAllBookingOnline();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public int DatPhongOnl(RoomB RoomB)
        {
            RoomB roomB = new RoomB();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            try
            {
                List<RoomDTO> rooms = RoomB.GetAllRooms();

                List<BookingDTO> bookings = BookingHieuLuc();

                List<Booking_OnlineDTO> booking_OnlineDTOs = GetAllBookingOnline();

                int result = 0;

                foreach (var i in booking_OnlineDTOs) // duyệt qua danh sách khách đặt onl
                {
                    // danh sách mã phòng | lọc theo loại phòng mà khách đặt | A
                    var danhSachMaPhong = rooms.Where(r => r.RType == i.LoaiPhong).Select(r => r.RId).ToList();
                    //Debug.WriteLine(i.ToString());

                    // danh sách mã phòng bận trong giờ mà khách muốn | B
                    var danhSachBookingTrungGio = bookings
                        .Where(book => !(book.BTimeCheckOut.AddMinutes(30) < i.TGianNhanPhong || i.TGianTraPhong.AddMinutes(30) < book.BTimeCheckIn))
                        .Select(r => r.RId)
                        .Distinct()
                        .ToList();

                    // A \ B
                    var phongTrong = danhSachMaPhong.Except(danhSachBookingTrungGio);

                    if (phongTrong.Count() > 0)
                    {
                        CustomerDTO customer = customerBusiness.GetCustomerById(i.CCCD);
                        if (customer == null)
                        {
                            customer = new CustomerDTO
                            {
                                CId = i.CCCD,
                                Name = i.HoTen,
                                Gender = "Other",
                                Phone = i.SoDienThoai,
                                Email = i.SoDienThoai,
                                Type = "New"
                            };
                            try
                            {
                                customerBusiness.AddCustomer(customer);
                            }
                            catch (Exception ex) { throw ex; }
                        }
                        BookingDTO bookingDTO = new BookingDTO
                        {
                            RId = phongTrong.ElementAt(0),
                            CId = customer.CId,
                            BTimeCheckIn = i.TGianNhanPhong,
                            BTimeCheckOut = i.TGianTraPhong,
                            BStatus = "Confirmed"
                        };
                        if (DatPhong(bookingDTO))
                        {
                            Debug.WriteLine(i.ToString());
                            if (BookingD.XoaBookingTrongBookingOnline(i))
                                result++;
                        }
                    }
                }
                return result;
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
                return BookingD.ChuyenTrangThai(id, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
