using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFullStack.Models;

namespace WebFullStack.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public JsonResult Authen(string userName,string password)
        {
            var returnData = new ReturnData();
            try
            {
                if(string.IsNullOrEmpty(userName)
                    || string.IsNullOrEmpty(password))
                {
                    returnData.responseCode = -1;
                    returnData.Description = "Dữ liệu đầu vào không hợp lệ!";
                    return Json(returnData, JsonRequestBehavior.AllowGet);
                }

                // Bước 2: gọi database để kiểm tra xem user có tồn tại không 

                returnData.responseCode = 1;
                returnData.Description = "Đăng nhập thành công";
                return Json(returnData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw;
            }

            return Json(returnData, JsonRequestBehavior.AllowGet);
        }
    }
}