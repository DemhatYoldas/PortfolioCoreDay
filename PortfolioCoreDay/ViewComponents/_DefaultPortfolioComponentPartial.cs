using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        PortfolioContext Context= new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.Categories.ToList();
            return View(values);
        }
    }
}
