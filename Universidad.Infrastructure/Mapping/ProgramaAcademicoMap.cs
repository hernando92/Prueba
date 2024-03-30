using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Mapping
{
    public class ProgramaAcademicoMap : IEntityTypeConfiguration<ProgramaAcademico>
    {
        public void Configure(EntityTypeBuilder<ProgramaAcademico> builder)
        {
            builder.HasOne(d => d.TipoProgramaAcademico)
             .WithMany(p => p.ProgramaAcademicos)
             .HasPrincipalKey(p => p.TipoProgramaAcademicoId)
             .HasForeignKey(d => d.TipoProgramaAcademicoId);
        }

    }
}
