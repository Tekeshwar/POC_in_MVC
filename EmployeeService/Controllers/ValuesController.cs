using EmployeeService.DB;
using EmployeeService.Models;
using EmployeeService.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    [Route("Emp")]
    [EmployeeService.Security.Result]
    public class ValuesController : ApiController
    {
        // GET api/values
        [CustomAuthentication]
        public IEnumerable<EmployeeModel> Get()
        {
            List<EmployeeModel> Employees = new List<EmployeeModel>();
            Employees.Add(new EmployeeModel() { Ename = "Emp-1", Email = "Emp-1@gmail.com", EmpNo = 1, Salary = 100 });
            Employees.Add(new EmployeeModel() { Ename = "Emp-2", Email = "Emp-2@gmail.com", EmpNo = 2, Salary = 200 });
            return Employees;
        }

        // GET api/values/5
        public EmployeeModel Get(int id)
        {
            return DbEmployee.Employees.Where(x=> x.EmpNo==id).SingleOrDefault();
        }

        // POST api/values
        public void Post([FromBody]EmployeeModel value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]EmployeeModel value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
