using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HttpContextRequest.Models;
using HttpContextRequest.Security;

namespace HttpContextRequest.Controllers
{
    public class HomeController : Controller
    {
        private UserDbContext db = new UserDbContext();
        
        public ActionResult Index()
        {
            var requests = new Dictionary<string, string>()
                {
                    {"Raw Url", HttpContext.Request.RawUrl },
                    {"User Host Address", HttpContext.Request.UserHostAddress },
                    {"Browser", HttpContext.Request.Browser.Browser },
                    {"Physical Path", HttpContext.Request.PhysicalPath }
                };
            ViewBag.requests = requests;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}