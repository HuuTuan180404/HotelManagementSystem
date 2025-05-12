using System;
using System.Collections.Generic;
using Data;
using DataTransferObject;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EmployeeBusiness
    {
        EmployeeData EmployeeData;

        public EmployeeBusiness()
        {
            EmployeeData = new EmployeeData();
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            return EmployeeData.GetAllEmployees();
        }

        public List<EmployeeDTO> GetEmployeesByRole(string role)
        {
            return EmployeeData.GetEmployeesByRole(role);
        }
       
        public List<EmployeeDTO> GetEmployeesByStatus(string status)
        {
            return EmployeeData.GetEmployeesByStatus(status);
        }

        public List<EmployeeDTO> GetEmployeesByString(string s)
        {
            return EmployeeData.GetEmployeesByString(s);
        }

        public EmployeeDTO GetEmployee(string EId)
        {
            return EmployeeData.GetEmployee(EId);
        }

        public bool AddEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                return EmployeeData.AddEmployee(employeeDTO);
            }
            catch (SqlException ex) { throw ex; }
        }

        public bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            return EmployeeData.UpdateEmployee(employeeDTO);
        }

        public bool DeleteEmployee(string EId)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.EId = EId;
            return EmployeeData.DeleteEmployee(employeeDTO);
        }

        public List<string> GetAllRoles()
        {
            try
            {
                return EmployeeData.GetAllRoles();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public string GetNextAvailableId()
        {
            try
            {
                return EmployeeData.GetNextAvailableId();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}