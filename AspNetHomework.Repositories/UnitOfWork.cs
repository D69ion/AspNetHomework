using AspNetHomework.Database.Contexts;
using AspNetHomework.Repositories.Interfaces;
using AutoMapper;
using System;

namespace AspNetHomework.Repositories
{
    /// <summary>
    /// Класс для работы с несколькими репозиотриями.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        public AspNetHomeworkContext DbContext { get; }
        private IProductRepository _productRepository;
        private IShopRepository _shopRepository;
        private IMapper _mapper;

        ///<inheritdoc cref="IProductRepository"/>
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(DbContext, _mapper);
                }
                return _productRepository;
            }
        }

        ///<inheritdoc cref="IShopRepository"/>
        public IShopRepository ShopRepository
        {
            get
            {
                if (_shopRepository == null)
                {
                    _shopRepository = new ShopRepository(DbContext, _mapper);
                }
                return _shopRepository;
            }
        }

        /// <summary>
        /// Инициализирует экземпляр <see cref="UnitOfWork"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        public UnitOfWork(AspNetHomeworkContext context, IMapper mapper)
        {
            DbContext = context;
            _mapper = mapper;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}
