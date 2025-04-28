using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ServiceUsageDetailDTO
    {
        public string SUId { get; set; }
        public string SName { get; set; }
        public string EId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateAt { get; set; }

        public string Display()
        {
            return $"{SUId}-{SName}-{EId}-{Quantity}";
        }
    }
}
