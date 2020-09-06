using achei.comp.prestador.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.prestador.repository.mapper
{
    public class ServicoCategoriaMap : Map<ServicoCategoria>
    {
        public ServicoCategoriaMap(EntityTypeBuilder<ServicoCategoria> builder) : base(builder)
        {
            builder
                .ToTable("ServicoCategoria");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(250)");

            builder.Ignore("DataCriacao");
        }
    }
}
