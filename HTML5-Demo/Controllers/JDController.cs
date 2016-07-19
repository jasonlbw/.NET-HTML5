using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class JDController : Controller
    {
        /// <summary>
        /// 导航
        /// </summary>
        /// <returns></returns>
        public ActionResult Nav()
        {
            return View();
        }

        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 购物车
        /// </summary>
        /// <returns></returns>
        public ActionResult Cart()
        {
            return View();
        }


        /// <summary>
        /// 频道
        /// </summary>
        /// <returns></returns>
        public ActionResult Category()
        {
            return View();
        }

    }
}
