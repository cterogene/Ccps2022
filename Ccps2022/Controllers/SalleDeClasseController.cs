using Microsoft.AspNetCore.Http;
using Ccps2022.Models;
using Ccps2022.Data;
using Microsoft.AspNetCore.Mvc;
using ApplicationDbContext = Ccps2022.Data.ApplicationDbContext;
namespace Ccps2022.Controllers
{
    public class SalleDeClasseController : Controller

    {
        private readonly ApplicationDbContext _db;
        public  SalleDeClasseController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: SalleDeClasseController
        public ActionResult Index()
        {
            IEnumerable<SalleDeClass> salle = _db.SalleDeClasses;
            return View(salle);
            
        }

    }
}
