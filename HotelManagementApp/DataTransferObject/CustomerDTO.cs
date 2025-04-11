using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CustomerDTO
    {
        public string CId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public static List<string> Properties()
        {
            Type type = typeof(CustomerDTO);
            var properties = type.GetProperties();
            return properties.Select(p => p.Name).ToList();
        }

        public string Display()
        {
            return $"{CId}-{Name}-{Gender}-{Phone}-{Email}-{Address}-{Type}";
        }
    }
}
