using Microsoft.AspNetCore.Mvc;
using Zteam.Data;

namespace Zteam.Controllers
{
    public class CartController : Controller
    {

        public readonly ApplicationDbContext _db;

        public CartController(ApplicationDbContext db) { _db = db; }

        public IActionResult Index()
        {
            return View();
        }


        }
    }
}
