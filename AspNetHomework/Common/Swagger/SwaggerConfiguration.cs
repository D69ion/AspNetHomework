using Microsoft.Extensions.DependencyInjection;

namespace AspNetHomework.Common.Swagger
{
    /// <summary>
    /// Расширения для конфигурации Swagger.
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Настройка документов Swagger.
        /// </summary>
        /// <param name="services">Коллекция сервисов для DI.</param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Product";
                c.DocumentName = SwaggerDocParts.Product;
                c.ApiGroupNames = new[] { SwaggerDocParts.Product };
                c.GenerateXmlObjects = true;
            })
            .AddSwaggerDocument(c =>
            {
                c.Title = "Shop";
                c.DocumentName = SwaggerDocParts.Shop;
                c.ApiGroupNames = new[] { SwaggerDocParts.Shop };
                c.GenerateXmlObjects = true;
            });
        }
    }
}
