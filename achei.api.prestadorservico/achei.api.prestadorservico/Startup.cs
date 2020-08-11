namespace achei.api.prestadorservico
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Configuração de Cors para aceitar requisições de outros domínios

            //Cors
            var allowedDomains = new[] { "" };

            services.AddCors(options =>
            {
                options.AddPolicy("DomainsAllowed", builder =>
                {
                    builder.SetIsOriginAllowedToAllowWildcardSubdomains()
                           .WithOrigins(allowedDomains)
                           .AllowAnyMethod()
                           .AllowCredentials()
                           .AllowAnyHeader()
                           .Build();
                });
            });

            #endregion

            #region Autenticação Jwt (JSON Web Token)

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        RequireSignedTokens = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),

                        ValidateIssuer = true,
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidateAudience = true,
                        ValidAudience = Configuration["Jwt:Audience"],
                        ValidateLifetime = true,
                        RequireExpirationTime = true
                    };
                });

            #endregion

            #region ADO EntityFramework DbContext's

            services.AddDbContext<Context>(options =>
                options.UseMySQL(Configuration.GetConnectionString("CONNECTION_STRING_PRESTADOR_SERVICO")));


            #endregion

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("DomainsAllowed");

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
