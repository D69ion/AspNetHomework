using AspNetHomework.Models;
using AspNetHomework.Models.Requests.Product;
using AspNetHomework.Models.Responses.Product;
using AutoMapper;

namespace AspNetHomework.Controllers.Mappings
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Товар".
    /// </summary>
    public class ProductProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ProductProfile"/>.
        /// </summary>
        public ProductProfile()
        {
            CreateMap<CreateProductRequest, ProductDto>();
            CreateMap<UpdateProductRequest, ProductDto>();
            CreateMap<ProductDto, ProductResponse>();
        }
    }
}
