using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class ContentController : Controller
    {
        
        // GET: Content
        public ContentResult Index2() //http://localhost:50020/content/index2
        {
            //return Content("My ContentResult");
            //return Content("My ContentResult", "text/html; charset=utf-8");
            return Content("My ContentResult", "text/html", Encoding.UTF8);
        }

        public ContentResult Index3() //http://localhost:50020/content/index3
        {
            //return Content("<b>My ContentResult</b>");

            return Content("<b>My ContentResult</b>", "text/plain");
        }

        public ContentResult Index4() //http://localhost:50020/content/index4
        {
            var xml = "<customers>" +
                      "<customer><name> Customer Name1 </name></customer>" +
                      "<customer><name>Customer Name 2 </name></customer>" +
                      "<customer><name>Customer Name 3 </name></customer>" +
                      "<customer><name>Customer Name 4 </name></customer>" +
                      "</customers>";

            return Content(xml, "application/xml");
        }
    }

}