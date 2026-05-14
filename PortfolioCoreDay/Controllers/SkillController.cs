using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult SkillList()
        {
            return View();
        }
    }
}
