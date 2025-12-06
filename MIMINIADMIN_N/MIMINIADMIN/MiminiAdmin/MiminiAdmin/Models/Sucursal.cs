using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiminiAdmin.Models
{
    public class Sucursal
    {
        [Key]
        public int IdSucursal { get; set; }
        public string Nom_sucursal { get; set; }
        public string Cod_sucursal { get; set; }
        public string Direccion { get; set; }
        public string Tel_Sucursal { get; set; }

        [ForeignKey("IdVentas")]
        public Ventas Ventas { get; set; }

        [ForeignKey("IdEmpleados")]
        public Empleados Empleados { get; set; }

        [ForeignKey("IdInventario")]
        public Inventario Inventario { get; set; }
    }
}
