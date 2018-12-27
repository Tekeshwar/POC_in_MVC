using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace EmployeeService.Security
{
    public class CustomAuthentication : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var auth = actionContext.Request.Headers.Authorization;
            var token = auth.Parameter;
            var json = CrossPlatformAESEncryption.Helper.CryptoHelper.Decrypt(token);
            var user = Newtonsoft.Json.JsonConvert.DeserializeObject<AuthUser>(json);
            if (!(user != null && user.ExpiresAt > DateTime.Now))
            {
                base.OnAuthorization(actionContext);
            }
        }
    }
}