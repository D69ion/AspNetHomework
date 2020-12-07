using AspNetHomework.Database;
using AspNetHomework.Models;
using AutoMapper;

namespace AspNetHomework.Services
{
    /// <summary>
    /// Профиль маппинга (товар).
    /// </summary>
    public class ProductProfile : Profile 
    {
        /// <summary>
        /// Инициализарует экземпляр <see cref="ProductProfile"/>.
        /// </summary>
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
