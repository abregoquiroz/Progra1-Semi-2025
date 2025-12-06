using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiminiAdmin.Models
{
    public class Ventas
    {
        [Key]
        public int IdVentas { get; set; }       
        public string Consumidor { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha_venta { get; set; }
        public string Metodo_pago { get; set; }

        [ForeignKey("IdSucursal")]
        public Sucursal Sucursal { get; set; }

        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; }


    }
}
