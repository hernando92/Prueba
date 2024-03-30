using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Mapping
{
    public class MatriculaMap : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.HasOne(d => d.Aspirante)
             .WithMany(p => p.Matriculas)
             .HasPrincipalKey(p => p.AspiranteId)
             .HasForeignKey(d => d.AspiranteId);

            builder.HasOne(d => d.ProgramaAcademico)
             .WithMany(p => p.Matriculas)
             .HasPrincipalKey(p => p.ProgramaAcademicoId)
             .HasForeignKey(d => d.ProgramaAcademicoId);
        }
    }
}
