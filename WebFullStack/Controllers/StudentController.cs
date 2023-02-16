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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PartialViewDemo()
        {
            return PartialView();
        }


        [HttpPost]
        public JsonResult GetDataForm(string abc)
        {
            var returnData = new ReturnData();
            if (string.IsNullOrEmpty(abc))
            {
                returnData.responseCode = -1;
                returnData.Description = "Dữ liệu không được trống";
                return Json(returnData, JsonRequestBehavior.AllowGet);

            }

            if (!CheckXSSInput(abc))
            {
                returnData.responseCode = -2;
                returnData.Description = "Dữ liệu không hợp lệ";
                return Json(returnData, JsonRequestBehavior.AllowGet);
            }
            returnData.responseCode = 1;
            returnData.Description = "Dữ liệu hợp lệ";
            return Json(returnData, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [ActionName("id1")]
        public ActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentInsertUpdate(ProductEditModels models)
        {
            if (!ModelState.IsValid)
            {

            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        public static bool CheckXSSInput(string input)
        {
            try
            {
                var listdangerousString = new List<string> { "<applet", "<body", "<embed", "<frame", "<script", "<frameset", "<html", "<iframe", "<img", "<style", "<layer", "<link", "<ilayer", "<meta", "<object", "<h", "<input", "<a", "&lt", "&gt" };
                if (string.IsNullOrEmpty(input)) return false;
                foreach (var dangerous in listdangerousString)
                {
                    if (input.Trim().ToLower().IndexOf(dangerous) >= 0) return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}