using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;
using System.Windows.Forms;

namespace Data
{
    public class EmployeeData
    {
        private string connectionString;

        public EmployeeData()
        {
            connectionString = @"Data Source=TURTLEWN;Initial Catalog=HotelManagementSystem;Integrated Security=True";
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT 
                            EId,
                            EName,
                            EGender,
                            EPhone,
                            EEmail,
                            EAddress,
                            ERole,
                            EStatus
                        FROM Employees", conn))
                    {
                        conn.Open();
                        Console.WriteLine("Database connection opened successfully");
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var employee = new EmployeeDTO
                                {
                                    EId = reader["EId"].ToString(),
                                    EName = reader["EName"].ToString(),
                                    EGender = reader["EGender"].ToString(),
                                    EPhone = reader["EPhone"].ToString(),
                                    EEmail = reader["EEmail"].ToString(),
                                    EAddress = reader["EAddress"].ToString(),
                                    ERole = reader["ERole"].ToString(),
                                    EStatus = reader["EStatus"].ToString()
                                };
                                employees.Add(employee);
                                Console.WriteLine($"Loaded employee: {employee.EId} - {employee.EName}");
                            }
                        }
                    }
                }
                Console.WriteLine($"Total employees loaded: {employees.Count}");
                return employees;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllEmployees: {ex.Message}");
                Console.WriteLine($"Connection string: {connectionString}");
                throw;
            }
        }

        public List<EmployeeDTO> GetEmployeesByStatus(string status)
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE EStatus = @Status", conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new EmployeeDTO
                            {
                                EId = reader["EId"].ToString(),
                                EName = reader["EName"].ToString(),
                                EGender = reader["EGender"].ToString(),
                                EPhone = reader["EPhone"].ToString(),
                                EEmail = reader["EEmail"].ToString(),
                                EAddress = reader["EAddress"].ToString(),
                                ERole = reader["ERole"].ToString(),
                                EStatus = reader["EStatus"].ToString()
                            });
                        }
                    }
                }
            }
            return employees;
        }

        public List<EmployeeDTO> GetEmployeesByString(string searchString)
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT * FROM Employees 
                    WHERE EId LIKE @SearchString 
                    OR EName LIKE @SearchString 
                    OR EPhone LIKE @SearchString 
                    OR EEmail LIKE @SearchString", conn))
                {
                    cmd.Parameters.AddWithValue("@SearchString", "%" + searchString + "%");
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new EmployeeDTO
                            {
                                EId = reader["EId"].ToString(),
                                EName = reader["EName"].ToString(),
                                EGender = reader["EGender"].ToString(),
                                EPhone = reader["EPhone"].ToString(),
                                EEmail = reader["EEmail"].ToString(),
                                EAddress = reader["EAddress"].ToString(),
                                ERole = reader["ERole"].ToString(),
                                EStatus = reader["EStatus"].ToString()
                            });
                        }
                    }
                }
            }
            return employees;
        }

        public List<string> GetAllEmployeeRoles()
        {
            List<string> roles = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT ERole FROM Employees", conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                roles.Add(reader["ERole"].ToString());
                            }
                        }
                    }
                }
                return roles;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database error while getting employee roles: {ex.Message}\nConnection string: {connectionString}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting employee roles: {ex.Message}", ex);
            }
        }

        public EmployeeDTO GetEmployee(string id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE EId = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new EmployeeDTO
                            {
                                EId = reader["EId"].ToString(),
                                EName = reader["EName"].ToString(),
                                EGender = reader["EGender"].ToString(),
                                EPhone = reader["EPhone"].ToString(),
                                EEmail = reader["EEmail"].ToString(),
                                EAddress = reader["EAddress"].ToString(),
                                ERole = reader["ERole"].ToString(),
                                EStatus = reader["EStatus"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public string GetRole(string id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ERole FROM Employees WHERE EId = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public string GetStatus(string id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT EStatus FROM Employees WHERE EId = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public bool DeleteEmployee(string id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EId = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateEmployee(EmployeeDTO employee)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Employees 
                               SET EName = @Name,
                                   EGender = @Gender,
                                   EPhone = @Phone,
                                   EEmail = @Email,
                                   EAddress = @Address,
                                   ERole = @Role,
                                   EStatus = @Status
                               WHERE EId = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", employee.EId);
                    cmd.Parameters.AddWithValue("@Name", employee.EName);
                    cmd.Parameters.AddWithValue("@Gender", employee.EGender);
                    cmd.Parameters.AddWithValue("@Phone", employee.EPhone);
                    cmd.Parameters.AddWithValue("@Email", employee.EEmail);
                    cmd.Parameters.AddWithValue("@Address", employee.EAddress);
                    cmd.Parameters.AddWithValue("@Role", employee.ERole);
                    cmd.Parameters.AddWithValue("@Status", employee.EStatus);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AddEmployee(EmployeeDTO employee)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Employees (EId, EName, EGender, EPhone, EEmail, EAddress, ERole, EStatus)
                               VALUES (@Id, @Name, @Gender, @Phone, @Email, @Address, @Role, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", employee.EId);
                    cmd.Parameters.AddWithValue("@Name", employee.EName);
                    cmd.Parameters.AddWithValue("@Gender", employee.EGender);
                    cmd.Parameters.AddWithValue("@Phone", employee.EPhone);
                    cmd.Parameters.AddWithValue("@Email", employee.EEmail);
                    cmd.Parameters.AddWithValue("@Address", employee.EAddress);
                    cmd.Parameters.AddWithValue("@Role", employee.ERole);
                    cmd.Parameters.AddWithValue("@Status", employee.EStatus);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}