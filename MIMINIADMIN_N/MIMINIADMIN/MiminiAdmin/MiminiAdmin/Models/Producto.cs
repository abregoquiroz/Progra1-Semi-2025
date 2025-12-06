using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiminiAdmin.Models
{
    public class Producto {
        [Key]
        public int IdProducto { get; set; }
        public string Nom_prod { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        
       
    }
}
