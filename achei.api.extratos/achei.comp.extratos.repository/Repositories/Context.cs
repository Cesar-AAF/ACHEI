using achei.comp.extratos.domain.Entities;
using achei.comp.extratos.repository.mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace achei.comp.extratos.repository.Repositories
{
    public class Context : DbContext
    {
        IConfiguration Configuration { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Extrato> Extrato { get; set; }
        public DbSet<Saldo> Saldo { get; set; }
        public DbSet<TipoOperacao> TipoOperacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ExtratoMap(modelBuilder.Entity<Extrato>());
            new SaldoMap(modelBuilder.Entity<Saldo>());
            new TipoOperacaoMap(modelBuilder.Entity<TipoOperacao>());
        }
    }
}
