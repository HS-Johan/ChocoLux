using Microsoft.AspNetCore.Mvc;

namespace ChocoLux.Controllers
{
    public class ChocoLuxController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Chocolates()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
