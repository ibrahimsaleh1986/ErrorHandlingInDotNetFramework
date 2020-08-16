using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication12.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomErrorPage()
        {
            return View();
        }
        public ActionResult ApplicationErrorPage()
        {
            var x = Server.GetLastError();
            return View();
        }
        public ActionResult PageNotFound()
        {
            return View();
        }
        public ActionResult Forbidden()
        {
            return View();
        }
    }
}