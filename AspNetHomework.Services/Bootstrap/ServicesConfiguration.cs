using AspNetHomework.Services.Interfaces;
using AspNetHomework.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetHomework.Services.Bootstrap
{
    /// <summary>
    /// Методы расширения для конфигурации сервисов
    /// </summary>
    public static class ServicesConfiguration
    {
        /// <summary>
        /// Конфигурация сервисов
        /// </summary>
        /// <param name="services">Конфигурация сервисов из Startup</param>
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
