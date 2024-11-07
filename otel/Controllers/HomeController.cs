using Microsoft.AspNetCore.Mvc;

namespace otel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

