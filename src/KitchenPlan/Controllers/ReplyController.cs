using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitchenPlan.Controllers
{
    public class ReplyController : DataController<BlogReply>
    {
        [HttpGet]
        public ActionResult Add(int id)
        {
            return View(id);
        }
        [HttpPost]
        public ActionResult Add(BlogReply reply)
        {
            objSet.AddObject(reply);

            return RedirectToAction("Posts", "Blog");
        }
    }
}
