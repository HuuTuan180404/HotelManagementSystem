using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class EmployeeDTO
    {
        public string EId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string ERole { get; set; }
        public string RoleDescription { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }

        public EmployeeDTO() { }

        public EmployeeDTO(EmployeeDTO other)
        {
            EId = other.EId;
            Name = other.Name;
            Gender = other.Gender;
            Phone = other.Phone;
            Email = other.Email;
            Address = other.Address;
            Status = other.Status;
            ERole = other.ERole;
            RoleDescription = other.RoleDescription;
            Password = other.Password;
            Avatar = other.Avatar;
        }

        public bool Compare(EmployeeDTO other)
        {
            if (this.EId != other.EId) return false;
            if (this.Name != other.Name) return false;
            if (this.Gender != other.Gender) return false;
            if (this.Phone != other.Phone) return false;
            if (this.Email != other.Email) return false;
            if (this.Address != other.Address) return false;
            if (this.Status != other.Status) return false;
            if (this.ERole != other.ERole) return false;
            if (this.Password != other.Password) return false;
            if (this.Avatar != other.Avatar) return false;
            return true;
        }

        public static List<string> Properties()
        {
            Type type = typeof(EmployeeDTO);
            return type.GetProperties().Select(p => p.Name).ToList();
        }

        public string Display()
        {
            return $"{EId}-{Name}-{Gender}-{Phone}-{Email}-{Address}-{Status}-{ERole}-{Avatar}";
        }

        public EmployeeDTO Clone()
        {
            return new EmployeeDTO(this);
        }
    }
}
