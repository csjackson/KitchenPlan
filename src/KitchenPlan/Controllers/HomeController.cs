using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitchenPlan.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
        public ActionResult About()
        {
           ViewBag.Title = "Home";
            return View();
        }
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    ViewBag.Title = "Home";
        //    base.OnActionExecuting(filterContext);
        //}
    }
}
