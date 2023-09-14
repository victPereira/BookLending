using BookLending.Data;
using BookLending.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLending.Controllers
{
    public class LendingController : Controller
    {

        readonly private ApplicationDbContext _db;

        public LendingController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<LendingModel> lendings = _db.Lending;
            return View(lendings);
        }
    }
}
