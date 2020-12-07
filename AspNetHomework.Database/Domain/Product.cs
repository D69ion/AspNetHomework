using AspNetHomework.Database.Domain;
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
        [Required]
        public long Vendor { get; set; }
    }
}
