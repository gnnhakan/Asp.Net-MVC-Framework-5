using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class RedirectToRouteController : Controller
    {
        // GET: RedirectToRoute
        public ActionResult Index() //http://localhost:50020/RedirectToRoute
        {
            return View();
        }

        public RedirectToRouteResult Index2() //http://localhost:50020/RedirectToRoute/index2
        {

            //Uygulama içersinde yönlendirme yapmak için

            //return RedirectToAction("Index"); /// ViewRedirect altındaki index calışır.

            //return RedirectToAction("Index", "View"); /// View Altindaki Index çalışır.

            //return RedirectToAction("Index", new { controller = "View", id = 2 }); //anonymous type tanıımlama yapabiliriz. olarak App_Start RouteConfig.cs kontrol ederseniz bu kismi görebilirsiniz.. 

            //return RedirectToAction("Index", new RouteValueDictionary() // Dictionary olarak set edebiliriz.
            //{
            //    { "controller", "View" }, 
            //    { "id", "3" }
            //});
            return RedirectToRoute("Default", new { controller = "View", action = "Index" });
        }
    }
}