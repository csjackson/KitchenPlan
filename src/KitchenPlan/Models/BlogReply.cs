using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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
                                  
        }
    }
}
