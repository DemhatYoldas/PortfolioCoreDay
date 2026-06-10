using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultMyProjectComponentPartial: ViewComponent
    {
         PortfolioContext Context= new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= Context.Portfolios.ToList();
            return View(values);
        }
    }
}
