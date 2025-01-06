using ChocoLux.Data;
using ChocoLux.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChocoLux.Controllers
{
    public class ChocoLuxController : Controller
    {
        private readonly ChocoLuxContext _context;

        public ChocoLuxController(ChocoLuxContext context)
        {
            _context = context;
        }

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
            var data = _context.Testimonial.ToList();

            return View(data);
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactUs datamodel)
        {
            if (datamodel.ContactName != null && datamodel.ContactPhone != null && datamodel.ContactEmail != null)
            {
                _context.Add(datamodel);
                _context.SaveChanges();
            }

            return RedirectToAction("ContactUs");
        }

        public IActionResult ContactList()
        {
            var data = _context.ContactUs.ToList();

            return View(data);
        }

        public IActionResult ContactEdit(int? id)
        {
            var data = _context.ContactUs.FirstOrDefault(johan => johan.ContactId == id);

            return View(data);
        }

        [HttpPost]
        public IActionResult ContactEdit(ContactUs datamodel)
        {
            if (datamodel.ContactName != null && datamodel.ContactPhone != null && datamodel.ContactEmail != null)
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }

            return RedirectToAction("ContactList");
        }


        public IActionResult ContactDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = _context.ContactUs.FirstOrDefault(johan => johan.ContactId == id);

            if (data == null)
            {
                return NotFound();
            }

            _context.Remove(data);
            _context.SaveChanges();

            return RedirectToAction("ContactList");
        }
    }
}
