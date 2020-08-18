using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.repository.mapper.prestadorservico
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
