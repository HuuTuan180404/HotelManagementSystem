//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using DataTransferObject;
    using System;
    using System.Collections.Generic;
    
    public partial class Bookings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bookings()
        {
            this.Payments = new HashSet<Payments>();
        }
    
        public string BId { get; set; }
        public string RId { get; set; }
        public string CId { get; set; }
        public System.DateTime BTimeCheckIn { get; set; }
        public System.DateTime BTimeCheckOut { get; set; }
        public string BStatus { get; set; }
        public Nullable<System.DateTime> BCreateAt { get; set; }
    
        public virtual BookingStatus BookingStatus { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Rooms Rooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ServiceUsage ServiceUsage { get; set; }
        public BookingDTO GetBookingDTO()
        {
            return new BookingDTO
            {
                BId = this.BId,
                RId = this.RId,
                CId = this.CId,
                BTimeCheckIn = this.BTimeCheckIn,
                BTimeCheckOut = this.BTimeCheckOut,
                BStatus = this.BStatus,
                BCreateAt = this.BCreateAt.HasValue ? this.BCreateAt.Value : DateTime.Now
            };
        }

        public static Bookings GetBookings(BookingDTO bookingDTO)
        {
            return new Bookings
            {
                BId = bookingDTO.BId,
                RId = bookingDTO.RId,
                CId = bookingDTO.CId,
                BTimeCheckIn = bookingDTO.BTimeCheckIn,
                BTimeCheckOut = bookingDTO.BTimeCheckOut,
                BStatus = bookingDTO.BStatus,
                BCreateAt = bookingDTO.BCreateAt
            };
        }
    }
}
