using achei.comp.orcamentos.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.orcamentos.repository.mapper
{
    public class OrcamentoMap : Map<Orcamento>
    {
        public OrcamentoMap(EntityTypeBuilder<Orcamento> builder) : base(builder)
        {
            builder
                .ToTable("Orcamento");

            builder.Property(p => p.OrcamentoServicoID)
                .HasColumnName("PrestadorServicoID")
                .HasColumnType("int");

            builder.Property(p => p.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar(250)");

            builder.Property(p => p.StatusID)
                .HasColumnName("OrcamentoStatusID")
                .HasColumnType("int");

            builder.Property(p => p.Valor)
                .HasColumnName("Valor")
                .HasColumnType("numeric(10, 2)");

            builder.Ignore("DataCriacao");
        }
    }
}
