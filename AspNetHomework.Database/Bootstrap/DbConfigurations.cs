using AspNetHomework.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetHomework.Database.Bootstrap
{
    /// <summary>
    /// Конфигурация БД.
    /// </summary>
    public static class DbConfigurations
    {
        /// <summary>
        /// Подключение DbContext.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        /// <param name="configuration">Конфигурация.</param>
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AspNetHomeworkContext>(
                options => options.UseNpgsql(
                    configuration.GetConnectionString(nameof(AspNetHomeworkContext)),
                    builder => builder.MigrationsAssembly(typeof(AspNetHomeworkContext).Assembly.FullName)));
        }
    }
}
