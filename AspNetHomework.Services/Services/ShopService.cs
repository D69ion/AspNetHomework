using AspNetHomework.Models.DTO;
using AspNetHomework.Repositories.Interfaces;
using AspNetHomework.Services.Interfaces;
using AspNetHomework.Services.Interfaces.CRUD;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetHomework.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными о магазинах.
    /// </summary>
    public class ShopService : IShopService
    {
        private readonly IShopRepository _repository;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopService/>.
        /// </summary>
        /// <param name="repository">Репозиторий.</param>
        public ShopService(IShopRepository repository)
        {
            _repository = repository;
        }

        ///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<ShopDto> CreateAsync(ShopDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        ///<inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            await _repository.DeleteAsync(ids);
        }

        ///<inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<ShopDto>> GetAsync(CancellationToken token = default)
        {
            return await _repository.GetAsync(token);
        }

        ///<inheritdoc cref="IGettableById{TDto}.GetAsync(long)"/>
        public async Task<ShopDto> GetAsync(long id)
        {
            return await _repository.GetAsync(id);
        }

        ///<inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
        public async Task<ShopDto> UpdateAsync(ShopDto dto)
        {
            return await _repository.UpdateAsync(dto);
        }
    }
}
