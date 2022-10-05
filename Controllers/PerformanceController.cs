using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class PerformanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
