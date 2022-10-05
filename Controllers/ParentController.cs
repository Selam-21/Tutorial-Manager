using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class ParentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
