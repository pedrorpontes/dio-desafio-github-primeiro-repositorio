using Localiza.Frotas5.Domain;
using Localiza.Frotas5.Infra.Facade;
using Localiza.Frotas5.Infra.Repository;
using Localiza.Frotas5.Infra.Repository.EF;
using Localiza.Frotas5.Infra.Singleton;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Frotas5
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "Localiza.Frotas5",
                    Description = "API - Frotas",
                    Version = "v1" 
                });

                var ApiPath = Path.Combine(AppContext.BaseDirectory, "Localiza.Frotas.xml");
                c.IncludeXmlComments(ApiPath);
            });
            services.AddSingleton<SingletonContainer>();
           
            services.AddTransient<IVeiculoRepository, FrotaRepository>();

            services.AddDbContext<FrotaContext>(opt => opt.UseInMemoryDatabase("Frota"));

            services.Configure<DetranOptions>(Configuration.GetSection("DetranOptions"));

            services.AddHttpClient();

            services.AddTransient<IVeiculoDetran, VeiculoDetranFacade>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API - Localiza.Frotas5");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
