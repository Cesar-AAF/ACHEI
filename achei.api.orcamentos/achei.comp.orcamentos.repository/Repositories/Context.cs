using achei.comp.orcamentos.domain.Entities;
using achei.comp.orcamentos.repository.mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace achei.comp.orcamentos.repository.Repositories
{
    public class Context : DbContext
    {
        IConfiguration Configuration { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Orcamento> Orcamento { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new OrcamentoMap(modelBuilder.Entity<Orcamento>());
            new StatusMap(modelBuilder.Entity<Status>());
        }
    }
}
