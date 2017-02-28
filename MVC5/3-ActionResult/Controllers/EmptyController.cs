using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class EmptyController : Controller
    {
        // GET: Empty
        public ActionResult Index() //http://localhost:50020/empty
        {
            return View();
            //Empty return null..
            return null;
        }

        public ActionResult Index2() ////http://localhost:50020/empty/index2
        {
            if (!User.Identity.IsAuthenticated)
                return new EmptyResult();

            return Content("Hello World!");
        }

        public void Index3()
        {
            //
        }

       

    }
}