using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFullStack.Models;

namespace WebFullStack.Controllers
{
    [Log]
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            var model = new List<StudentInfor>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    model.Add(new StudentInfor { Id = i, Name = "Web ASPNET MVC thầy Quân bài " + i });
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return View(model);
        }

        public ActionResult PartialViewDemo()
        {
            return PartialView();
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
            return Json(null, JsonRequestBehavior.AllowGet);
        }
    }
}