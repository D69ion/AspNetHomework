using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AspNetHomework.Common.Swagger;
using AspNetHomework.Models.DTO;
using AspNetHomework.Models.Requests.Shop;
using AspNetHomework.Models.Responses.Shop;
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
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Shop)]
    public class ShopsController : ControllerBase
    {
        private readonly ILogger<ShopsController> _logger;
        private readonly IShopService _shopService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopsController"/>.
        /// </summary>
        /// <param name="logger">Логгер.</param>
        /// <param name="shopService">Сервис магазинов.</param>
        /// <param name="mapper">Маппер</param>
        public ShopsController(ILogger<ShopsController> logger, IShopService shopService, IMapper mapper)
        {
            _logger = logger;
            _shopService = shopService;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение перечня магазинов.
        /// </summary>
        /// <returns>Коллекция сущностей "Магазины".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ShopResponse>))]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Shops/Get was requested.");
            var response = await _shopService.GetAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<ShopResponse>>(response));
        }

        /// <summary>
        /// Получение магазина по id.
        /// </summary>
        /// <param name="id">Id магазина.</param>
        /// <returns>Сущность "Магазин".</returns>
        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShopResponse))]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            _logger.LogInformation("Shops/GetById was requested.");
            var response = await _shopService.GetAsync(id);
            return Ok(_mapper.Map<ShopResponse>(response));
        }

        /// <summary>
        /// Добавление сущности "Магазин".
        /// </summary>
        /// <param name="request">Запрос на добавление сущности.</param>
        /// <returns>Сущность "Магазин".</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShopResponse))]
        public async Task<IActionResult> PostAsync(CreateShopRequest request)
        {
            _logger.LogInformation("Shops/PostAsync was requested");
            var response = await _shopService.CreateAsync(_mapper.Map<ShopDto>(request));
            return Ok(_mapper.Map<ShopResponse>(response));
        }


        /// <summary>
        /// Изменение сущности "Магазин".
        /// </summary>
        /// <returns>Cущность "Магазин".</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShopResponse))]
        public async Task<IActionResult> PutAsync(UpdateShopRequest request)
        {
            _logger.LogInformation("Shops/Put was requested.");
            var response = await _shopService.UpdateAsync(_mapper.Map<ShopDto>(request));
            return Ok(_mapper.Map<ShopResponse>(response));
        }

        /// <summary>
        /// Удаление сущностей "Магазин".
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(params long[] ids)
        {
            _logger.LogInformation("Shops/Delete was requested.");
            await _shopService.DeleteAsync(ids);
            return NoContent();
        }

    }
}
