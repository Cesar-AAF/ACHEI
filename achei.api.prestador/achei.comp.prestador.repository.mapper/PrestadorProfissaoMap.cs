using achei.comp.prestador.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.prestador.repository.mapper
{
    public class PrestadorProfissaoMap : Map<PrestadorProfissao>
    {
        public PrestadorProfissaoMap(EntityTypeBuilder<PrestadorProfissao> builder) : base(builder)
        {
            builder
                .ToTable("PrestadorServicoXProfissao");

            builder.Property(p => p.PrestadorServicoID)
                .HasColumnName("PrestadorServicoID")
                .HasColumnType("int");

            builder.Property(p => p.ProfissaoID)
                .HasColumnName("ProfissaoID")
                .HasColumnType("int");

            builder.Ignore("DataCriacao");
        }
    }
}
