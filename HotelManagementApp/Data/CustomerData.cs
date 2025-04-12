using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace Data
{
    public class CustomerData
    {
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            using (var DB = new HotelManagementSystemContext())
            {
                var customers = DB.Customers.Select(c => new CustomerDTO
                {
                    CId = c.CId,
                    Name = c.Name,
                    Gender = c.Gender,
                    Phone = c.Phone,
                    Email = c.Email,
                    Address = c.Address,
                    Type = c.Type
                });

                if (customers != null)
                {
                    list = customers.ToList();
                }
            }
            return list;
        }

        public CustomerDTO GetCustomerById(string cId)
        {
            using (var DB = new HotelManagementSystemContext())
            {
                var customer = DB.Customers.Where(c => c.CId == cId)
                    .Select(c => new CustomerDTO
                    {
                        CId = c.CId,
                        Name = c.Name,
                        Gender = c.Gender,
                        Phone = c.Phone,
                        Email = c.Email,
                        Address = c.Address,
                        Type = c.Type
                    }).FirstOrDefault();

                return customer;
            }
        }

        public bool AddCustomer(CustomerDTO customer)
        {
            try
            {
                using (var DB = new HotelManagementSystemContext())
                {
                    var newCustomer = new Customers
                    {
                        CId = customer.CId,
                        Name = customer.Name,
                        Gender = customer.Gender,
                        Phone = customer.Phone,
                        Email = customer.Email,
                        Address = customer.Address,
                        Type = customer.Type
                    };

                    DB.Customers.Add(newCustomer);
                    DB.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(CustomerDTO customer)
        {
            try
            {
                using (var DB = new HotelManagementSystemContext())
                {
                    var existingCustomer = DB.Customers.Find(customer.CId);
                    if (existingCustomer != null)
                    {
                        existingCustomer.Name = customer.Name;
                        existingCustomer.Gender = customer.Gender;
                        existingCustomer.Phone = customer.Phone;
                        existingCustomer.Email = customer.Email;
                        existingCustomer.Address = customer.Address;
                        existingCustomer.Type = customer.Type;

                        DB.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(string cId)
        {
            try
            {
                using (var DB = new HotelManagementSystemContext())
                {
                    var customer = DB.Customers.Find(cId);
                    if (customer != null)
                    {
                        DB.Customers.Remove(customer);
                        DB.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<CustomerDTO> FilterByString(string searchString)
        {
            var list = GetAllCustomers().Where(x => x.Display().IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return list;
        }
    }
}
