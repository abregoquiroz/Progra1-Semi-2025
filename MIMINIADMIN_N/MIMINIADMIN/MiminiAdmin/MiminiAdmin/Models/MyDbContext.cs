using Microsoft.EntityFrameworkCore;
using MiminiAdmin.Models;
namespace MiminiAdmin.Models
{
    public class MyDbContext : DbContext {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> option) : base(option) { }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Empleados> Empleados { get; set; }      
        public DbSet<Inventario> Inventario { get; set; }      
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Producto>().HasKey(p => p.IdProducto);
            modelBuilder.Entity<Empleados>().HasKey(e => e.IdEmpleados);           
            modelBuilder.Entity<Inventario>().HasKey(i => i.IdInventario);           
            modelBuilder.Entity<Sucursal>().HasKey(s => s.IdSucursal);
            modelBuilder.Entity<Ventas>().HasKey(v => v.IdVentas);
        }
        
    }
}
