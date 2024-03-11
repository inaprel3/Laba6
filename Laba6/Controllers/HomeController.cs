// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;

namespace Laba6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}