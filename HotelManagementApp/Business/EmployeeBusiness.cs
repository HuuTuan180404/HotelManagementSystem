using System;
using System.Collections.Generic;
using Data;
using DataTransferObject;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace Business
{
    public class EmployeeBusiness
    {
        private readonly EmployeeData EmployeeData;
        private readonly string AvatarDirectory = "Avatars";
        private readonly Cloudinary cloudinary = new Cloudinary(new Account("dnumhb9vv", "379726368829849", "EwHNOSI78bhHKd_uE9LaIk8aR24"));

        public EmployeeBusiness()
        {
            EmployeeData = new EmployeeData();
            // Tạo thư mục lưu avatar nếu chưa tồn tại
            if (!Directory.Exists(AvatarDirectory))
            {
                Directory.CreateDirectory(AvatarDirectory);
            }
        }

        #region Get Methods
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
        #endregion

        #region Validation Methods
        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            // Mật khẩu phải có ít nhất 8 ký tự
            if (password.Length < 8)
                return false;

            // Mật khẩu phải chứa ít nhất 1 chữ hoa
            if (!password.Any(char.IsUpper))
                return false;

            // Mật khẩu phải chứa ít nhất 1 chữ thường
            if (!password.Any(char.IsLower))
                return false;

            // Mật khẩu phải chứa ít nhất 1 số
            if (!password.Any(char.IsDigit))
                return false;

            // Mật khẩu phải chứa ít nhất 1 ký tự đặc biệt
            if (!password.Any(c => !char.IsLetterOrDigit(c)))
                return false;

            return true;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }
        #endregion

        #region CRUD Methods
        public bool AddEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                // Kiểm tra số điện thoại
                if (string.IsNullOrWhiteSpace(employeeDTO.Phone))
                    throw new Exception("Số điện thoại không được để trống");

                // Kiểm tra mật khẩu
                if (string.IsNullOrWhiteSpace(employeeDTO.Password))
                    throw new Exception("Mật khẩu không được để trống");

                if (!IsValidPassword(employeeDTO.Password))
                    throw new Exception("Mật khẩu không đủ mạnh. Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt");

                // Mã hóa mật khẩu
                employeeDTO.Password = HashPassword(employeeDTO.Password);

                // Xử lý avatar nếu có
                if (!string.IsNullOrWhiteSpace(employeeDTO.Avatar))
                {
                    // Nếu là đường dẫn file local, upload lên Cloudinary
                    if (System.IO.File.Exists(employeeDTO.Avatar))
                    {
                        var uploadParams = new ImageUploadParams()
                        {
                            File = new FileDescription(employeeDTO.Avatar),
                            PublicId = $"employee_{employeeDTO.EId}_avatar"
                        };
                        var uploadResult = cloudinary.Upload(uploadParams);
                        employeeDTO.Avatar = uploadResult.SecureUrl.ToString();
                    }
                }

                return EmployeeData.AddEmployee(employeeDTO);
            }
            catch (SqlException ex) { throw ex; }
        }

        public bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                // Kiểm tra số điện thoại
                if (string.IsNullOrWhiteSpace(employeeDTO.Phone))
                    throw new Exception("Số điện thoại không được để trống");

                // Nếu có thay đổi mật khẩu
                if (!string.IsNullOrWhiteSpace(employeeDTO.Password))
                {
                    if (!IsValidPassword(employeeDTO.Password))
                        throw new Exception("Mật khẩu không đủ mạnh. Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt");

                    employeeDTO.Password = HashPassword(employeeDTO.Password);
                }

                // Nếu có thay đổi avatar
                if (!string.IsNullOrWhiteSpace(employeeDTO.Avatar))
                {
                    // Nếu là đường dẫn file local, upload lên Cloudinary
                    if (System.IO.File.Exists(employeeDTO.Avatar))
                    {
                        var uploadParams = new ImageUploadParams()
                        {
                            File = new FileDescription(employeeDTO.Avatar),
                            PublicId = $"employee_{employeeDTO.EId}_avatar"
                        };
                        var uploadResult = cloudinary.Upload(uploadParams);
                        if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK && uploadResult.SecureUrl != null)
                        {
                            employeeDTO.Avatar = uploadResult.SecureUrl.ToString();
                        }
                        else
                        {
                            var errorMsg = uploadResult.Error != null ? uploadResult.Error.Message : "Không rõ nguyên nhân";
                            throw new Exception("Upload avatar thất bại: " + errorMsg);
                        }
                    }
                }

                return EmployeeData.UpdateEmployee(employeeDTO);
            }
            catch (SqlException ex) { throw ex; }
        }

        public bool DeleteEmployee(string EId)
        {
            try
            {
                // Xóa avatar nếu có
                var employee = GetEmployee(EId);
                if (employee != null && !string.IsNullOrWhiteSpace(employee.Avatar))
                {
                    DeleteAvatar(employee.Avatar);
                }

                EmployeeDTO employeeDTO = new EmployeeDTO();
                employeeDTO.EId = EId;
                return EmployeeData.DeleteEmployee(employeeDTO);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Authentication Methods
        public bool ValidateLogin(string EId, string password)
        {
            try
            {
                var employee = GetEmployee(EId);
                if (employee == null)
                    return false;

                return VerifyPassword(password, employee.Password);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi xác thực đăng nhập: {ex.Message}");
            }
        }

        public bool ChangePassword(string EId, string oldPassword, string newPassword)
        {
            try
            {
                var employee = GetEmployee(EId);
                if (employee == null)
                    throw new Exception("Không tìm thấy nhân viên");

                if (!VerifyPassword(oldPassword, employee.Password))
                    throw new Exception("Mật khẩu cũ không đúng");

                if (!IsValidPassword(newPassword))
                    throw new Exception("Mật khẩu mới không đủ mạnh. Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt");

                employee.Password = HashPassword(newPassword);
                return EmployeeData.UpdateEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thay đổi mật khẩu: {ex.Message}");
            }
        }

        public bool ResetPassword(string EId, string newPassword)
        {
            try
            {
                var employee = GetEmployee(EId);
                if (employee == null)
                    throw new Exception("Không tìm thấy nhân viên");

                if (!IsValidPassword(newPassword))
                    throw new Exception("Mật khẩu mới không đủ mạnh. Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt");

                employee.Password = HashPassword(newPassword);
                return EmployeeData.UpdateEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi đặt lại mật khẩu: {ex.Message}");
            }
        }
        #endregion

        #region Avatar Methods
        private string SaveAvatar(string sourcePath, string employeeId)
        {
            try
            {
                if (!File.Exists(sourcePath))
                    throw new FileNotFoundException("Không tìm thấy file avatar");

                string extension = Path.GetExtension(sourcePath);
                string newFileName = $"{employeeId}{extension}";
                string destinationPath = Path.Combine(AvatarDirectory, newFileName);

                // Xóa avatar cũ nếu có
                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);
                }

                // Copy file mới
                File.Copy(sourcePath, destinationPath);
                return destinationPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi lưu avatar: {ex.Message}");
            }
        }

        private void DeleteAvatar(string avatarPath)
        {
            try
            {
                if (File.Exists(avatarPath))
                {
                    File.Delete(avatarPath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi xóa avatar: {ex.Message}");
            }
        }
        #endregion

        #region Utility Methods
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
        #endregion
    }
}