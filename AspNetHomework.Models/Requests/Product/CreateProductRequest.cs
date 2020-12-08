using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Models.Requests.Product
{
    /// <summary>
    /// Запрос на создание позиции товара.
    /// </summary>
    public class CreateProductRequest
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
        public long VendorId { get; set; }
    }
}
