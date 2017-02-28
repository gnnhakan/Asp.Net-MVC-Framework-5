using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace _6_CustomActionNameSelector.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home
        public ViewResult Index()
        {
            return View(); 
        }

        /// <summary>
        /// CustomActionName ActionNameSelectorAttribute den implemante ediyoruz. 
        /// Bu örnekte action Name uzunlugunu
        /// </summary>
        public class ActionLengthAttribute : ActionNameSelectorAttribute
        {
            private readonly int _length;

            public ActionLengthAttribute(int length)
            {
                _length = length;
            }

            public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
            {
                return actionName.Length <= _length;
            }
        }

        [ActionLength(7)]
        public ActionResult Test1()
        {
            return Content("Sample"); // return edilen değer 5 hane ben yukarda 3 set ettim. 3 vee 3 den kucukse ise calısak.. Yani bu çalışmayacaktir. 
        }

        
        //ActionNameSelector ile ActionMethodSelector Arasındaki Farklar
        // --> aynı nesneleri elde edilmesine rağmen birbirine karıştırmamak gerekir. 
        // Birbirinin yerine kullansa bile hatasız çalışır. ancak ayırt etmemiz gerekir.
        // Bu konuda MVC nin çalışması gözardı edilmemelidir. 
        // MVC çalışma yapısında Route mekanizması mevcuttur. Burda Uygun aksiyon kontrol edilir. Seçilen aksiyon içersinde filtreleme yapılır(ActionMethod Secimi de burda yapılır.).

        // CustomActionMethodSelector veya ActionNameSelector Tanımlarken iki soruyu kendimize sormalıyız
         //1- Aksiyon Seçimi
         //2- Seçilen Aksiyonun Filtrelenmesi....
     
    }
}