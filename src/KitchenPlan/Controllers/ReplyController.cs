using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitchenPlan.Controllers
{
    public class ReplyController : DataController<BlogPost> 
    {
        [HttpGet]
        public ActionResult Add(int id)
        {
            return View(id);
        }
        [HttpPost]
        public ActionResult Add(BlogPost post)
        {
            objSet.AddObject(post);

            return RedirectToAction("Post", "Blog");
        }
    
    }
}
