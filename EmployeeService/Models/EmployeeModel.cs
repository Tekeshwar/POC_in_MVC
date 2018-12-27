using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    public class EmployeeModel
    {
        public int EmpNo { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; } 
    }
}