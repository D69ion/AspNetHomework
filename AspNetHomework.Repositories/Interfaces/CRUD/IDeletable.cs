using System.Threading.Tasks;

namespace AspNetHomework.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс удаления сущностей.
    /// </summary>
    public interface IDeletable
    {
        /// <summary>
        /// Групповое удаление сущностей.
        /// </summary>
        /// <param name="ids">Идентификаторы.</param>
        /// <returns>Задача, представляющая асинзронную операцию.</returns>
        Task DeleteAsync(params long[] ids);
    }
}
