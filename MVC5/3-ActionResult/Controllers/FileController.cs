using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ActionResult.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index() //http://localhost:50020/file
        {
            return View();
        }

        public FileResult Index2() //http://localhost:50020/file/index2
        {
            //return File("~/Content/Sample.doc", "application/msword");

            //return File("~/Content/Sample.doc", "application/msword", "Sample.doc");

            //return File("~/Content/Sample.txt", "text/plain");

            //return File("~/Content/Sample.txt", "text/plain", "Sample.txt");

            return new FilePathResult("~/Content/Sample.txt", "text/plain")
            {
                FileDownloadName = "Sample.txt"
            };
        }

        public FileContentResult Index3() //http://localhost:50020/file/index3
        {
            byte[] bytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/Sample.txt"));

            return File(bytes, "text/plain", "Sample.txt");
        }

        public ActionResult Index4() //http://localhost:50020/file/index4
        {
            var fileStream = new FileStream(Server.MapPath("~/Content/Sample.txt"), FileMode.Open);

            return File(fileStream, "Sample.txt");
        }
    }
}