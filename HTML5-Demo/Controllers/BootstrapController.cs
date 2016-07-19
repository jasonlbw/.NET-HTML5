using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class BootstrapController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 3.4表格
        /// </summary>
        /// <returns></returns>
        public ActionResult Table()
        {
            return View();
        }

        /// <summary>
        /// 3.5表单
        /// </summary>
        /// <returns></returns>
        public ActionResult Form()
        {
            return View();
        }

        /// <summary>
        /// 3.6按钮
        /// </summary>
        /// <returns></returns>
        public ActionResult Button()
        {
            return View();
        }

        /// <summary>
        /// 3.7图像
        /// </summary>
        /// <returns></returns>
        public ActionResult Image()
        {
            return View();
        }
    }
}
