using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace ASP.NET_Tesis
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}