using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        //[HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to admin parth";

            return View();
        }

    }
}