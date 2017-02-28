using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class JsonController : Controller
    {
        public class Customer
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string SSN { get; set; }
        }

        // GET: Json
        public ActionResult Index() //http://localhost:50020/json/
        {
            return View();
        }

        // GET: Json
        public JsonResult Index2() //http://localhost:50020/json/index2
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Name",
                    Surname = "Surname",
                    SSN = "456654N"
                },
                new Customer
                {
                     Name = "Name",
                    Surname = "Surname",
                    SSN = "103456C"
                },
                new Customer
                {
                     Name = "Name",
                    Surname = "Surname",
                    SSN = "025456F"
                },
                     new Customer
                {
                     Name = "Name",
                    Surname = "Surname",
                    SSN = "120456G"
                }
            };

            return Json(customers, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }
    }
}