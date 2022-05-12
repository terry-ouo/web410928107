using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410928107.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Signup(string name, string account, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (string.IsNullOrWhiteSpace(account))
            {
                ViewBag.AccountMessage = "請輸入帳號";
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }
            if(!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(account) && !string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Message = "註冊成功";
            }
            return View();
        }
    }
}