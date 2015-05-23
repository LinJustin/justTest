using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class WhoamiController : Controller
    {
        //
        // GET: /Whoami/

        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = name;
            ViewBag.Id = id;
            return View();

            //return HttpUtility.HtmlEncode("Hello " + name + ", id: " + id);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
