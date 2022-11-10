using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ApiRest.Models
{
    public class CursoModel
    {
        //[Required]
       
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int numberStudents { get; set; }

        
    }
}
