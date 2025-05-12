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
        private readonly HotelManagementSystemContext DB;

        public EmployeeData()
        {
            try
            {
                DB = new HotelManagementSystemContext();
            }
            catch (SqlException ex) { throw ex; }
        }

        #region Get Methods
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
                        RoleDescription = e.EmployeeRole.Description,
                        Password = e.Password,
                        Avatar = e.Avatar
                    });

                if (employees != null)
                {
                    list = employees.ToList();
                }
            }
            catch (SqlException ex) { throw ex; }
            return list;
        }

        public EmployeeDTO GetEmployee(string EId)
        {
            if (string.IsNullOrWhiteSpace(EId))
                throw new ArgumentException("Mã nhân viên không được để trống");

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
                        RoleDescription = e.EmployeeRole.Description,
                        Password = e.Password,
                        Avatar = e.Avatar
                    })
                    .FirstOrDefault();
                return employee;
            }
            catch (SqlException ex) { throw ex; }
        }

        public List<EmployeeDTO> GetEmployeesByRole(string role)
        {
            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("Vai trò không được để trống");

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
                        RoleDescription = e.EmployeeRole.Description,
                        Password = e.Password,
                        Avatar = e.Avatar
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
            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("Trạng thái không được để trống");

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
                        RoleDescription = e.EmployeeRole.Description,
                        Password = e.Password,
                        Avatar = e.Avatar
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
            if (string.IsNullOrWhiteSpace(s))
                throw new ArgumentException("Từ khóa tìm kiếm không được để trống");

            var searchTerm = s.ToLower().Trim();
            return GetAllEmployees()
                .Where(x => x.Name.ToLower().Split(' ')
                    .Any(word => word.StartsWith(searchTerm)))
                .ToList();
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
            catch (SqlException ex) { throw ex; }
        }
        #endregion

        #region Validation Methods
        private bool IsPhoneNumberExists(string phone, string excludeEId = null)
        {
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Số điện thoại không được để trống");

            try
            {
                var query = DB.Employees.Where(e => e.Phone == phone);
                if (!string.IsNullOrEmpty(excludeEId))
                {
                    query = query.Where(e => e.EId != excludeEId);
                }
                return query.Any();
            }
            catch (SqlException ex) { throw ex; }
        }

        private void ValidateEmployeeData(EmployeeDTO employeeDTO)
        {
            if (employeeDTO == null)
                throw new ArgumentNullException(nameof(employeeDTO), "Dữ liệu nhân viên không hợp lệ");

            if (string.IsNullOrWhiteSpace(employeeDTO.Name))
                throw new ArgumentException("Tên nhân viên không được để trống");

            if (string.IsNullOrWhiteSpace(employeeDTO.Phone))
                throw new ArgumentException("Số điện thoại không được để trống");

            if (string.IsNullOrWhiteSpace(employeeDTO.Gender))
                throw new ArgumentException("Giới tính không được để trống");

            if (string.IsNullOrWhiteSpace(employeeDTO.Status))
                throw new ArgumentException("Trạng thái không được để trống");

            if (string.IsNullOrWhiteSpace(employeeDTO.ERole))
                throw new ArgumentException("Chức vụ không được để trống");
        }
        #endregion

        #region CRUD Methods
        public bool AddEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                ValidateEmployeeData(employeeDTO);

                // Kiểm tra số điện thoại đã tồn tại chưa
                if (IsPhoneNumberExists(employeeDTO.Phone))
                    throw new Exception("Số điện thoại này đã được sử dụng bởi nhân viên khác");

                // Kiểm tra mã nhân viên đã tồn tại chưa
                if (DB.Employees.Any(e => e.EId == employeeDTO.EId))
                    throw new Exception("Mã nhân viên này đã tồn tại, vui lòng nhập mã khác.");

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
                    ERole = employeeDTO.ERole,
                    Password = employeeDTO.Password,
                    Avatar = employeeDTO.Avatar
                };

                // Add to database
                DB.Employees.Add(employee);
                DB.SaveChanges();

                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => $"{x.PropertyName}: {x.ErrorMessage}")
                    .ToList();
                var fullErrorMessage = string.Join("; ", errorMessages);
                throw new Exception($"Lỗi xác thực dữ liệu: {fullErrorMessage}");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                while (innerException != null && innerException.InnerException != null)
                {
                    innerException = innerException.InnerException;
                }
                
                // Check if it's a unique constraint violation for phone
                if (innerException?.Message.Contains("UNIQUE KEY") == true)
                {
                    if (innerException.Message.Contains("Phone"))
                    {
                        throw new Exception("Số điện thoại này đã được sử dụng bởi nhân viên khác");
                    }
                }
                
                throw new Exception($"Lỗi cập nhật database: {innerException?.Message ?? ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm nhân viên: {ex.Message}");
            }
        }

        public bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                ValidateEmployeeData(employeeDTO);

                var employee = DB.Employees.SingleOrDefault(e => e.EId == employeeDTO.EId);
                if (employee == null) return false;

                // Kiểm tra số điện thoại đã tồn tại chưa (trừ nhân viên hiện tại)
                if (IsPhoneNumberExists(employeeDTO.Phone, employeeDTO.EId))
                    throw new Exception("Số điện thoại này đã được sử dụng bởi nhân viên khác");

                employee.Name = employeeDTO.Name.Trim();
                employee.Gender = employeeDTO.Gender;
                employee.Phone = employeeDTO.Phone.Trim();
                employee.Email = employeeDTO.Email?.Trim() ?? "";
                employee.Address = employeeDTO.Address?.Trim() ?? "";
                employee.Status = employeeDTO.Status;
                employee.ERole = employeeDTO.ERole;
                employee.Password = employeeDTO.Password;
                employee.Avatar = employeeDTO.Avatar;

                DB.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => $"{x.PropertyName}: {x.ErrorMessage}")
                    .ToList();
                var fullErrorMessage = string.Join("; ", errorMessages);
                throw new Exception($"Lỗi xác thực dữ liệu: {fullErrorMessage}");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                while (innerException != null && innerException.InnerException != null)
                {
                    innerException = innerException.InnerException;
                }
                
                // Check if it's a unique constraint violation for phone
                if (innerException?.Message.Contains("UNIQUE KEY") == true)
                {
                    if (innerException.Message.Contains("Phone"))
                    {
                        throw new Exception("Số điện thoại này đã được sử dụng bởi nhân viên khác");
                    }
                }
                
                throw new Exception($"Lỗi cập nhật database: {innerException?.Message ?? ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật nhân viên: {ex.Message}");
            }
        }

        public bool DeleteEmployee(EmployeeDTO employeeDTO)
        {
            if (employeeDTO == null)
                throw new ArgumentNullException(nameof(employeeDTO), "Dữ liệu nhân viên không hợp lệ");

            if (string.IsNullOrWhiteSpace(employeeDTO.EId))
                throw new ArgumentException("Mã nhân viên không được để trống");

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
        #endregion

        #region Utility Methods
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
                throw new Exception($"Lỗi khi tạo mã nhân viên mới: {ex.Message}");
            }
        }
        #endregion
    }
}