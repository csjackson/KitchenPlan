using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace KitchenPlan
{
    [MetadataType(typeof(BlogReplyMD))]
    public partial class BlogReply
    {
        public class BlogReplyMD
        {
            [Display(Name="Body")]
            [DataType(DataType.MultilineText)]
            public object BlogReplyText { get; set; }

            [Display(Name="Your Name")]
            public object ReplyBy { get; set; }
            [HiddenInput(DisplayValue=false)]
            public object BlogReplyId { get; set; }

            [HiddenInput(DisplayValue=false)]
            public object BlogPostId { get; set; }
                                  
        }
    }
}
