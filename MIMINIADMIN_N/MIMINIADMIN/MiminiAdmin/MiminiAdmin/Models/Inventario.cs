using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiminiAdmin.Models
{
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }
        public string Nom_producto { get; set; }
        public string Codigo { get; set; }
        public string Canti_prod_entrante { get; set; }
        public string Canti_prod_saliente { get; set; }
        public string Estado_actual { get; set; }
        public int IdProducto { get; set; }
        public int IdSucursal { get; set; }

        //relación
        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; }

        [ForeignKey("IdSucursal")]
        public Sucursal Sucursal { get; set; }
    }

}
