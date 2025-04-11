using Data;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomerBusiness
    {
        private CustomerData customerData = new CustomerData();

        public List<CustomerDTO> GetAllCustomers()
        {
            return customerData.GetAllCustomers();
        }

        public CustomerDTO GetCustomerById(string cId)
        {
            return customerData.GetCustomerById(cId);
        }

        public bool AddCustomer(CustomerDTO customer)
        {
            return customerData.AddCustomer(customer);
        }

        public bool UpdateCustomer(CustomerDTO customer)
        {
            return customerData.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(string cId)
        {
            return customerData.DeleteCustomer(cId);
        }

        public List<CustomerDTO> SearchCustomers(string searchString)
        {
            return customerData.GetAllCustomers()
                .Where(c => c.Name.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<string> GetCustomerTypes()
        {
            return new List<string> { "Regular", "VIP", "New" };
        }

        public List<string> GetGenders()
        {
            return new List<string> { "Male", "Female", "Other" };
        }
    }
}
