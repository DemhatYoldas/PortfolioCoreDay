using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        PortfolioContext Context=new PortfolioContext();
       
        public IViewComponentResult Invoke()
        {
            var values = Context.Testimonials.ToList();
            return View(values);
        }
    }
}
