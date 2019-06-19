using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace ASP.NET_Tesis
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public ActionResult Validate(User u)
        {
            if (u.Email == "admin"){
                if (u.Password == "1234"){
                    return Json(new { status = true, message = "Login Successfull!"});
                }
                return Json(new { status = false, message = "Invalid Password!"});
            }
            return Json(new { status = false, message = "Invalid Email!"});
        }
    }
    

    
}