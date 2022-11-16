using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFullStack.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("id1")]
        public ActionResult Index1()
        {
            return View();
        }

        [NonAction]
        public ActionResult Index1(string id)
        {
            return Json(null,JsonRequestBehavior.AllowGet);
        }
    }
}