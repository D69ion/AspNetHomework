using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Database.Domain
{
    /// <summary>
    /// Наличие товара в магазине.
    /// </summary>
    public class Availability : BaseEntity
    {
        /// <summary>
        /// Магазин.
        /// </summary>
        [Required]
        public long Shop { get; set; }

        /// <summary>
        /// Товар.
        /// </summary>
        [Required]
        public long Product { get; set; }

        /// <summary>
        /// Кол-во оставшегося товара.
        /// </summary>
        [Required]
        public long Count { get; set; }
    }
}
