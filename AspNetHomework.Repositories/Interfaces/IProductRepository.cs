using AspNetHomework.Database;
using AspNetHomework.Models;
using AspNetHomework.Repositories.Interfaces.CRUD;

namespace AspNetHomework.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с сущностями "Товар".
    /// </summary>
    public interface IProductRepository : ICrudRepository<ProductDto, Product>
    {
    }
}
