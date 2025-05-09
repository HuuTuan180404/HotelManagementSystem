using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PaymentD
    {
        HotelManagementSystemContext DB;

        public PaymentD() { DB = new HotelManagementSystemContext(); }

        public PaymentDTO GetPaymentById(string id)
        {
            try
            {
                //return DB.Payments
                return null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<PaymentMethodDTO> GetAllPaymentMethods()
        {
            try
            {
                return DB.PaymentMethod.Select(s => new PaymentMethodDTO
                {
                    PMethod = s.PMethod,
                    Description = s.Description
                }).ToList();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool CreateBill(PaymentDTO paymentDTO)
        {
            try
            {
                DB.Payments.Add(Payments.Convert(paymentDTO));
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
