using AspNetHomework.Models;
using AspNetHomework.Services.Interfaces;
using System.Collections.Generic;
using AspNetHomework.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using AspNetHomework.Services.Interfaces.CRUD;
using System;

namespace AspNetHomework.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными о товарах.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ProductService"/>.
        /// </summary>
        /// <param name="unitOfWork">Экземпляр UoW.</param>
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        ///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<ProductDto> CreateAsync(ProductDto dto)
        {
            using var scope = await _unitOfWork.ProductRepository.Context.Database.BeginTransactionAsync();
            try
            {
                var products = await _unitOfWork.ProductRepository.CreateAsync(dto);
                scope.Commit();
                return products;
            }
            catch (Exception e)
            {
                scope.Rollback();
                throw e;
            }
        }

        ///<inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            await _unitOfWork.ProductRepository.DeleteAsync(ids);
        }

        ///<inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<ProductDto>> GetAsync(CancellationToken token = default)
        {
            return await _unitOfWork.ProductRepository.GetAsync(token);
        }

        ///<inheritdoc cref="IGettableById{TDto}.GetAsync(long)"/>
        public async Task<ProductDto> GetAsync(long id)
        {
            return await _unitOfWork.ProductRepository.GetAsync(id);
        }

        ///<inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
        public async Task<ProductDto> UpdateAsync(ProductDto dto)
        {
            return await _unitOfWork.ProductRepository.UpdateAsync(dto);
        }
    }
}
