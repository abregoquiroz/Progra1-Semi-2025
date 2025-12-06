using System.ComponentModel.DataAnnotations;

namespace webApp.Models
{
    public class Periodo
    {
        [Key]
        public int idPeriodo { get; set; }
        public DateTime fecha { get; set; }
        public string periodo { get; set; }
        //Relacion con la tabla matriculas
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
