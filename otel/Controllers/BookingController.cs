using Microsoft.AspNetCore.Mvc;

namespace otel.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Manage()
        {
            // Müşterinin rezervasyon bilgilerini getirin
            return View();
        }

        public IActionResult BookRoom(int roomId, DateTime checkInDate)
        {
            // Oda rezervasyon işlemlerini gerçekleştirin
            return RedirectToAction("Manage");
        }
    }
}
