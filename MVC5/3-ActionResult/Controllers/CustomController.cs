using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace _3_ActionResult.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index() //http://localhost:50020/custom
        {
            return View();
        }

        public ActionResult Index2() ////http://localhost:50020/custom/index2
        {
            return new CustomResult();
        }

        public class CustomResult : ActionResult
        {
            public override void ExecuteResult(ControllerContext context)
            {
                context.HttpContext.Response.Write("MyCustomResult");
            }
        }

        public class XmlResult : ActionResult
        {
            private readonly object _data;

            public XmlResult(object data)
            {
                _data = data;
            }

            public override void ExecuteResult(ControllerContext context)
            {
                if (_data != null)
                {
                    var xs = new XmlSerializer(_data.GetType());

                    context.HttpContext.Response.ContentType = "application/xml";

                    xs.Serialize(context.HttpContext.Response.Output, _data);
                }
            }
        }

        public class Customer
        {
            public string Name { get; set; }
            public string SurName { get; set; }
            public string SSN { get; set; }
        }

       
        public ActionResult Index3() //http://localhost:50020/custom/index3
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Name1",
                    SurName = "SurName1",
                    SSN = "SSN1",
                },
                new Customer
                {
                    Name = "Name2",
                    SurName = "SurName2",
                    SSN = "SSN2",
                },
                new Customer
                {
                    Name = "Name3",
                    SurName = "SurName3",
                    SSN = "SSN3",
                }

            };

            return new XmlResult(customers);
        }
    }
}