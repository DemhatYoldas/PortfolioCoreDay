using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
