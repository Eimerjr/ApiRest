using ApiRest.Models;

namespace ApiRest.RepositorioDatos
{
    public class RpCursos
    {
        public static List<CursoModel> listaCursos = new List<CursoModel>()
        {
            new CursoModel() { Id = 1, Name = "Matematicas" , numberStudents = 10 },
            new CursoModel() { Id = 2, Name = "Ingenieria de software" , numberStudents = 12 },
            new CursoModel() { Id = 3, Name = "Calculo diferencial" , numberStudents = 29 }
        };

        public IEnumerable<CursoModel> getCursos()
        {
            return listaCursos;
        }

        public CursoModel getCurso(int id)
        {
            var Cursos = listaCursos.Where(cur => cur.Id == id);

            return Cursos.FirstOrDefault();
        }

        public void Agregar(CursoModel nuevoCurso)
        {
            listaCursos.Add(nuevoCurso);
        }

        public void eliminar(CursoModel nuevoCurso)
        {
            listaCursos.Remove(nuevoCurso);
        }


    }
}
