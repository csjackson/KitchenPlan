using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KitchenPlan.Models;

namespace KitchenPlan.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public ActionResult List()
        {
            var list = new List<PantryItem>();
            using (var conn = new System.Data.SqlClient.SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=KitchenPlan;Integrated Security=SSPI;"))
            {
                conn.Open();
                var cmd = new System.Data.SqlClient.SqlCommand("select * from PantryItems", conn);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var row = new PantryItem();
                    row.PantryItemId = rdr.GetInt32(0);
                    row.Description = rdr.GetString(1);
                    list.Add(row);
                }
            }

            return View(list);
        }
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    ViewBag.Title = "Home";
        //    base.OnActionExecuting(filterContext);
        //}
    }
}
