using AspNetHomework.Models;
using AspNetHomework.Services.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using AspNetHomework.Database.Mocks;

namespace AspNetHomework.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными о товарах.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <inheritdoc cref="IProductService"/>
        public IEnumerable<ProductDTO> Get()
        {
            var products = ProductMock.GetProducts();
            var response = _mapper.Map<IEnumerable<ProductDTO>>(products);
            return response;
        }
    }
}
