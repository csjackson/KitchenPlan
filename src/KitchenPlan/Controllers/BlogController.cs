using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitchenPlan.Controllers
{
    public class BlogController : DataController<BlogPost>
    {
        //
        // GET: /Blog/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Post()
        {
            return View(objSet.ToList());
        }

    }
}
