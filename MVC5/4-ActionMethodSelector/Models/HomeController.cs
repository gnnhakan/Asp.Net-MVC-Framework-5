using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_ActionMethodSelector.Models
{
    public class HomeController : Controller
    {

        /// <summary>
        /// bu kısımda ActionMethodlardan 
        ///  --> NonActionName
        ///  --> ActionName
        ///  --> AcceptVerb görüyor olacağız....
        /// </summary>
        /// <returns></returns>
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// ActionName Kullanımı
        ///Eğer index2 yi kendi istediğimiz isimle çağırmak istersek ActionName attributeden faydalanırız. 
        // Özellikle view return etme durumunda. 
        /// </summary>
        /// <returns></returns>

        [ActionName("CustomName")]
        public ActionResult Index2()
        {
            return View();
        }

        // herkes çağırabilir.
        public string ConnectionString()
        {
            return "Myconnection String";
        }


        /// <summary>
        /// NonAction Kullanımı 
        /// Bazi Durumlarda çağırmamiz gerekebilir.NonAction yapmamiz yeterlidir.
        /// </summary>
        /// <returns></returns>
        [NonAction] 
        public string ConnectionString2()
        {
            return "Myconnection String";
        }

        // bu şekilde istek yapılırsa GET türündedir. 
        // POST Yapılırsa istek geçerlidir.
        //Ancak PUT,DELETE,PUT diğer aksiyonlar kabul edilmez. ASP.NET MVC 5 te default değeri sadece Get ve Post istekleri kabul edilir. 
        // Değiştimek için WebConfig e diğer degerleri girebiliriz. 
        public ActionResult MyContent()
        {
            return Content("My Content");
        }

        /// <summary>
        /// AcceptVerb Kullanımı 
        /// Bu şekilde Http istekleklerinide değiştirebiliriz. Ayrıca         [HttpGet],[HttpDelete],[HttpPost] bu şelilde de kullanabiliriz. Ancak AcceptVerb ile birden fazla istek yapabiliriz. 
        /// </summary>
        /// <returns></returns>

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult MyContent2()
        {
            return Content("My Content2");
        }


    }
}