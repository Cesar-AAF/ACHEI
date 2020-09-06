using achei.comp.orcamentos.domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.orcamentos.repository.mapper
{
    public class Map<T> where T : Base
    {
        public Map(EntityTypeBuilder<T> builder)
        {
            builder
                .HasKey(k => k.Id);
        }
    }
}
