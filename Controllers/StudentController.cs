using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
