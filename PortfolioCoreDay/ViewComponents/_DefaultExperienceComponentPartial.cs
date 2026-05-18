using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experinces.ToList();
            return View(values);
        } 
    }
}
