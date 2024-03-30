using Microsoft.EntityFrameworkCore;
using Universidad.Domain.Entities;
using Universidad.Infrastructure.Mapping;

namespace Universidad.Infrastructure
{
    public class UniversidadDbContext : DbContext
    {

        public UniversidadDbContext(DbContextOptions<UniversidadDbContext> options)
            : base(options)
        {
            InitalizeContext();
        }

        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //Database.SetCommandTimeout(360);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MatriculaMap());
            modelBuilder.ApplyConfiguration(new ProgramaAcademicoMap());
            modelBuilder.ApplyConfiguration(new AspiranteMap());
        }

        public DbSet<Aspirante> Aspirante { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<MatriculaHistorialPago> MatriculaHistorialPago { get; set; }
        public DbSet<ProgramaAcademico> ProgramaAcademico { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<TipoProgramaAcademico> TipoProgramaAcademico { get; set; }

    }
}
