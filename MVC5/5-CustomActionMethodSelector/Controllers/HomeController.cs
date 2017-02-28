using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace _5_CustomActionMethodSelector.Controllers
{
    public class HomeController : Controller
    {
        public class Customer
        {
            public string CustomerName { get; set; }
            public string CustomerSurName { get; set; }
            public string SSN { get; set; }
        }

        /// <summary>
        /// CustomAjax Selector
        /// </summary>
        /// Yazacağımız custom Method ActionMethodSelectorAttribute den implemante edilmesi gerekiyor..
        /// <returns></returns>
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }

        public class MyCustomAjaxMethodAttribute : ActionMethodSelectorAttribute
        {
            public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
            {
                return controllerContext.HttpContext.Request.IsAjaxRequest();
            }
        }

        [MyCustomAjaxMethod]
        public JsonResult GetCustomer()
        {
            var customers = new List<Customer>
            {
                new Customer()
                {
                    CustomerName = "CustomerName",
                    CustomerSurName ="CustomerSurName",
                    SSN = "123456"
                },
                new Customer
                {
                      CustomerName = "CustomerName2",
                    CustomerSurName ="CustomerSurName2",
                    SSN = "1234562"
                },
            };

            return Json(customers, JsonRequestBehavior.AllowGet);
        }
    }
}