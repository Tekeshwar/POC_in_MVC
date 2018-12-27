using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.Security
{
    public class AuthUser
    {
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}