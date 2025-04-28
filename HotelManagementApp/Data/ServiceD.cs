using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    }).ToList();
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
                DB.ServiceUsage.Add(new ServiceUsage
                {
                    SUId = Id,
                    SUDate = DateTime.Now
                });
                DB.SaveChanges();
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
                    DB.ServiceUsageDetail.Add(ServiceUsageDetail.Convert(service));
                    DB.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
