using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFullStack.Models;

namespace WebFullStack.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return RedirectToAction("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ListStudentPartial(int? ClassId)
        {
            var lstmodel = new List<StudentInfor>();
            try
            {
                var lst = DB.DataAccess.SqlDbHelper.GetStudentByClassId(Convert.ToInt32(ClassId));
                if (lst != null && lst.Count > 0)
                {
                    foreach (var item in lst)
                    {
                        lstmodel.Add(new StudentInfor
                        {
                            id = item.id,
                            StudentName = item.StudentName,
                            StudentClassID = item.StudentClassID,
                            StudentCode = item.StudentCode,
                            StudentAddress = item.StudentAddress
                        });
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return PartialView(lstmodel);
        }
    }
}