using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AspNetHomework.Common.Swagger;
using AspNetHomework.Models;
using AspNetHomework.Models.Requests.Product;
using AspNetHomework.Models.Responses.Product;
using AspNetHomework.Services.Interfaces;
using AutoMapper;
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
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ProductsController"/>.
        /// </summary>
        /// <param name="logger">Логгер.</param>
        /// <param name="productService">Сервис товаров.</param>
        /// <param name="mapper">Маппер</param>
        public ProductsController(ILogger<ProductsController> logger, IProductService productService, IMapper mapper)
        {
            _logger = logger;
            _productService = productService;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение перечня доступных товаров.
        /// </summary>
        /// <returns>Коллекция сущностей "Товары".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProductResponse>))]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Products/Get was requested.");
            var response = await _productService.GetAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<ProductResponse>>(response));
        }

        /// <summary>
        /// Получение товара по id.
        /// </summary>
        /// <param name="id">Id товара.</param>
        /// <returns>Сущность "Товар".</returns>
        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductResponse))]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            _logger.LogInformation("Products/GetById was requested.");
            var response = await _productService.GetAsync(id);
            return Ok(_mapper.Map<ProductResponse>(response));
        }

        /// <summary>
        /// Добавление сущности "Товар".
        /// </summary>
        /// <param name="request">Запрос на добавление сущности.</param>
        /// <returns>Сущность "Товар".</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductResponse))]
        public async Task<IActionResult> PostAsync(CreateProductRequest request)
        {
            _logger.LogInformation("Products/PostAsync was requested");
            var response = await _productService.CreateAsync(_mapper.Map<ProductDto>(request));
            return Ok(_mapper.Map<ProductResponse>(response));
        }


        /// <summary>
        /// Изменение сущности "Товар".
        /// </summary>
        /// <returns>Cущность "Товар".</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductResponse))]
        public async Task<IActionResult> PutAsync(UpdateProductRequest request)
        {
            _logger.LogInformation("Products/Put was requested.");
            var response = await _productService.UpdateAsync(_mapper.Map<ProductDto>(request));
            return Ok(_mapper.Map<ProductResponse>(response));
        }

        /// <summary>
        /// Удаление сущностей "Товар".
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(params long[] ids)
        {
            _logger.LogInformation("Products/Delete was requested.");
            await _productService.DeleteAsync(ids);
            return NoContent();
        }
    }
}
