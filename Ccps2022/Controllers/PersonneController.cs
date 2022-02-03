using Ccps2022.Models;
using Microsoft.AspNetCore.Mvc;

using ApplicationDbContext = Ccps2022.Models.ApplicationDbContext;

namespace Ccps2022.Controllers
{
    public class PersonneController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PersonneController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Personne> personne = _db.Personnes;

            return View(personne);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Personne personne)
        {
            _db.Personnes.Add(personne);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
