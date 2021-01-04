using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LGUPlusCommon;

namespace HomePageWebApplication.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 메인 페이지 호출 액션 메소드
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //사용자 
            UserServices service = new UserServices();
            var user = service.GetUserData("youjin");
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