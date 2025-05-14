using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;

namespace Data
{
    public class ServiceD
    {
        HotelManagementSystemContext DB;
        public ServiceD() { DB = new HotelManagementSystemContext(); }
        public List<ServiceDTO> GetAllServices()
        {
            try
            {
                var services = DB.Services.Select(s => new ServiceDTO
                {
                    SName = s.SName,
                    SPrice = s.SPrice,
                    SDescription = s.SDescription
                }).ToList();
                return services;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ServiceUsageDetailDTO> GetAllServicesUsage(string SUId)
        {
            try
            {
                var services = DB.ServiceUsageDetail
                    .Where(s => s.SUId == SUId)
                    .Select(s => new ServiceUsageDetailDTO
                    {
                        SUId = SUId,
                        SName = s.SName,
                        EId = s.EId,
                        Quantity = s.Quantity
                    })
                    .ToList();
                return services;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CreateRequest(string Id)
        {
            try
            {
                var x = DB.ServiceUsage.Where(r => r.SUId == Id).SingleOrDefault();
                if (x == null)
                {
                    DB.ServiceUsage.Add(new ServiceUsage
                    {
                        SUId = Id,
                        SUDate = DateTime.Now
                    });
                    DB.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool Request(List<ServiceUsageDetailDTO> list)
        {
            try
            {
                foreach (var service in list)
                {
                    DB.ServiceUsageDetail.Add(new ServiceUsageDetail
                    {

                        SUId = service.SUId,
                        SName = service.SName,
                        EId = service.EId,
                        Quantity = service.Quantity,
                        CreateAt = DateTime.Now
                    });
                    DB.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DoanhThuDichVuDTO> LayDoanhThuDichVu(int year)
        {
            try
            {
                var result = DB.ServiceUsageDetail
            .Join(DB.Services,
                sud => sud.SName,
                s => s.SName,
                (sud, s) => new { sud, s })
            .Join(DB.Payments,
                combined => combined.sud.SUId,
                p => p.BId,
                (combined, p) => new
                {
                    combined.s.SName,
                    combined.sud.Quantity,
                    combined.s.SPrice,
                    p.Date
                })
            .Where(x => x.Date.Value.Year == year)
            .GroupBy(x => new
            {
                Month = x.Date.Value.Month,
            })
            .Select(g => new
            {
                Month = g.Key.Month,
                Total = g.Sum(x => x.Quantity * x.SPrice)
            })
            .ToList()
            .Select(g => new DoanhThuDichVuDTO
            {
                month = g.Month,
                Total = g.Total
            })
            .ToList();
                return result.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
