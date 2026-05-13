using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult TestimonialListe()
        {
            var values=context.Testimonials.ToList();
            return View(values);
            // sayfa yenilenmesiyle beraber verilerde gelsin 
        }

        [HttpGet]
          public IActionResult CreateTestimonial()
        {
            return View();
        }


        [HttpPost]
        public IActionResult PostTestimonial(Testimonial testimonial) 
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialListe");
        }
    }
}
