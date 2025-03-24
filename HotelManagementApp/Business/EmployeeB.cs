using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;
using Data;

namespace Business
{
    public class EmployeeB
    {
        public List<EmployeeDTO> GetAllEmployees()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            string query = @"SELECT e.*, r.ERDescription 
                           FROM Employees e 
                           LEFT JOIN Employee_Role r ON e.ERole = r.ERole";

            try
            {
                using (SqlConnection conn = ConfigData.getConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeDTO employee = new EmployeeDTO
                                {
                                    EID = reader["EID"].ToString(),
                                    EName = reader["EName"].ToString(),
                                    EGender = reader["EGender"].ToString(),
                                    EPhone = reader["EPhone"].ToString(),
                                    EEmail = reader["EEmail"].ToString(),
                                    EAddress = reader["EAddress"].ToString(),
                                    EStatus = reader["EStatus"].ToString(),
                                    ERole = reader["ERole"].ToString(),
                                    ERDescription = reader["ERDescription"]?.ToString()
                                };
                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading employee data: " + ex.Message, ex);
            }
            return employees;
        }

        public List<EmployeeDTO> GetFilteredEmployees(string searchText, string status, string role)
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            string query = @"SELECT e.*, r.ERDescription 
                           FROM Employees e 
                           LEFT JOIN Employee_Role r ON e.ERole = r.ERole 
                           WHERE (@SearchText = '' OR 
                                 e.EName LIKE '%' + @SearchText + '%' OR 
                                 e.EPhone LIKE '%' + @SearchText + '%' OR 
                                 e.EEmail LIKE '%' + @SearchText + '%')
                           AND (@Status = '' OR e.EStatus = @Status)
                           AND (@Role = '' OR e.ERole = @Role)";

            using (SqlConnection conn = ConfigData.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchText", searchText ?? "");
                    cmd.Parameters.AddWithValue("@Status", status ?? "");
                    cmd.Parameters.AddWithValue("@Role", role ?? "");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeDTO employee = new EmployeeDTO
                            {
                                EID = reader["EID"].ToString(),
                                EName = reader["EName"].ToString(),
                                EGender = reader["EGender"].ToString(),
                                EPhone = reader["EPhone"].ToString(),
                                EEmail = reader["EEmail"].ToString(),
                                EAddress = reader["EAddress"].ToString(),
                                EStatus = reader["EStatus"].ToString(),
                                ERole = reader["ERole"].ToString(),
                                ERDescription = reader["ERDescription"]?.ToString()
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }

        public List<EmployeeDTO> GetAllRoles()
        {
            List<EmployeeDTO> roles = new List<EmployeeDTO>();
            string query = "SELECT ERole, ERDescription FROM Employee_Role";

            using (SqlConnection conn = ConfigData.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeDTO role = new EmployeeDTO
                            {
                                ERole = reader["ERole"].ToString(),
                                ERDescription = reader["ERDescription"].ToString()
                            };
                            roles.Add(role);
                        }
                    }
                }
            }
            return roles;
        }

        public bool DeleteEmployees(List<string> employeeIds)
        {
            using (SqlConnection conn = ConfigData.getConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EID = @EID", conn, transaction))
                        {
                            cmd.Parameters.Add("@EID", SqlDbType.VarChar);
                            foreach (string id in employeeIds)
                            {
                                cmd.Parameters["@EID"].Value = id;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
} 