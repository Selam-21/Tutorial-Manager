using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class TeacherRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
