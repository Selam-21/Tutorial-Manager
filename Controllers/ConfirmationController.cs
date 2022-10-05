using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class ConfirmationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
