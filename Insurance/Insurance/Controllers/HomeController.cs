using Insurance.DAL.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new DatabaseContext())
            {
                var stud = new User() { Username = "Bill" };
                ctx.User.Add(stud);
                ctx.SaveChanges();
            }
            
            return View();
        }
    }
}