using Microsoft.AspNetCore.Mvc;
using otel.Models;

namespace otel.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Details(int id)
        {
            // Model'den oda bilgilerini çek
            Room room = GetRoomById(id); // Bu, modelden veri getirmek için örnek bir metot
            return View(room);
        }

        private Room GetRoomById(int id)
        {
            // Bu metot, belirtilen oda ID'sine göre veri getirecek şekilde düzenlenmelidir.
            return new Room { Id = id, Name = "Deluxe Oda", Price = 200, Description = "Geniş ve konforlu" };
        }
    }
}
