using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KitchenPlan
{
    [MetadataType(typeof(BlogPostMD))]
    public partial class BlogPost
    {
        public class BlogPostMD
        {
            [Display(Name="Body")]
            [DataType(DataType.MultilineText)]
            public object PostText { get; set; }
            [Display(Name="Date Created")]
            public object PostDate { get; set; }
            [Display(Name="Title")]
            public object PostTitle { get; set; }
        }
    }
}