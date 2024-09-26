using achei.comp.extratos.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.extratos.repository.mapper
{
    public class ExtratoMap : Map<Extrato>
    {
        public ExtratoMap(EntityTypeBuilder<Extrato> builder) : base(builder)
        {
            builder
                .ToTable("Extrato");

            builder.Property(p => p.SaldoID)
                .HasColumnName("SaldoID")
                .HasColumnType("int");

            builder.Property(p => p.ValorAnterior)
                .HasColumnName("ValorAnterior")
                .HasColumnType("numeric(10, 2)");

            builder.Property(p => p.ValorPosterior)
                .HasColumnName("ValorPosterior")
                .HasColumnType("numeric(10, 2)");

            builder.Property(p => p.ValorOperacao)
                .HasColumnName("ValorOperacao")
                .HasColumnType("numeric(10, 2)");

            builder.Property(p => p.TipoOperacaoID)
                .HasColumnName("TipoOperacaoID")
                .HasColumnType("int");

            builder.Property(p => p.DataOperacao)
                .HasColumnName("DataOperacao")
                .HasColumnType("datetime");

            builder.Ignore("DataCriacao");
        }
    }
}
