using Microsoft.AspNetCore.Mvc;
using SitePessoalMVC.Domain.Entities;
using SitePessoalMVC.Infraestrutura;

namespace SitePessoalMVC.Controllers
{
    public class CursoController : Controller
    {
        private readonly SitePessoalDbContext _db;

        public CursoController(SitePessoalDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cursos = _db.Cursos.ToList();
            return View(cursos);
        }

        [HttpPost]
        public IActionResult Add(Curso curso)
        {
            var cursos = _db.Cursos.Add(curso);
            _db.SaveChanges();

            return View(cursos.Entity);
        }
    }
}
