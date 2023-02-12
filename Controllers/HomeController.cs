using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartIdentity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (SmartIdentityEntities db = new SmartIdentityEntities())
            {
                var data = db.persons.FirstOrDefault();
                return View(data);
            }
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