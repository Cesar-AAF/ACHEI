using achei.comp.prestador.application.Services;
using achei.comp.prestador.domain.Interfaces.Applications;
using achei.comp.prestador.domain.Interfaces.Repositories;
using achei.comp.prestador.repository.Repositories; 
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting; 

namespace achei.api.prestador {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
         
        public void ConfigureServices(IServiceCollection services) {

            services.AddMvcCore()
               .AddCors()
               .AddJsonFormatters()
               .AddXmlSerializerFormatters()
               .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<IAvaliacaoService, AvaliacaoService>();
            services.AddScoped<IPrestadorProfissaoService, PrestadorProfissaoService>();
            services.AddScoped<IPrestadorService, PrestadorService>();
            services.AddScoped<IPrestadorServicoService, PrestadorServicoService>();
            services.AddScoped<IProfissaoService, ProfissaoService>();
            services.AddScoped<IServicoCategoriaService, ServicoCategoriaService>();
            services.AddScoped<IServicoService, ServicoService>();
            services.AddScoped<IServicoSubCategoriaService, ServicoSubCategoriaService>(); 
            services.AddScoped<Context>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<IPrestadorProfissaoRepository, PrestadorProfissaoRepository>();
            services.AddScoped<IPrestadorRepository, PrestadorRepository>();
            services.AddScoped<IPrestadorServicoRepository, PrestadorServicoRepository>();
            services.AddScoped<IProfissaoRepository, ProfissaoRepository>();
            services.AddScoped<IServicoCategoriaRepository, ServicoCategoriaRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<IServicoSubCategoriaRepository, ServicoSubCategoriaRepository>();

            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("CONNECTION_STRING_PRESTADOR")));
             
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
         
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else { 
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
