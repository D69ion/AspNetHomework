using AspNetHomework.Database;
using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Models
{
    /// <summary>
    /// DTO для <see cref="Product"/>.
    /// </summary>
    public class ProductDTO
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        [Required]
        public string VendorCode { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        [Required]
        public double Price { get; set; }

        /// <summary>
        /// Вес в кг.
        /// </summary>
        [Required]
        public double Weight { get; set; }
    }
}
