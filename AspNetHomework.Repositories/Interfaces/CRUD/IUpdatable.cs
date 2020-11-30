using System.Threading;
using System.Threading.Tasks;

namespace AspNetHomework.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для изменения сущности.
    /// </summary>
    /// <typeparam name="TDto">Dto.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface IUpdatable<TDto, TModel>
    {
        /// <summary>
        /// Изменения сущности.
        /// </summary>
        /// <param name="dto">Dto.</param>
        /// <param name="token">Экземпляр <see cref="CancellationToken"/>.</param>
        /// <returns>Обновленная сущность.</returns>
        Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default);
    }
}
