using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Objects;

namespace KitchenPlan.Controllers
{
    public class HomeController : DataController<PantryItem>
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
            return View(objSet.Include("PlannedMeals").ToList());
        }
     

        public ActionResult Alpha()
        {
            return View(objSet.OrderBy(pi => pi.Description).ToList());
        }
     /*   public ActionResult Scramble()
      {
            List<PantryItem> list;
            using (var context = new KitchenPlanEntities())
            {
                var os = context.CreateObjectSet<PantryItem>();
                var query = from pi in os select pi;
                list = query.ToList();
            }
      }
*/        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    ViewBag.Title = "Home";
        //    base.OnActionExecuting(filterContext);
        //}
    }
}
