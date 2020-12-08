using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Database.Domain
{
    /// <summary>
    /// Наличие товара в магазине.
    /// </summary>
    public class Availability : BaseEntityWithLinks<Product, Shop>
    {
        /// <summary>
        /// Кол-во оставшегося товара.
        /// </summary>
        [Required]
        public long Count { get; set; }
    }
}
