using Microsoft.AspNetCore.Mvc;
using Zteam.Data;
using Zteam.Models;
using static Azure.Core.HttpHeader;

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
        public IActionResult GameDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game game = _db.Game.FirstOrDefault(g => g.GameId == id);

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }
    }

}