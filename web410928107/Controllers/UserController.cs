using System.Web.Mvc;
using web410928107.ViewMpdels;

namespace web410928107.Controllers
{
    public class UserController : Controller
    {
        public ActionResult SignUp()
        {
            return View(new SignUpData());
        }
        [HttpPost]
        // GET: User
        public ActionResult Signup(SignUpData data)
        {
            
           
            if(ModelState.IsValid)
            {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}