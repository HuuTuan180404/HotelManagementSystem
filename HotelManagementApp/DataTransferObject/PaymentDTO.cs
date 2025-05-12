using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class PaymentDTO
    {
        public string BPId { get; set; }
        public string BId { get; set; }
        public string EId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string PMethod { get; set; }
    }
}
