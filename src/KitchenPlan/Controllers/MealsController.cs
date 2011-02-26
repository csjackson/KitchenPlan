using System;
using System.Web.Mvc;

namespace KitchenPlan.Controllers
{
    public class MealsController : DataController<PlannedMeal>
    {
        [HttpGet]
        public ActionResult Add(int id)
        {
            return View(id);
        }
        [HttpPost]
        public ActionResult Add(PlannedMeal meal)
        {
            objSet.AddObject(meal);
            
            return RedirectToAction("List", "Home");
        }
    }
}
