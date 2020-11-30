using AspNetHomework.Common.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using AspNetHomework.Services.Bootstrap;
using AspNetHomework.Services.Services;
using System.Reflection;
using AspNetHomework.Database.Bootstrap;
using AspNetHomework.Repositories;
using AspNetHomework.Controllers;

namespace AspNetHomework
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
            services.ConfigureDb(Configuration);
            services.ConfigureRepositories();
            services.AddControllers();
            services.ConfigureServices();
            services.AddAutoMapper(
                typeof(ProductRepository).GetTypeInfo().Assembly,
                typeof(ProductsController).GetTypeInfo().Assembly,
                typeof(ShopRepository).GetTypeInfo().Assembly,
                typeof(ShopsController).GetTypeInfo().Assembly);
            services.ConfigureSwagger();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors();
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
