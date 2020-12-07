using AspNetHomework.Database.Contexts;
using AspNetHomework.Database.Domain;
using AspNetHomework.Models.DTO;
using AspNetHomework.Repositories.Interfaces;
using AutoMapper;

namespace AspNetHomework.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущнростями "Магазин".
    /// </summary>
    public class ShopRepository : BaseRepository<ShopDto, Shop>, IShopRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopRepository"/>.
        /// </summary>
        /// <param name="context">Контекст.</param>
        /// <param name="mapper">Маппер.</param>
        public ShopRepository(AspNetHomeworkContext context, IMapper mapper) : base (context, mapper)
        {

        }
    }
}
