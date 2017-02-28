using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() //http://localhost:50020/
        {
            return View();
        }
    }
}