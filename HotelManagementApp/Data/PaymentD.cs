using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Contexts;
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

        public List<Tuple<int, decimal>> DoanhThuTungThang()
        {
            try
            {
                // Bước 1: Lấy dữ liệu thô bằng anonymous object
                var rawData = DB.Payments
                    .Where(p => p.Date != null)
                    .GroupBy(p => p.Date.Value.Month)
                    .Select(g => new
                    {
                        Month = g.Key,
                        TotalAmount = g.Sum(p => p.Amount)
                    })
                    .OrderBy(g => g.Month)
                    .ToList();  // Truy vấn hoàn tất, đưa về RAM

                // Bước 2: Dùng Tuple sau khi có dữ liệu trong RAM
                var result = rawData
                    .Select(x => Tuple.Create(x.Month, x.TotalAmount))
                    .ToList();

                return result;
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public List<Tuple<int, decimal>> DoanhThuTheoNamThang(int year)
        {
            try
            {
                var query = DB.Payments.Where(p => p.Date != null && p.Date.Value.Year == year);

                var rawData = query
                    .GroupBy(p => p.Date.Value.Month)
                    .Select(g => new
                    {
                        Month = g.Key,
                        TotalAmount = g.Sum(p => p.Amount)
                    })
                    .OrderBy(g => g.Month)
                    .ToList();

                var result = rawData
                    .Select(x => Tuple.Create(x.Month, x.TotalAmount))
                    .ToList();

                return result;
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public List<int> GetYearsWithPayments()
        {
            return DB.Payments
                .Where(p => p.Date != null)
                .Select(p => p.Date.Value.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();
        }

    }
}
