using achei.comp.orcamentos.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.orcamentos.repository.mapper
{
    public class StatusMap : Map<Status>
    {
        public StatusMap(EntityTypeBuilder<Status> builder) : base(builder)
        {
            builder
                .ToTable("Status");

            builder.Property(p => p.Descricao)
                .HasColumnName("Status")
                .HasColumnType("varchar(50)");

            builder.Ignore("DataCriacao");
        }
    }
}
