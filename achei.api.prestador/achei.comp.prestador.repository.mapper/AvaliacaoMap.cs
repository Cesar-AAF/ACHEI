using achei.comp.prestador.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.prestador.repository.mapper
{
    public class AvaliacaoMap : Map<PrestadorAvaliacao>
    {
        public AvaliacaoMap(EntityTypeBuilder<PrestadorAvaliacao> builder) : base(builder)
        {
            builder
                .ToTable("PrestadorServicoAvaliacao");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("int");

            builder.Ignore("DataCriacao");
        }
    }
}
