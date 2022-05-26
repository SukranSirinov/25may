using Microsoft.AspNetCore.Mvc;

namespace _22may.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
