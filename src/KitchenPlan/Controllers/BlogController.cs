using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitchenPlan.Controllers
{
    public class BlogController : DataController<BlogPost>
    {
        public ActionResult Index()
        {
            return RedirectToAction("Posts", "Blog");
        }
        
        public ActionResult Posts()
        {
            return View(objSet.Include("BlogReplies").ToList());
        }

        [HttpGet]
        public ActionResult NewPost(int id)
        {
            return View(id);
        }
        [HttpPost]
        public ActionResult NewPost(BlogPost post)
        {
            objSet.AddObject(post);

            return RedirectToAction("Posts", "Blog");
        }
    }    
}
