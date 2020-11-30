using AspNetHomework.Models;
using AspNetHomework.Services.Interfaces;
using System.Collections.Generic;
using AspNetHomework.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using AspNetHomework.Services.Interfaces.CRUD;

namespace AspNetHomework.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными о товарах.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ProductService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий.</param>
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        ///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<ProductDto> CreateAsync(ProductDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        ///<inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            await _repository.DeleteAsync(ids);
        }

        ///<inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<ProductDto>> GetAsync(CancellationToken token = default)
        {
            return await _repository.GetAsync(token);
        }

        ///<inheritdoc cref="IGettableById{TDto}.GetAsync(long)"/>
        public async Task<ProductDto> GetAsync(long id)
        {
            return await _repository.GetAsync(id);
        }

        ///<inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
        public async Task<ProductDto> UpdateAsync(ProductDto dto)
        {
            return await _repository.UpdateAsync(dto);
        }
    }
}
