using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
