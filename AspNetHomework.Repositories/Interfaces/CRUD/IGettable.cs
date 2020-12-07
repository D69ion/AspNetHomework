using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetHomework.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для получения сущностей.
    /// </summary>
    public interface IGettable<TDto, TModel>
    {
        /// <summary>
        /// Получение сущностей.
        /// </summary>
        /// <param name="token">Экземпляр <see cref="CancellationToken"/>.</param>
        /// <returns>Коллекция экземпляров сущностей.</returns>
        Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default);
    }
}
