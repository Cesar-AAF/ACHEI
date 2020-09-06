using achei.comp.extratos.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.extratos.repository.mapper
{
    public class SaldoMap : Map<Saldo>
    {
        public SaldoMap(EntityTypeBuilder<Saldo> builder) : base(builder)
        {
            builder
                .ToTable("Saldo");

            builder.Property(p => p.ValorSaldo)
                .HasColumnName("Saldo")
                .HasColumnType("decimal");

            builder.Property(p => p.DataAtualizacao)
                .HasColumnName("DataAtualizacao")
                .HasColumnType("datetime");

            builder.Property(p => p.DataCriacao)
                .HasColumnName("DataCriacao")
                .HasColumnType("datetime");
        }
    }
}
