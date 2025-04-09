using System;
using System.Collections.Generic;
using Data;
using DataTransferObject;

namespace Business
{
    public class EmployeeBusiness
    {
        private readonly EmployeeData employeeData;

        public EmployeeBusiness()
        {
            employeeData = new EmployeeData();
        }

        // Get all employees with their details
        public List<EmployeeDTO> GetAllEmployees()
        {
            return employeeData.GetAllEmployees();
        }

        // Get all employees filtered by status
        public List<EmployeeDTO> GetEmployeesByStatus(string status)
        {
            return employeeData.GetEmployeesByStatus(status);
        }

        // Get all employees filtered by search string
        public List<EmployeeDTO> GetEmployeesByString(string searchString)
        {
            return employeeData.GetEmployeesByString(searchString);
        }

        // Get all employee roles
        public List<string> GetAllEmployeeRoles()
        {
            return employeeData.GetAllEmployeeRoles();
        }

        // Get employee by ID
        public EmployeeDTO GetEmployee(string id)
        {
            return employeeData.GetEmployee(id);
        }

        // Get employee by role
        public string GetRole(string id)
        {
            return employeeData.GetRole(id);
        }

        // Get employee by status
        public string GetStatus(string id)
        {
            return employeeData.GetStatus(id);
        }

        // Delete employee
        public bool DeleteEmployee(string id)
        {
            return employeeData.DeleteEmployee(id);
        }

        // Update employee
        public bool UpdateEmployee(EmployeeDTO employee)
        {
            return employeeData.UpdateEmployee(employee);
        }

        // Add new employee
        public bool AddEmployee(EmployeeDTO employee)
        {
            return employeeData.AddEmployee(employee);
        }
    }
}