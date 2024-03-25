using Microsoft.AspNetCore.Mvc;
using Zteam.Data;
using Zteam.Models;

namespace Zteam.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LibraryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult AllGame()
        {
            IEnumerable<Game> game = _db.Game;
            return View(game);
        }
    }
}