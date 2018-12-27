using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace EmployeeService.Security
{
    public class Result : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var objectContent = actionExecutedContext.Response.Content as ObjectContent;
            if (objectContent != null)
            {
                DateTime req = (DateTime)HttpContext.Current.Items["ReqTime"];
                var type = objectContent.ObjectType; //type of the returned object
                var value = objectContent.Value; //holding the returned value
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(value);
                var payload = CrossPlatformAESEncryption.Helper.CryptoHelper.Encrypt(json);
                var resp = new FinalResponse();
                resp.Status = "Ok";
                resp.Payload = payload;
                resp.TimeTaken = DateTime.Now.Subtract(req);
                actionExecutedContext.Response.Content = new ObjectContent<FinalResponse>(resp, new System.Net.Http.Formatting.JsonMediaTypeFormatter());
            }
        }
    }

    public class FinalResponse
    {
        public string Status { get; set; }
        public List<string> Errors { get; set; }

        public TimeSpan TimeTaken { get; set; }
        public object Payload { get; set; }
    }
}