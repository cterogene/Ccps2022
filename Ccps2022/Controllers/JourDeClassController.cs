using Microsoft.AspNetCore.Mvc;
using Ccps2022.Models;
using ApplicationDbcontext = Ccps2022.Models.ApplicationDbContext;

namespace Ccps2022.Controllers
{
    public class JourDeClassController : Controller
    {
        private readonly ApplicationDbContext _db;
        public JourDeClassController(ApplicationDbContext db)
        {
            _db = db;   
        }
        public IActionResult Index()
        {
            IEnumerable<JoursDeClass> joursDeClasses = _db.JoursDeClasses;
            return View(joursDeClasses);
        }
         public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JoursDeClass joursDeClass)
        {
            _db.JoursDeClasses.Add(joursDeClass);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            if (id == null)
            { return NotFound(); }
            var JourdeClasse = _db.JoursDeClasses.Find(id);
            if(JourdeClasse == null)
                { return NotFound(); }
            return View(JourdeClasse);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(JoursDeClass joursDeClass)
        { _db.JoursDeClasses.Update(joursDeClass);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            { return NotFound(); }
            JoursDeClass joursDeClass = _db.JoursDeClasses.Find(id);
            if (joursDeClass == null)
            { return NotFound(); }

            return View(joursDeClass);

        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JoursDeClass joursDeClass = _db.JoursDeClasses.Find(id);
            _db.JoursDeClasses.Remove(joursDeClass);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            if (id == null)
            { return NotFound(); }
            var joursDeClass = _db.JoursDeClasses.Find(id);
            if (joursDeClass == null)
            { return NotFound(); }

            return View(joursDeClass);
        }
    }
}
