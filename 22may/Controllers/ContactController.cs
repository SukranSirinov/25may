using Microsoft.AspNetCore.Mvc;

namespace _22may.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
