using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.UCenter.Controllers
{
    public class HomeController : Controller
    {
        // GET: UCenter/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}