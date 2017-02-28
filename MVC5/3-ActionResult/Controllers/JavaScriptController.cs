using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class JavaScriptController : Controller
    {
        // GET: JavaScript
        public ActionResult Index() //http://localhost:50020/JavaScript
        {
            return View();
        }

        public JavaScriptResult Alert()
        {
            return JavaScript("alert('Hello world');");
        }
    }
}