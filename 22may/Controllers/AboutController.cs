using Microsoft.AspNetCore.Mvc;

namespace _22may.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
