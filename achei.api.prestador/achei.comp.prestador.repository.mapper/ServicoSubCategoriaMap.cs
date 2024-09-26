using achei.comp.prestador.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.prestador.repository.mapper
{
    public class ServicoSubCategoriaMap : Map<ServicoSubCategoria>
    {
        public ServicoSubCategoriaMap(EntityTypeBuilder<ServicoSubCategoria> builder) : base(builder)
        {
            builder
                .ToTable("ServicoSubCategoria");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(250)");

            builder.Property(p => p.ServicoCategoriaID)
                .HasColumnName("ServicoCategoriaID")
                .HasColumnType("int");

            builder.Ignore("DataCriacao");
        }
    }
}
