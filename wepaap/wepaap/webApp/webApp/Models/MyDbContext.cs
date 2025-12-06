using Microsoft.EntityFrameworkCore;
using webApp.Models;
namespace webApp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey(a => a.idAlumno);
            modelBuilder.Entity<Materia>().HasKey(m => m.idMateria);
            modelBuilder.Entity<Docente>().HasKey(d => d.idDocente);
            modelBuilder.Entity<Periodo>().HasKey(p => p.idPeriodo);
            modelBuilder.Entity<Matricula>().HasKey(mt => mt.idMatricula);

            //Relacion de matriucla con la tabla alumnos
            modelBuilder.Entity<Matricula>()
                .HasOne(a => a.Alumno)
                .WithMany(m => m.Matriculas)
                .HasForeignKey(mt => mt.idAlumno)
                .OnDelete(DeleteBehavior.Cascade);

            //Relacion de matricula con la tabla periodos
            modelBuilder.Entity<Matricula>()
                .HasOne(p => p.Periodo)
                .WithMany(m => m.Matriculas)
                .HasForeignKey(mt => mt.idPeriodo)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
