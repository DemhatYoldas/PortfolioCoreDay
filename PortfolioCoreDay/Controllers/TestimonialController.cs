using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult TestimonialListe()
        {
            var values = context.Testimonials.ToList();
            return View(values);
            // sayfa yenilenmesiyle beraber verilerde gelsin 
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialListe");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialListe");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialListe");

        }
    }
}
