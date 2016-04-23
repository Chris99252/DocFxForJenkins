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

        /// <summary>
        /// 關於我們
        /// </summary>
        /// <returns>關於頁面</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// 聯絡我們
        /// </summary>
        /// <returns>聯絡頁面</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}