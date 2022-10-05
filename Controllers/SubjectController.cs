using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
