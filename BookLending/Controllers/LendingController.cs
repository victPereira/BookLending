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

        // Metodo GET - Pegando informacoes da base de dados
        public IActionResult Index()
        {
            IEnumerable<LendingModel> lendings = _db.Lending;
            return View(lendings);
        }

        // Metodo GET - Pegando simplesmente a pagina Register no click e mostra a tela
        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            LendingModel lending = _db.Lending.FirstOrDefault(x => x.Id == id);

            if(lending == null) 
            {
                return NotFound();
            }

            return View(lending);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            LendingModel lending = _db.Lending.FirstOrDefault(x => x.Id == id);

            if (lending == null)
            {
                return NotFound();
            }

            return View(lending);
        }



        [HttpPost]
        public IActionResult Register(LendingModel lending) 
        { 
            if (ModelState.IsValid)
            { 
                _db.Lending.Add(lending);
                _db.SaveChanges();

                TempData["MessageSuccess"] = "Registration completed successfully!";

                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpPost]
        public IActionResult Edit(LendingModel lending)
        {
            if(ModelState.IsValid)
            {
                _db.Lending.Update(lending);
                _db.SaveChanges();

                TempData["MessageSuccess"] = "Edit completed successfully!";

                return RedirectToAction("Index");
            }


            return View(lending); 
        }

        [HttpPost]
        public IActionResult Delete(LendingModel lending)
        { 
            if (lending == null)
            {
                return NotFound();
            }

            _db.Lending.Remove(lending);
            _db.SaveChanges();

            TempData["MessageSuccess"] = "Removal completed successfully!";

            return RedirectToAction("Index");
        }
    }
}
