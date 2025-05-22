using Microsoft.AspNetCore.Mvc;

namespace SPORTS_STORE.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
