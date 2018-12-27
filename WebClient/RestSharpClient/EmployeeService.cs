using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Models;

namespace WebClient.RestSharpClient
{
    public class EmployeeService
    {
        private const string hostUrl = "http://localhost:1495/Emp";
        public List<EmployeeModle> GetEmployee()
        {
            //List<EmployeeModle> employees = new List<EmployeeModle>();
            var client = new RestClient(hostUrl);
            var request = new RestRequest();
            RestResponse<List<EmployeeModle>> responce = (RestResponse<List<EmployeeModle>>)client.Execute<List<EmployeeModle>>(request);
            
            return null;
            
        }
    }
}