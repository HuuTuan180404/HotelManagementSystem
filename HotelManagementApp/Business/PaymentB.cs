using Data;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PaymentB
    {
        PaymentD PaymentD;
        public PaymentB() { PaymentD = new PaymentD(); }
        public List<PaymentMethodDTO> GetAllPaymentMethods()
        {
            try
            {
                return PaymentD.GetAllPaymentMethods();
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
                return PaymentD.CreateBill(paymentDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
