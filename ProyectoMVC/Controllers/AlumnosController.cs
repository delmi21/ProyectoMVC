using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Db;
using ProyectoMVC.Models;

namespace ProyectoMVC.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly AppDbContext _dbConn;
        public AlumnosController(AppDbContext appDb)
        {
            _dbConn = appDb;
        }
        public IActionResult Index()
        {
            List<Alumnos> alumnos = _dbConn.Alumnos.ToList();
            return View(alumnos);

        }
    }
}
