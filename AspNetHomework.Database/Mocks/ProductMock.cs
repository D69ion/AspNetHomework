using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetHomework.Database.Mocks
{
    /// <summary>
    /// Mock для коллекции сущностей "Товары"
    /// </summary>
    public class ProductMock
    {
        /// <summary>
        /// Получение коллекции сущностей "Товары"
        /// </summary>
        /// <returns>Коллекция сущностей "Товары"</returns>
        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product {Id = 1, Name = "q", Description = "a", Price = 1.0, VendorCode = "00001", Weight = 0.1},
                new Product {Id = 2, Name = "qw", Description = "as", Price = 11.1, VendorCode = "00002", Weight = 0.5},
                new Product {Id = 3, Name = "qwe", Description = "asd", Price = 12.2, VendorCode = "00003", Weight = 1.1}
            };
        }
    }
}
