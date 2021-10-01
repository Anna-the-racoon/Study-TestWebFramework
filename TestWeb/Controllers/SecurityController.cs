using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Security());
        }

        [HttpPost]
        public ActionResult Index(string login, string password)
        {
            //if (login.Length == 0 && password.Length == 0) return HttpNotFound(); ;

            return View();
        }

        [HttpPost]
        public ActionResult Index(Security view)
        {

            //if (view.Login.Length == 0 && view.Password.Length == 0) return HttpNotFound(); ;

            return View(view);
        }

        [HttpGet]
        public ActionResult Result(Security view)
        {
            return View(view);
        }
    }
}