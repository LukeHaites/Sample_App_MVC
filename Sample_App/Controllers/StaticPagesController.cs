using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_App.Controllers
{
    public class StaticPagesController : Controller
    {
        //
        // GET: /StaticPages/

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
