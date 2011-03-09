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
        public ActionResult NewPost(int? id)
        {
            var entry = objSet.FirstOrDefault(qq => qq.BlogPostId == id.Value);
            if (entry == null)
                entry = new BlogPost();
            return View(entry);
        }
        [HttpPost]
        public ActionResult NewPost(BlogPost post)
        {
            var entry = objSet.FirstOrDefault(qq => qq.BlogPostId == post.BlogPostId);
            if (entry == null)
                objSet.AddObject(post);
            else
            {
                entry.BlogPostId = post.BlogPostId;
                entry.PostDate = post.PostDate;
                entry.PostTitle = post.PostTitle;
                entry.PostText = post.PostText;
            }
            return RedirectToAction("Posts", "Blog");
        }
        public ActionResult ReplyView(int? id)
        {
            var reply = objSet.Include("BlogReplies").FirstOrDefault(qq => qq.BlogPostId == id.Value);
            return View(reply);
        }
    }    
}
