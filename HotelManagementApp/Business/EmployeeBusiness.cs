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

    }
}