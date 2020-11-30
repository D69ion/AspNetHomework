using System.Threading.Tasks;

namespace AspNetHomework.Services.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс сервиса для изменения сущности.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    public interface IUpdatable<TDto>
    {
        /// <summary>
        /// Изменение сущности.
        /// </summary>
        /// <param name="dto">DTO.</param>
        /// <returns>Обновленная сущность.</returns>
        Task<TDto> UpdateAsync(TDto dto);
    }
}
