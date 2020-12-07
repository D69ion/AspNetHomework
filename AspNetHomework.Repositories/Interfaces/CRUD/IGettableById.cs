using System.Threading.Tasks;

namespace AspNetHomework.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для получения сущностейпо идентификатору.
    /// </summary>
    /// <typeparam name="TDto">Dto.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface IGettableById<TDto, TModel>
    {
        /// <summary>
        /// Получение сущности по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Экземпляр сущности.</returns>
        Task<TDto> GetAsync(long id);
    }
}
