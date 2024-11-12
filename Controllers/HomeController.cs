using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TuVanDuHocWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DangKy()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        public ActionResult HocBong()
        {
            return View();
        }
        public ActionResult Hocbonguc()
        {
            return View();
        }
        public ActionResult TinTuc()
        {
            return View();
        }
        public ActionResult GocTuVan()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult DuhocUc()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Sukien()
        {
            return View();
        }
    }
}