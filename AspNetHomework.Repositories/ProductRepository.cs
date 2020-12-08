using AspNetHomework.Database;
using AspNetHomework.Database.Contexts;
using AspNetHomework.Models;
using AspNetHomework.Repositories.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AspNetHomework.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями "Товар".
    /// </summary>
    public class ProductRepository : BaseRepository<ProductDto, Product>, IProductRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ProductRepository"/>.
        /// </summary>
        /// <param name="context">Контекст.</param>
        /// <param name="mapper">Маппер.</param>
        public ProductRepository(AspNetHomeworkContext context, IMapper mapper) : base (context, mapper)
        {

        }

        ///<inheritdoc cref="DefaultIncludeProperties(DbSet{Product})"/>
        protected override IQueryable<Product> DefaultIncludeProperties(DbSet<Product> dbSet)
        {
            return DbSet.Include(x => x.Vendor);
        }
    }
}
