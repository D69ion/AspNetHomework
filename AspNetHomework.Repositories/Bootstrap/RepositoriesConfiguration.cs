using AspNetHomework.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetHomework.Repositories
{
    /// <summary>
    /// Расширения для конфигурации репозиториев.
    /// </summary>
    public static class RepositoriesConfiguration
    {
        /// <summary>
        /// Конфигурирование репозиториев.
        /// </summary>
        /// <param name="services">Коллекция сервисов из Startup.</param>
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IShopRepository, ShopRepository>();
        }
    }
}
