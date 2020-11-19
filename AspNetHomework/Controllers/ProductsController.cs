using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetHomework.Common.Swagger;
using AspNetHomework.Models;
using AspNetHomework.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetHomework.Controllers
{
    /// <summary>
    /// Контроллер для работы с данными об одежде.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Product)]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductService _productService;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ProductsController"/>.
        /// </summary>
        /// <param name="logger">Логгер.</param>
        /// <param name="productService">Сервис товаров.</param>
        public ProductsController(ILogger<ProductsController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        /// <summary>
        /// Получение перечня доступных товаров.
        /// </summary>
        /// <returns>Коллекция сущностей "Товары".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProductDTO>))]
        public IActionResult Get()
        {
            _logger.LogInformation("Product/get was requested");
            var response = _productService.Get();
            return Ok(response);
        }
    }
}
