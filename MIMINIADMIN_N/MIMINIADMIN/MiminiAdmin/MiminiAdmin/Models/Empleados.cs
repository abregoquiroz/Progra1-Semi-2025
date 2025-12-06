using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiminiAdmin.Models
{
    public class Empleados {

        [Key]
        public int IdEmpleados { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }        

        //relación
        [ForeignKey("IdSucursal")]
        public Sucursal Sucursal { get; set; }


    }
}

