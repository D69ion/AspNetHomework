using AspNetHomework.Database.Domain;
using AspNetHomework.Models.DTO;
using AutoMapper;

namespace AspNetHomework.Services.Mapping
{
    /// <summary>
    /// Профиль маппинга (магазин).
    /// </summary>
    public class ShopProfile : Profile
    {
        /// <summary>
        /// Инициализарует экземпляр <see cref="ShopProfile"/>.
        /// </summary>
        public ShopProfile()
        {
            CreateMap<Shop, ShopDTO>().ReverseMap();
        }
    }
}
