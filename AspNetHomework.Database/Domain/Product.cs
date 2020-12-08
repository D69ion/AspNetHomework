using AspNetHomework.Database.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Database
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        [Required]
        public string VendorCode { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [StringLength(250)]
        public string Description { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        [Required]
        public double Price { get; set; }

        /// <summary>
        /// Вес в кг.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        public Vendor Vendor { get; set; }

        /// <summary>
        /// Идентификатор поставщика.
        /// </summary>
        public long VendorId { get; set; }

        /// <summary>
        /// Наличие товара в магазинах.
        /// </summary>
        public ICollection<Availability> Availabilities { get; set; }
    }
}
