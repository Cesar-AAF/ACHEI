using achei.comp.prestadorservico.domain.Entity;
using achei.comp.prestadorservico.repository.mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace achei.comp.prestadorservico.repository.Repositories
{
    public class Context : DbContext
    {
        IConfiguration Configuration { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<PrestadorServico> PrestadorServico { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new PrestadorServicoMap(modelBuilder.Entity<PrestadorServico>());
        }
    }
}
