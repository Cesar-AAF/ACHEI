using achei.comp.prestador.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.prestador.repository.mapper
{
    public class ProfissaoMap : Map<Profissao>
    {
        public ProfissaoMap(EntityTypeBuilder<Profissao> builder) : base(builder)
        {
            builder
                .ToTable("Profissao");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(50)");
        }
    }
}
