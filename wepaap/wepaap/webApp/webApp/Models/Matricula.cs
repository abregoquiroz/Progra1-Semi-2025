using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webApp.Models
{
    public class Matricula
    {
        [Key]
        public int idMatricula { get; set; }
        public int idAlumno { get; set; } // Llave foranea fk_matricula_alumno
        public int idPeriodo { get; set; } // Llave foranea fk_matricula_periodo
        public DateTime fecha { get; set; }
        //Relacion con la tabla alumnos
        [ForeignKey("idAlumno")]
        public Alumno? Alumno { get; set; }
        //Relacion con la tabla periodos
        [ForeignKey("idPeriodo")]
        public Periodo? Periodo { get; set; }
    }
}
