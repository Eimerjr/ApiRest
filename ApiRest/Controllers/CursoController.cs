using ApiRest.Models;
using ApiRest.RepositorioDatos;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RpCursos RpCurso = new RpCursos();
            return Ok(RpCurso.getCursos());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RpCursos RpCurso = new RpCursos();

            var cursort = RpCurso.getCurso(id);

            if (cursort == null)
            {
                var nf = NotFound("Curso " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cursort);
        }

        [HttpPost("agregar")]
        public IActionResult AddCurso(CursoModel nuevoCurso)
        {
            RpCursos RpCurso = new RpCursos();
            RpCurso.Agregar(nuevoCurso);
            return CreatedAtAction(nameof(AddCurso), nuevoCurso);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteCurso(int id )
        {
            RpCursos RpCurso = new RpCursos();

            var cursort = RpCurso.getCurso(id);

            if (cursort == null)
            {
                var nf = NotFound("Curso " + id.ToString() + " no existe, no se puede eliminar.");
                return nf;
            }

            RpCurso.eliminar(cursort);

            return Ok(RpCurso.getCursos());
            
        }
    }
}
