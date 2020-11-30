using AspNetHomework.Database.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetHomework.Database.Contexts
{
    /// <summary>
    /// Контекст для работы с данными БД "Магазин продуктов".
    /// </summary>
    public class AspNetHomeworkContext : DbContext
    {
        /// <summary>
        /// Наличие в магазинах.
        /// </summary>
        public DbSet<Availability> Availabilities { get; set; }

        /// <summary>
        /// Товары.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Магазины.
        /// </summary>
        public DbSet<Shop> Shops { get; set; }

        /// <summary>
        /// Поставщики.
        /// </summary>
        public DbSet<Vendor> Vendors { get; set; }

        /// <summary>
        /// Инициализирует экземпляр <see cref="AspNetHomeworkContext"/>.
        /// </summary>
        /// <param name="options">Опции для конфигурации контекста.</param>
        public AspNetHomeworkContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
