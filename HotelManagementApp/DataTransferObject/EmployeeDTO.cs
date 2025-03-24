using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class EmployeeDTO
    {
        public string EID { get; set; }
        public string EName { get; set; }
        public string EGender { get; set; }
        public string EPhone { get; set; }
        public string EEmail { get; set; }
        public string EAddress { get; set; }
        public string EStatus { get; set; }
        public string ERole { get; set; }
        public string ERDescription { get; set; }
    }
}