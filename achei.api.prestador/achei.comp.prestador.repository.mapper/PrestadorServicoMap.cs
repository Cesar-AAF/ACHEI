using achei.comp.prestador.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.prestador.repository.mapper
{
    public class PrestadorServicoMap : Map<PrestadorServico>
    {
        public PrestadorServicoMap(EntityTypeBuilder<PrestadorServico> builder) : base(builder)
        {
            builder
                .ToTable("PrestadorServicoXServico");

            builder.Property(p => p.PrestadorServicoID)
                .HasColumnName("PrestadorServicoID")
                .HasColumnType("int");

            builder.Property(p => p.ServicoID)
                .HasColumnName("ServicoID")
                .HasColumnType("int");

            builder.Ignore("DataCriacao");
        }
    }
}
