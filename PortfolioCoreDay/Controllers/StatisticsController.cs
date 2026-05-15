using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.vCount=context.Skills.Count();
            ViewBag.vSum=context.Skills.Sum(x=>x.SkillValue);
            ViewBag.vAvg=context.Skills.Average(x=>x.SkillValue);
            ViewBag.vMax=context.Skills.Where(x=>x.SkillValue>80).Count();
            return View();
        }
    }
}
