using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesProject.Models;
using System.Collections;

namespace ShoesProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Lay ra 1 tai khoan trong db dua tren username
            /*ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
            account acc = db.accounts.SingleOrDefault(x => x.username == "bedang");
            return View(acc);*/


            // Lay ra danh sach san pham tu db
            ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
            List<sho> listShoes = db.shoes.ToList();


            return View(listShoes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}