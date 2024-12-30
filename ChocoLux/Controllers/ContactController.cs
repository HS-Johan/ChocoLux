using Microsoft.AspNetCore.Mvc;

namespace ChocoLux.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
