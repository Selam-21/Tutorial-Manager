using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
