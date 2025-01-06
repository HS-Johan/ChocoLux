using Microsoft.AspNetCore.Mvc;

namespace ChocoLux.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
