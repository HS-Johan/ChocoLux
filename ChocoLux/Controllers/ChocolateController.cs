using ChocoLux.Data;
using ChocoLux.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace ChocoLux.Controllers
{
    public class ChocolateController : Controller
    {
        private readonly ChocoLuxContext _context;

        public ChocolateController(ChocoLuxContext context)
        {
            _context = context;
        }

        public IActionResult ChocolateForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChocolateForm(Chocolate datamodel)
        {
            if (datamodel.ChocolateName != null)
            {
                _context.Add(datamodel);
                _context.SaveChanges();
            }

            return RedirectToAction("ChocolateList");
        }

        public IActionResult ChocolateList()
        {
            var data = _context.Chocolate.ToList();

            return View(data);
        }

        public IActionResult ChocolateEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Chocolate.FirstOrDefault(johan => johan.ChocolateId == id);

            return View(product);
        }

        [HttpPost]
        public IActionResult ChocolateEdit(Chocolate datamodel)
        {
            if (datamodel.ChocolateName != null)
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }

            return RedirectToAction("ChocolateList");
        }

        public IActionResult ChocolateDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Chocolate = _context.Chocolate.FirstOrDefault(johan => johan.ChocolateId == id);

            if (Chocolate == null)
            {
                return NotFound();
            }

            _context.Remove(Chocolate);
            _context.SaveChanges();

            return RedirectToAction("ChocolateList");
        }
    }
}
