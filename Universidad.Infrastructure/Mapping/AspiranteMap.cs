using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Mapping
{
    internal class AspiranteMap : IEntityTypeConfiguration<Aspirante>
    {
        public void Configure(EntityTypeBuilder<Aspirante> builder)
        {
            builder.HasOne(d => d.TipoDocumento)
             .WithMany(p => p.Aspirantes)
             .HasPrincipalKey(p => p.TipoDocumentoId)
             .HasForeignKey(d => d.TipoDocumentoId);
        }
    }
}
