using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class EmployeeDTO
    {
        [DisplayName("ID")]
        public string EId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string EName { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public string EGender { get; set; }

        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits")]
        public string EPhone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EEmail { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        public string EAddress { get; set; }

        [DisplayName("Role")]
        public string ERole { get; set; }

        [DisplayName("Status")]
        public string EStatus { get; set; }

        public override string ToString()
        {
            return $"{EId} - {EName}";
        }
    }
}
