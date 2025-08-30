
using Microsoft.AspNetCore.Mvc;
using MiServicioWeb.Data;
using Universidad.Models;
using System.Collections.Generic;
using System.Linq;
using Universidad; // Replace 'YourNamespace.Models' with the actual namespace where AppDbContext is defined

namespace MiServicioWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstudiantesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Estudiante>> GetEstudiantes()
        {
            return _context.Estudiantes.ToList();
        }

        [HttpPost]
        public ActionResult<Estudiante> PostEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEstudiantes), new { id = estudiante.Id }, estudiante);
        }
    }
}