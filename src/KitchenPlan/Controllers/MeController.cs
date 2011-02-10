using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitchenPlan.Controllers
{
    public class MeController : Controller
    {
        //
        // GET: /Me/

        public ActionResult Bio()
        {
            ViewBag.Title = "Bio";
            return View();
        }
        public ActionResult HeadShot()
        {
            ViewBag.Title = "HeadShot";
            return View();
        }
    }
}
