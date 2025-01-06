using ChocoLux.Data;
using ChocoLux.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ChocoLux.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ChocoLuxContext _context;

        public TestimonialController(ChocoLuxContext context)
        {
            _context = context;
        }

        public IActionResult TestimonialCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TestimonialCreate(Testimonial datamodel)
        {
            if (datamodel.TestimonialTitle != null && datamodel.TestimonialDescription != null && datamodel.TestimonialThumbnail != null)
            {
                _context.Add(datamodel);
                _context.SaveChanges();
            }

            return RedirectToAction("TestimonialList");
        }

        public IActionResult TestimonialList()
        {
            var data = _context.Testimonial.Select(
                b => new Testimonial
                {
                    TestimonialId = b.TestimonialId,
                    TestimonialTitle = b.TestimonialTitle,
                    TestimonialThumbnail = b.TestimonialThumbnail,
                    TestimonialIsActive = b.TestimonialIsActive,

                    TestimonialDescription = b.TestimonialDescription != null && b.TestimonialDescription.Length > 150
                    ? b.TestimonialDescription.Substring(0, 150)
                    : b.TestimonialDescription
                }

                ).ToList();

            return View(data);
        }

        public IActionResult TestimonialEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Testimonial = _context.Testimonial.FirstOrDefault(johan => johan.TestimonialId == id);

            return View(Testimonial);
        }

        [HttpPost]
        public IActionResult TestimonialEdit(Testimonial datamodel)
        {
            if (datamodel.TestimonialTitle != null)
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }

            return RedirectToAction("TestimonialList");
        }

        public IActionResult TestimonialDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Testimonial = _context.Testimonial.FirstOrDefault(johan => johan.TestimonialId == id);

            if (Testimonial == null)
            {
                return NotFound();
            }

            _context.Remove(Testimonial);
            _context.SaveChanges();

            return RedirectToAction("TestimonialList");
        }
    }
}
