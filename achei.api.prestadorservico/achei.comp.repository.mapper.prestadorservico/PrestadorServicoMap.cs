namespace achei.comp.domain.prestadorservico.Entity
{
    public class PrestadorServicoMap : Mapper.Map<PrestadorServico>
    {
        public PrestadorServicoMap(EntityTypeBuilder<PrestadorServico> builder) : base(builder)
        {
            builder
                   .ToTable("PrestadorServico");

            builder.Property(p => p.CNPJ)
                .HasColumnName("CNPJ")
                .HasColumnType("varchar(15)");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Senha)
                .HasColumnName("Senha")
                .HasColumnType("varchar(50)");

            builder.Property(p => p.DDD)
                .HasColumnName("DDD")
                .HasColumnType("varchar(5)");

            builder.Property(p => p.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Status)
                .HasColumnName("Status")
                .HasColumnType("bit");

            builder.Property(p => p.EnderecoID)
                .HasColumnName("EnderecoID")
                .HasColumnType("int");

            builder.Property(p => p.DataCriacao)
                .HasColumnName("DataCriacao")
                .HasColumnType("datetime");

            builder.Property(p => p.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar(500)");

            builder.Property(p => p.PrestadorServicoAvaliacaoID)
                .HasColumnName("PrestadorServicoAvaliacaoID")
                .HasColumnType("int");

            builder.Property(p => p.SaldoId)
                .HasColumnName("SaldoId")
                .HasColumnType("int");

            //builder.Ignore("");
        }
    }
}
