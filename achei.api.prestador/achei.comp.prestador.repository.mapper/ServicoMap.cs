using achei.comp.prestador.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.prestador.repository.mapper
{
    public class ServicoMap : Map<Servico>
    {
        public ServicoMap(EntityTypeBuilder<Servico> builder) : base(builder)
        {
            builder
                .ToTable("Servico");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property(p => p.ServicoSubCategoriaID)
                .HasColumnName("ServicoSubCategoriaID")
                .HasColumnType("int");

            builder.Ignore("DataCriacao");
        }
    }
}
