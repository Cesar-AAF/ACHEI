using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.repository.mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace achei.comp.prestador.repository.Repositories
{
    public class Context : DbContext
    {
        IConfiguration Configuration { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<PrestadorAvaliacao> Avaliacao { get; set; }
        public DbSet<Prestador> Prestador { get; set; }
        public DbSet<PrestadorProfissao> PrestadorProfissao { get; set; }
        public DbSet<PrestadorServico> PrestadorServico { get; set; }
        public DbSet<Profissao> Profissao { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<ServicoCategoria> ServicoCategoria { get; set; }
        public DbSet<ServicoSubCategoria> ServicoSubCategoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new AvaliacaoMap(modelBuilder.Entity<PrestadorAvaliacao>());
            new PrestadorMap(modelBuilder.Entity<Prestador>());
            new PrestadorProfissaoMap(modelBuilder.Entity<PrestadorProfissao>());
            new PrestadorServicoMap(modelBuilder.Entity<PrestadorServico>());
            new ProfissaoMap(modelBuilder.Entity<Profissao>());
            new ServicoMap(modelBuilder.Entity<Servico>());
            new ServicoCategoriaMap(modelBuilder.Entity<ServicoCategoria>());
            new ServicoSubCategoriaMap(modelBuilder.Entity<ServicoSubCategoria>());
        }
    }
}
