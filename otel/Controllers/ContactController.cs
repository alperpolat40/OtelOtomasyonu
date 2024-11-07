using Microsoft.AspNetCore.Mvc;

namespace otel.Controllers
{
    public class ContactController : Controller
    {
        // GET: /Contact/
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Contact/SendMessage
        [HttpPost]
        public IActionResult SendMessage(string name, string message)
        {
            // Gönderilen iletişim bilgilerini işleyin (örneğin, veritabanına kaydedin veya e-posta gönderin)

            // İletişim gönderimi başarılı olduğunda kullanıcıya bir bildirim göster
            ViewBag.Message = "Mesajınız başarıyla gönderildi.";
            return View("Index");
        }
    }
}
