using achei.comp.orcamentos.application.Services; 
using achei.comp.orcamentos.domain.Interfaces.Applications;
using achei.comp.orcamentos.domain.Interfaces.Repositories;
using achei.comp.orcamentos.repository.Repositories; 
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace achei.api.orcamentos {
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
             
            services.AddScoped<IOrcamentoService, OrcamentoService>(); 
            services.AddScoped<Context>();
            services.AddScoped<IOrcamentoRepository, OrcamentoRepository>(); 

            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("CONNECTION_STRING_ORCAMENTO")));
             
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
