using DemoStore.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoStore.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ChangeType()
        {
            try
            {
                string strTypeMode = Request.Form["typeid"].ToString();

                VarsHelper.Mode = strTypeMode;

                return RedirectToAction("Index","Product");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}