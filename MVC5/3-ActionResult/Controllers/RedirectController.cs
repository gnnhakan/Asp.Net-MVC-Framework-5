using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index() //http://localhost:50020/Redirect
        {
            return View();
        }

        public RedirectResult Index2() //http://localhost:50020/Redirect/index2
        {
            //return Redirect("~/view");
            return Redirect("http://google.com");
        }
    }
}