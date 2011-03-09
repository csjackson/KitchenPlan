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
        public ActionResult AddReply(int? replyId, int post)
        {
            var entry = objSet.FirstOrDefault(qq => qq.BlogReplyId == replyId.Value);
            if (entry == null)
                entry = new BlogReply();
            entry.BlogPostId = post;
            return View(entry);
        }
        [HttpPost]
        public ActionResult AddReply(BlogReply reply)
        {
            var entry = objSet.FirstOrDefault(qq => qq.BlogReplyId == reply.BlogReplyId);
            if (reply == null)
                objSet.AddObject(reply);
            else if (reply.BlogReplyId.Equals(0))
            {
                entry.BlogPostId = reply.BlogPostId;
                entry.ReplyBy = reply.ReplyBy;
                entry.BlogReplyText = reply.BlogReplyText;
            }
            else
            {
                entry.BlogReplyId = reply.BlogReplyId;
                entry.BlogPostId = reply.BlogPostId;
                entry.ReplyBy = reply.ReplyBy;
                entry.BlogReplyText = reply.BlogReplyText;
            }

            return RedirectToAction("Posts", "Blog");
        }
    }
}
