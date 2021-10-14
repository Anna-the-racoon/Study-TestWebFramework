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
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Login, string Password)
        {
            if (!ModelState.IsValid) return View("Index");

            var security = new Security() 
            { Login = Login,
              Password = Password };

            return View("Result", security); 
        }


        [HttpPost]
        [ActionName("Submit")]
        public ActionResult Result()
        {
            return View("Result", new Security() { Login = "1", Password = "10" }) ;
        }

    }
}