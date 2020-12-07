using AspNetHomework.Models.DTO;
using AspNetHomework.Services.Interfaces.CRUD;

namespace AspNetHomework.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с данными о магазинах.
    /// </summary>
    public interface IShopService : ICrudService<ShopDTO>
    {
    }
}
