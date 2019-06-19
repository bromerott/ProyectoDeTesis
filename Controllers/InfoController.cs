using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace ASP.NET_Tesis
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}