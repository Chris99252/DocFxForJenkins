using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocFxForJenkinsDemo.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 入口網頁
        /// </summary>
        /// <returns>首頁</returns>
        public ActionResult Index()
        {
            return View();
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