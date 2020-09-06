using achei.comp.extratos.application.Services;
using achei.comp.extratos.domain.Interfaces.Applications;
using achei.comp.extratos.domain.Interfaces.Repositories;
using achei.comp.extratos.repository.Repositories; 
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace achei.api.extratos {
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
              
            services.AddScoped<ISaldoService, SaldoService>(); 
            services.AddScoped<IExtratoService, ExtratoService>(); 
            services.AddScoped<Context>();
            services.AddScoped<IExtratoRepository, ExtratoRepository>();
            services.AddScoped<ISaldoRepository, SaldoRepository>();
            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("CONNECTION_STRING_EXTRATOS")));
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
