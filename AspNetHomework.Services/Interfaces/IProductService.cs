using AspNetHomework.Models;
using System.Collections.Generic;

namespace AspNetHomework.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с данными о товарах. 
    /// </summary>
    public interface IProductService
    {
        IEnumerable<ProductDTO> Get();
    }
}
