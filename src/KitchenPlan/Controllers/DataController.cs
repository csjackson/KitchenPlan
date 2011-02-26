using System;
using System.Web.Mvc;
using System.Data.Objects;

namespace KitchenPlan.Controllers
{
    public abstract class DataController<T> : Controller where T : class
    {
        protected ObjectSet<T> objSet;
        protected KitchenPlanEntities context ;
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            context = new KitchenPlanEntities();
            objSet = context.CreateObjectSet<T>();
            base.OnActionExecuting(filterContext);

        }
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (context != null && filterContext.Exception == null)
                context.SaveChanges();
            if (context != null)
                context.Dispose();
            base.OnActionExecuted(filterContext);
        }
    }
}
