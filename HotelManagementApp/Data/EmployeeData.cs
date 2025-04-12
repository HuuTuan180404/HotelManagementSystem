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
            connectionString = @"Data Source=.;Initial Catalog=HotelManagementSystem;Integrated Security=True";
        }

    }
}