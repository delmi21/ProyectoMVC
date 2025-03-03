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
        
        [HttpGet]
        public IActionResult UpSert(int id)
        {

            if (id == 0)
            {
                Alumnos alumno = new();
                return View(alumno);
            }
            else
            {
                Alumnos alumno = _dbConn.Alumnos.FirstOrDefault(row => row.AlumnoId == id) ?? new();
                    return View(alumno);
            }
                
        }
        [HttpPost]
        public IActionResult UpSert(Alumnos model)
        {
            if (model.AlumnoId == 0)
            {
                if(ModelState.IsValid)
                    {
                    _dbConn.Alumnos.Add(model);
                    _dbConn.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            else
            {
                if (ModelState.IsValid)
                {
                    _dbConn.Alumnos.Update(model);
                    _dbConn.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
                return View("model");
                
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Alumnos alumno = _dbConn.Alumnos.FirstOrDefault(row => row.AlumnoId == id) ?? new();
            alumno.IsActive = false;
            _dbConn.Alumnos.Update(alumno);
            _dbConn.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}
    
