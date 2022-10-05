using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class StudentRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
