using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomePage.Controllers
{
    public class HomeController : Controller
    {
        //123 456  123  123
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}