using AspNetHomework.Database.Domain;
using AspNetHomework.Models.DTO;
using AspNetHomework.Repositories.Interfaces.CRUD;

namespace AspNetHomework.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с сущностями "Магазин".
    /// </summary>
    public interface IShopRepository : ICrudRepository<ShopDto, Shop>
    {
    }
}
