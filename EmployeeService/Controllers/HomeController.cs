using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 0)
        {
            ViewBag.Title = "Home Page";
            var user = new Security.AuthUser();
            user.ExpiresAt = DateTime.Now.AddDays(1);
            if (id > 0)
            {
                user.ExpiresAt = DateTime.Now.AddDays(-1);
            }
            user.Roles = new List<string>();
            user.UserName = "tekesh";
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            var token = CrossPlatformAESEncryption.Helper.CryptoHelper.Encrypt(json);
            ViewBag.Title = token;
            return View();
        }
    }
}
