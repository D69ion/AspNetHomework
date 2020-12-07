using AspNetHomework.Database;
using AspNetHomework.Models.DTO;

namespace AspNetHomework.Models
{
    /// <summary>
    /// DTO для <see cref="Product"/>.
    /// </summary>
    public class ProductDTO : BaseDTO
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        public string VendorCode { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Вес в кг.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        public long Vendor { get; set; }

    }
}
