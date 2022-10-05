using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
