using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Index() //http://localhost:50020/view/
        {
            return View();
        }

        //viewResult
        public ViewResult Index2() //http://localhost:50020/view/index2
        {
            return View();
            //Parametre vererek çalıştırma.  
            //return View("Index2");
        }

        // Hangi durumlarda action result hangi durumlarda ViewResult Kullanmamiz Gerekir?
        //Gelen değere göre aksiyon almak istiyorsak Action Result kullanılır.
        //public ActionResult Index3()
        //{
        //    if (true)
        //    {
        //        return Redirect("Index");
        //    }
        //    return View();
        //}

         // PartialView ViewResult gibi çalışır. 
         // Sadece tanımlarken PartialView olarak tanımla diyoruz...
        public PartialViewResult Partial() //http://localhost:50020/view/Partial
        {
            return PartialView();
        }

    }
}