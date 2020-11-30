using AspNetHomework.Models;
using AspNetHomework.Services.Interfaces.CRUD;

namespace AspNetHomework.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с данными о товарах.
    /// </summary>
    public interface IProductService : ICrudService<ProductDTO>
    {
    }
}
