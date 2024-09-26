using achei.comp.extratos.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.extratos.repository.mapper
{
    public class TipoOperacaoMap : Map<TipoOperacao>
    {
        public TipoOperacaoMap(EntityTypeBuilder<TipoOperacao> builder) : base(builder)
        {
            builder
                .ToTable("TipoOperacao");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(25)");

            builder.Ignore("DataCriacao");
        }
    }
}
