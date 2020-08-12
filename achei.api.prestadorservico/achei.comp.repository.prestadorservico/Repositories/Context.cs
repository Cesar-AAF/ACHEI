using System;
using System.Collections.Generic;
using System.Text;

namespace achei.comp.repository.prestadorservico.Repositories
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
