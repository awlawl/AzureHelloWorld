using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace AzurePaasTest2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            ViewBag.ProfileUserName = Profile.UserName;
            ViewBag.ContextRequestLogonUserIdentity = JsonConvert.SerializeObject(HttpContext.Request.LogonUserIdentity, Formatting.Indented);
            if (HttpContext.Request.LogonUserIdentity!=null)
                ViewBag.ContextRequestLogonUserIdentityName = HttpContext.Request.LogonUserIdentity.Name;
            else
            {
                ViewBag.ContextRequestLogonUserIdentityName = "HttpContext.Request.LogonUserIdentity is null";
            }

            ViewBag.User = User;
            ViewBag.ConfigValue = ConfigurationManager.AppSettings["TestConfigSetting"];
            

            return View();
        }

    }
}
