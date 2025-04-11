using System;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using DataTransferObject;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Entity;

namespace Data
{
    public class EmployeeData
    {
        HotelManagementSystemContext DB;

        public EmployeeData()
        {
            try
            {
                DB = new HotelManagementSystemContext();
            }
            catch (SqlException ex) { throw ex; }
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            try
            {
                var employees = DB.Employees.Include("EmployeeRole")
                    .Select(e => new EmployeeDTO
                    {
                        EId = e.EId,
                        Name = e.Name,
                        Gender = e.Gender,
                        Phone = e.Phone,
                        Email = e.Email,
                        Address = e.Address,
                        Status = e.Status,
                        ERole = e.ERole,
                        RoleDescription = e.EmployeeRole.Description
                    });

                if (employees != null)
                {
                    list = employees.ToList();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return list;
        }

        public EmployeeDTO GetEmployee(string EId)
        {
            try
            {
                var employee = DB.Employees.Include("EmployeeRole")
                    .Where(e => e.EId == EId)
                    .Select(e => new EmployeeDTO
                    {
                        EId = e.EId,
                        Name = e.Name,
                        Gender = e.Gender,
                        Phone = e.Phone,
                        Email = e.Email,
                        Address = e.Address,
                        Status = e.Status,
                        ERole = e.ERole,
                        RoleDescription = e.EmployeeRole.Description
                    })
                    .FirstOrDefault();
                return employee;
            }
            catch (SqlException ex) { throw ex; }
        }

        public List<EmployeeDTO> GetEmployeesByRole(string role)
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            try
            {
                var employees = DB.Employees.Include("EmployeeRole")
                    .Where(e => e.ERole == role)
                    .Select(e => new EmployeeDTO
                    {
                        EId = e.EId,
                        Name = e.Name,
                        Gender = e.Gender,
                        Phone = e.Phone,
                        Email = e.Email,
                        Address = e.Address,
                        Status = e.Status,
                        ERole = e.ERole,
                        RoleDescription = e.EmployeeRole.Description
                    });

                if (employees != null)
                {
                    list = employees.ToList();
                }
            }
            catch (SqlException ex) { throw ex; }
            return list;
        }

        public List<EmployeeDTO> GetEmployeesByStatus(string status)
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            try
            {
                var employees = DB.Employees.Include("EmployeeRole")
                    .Where(e => e.Status == status)
                    .Select(e => new EmployeeDTO
                    {
                        EId = e.EId,
                        Name = e.Name,
                        Gender = e.Gender,
                        Phone = e.Phone,
                        Email = e.Email,
                        Address = e.Address,
                        Status = e.Status,
                        ERole = e.ERole,
                        RoleDescription = e.EmployeeRole.Description
                    });

                if (employees != null)
                {
                    list = employees.ToList();
                }
            }
            catch (SqlException ex) { throw ex; }
            return list;
        }

        public List<EmployeeDTO> GetEmployeesByString(string s)
        {
            var searchTerm = s.ToLower().Trim();
            return GetAllEmployees()
                .Where(x => x.Name.ToLower().Split(' ')
                    .Any(word => word.StartsWith(searchTerm)))
                .ToList();
        }

        public bool AddEmployee(EmployeeDTO employeeDTO)
        {
            if (employeeDTO == null)
                throw new Exception("Dữ liệu nhân viên không hợp lệ");

            try
            {
                // Basic validation
                if (string.IsNullOrWhiteSpace(employeeDTO.Name))
                    throw new Exception("Tên nhân viên không được để trống");

                if (string.IsNullOrWhiteSpace(employeeDTO.Phone))
                    throw new Exception("Số điện thoại không được để trống");

                if (string.IsNullOrWhiteSpace(employeeDTO.Gender))
                    throw new Exception("Giới tính không được để trống");

                if (string.IsNullOrWhiteSpace(employeeDTO.Status))
                    throw new Exception("Trạng thái không được để trống");

                if (string.IsNullOrWhiteSpace(employeeDTO.ERole))
                    throw new Exception("Chức vụ không được để trống");

                // Check for duplicate email if provided
                if (!string.IsNullOrWhiteSpace(employeeDTO.Email))
                {
                    var existingEmployee = DB.Employees.FirstOrDefault(e => e.Email == employeeDTO.Email.Trim());
                    if (existingEmployee != null)
                    {
                        throw new Exception("Email này đã được sử dụng bởi nhân viên khác");
                    }
                }

                // Create new employee
                var employee = new Employees
                {
                    EId = employeeDTO.EId,
                    Name = employeeDTO.Name.Trim(),
                    Gender = employeeDTO.Gender,
                    Phone = employeeDTO.Phone.Trim(),
                    Email = employeeDTO.Email?.Trim() ?? "",
                    Address = employeeDTO.Address?.Trim() ?? "",
                    Status = employeeDTO.Status,
                    ERole = employeeDTO.ERole
                };

                // Add to database
                DB.Employees.Add(employee);
                DB.SaveChanges();

                return true;
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                while (innerException != null && innerException.InnerException != null)
                {
                    innerException = innerException.InnerException;
                }
                
                // Check if it's a unique constraint violation
                if (innerException?.Message.Contains("UNIQUE KEY") == true)
                {
                    if (innerException.Message.Contains("Email"))
                    {
                        throw new Exception("Email này đã được sử dụng bởi nhân viên khác");
                    }
                }
                
                throw new Exception($"Lỗi cập nhật database: {innerException?.Message ?? ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm nhân viên: {ex.Message}");
            }
        }

        public bool DeleteEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                var employee = DB.Employees.SingleOrDefault(e => e.EId == employeeDTO.EId);
                if (employee == null)
                    return false;
                DB.Employees.Remove(employee);
                DB.SaveChanges();
                return true;
            }
            catch (SqlException ex) { throw ex; }
        }

        public bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                var employee = DB.Employees.SingleOrDefault(e => e.EId == employeeDTO.EId);
                if (employee == null) return false;

                employee.Name = employeeDTO.Name;
                employee.Gender = employeeDTO.Gender;
                employee.Phone = employeeDTO.Phone;
                employee.Email = employeeDTO.Email;
                employee.Address = employeeDTO.Address;
                employee.Status = employeeDTO.Status;
                employee.ERole = employeeDTO.ERole;

                DB.SaveChanges();
                return true;
            }
            catch (SqlException ex) { throw ex; }
        }

        public List<string> GetAllRoles()
        {
            try
            {
                var roles = DB.EmployeeRole
                    .Select(r => r.ERole)
                    .ToList();
                return roles;
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
                // Get all existing employee IDs
                var existingIds = DB.Employees
                    .Select(e => e.EId)
                    .ToList();

                // Convert IDs to numbers and sort them
                var numericIds = new List<int>();
                foreach (var id in existingIds)
                {
                    if (id.StartsWith("E") && int.TryParse(id.Substring(1), out int numericId))
                    {
                        numericIds.Add(numericId);
                    }
                }
                numericIds.Sort();

                // Find the first available number
                int nextId = 1;
                foreach (int currentId in numericIds)
                {
                    if (currentId != nextId)
                    {
                        break;
                    }
                    nextId++;
                }

                // Format the ID with leading zeros (e.g., E001)
                return $"E{nextId:D3}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
