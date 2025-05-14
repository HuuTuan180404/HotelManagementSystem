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

        public string UpdateCustomerWithMessage(CustomerDTO customer)
        {
            try
            {
                using (var DB = new HotelManagementSystemContext())
                {
                    var existingCustomer = DB.Customers.Find(customer.CId);
                    if (existingCustomer != null)
                    {
                        // Kiểm tra trùng số điện thoại với khách hàng khác
                        if (!string.IsNullOrWhiteSpace(customer.Phone))
                        {
                            var phoneExists = DB.Customers.Any(c => c.Phone == customer.Phone && c.CId != customer.CId);
                            if (phoneExists)
                                return "Số điện thoại đã tồn tại cho khách hàng khác!";
                        }
                        // Kiểm tra trùng email với khách hàng khác
                        if (!string.IsNullOrWhiteSpace(customer.Email))
                        {
                            var emailExists = DB.Customers.Any(c => c.Email == customer.Email && c.CId != customer.CId);
                            if (emailExists)
                                return "Email đã tồn tại cho khách hàng khác!";
                        }
                        existingCustomer.Name = customer.Name;
                        existingCustomer.Gender = customer.Gender;
                        existingCustomer.Phone = customer.Phone;
                        existingCustomer.Email = customer.Email;
                        existingCustomer.Address = customer.Address;
                        existingCustomer.Type = customer.Type;
                        DB.SaveChanges();
                        return "OK";
                    }
                    return "Không tìm thấy khách hàng để cập nhật!";
                }
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật khách hàng: " + ex.Message;
            }
        }

        public string DeleteCustomerWithMessage(string cId)
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
                        return "OK";
                    }
                    return "Không tìm thấy khách hàng để xóa!";
                }
            }
            catch (Exception ex)
            {
                // Lấy thông tin lỗi sâu nhất
                string detail = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return $"Lỗi khi xóa khách hàng: {detail}";
            }
        }

        public List<CustomerDTO> FilterByString(string searchString)
        {
            var list = GetAllCustomers().Where(x => x.Display().IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return list;
        }
    }
}
