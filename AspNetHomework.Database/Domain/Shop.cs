using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Database.Domain
{
    /// <summary>
    /// Магазин.
    /// </summary>
    public class Shop : BaseEntity
    {
        /// <summary>
        /// Название магазина.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string ShopName { get; set; }

        /// <summary>
        /// Адрес магазина.
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        /// <summary>
        /// Наличие товара в магазинах.
        /// </summary>
        public ICollection<Availability> Availabilities { get; set; }
    }
}
