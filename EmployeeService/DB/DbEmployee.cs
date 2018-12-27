using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.DB
{
    public class DbEmployee
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel>();
        public  DbEmployee()
        {
            Employees.Add(new EmployeeModel() { Ename = "Emp-1", Email = "Emp-1@gmail.com", EmpNo = 1, Salary = 100 });
            Employees.Add(new EmployeeModel() { Ename = "Emp-2", Email = "Emp-2@gmail.com", EmpNo = 2, Salary = 200 });
        }

    }
}