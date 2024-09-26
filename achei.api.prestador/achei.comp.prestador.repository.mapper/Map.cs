using achei.comp.prestador.domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.prestador.repository.mapper
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
