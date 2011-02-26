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

        public ActionResult List()
        {
            List<PantryItem> list;

            using (var context = new KitchenPlanEntities())
            {
                var os = context.CreateObjectSet<PantryItem>();
                var query = from pi in os where pi.Description.StartsWith("R") select pi;
                list = query.ToList();

            }
            return View(list);
        }
    

        public ActionResult Alpha()
        {
            List<PantryItem> list;
            using (var context = new KitchenPlanEntities())
            {
                var os = context.CreateObjectSet<PantryItem>();
                var query = from pi in os orderby(pi.Description) select pi;
                list = query.ToList();
            }
            return View(list);
        }
        public ActionResult Scramble()
      {
            List<PantryItem> list;
            using (var context = new KitchenPlanEntities())
            {
                var os = context.CreateObjectSet<PantryItem>();
                var query = from pi in os select pi;
                list = query.ToList();
            }
      }
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    ViewBag.Title = "Home";
        //    base.OnActionExecuting(filterContext);
        //}
    }
}
