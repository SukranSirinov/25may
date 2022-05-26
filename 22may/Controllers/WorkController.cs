using Microsoft.AspNetCore.Mvc;

namespace _22may.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
