using AspNetHomework.Models.DTO;
using AspNetHomework.Models.Requests.Shop;
using AspNetHomework.Models.Responses.Shop;
using AutoMapper;

namespace AspNetHomework.Controllers.Mappings
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Товар".
    /// </summary>
    public class ShopProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopProfile"/>.
        /// </summary>
        public ShopProfile()
        {
            CreateMap<CreateShopRequest, ShopDto>();
            CreateMap<UpdateShopRequest, ShopDto>();
            CreateMap<ShopDto, ShopResponse>();
        }

    }
}
