using Data;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business
{
    public class ServiceB
    {
        ServiceD ServiceD;
        public ServiceB() { ServiceD = new ServiceD(); }
        public List<ServiceDTO> GetAllServices()
        {
            try
            {
                return ServiceD.GetAllServices();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ServiceDTO GetServiceBySName(string sname)
        {
            try
            {
                return ServiceD.GetAllServices().SingleOrDefault(s => s.SName == sname);
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
                return ServiceD.GetAllServicesUsage(SUId);
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
                ServiceD.CreateRequest(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Request(List<ServiceUsageDetailDTO> list)
        {
            try
            {
                return ServiceD.Request(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
