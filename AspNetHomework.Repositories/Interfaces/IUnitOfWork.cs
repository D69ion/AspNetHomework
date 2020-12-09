using System;

namespace AspNetHomework.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с несколькими репозиториями.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IShopRepository ShopRepository { get; }

    }
}
