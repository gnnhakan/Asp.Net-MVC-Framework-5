using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class HttpController : Controller
    {
        // GET: Http
        public ActionResult Index() //http://localhost:50020/http
        {
            return View();
        }

        // GET: Http
        public HttpStatusCodeResult Index2() //http://localhost:50020/http/index2
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadGateway);

            //return new HttpStatusCodeResult(502);

            //return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "Bad Gateway");


        }

        public HttpNotFoundResult Index3() //http://localhost:50020/http/index3
        {
            //return HttpNotFound();

            return HttpNotFound("Sorry! This page is not found");

            //return new HttpNotFoundResult();
        }

        public HttpUnauthorizedResult Index4() //http://localhost:50020/http/index4
        {
            //return new HttpUnauthorizedResult();

            return new HttpUnauthorizedResult("Not Authenticate");
        }

       
    }
}