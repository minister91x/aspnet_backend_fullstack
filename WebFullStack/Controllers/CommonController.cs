using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFullStack.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HeaderPartial()
        {
            return PartialView();
        }

        public ActionResult LeftMenuPartial()
        {
            // xử lý lấy dữ liệu trong database và trẻ về partialView
            return PartialView();
        }

        public ActionResult FooterPartial()
        {
            return PartialView();
        }
    }
}